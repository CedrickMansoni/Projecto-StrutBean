namespace StrutBeam.MVVM.Views
{
    partial class View06SlingLoadAssessment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View06SlingLoadAssessment));
            PainelCentral = new Panel();
            btnCalculate = new Button();
            btnClear = new Button();
            panel5 = new Panel();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel8 = new Panel();
            txtPEF = new TextBox();
            panel7 = new Panel();
            txtSWF = new TextBox();
            panel6 = new Panel();
            txtSWW = new TextBox();
            panel4 = new Panel();
            txtBCF = new TextBox();
            panel3 = new Panel();
            txtBCW = new TextBox();
            panel2 = new Panel();
            txtLOF = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            lblLOFW = new Label();
            lblBCFW = new Label();
            lblSWFW = new Label();
            lblPEW = new Label();
            lblPEFW = new Label();
            lblTWW = new Label();
            lblTWF = new Label();
            lblTWFW = new Label();
            lblESLFW = new Label();
            panel1 = new Panel();
            txtLOW = new TextBox();
            PainelCentral.SuspendLayout();
            panel5.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // PainelCentral
            // 
            PainelCentral.BorderStyle = BorderStyle.FixedSingle;
            PainelCentral.Controls.Add(btnCalculate);
            PainelCentral.Controls.Add(btnClear);
            PainelCentral.Controls.Add(panel5);
            PainelCentral.Controls.Add(tableLayoutPanel1);
            PainelCentral.Location = new Point(31, 27);
            PainelCentral.Name = "PainelCentral";
            PainelCentral.Size = new Size(892, 638);
            PainelCentral.TabIndex = 0;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(630, 585);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(171, 36);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(446, 585);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(171, 36);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Orange;
            panel5.Controls.Add(label2);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(890, 40);
            panel5.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(335, 5);
            label2.Name = "label2";
            label2.Size = new Size(231, 30);
            label2.TabIndex = 14;
            label2.Text = "Sling Load Assessment";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.11111F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.88889F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 184F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 176F));
            tableLayoutPanel1.Controls.Add(panel8, 2, 4);
            tableLayoutPanel1.Controls.Add(panel7, 2, 3);
            tableLayoutPanel1.Controls.Add(panel6, 1, 3);
            tableLayoutPanel1.Controls.Add(panel4, 2, 2);
            tableLayoutPanel1.Controls.Add(panel3, 1, 2);
            tableLayoutPanel1.Controls.Add(panel2, 2, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 1, 0);
            tableLayoutPanel1.Controls.Add(label4, 2, 0);
            tableLayoutPanel1.Controls.Add(label5, 3, 0);
            tableLayoutPanel1.Controls.Add(label6, 0, 1);
            tableLayoutPanel1.Controls.Add(label7, 0, 2);
            tableLayoutPanel1.Controls.Add(label8, 0, 3);
            tableLayoutPanel1.Controls.Add(label9, 0, 4);
            tableLayoutPanel1.Controls.Add(label10, 0, 5);
            tableLayoutPanel1.Controls.Add(label11, 0, 6);
            tableLayoutPanel1.Controls.Add(lblLOFW, 3, 1);
            tableLayoutPanel1.Controls.Add(lblBCFW, 3, 2);
            tableLayoutPanel1.Controls.Add(lblSWFW, 3, 3);
            tableLayoutPanel1.Controls.Add(lblPEW, 1, 4);
            tableLayoutPanel1.Controls.Add(lblPEFW, 3, 4);
            tableLayoutPanel1.Controls.Add(lblTWW, 1, 5);
            tableLayoutPanel1.Controls.Add(lblTWF, 2, 5);
            tableLayoutPanel1.Controls.Add(lblTWFW, 3, 5);
            tableLayoutPanel1.Controls.Add(lblESLFW, 3, 6);
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            tableLayoutPanel1.Location = new Point(69, 65);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 44.1176453F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 55.8823547F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 74F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            tableLayoutPanel1.Size = new Size(735, 505);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(txtPEF);
            panel8.Location = new Point(377, 299);
            panel8.Name = "panel8";
            panel8.Size = new Size(177, 66);
            panel8.TabIndex = 47;
            // 
            // txtPEF
            // 
            txtPEF.BackColor = Color.FromArgb(22, 30, 46);
            txtPEF.BorderStyle = BorderStyle.None;
            txtPEF.Font = new Font("Bahnschrift", 16.2F);
            txtPEF.ForeColor = Color.White;
            txtPEF.Location = new Point(0, 17);
            txtPEF.Name = "txtPEF";
            txtPEF.Size = new Size(178, 33);
            txtPEF.TabIndex = 27;
            txtPEF.Text = "0";
            txtPEF.TextAlign = HorizontalAlignment.Center;
            txtPEF.KeyPress += txtLOW_KeyPress;
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(txtSWF);
            panel7.Location = new Point(377, 229);
            panel7.Name = "panel7";
            panel7.Size = new Size(177, 64);
            panel7.TabIndex = 46;
            // 
            // txtSWF
            // 
            txtSWF.BackColor = Color.FromArgb(22, 30, 46);
            txtSWF.BorderStyle = BorderStyle.None;
            txtSWF.Font = new Font("Bahnschrift", 16.2F);
            txtSWF.ForeColor = Color.White;
            txtSWF.Location = new Point(0, 15);
            txtSWF.Name = "txtSWF";
            txtSWF.Size = new Size(178, 33);
            txtSWF.TabIndex = 27;
            txtSWF.Text = "0";
            txtSWF.TextAlign = HorizontalAlignment.Center;
            txtSWF.KeyPress += txtLOW_KeyPress;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(txtSWW);
            panel6.Location = new Point(194, 229);
            panel6.Name = "panel6";
            panel6.Size = new Size(177, 64);
            panel6.TabIndex = 45;
            // 
            // txtSWW
            // 
            txtSWW.BackColor = Color.FromArgb(22, 30, 46);
            txtSWW.BorderStyle = BorderStyle.None;
            txtSWW.Font = new Font("Bahnschrift", 16.2F);
            txtSWW.ForeColor = Color.White;
            txtSWW.Location = new Point(0, 15);
            txtSWW.Name = "txtSWW";
            txtSWW.Size = new Size(178, 33);
            txtSWW.TabIndex = 27;
            txtSWW.Text = "0";
            txtSWW.TextAlign = HorizontalAlignment.Center;
            txtSWW.KeyPress += txtLOW_KeyPress;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(txtBCF);
            panel4.Location = new Point(377, 155);
            panel4.Name = "panel4";
            panel4.Size = new Size(177, 68);
            panel4.TabIndex = 44;
            // 
            // txtBCF
            // 
            txtBCF.BackColor = Color.FromArgb(22, 30, 46);
            txtBCF.BorderStyle = BorderStyle.None;
            txtBCF.Font = new Font("Bahnschrift", 16.2F);
            txtBCF.ForeColor = Color.White;
            txtBCF.Location = new Point(0, 21);
            txtBCF.Name = "txtBCF";
            txtBCF.Size = new Size(178, 33);
            txtBCF.TabIndex = 27;
            txtBCF.Text = "0";
            txtBCF.TextAlign = HorizontalAlignment.Center;
            txtBCF.KeyPress += txtLOW_KeyPress;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(txtBCW);
            panel3.Location = new Point(194, 155);
            panel3.Name = "panel3";
            panel3.Size = new Size(177, 68);
            panel3.TabIndex = 43;
            // 
            // txtBCW
            // 
            txtBCW.BackColor = Color.FromArgb(22, 30, 46);
            txtBCW.BorderStyle = BorderStyle.None;
            txtBCW.Font = new Font("Bahnschrift", 16.2F);
            txtBCW.ForeColor = Color.White;
            txtBCW.Location = new Point(0, 18);
            txtBCW.Name = "txtBCW";
            txtBCW.Size = new Size(178, 33);
            txtBCW.TabIndex = 27;
            txtBCW.Text = "0";
            txtBCW.TextAlign = HorizontalAlignment.Center;
            txtBCW.KeyPress += txtLOW_KeyPress;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtLOF);
            panel2.Location = new Point(377, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(177, 79);
            panel2.TabIndex = 42;
            // 
            // txtLOF
            // 
            txtLOF.BackColor = Color.FromArgb(22, 30, 46);
            txtLOF.BorderStyle = BorderStyle.None;
            txtLOF.Font = new Font("Bahnschrift", 16.2F);
            txtLOF.ForeColor = Color.White;
            txtLOF.Location = new Point(0, 23);
            txtLOF.Name = "txtLOF";
            txtLOF.Size = new Size(178, 33);
            txtLOF.TabIndex = 27;
            txtLOF.Text = "0";
            txtLOF.TextAlign = HorizontalAlignment.Center;
            txtLOF.KeyPress += txtLOW_KeyPress;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 13F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(185, 67);
            label1.TabIndex = 15;
            label1.Text = "Items";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 13F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(194, 0);
            label3.Name = "label3";
            label3.Size = new Size(177, 67);
            label3.TabIndex = 16;
            label3.Text = "Weight (lbs)";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 13F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(377, 0);
            label4.Name = "label4";
            label4.Size = new Size(178, 67);
            label4.TabIndex = 17;
            label4.Text = "Factor";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 13F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(561, 0);
            label5.Name = "label5";
            label5.Size = new Size(171, 67);
            label5.TabIndex = 18;
            label5.Text = "Factored Weight (lbs)";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 13F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 67);
            label6.Name = "label6";
            label6.Size = new Size(185, 85);
            label6.TabIndex = 19;
            label6.Text = "Lifted object";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Segoe UI", 13F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(3, 152);
            label7.Name = "label7";
            label7.Size = new Size(185, 74);
            label7.TabIndex = 20;
            label7.Text = "Beam clamp";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Segoe UI", 13F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(3, 226);
            label8.Name = "label8";
            label8.Size = new Size(185, 70);
            label8.TabIndex = 21;
            label8.Text = "Sling Weight";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Segoe UI", 13F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(3, 296);
            label9.Name = "label9";
            label9.Size = new Size(185, 72);
            label9.TabIndex = 22;
            label9.Text = "pay eye";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Dock = DockStyle.Fill;
            label10.Font = new Font("Segoe UI", 13F);
            label10.ForeColor = Color.White;
            label10.Location = new Point(3, 368);
            label10.Name = "label10";
            label10.Size = new Size(185, 68);
            label10.TabIndex = 23;
            label10.Text = "Total Weight";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.BorderStyle = BorderStyle.FixedSingle;
            label11.Dock = DockStyle.Fill;
            label11.Font = new Font("Segoe UI", 13F);
            label11.ForeColor = Color.White;
            label11.Location = new Point(3, 436);
            label11.Name = "label11";
            label11.Size = new Size(185, 69);
            label11.TabIndex = 24;
            label11.Text = "Each Sling Loads";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLOFW
            // 
            lblLOFW.BackColor = Color.FromArgb(10, 30, 46);
            lblLOFW.BorderStyle = BorderStyle.FixedSingle;
            lblLOFW.Dock = DockStyle.Fill;
            lblLOFW.Font = new Font("Bahnschrift", 13.8F);
            lblLOFW.ForeColor = Color.White;
            lblLOFW.Location = new Point(561, 67);
            lblLOFW.Name = "lblLOFW";
            lblLOFW.Size = new Size(171, 85);
            lblLOFW.TabIndex = 32;
            lblLOFW.Text = "0";
            lblLOFW.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBCFW
            // 
            lblBCFW.BackColor = Color.FromArgb(10, 30, 46);
            lblBCFW.BorderStyle = BorderStyle.FixedSingle;
            lblBCFW.Dock = DockStyle.Fill;
            lblBCFW.Font = new Font("Bahnschrift", 13.8F);
            lblBCFW.ForeColor = Color.White;
            lblBCFW.Location = new Point(561, 152);
            lblBCFW.Name = "lblBCFW";
            lblBCFW.Size = new Size(171, 74);
            lblBCFW.TabIndex = 33;
            lblBCFW.Text = "0";
            lblBCFW.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSWFW
            // 
            lblSWFW.BackColor = Color.FromArgb(10, 30, 46);
            lblSWFW.BorderStyle = BorderStyle.FixedSingle;
            lblSWFW.Dock = DockStyle.Fill;
            lblSWFW.Font = new Font("Bahnschrift", 13.8F);
            lblSWFW.ForeColor = Color.White;
            lblSWFW.Location = new Point(561, 226);
            lblSWFW.Name = "lblSWFW";
            lblSWFW.Size = new Size(171, 70);
            lblSWFW.TabIndex = 34;
            lblSWFW.Text = "0";
            lblSWFW.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPEW
            // 
            lblPEW.BackColor = Color.FromArgb(10, 30, 46);
            lblPEW.BorderStyle = BorderStyle.FixedSingle;
            lblPEW.Dock = DockStyle.Fill;
            lblPEW.Font = new Font("Bahnschrift", 13.8F);
            lblPEW.ForeColor = Color.White;
            lblPEW.Location = new Point(194, 296);
            lblPEW.Name = "lblPEW";
            lblPEW.Size = new Size(177, 72);
            lblPEW.TabIndex = 35;
            lblPEW.Text = "0";
            lblPEW.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPEFW
            // 
            lblPEFW.BackColor = Color.FromArgb(10, 30, 46);
            lblPEFW.BorderStyle = BorderStyle.FixedSingle;
            lblPEFW.Dock = DockStyle.Fill;
            lblPEFW.Font = new Font("Bahnschrift", 13.8F);
            lblPEFW.ForeColor = Color.White;
            lblPEFW.Location = new Point(561, 296);
            lblPEFW.Name = "lblPEFW";
            lblPEFW.Size = new Size(171, 72);
            lblPEFW.TabIndex = 36;
            lblPEFW.Text = "0";
            lblPEFW.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTWW
            // 
            lblTWW.BackColor = Color.FromArgb(10, 30, 46);
            lblTWW.BorderStyle = BorderStyle.FixedSingle;
            lblTWW.Dock = DockStyle.Fill;
            lblTWW.Font = new Font("Bahnschrift", 13.8F);
            lblTWW.ForeColor = Color.White;
            lblTWW.Location = new Point(194, 368);
            lblTWW.Name = "lblTWW";
            lblTWW.Size = new Size(177, 68);
            lblTWW.TabIndex = 37;
            lblTWW.Text = "0";
            lblTWW.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTWF
            // 
            lblTWF.BackColor = Color.FromArgb(10, 30, 46);
            lblTWF.BorderStyle = BorderStyle.FixedSingle;
            lblTWF.Dock = DockStyle.Fill;
            lblTWF.Font = new Font("Bahnschrift", 13.8F);
            lblTWF.ForeColor = Color.White;
            lblTWF.Location = new Point(377, 368);
            lblTWF.Name = "lblTWF";
            lblTWF.Size = new Size(178, 68);
            lblTWF.TabIndex = 38;
            lblTWF.Text = "0";
            lblTWF.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTWFW
            // 
            lblTWFW.BackColor = Color.FromArgb(10, 30, 46);
            lblTWFW.BorderStyle = BorderStyle.FixedSingle;
            lblTWFW.Dock = DockStyle.Fill;
            lblTWFW.Font = new Font("Bahnschrift", 13.8F);
            lblTWFW.ForeColor = Color.White;
            lblTWFW.Location = new Point(561, 368);
            lblTWFW.Name = "lblTWFW";
            lblTWFW.Size = new Size(171, 68);
            lblTWFW.TabIndex = 39;
            lblTWFW.Text = "0";
            lblTWFW.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblESLFW
            // 
            lblESLFW.BackColor = Color.FromArgb(10, 30, 46);
            lblESLFW.BorderStyle = BorderStyle.FixedSingle;
            lblESLFW.Dock = DockStyle.Fill;
            lblESLFW.Font = new Font("Bahnschrift", 13.8F);
            lblESLFW.ForeColor = Color.White;
            lblESLFW.Location = new Point(561, 436);
            lblESLFW.Name = "lblESLFW";
            lblESLFW.Size = new Size(171, 69);
            lblESLFW.TabIndex = 40;
            lblESLFW.Text = "0";
            lblESLFW.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtLOW);
            panel1.Location = new Point(194, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(177, 79);
            panel1.TabIndex = 41;
            // 
            // txtLOW
            // 
            txtLOW.BackColor = Color.FromArgb(22, 30, 46);
            txtLOW.BorderStyle = BorderStyle.None;
            txtLOW.Font = new Font("Bahnschrift", 16.2F);
            txtLOW.ForeColor = Color.White;
            txtLOW.Location = new Point(0, 23);
            txtLOW.Name = "txtLOW";
            txtLOW.Size = new Size(178, 33);
            txtLOW.TabIndex = 27;
            txtLOW.Text = "0";
            txtLOW.TextAlign = HorizontalAlignment.Center;
            txtLOW.KeyPress += txtLOW_KeyPress;
            // 
            // View06SlingLoadAssessment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 30, 46);
            ClientSize = new Size(963, 690);
            Controls.Add(PainelCentral);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "View06SlingLoadAssessment";
            Text = "View06SlingLoad";
            Load += View06SlingLoad_Load;
            PainelCentral.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PainelCentral;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel5;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button btnCalculate;
        private Button btnClear;
        private Label lblLOFW;
        private Label lblBCFW;
        private Label lblSWFW;
        private Label lblPEW;
        private Label lblPEFW;
        private Label lblTWW;
        private Label lblTWF;
        private Label lblTWFW;
        private Label lblESLFW;
        private Panel panel6;
        private TextBox txtSWW;
        private Panel panel4;
        private TextBox txtBCF;
        private Panel panel3;
        private TextBox txtBCW;
        private Panel panel2;
        private TextBox txtLOF;
        private Panel panel1;
        private TextBox txtLOW;
        private Panel panel8;
        private TextBox txtPEF;
        private Panel panel7;
        private TextBox txtSWF;
    }
}