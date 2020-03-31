using System;
using System.Collections;
using System.Collections.Generic;

namespace Notification
{
    class Program
    {
        static void Main(string[] args)
        {
            var validationIsBlank = new isNullorWhiteSpace("");
            var validations = new List<IValidation>();
            validations.Add(validationIsBlank);

            var notValidations = new NotificationValidations(validations);

            notValidations.runValidations();

            Console.WriteLine(notValidations.HasErrors());
        }
    }
}
