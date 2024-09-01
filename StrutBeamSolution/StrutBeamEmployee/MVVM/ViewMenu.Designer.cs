namespace StrutBeamEmployee.MVVM
{
    partial class ViewMenu
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            PainelFormsExternos = new Panel();
            dataGrid = new DataGridView();
            PainelEsquerdo = new Panel();
            PainelMenu = new Panel();
            btnViewLicenses = new Button();
            btnCustomerList = new Button();
            btnGenerateLicense = new Button();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            PainelFormsExternos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            PainelEsquerdo.SuspendLayout();
            PainelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // PainelFormsExternos
            // 
            PainelFormsExternos.BorderStyle = BorderStyle.FixedSingle;
            PainelFormsExternos.Controls.Add(dataGrid);
            PainelFormsExternos.Dock = DockStyle.Fill;
            PainelFormsExternos.Location = new Point(271, 0);
            PainelFormsExternos.Margin = new Padding(3, 2, 3, 2);
            PainelFormsExternos.Name = "PainelFormsExternos";
            PainelFormsExternos.Size = new Size(641, 463);
            PainelFormsExternos.TabIndex = 3;
            // 
            // dataGrid
            // 
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Location = new Point(5, 7);
            dataGrid.Name = "dataGrid";
            dataGrid.ReadOnly = true;
            dataGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle1.BackColor = Color.DarkKhaki;
            dataGridViewCellStyle1.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGrid.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid.Size = new Size(626, 443);
            dataGrid.TabIndex = 1;
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
            PainelEsquerdo.Size = new Size(271, 463);
            PainelEsquerdo.TabIndex = 2;
            // 
            // PainelMenu
            // 
            PainelMenu.Controls.Add(btnViewLicenses);
            PainelMenu.Controls.Add(btnCustomerList);
            PainelMenu.Controls.Add(btnGenerateLicense);
            PainelMenu.Location = new Point(6, 140);
            PainelMenu.Margin = new Padding(3, 2, 3, 2);
            PainelMenu.Name = "PainelMenu";
            PainelMenu.Size = new Size(255, 197);
            PainelMenu.TabIndex = 0;
            // 
            // btnViewLicenses
            // 
            btnViewLicenses.Location = new Point(10, 133);
            btnViewLicenses.Margin = new Padding(3, 2, 3, 2);
            btnViewLicenses.Name = "btnViewLicenses";
            btnViewLicenses.Size = new Size(234, 49);
            btnViewLicenses.TabIndex = 17;
            btnViewLicenses.Text = "VIEW LICENSES";
            btnViewLicenses.UseVisualStyleBackColor = true;
            btnViewLicenses.Click += btnViewLicenses_Click;
            // 
            // btnCustomerList
            // 
            btnCustomerList.Location = new Point(10, 11);
            btnCustomerList.Margin = new Padding(3, 2, 3, 2);
            btnCustomerList.Name = "btnCustomerList";
            btnCustomerList.Size = new Size(234, 49);
            btnCustomerList.TabIndex = 15;
            btnCustomerList.Text = "UPDATE LICENSE";
            btnCustomerList.UseVisualStyleBackColor = true;
            btnCustomerList.Click += btnCustomerList_Click;
            // 
            // btnGenerateLicense
            // 
            btnGenerateLicense.Location = new Point(10, 73);
            btnGenerateLicense.Margin = new Padding(3, 2, 3, 2);
            btnGenerateLicense.Name = "btnGenerateLicense";
            btnGenerateLicense.Size = new Size(234, 49);
            btnGenerateLicense.TabIndex = 16;
            btnGenerateLicense.Text = "GENERATE LICENSE";
            btnGenerateLicense.UseVisualStyleBackColor = true;
            btnGenerateLicense.Click += btnGenerateLicense_Click;
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
            // ViewMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(2, 50, 4);
            ClientSize = new Size(912, 463);
            Controls.Add(PainelFormsExternos);
            Controls.Add(PainelEsquerdo);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ViewMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            FormClosed += ViewMenu_FormClosed;
            PainelFormsExternos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            PainelEsquerdo.ResumeLayout(false);
            PainelEsquerdo.PerformLayout();
            PainelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel PainelFormsExternos;
        private Panel PainelEsquerdo;
        private Panel PainelMenu;
        private Button btnCustomerList;
        private Button btnGenerateLicense;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label label3;
        private DataGridView dataGrid;
        private Button btnViewLicenses;
    }
}