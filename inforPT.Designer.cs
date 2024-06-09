namespace PBL3
{
    partial class inforPT
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
            label4 = new Label();
            label5 = new Label();
            txtName = new TextBox();
            txtLuong = new TextBox();
            txtmaso = new TextBox();
            txtChuyenmon = new RichTextBox();
            txtKinhnghiem = new RichTextBox();
            btcancel = new Button();
            bt_savePT = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 46);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Họ tên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 139);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 1;
            label2.Text = "Lương:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(330, 50);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 2;
            label3.Text = "Mã số:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(297, 80);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 3;
            label4.Text = "Kinh nghiệm:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 82);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 4;
            label5.Text = "Chuyên môn:";
            // 
            // txtName
            // 
            txtName.Location = new Point(141, 44);
            txtName.Margin = new Padding(2, 2, 2, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(137, 23);
            txtName.TabIndex = 5;
            // 
            // txtLuong
            // 
            txtLuong.Location = new Point(143, 137);
            txtLuong.Margin = new Padding(2, 2, 2, 2);
            txtLuong.Name = "txtLuong";
            txtLuong.Size = new Size(137, 23);
            txtLuong.TabIndex = 7;
            // 
            // txtmaso
            // 
            txtmaso.Location = new Point(380, 46);
            txtmaso.Margin = new Padding(2, 2, 2, 2);
            txtmaso.Name = "txtmaso";
            txtmaso.Size = new Size(85, 23);
            txtmaso.TabIndex = 8;
            // 
            // txtChuyenmon
            // 
            txtChuyenmon.Location = new Point(143, 80);
            txtChuyenmon.Margin = new Padding(2, 2, 2, 2);
            txtChuyenmon.Name = "txtChuyenmon";
            txtChuyenmon.Size = new Size(136, 44);
            txtChuyenmon.TabIndex = 9;
            txtChuyenmon.Text = "";
            // 
            // txtKinhnghiem
            // 
            txtKinhnghiem.Location = new Point(382, 79);
            txtKinhnghiem.Margin = new Padding(2, 2, 2, 2);
            txtKinhnghiem.Name = "txtKinhnghiem";
            txtKinhnghiem.Size = new Size(136, 46);
            txtKinhnghiem.TabIndex = 10;
            txtKinhnghiem.Text = "";
            // 
            // btcancel
            // 
            btcancel.Location = new Point(306, 209);
            btcancel.Margin = new Padding(2, 2, 2, 2);
            btcancel.Name = "btcancel";
            btcancel.Size = new Size(71, 23);
            btcancel.TabIndex = 28;
            btcancel.Text = "Cancel";
            btcancel.UseVisualStyleBackColor = true;
            btcancel.Click += btcancel_Click;
            // 
            // bt_savePT
            // 
            bt_savePT.Location = new Point(175, 209);
            bt_savePT.Margin = new Padding(2, 2, 2, 2);
            bt_savePT.Name = "bt_savePT";
            bt_savePT.Size = new Size(71, 23);
            bt_savePT.TabIndex = 27;
            bt_savePT.Text = "Save";
            bt_savePT.UseVisualStyleBackColor = true;
            bt_savePT.Click += bt_savePT_Click;
            // 
            // inforPT
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(btcancel);
            Controls.Add(bt_savePT);
            Controls.Add(txtKinhnghiem);
            Controls.Add(txtChuyenmon);
            Controls.Add(txtmaso);
            Controls.Add(txtLuong);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "inforPT";
            Text = "Thông tin PT";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtName;
        private TextBox txtLuong;
        private TextBox txtmaso;
        private RichTextBox txtChuyenmon;
        private RichTextBox txtKinhnghiem;
        private Button btcancel;
        private Button bt_savePT;
    }
}