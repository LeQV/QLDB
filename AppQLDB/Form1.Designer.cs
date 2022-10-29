namespace AppQLDB
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenGoi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridNhom = new System.Windows.Forms.DataGridView();
            this.gridLienLac = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThemNhom = new System.Windows.Forms.ToolStripButton();
            this.btnXoaNhom = new System.Windows.Forms.ToolStripButton();
            this.btnThemLienLac = new System.Windows.Forms.ToolStripButton();
            this.btnXoaLienLac = new System.Windows.Forms.ToolStripButton();
            this.txtTimKiem = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tenNhomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idLienLacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenGoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNhom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLienLac)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSdt);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.txtTenGoi);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.gridNhom);
            this.panel1.Controls.Add(this.gridLienLac);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 655);
            this.panel1.TabIndex = 0;
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(415, 592);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(251, 22);
            this.txtSdt.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(415, 553);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(251, 22);
            this.txtEmail.TabIndex = 9;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(415, 509);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(251, 22);
            this.txtDiaChi.TabIndex = 8;
            // 
            // txtTenGoi
            // 
            this.txtTenGoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenGoi.Location = new System.Drawing.Point(415, 451);
            this.txtTenGoi.Name = "txtTenGoi";
            this.txtTenGoi.Size = new System.Drawing.Size(251, 30);
            this.txtTenGoi.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 592);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số điện thoại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 559);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 515);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Địa chỉ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 456);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên gọi";
            // 
            // gridNhom
            // 
            this.gridNhom.AutoGenerateColumns = false;
            this.gridNhom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridNhom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenNhomDataGridViewTextBoxColumn});
            this.gridNhom.DataSource = this.bindingSource1;
            this.gridNhom.Location = new System.Drawing.Point(3, 30);
            this.gridNhom.Name = "gridNhom";
            this.gridNhom.RowHeadersWidth = 51;
            this.gridNhom.RowTemplate.Height = 24;
            this.gridNhom.Size = new System.Drawing.Size(228, 625);
            this.gridNhom.TabIndex = 2;
            this.gridNhom.SelectionChanged += new System.EventHandler(this.gridNhom_SelectionChanged);
            // 
            // gridLienLac
            // 
            this.gridLienLac.AutoGenerateColumns = false;
            this.gridLienLac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLienLac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLienLacDataGridViewTextBoxColumn,
            this.tenGoiDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn});
            this.gridLienLac.DataSource = this.bindingSource2;
            this.gridLienLac.Location = new System.Drawing.Point(237, 30);
            this.gridLienLac.Name = "gridLienLac";
            this.gridLienLac.RowHeadersWidth = 51;
            this.gridLienLac.RowTemplate.Height = 24;
            this.gridLienLac.Size = new System.Drawing.Size(920, 404);
            this.gridLienLac.TabIndex = 1;
            this.gridLienLac.SelectionChanged += new System.EventHandler(this.gridLienLac_SelectionChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemNhom,
            this.btnXoaNhom,
            this.btnThemLienLac,
            this.btnXoaLienLac,
            this.txtTimKiem,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1160, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btnThemNhom
            // 
            this.btnThemNhom.Image = global::AppQLDB.Properties.Resources._1814113_add_more_plus_icon;
            this.btnThemNhom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThemNhom.Name = "btnThemNhom";
            this.btnThemNhom.Size = new System.Drawing.Size(112, 28);
            this.btnThemNhom.Text = "Thêm nhóm";
            this.btnThemNhom.Click += new System.EventHandler(this.btnThemNhom_Click);
            // 
            // btnXoaNhom
            // 
            this.btnXoaNhom.Image = global::AppQLDB.Properties.Resources._9004715_cross_delete_remove_cancel_icon;
            this.btnXoaNhom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoaNhom.Name = "btnXoaNhom";
            this.btnXoaNhom.Size = new System.Drawing.Size(101, 28);
            this.btnXoaNhom.Text = "Xóa nhóm";
            this.btnXoaNhom.Click += new System.EventHandler(this.btnXoaNhom_Click);
            // 
            // btnThemLienLac
            // 
            this.btnThemLienLac.Image = global::AppQLDB.Properties.Resources._1814113_add_more_plus_icon;
            this.btnThemLienLac.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThemLienLac.Name = "btnThemLienLac";
            this.btnThemLienLac.Size = new System.Drawing.Size(121, 28);
            this.btnThemLienLac.Text = "Thêm liên lạc";
            this.btnThemLienLac.Click += new System.EventHandler(this.btnThemLienLac_Click);
            // 
            // btnXoaLienLac
            // 
            this.btnXoaLienLac.Image = global::AppQLDB.Properties.Resources._9004715_cross_delete_remove_cancel_icon;
            this.btnXoaLienLac.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoaLienLac.Name = "btnXoaLienLac";
            this.btnXoaLienLac.Size = new System.Drawing.Size(110, 28);
            this.btnXoaLienLac.Text = "Xóa liên lạc";
            this.btnXoaLienLac.Click += new System.EventHandler(this.btnXoaLienLac_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(1, 0, 5, 0);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(100, 31);
            this.txtTimKiem.Enter += new System.EventHandler(this.toolStripTextBox1_Click);
            this.txtTimKiem.TextChanged += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Margin = new System.Windows.Forms.Padding(280, 1, 0, 2);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(152, 28);
            this.toolStripLabel1.Text = "Nhập từ cần tìm kiếm";
            // 
            // tenNhomDataGridViewTextBoxColumn
            // 
            this.tenNhomDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenNhomDataGridViewTextBoxColumn.DataPropertyName = "TenNhom";
            this.tenNhomDataGridViewTextBoxColumn.HeaderText = "TenNhom";
            this.tenNhomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenNhomDataGridViewTextBoxColumn.Name = "tenNhomDataGridViewTextBoxColumn";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(AppQLDB.ViewModel.NhomViewModel);
            // 
            // idLienLacDataGridViewTextBoxColumn
            // 
            this.idLienLacDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idLienLacDataGridViewTextBoxColumn.DataPropertyName = "IdLienLac";
            this.idLienLacDataGridViewTextBoxColumn.HeaderText = "IdLienLac";
            this.idLienLacDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idLienLacDataGridViewTextBoxColumn.Name = "idLienLacDataGridViewTextBoxColumn";
            // 
            // tenGoiDataGridViewTextBoxColumn
            // 
            this.tenGoiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenGoiDataGridViewTextBoxColumn.DataPropertyName = "TenGoi";
            this.tenGoiDataGridViewTextBoxColumn.HeaderText = "TenGoi";
            this.tenGoiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenGoiDataGridViewTextBoxColumn.Name = "tenGoiDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "SDT";
            this.sDTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataSource = typeof(AppQLDB.ViewModel.LienLacViewModel);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 655);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNhom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLienLac)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThemNhom;
        private System.Windows.Forms.ToolStripButton btnXoaNhom;
        private System.Windows.Forms.ToolStripButton btnThemLienLac;
        private System.Windows.Forms.ToolStripButton btnXoaLienLac;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenGoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridNhom;
        private System.Windows.Forms.DataGridView gridLienLac;
        private System.Windows.Forms.ToolStripTextBox txtTimKiem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLienLacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenGoiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
    }
}

