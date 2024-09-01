using Microsoft.EntityFrameworkCore;

namespace LicenseGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            var dbContext = new DataContext();
            //dbContext.Database.EnsureDeleted();
            dbContext.Database.EnsureCreated();
            dbContext.Dispose();
        }

        private async void btnGenerator_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCustomerId.Text))
            {
                MessageBox.Show("Insert the customer id");
            }else if (string.IsNullOrEmpty(txtMonths.Text))
            {
                MessageBox.Show("Enter the license period in months");
            }
            else
            {
                CriarDirectorio("c:\\MyLicense");
                string pathFile = Path.Combine("c:\\MyLicense", $"{DateTime.Now.Date.ToString("ddMMyyyy")}-{Guid.NewGuid().ToString("N")}.bin");

                string newCode = string.Empty;                

                using (var dbContext = new DataContext())
                {
                    newCode = Guid.NewGuid().ToString("N");

                    while (await dbContext.TabelaCodigo.FirstOrDefaultAsync(c => c.Codigo == newCode) is not null)
                    {
                        newCode = Guid.NewGuid().ToString("N");
                    }

                    var Code = new CodigoGerado()
                    {
                        Codigo = newCode,
                    };
                    await dbContext.TabelaCodigo.AddAsync(Code);
                    await dbContext.SaveChangesAsync();

                    using (BinaryWriter bw = new(File.Open(pathFile, FileMode.Create)))
                    {
                        string customerId = txtCustomerId.Text;
                        int month = Convert.ToInt32(txtMonths.Text);
                        string code = newCode;
                        string License = Guid.NewGuid().ToString("N");

                        bw.Write(customerId);
                        bw.Write(month);
                        bw.Write(code);
                        bw.Write(License);
                    }

                    MessageBox.Show($"License created successfully.\n{pathFile}");
                    txtCustomerId.Clear();
                    txtMonths.Clear();
                }
            }
        }

        private void CriarDirectorio(string caminho)
        {
            try
            {
                Directory.CreateDirectory(caminho);
            }
            catch
            {

            }
        }
    }
}
