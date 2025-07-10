using Demo.BusinessLogic.DTOs.Departments;
using Demo.BusinessLogic.DTOs.Employees;
using Demo.BusinessLogic.Services.Employees;
using Demo.DataAccess.Entities.Common.Enums;
using Demo.Presentation.ViewModels.Departments;
using Demo.Presentation.ViewModels.Employees;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Presentation.Controllers
{
    public class EmployeeController : Controller
    {
        #region Services

        private readonly IEmployeeService _employeeService;
        private readonly ILogger<EmployeeController> _logger;
        private readonly IWebHostEnvironment _env;

        public EmployeeController(IEmployeeService employeeService, ILogger<EmployeeController> logger, IWebHostEnvironment env)
        {
            _employeeService = employeeService;
            _logger = logger;
            _env = env;
        }
        #endregion

        #region Index

        [HttpGet]
        public IActionResult Index()
        {
            var employees = _employeeService.GetAllEmployees();
            return View(employees);
        }
        #endregion

        #region Create

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken] // Action filter
        public IActionResult Create(CreateEmployeeDTO createEmployeeDTO)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var result = _employeeService.CreateEmployee(createEmployeeDTO);
                    if (result.HasValue)
                    {
                        return RedirectToAction("Index");
                    }
                    ModelState.AddModelError("", "Failed to create employee.");
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "An error occurred while creating the employee.");
                    if (_env.IsDevelopment())
                    {
                        ModelState.AddModelError("", ex.Message);
                    }
                    else
                    {
                        ModelState.AddModelError("", "An unexpected error occurred. Please try again later.");
                    }
                }
            }
            return View(createEmployeeDTO);
        }
        #endregion

        #region Details

        [HttpGet]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return BadRequest("Employee ID is required.");
            }
            var employee = _employeeService.GetEmployeeById(id.Value);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        #endregion
        
        #region Edit

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return BadRequest("Employee ID is required.");
            }
            var employee = _employeeService.GetEmployeeById(id.Value);
            if (employee == null)
            {
                return NotFound();
            }

            return View(new EmployeeToUpdateDto()
            {
                EmployeeType = Enum.TryParse<EmployeeType>(employee.EmployeeType, out var empType) ? empType : default,
                Gender = Enum.TryParse<Gender>(employee.Gender, out var gender) ? gender : default,
                Name = employee.Name,
                Age = employee.Age,
                Address = employee.Address,
                Salary = employee.Salary,
                IsActive = employee.IsActive,
                Email = employee.Email,
                PhoneNumber = employee.PhoneNumber,
                HiringDate = employee.HiringDate,
                Id = id.Value
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, EmployeeToUpdateDto employeeDto)
        {
            if (!ModelState.IsValid)
            {
                return View(employeeDto);
            }
            var message = string.Empty;
            try
            {
                var result = _employeeService.Update(employeeDto);
                if (result.HasValue)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    message = "Failed to update Employee.";
                }
            }
            catch (Exception ex)
            {
                message = _env.IsDevelopment() ? ex.Message : "An unexpected error occurred. Please try again later.";
            }
            return View(employeeDto);
        }
        #endregion

        #region Delete

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return BadRequest("Employee ID is required.");
            }
            var employee = _employeeService.GetEmployeeById(id.Value);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            try
            {
                var result = _employeeService.DeleteEmployee(id);
                if (result)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    TempData["ErrorMessage"] = "Failed to delete employee. The employee may not exist.";
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while deleting the employee.");
                var message = _env.IsDevelopment() ? ex.Message : "An unexpected error occurred. Please try again later.";
                TempData["ErrorMessage"] = message;
            }

            return RedirectToAction(nameof(Index));
        } 
        #endregion
    }
}