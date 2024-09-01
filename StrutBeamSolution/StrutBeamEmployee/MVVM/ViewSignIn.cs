using StrutBeam.MVVM.ViewModels;
using StrutBeamEmployee.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrutBeamEmployee.MVVM
{
    public partial class ViewSignIn : Form
    {
        public ViewSignIn()
        {
            InitializeComponent();
        }
        public string ngrok = string.Empty;
        private async void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                ngrok = txtHOST.Text != string.Empty ? txtHOST.Text : "d848-105-172-139-67";
            }
            catch
            {
                //new View00ErrorMessage("Error", "Solicite um código").ShowDialog();
            }
            if (await TestConnection($"{ngrok}"))
            {
                new View03SignUp(ngrok).ShowDialog();
            }
            else
            {
                new View00ErrorMessage("Error", "Request a new server access code").ShowDialog();
            }
        }
        public async Task<bool> TestConnection(string HostNGROK)
        {
            try
            {
                using (HttpClient clientHttp = new HttpClient())
                {
                    using (var response = await clientHttp.GetAsync($"https://{HostNGROK}.ngrok-free.app/api/ConnectionNGROK"))
                    {
                        if (response.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            return true;
                        }
                    }
                }
            }
            catch
            {

            }
            return false;
        }

        private async void linkActivate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                ngrok = txtHOST.Text != string.Empty ? txtHOST.Text : "c90b-197-234-115-34";
            }
            catch
            {
                //new View00ErrorMessage("Error", "Solicite um código").ShowDialog();
            }
            if (await TestConnection($"{ngrok}"))
            {
                new View02Activate(ngrok).ShowDialog();
            }
            else
            {
                new View00ErrorMessage("Error", "Request a new server access code").ShowDialog();
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                new View00ErrorMessage("Error", "Enter your username").ShowDialog();
                txtUsername.Focus();
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                new View00ErrorMessage("Error", "Enter your password").ShowDialog();
                txtPassword.Focus();
            }
            else if (string.IsNullOrEmpty(txtHOST.Text)) 
            {
                new View00ErrorMessage("Error", "Enter the server access code").ShowDialog();
                txtHOST.Focus();
            }
            else
            {
                _ = SignIn();
            }
        }

        private async Task SignIn()
        {     
            try
            {
                var client = new Employee()
                {
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                };

                var request = await new ViewModelSignUp(client, txtHOST.Text).SelectEmployee();

                if (request != 0)
                {
                    new ViewMenu(txtHOST.Text).Show();
                    this.Hide();
                }
                else
                {
                    new View00ErrorMessage("Error", "Incorrect username or password").ShowDialog();
                }
            }
            catch
            {
                
            }
        }
    }
}
