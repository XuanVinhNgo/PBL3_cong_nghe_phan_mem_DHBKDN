namespace PBL3
{
    partial class GymDataFormPT
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
            label1 = new Label();
            tabPack = new TabPage();
            DGV_Pack = new DataGridView();
            tabMachine = new TabPage();
            DGV_Machine = new DataGridView();
            comboBox7 = new ComboBox();
            comboBox8 = new ComboBox();
            btn_Mac_Sort = new Button();
            label5 = new Label();
            tabPT = new TabPage();
            txtSearch_PT = new TextBox();
            btnSearch_PT = new Button();
            btnSort_PT = new Button();
            cbbSort_PT = new ComboBox();
            DGV_PT = new DataGridView();
            tabMem = new TabPage();
            txtSearch = new TextBox();
            btn_Search = new Button();
            btnSort = new Button();
            cbbSort = new ComboBox();
            bt_soluongkhach = new Button();
            DGV_Mem = new DataGridView();
            tabControlGym = new TabControl();
            tabLogout = new TabPage();
            tabPack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Pack).BeginInit();
            tabMachine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Machine).BeginInit();
            tabPT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_PT).BeginInit();
            tabMem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Mem).BeginInit();
            tabControlGym.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Lucida Handwriting", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(290, 5);
            label1.Name = "label1";
            label1.Size = new Size(212, 63);
            label1.TabIndex = 0;
            label1.Text = "NVGym";
            // 
            // tabPack
            // 
            tabPack.BackColor = Color.LightYellow;
            tabPack.Controls.Add(DGV_Pack);
            tabPack.Location = new Point(4, 24);
            tabPack.Margin = new Padding(2);
            tabPack.Name = "tabPack";
            tabPack.Padding = new Padding(2);
            tabPack.Size = new Size(945, 459);
            tabPack.TabIndex = 6;
            tabPack.Text = "Membership package";
            // 
            // DGV_Pack
            // 
            DGV_Pack.BackgroundColor = Color.LightYellow;
            DGV_Pack.BorderStyle = BorderStyle.None;
            DGV_Pack.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Pack.Location = new Point(16, 45);
            DGV_Pack.Margin = new Padding(2);
            DGV_Pack.Name = "DGV_Pack";
            DGV_Pack.RowHeadersWidth = 62;
            DGV_Pack.Size = new Size(909, 353);
            DGV_Pack.TabIndex = 0;
            // 
            // tabMachine
            // 
            tabMachine.BackColor = Color.LightYellow;
            tabMachine.Controls.Add(DGV_Machine);
            tabMachine.Controls.Add(comboBox7);
            tabMachine.Controls.Add(comboBox8);
            tabMachine.Controls.Add(btn_Mac_Sort);
            tabMachine.Controls.Add(label5);
            tabMachine.Location = new Point(4, 24);
            tabMachine.Name = "tabMachine";
            tabMachine.Padding = new Padding(3);
            tabMachine.Size = new Size(945, 459);
            tabMachine.TabIndex = 3;
            tabMachine.Text = "Machine";
            // 
            // DGV_Machine
            // 
            DGV_Machine.BackgroundColor = Color.LightYellow;
            DGV_Machine.BorderStyle = BorderStyle.None;
            DGV_Machine.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Machine.Location = new Point(31, 65);
            DGV_Machine.Name = "DGV_Machine";
            DGV_Machine.RowHeadersWidth = 62;
            DGV_Machine.Size = new Size(887, 338);
            DGV_Machine.TabIndex = 18;
            // 
            // comboBox7
            // 
            comboBox7.Font = new Font("Segoe UI", 20F);
            comboBox7.FormattingEnabled = true;
            comboBox7.Location = new Point(608, 11);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new Size(185, 45);
            comboBox7.TabIndex = 16;
            // 
            // comboBox8
            // 
            comboBox8.Font = new Font("Segoe UI", 20F);
            comboBox8.FormattingEnabled = true;
            comboBox8.Location = new Point(144, 11);
            comboBox8.Name = "comboBox8";
            comboBox8.Size = new Size(172, 45);
            comboBox8.TabIndex = 17;
            // 
            // btn_Mac_Sort
            // 
            btn_Mac_Sort.Font = new Font("Segoe UI", 20F);
            btn_Mac_Sort.Location = new Point(799, 11);
            btn_Mac_Sort.Name = "btn_Mac_Sort";
            btn_Mac_Sort.Size = new Size(119, 48);
            btn_Mac_Sort.TabIndex = 15;
            btn_Mac_Sort.Text = "Sort";
            btn_Mac_Sort.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.BackColor = Color.LightYellow;
            label5.Font = new Font("Segoe UI", 20F);
            label5.ForeColor = Color.Black;
            label5.ImageAlign = ContentAlignment.MiddleLeft;
            label5.Location = new Point(18, 14);
            label5.Name = "label5";
            label5.Size = new Size(120, 37);
            label5.TabIndex = 13;
            label5.Text = "Filter";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tabPT
            // 
            tabPT.BackColor = Color.LightYellow;
            tabPT.Controls.Add(txtSearch_PT);
            tabPT.Controls.Add(btnSearch_PT);
            tabPT.Controls.Add(btnSort_PT);
            tabPT.Controls.Add(cbbSort_PT);
            tabPT.Controls.Add(DGV_PT);
            tabPT.Location = new Point(4, 24);
            tabPT.Name = "tabPT";
            tabPT.Padding = new Padding(3);
            tabPT.Size = new Size(945, 459);
            tabPT.TabIndex = 1;
            tabPT.Text = "Personal Trainer";
            // 
            // txtSearch_PT
            // 
            txtSearch_PT.Location = new Point(59, 19);
            txtSearch_PT.Margin = new Padding(2);
            txtSearch_PT.Name = "txtSearch_PT";
            txtSearch_PT.Size = new Size(150, 23);
            txtSearch_PT.TabIndex = 18;
            // 
            // btnSearch_PT
            // 
            btnSearch_PT.Location = new Point(211, 18);
            btnSearch_PT.Margin = new Padding(2);
            btnSearch_PT.Name = "btnSearch_PT";
            btnSearch_PT.Size = new Size(66, 20);
            btnSearch_PT.TabIndex = 17;
            btnSearch_PT.Text = "Search";
            btnSearch_PT.UseVisualStyleBackColor = true;
            // 
            // btnSort_PT
            // 
            btnSort_PT.Location = new Point(533, 17);
            btnSort_PT.Margin = new Padding(2);
            btnSort_PT.Name = "btnSort_PT";
            btnSort_PT.Size = new Size(64, 21);
            btnSort_PT.TabIndex = 16;
            btnSort_PT.Text = "Sort";
            btnSort_PT.UseVisualStyleBackColor = true;
            // 
            // cbbSort_PT
            // 
            cbbSort_PT.FormattingEnabled = true;
            cbbSort_PT.Location = new Point(409, 18);
            cbbSort_PT.Margin = new Padding(2);
            cbbSort_PT.Name = "cbbSort_PT";
            cbbSort_PT.Size = new Size(122, 23);
            cbbSort_PT.TabIndex = 15;
            // 
            // DGV_PT
            // 
            DGV_PT.BackgroundColor = Color.LightYellow;
            DGV_PT.BorderStyle = BorderStyle.None;
            DGV_PT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_PT.Location = new Point(18, 50);
            DGV_PT.Name = "DGV_PT";
            DGV_PT.RowHeadersWidth = 62;
            DGV_PT.Size = new Size(916, 354);
            DGV_PT.TabIndex = 11;
            // 
            // tabMem
            // 
            tabMem.BackColor = Color.LightYellow;
            tabMem.Controls.Add(txtSearch);
            tabMem.Controls.Add(btn_Search);
            tabMem.Controls.Add(btnSort);
            tabMem.Controls.Add(cbbSort);
            tabMem.Controls.Add(bt_soluongkhach);
            tabMem.Controls.Add(DGV_Mem);
            tabMem.Location = new Point(4, 24);
            tabMem.Name = "tabMem";
            tabMem.Padding = new Padding(3);
            tabMem.Size = new Size(945, 459);
            tabMem.TabIndex = 0;
            tabMem.Text = "Member";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(76, 19);
            txtSearch.Margin = new Padding(2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(150, 23);
            txtSearch.TabIndex = 12;
            // 
            // btn_Search
            // 
            btn_Search.Location = new Point(229, 18);
            btn_Search.Margin = new Padding(2);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(66, 20);
            btn_Search.TabIndex = 11;
            btn_Search.Text = "Search";
            btn_Search.UseVisualStyleBackColor = true;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(551, 17);
            btnSort.Margin = new Padding(2);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(64, 21);
            btnSort.TabIndex = 10;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            // 
            // cbbSort
            // 
            cbbSort.FormattingEnabled = true;
            cbbSort.Location = new Point(426, 18);
            cbbSort.Margin = new Padding(2);
            cbbSort.Name = "cbbSort";
            cbbSort.Size = new Size(122, 23);
            cbbSort.TabIndex = 9;
            // 
            // bt_soluongkhach
            // 
            bt_soluongkhach.Location = new Point(777, 16);
            bt_soluongkhach.Margin = new Padding(2);
            bt_soluongkhach.Name = "bt_soluongkhach";
            bt_soluongkhach.Size = new Size(125, 25);
            bt_soluongkhach.TabIndex = 8;
            bt_soluongkhach.Text = "Tổng số khách";
            bt_soluongkhach.UseVisualStyleBackColor = true;
            // 
            // DGV_Mem
            // 
            DGV_Mem.BackgroundColor = Color.LightYellow;
            DGV_Mem.BorderStyle = BorderStyle.None;
            DGV_Mem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Mem.Location = new Point(16, 55);
            DGV_Mem.Name = "DGV_Mem";
            DGV_Mem.RowHeadersWidth = 62;
            DGV_Mem.Size = new Size(918, 353);
            DGV_Mem.TabIndex = 0;
            // 
            // tabControlGym
            // 
            tabControlGym.Controls.Add(tabMem);
            tabControlGym.Controls.Add(tabPT);
            tabControlGym.Controls.Add(tabMachine);
            tabControlGym.Controls.Add(tabPack);
            tabControlGym.Controls.Add(tabLogout);
            tabControlGym.Location = new Point(-4, 68);
            tabControlGym.Name = "tabControlGym";
            tabControlGym.SelectedIndex = 0;
            tabControlGym.Size = new Size(953, 487);
            tabControlGym.TabIndex = 10;
            // 
            // tabLogout
            // 
            tabLogout.BackColor = Color.LightYellow;
            tabLogout.Location = new Point(4, 24);
            tabLogout.Name = "tabLogout";
            tabLogout.Padding = new Padding(3);
            tabLogout.Size = new Size(945, 459);
            tabLogout.TabIndex = 7;
            tabLogout.Text = "Log out";
            tabLogout.Enter += tabLogout_Enter;
            // 
            // GymDataFormPT
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(949, 554);
            Controls.Add(tabControlGym);
            Controls.Add(label1);
            Name = "GymDataFormPT";
            Text = "Gym Management for Personal Trainer";
            tabPack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGV_Pack).EndInit();
            tabMachine.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGV_Machine).EndInit();
            tabPT.ResumeLayout(false);
            tabPT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_PT).EndInit();
            tabMem.ResumeLayout(false);
            tabMem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Mem).EndInit();
            tabControlGym.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabPage tabPack;
        private DataGridView DGV_Pack;
        private TabPage tabMachine;
        private DataGridView DGV_Machine;
        private ComboBox comboBox7;
        private ComboBox comboBox8;
        private Button btn_Mac_Sort;
        private Label label5;
        private TabPage tabPT;
        private DataGridView DGV_PT;
        private TabPage tabMem;
        private Button bt_soluongkhach;
        private DataGridView DGV_Mem;
        private TabControl tabControlGym;
        private Button btn_Search;
        private Button btnSort;
        private ComboBox cbbSort;
        private TextBox txtSearch;
        private TextBox txtSearch_PT;
        private Button btnSearch_PT;
        private Button btnSort_PT;
        private ComboBox cbbSort_PT;
        private TabPage tabLogout;
    }
}