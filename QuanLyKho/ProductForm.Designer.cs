namespace QuanLyKho
{
    partial class ProductForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaSp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlykhoDataSet = new QuanLyKho.quanlykhoDataSet();
            this.sanPhamTableAdapter = new QuanLyKho.quanlykhoDataSetTableAdapters.SanPhamTableAdapter();
            this.inpSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.inpTenSp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inpGiaSp = new System.Windows.Forms.TextBox();
            this.inpDonVi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inpSL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.inpMoTa = new System.Windows.Forms.RichTextBox();
            this.inpMaSp = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlykhoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSp,
            this.Ten,
            this.MoTa,
            this.SoLuong,
            this.DonViTinh,
            this.GiaTien});
            this.dataGridView1.DataSource = this.sanPhamBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(33, 267);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(980, 345);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.loadRowToForm);
            // 
            // MaSp
            // 
            this.MaSp.DataPropertyName = "MaSp";
            this.MaSp.HeaderText = "MaSp";
            this.MaSp.MinimumWidth = 6;
            this.MaSp.Name = "MaSp";
            this.MaSp.ReadOnly = true;
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Ten";
            this.Ten.MinimumWidth = 6;
            this.Ten.Name = "Ten";
            // 
            // MoTa
            // 
            this.MoTa.DataPropertyName = "MoTa";
            this.MoTa.HeaderText = "MoTa";
            this.MoTa.MinimumWidth = 6;
            this.MoTa.Name = "MoTa";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "SoLuong";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            // 
            // DonViTinh
            // 
            this.DonViTinh.DataPropertyName = "DonViTinh";
            this.DonViTinh.HeaderText = "DonViTinh";
            this.DonViTinh.MinimumWidth = 6;
            this.DonViTinh.Name = "DonViTinh";
            // 
            // GiaTien
            // 
            this.GiaTien.DataPropertyName = "GiaTien";
            this.GiaTien.HeaderText = "GiaTien";
            this.GiaTien.MinimumWidth = 6;
            this.GiaTien.Name = "GiaTien";
            // 
            // sanPhamBindingSource
            // 
            this.sanPhamBindingSource.DataMember = "SanPham";
            this.sanPhamBindingSource.DataSource = this.quanlykhoDataSet;
            // 
            // quanlykhoDataSet
            // 
            this.quanlykhoDataSet.DataSetName = "quanlykhoDataSet";
            this.quanlykhoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sanPhamTableAdapter
            // 
            this.sanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // inpSearch
            // 
            this.inpSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpSearch.Location = new System.Drawing.Point(544, 198);
            this.inpSearch.Name = "inpSearch";
            this.inpSearch.Size = new System.Drawing.Size(332, 30);
            this.inpSearch.TabIndex = 6;
            this.inpSearch.TextChanged += new System.EventHandler(this.inpName_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(669, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SpringGreen;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Yellow;
            this.btnAdd.Location = new System.Drawing.Point(881, 191);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(132, 44);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Tìm kiếm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(44, 182);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(345, 43);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Lưu thay đổi";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tên";
            // 
            // inpTenSp
            // 
            this.inpTenSp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpTenSp.Location = new System.Drawing.Point(144, 33);
            this.inpTenSp.Name = "inpTenSp";
            this.inpTenSp.Size = new System.Drawing.Size(245, 30);
            this.inpTenSp.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Giá tiền";
            // 
            // inpGiaSp
            // 
            this.inpGiaSp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpGiaSp.Location = new System.Drawing.Point(144, 85);
            this.inpGiaSp.Name = "inpGiaSp";
            this.inpGiaSp.Size = new System.Drawing.Size(208, 30);
            this.inpGiaSp.TabIndex = 17;
            // 
            // inpDonVi
            // 
            this.inpDonVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpDonVi.Location = new System.Drawing.Point(658, 31);
            this.inpDonVi.Name = "inpDonVi";
            this.inpDonVi.Size = new System.Drawing.Size(167, 30);
            this.inpDonVi.TabIndex = 21;
            this.inpDonVi.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(549, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Đơn vị tính";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // inpSL
            // 
            this.inpSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpSL.Location = new System.Drawing.Point(144, 134);
            this.inpSL.Name = "inpSL";
            this.inpSL.Size = new System.Drawing.Size(167, 30);
            this.inpSL.TabIndex = 19;
            this.inpSL.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Số lượng";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(578, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Mô tả";
            // 
            // inpMoTa
            // 
            this.inpMoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpMoTa.Location = new System.Drawing.Point(658, 90);
            this.inpMoTa.Name = "inpMoTa";
            this.inpMoTa.Size = new System.Drawing.Size(352, 81);
            this.inpMoTa.TabIndex = 24;
            this.inpMoTa.Text = "";
            // 
            // inpMaSp
            // 
            this.inpMaSp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpMaSp.Location = new System.Drawing.Point(357, 132);
            this.inpMaSp.Name = "inpMaSp";
            this.inpMaSp.Size = new System.Drawing.Size(167, 30);
            this.inpMaSp.TabIndex = 25;
            this.inpMaSp.Visible = false;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 624);
            this.Controls.Add(this.inpMaSp);
            this.Controls.Add(this.inpMoTa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.inpDonVi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inpSL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inpGiaSp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inpTenSp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.inpSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ProductForm";
            this.Text = "Quản lý sản phẩm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlykhoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private quanlykhoDataSet quanlykhoDataSet;
        private System.Windows.Forms.BindingSource sanPhamBindingSource;
        private quanlykhoDataSetTableAdapters.SanPhamTableAdapter sanPhamTableAdapter;
        private System.Windows.Forms.TextBox inpSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inpTenSp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inpGiaSp;
        private System.Windows.Forms.TextBox inpDonVi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inpSL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox inpMoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTien;
        private System.Windows.Forms.TextBox inpMaSp;
    }
}