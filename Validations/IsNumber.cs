using System;
using System.Collections.Generic;
using System.Text;

namespace Notification
{
    public class IsNumber:IValidation
    {
        public string errorMessage { get; set; }
        public string value { get; set; }
        /// <summary>
        /// Faz a validacao da string de acordo com valor injetado no construtor. Verifica se o mesmo e numerico.
        /// </summary>
        /// <param name="value">Valor a ser comparado</param>
        public IsNumber(string value)
        {
            this.value = value;
            errorMessage = "Valor deve ser numerico.";
        }
        private bool CheckValidation(string value)
        {
            if (Int32.TryParse(value, out int result))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool check()
        {
            return CheckValidation(value);
        }
    }
}
