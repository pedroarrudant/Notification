using System;

namespace Notification
{
    public class isNullorWhiteSpace:IValidation
    {
        public string errorMessage { get; set; }
        public string value { get; set; }
        public isNullorWhiteSpace(string value)
        {
            this.value = value;
        }
        private bool checkValidation(string value)
        {
            return !String.IsNullOrWhiteSpace(value);
        }
        public bool check()
        {
            return checkValidation(value);
        }
    }
}