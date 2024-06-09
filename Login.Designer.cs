namespace PBL3
{
    partial class Login
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
            btlogin = new Button();
            txtUsername = new TextBox();
            txtPass = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btcancel = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // btlogin
            // 
            btlogin.Location = new Point(71, 207);
            btlogin.Margin = new Padding(2);
            btlogin.Name = "btlogin";
            btlogin.Size = new Size(76, 23);
            btlogin.TabIndex = 0;
            btlogin.Text = "Login";
            btlogin.UseVisualStyleBackColor = true;
            btlogin.Click += btlogin_Click;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.HighlightText;
            txtUsername.Location = new Point(83, 94);
            txtUsername.Margin = new Padding(2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(144, 23);
            txtUsername.TabIndex = 1;
            txtUsername.KeyDown += txtUsername_KeyDown;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(83, 151);
            txtPass.Margin = new Padding(2);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(144, 23);
            txtPass.TabIndex = 2;
            txtPass.KeyDown += txtPass_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 71);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 3;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 127);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // btcancel
            // 
            btcancel.Location = new Point(165, 207);
            btcancel.Margin = new Padding(2);
            btcancel.Name = "btcancel";
            btcancel.Size = new Size(76, 23);
            btcancel.TabIndex = 5;
            btcancel.Text = "Cancel";
            btcancel.UseVisualStyleBackColor = true;
            btcancel.Click += btcancel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Lucida Handwriting", 24F);
            label3.Location = new Point(71, 9);
            label3.Name = "label3";
            label3.Size = new Size(140, 41);
            label3.TabIndex = 6;
            label3.Text = "NVGym";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(288, 298);
            Controls.Add(label3);
            Controls.Add(btcancel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPass);
            Controls.Add(txtUsername);
            Controls.Add(btlogin);
            Margin = new Padding(2);
            Name = "Login";
            Text = "Log In";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btlogin;
        private TextBox txtUsername;
        private TextBox txtPass;
        private Label label1;
        private Label label2;
        private Button btcancel;
        private Label label3;
    }
}