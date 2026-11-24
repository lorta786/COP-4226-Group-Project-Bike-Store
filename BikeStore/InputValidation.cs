
using System.Windows.Forms;

namespace BikeStore
{
    internal static class InputValidation
    {
        public static bool IsRequired(TextBox textBox, string fieldName)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                MessageBox.Show(
                    fieldName + " is required.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                textBox.Focus();
                return false;
            }

            return true;
        }

        public static bool HasMinLength(
            TextBox textBox, string fieldName, int minLength)
        {
            if (textBox.Text.Length < minLength)
            {
                MessageBox.Show(
                    fieldName + " must contain at least " +
                    minLength + " characters.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                textBox.Focus();
                return false;
            }

            return true;
        }

        public static void ClearInputs(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBoxBase textBox)
                    textBox.Clear();
                else if (control is ComboBox comboBox)
                    comboBox.SelectedIndex = -1;
                else if (control is CheckBox checkBox)
                    checkBox.Checked = false;
                else if (control is RadioButton radioButton)
                    radioButton.Checked = false;

                if (control.HasChildren)
                    ClearInputs(control);
            }
        }
    }
}

