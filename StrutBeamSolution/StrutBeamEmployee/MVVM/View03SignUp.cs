using StrutBeam.MVVM.ViewModels;
using StrutBeamEmployee.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrutBeamEmployee.MVVM
{
    public partial class View03SignUp : Form
    {
        private string uri = string.Empty;
        public View03SignUp(string ngrok)
        {
            InitializeComponent();
            uri = ngrok;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var client = new Employee()
            {
                Username = textBox1.Text,
                Password = textBox2.Text,
                Email = textBox3.Text,
                Enable = true
            };
            if (string.IsNullOrEmpty(client.Username))
            {
                new View00ErrorMessage("Error", "Enter your username").ShowDialog();
            }
            else if (string.IsNullOrEmpty(client.Password))
            {
                new View00ErrorMessage("Notification", "Enter your password").ShowDialog();
            }
            else if (string.IsNullOrEmpty(client.Email))
            {
                new View00ErrorMessage("Notification", "Enter your email address").ShowDialog();
            }
            else
            {
                this.Enabled = false;
                var request = await new ViewModelSignUp(client, uri).CreateEmployee();
                new View00ErrorMessage("Notification", request).ShowDialog();
                this.Enabled = true;
                this.Close();
            }
        }
    }
}
