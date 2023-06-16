namespace ToDoList_App
{
    public class Result
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public bool IsValidationError { get; set; }
        public bool IsTokenError { get; set; }
    }
}