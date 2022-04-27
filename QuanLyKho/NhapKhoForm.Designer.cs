namespace QuanLyKho
{
    partial class NhapKhoForm
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
            this.inpSoLuong = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboxProduct = new System.Windows.Forms.ComboBox();
            this.sanPhamTableAdapter1 = new QuanLyKho.quanlykhoDataSetTableAdapters.SanPhamTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxNcc = new System.Windows.Forms.ComboBox();
            this.listSanPham = new System.Windows.Forms.DataGridView();
            this.Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAddProductToBill = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.inpGiaNhap = new System.Windows.Forms.TextBox();
            this.btnSearchNcc = new System.Windows.Forms.Button();
            this.errorProviderSoLuong = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderGiaNhap = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelTenNv = new System.Windows.Forms.Label();
            this.inpTenNv = new System.Windows.Forms.TextBox();
            this.labelMaNv = new System.Windows.Forms.Label();
            this.inpMaNv = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.listSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderGiaNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // inpSoLuong
            // 
            this.inpSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpSoLuong.Location = new System.Drawing.Point(198, 82);
            this.inpSoLuong.Name = "inpSoLuong";
            this.inpSoLuong.Size = new System.Drawing.Size(301, 34);
            this.inpSoLuong.TabIndex = 0;
            this.inpSoLuong.TextChanged += new System.EventHandler(this.inpSearch_TextChanged);
            this.inpSoLuong.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateSoLuong);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(615, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboxProduct
            // 
            this.comboxProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboxProduct.FormattingEnabled = true;
            this.comboxProduct.Items.AddRange(new object[] {
            "vu",
            "nam",
            "lon",
            "le"});
            this.comboxProduct.Location = new System.Drawing.Point(198, 27);
            this.comboxProduct.MaxDropDownItems = 10;
            this.comboxProduct.Name = "comboxProduct";
            this.comboxProduct.Size = new System.Drawing.Size(395, 37);
            this.comboxProduct.TabIndex = 2;
            this.comboxProduct.DropDown += new System.EventHandler(this.ShowData);
            this.comboxProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchProducts);
            // 
            // sanPhamTableAdapter1
            // 
            this.sanPhamTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhà cung cấp";
            // 
            // comboBoxNcc
            // 
            this.comboBoxNcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNcc.FormattingEnabled = true;
            this.comboBoxNcc.Items.AddRange(new object[] {
            "vu",
            "nam",
            "lon",
            "le"});
            this.comboBoxNcc.Location = new System.Drawing.Point(198, 186);
            this.comboBoxNcc.MaxDropDownItems = 10;
            this.comboBoxNcc.Name = "comboBoxNcc";
            this.comboBoxNcc.Size = new System.Drawing.Size(395, 37);
            this.comboBoxNcc.TabIndex = 6;
            // 
            // listSanPham
            // 
            this.listSanPham.AllowUserToAddRows = false;
            this.listSanPham.AllowUserToDeleteRows = false;
            this.listSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listSanPham.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.listSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Remove});
            this.listSanPham.Location = new System.Drawing.Point(25, 360);
            this.listSanPham.Name = "listSanPham";
            this.listSanPham.ReadOnly = true;
            this.listSanPham.RowHeadersWidth = 51;
            this.listSanPham.RowTemplate.Height = 24;
            this.listSanPham.Size = new System.Drawing.Size(991, 252);
            this.listSanPham.TabIndex = 7;
            this.listSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listSanPham_CellContentClick);
            // 
            // Remove
            // 
            this.Remove.HeaderText = "Remove";
            this.Remove.MinimumWidth = 6;
            this.Remove.Name = "Remove";
            this.Remove.ReadOnly = true;
            this.Remove.Text = "<=";
            this.Remove.UseColumnTextForButtonValue = true;
            // 
            // btnAddProductToBill
            // 
            this.btnAddProductToBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProductToBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProductToBill.Location = new System.Drawing.Point(198, 240);
            this.btnAddProductToBill.Name = "btnAddProductToBill";
            this.btnAddProductToBill.Size = new System.Drawing.Size(219, 42);
            this.btnAddProductToBill.TabIndex = 8;
            this.btnAddProductToBill.Text = "Thêm vào hóa đơn";
            this.btnAddProductToBill.UseVisualStyleBackColor = true;
            this.btnAddProductToBill.Click += new System.EventHandler(this.btnAddProductToBill_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(789, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(227, 42);
            this.button3.TabIndex = 9;
            this.button3.Text = "Thêm sản phẩm mới";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(789, 181);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(227, 42);
            this.button4.TabIndex = 10;
            this.button4.Text = "Quản lý nhà cung cấp";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Danh sách sản phẩm ";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Highlight;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(789, 304);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(227, 42);
            this.button5.TabIndex = 12;
            this.button5.Text = "Hoàn thành";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "Giá nhập";
            // 
            // inpGiaNhap
            // 
            this.inpGiaNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpGiaNhap.Location = new System.Drawing.Point(198, 133);
            this.inpGiaNhap.Name = "inpGiaNhap";
            this.inpGiaNhap.Size = new System.Drawing.Size(301, 34);
            this.inpGiaNhap.TabIndex = 13;
            this.inpGiaNhap.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateGiaNhap);
            // 
            // btnSearchNcc
            // 
            this.btnSearchNcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchNcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchNcc.Location = new System.Drawing.Point(615, 183);
            this.btnSearchNcc.Name = "btnSearchNcc";
            this.btnSearchNcc.Size = new System.Drawing.Size(157, 42);
            this.btnSearchNcc.TabIndex = 15;
            this.btnSearchNcc.Text = "Tìm kiếm";
            this.btnSearchNcc.UseVisualStyleBackColor = true;
            this.btnSearchNcc.Click += new System.EventHandler(this.btnSearchNcc_Click);
            // 
            // errorProviderSoLuong
            // 
            this.errorProviderSoLuong.ContainerControl = this;
            // 
            // errorProviderGiaNhap
            // 
            this.errorProviderGiaNhap.ContainerControl = this;
            // 
            // labelTenNv
            // 
            this.labelTenNv.AutoSize = true;
            this.labelTenNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenNv.Location = new System.Drawing.Point(623, 136);
            this.labelTenNv.Name = "labelTenNv";
            this.labelTenNv.Size = new System.Drawing.Size(86, 29);
            this.labelTenNv.TabIndex = 19;
            this.labelTenNv.Text = "Tên nv";
            this.labelTenNv.Visible = false;
            // 
            // inpTenNv
            // 
            this.inpTenNv.Enabled = false;
            this.inpTenNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpTenNv.Location = new System.Drawing.Point(715, 133);
            this.inpTenNv.Name = "inpTenNv";
            this.inpTenNv.Size = new System.Drawing.Size(301, 34);
            this.inpTenNv.TabIndex = 18;
            this.inpTenNv.WordWrap = false;
            this.inpTenNv.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelMaNv
            // 
            this.labelMaNv.AutoSize = true;
            this.labelMaNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaNv.Location = new System.Drawing.Point(623, 85);
            this.labelMaNv.Name = "labelMaNv";
            this.labelMaNv.Size = new System.Drawing.Size(115, 29);
            this.labelMaNv.TabIndex = 17;
            this.labelMaNv.Text = "Mã nv lập";
            this.labelMaNv.Visible = false;
            // 
            // inpMaNv
            // 
            this.inpMaNv.Enabled = false;
            this.inpMaNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpMaNv.Location = new System.Drawing.Point(753, 82);
            this.inpMaNv.Name = "inpMaNv";
            this.inpMaNv.Size = new System.Drawing.Size(263, 34);
            this.inpMaNv.TabIndex = 16;
            this.inpMaNv.WordWrap = false;
            // 
            // NhapKhoForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 624);
            this.Controls.Add(this.labelTenNv);
            this.Controls.Add(this.inpTenNv);
            this.Controls.Add(this.labelMaNv);
            this.Controls.Add(this.inpMaNv);
            this.Controls.Add(this.btnSearchNcc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inpGiaNhap);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnAddProductToBill);
            this.Controls.Add(this.listSanPham);
            this.Controls.Add(this.comboBoxNcc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboxProduct);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inpSoLuong);
            this.Name = "NhapKhoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nhập sản phẩm vào kho";
            this.Load += new System.EventHandler(this.NhapKhoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderGiaNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inpSoLuong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboxProduct;
        private quanlykhoDataSetTableAdapters.SanPhamTableAdapter sanPhamTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxNcc;
        private System.Windows.Forms.DataGridView listSanPham;
        private System.Windows.Forms.Button btnAddProductToBill;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inpGiaNhap;
        private System.Windows.Forms.Button btnSearchNcc;
        private System.Windows.Forms.DataGridViewButtonColumn Remove;
        private System.Windows.Forms.ErrorProvider errorProviderSoLuong;
        private System.Windows.Forms.ErrorProvider errorProviderGiaNhap;
        private System.Windows.Forms.Label labelTenNv;
        private System.Windows.Forms.TextBox inpTenNv;
        private System.Windows.Forms.Label labelMaNv;
        private System.Windows.Forms.TextBox inpMaNv;
    }
}