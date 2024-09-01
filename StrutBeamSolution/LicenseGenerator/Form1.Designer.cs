namespace LicenseGenerator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            txtCustomerId = new TextBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            txtMonths = new TextBox();
            btnGenerator = new Button();
            progressBar1 = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 20);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 0;
            label1.Text = "Customer ID";
            // 
            // txtCustomerId
            // 
            txtCustomerId.Font = new Font("Segoe UI", 14F);
            txtCustomerId.Location = new Point(81, 43);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.Size = new Size(265, 39);
            txtCustomerId.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonShadow;
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 174);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(352, 20);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 5;
            label3.Text = "Months";
            // 
            // txtMonths
            // 
            txtMonths.Font = new Font("Segoe UI", 14F);
            txtMonths.Location = new Point(352, 43);
            txtMonths.Name = "txtMonths";
            txtMonths.Size = new Size(91, 39);
            txtMonths.TabIndex = 6;
            // 
            // btnGenerator
            // 
            btnGenerator.Font = new Font("Segoe UI", 12F);
            btnGenerator.Location = new Point(81, 88);
            btnGenerator.Name = "btnGenerator";
            btnGenerator.Size = new Size(362, 68);
            btnGenerator.TabIndex = 7;
            btnGenerator.Text = "Generate license";
            btnGenerator.UseVisualStyleBackColor = true;
            btnGenerator.Click += btnGenerator_Click;
            // 
            // progressBar1
            // 
            progressBar1.Dock = DockStyle.Bottom;
            progressBar1.Location = new Point(75, 162);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(376, 12);
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 174);
            Controls.Add(progressBar1);
            Controls.Add(btnGenerator);
            Controls.Add(txtMonths);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(txtCustomerId);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "License Generator";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCustomerId;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox txtMonths;
        private Button btnGenerator;
        private ProgressBar progressBar1;
    }
}
