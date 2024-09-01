
using Microsoft.EntityFrameworkCore;

namespace StrutBeam.MVVM.Views
{
    public partial class View08System : Form
    {
        string userName = string.Empty;
        string dateExpiraction = string.Empty;
        string dateActivation = string.Empty;
        public View08System(Models.Clients _user)
        {
            InitializeComponent();
            userName = _user.Username;             
        }

        private async void View08System_Load(object sender, EventArgs e)
        {
            PainelCentral.Location = new System.Drawing.Point((this.Width / 2) - PainelCentral.Width / 2, (this.Height / 2) - PainelCentral.Height / 2);
            try
            {
                using (var dbContext = new DataContext())
                {
                    var license = await dbContext.TabelaLicenca.OrderByDescending(i => i.Id).FirstOrDefaultAsync();
                    if (license != null)
                    {
                        dateActivation = license.ActivationDate.ToString();
                        dateExpiraction = license.ExpiractionDate.ToString();
                    }
                }

                lblUser.Text = userName;
                lblDate1.Text = Convert.ToDateTime(dateActivation).Date.ToString("dd-MM-yyyy");
                lblDate2.Text = Convert.ToDateTime(dateExpiraction).Date.ToString("dd-MM-yyyy"); 
                lblTime.Text = (Convert.ToDateTime(dateExpiraction) - Convert.ToDateTime(dateActivation)).ToString("dd");                
            }
            catch
            {
                //new View00ErrorMessage("Error", "To use the system it is necessary to activate the license.").ShowDialog();
            }
        }
    }
}
