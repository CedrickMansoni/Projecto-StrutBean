namespace StrutBeam.MVVM.Views
{
    partial class View00ErrorMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View00ErrorMessage));
            lblMessage = new Label();
            btnYes = new Button();
            label3 = new Label();
            lblTitle = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            SuspendLayout();
            // 
            // lblMessage
            // 
            lblMessage.Font = new Font("Segoe UI", 13F);
            lblMessage.ForeColor = Color.White;
            lblMessage.Location = new Point(12, 75);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(426, 177);
            lblMessage.TabIndex = 0;
            lblMessage.Text = "Message";
            // 
            // btnYes
            // 
            btnYes.Location = new Point(340, 255);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(94, 29);
            btnYes.TabIndex = 1;
            btnYes.Text = "Ok";
            btnYes.UseVisualStyleBackColor = true;
            btnYes.Click += btnYes_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Orange;
            label3.Location = new Point(-73, 25);
            label3.Name = "label3";
            label3.Size = new Size(755, 31);
            label3.TabIndex = 11;
            label3.Text = "_________________________________________________________";
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 13F);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(10, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(430, 38);
            lblTitle.TabIndex = 12;
            lblTitle.Text = "Error";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Orange;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 300);
            panel1.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Orange;
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(440, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 300);
            panel2.TabIndex = 14;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Orange;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(10, 290);
            panel3.Name = "panel3";
            panel3.Size = new Size(430, 10);
            panel3.TabIndex = 15;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Orange;
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(10, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(430, 10);
            panel4.TabIndex = 16;
            // 
            // View00ErrorMessage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 10, 5);
            ClientSize = new Size(450, 300);
            Controls.Add(lblTitle);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(btnYes);
            Controls.Add(lblMessage);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(450, 300);
            MinimumSize = new Size(450, 300);
            Name = "View00ErrorMessage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View00ErrorMessage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMessage;
        private Button btnYes;
        private Label label3;
        private Label lblTitle;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}