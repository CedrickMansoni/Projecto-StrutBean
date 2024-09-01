using Microsoft.EntityFrameworkCore;
using StrutBeam.MVVM.Models;

namespace StrutBeam.MVVM.Views
{
    public partial class View03SignUp : Form
    {
        View01SignIn Janela;
        public View03SignUp(View01SignIn view01SignIn)
        {
            InitializeComponent();
            Janela = view01SignIn;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var client = new Clients()
            {
                Username = textBox1.Text,
                Password = textBox2.Text,
            };
            if (string.IsNullOrEmpty(client.Username))
            {
                new View00ErrorMessage("Error", "Enter your username").ShowDialog();
            }
            else if (string.IsNullOrEmpty(client.Password))
            {
                new View00ErrorMessage("Notification", "Enter your password").ShowDialog();
            }
            else
            {
                this.Enabled = false;
                using (var dbContext = new DataContext())
                {
                    var user = await dbContext.TabelaUsuario.FirstOrDefaultAsync(u => u.Username == client.Username);
                    if (user is not null)
                    {
                        new View00ErrorMessage("Notification", "There is already an account registered on this machine").ShowDialog();
                    }
                    else
                    {
                        await dbContext.TabelaUsuario.AddAsync(client);
                        if (await dbContext.SaveChangesAsync() == 1)
                        {
                            new View00ErrorMessage("Notification", "account created successfully").ShowDialog();
                            textBox1.Clear();
                            textBox2.Clear();
                        }
                    }
                }                    
                this.Enabled = true;
            }
        }

        private void View03SignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Janela.Show();
        }
    }
}
