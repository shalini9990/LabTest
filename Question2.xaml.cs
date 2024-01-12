using Microsoft.Maui.Controls;
using System.Text.RegularExpressions;

namespace Registerpagge
{
    public partial class Mainpage : ContentPage
    {
        int count = 0;

        public Mainpage()
        {
            InitializeComponent();
        }

        private void PhoneEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            var isValidPhoneNumber = IsValidPhoneNumber(e.NewTextValue);
            InvalidPhoneNumberLabel.IsVisible = !isValidPhoneNumber;
            UpdateRegisterButtonState();
        }

        private void PasswordEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            var isValidPasswordLength = IsValidPasswordLength(e.NewTextValue);
            InvalidPasswordLengthLabel.IsVisible = !isValidPasswordLength;
            UpdateRegisterButtonState();
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            return !string.IsNullOrEmpty(phoneNumber) && Regex.IsMatch(phoneNumber, @"^\d{10}$");
        }

        private bool IsValidPasswordLength(string password)
        {
            return !string.IsNullOrEmpty(password) && password.Length > 5;
        }

        private void UpdateRegisterButtonState()
        {
            RegisterButton.IsEnabled = IsValidPhoneNumber(PhoneEntry.Text) &&
                                       IsValidPasswordLength(PasswordEntry.Text) &&
                                       TermsAndConditionsCheckbox.IsChecked;
        }

        private void RegisterButton_Clicked(object sender, EventArgs e)
        {
            // Add your registration logic here
        }
    }


}

