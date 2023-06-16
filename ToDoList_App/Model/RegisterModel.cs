namespace ToDoList_App
{
    public class RegisterModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Name { get; set; }

        public Result PerformAction()
        {
            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(ConfirmPassword) || string.IsNullOrEmpty(Name) || ConfirmPassword != Password)
                return new Result
                {
                    IsValidationError = true,
                    Message = "Enter valid details"
                };
            return new Result
            {
                IsSuccess = true,
                Message = "User regitered successfully"
            };
        }
    }
}