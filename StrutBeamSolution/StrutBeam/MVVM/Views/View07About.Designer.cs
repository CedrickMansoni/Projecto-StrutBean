namespace StrutBeam.MVVM.Views
{
    partial class View07About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View07About));
            label1 = new Label();
            label3 = new Label();
            lblText = new Label();
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Showcard Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1719, 31);
            label1.TabIndex = 13;
            label1.Text = "ABOUT THIS APPLICATION";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Showcard Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Orange;
            label3.Location = new Point(0, 31);
            label3.Name = "label3";
            label3.Size = new Size(1719, 31);
            label3.TabIndex = 14;
            label3.Text = "___________________________________________________________________________________________________________________________________________________________________________";
            // 
            // lblText
            // 
            lblText.Dock = DockStyle.Fill;
            lblText.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblText.ForeColor = Color.White;
            lblText.Location = new Point(112, 62);
            lblText.Name = "lblText";
            lblText.Size = new Size(1495, 648);
            lblText.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Orange;
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 710);
            panel1.Name = "panel1";
            panel1.Size = new Size(1719, 72);
            panel1.TabIndex = 16;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Bahnschrift", 13F);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(1719, 72);
            label2.TabIndex = 17;
            label2.Text = "For technical support please contact: Admin@additechsolutions.com |  clinton@additechsolutions.com";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1607, 62);
            panel2.Name = "panel2";
            panel2.Size = new Size(112, 648);
            panel2.TabIndex = 17;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 62);
            panel3.Name = "panel3";
            panel3.Size = new Size(112, 648);
            panel3.TabIndex = 18;
            // 
            // View07About
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 30, 46);
            ClientSize = new Size(1719, 782);
            Controls.Add(lblText);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "View07About";
            Text = "View07About";
            Load += View07About_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label lblText;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Panel panel3;
    }
}