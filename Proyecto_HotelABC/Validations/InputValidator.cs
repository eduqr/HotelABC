﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Proyecto_HotelABC.Validations
{
    public class InputValidator
    {
        public static bool IsObjectNull(object obj)
        {
            return obj == null;     // Retorna true si se cumple que obj sea null
        }

        public static bool IsStringEmpty(string str)
        {
            return string.IsNullOrWhiteSpace(str);  // Retorna true si hay un string vacío
        }

        public static bool IsNumber(string text)
        {
            foreach (char c in text)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }

        public static bool IsValidEmail(string email)
        {
            return email.Contains("@");     // Retorna true si email contiene "@"
        }

        public static bool IsNumericTextBox(TextBox textBox)
        {
            if (!int.TryParse(textBox.Text, out _))
            {

                textBox.Text = string.Empty;
                textBox.Focus();
                return false;
            }
            return true;
        }
        public static bool AreTextBoxesEmpty(IEnumerable<TextBox> textBoxes)
        {
            foreach (var textBox in textBoxes)
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
