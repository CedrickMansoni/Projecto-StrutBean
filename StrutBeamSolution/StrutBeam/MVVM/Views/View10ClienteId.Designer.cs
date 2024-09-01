namespace StrutBeam.MVVM.Views
{
    partial class View10ClienteId
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
            txtId = new TextBox();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 12F);
            txtId.Location = new Point(12, 35);
            txtId.Name = "txtId";
            txtId.PlaceholderText = "Id";
            txtId.Size = new Size(841, 34);
            txtId.TabIndex = 8;
            txtId.TextAlign = HorizontalAlignment.Center;
            // 
            // View10ClienteId
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 30, 46);
            ClientSize = new Size(865, 105);
            Controls.Add(txtId);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximumSize = new Size(883, 152);
            MinimumSize = new Size(883, 152);
            Name = "View10ClienteId";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My ID";
            Load += View10ClienteId_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
    }
}