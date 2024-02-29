using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CodeChum
{
    public partial class Form1 : Form
    {
        // Define the valid username-password pairs
        private Dictionary<string, string> validCredentials = new Dictionary<string, string>
        {
            {"admin", "admin12345" },
            {"user1", "password123" },
            {"student1", "PF101@2024" }
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the entered username and password
            string enteredUsername = usernameTextBox.Text;
            string enteredPassword = passwordTextBox.Text;

            // Check if the entered credentials match any valid pair
            if (validCredentials.ContainsKey(enteredUsername) && validCredentials[enteredUsername] == enteredPassword)
            {
                resultLabel.Text = "Login Successful";
            }
            else
            {
                resultLabel.Text = "Invalid username or password.";
            }
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
