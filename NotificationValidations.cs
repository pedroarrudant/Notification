using System;
using System.Collections;
using System.Collections.Generic;

namespace Notification
{
    public class NotificationValidations
    {
        private List<IValidation> validations { get; set; }
        public List<NotificationError> _errors { get; private set; }
        public NotificationValidations(List<IValidation> validations)
        {
            this.validations = validations;
        }
        public void runValidations()
        {
            _errors = new List<NotificationError>();

            foreach (var item in validations)
            {
                if (!item.check())
                {
                    NotificationError error = new NotificationError(item.errorMessage);
                    _errors.Add(error);
                }
            }
        }
        public bool HasErrors()
        {
            if (0 != _errors.Count)
                return true;
            else
                return true;
        }
    }
}