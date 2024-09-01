using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using StrutBeam.MVVM.Models;
using StrutBeam.MVVM.Views.StrutBeam;
using Excel = Microsoft.Office.Interop.Excel;

namespace StrutBeam.MVVM.Views
{
    public partial class View05BeamSafeAssessment : Form
    {
        public View05BeamSafeAssessment()
        {
            InitializeComponent();            
        }

        private async void btnCalcular_ClickAsync(object sender, EventArgs e)
        {
            if (Beam_Section_Saze.Text == string.Empty)
            {
                new View00ErrorMessage("Error", "Insert Beam").ShowDialog();
                Beam_Section_Saze.Focus();
            }
            else if (Beam_Section_SazeType.Text == string.Empty)
            {
                new View00ErrorMessage("Error", "Insert Beam type").ShowDialog();
                Beam_Section_SazeType.Focus();
            }
            else if (txtFy.Text == string.Empty || Convert.ToDecimal(txtFy.Text) == Convert.ToDecimal("0,0"))
            {
                new View00ErrorMessage("Error", "The Steel Minimum Yield Strength field cannot be equal to zero").ShowDialog();
                txtFy.Focus();
            }
            else if (txtE.Text == string.Empty || Convert.ToDecimal(txtE.Text) == Convert.ToDecimal("0,0"))
            {
                new View00ErrorMessage("Error", "The Young's modulus field cannot be equal to zero").ShowDialog();
                txtE.Focus();
            }
            else if (txtL.Text == string.Empty || Convert.ToDecimal(txtL.Text) == Convert.ToDecimal("0,0"))
            {
                new View00ErrorMessage("Error", "The Beam Simple-Span Length field cannot be equal to zero").ShowDialog();
                txtL.Focus();
            }
            else
            {
                loading.Location = new System.Drawing.Point((this.Width / 2) - (loading.Width / 2), (this.Height / 2) - (loading.Height / 2));
                loading.Visible = true;
                var v = new SectionProperties(Beam_Section_Saze.Text);
                if (!v.StandarizedBeam())
                {
                    await SalvarECalcular();
                    new Form03Summary().ShowDialog();
                }
                else
                {
                    new View00ErrorMessage("Warning", "Lifting is not Safe to proceed. Do not proceed.").ShowDialog();
                }
                loading.Visible = false;
            }
        }
        private SafeLoadAssessment ConverterDados()
        {
            var data = new SafeLoadAssessment();

            #region Zona1
            data.BeamSectioSize = @$"{Beam_Section_Saze.Text}";
            data.BeamSectioType = Beam_Section_SazeType.Text;

            data.Lift_Plan_Fy = txtFy.Text == string.Empty ? Convert.ToDecimal("0,0") : Convert.ToDecimal(txtFy.Text);
            data.Lift_Plan_E = txtE.Text == string.Empty ? Convert.ToDecimal("0,0") : Convert.ToDecimal(txtE.Text);
            data.Lift_Plan_V = txtV.Text == string.Empty ? Convert.ToDecimal("0,0") : Convert.ToDecimal(txtV.Text);
            data.Lift_Plan_L = txtL.Text == string.Empty ? Convert.ToDecimal("0,0") : Convert.ToDecimal(txtL.Text);
            data.Lift_Plan_Lb = txtLb.Text == string.Empty ? Convert.ToDecimal("0,0") : Convert.ToDecimal(txtLb.Text);
            data.Lift_Plan_Cb = txtCb.Text == string.Empty ? Convert.ToDecimal("0,0") : Convert.ToDecimal(txtCb.Text);
            data.Lift_Plan_Lo = txtLo.Text == string.Empty ? Convert.ToDecimal("0,0") : Convert.ToDecimal(txtLo.Text);
            data.Lift_Plan_Lbo = txtLbo.Text == string.Empty ? Convert.ToDecimal("0,0") : Convert.ToDecimal(txtLbo.Text);
            data.Lift_Plan_Cbo = txtCbo.Text == string.Empty ? Convert.ToDecimal("0,0") : Convert.ToDecimal(txtCbo.Text);
            #endregion

            #region Zona2
            data.Lift_Plan_Tl = txtTL.Text == string.Empty ? Convert.ToDecimal("0,0") : Convert.ToDecimal(txtTL.Text);
            data.Lift_Plan_Hw = txtHw.Text == string.Empty ? Convert.ToDecimal("0,0") : Convert.ToDecimal(txtHw.Text);
            data.Lift_Plan_Ll = txtLl.Text == string.Empty ? Convert.ToDecimal("0,0") : Convert.ToDecimal(txtLl.Text);
            data.Lift_Plan_Df = txtDf.Text == string.Empty ? Convert.ToDecimal("0,0") : Convert.ToDecimal(txtDf.Text);
            data.Lift_Plan_Hf = txtHf.Text == string.Empty ? Convert.ToDecimal("0,0") : Convert.ToDecimal(txtHf.Text);
            data.Lift_Plan_Ang1 = txtAng1.Text == string.Empty ? Convert.ToDecimal("0,0") : Convert.ToDecimal(txtAng1.Text);
            data.Lift_Plan_Ang2 = txtAng2.Text == string.Empty ? Convert.ToDecimal("0,0") : Convert.ToDecimal(txtAng2.Text);
            data.Lift_Plan_HLF = txtHlf.Text == string.Empty ? Convert.ToDecimal("0,0") : Convert.ToDecimal(txtHlf.Text);
            data.Lift_Plan_LLF = txtLlf.Text == string.Empty ? Convert.ToDecimal("0,0") : Convert.ToDecimal(txtLlf.Text);
            data.Lift_Plan_S1 = txtS1.Text == string.Empty ? Convert.ToDecimal("0,0") : Convert.ToDecimal(txtS1.Text);
            #endregion

            #region Zona3
            data.Lift_Plan_Wsps = txtWsps.Text == string.Empty ? Convert.ToDecimal("0,0") : Convert.ToDecimal(txtWsps.Text);
            data.Lift_Plan_Cs = txtCs.Text == string.Empty ? Convert.ToDecimal("0,0") : Convert.ToDecimal(txtCs.Text);
            data.Lift_Plan_Wps0 = txtWps0.Text == string.Empty ? Convert.ToDecimal("0,0") : Convert.ToDecimal(txtWps0.Text);
            data.Lift_Plan_Wps2 = txtWps2.Text == string.Empty ? Convert.ToDecimal("0,0") : Convert.ToDecimal(txtWps2.Text);
            data.Lift_Plan_Alift = txtAlift.Text == string.Empty ? Convert.ToDecimal("0,0") : Convert.ToDecimal(txtAlift.Text);
            data.Lift_Plan_Calift = txtCalift.Text == string.Empty ? Convert.ToDecimal("0,0") : Convert.ToDecimal(txtCalift.Text);
            data.Lift_Plan_Wps = txtWps.Text == string.Empty ? Convert.ToDecimal("0,0") : Convert.ToDecimal(txtWps.Text);
            data.Lift_Plan_ah = txtAh.Text == string.Empty ? Convert.ToDecimal("0,0") : Convert.ToDecimal(txtAh.Text);
            data.Lift_Plan_Wel1 = txtWel1.Text == string.Empty ? Convert.ToDecimal("0,0") : Convert.ToDecimal(txtWel1.Text);
            data.Lift_Plan_Wel = txtWel.Text == string.Empty ? Convert.ToDecimal("0,0") : Convert.ToDecimal(txtWel.Text);
            data.Lift_Plan_Pblk = txtPblk.Text == string.Empty ? Convert.ToDecimal("0,0") : Convert.ToDecimal(txtPblk.Text);
            data.Lift_Plan_Bspac = txtBspac.Text == string.Empty ? Convert.ToDecimal("0,0") : Convert.ToDecimal(txtBspac.Text);
            data.Lift_Plan_Pld = txtPblk.Text == string.Empty ? Convert.ToDecimal("0,0") : Convert.ToDecimal(txtPblk.Text);
            #endregion

            return data;
        }
        private async Task SalvarECalcular()
        {
            var data = ConverterDados();
            Excel.Application? App = new();
            Workbook? Pasta;
            Worksheet? Planilha;
            string Caminho = AppDomain.CurrentDomain.BaseDirectory + @"\arq.xlsx";

            Pasta = App.Workbooks.Open(Caminho, Type.Missing, Type.Missing, Type.Missing, "14142311");

            Planilha = Pasta.Worksheets[2];

            Planilha.Cells[1, 1].Value = data.BeamSectioSize;
            Planilha.Cells[2, 1].Value = data.BeamSectioType;
            Planilha.Cells[3, 1].Value = data.Lift_Plan_Fy;
            Planilha.Cells[4, 1].Value = data.Lift_Plan_E;
            Planilha.Cells[5, 1].Value = data.Lift_Plan_V;
            Planilha.Cells[6, 1].Value = data.Lift_Plan_L;
            Planilha.Cells[7, 1].Value = data.Lift_Plan_Lb;
            Planilha.Cells[8, 1].Value = data.Lift_Plan_Cb;
            Planilha.Cells[9, 1].Value = data.Lift_Plan_Lo;
            Planilha.Cells[10, 1].Value = data.Lift_Plan_Lbo;
            Planilha.Cells[11, 1].Value = data.Lift_Plan_Cbo;

            Planilha.Cells[13, 1].Value = data.Lift_Plan_Tl;
            Planilha.Cells[14, 1].Value = data.Lift_Plan_Hw;
            Planilha.Cells[15, 1].Value = data.Lift_Plan_Ll;
            Planilha.Cells[16, 1].Value = data.Lift_Plan_Df;
            Planilha.Cells[17, 1].Value = data.Lift_Plan_Hf;
            Planilha.Cells[18, 1].Value = data.Lift_Plan_Ang1;
            Planilha.Cells[19, 1].Value = data.Lift_Plan_Ang2;

            Planilha.Cells[21, 1].Value = data.Lift_Plan_HLF;
            Planilha.Cells[22, 1].Value = data.Lift_Plan_LLF;

            Planilha.Cells[24, 1].Value = data.Lift_Plan_S1;

            Planilha.Cells[26, 1].Value = data.Lift_Plan_Wsps;
            Planilha.Cells[27, 1].Value = data.Lift_Plan_Cs;
            Planilha.Cells[28, 1].Value = data.Lift_Plan_Wps0;
            Planilha.Cells[29, 1].Value = data.Lift_Plan_Wps2;
            Planilha.Cells[30, 1].Value = data.Lift_Plan_Alift;
            Planilha.Cells[31, 1].Value = data.Lift_Plan_Calift;
            Planilha.Cells[32, 1].Value = data.Lift_Plan_Wps;
            Planilha.Cells[33, 1].Value = data.Lift_Plan_ah;
            Planilha.Cells[34, 1].Value = data.Lift_Plan_Wel1;
            Planilha.Cells[35, 1].Value = data.Lift_Plan_Wel;
            Planilha.Cells[36, 1].Value = data.Lift_Plan_Pblk;
            Planilha.Cells[37, 1].Value = data.Lift_Plan_Bspac;
            Planilha.Cells[38, 1].Value = data.Lift_Plan_Pld;

            Pasta.Save();
            Planilha = null;

            if (Pasta != null)
            {
                Pasta.Close(false);
            }
            await Task.Delay(5000);
            App.Quit();
            await Task.Delay(15000);

            Pasta = null;
            App = null;

            //if (App != null)
            //{
            //    Marshal.ReleaseComObject(App);
            //}
        }

        private void txtFy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44) { e.Handled = true; }
            if (e.KeyChar == '.') { e.Handled = true; }
            if (e.KeyChar == ',') { e.Handled = false; }
        }

        private void txtL_TextChanged(object sender, EventArgs e)
        {
            if (txtL.Text != string.Empty)
            {
                txtLb.Text = txtL.Text;
            }
            else
            {
                txtLb.Text = string.Empty;
            }
        }

        private void txtAng1_TextChanged(object sender, EventArgs e)
        {
            if (txtAng1.Text != string.Empty)
            {
                txtHlf.Text = (Math.Sin(double.Parse(txtAng1.Text, System.Globalization.CultureInfo.InvariantCulture) * Math.PI / 180) * 1.5).ToString("N");
            }
            else
            {
                txtHlf.Text = string.Empty;
            }
        }

        private void txtAng2_TextChanged(object sender, EventArgs e)
        {
            if (txtAng2.Text != string.Empty)
            {
                txtLlf.Text = Math.Sin(double.Parse(txtAng2.Text, System.Globalization.CultureInfo.InvariantCulture) * Math.PI / 180).ToString("N");
            }
            else
            {
                txtLlf.Text = string.Empty;
            }
        }

        private void txtWsps_TextChanged(object sender, EventArgs e)
        {
            if (txtWsps.Text != string.Empty)
            {
                txtWps0.Text = (0.00338 * Math.Pow(double.Parse(txtWsps.Text, System.Globalization.CultureInfo.InvariantCulture), 2)).ToString();
            }
            else
            {
                txtWps0.Text = string.Empty;
            }
        }

        private void txtWps0_TextChanged(object sender, EventArgs e)
        {
            if (txtAlift.Text != string.Empty && txtWps0.Text != string.Empty && txtCalift.Text != string.Empty)
            {
                double n = (double.Parse(txtAlift.Text)
                    * double.Parse(txtWps0.Text)
                    * double.Parse(txtCalift.Text));
                txtWps.Text = (n / 1000.0).ToString("N");
            }
            else
            {
                txtWps.Text = string.Empty;
            }
        }

        private void txtAlift_TextChanged(object sender, EventArgs e)
        {
            if (txtAlift.Text != string.Empty && txtWps0.Text != string.Empty && txtCalift.Text != string.Empty)
            {
                double n = (double.Parse(txtAlift.Text)
                    * double.Parse(txtWps0.Text)
                    * double.Parse(txtCalift.Text));
                txtWps.Text = (n / 1000.0).ToString("N");
            }
            else
            {
                txtWps.Text = string.Empty;
            }
        }

        private void txtCalift_TextChanged(object sender, EventArgs e)
        {
            if (txtAlift.Text != string.Empty && txtWps0.Text != string.Empty && txtCalift.Text != string.Empty)
            {
                double n = (double.Parse(txtAlift.Text)
                    * double.Parse(txtWps0.Text)
                    * double.Parse(txtCalift.Text));
                txtWps.Text = (n / 1000.0).ToString("N");
            }
            else
            {
                txtWps.Text = string.Empty;
            }
        }

        private void txtAh_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtAh.Text != string.Empty)
                {
                    txtWel.Text = (double.Parse(txtAh.Text) * double.Parse(txtLl.Text)).ToString("N");
                }
                else
                {
                    txtWel.Text = string.Empty;
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
