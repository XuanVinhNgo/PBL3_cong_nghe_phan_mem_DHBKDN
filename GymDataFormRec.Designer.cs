namespace PBL3
{
    partial class GymDataFormRec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GymDataFormRec));
            label1 = new Label();
            tabPack = new TabPage();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            DGV_Pack = new DataGridView();
            tabMachine = new TabPage();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            DGV_Machine = new DataGridView();
            comboBox7 = new ComboBox();
            comboBox8 = new ComboBox();
            btn_Mac_Sort = new Button();
            label5 = new Label();
            tabReceptiionist = new TabPage();
            txtSearch_Recep = new TextBox();
            btnSearch_Recep = new Button();
            btnSort_Recep = new Button();
            cbbSort_Recep = new ComboBox();
            DGV_Recep = new DataGridView();
            addReceptionist = new Button();
            btnDelete = new Button();
            btn_updateRecep = new Button();
            tabPT = new TabPage();
            txtSearch_PT = new TextBox();
            btnSearch_PT = new Button();
            btnSort_PT = new Button();
            cbbSort_PT = new ComboBox();
            DGV_PT = new DataGridView();
            addPT = new Button();
            btn_PT_del = new Button();
            btn_PT_Update = new Button();
            tabMem = new TabPage();
            button10 = new Button();
            txtSearch = new TextBox();
            btn_Search = new Button();
            btnSort = new Button();
            cbbSort = new ComboBox();
            bt_soluongkhach = new Button();
            DGV_Mem = new DataGridView();
            btn_Mem_Add = new Button();
            btn_Mem_Update = new Button();
            btn_Mem_Del = new Button();
            tabControlGym = new TabControl();
            tabInvoice = new TabPage();
            button1 = new Button();
            button3 = new Button();
            DGV_Invoice = new DataGridView();
            tabLogOut = new TabPage();
            tabPack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Pack).BeginInit();
            tabMachine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Machine).BeginInit();
            tabReceptiionist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Recep).BeginInit();
            tabPT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_PT).BeginInit();
            tabMem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Mem).BeginInit();
            tabControlGym.SuspendLayout();
            tabInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Invoice).BeginInit();
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
            tabPack.BackColor = Color.FromArgb(192, 255, 255);
            tabPack.Controls.Add(button4);
            tabPack.Controls.Add(button5);
            tabPack.Controls.Add(button6);
            tabPack.Controls.Add(DGV_Pack);
            tabPack.Location = new Point(4, 24);
            tabPack.Margin = new Padding(2);
            tabPack.Name = "tabPack";
            tabPack.Padding = new Padding(2);
            tabPack.Size = new Size(945, 459);
            tabPack.TabIndex = 6;
            tabPack.Text = "Membership package";
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            button4.Image = Properties.Resources.add;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(263, 410);
            button4.Name = "button4";
            button4.Size = new Size(100, 38);
            button4.TabIndex = 8;
            button4.Text = "Add";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            button5.Image = Properties.Resources.edit;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(433, 410);
            button5.Name = "button5";
            button5.Size = new Size(100, 38);
            button5.TabIndex = 9;
            button5.Text = "Edit";
            button5.TextAlign = ContentAlignment.MiddleRight;
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            button6.Image = Properties.Resources.delete;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(597, 410);
            button6.Name = "button6";
            button6.Size = new Size(120, 38);
            button6.TabIndex = 10;
            button6.Text = "Delete";
            button6.TextAlign = ContentAlignment.MiddleRight;
            button6.UseVisualStyleBackColor = true;
            // 
            // DGV_Pack
            // 
            DGV_Pack.BackgroundColor = Color.FromArgb(192, 255, 255);
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
            tabMachine.BackColor = Color.FromArgb(192, 255, 255);
            tabMachine.Controls.Add(button7);
            tabMachine.Controls.Add(button8);
            tabMachine.Controls.Add(button9);
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
            // button7
            // 
            button7.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            button7.Image = Properties.Resources.add;
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(272, 416);
            button7.Name = "button7";
            button7.Size = new Size(100, 38);
            button7.TabIndex = 19;
            button7.Text = "Add";
            button7.TextAlign = ContentAlignment.MiddleRight;
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            button8.Image = Properties.Resources.edit;
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(441, 416);
            button8.Name = "button8";
            button8.Size = new Size(100, 38);
            button8.TabIndex = 20;
            button8.Text = "Edit";
            button8.TextAlign = ContentAlignment.MiddleRight;
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            button9.Image = Properties.Resources.delete;
            button9.ImageAlign = ContentAlignment.MiddleLeft;
            button9.Location = new Point(606, 416);
            button9.Name = "button9";
            button9.Size = new Size(120, 38);
            button9.TabIndex = 21;
            button9.Text = "Delete";
            button9.TextAlign = ContentAlignment.MiddleRight;
            button9.UseVisualStyleBackColor = true;
            // 
            // DGV_Machine
            // 
            DGV_Machine.BackgroundColor = Color.FromArgb(192, 255, 255);
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
            label5.Font = new Font("Segoe UI", 20F);
            label5.Image = (Image)resources.GetObject("label5.Image");
            label5.ImageAlign = ContentAlignment.MiddleLeft;
            label5.Location = new Point(18, 14);
            label5.Name = "label5";
            label5.Size = new Size(120, 37);
            label5.TabIndex = 13;
            label5.Text = "Filter";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tabReceptiionist
            // 
            tabReceptiionist.BackColor = Color.FromArgb(192, 255, 255);
            tabReceptiionist.Controls.Add(txtSearch_Recep);
            tabReceptiionist.Controls.Add(btnSearch_Recep);
            tabReceptiionist.Controls.Add(btnSort_Recep);
            tabReceptiionist.Controls.Add(cbbSort_Recep);
            tabReceptiionist.Controls.Add(DGV_Recep);
            tabReceptiionist.Controls.Add(addReceptionist);
            tabReceptiionist.Controls.Add(btnDelete);
            tabReceptiionist.Controls.Add(btn_updateRecep);
            tabReceptiionist.Location = new Point(4, 24);
            tabReceptiionist.Name = "tabReceptiionist";
            tabReceptiionist.Padding = new Padding(3);
            tabReceptiionist.Size = new Size(945, 459);
            tabReceptiionist.TabIndex = 2;
            tabReceptiionist.Text = "Receptionist";
            // 
            // txtSearch_Recep
            // 
            txtSearch_Recep.Location = new Point(50, 17);
            txtSearch_Recep.Margin = new Padding(2);
            txtSearch_Recep.Name = "txtSearch_Recep";
            txtSearch_Recep.Size = new Size(150, 23);
            txtSearch_Recep.TabIndex = 22;
            // 
            // btnSearch_Recep
            // 
            btnSearch_Recep.Location = new Point(202, 17);
            btnSearch_Recep.Margin = new Padding(2);
            btnSearch_Recep.Name = "btnSearch_Recep";
            btnSearch_Recep.Size = new Size(66, 20);
            btnSearch_Recep.TabIndex = 21;
            btnSearch_Recep.Text = "Search";
            btnSearch_Recep.UseVisualStyleBackColor = true;
            btnSearch_Recep.Click += btnSearch_Recep_Click;
            // 
            // btnSort_Recep
            // 
            btnSort_Recep.Location = new Point(524, 16);
            btnSort_Recep.Margin = new Padding(2);
            btnSort_Recep.Name = "btnSort_Recep";
            btnSort_Recep.Size = new Size(64, 21);
            btnSort_Recep.TabIndex = 20;
            btnSort_Recep.Text = "Sort";
            btnSort_Recep.UseVisualStyleBackColor = true;
            btnSort_Recep.Click += btnSort_Recep_Click;
            // 
            // cbbSort_Recep
            // 
            cbbSort_Recep.FormattingEnabled = true;
            cbbSort_Recep.Location = new Point(400, 17);
            cbbSort_Recep.Margin = new Padding(2);
            cbbSort_Recep.Name = "cbbSort_Recep";
            cbbSort_Recep.Size = new Size(122, 23);
            cbbSort_Recep.TabIndex = 19;
            // 
            // DGV_Recep
            // 
            DGV_Recep.BackgroundColor = Color.FromArgb(192, 255, 255);
            DGV_Recep.BorderStyle = BorderStyle.None;
            DGV_Recep.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Recep.Location = new Point(18, 50);
            DGV_Recep.Name = "DGV_Recep";
            DGV_Recep.RowHeadersWidth = 62;
            DGV_Recep.Size = new Size(909, 351);
            DGV_Recep.TabIndex = 11;
            // 
            // addReceptionist
            // 
            addReceptionist.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            addReceptionist.Image = Properties.Resources.add;
            addReceptionist.ImageAlign = ContentAlignment.MiddleLeft;
            addReceptionist.Location = new Point(109, 410);
            addReceptionist.Name = "addReceptionist";
            addReceptionist.Size = new Size(100, 38);
            addReceptionist.TabIndex = 12;
            addReceptionist.Text = "Add";
            addReceptionist.TextAlign = ContentAlignment.MiddleRight;
            addReceptionist.UseVisualStyleBackColor = true;
            addReceptionist.Click += addReceptionist_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            btnDelete.Image = Properties.Resources.delete;
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(657, 410);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 38);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.TextAlign = ContentAlignment.MiddleRight;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDeleteRecep_Click;
            // 
            // btn_updateRecep
            // 
            btn_updateRecep.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            btn_updateRecep.Image = Properties.Resources.edit;
            btn_updateRecep.ImageAlign = ContentAlignment.MiddleLeft;
            btn_updateRecep.Location = new Point(402, 410);
            btn_updateRecep.Name = "btn_updateRecep";
            btn_updateRecep.Size = new Size(100, 38);
            btn_updateRecep.TabIndex = 13;
            btn_updateRecep.Text = "Edit";
            btn_updateRecep.TextAlign = ContentAlignment.MiddleRight;
            btn_updateRecep.UseVisualStyleBackColor = true;
            btn_updateRecep.Click += btn_updateRecep_Click;
            // 
            // tabPT
            // 
            tabPT.BackColor = Color.FromArgb(192, 255, 255);
            tabPT.Controls.Add(txtSearch_PT);
            tabPT.Controls.Add(btnSearch_PT);
            tabPT.Controls.Add(btnSort_PT);
            tabPT.Controls.Add(cbbSort_PT);
            tabPT.Controls.Add(DGV_PT);
            tabPT.Controls.Add(addPT);
            tabPT.Controls.Add(btn_PT_del);
            tabPT.Controls.Add(btn_PT_Update);
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
            btnSearch_PT.Click += btnSearch_PT_Click;
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
            btnSort_PT.Click += btnSort_PT_Click;
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
            DGV_PT.BackgroundColor = Color.FromArgb(192, 255, 255);
            DGV_PT.BorderStyle = BorderStyle.None;
            DGV_PT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_PT.Location = new Point(18, 50);
            DGV_PT.Name = "DGV_PT";
            DGV_PT.RowHeadersWidth = 62;
            DGV_PT.Size = new Size(916, 354);
            DGV_PT.TabIndex = 11;
            // 
            // addPT
            // 
            addPT.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            addPT.Image = Properties.Resources.add;
            addPT.ImageAlign = ContentAlignment.MiddleLeft;
            addPT.Location = new Point(109, 410);
            addPT.Name = "addPT";
            addPT.Size = new Size(100, 38);
            addPT.TabIndex = 12;
            addPT.Text = "Add";
            addPT.TextAlign = ContentAlignment.MiddleRight;
            addPT.UseVisualStyleBackColor = true;
            addPT.Click += addPT_Click;
            // 
            // btn_PT_del
            // 
            btn_PT_del.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btn_PT_del.Image = Properties.Resources.delete;
            btn_PT_del.ImageAlign = ContentAlignment.MiddleLeft;
            btn_PT_del.Location = new Point(657, 410);
            btn_PT_del.Name = "btn_PT_del";
            btn_PT_del.Size = new Size(120, 38);
            btn_PT_del.TabIndex = 14;
            btn_PT_del.Text = "Delete";
            btn_PT_del.TextAlign = ContentAlignment.MiddleRight;
            btn_PT_del.UseVisualStyleBackColor = true;
            btn_PT_del.Click += btn_PT_del_Click;
            // 
            // btn_PT_Update
            // 
            btn_PT_Update.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btn_PT_Update.Image = Properties.Resources.edit;
            btn_PT_Update.ImageAlign = ContentAlignment.MiddleLeft;
            btn_PT_Update.Location = new Point(402, 410);
            btn_PT_Update.Name = "btn_PT_Update";
            btn_PT_Update.Size = new Size(100, 38);
            btn_PT_Update.TabIndex = 13;
            btn_PT_Update.Text = "Edit";
            btn_PT_Update.TextAlign = ContentAlignment.MiddleRight;
            btn_PT_Update.UseVisualStyleBackColor = true;
            btn_PT_Update.Click += btn_PT_Update_Click;
            // 
            // tabMem
            // 
            tabMem.BackColor = Color.FromArgb(192, 255, 255);
            tabMem.Controls.Add(button10);
            tabMem.Controls.Add(txtSearch);
            tabMem.Controls.Add(btn_Search);
            tabMem.Controls.Add(btnSort);
            tabMem.Controls.Add(cbbSort);
            tabMem.Controls.Add(bt_soluongkhach);
            tabMem.Controls.Add(DGV_Mem);
            tabMem.Controls.Add(btn_Mem_Add);
            tabMem.Controls.Add(btn_Mem_Update);
            tabMem.Controls.Add(btn_Mem_Del);
            tabMem.Location = new Point(4, 24);
            tabMem.Name = "tabMem";
            tabMem.Padding = new Padding(3);
            tabMem.Size = new Size(945, 459);
            tabMem.TabIndex = 0;
            tabMem.Text = "Member";
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            button10.Location = new Point(755, 417);
            button10.Name = "button10";
            button10.Size = new Size(179, 38);
            button10.TabIndex = 13;
            button10.Text = "Attendance";
            button10.UseVisualStyleBackColor = true;
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
            btn_Search.Click += btn_Search_Click;
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
            btnSort.Click += btnSort_Click;
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
            bt_soluongkhach.Click += bt_soluongkhach_Click;
            // 
            // DGV_Mem
            // 
            DGV_Mem.BackgroundColor = Color.FromArgb(192, 255, 255);
            DGV_Mem.BorderStyle = BorderStyle.None;
            DGV_Mem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Mem.Location = new Point(16, 55);
            DGV_Mem.Name = "DGV_Mem";
            DGV_Mem.RowHeadersWidth = 62;
            DGV_Mem.Size = new Size(918, 353);
            DGV_Mem.TabIndex = 0;
            // 
            // btn_Mem_Add
            // 
            btn_Mem_Add.BackgroundImageLayout = ImageLayout.None;
            btn_Mem_Add.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btn_Mem_Add.Image = (Image)resources.GetObject("btn_Mem_Add.Image");
            btn_Mem_Add.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Mem_Add.Location = new Point(141, 417);
            btn_Mem_Add.Name = "btn_Mem_Add";
            btn_Mem_Add.Size = new Size(100, 38);
            btn_Mem_Add.TabIndex = 7;
            btn_Mem_Add.Text = "Add";
            btn_Mem_Add.TextAlign = ContentAlignment.MiddleRight;
            btn_Mem_Add.UseVisualStyleBackColor = true;
            btn_Mem_Add.Click += btn_Mem_Add_Click;
            // 
            // btn_Mem_Update
            // 
            btn_Mem_Update.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btn_Mem_Update.Image = (Image)resources.GetObject("btn_Mem_Update.Image");
            btn_Mem_Update.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Mem_Update.Location = new Point(329, 417);
            btn_Mem_Update.Name = "btn_Mem_Update";
            btn_Mem_Update.Size = new Size(100, 38);
            btn_Mem_Update.TabIndex = 7;
            btn_Mem_Update.Text = "Edit";
            btn_Mem_Update.TextAlign = ContentAlignment.MiddleRight;
            btn_Mem_Update.UseVisualStyleBackColor = true;
            btn_Mem_Update.Click += btn_Mem_Update_Click;
            // 
            // btn_Mem_Del
            // 
            btn_Mem_Del.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btn_Mem_Del.Image = (Image)resources.GetObject("btn_Mem_Del.Image");
            btn_Mem_Del.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Mem_Del.Location = new Point(542, 417);
            btn_Mem_Del.Name = "btn_Mem_Del";
            btn_Mem_Del.Size = new Size(120, 38);
            btn_Mem_Del.TabIndex = 7;
            btn_Mem_Del.Text = "Delete";
            btn_Mem_Del.TextAlign = ContentAlignment.MiddleRight;
            btn_Mem_Del.UseVisualStyleBackColor = true;
            btn_Mem_Del.Click += btn_Mem_Del_Click;
            // 
            // tabControlGym
            // 
            tabControlGym.Controls.Add(tabMem);
            tabControlGym.Controls.Add(tabPT);
            tabControlGym.Controls.Add(tabReceptiionist);
            tabControlGym.Controls.Add(tabMachine);
            tabControlGym.Controls.Add(tabInvoice);
            tabControlGym.Controls.Add(tabPack);
            tabControlGym.Controls.Add(tabLogOut);
            tabControlGym.Location = new Point(-4, 68);
            tabControlGym.Name = "tabControlGym";
            tabControlGym.SelectedIndex = 0;
            tabControlGym.Size = new Size(953, 487);
            tabControlGym.TabIndex = 10;
            tabControlGym.SelectedIndexChanged += TabControl1_SelectedIndexChanged;
            // 
            // tabInvoice
            // 
            tabInvoice.BackColor = Color.FromArgb(192, 255, 255);
            tabInvoice.Controls.Add(button1);
            tabInvoice.Controls.Add(button3);
            tabInvoice.Controls.Add(DGV_Invoice);
            tabInvoice.Location = new Point(4, 24);
            tabInvoice.Margin = new Padding(2);
            tabInvoice.Name = "tabInvoice";
            tabInvoice.Padding = new Padding(2);
            tabInvoice.Size = new Size(945, 459);
            tabInvoice.TabIndex = 5;
            tabInvoice.Text = "Invoice";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            button1.Image = Properties.Resources.add;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(249, 412);
            button1.Name = "button1";
            button1.Size = new Size(100, 38);
            button1.TabIndex = 8;
            button1.Text = "Add";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            button3.Image = Properties.Resources.delete;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(583, 412);
            button3.Name = "button3";
            button3.Size = new Size(120, 38);
            button3.TabIndex = 10;
            button3.Text = "Delete";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = true;
            // 
            // DGV_Invoice
            // 
            DGV_Invoice.BackgroundColor = Color.FromArgb(192, 255, 255);
            DGV_Invoice.BorderStyle = BorderStyle.None;
            DGV_Invoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Invoice.Location = new Point(20, 46);
            DGV_Invoice.Margin = new Padding(2);
            DGV_Invoice.Name = "DGV_Invoice";
            DGV_Invoice.RowHeadersWidth = 62;
            DGV_Invoice.Size = new Size(903, 349);
            DGV_Invoice.TabIndex = 0;
            // 
            // tabLogOut
            // 
            tabLogOut.BackColor = Color.FromArgb(192, 255, 255);
            tabLogOut.Location = new Point(4, 24);
            tabLogOut.Name = "tabLogOut";
            tabLogOut.Padding = new Padding(3);
            tabLogOut.Size = new Size(945, 459);
            tabLogOut.TabIndex = 7;
            tabLogOut.Text = "Log out";
            tabLogOut.Enter += tabLogOut_Enter;
            // 
            // GymDataFormRec
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(949, 554);
            Controls.Add(tabControlGym);
            Controls.Add(label1);
            Name = "GymDataFormRec";
            Text = "Gym Management for Receptionist";
            tabPack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGV_Pack).EndInit();
            tabMachine.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGV_Machine).EndInit();
            tabReceptiionist.ResumeLayout(false);
            tabReceptiionist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Recep).EndInit();
            tabPT.ResumeLayout(false);
            tabPT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_PT).EndInit();
            tabMem.ResumeLayout(false);
            tabMem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Mem).EndInit();
            tabControlGym.ResumeLayout(false);
            tabInvoice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGV_Invoice).EndInit();
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
        private TabPage tabReceptiionist;
        private DataGridView DGV_Recep;
        private Button addReceptionist;
        private Button btnDelete;
        private Button btn_updateRecep;
        private TabPage tabPT;
        private DataGridView DGV_PT;
        private Button addPT;
        private Button btn_PT_del;
        private Button btn_PT_Update;
        private TabPage tabMem;
        private Button bt_soluongkhach;
        private DataGridView DGV_Mem;
        private Button btn_Mem_Add;
        private Button btn_Mem_Update;
        private Button btn_Mem_Del;
        private TabControl tabControlGym;
        private TabPage tabInvoice;
        private DataGridView DGV_Invoice;
        private Button btn_Search;
        private Button btnSort;
        private ComboBox cbbSort;
        private TextBox txtSearch;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private TextBox txtSearch_PT;
        private Button btnSearch_PT;
        private Button btnSort_PT;
        private ComboBox cbbSort_PT;
        private TextBox txtSearch_Recep;
        private Button btnSearch_Recep;
        private Button btnSort_Recep;
        private ComboBox cbbSort_Recep;
        private Button button10;
        private TabPage tabLogOut;
    }
}
