using System;
using System.Collections.Generic;
using System.Text;

namespace Notification
{
    public class IsNotNumber:IValidation
    {
        public string errorMessage { get; set; }
        public string value { get; set; }
        /// <summary>
        /// Faz a validacao da string de acordo com valor injetado no construtor. Verifica se o mesmo nao e numerico.
        /// </summary>
        /// <param name="value">Valor a ser comparado</param>
        public IsNotNumber(string value)
        {
            this.value = value;
            errorMessage = "Valor nao pode ser numerico.";
        }
        private bool CheckValidation(string value)
        {
            if (Int32.TryParse(value, out int result))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool check()
        {
            return CheckValidation(value);
        }
    }
}
