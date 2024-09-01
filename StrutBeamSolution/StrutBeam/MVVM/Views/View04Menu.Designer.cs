namespace StrutBeam.MVVM.Views
{
    partial class View04Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View04Menu));
            PainelEsquerdo = new Panel();
            PainelMenu = new Panel();
            btnClose = new Button();
            button4 = new Button();
            BtnFrmBeamSafeLoadAssessment = new Button();
            BtnFrmAbout = new Button();
            BtnFrmSlingLoadAssessment = new Button();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            PainelFormsExternos = new Panel();
            PainelEsquerdo.SuspendLayout();
            PainelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // PainelEsquerdo
            // 
            PainelEsquerdo.BorderStyle = BorderStyle.FixedSingle;
            PainelEsquerdo.Controls.Add(PainelMenu);
            PainelEsquerdo.Controls.Add(label4);
            PainelEsquerdo.Controls.Add(label2);
            PainelEsquerdo.Controls.Add(label1);
            PainelEsquerdo.Controls.Add(label3);
            PainelEsquerdo.Dock = DockStyle.Left;
            PainelEsquerdo.Location = new Point(0, 0);
            PainelEsquerdo.Margin = new Padding(3, 2, 3, 2);
            PainelEsquerdo.Name = "PainelEsquerdo";
            PainelEsquerdo.Size = new Size(271, 542);
            PainelEsquerdo.TabIndex = 0;
            // 
            // PainelMenu
            // 
            PainelMenu.Controls.Add(btnClose);
            PainelMenu.Controls.Add(button4);
            PainelMenu.Controls.Add(BtnFrmBeamSafeLoadAssessment);
            PainelMenu.Controls.Add(BtnFrmAbout);
            PainelMenu.Controls.Add(BtnFrmSlingLoadAssessment);
            PainelMenu.Location = new Point(6, 140);
            PainelMenu.Margin = new Padding(3, 2, 3, 2);
            PainelMenu.Name = "PainelMenu";
            PainelMenu.Size = new Size(255, 314);
            PainelMenu.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.ForeColor = SystemColors.ButtonHighlight;
            btnClose.Location = new Point(10, 247);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(234, 49);
            btnClose.TabIndex = 19;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // button4
            // 
            button4.Location = new Point(10, 188);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(234, 49);
            button4.TabIndex = 18;
            button4.Text = "ACCOUNT";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // BtnFrmBeamSafeLoadAssessment
            // 
            BtnFrmBeamSafeLoadAssessment.Location = new Point(10, 11);
            BtnFrmBeamSafeLoadAssessment.Margin = new Padding(3, 2, 3, 2);
            BtnFrmBeamSafeLoadAssessment.Name = "BtnFrmBeamSafeLoadAssessment";
            BtnFrmBeamSafeLoadAssessment.Size = new Size(234, 49);
            BtnFrmBeamSafeLoadAssessment.TabIndex = 15;
            BtnFrmBeamSafeLoadAssessment.Text = "BEAM SAFE LOAD ASSESSMENT";
            BtnFrmBeamSafeLoadAssessment.UseVisualStyleBackColor = true;
            BtnFrmBeamSafeLoadAssessment.Click += BtnFrmBeamSafeLoadAssessment_Click;
            // 
            // BtnFrmAbout
            // 
            BtnFrmAbout.Location = new Point(10, 129);
            BtnFrmAbout.Margin = new Padding(3, 2, 3, 2);
            BtnFrmAbout.Name = "BtnFrmAbout";
            BtnFrmAbout.Size = new Size(234, 49);
            BtnFrmAbout.TabIndex = 17;
            BtnFrmAbout.Text = "ABOUT THIS APP";
            BtnFrmAbout.UseVisualStyleBackColor = true;
            BtnFrmAbout.Click += BtnFrmAbout_Click;
            // 
            // BtnFrmSlingLoadAssessment
            // 
            BtnFrmSlingLoadAssessment.Location = new Point(10, 70);
            BtnFrmSlingLoadAssessment.Margin = new Padding(3, 2, 3, 2);
            BtnFrmSlingLoadAssessment.Name = "BtnFrmSlingLoadAssessment";
            BtnFrmSlingLoadAssessment.Size = new Size(234, 49);
            BtnFrmSlingLoadAssessment.TabIndex = 16;
            BtnFrmSlingLoadAssessment.Text = "SLING LOAD ASSESSMENT";
            BtnFrmSlingLoadAssessment.UseVisualStyleBackColor = true;
            BtnFrmSlingLoadAssessment.Click += BtnFrmSlingLoadAssessment_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(54, 57);
            label4.Name = "label4";
            label4.Size = new Size(136, 20);
            label4.TabIndex = 14;
            label4.Text = "Hoisting Calculator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(37, 34);
            label2.Name = "label2";
            label2.Size = new Size(177, 20);
            label2.TabIndex = 13;
            label2.Text = "Strutural Beam Safe Load";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(54, 6);
            label1.Name = "label1";
            label1.Size = new Size(141, 26);
            label1.TabIndex = 11;
            label1.Text = "STRUT HOIST";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Orange;
            label3.Location = new Point(-42, 64);
            label3.Name = "label3";
            label3.Size = new Size(322, 26);
            label3.TabIndex = 12;
            label3.Text = "_______________________________";
            // 
            // PainelFormsExternos
            // 
            PainelFormsExternos.BorderStyle = BorderStyle.FixedSingle;
            PainelFormsExternos.Dock = DockStyle.Fill;
            PainelFormsExternos.Location = new Point(271, 0);
            PainelFormsExternos.Margin = new Padding(3, 2, 3, 2);
            PainelFormsExternos.Name = "PainelFormsExternos";
            PainelFormsExternos.Size = new Size(625, 542);
            PainelFormsExternos.TabIndex = 1;
            // 
            // View04Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 30, 46);
            ClientSize = new Size(896, 542);
            Controls.Add(PainelFormsExternos);
            Controls.Add(PainelEsquerdo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "View04Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            WindowState = FormWindowState.Maximized;
            FormClosed += View04Menu_FormClosed;
            Load += View04Menu_Load;
            Resize += View04Menu_Resize;
            PainelEsquerdo.ResumeLayout(false);
            PainelEsquerdo.PerformLayout();
            PainelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel PainelEsquerdo;
        private Panel PainelFormsExternos;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label2;
        private Button button4;
        private Button BtnFrmAbout;
        private Button BtnFrmSlingLoadAssessment;
        private Button BtnFrmBeamSafeLoadAssessment;
        private Panel PainelMenu;
        private Button btnClose;
    }
}