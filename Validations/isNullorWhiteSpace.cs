using System;

namespace Notification
{
    public class IsNullorWhiteSpace:IValidation
    {
        public string errorMessage { get; set; }
        public string value { get; set; }
        /// <summary>
        /// Faz a validacao da string de acordo com valor injetado no construtor. Verifica se o valor esta em branco.
        /// </summary>
        /// <param name="value">Valor a ser comparado</param>
        public IsNullorWhiteSpace(string value)
        {
            this.value = value;
            errorMessage = "String nula ou em branco.";
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