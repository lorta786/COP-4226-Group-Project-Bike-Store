using System;
using System.Windows.Forms;

namespace BikeStore
{
    /// <summary>
    /// Generic routines for validating input and clearing a screen.
    /// Shared by every form. Each method shows a message and moves the
    /// cursor to the bad field when the check fails.
    /// </summary>
    public static class InputValidation
    {
        private static string title = "Entry Error";

        public static string Title
        {
            get { return title; }
            set { title = value; }
        }

        // The control must not be empty.
        public static bool IsPresent(Control control, string name)
        {
            if (control.Text.Trim() == "")
            {
                MessageBox.Show(name + " is required.", Title);
                control.Focus();
                return false;
            }
            return true;
        }

        // Same check as IsPresent, used by the login and create-account forms.
        public static bool IsRequired(Control control, string name)
        {
            return IsPresent(control, name);
        }

        // The text must be at least minLength characters long (for example, a password).
        public static bool HasMinLength(Control control, string name, int minLength)
        {
            if (control.Text.Length < minLength)
            {
                MessageBox.Show(name + " must be at least " + minLength + " characters.", Title);
                control.Focus();
                return false;
            }
            return true;
        }

        // A combo box must have an item selected.
        public static bool IsSelected(ComboBox comboBox, string name)
        {
            if (comboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a " + name + ".", Title);
                comboBox.Focus();
                return false;
            }
            return true;
        }

        // The text must be a decimal number.
        public static bool IsDecimal(TextBox textBox, string name)
        {
            decimal number;
            if (!Decimal.TryParse(textBox.Text, out number))
            {
                MessageBox.Show(name + " must be a number.", Title);
                textBox.Focus();
                return false;
            }
            return true;
        }

        // The text must be a whole number.
        public static bool IsInt32(TextBox textBox, string name)
        {
            int number;
            if (!Int32.TryParse(textBox.Text, out number))
            {
                MessageBox.Show(name + " must be a whole number.", Title);
                textBox.Focus();
                return false;
            }
            return true;
        }

        // The number must be between min and max. Call IsDecimal first.
        public static bool IsWithinRange(TextBox textBox, string name, decimal min, decimal max)
        {
            decimal number = Convert.ToDecimal(textBox.Text);
            if (number < min || number > max)
            {
                MessageBox.Show(name + " must be between " + min + " and " + max + ".", Title);
                textBox.Focus();
                return false;
            }
            return true;
        }

        // If an email was typed, it must look like name@domain.com.
        public static bool IsValidEmail(TextBox textBox, string name)
        {
            string email = textBox.Text.Trim();
            if (email == "")
                return true;   // optional field

            int at = email.IndexOf('@');
            int dot = email.LastIndexOf('.');
            if (at < 1 || dot < at + 2 || dot == email.Length - 1 || email.Contains(" "))
            {
                MessageBox.Show(name + " must be a valid email address, like name@example.com.", Title);
                textBox.Focus();
                return false;
            }
            return true;
        }

        // If anything was typed in a masked box, the whole mask must be filled.
        public static bool IsMaskComplete(MaskedTextBox maskedTextBox, string name)
        {
            bool anyDigits = false;
            foreach (char c in maskedTextBox.Text)
            {
                if (Char.IsDigit(c))
                {
                    anyDigits = true;
                    break;
                }
            }

            if (anyDigits && !maskedTextBox.MaskCompleted)
            {
                MessageBox.Show(name + " is incomplete.", Title);
                maskedTextBox.Focus();
                return false;
            }
            return true;
        }

        // The end date must not be before the start date.
        public static bool IsDateOnOrAfter(DateTimePicker endPicker, DateTimePicker startPicker, string endName, string startName)
        {
            if (endPicker.Value.Date < startPicker.Value.Date)
            {
                MessageBox.Show(endName + " can't be before " + startName + ".", Title);
                endPicker.Focus();
                return false;
            }
            return true;
        }

        // Clears every text box, masked box, combo box and date picker on the
        // form, including controls inside group boxes and panels.
        public static void ClearScreen(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox)
                    ((TextBox)control).Clear();
                else if (control is MaskedTextBox)
                    ((MaskedTextBox)control).Clear();
                else if (control is ComboBox)
                    ((ComboBox)control).SelectedIndex = -1;
                else if (control is DateTimePicker)
                {
                    DateTimePicker picker = (DateTimePicker)control;
                    picker.Value = DateTime.Today;
                    if (picker.ShowCheckBox)
                        picker.Checked = false;
                }

                if (control.HasChildren)
                    ClearScreen(control);
            }
        }
    }
}
