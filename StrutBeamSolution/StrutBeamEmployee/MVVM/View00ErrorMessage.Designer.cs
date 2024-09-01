namespace StrutBeamEmployee.MVVM
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
            lblTitle = new Label();
            panel4 = new Panel();
            panel3 = new Panel();
            btnYes = new Button();
            lblMessage = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            label3 = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 13F);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(9, 8);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(410, 28);
            lblTitle.TabIndex = 20;
            lblTitle.Text = "Error";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Orange;
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(9, 0);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(410, 8);
            panel4.TabIndex = 24;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Orange;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(9, 158);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(410, 8);
            panel3.TabIndex = 23;
            // 
            // btnYes
            // 
            btnYes.Location = new Point(328, 129);
            btnYes.Margin = new Padding(3, 2, 3, 2);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(82, 22);
            btnYes.TabIndex = 18;
            btnYes.Text = "Ok";
            btnYes.UseVisualStyleBackColor = true;
            btnYes.Click += btnYes_Click;
            // 
            // lblMessage
            // 
            lblMessage.Font = new Font("Segoe UI", 13F);
            lblMessage.ForeColor = Color.White;
            lblMessage.Location = new Point(43, 56);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(373, 64);
            lblMessage.TabIndex = 17;
            lblMessage.Text = "Message";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Orange;
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(419, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(9, 166);
            panel2.TabIndex = 22;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Orange;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(9, 166);
            panel1.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Orange;
            label3.Location = new Point(-32, 19);
            label3.Name = "label3";
            label3.Size = new Size(582, 26);
            label3.TabIndex = 19;
            label3.Text = "_________________________________________________________";
            // 
            // View00ErrorMessage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 10, 5);
            ClientSize = new Size(428, 166);
            Controls.Add(lblTitle);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(btnYes);
            Controls.Add(lblMessage);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "View00ErrorMessage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View00ErrorMessage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Panel panel4;
        private Panel panel3;
        private Button btnYes;
        private Label lblMessage;
        private Panel panel2;
        private Panel panel1;
        private Label label3;
    }
}