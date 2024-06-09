namespace PBL3
{
    partial class inforRecep
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            txtSalary = new TextBox();
            txtChuyenmon = new RichTextBox();
            btcancel = new Button();
            bt_save = new Button();
            label4 = new Label();
            label5 = new Label();
            txtMaLT = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 38);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 151);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 1;
            label2.Text = "Mức lương:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 76);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 2;
            label3.Text = "Chuyên môn:";
            // 
            // txtName
            // 
            txtName.Location = new Point(167, 35);
            txtName.Margin = new Padding(2, 2, 2, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(157, 23);
            txtName.TabIndex = 3;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(167, 149);
            txtSalary.Margin = new Padding(2, 2, 2, 2);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(157, 23);
            txtSalary.TabIndex = 4;
            // 
            // txtChuyenmon
            // 
            txtChuyenmon.Location = new Point(167, 69);
            txtChuyenmon.Margin = new Padding(2, 2, 2, 2);
            txtChuyenmon.Name = "txtChuyenmon";
            txtChuyenmon.Size = new Size(157, 59);
            txtChuyenmon.TabIndex = 5;
            txtChuyenmon.Text = "";
            // 
            // btcancel
            // 
            btcancel.Location = new Point(307, 212);
            btcancel.Margin = new Padding(2, 2, 2, 2);
            btcancel.Name = "btcancel";
            btcancel.Size = new Size(71, 23);
            btcancel.TabIndex = 26;
            btcancel.Text = "Cancel";
            btcancel.UseVisualStyleBackColor = true;
            btcancel.Click += btcancel_Click;
            // 
            // bt_save
            // 
            bt_save.Location = new Point(174, 212);
            bt_save.Margin = new Padding(2, 2, 2, 2);
            bt_save.Name = "bt_save";
            bt_save.Size = new Size(71, 23);
            bt_save.TabIndex = 25;
            bt_save.Text = "Save";
            bt_save.UseVisualStyleBackColor = true;
            bt_save.Click += bt_save_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(328, 151);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 27;
            label4.Text = "VND";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(357, 35);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 28;
            label5.Text = "Mã số:";
            // 
            // txtMaLT
            // 
            txtMaLT.Location = new Point(407, 35);
            txtMaLT.Margin = new Padding(2, 2, 2, 2);
            txtMaLT.Name = "txtMaLT";
            txtMaLT.Size = new Size(80, 23);
            txtMaLT.TabIndex = 29;
            // 
            // inforRecep
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(txtMaLT);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btcancel);
            Controls.Add(bt_save);
            Controls.Add(txtChuyenmon);
            Controls.Add(txtSalary);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "inforRecep";
            Text = "Thông tin nhân viên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private TextBox txtSalary;
        private RichTextBox txtChuyenmon;
        private Button btcancel;
        private Button bt_save;
        private Label label4;
        private Label label5;
        private TextBox txtMaLT;
    }
}