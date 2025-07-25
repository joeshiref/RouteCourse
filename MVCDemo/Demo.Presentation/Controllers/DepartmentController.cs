﻿using Demo.BusinessLogic.DTOs;
using Demo.BusinessLogic.DTOs.Departments;
using Demo.BusinessLogic.Services.Departments;
using Demo.DataAccess.Repositories;
using Demo.Presentation.ViewModels.Departments;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Presentation.Controllers
{
    public class DepartmentController : Controller
    {
        #region Services
        private readonly IDepartmentService _departmentService;
        private readonly ILogger<DepartmentController> _logger;
        private readonly IWebHostEnvironment _env;

        public DepartmentController(IDepartmentService departmentService, ILogger<DepartmentController> logger, IWebHostEnvironment env)
        {
            _departmentService = departmentService;
            _logger = logger;
            _env = env;
        } 
        #endregion

        #region Index
        [HttpGet]
        public IActionResult Index()
        {
            var departments = _departmentService.GetAllDepartments();
            return View(departments);
        }
        #endregion

        #region Create

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(DepartmentViewModel departmentVM)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var result = _departmentService.CreateDepartment(new CreateDepartmentDTO()
                    {
                        Name = departmentVM.Name,
                        Code = departmentVM.Code,
                        Description = departmentVM.Description,
                        CreationDate = departmentVM.CreationDate
                    });
                    if (result.HasValue)
                    {
                        return RedirectToAction("Index");
                    }
                    ModelState.AddModelError("", "Failed to create department.");
                }
                catch (Exception ex)
                {
                    // Log the exception
                    _logger.LogError(ex, "An error occurred while creating the department.");
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
            return View(departmentVM);
        }
        #endregion

        #region Edit

        [HttpGet]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return BadRequest("Department ID is required.");
            }
            var department = _departmentService.GetDepartmentByID(id.Value);
            if (department == null)
            {
                return NotFound();
            }
            return View(department);
        }


        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return BadRequest("Department ID is required.");
            }
            var department = _departmentService.GetDepartmentByID(id.Value);
            if (department == null)
            {
                return NotFound();
            }

            return View(new DepartmentViewModel()
            {
                Code = department.Code,
                Description = department.Description,
                CreationDate = department.DateOfCreation,
                Name = department.Name
            });
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, DepartmentViewModel departmentVM)
        {
            if (!ModelState.IsValid)
            {
                return View(departmentVM);
            }
            var message = string.Empty;
            try
            {
                var result = _departmentService.Update(new DepartmentToUpdateDto()
                {
                    Id = id,
                    Name = departmentVM.Name,
                    Code = departmentVM.Code,
                    Description = departmentVM.Description,
                    CreationDate = departmentVM.CreationDate
                });
                if (result.HasValue)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    message = "Failed to update department.";
                }
            }
            catch (Exception ex)
            {
                message = _env.IsDevelopment() ? ex.Message : "An unexpected error occurred. Please try again later.";
            }
            return View(departmentVM);
        }

        #endregion

        #region Delete

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return BadRequest("Department ID is required.");
            }
            var department = _departmentService.GetDepartmentByID(id.Value);
            if (department == null)
            {
                return NotFound();
            }
            return View(department);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            var result = _departmentService.DeleteDepartment(id);
            var message = string.Empty;
            try
            {
                if (result.HasValue)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    message = "Failed to delete department.";
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                message = _env.IsDevelopment() ? ex.Message : "An unexpected error occurred. Please try again later.";
            }
            ModelState.AddModelError("", message);
            return View(nameof(Index));
        } 
        #endregion

    }
}
