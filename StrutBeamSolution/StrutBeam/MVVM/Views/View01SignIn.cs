
using Microsoft.EntityFrameworkCore;
using StrutBeam.MVVM.Models;

namespace StrutBeam.MVVM.Views
{
    public partial class View01SignIn : Form
    {
        string dateExpiraction = string.Empty;
        string dateSignIn = string.Empty;
        public View01SignIn()
        {
            InitializeComponent();
        }

        private async void btnSignIn_Click(object sender, EventArgs e)
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
            else
            {
                using (var dbContext = new DataContext())
                {
                    var licence = await dbContext.TabelaLicenca.CountAsync();
                    if (licence == 0)
                    {
                        new View00ErrorMessage("Error", "There is no active license").ShowDialog();
                    }
                    else
                    {
                        var L = await dbContext.TabelaLicenca.OrderByDescending(l => l.Id).FirstOrDefaultAsync();
                        var LostDate = await dbContext.TabelaControlAccess.FirstOrDefaultAsync();

                        if (L is not null && LostDate is not null)
                        {
                            if (!(Convert.ToDateTime(L.ExpiractionDate) >= DateTime.Now) && !(DateTime.Now >= LostDate.DateAccess))
                            {
                                new View00ErrorMessage("Error", "Possible problems: Expired license\nOutdated system date and time").ShowDialog();
                            }
                            else
                            {
                                LostDate.DateAccess = DateTime.Now;
                                dbContext.TabelaControlAccess.Update(LostDate);
                                await dbContext.SaveChangesAsync();

                                var user = await dbContext.TabelaUsuario.FirstOrDefaultAsync(u => u.Username == txtUsername.Text && u.Password == txtPassword.Text);
                                if (user is not null)
                                {
                                    new View04Menu(user).Show();
                                    this.Hide();
                                }
                                else
                                {
                                    new View00ErrorMessage("Error", "Incorrect username or password").ShowDialog();
                                }
                            }

                        }
                    }
                }
            }
        }

        public string ngrok = string.Empty;
        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new View03SignUp(this).Show();
            this.Hide();
        }

        private async void linkActivate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string pathFile = openFileDialog.FileName;

                if (Path.Exists(pathFile))
                {
                    string customerId = string.Empty;
                    int month = 0;
                    string code = string.Empty;
                    string license = string.Empty;

                    using (BinaryReader br = new(File.Open(pathFile, FileMode.Open)))
                    {
                        while (br.BaseStream.Position != br.BaseStream.Length)
                        {
                            customerId = br.ReadString();
                            month = br.ReadInt32();
                            code = br.ReadString();
                            license = br.ReadString();
                        }
                    }
                    if (!await VerificarCliente(customerId))
                    {
                        new View00ErrorMessage("Error", "This license was not generated for this client machine").ShowDialog();
                    }
                    else if (await VerificarCodigo(code))
                    {
                        new View00ErrorMessage("Error", "This license has already been used on this client machine").ShowDialog();
                    }
                    else
                    {
                        using (var dbContext = new DataContext())
                        {
                            if (await dbContext.TabelaLicenca.CountAsync() != 0)
                            {
                                var licenca = await dbContext.TabelaLicenca.OrderByDescending(x => x.Id).FirstOrDefaultAsync();
                                if (licenca != null)
                                {
                                    TimeSpan diaRestante = Convert.ToDateTime(licenca.ExpiractionDate) - DateTime.Now;
                                    if (Convert.ToInt32(diaRestante.TotalDays) >= 0)
                                    {
                                        int dia = (month * 30) + Convert.ToInt32(diaRestante.TotalDays);
                                        var newLicense = new Licenses()
                                        {
                                            License = license,
                                            Month = month,
                                            Code = code,
                                            ActivationDate = DateTime.Now,
                                            ExpiractionDate = DateTime.Now.AddDays(dia),
                                        };
                                        try
                                        {
                                            await dbContext.TabelaLicenca.AddAsync(newLicense);
                                            if (await dbContext.SaveChangesAsync() == 1)
                                            {
                                                new View00ErrorMessage("Notification", "License activated successfully").ShowDialog();
                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show(ex.ToString());
                                        }
                                    }
                                    else
                                    {
                                        var newLicense = new Licenses()
                                        {
                                            ActivationDate = DateTime.Now,
                                            ExpiractionDate = DateTime.Now.AddDays((month * 30)),
                                            Code = code,
                                            Month = month,
                                            License = license
                                        };
                                        await dbContext.TabelaLicenca.AddAsync(newLicense);
                                        if (await dbContext.SaveChangesAsync() == 1)
                                        {
                                            new View00ErrorMessage("Notification", "License activated successfully").ShowDialog();
                                        }
                                    }

                                }
                            }
                            else
                            {
                                var newLicense = new Licenses()
                                {
                                    ActivationDate = DateTime.Now,
                                    ExpiractionDate = DateTime.Now.AddDays((month * 30)),
                                    Code = code,
                                    Month = month,
                                    License = license
                                };
                                await dbContext.TabelaLicenca.AddAsync(newLicense);
                                if (await dbContext.SaveChangesAsync() == 1)
                                {
                                    new View00ErrorMessage("Notification", "License activated successfully").ShowDialog();
                                }
                            }
                        }
                    }
                }
            }
            openFileDialog.Dispose();
        }

        private async Task<bool> VerificarCliente(string id)
        {
            bool response = false;
            using (var dbContext = new DataContext())
            {
                var cliente = await dbContext.TabelaClienteId.FirstOrDefaultAsync();
                if (cliente is not null)
                {
                    if (cliente.CustomerId == id)
                    {
                        response = true;
                    }
                }
            }
            return response;
        }

        private async Task<bool> VerificarCodigo(string codigo)
        {
            bool response = false;
            using (var dbContext = new DataContext())
            {
                var codigoLicenca = await dbContext.TabelaLicenca.OrderByDescending(i => i.Id).FirstOrDefaultAsync(c => c.Code == codigo);

                if (codigoLicenca is not null)
                {
                    response = true;
                }
            }
            return response;
        }
        private void View01SignIn_Load(object sender, EventArgs e)
        {

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            var dbContext = new DataContext();
            //dbContext.Database.EnsureDeleted();
            dbContext.Database.EnsureCreated();
            if (dbContext.TabelaClienteId.Count() == 0)
            {
                var clienteId = new CustomerIdentification() { CustomerId = Guid.NewGuid().ToString("N") };
                dbContext.TabelaClienteId.Add(clienteId);
                var access = new ControlAccess() { DateAccess = DateTime.Now };
                dbContext.TabelaControlAccess.Add(access);
                dbContext.SaveChanges();
            }

            dbContext.Dispose();
        }

        private void View01SignIn_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new View10ClienteId().ShowDialog();
        }
    }
}
