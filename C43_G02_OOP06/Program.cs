namespace C43_G02_OOP06
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Part 01

            // Question 1
            // b) To define a blueprint for a class

            // Question 2
            // a) private

            // Question 3
            // b) No

            // Question 4
            // b) Yes, interfaces can inherit from multiple interfaces

            // Question 5
            // d) implements

            // Question 6
            // b) No

            // Question 7
            // b) No, all members are implicitly public

            // Question 8
            // a) To hide the interface members from outside access

            // Question 9
            // b) No, interfaces cannot have constructors

            // Question 10
            // c) By separating interface names with commas



            #endregion


            #region Part 02

            #region Question 1
            //ICircle circle = new Circle(5);
            //IRectangle rectangle = new Rectangle(4, 6);

            //circle.DisplayShapeInfo();
            //rectangle.DisplayShapeInfo();
            #endregion


            #region Question 2
            //IAuthenticationService authService = new BasicAuthenticationService();

            //string username = "user1";
            //string password = "password123";

            //bool isAuthenticated = authService.AuthenticateUser(username, password);
            //Console.WriteLine($"Is user authenticated? {isAuthenticated}");

            //string role = "admin";
            //bool isAuthorized = authService.AuthorizeUser(username, role);
            //Console.WriteLine($"Is user authorized for role '{role}'? {isAuthorized}");
            #endregion


            #region Question 3
            INotificationService emailService = new EmailNotificationService();
            INotificationService smsService = new SmsNotificationService();
            INotificationService pushService = new PushNotificationService();

            string recipient = "joeesherif@gmail.com";
            string message = "This is a test notification";

            emailService.SendNotification(recipient, message);
            smsService.SendNotification(recipient, message);
            pushService.SendNotification(recipient, message);
            #endregion

            #endregion
        }
    }
}