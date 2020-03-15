using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Controls;

namespace LogIn_WPF
{
    public class PassWordCommand : ICommand
    {
        public string Password { get; set; }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            PasswordBox boxpass = (PasswordBox)parameter;
            Password = boxpass.Password;

            //Created an if statement to ensure the correct password was inputted
            //if true the below will execute
            if(Password == "microsoft")
            {
                System.Windows.MessageBox.Show("You have gained access");
            }
            //if false the below will be executed
            else
            {
                System.Windows.MessageBox.Show("You have been denied. Please try again");
            }
        }
    }
}
