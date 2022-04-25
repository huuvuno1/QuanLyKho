namespace QuanLyKho
{
    partial class XuatKhoForm
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
            this.errorProviderGiaNhap = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSearchNcc = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.btnAddProductToBill = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.listSanPham = new System.Windows.Forms.DataGridView();
            this.comboBoxCH = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sanPhamTableAdapter1 = new QuanLyKho.quanlykhoDataSetTableAdapters.SanPhamTableAdapter();
            this.comboxProduct = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProviderSoLuong = new System.Windows.Forms.ErrorProvider(this.components);
            this.inpSoLuong = new System.Windows.Forms.TextBox();
            this.comboBoxGiaXuat = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderGiaNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProviderGiaNhap
            // 
            this.errorProviderGiaNhap.ContainerControl = this;
            // 
            // btnSearchNcc
            // 
            this.btnSearchNcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchNcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchNcc.Location = new System.Drawing.Point(618, 177);
            this.btnSearchNcc.Name = "btnSearchNcc";
            this.btnSearchNcc.Size = new System.Drawing.Size(157, 42);
            this.btnSearchNcc.TabIndex = 31;
            this.btnSearchNcc.Text = "Tìm kiếm";
            this.btnSearchNcc.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 29);
            this.label5.TabIndex = 30;
            this.label5.Text = "Giá xuất";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Highlight;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(792, 298);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(227, 42);
            this.button5.TabIndex = 28;
            this.button5.Text = "Hoàn thành";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 29);
            this.label4.TabIndex = 27;
            this.label4.Text = "Danh sách sản phẩm ";
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(792, 175);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(227, 42);
            this.button4.TabIndex = 26;
            this.button4.Text = "Quản lý cửa hàng";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnAddProductToBill
            // 
            this.btnAddProductToBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProductToBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProductToBill.Location = new System.Drawing.Point(201, 234);
            this.btnAddProductToBill.Name = "btnAddProductToBill";
            this.btnAddProductToBill.Size = new System.Drawing.Size(219, 42);
            this.btnAddProductToBill.TabIndex = 24;
            this.btnAddProductToBill.Text = "Thêm vào hóa đơn";
            this.btnAddProductToBill.UseVisualStyleBackColor = true;
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
            // listSanPham
            // 
            this.listSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listSanPham.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.listSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Remove});
            this.listSanPham.Location = new System.Drawing.Point(28, 354);
            this.listSanPham.Name = "listSanPham";
            this.listSanPham.RowHeadersWidth = 51;
            this.listSanPham.RowTemplate.Height = 24;
            this.listSanPham.Size = new System.Drawing.Size(991, 252);
            this.listSanPham.TabIndex = 23;
            // 
            // comboBoxCH
            // 
            this.comboBoxCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCH.FormattingEnabled = true;
            this.comboBoxCH.Items.AddRange(new object[] {
            "vu",
            "nam",
            "lon",
            "le"});
            this.comboBoxCH.Location = new System.Drawing.Point(201, 180);
            this.comboBoxCH.MaxDropDownItems = 10;
            this.comboBoxCH.Name = "comboBoxCH";
            this.comboBoxCH.Size = new System.Drawing.Size(395, 37);
            this.comboBoxCH.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "Cửa hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 29);
            this.label2.TabIndex = 20;
            this.label2.Text = "Số lượng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "Sản phẩm";
            // 
            // sanPhamTableAdapter1
            // 
            this.sanPhamTableAdapter1.ClearBeforeFill = true;
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
            this.comboxProduct.Location = new System.Drawing.Point(201, 21);
            this.comboxProduct.MaxDropDownItems = 10;
            this.comboxProduct.Name = "comboxProduct";
            this.comboxProduct.Size = new System.Drawing.Size(395, 37);
            this.comboxProduct.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(618, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 42);
            this.button1.TabIndex = 17;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // errorProviderSoLuong
            // 
            this.errorProviderSoLuong.ContainerControl = this;
            // 
            // inpSoLuong
            // 
            this.inpSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpSoLuong.Location = new System.Drawing.Point(201, 130);
            this.inpSoLuong.Name = "inpSoLuong";
            this.inpSoLuong.Size = new System.Drawing.Size(301, 34);
            this.inpSoLuong.TabIndex = 16;
            // 
            // comboBoxGiaXuat
            // 
            this.comboBoxGiaXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGiaXuat.FormattingEnabled = true;
            this.comboBoxGiaXuat.Items.AddRange(new object[] {
            "vu",
            "nam",
            "lon",
            "le"});
            this.comboBoxGiaXuat.Location = new System.Drawing.Point(201, 77);
            this.comboBoxGiaXuat.MaxDropDownItems = 10;
            this.comboBoxGiaXuat.Name = "comboBoxGiaXuat";
            this.comboBoxGiaXuat.Size = new System.Drawing.Size(395, 37);
            this.comboBoxGiaXuat.TabIndex = 32;
            // 
            // XuatKhoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 624);
            this.Controls.Add(this.comboBoxGiaXuat);
            this.Controls.Add(this.btnSearchNcc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnAddProductToBill);
            this.Controls.Add(this.listSanPham);
            this.Controls.Add(this.comboBoxCH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboxProduct);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inpSoLuong);
            this.Name = "XuatKhoForm";
            this.Text = "Xuất kho";
            this.Load += new System.EventHandler(this.XuatKhoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderGiaNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProviderGiaNhap;
        private System.Windows.Forms.ComboBox comboBoxGiaXuat;
        private System.Windows.Forms.Button btnSearchNcc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnAddProductToBill;
        private System.Windows.Forms.DataGridView listSanPham;
        private System.Windows.Forms.DataGridViewButtonColumn Remove;
        private System.Windows.Forms.ComboBox comboBoxCH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboxProduct;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox inpSoLuong;
        private quanlykhoDataSetTableAdapters.SanPhamTableAdapter sanPhamTableAdapter1;
        private System.Windows.Forms.ErrorProvider errorProviderSoLuong;
    }
}