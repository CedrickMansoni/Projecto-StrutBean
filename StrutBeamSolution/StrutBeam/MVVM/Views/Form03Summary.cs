using Newtonsoft.Json;
using StrutBeam.MVVM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Runtime.InteropServices;

namespace StrutBeam.MVVM.Views.StrutBeam
{
    public partial class Form03Summary : Form
    {
        double limit1 = 0;
        double limit2 = 0;

        public Form03Summary()
        {
            InitializeComponent();            
        }

        private async void Form03Summary_Load(object sender, EventArgs e)
        {
            loading.Location = new System.Drawing.Point((this.Width / 2) - (loading.Width / 2), (this.Height / 2) - (loading.Height / 2));
            loading.Visible = true;

            Excel.Application? App = new();
            Workbook? Pasta;
            Worksheet? Planilha;
            string Caminho = AppDomain.CurrentDomain.BaseDirectory + @"\arq.xlsx";

            Pasta = App.Workbooks.Open(Caminho, Type.Missing, Type.Missing, Type.Missing, "14142311");
            Planilha = Pasta.Worksheets[3];

            await TopFlangeInCompressionAsync();
            await BiaxialStressByCombiningTheGlobalAndLocalStressAsync();
            await MaxiDeflectionAsync();

            P1.Height = (int)limit1 * 10;
            P2.Height = (int)limit2 * 10;
            P1.Top = 415 - P1.Height;
            P2.Top = 415 - P2.Height;
            if (P1.Height < P2.Height)
            {
                lblOBS.Text = "Lift plan is safe to proceed\n";
            }
            else if (P1.Height > P2.Height) 
            {
                lblOBS.Text = "warning:  lift plan is not safe to proceed.\n1) Consult Engineering  for further assessment, recommendations  and endorsements.\n2) Proceed only per Engineering  recommendations.";
            }
            else
            {
                lblOBS.Text = "Warning: The  Threshold is achieved.\nThe lift plan is safe to proceed   however it is recommended  additional review and  endorsement by engineering.\n";
            }
            Pasta.Save();
            Planilha = null;

            if (Pasta != null)
            {
                Pasta.Close(false);
            }
            await Task.Delay(30000);
            App.Quit();
            //await Task.Delay(30000);
            
            Pasta = null;
            //App = null;

            if (App != null)
            {
                Marshal.ReleaseComObject(App);
            }
            loading.Visible = false;
        }
   
        private async Task TopFlangeInCompressionAsync()
        {
            Excel.Application? App = new();
            Workbook? Pasta;
            Worksheet? Planilha;
            string Caminho = AppDomain.CurrentDomain.BaseDirectory + @"\arq.xlsx";
            Pasta = App.Workbooks.Open(Caminho, Type.Missing, Type.Missing, Type.Missing, "14142311");

            Planilha = Pasta.Worksheets[3];

            lblFa.Text = Planilha.Cells[143, 2].Value.ToString(); 
           
            lblFbx.Text = Planilha.Cells[144, 2].Value.ToString("N");

            lblFby.Text = Planilha.Cells[145, 2].Value.ToString("N");

            lblFvy.Text = Planilha.Cells[146, 2].Value.ToString("N");
           
            lblAscH1.Text = Planilha.Cells[147, 2].Value.ToString("N");

            lblAscH2.Text = Planilha.Cells[148, 2].Value.ToString("N");
                        
            lblSrcase1.Text = Planilha.Cells[150, 2].Value.ToString("N");

            lblSrcase2.Text = Planilha.Cells[151, 2].Value.ToString("N");
            
            Planilha = null;
            if (Pasta != null)
            {
                Pasta.Close(false);
            }
            await Task.Delay(30000);
            App.Quit();
            //await Task.Delay(30000);
           
            Pasta = null;
            //App = null;

            if (App != null)
            {
                Marshal.ReleaseComObject(App);
            }
        }
        private async Task BiaxialStressByCombiningTheGlobalAndLocalStressAsync()
        {
            // POINT - 0
            Excel.Application? App = new();
            Workbook? Pasta;
            Worksheet? Planilha;
            string Caminho = AppDomain.CurrentDomain.BaseDirectory + @"\arq.xlsx";
            Pasta = App.Workbooks.Open(Caminho, Type.Missing, Type.Missing, Type.Missing, "14142311");

            Planilha = Pasta.Worksheets[3];

            lblSigmaz0c.Text = Planilha.Cells[156, 2].Value.ToString();

            lblSigmax0c.Text = Planilha.Cells[157, 2].Value.ToString("N");

            lblSigmaxz0c.Text = Planilha.Cells[158, 2].Value.ToString("N");

            lblSigmaVmis0.Text = Planilha.Cells[159, 2].Value.ToString("N");

            lblSR3P0.Text = Planilha.Cells[161, 2].Value.ToString("N");
            //-------------------------------------------------------------------------------------------------------------------------------------
            // POINT - 1
            
            lblSigmaz1c.Text = Planilha.Cells[164, 2].Value.ToString("N");
            
            lblSigmax1c.Text = Planilha.Cells[165, 2].Value.ToString("N");

            lblSigmaxz1c.Text = Planilha.Cells[166, 2].Value.ToString("N");

            lblSigmaVmis1.Text = Planilha.Cells[167, 2].Value.ToString("N");

            lblSR4.Text = Planilha.Cells[169, 2].Value.ToString("N");
            //-------------------------------------------------------------------------------------------------------------------------------------
            // POINT - 2
            
            lblSigmaz2c.Text = Planilha.Cells[172, 2].Value.ToString("N");

            lblSigmax2c.Text = Planilha.Cells[173, 2].Value.ToString("N");

            lblSigmaxz2c.Text = Planilha.Cells[174, 2].Value.ToString("N");

            lblSigmaVmis2.Text = Planilha.Cells[175, 2].Value.ToString("N");

            lblSR5.Text = Planilha.Cells[177, 2].Value.ToString("N");

            lblSR_Case3.Text = Planilha.Cells[178, 2].Value.ToString("N");

            if (Pasta != null)
            {
                Pasta.Close(false);
            }
            await Task.Delay(5000);
            App.Quit();
            //await Task.Delay(5000);
            Planilha = null;
            Pasta = null;
            //App = null;

            if (App != null)
            {
                Marshal.ReleaseComObject(App);
            }
        }
        private async Task MaxiDeflectionAsync()
        {
            Excel.Application? App = new();
            Workbook? Pasta;
            Worksheet? Planilha;
            string Caminho = AppDomain.CurrentDomain.BaseDirectory + @"\arq.xlsx";
            Pasta = App.Workbooks.Open(Caminho, Type.Missing, Type.Missing, Type.Missing, "14142311");

            Planilha = Pasta.Worksheets[3];

            lblStressRatioResult.Text = Planilha.Cells[181, 3].Value.ToString("N");

            lblStressRatioTarget.Text = Planilha.Cells[181, 4].Value.ToString("N");

            Maxi_Result.Text = Planilha.Cells[183, 3].Value.ToString("N");

            limit1 = Convert.ToDouble(Planilha.Cells[181, 3].Value.ToString("N")) / 0.1;
            limit2 = Convert.ToDouble(Planilha.Cells[181, 4].Value.ToString("N")) / 0.1;

            if (Pasta != null)
            {
                Pasta.Close(false);
            }
            await Task.Delay(5000);
            App.Quit();
            //await Task.Delay(5000);
            Planilha = null;
            Pasta = null;
            //App = null;

            if (App != null)
            {
                Marshal.ReleaseComObject(App);
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            btnSaveFile.Visible = false;
            this.FormBorderStyle = FormBorderStyle.None;
            CriarDirectorio("c:\\summary");

            try
            {
                var path = "c:\\summary";
                var result = CapturarForm(path, this);
                if (result != null) 
                {
                    MessageBox.Show("Summary saved in " + result);                
                }
                else
                {
                    MessageBox.Show("Unable to save summary " + result, "Error");
                }
            }
            catch 
            {

            }
            btnSaveFile.Visible = true;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }
        private string CapturarForm(string path, Form form)
        {
            try
            {
                var nomeArquivo = path + "\\" +
                    $"{Lift_Plan.Text}."+ DateTime.Now.ToString().Replace(" ", "_").Replace("/","").Replace(":","") + ".png";
                using (var bmp = new Bitmap(form.Width, form.Height))
                {
                    form.DrawToBitmap(bmp, new System.Drawing.Rectangle(0, 0, bmp.Width, bmp.Height));
                    bmp.Save(nomeArquivo);
                }
                return nomeArquivo;
            }
            catch 
            {
                return "";
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
