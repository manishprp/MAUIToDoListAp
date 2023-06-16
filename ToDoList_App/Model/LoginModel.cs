namespace ToDoList_App
{
    public class LoginModel
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public Result PerformAction()
        {
            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
                return new Result
                {
                    IsValidationError = true,
                    Message = "Enter correct values"
                };
            return new Result
            {
                IsSuccess = true,
                IsValidationError = false,
                Message = "Loggged in successfully"
            };
            //PerformApicall for
        }
    }
}