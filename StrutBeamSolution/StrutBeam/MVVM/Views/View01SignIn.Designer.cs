namespace StrutBeam.MVVM.Views
{
    partial class View01SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View01SignIn));
            pictureBox1 = new PictureBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            btnSignIn = new Button();
            label1 = new Label();
            linkActivate = new LinkLabel();
            label2 = new Label();
            linkSignUp = new LinkLabel();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(167, 320);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F);
            txtUsername.Location = new Point(218, 135);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(370, 34);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(218, 178);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(370, 34);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(176, 135);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(176, 178);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(37, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.FromArgb(0, 192, 0);
            btnSignIn.BackgroundImageLayout = ImageLayout.None;
            btnSignIn.Font = new Font("Segoe UI", 13F);
            btnSignIn.ForeColor = SystemColors.Control;
            btnSignIn.ImageAlign = ContentAlignment.MiddleLeft;
            btnSignIn.Location = new Point(218, 222);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(250, 48);
            btnSignIn.TabIndex = 3;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(294, 11);
            label1.Name = "label1";
            label1.Size = new Size(174, 31);
            label1.TabIndex = 6;
            label1.Text = "STRUT HOIST";
            // 
            // linkActivate
            // 
            linkActivate.AutoSize = true;
            linkActivate.LinkColor = Color.White;
            linkActivate.Location = new Point(176, 286);
            linkActivate.Name = "linkActivate";
            linkActivate.Size = new Size(63, 20);
            linkActivate.TabIndex = 4;
            linkActivate.TabStop = true;
            linkActivate.Text = "Activate";
            linkActivate.LinkClicked += linkActivate_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(358, 286);
            label2.Name = "label2";
            label2.Size = new Size(164, 20);
            label2.TabIndex = 8;
            label2.Text = "Don´t have an account?";
            // 
            // linkSignUp
            // 
            linkSignUp.AutoSize = true;
            linkSignUp.LinkColor = Color.White;
            linkSignUp.Location = new Point(528, 286);
            linkSignUp.Name = "linkSignUp";
            linkSignUp.Size = new Size(61, 20);
            linkSignUp.TabIndex = 5;
            linkSignUp.TabStop = true;
            linkSignUp.Text = "Sign Up";
            linkSignUp.LinkClicked += linkSignUp_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Orange;
            label3.Location = new Point(184, 31);
            label3.Name = "label3";
            label3.Size = new Size(417, 31);
            label3.TabIndex = 10;
            label3.Text = "_______________________________";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(6, 69);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(36, 27);
            textBox3.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Orange;
            label4.Location = new Point(53, 286);
            label4.Name = "label4";
            label4.Size = new Size(664, 31);
            label4.TabIndex = 13;
            label4.Text = "__________________________________________________";
            // 
            // button1
            // 
            button1.BackColor = Color.CadetBlue;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Font = new Font("Segoe UI", 13F);
            button1.ForeColor = SystemColors.Control;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(474, 222);
            button1.Name = "button1";
            button1.Size = new Size(115, 48);
            button1.TabIndex = 16;
            button1.Text = "My Id";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // View01SignIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 30, 46);
            ClientSize = new Size(618, 320);
            Controls.Add(button1);
            Controls.Add(linkSignUp);
            Controls.Add(label2);
            Controls.Add(linkActivate);
            Controls.Add(label1);
            Controls.Add(btnSignIn);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(636, 367);
            MinimumSize = new Size(636, 367);
            Name = "View01SignIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Structural Beam Safe load Hoisting Calculator";
            FormClosing += View01SignIn_FormClosing;
            Load += View01SignIn_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button btnSignIn;
        private Label label1;
        private LinkLabel linkActivate;
        private Label label2;
        private LinkLabel linkSignUp;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private Button button1;
    }
}