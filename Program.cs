using System;
using System.Collections;
using System.Collections.Generic;

namespace Notification
{
    static class Program
    {
        static void Main(string[] args)
        {
            var validationIsBlank = new IsNullorWhiteSpace("");
            var validationIsNumber = new IsNumber("s");
            var validationIsNotNumber = new IsNotNumber("123");
            var validations = new List<IValidation>
            {
                validationIsBlank, validationIsNumber, validationIsNotNumber
            };

            var notValidations = new NotificationValidations(validations);

            notValidations.runValidations();

            if (notValidations.HasErrors())
            {
                Console.WriteLine("Existem erros: " + notValidations.HasErrors());

                foreach (NotificationError item in notValidations._errors)
                {
                    Console.WriteLine("Tipo do erro: " + item.message);
                }
            }
            Console.ReadKey();
        }
    }
}
