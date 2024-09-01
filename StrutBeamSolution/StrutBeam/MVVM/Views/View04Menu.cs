using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrutBeam.MVVM.Views
{
    public partial class View04Menu : Form
    {
        Models.Clients _user;
        public View04Menu(Models.Clients user)
        {
            InitializeComponent();
            _user = user;
        }

        private async void View04Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            using (var dbContext = new DataContext())
            {
                var LostDate = await dbContext.TabelaControlAccess.FirstOrDefaultAsync();
                if (LostDate != null)
                {
                    if (DateTime.Now >= LostDate.DateAccess)
                    {
                        LostDate.DateAccess = DateTime.Now;
                        dbContext.TabelaControlAccess.Update(LostDate);
                        await dbContext.SaveChangesAsync();
                    }
                }
            }
            Application.Exit();
        }

        private void View04Menu_Load(object sender, EventArgs e)
        {
            PainelMenu.Location = new Point(7, (PainelEsquerdo.Height / 2) - (PainelMenu.Height / 2));
        }

        private void View04Menu_Resize(object sender, EventArgs e)
        {
            PainelMenu.Location = new Point(7, (PainelEsquerdo.Height / 2) - (PainelMenu.Height / 2));
        }

        #region Formulários externos
        // codigo para trazer formularios externos
        Form? FormExterno = null;
        private void AbrirNovaJanela(Form janelas)
        {
            if (FormExterno != null)
            {
                FormExterno.Close();
                FormExterno = janelas as Form;
                FormExterno.TopLevel = false;
                FormExterno.Dock = DockStyle.Fill;
                this.PainelFormsExternos.Controls.Add(FormExterno);
                this.PainelFormsExternos.Tag = FormExterno;
                FormExterno.Size = new Size(PainelFormsExternos.Width, PainelFormsExternos.Height);
                PainelFormsExternos.BringToFront();
                FormExterno.Show();
            }
            else
            {
                FormExterno = janelas as Form;
                FormExterno.TopLevel = false;
                FormExterno.Dock = DockStyle.Fill;
                this.PainelFormsExternos.Controls.Add(FormExterno);
                this.PainelFormsExternos.Tag = FormExterno;
                FormExterno.Size = new Size(PainelFormsExternos.Width, PainelFormsExternos.Height);
                PainelFormsExternos.BringToFront();
                FormExterno.Show();

            }
        }
        private void FecharNovaJanela(Form janelas)
        {
            try
            {
                if (FormExterno != null)
                {
                    FormExterno.Close();
                    FormExterno.Show();
                }
            }
            catch (Exception)
            {

            }
        }
        #endregion

        private async void BtnFrmBeamSafeLoadAssessment_Click(object sender, EventArgs e)
        {
            using (var dbContext = new DataContext())
            {
                var LostDate = await dbContext.TabelaControlAccess.FirstOrDefaultAsync();
                if (LostDate != null)
                {
                    if(DateTime.Now >= LostDate.DateAccess)
                    {
                        LostDate.DateAccess = DateTime.Now;
                        dbContext.TabelaControlAccess.Update(LostDate);
                        await dbContext.SaveChangesAsync();
                    }
                }
            }
            var janela = new View05BeamSafeAssessment();
            janela.Width = PainelFormsExternos.Width;
            janela.Height = PainelFormsExternos.Height;
            AbrirNovaJanela(janela);
        }

        private async void BtnFrmSlingLoadAssessment_Click(object sender, EventArgs e)
        {
            using (var dbContext = new DataContext())
            {
                var LostDate = await dbContext.TabelaControlAccess.FirstOrDefaultAsync();
                if (LostDate != null)
                {
                    if (DateTime.Now >= LostDate.DateAccess)
                    {
                        LostDate.DateAccess = DateTime.Now;
                        dbContext.TabelaControlAccess.Update(LostDate);
                        await dbContext.SaveChangesAsync();
                    }
                }
            }
            var janela = new View06SlingLoadAssessment();
            janela.Width = PainelFormsExternos.Width;
            janela.Height = PainelFormsExternos.Height;
            AbrirNovaJanela(janela);
        }

        private async void BtnFrmAbout_Click(object sender, EventArgs e)
        {
            using (var dbContext = new DataContext())
            {
                var LostDate = await dbContext.TabelaControlAccess.FirstOrDefaultAsync();
                if (LostDate != null)
                {
                    if (DateTime.Now >= LostDate.DateAccess)
                    {
                        LostDate.DateAccess = DateTime.Now;
                        dbContext.TabelaControlAccess.Update(LostDate);
                        await dbContext.SaveChangesAsync();
                    }
                }
            }

            var janela = new View07About();
            janela.Width = PainelFormsExternos.Width;
            janela.Height = PainelFormsExternos.Height;
            AbrirNovaJanela(janela);
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            using (var dbContext = new DataContext())
            {
                var LostDate = await dbContext.TabelaControlAccess.FirstOrDefaultAsync();
                if (LostDate != null)
                {
                    if (DateTime.Now >= LostDate.DateAccess)
                    {
                        LostDate.DateAccess = DateTime.Now;
                        dbContext.TabelaControlAccess.Update(LostDate);
                        await dbContext.SaveChangesAsync();
                    }
                }
            }

            var janela = new View08System(_user);
            janela.Width = PainelFormsExternos.Width;
            janela.Height = PainelFormsExternos.Height;
            AbrirNovaJanela(janela);
        }

        private async void btnClose_Click(object sender, EventArgs e)
        {
            using (var dbContext = new DataContext())
            {
                var LostDate = await dbContext.TabelaControlAccess.FirstOrDefaultAsync();
                if (LostDate != null)
                {
                    if (DateTime.Now >= LostDate.DateAccess)
                    {
                        LostDate.DateAccess = DateTime.Now;
                        dbContext.TabelaControlAccess.Update(LostDate);
                        await dbContext.SaveChangesAsync();
                    }
                }
            }

            try
            {
                if (FormExterno != null)
                {
                    FormExterno.Close();
                    //FormExterno = janelas as Form;
                    FormExterno.TopLevel = false;
                    FormExterno.Dock = DockStyle.Fill;
                    this.PainelFormsExternos.Controls.Add(FormExterno);
                    this.PainelFormsExternos.Tag = FormExterno;
                    FormExterno.Size = new Size(PainelFormsExternos.Width, PainelFormsExternos.Height);
                    PainelFormsExternos.BringToFront();
                }
            }
            catch
            {

            }
        }
    }
}
