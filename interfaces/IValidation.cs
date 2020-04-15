namespace Notification
{
    public interface IValidation
    {
        public string errorMessage { get; set; }
        public bool check();
    }    
}