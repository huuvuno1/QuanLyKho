namespace QuanLyKho
{
    partial class NhanVienForm
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
            this.quanlykhoDataSet1 = new QuanLyKho.quanlykhoDataSet();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.inpMail = new System.Windows.Forms.TextBox();
            this.inpPhone = new System.Windows.Forms.TextBox();
            this.inpAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inpName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inpMa = new System.Windows.Forms.TextBox();
            this.quanlykhoDataSet = new QuanLyKho.quanlykhoDataSet();
            this.quanlykhoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhaCungCapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.nhaCungCapTableAdapter1 = new QuanLyKho.quanlykhoDataSetTableAdapters.NhaCungCapTableAdapter();
            this.inpGioiTinh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienTableAdapter = new QuanLyKho.quanlykhoDataSetTableAdapters.NhanVienTableAdapter();
            this.nhanVienTableAdapter1 = new QuanLyKho.quanlykhoDataSetTableAdapters.NhanVienTableAdapter();
            this.MaNv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.quanlykhoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlykhoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlykhoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // quanlykhoDataSet1
            // 
            this.quanlykhoDataSet1.DataSetName = "quanlykhoDataSet";
            this.quanlykhoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(593, 565);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(142, 47);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(403, 565);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(142, 47);
            this.btnEdit.TabIndex = 26;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(210, 565);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(142, 47);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(636, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "SĐT";
            // 
            // inpMail
            // 
            this.inpMail.Enabled = false;
            this.inpMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpMail.Location = new System.Drawing.Point(713, 121);
            this.inpMail.Name = "inpMail";
            this.inpMail.Size = new System.Drawing.Size(312, 30);
            this.inpMail.TabIndex = 23;
            // 
            // inpPhone
            // 
            this.inpPhone.Enabled = false;
            this.inpPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpPhone.Location = new System.Drawing.Point(713, 73);
            this.inpPhone.Name = "inpPhone";
            this.inpPhone.Size = new System.Drawing.Size(312, 30);
            this.inpPhone.TabIndex = 22;
            // 
            // inpAddress
            // 
            this.inpAddress.Enabled = false;
            this.inpAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpAddress.Location = new System.Drawing.Point(713, 25);
            this.inpAddress.Name = "inpAddress";
            this.inpAddress.Size = new System.Drawing.Size(312, 30);
            this.inpAddress.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(636, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(636, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Email";
            // 
            // inpName
            // 
            this.inpName.Enabled = false;
            this.inpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpName.Location = new System.Drawing.Point(200, 73);
            this.inpName.Name = "inpName";
            this.inpName.Size = new System.Drawing.Size(312, 30);
            this.inpName.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Họ tên";
            // 
            // inpMa
            // 
            this.inpMa.Enabled = false;
            this.inpMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpMa.Location = new System.Drawing.Point(200, 23);
            this.inpMa.Name = "inpMa";
            this.inpMa.Size = new System.Drawing.Size(98, 30);
            this.inpMa.TabIndex = 16;
            // 
            // quanlykhoDataSet
            // 
            this.quanlykhoDataSet.DataSetName = "quanlykhoDataSet";
            this.quanlykhoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quanlykhoDataSetBindingSource
            // 
            this.quanlykhoDataSetBindingSource.DataSource = this.quanlykhoDataSet;
            this.quanlykhoDataSetBindingSource.Position = 0;
            // 
            // nhaCungCapBindingSource
            // 
            this.nhaCungCapBindingSource.DataMember = "NhaCungCap";
            this.nhaCungCapBindingSource.DataSource = this.quanlykhoDataSetBindingSource;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mã nhân viên";
            // 
            // nhaCungCapTableAdapter1
            // 
            this.nhaCungCapTableAdapter1.ClearBeforeFill = true;
            // 
            // inpGioiTinh
            // 
            this.inpGioiTinh.Enabled = false;
            this.inpGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpGioiTinh.Location = new System.Drawing.Point(200, 121);
            this.inpGioiTinh.Name = "inpGioiTinh";
            this.inpGioiTinh.Size = new System.Drawing.Size(312, 30);
            this.inpGioiTinh.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 25);
            this.label6.TabIndex = 28;
            this.label6.Text = "Giới tính";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNv,
            this.Ten,
            this.SDT,
            this.Email,
            this.DiaChi,
            this.GioiTinh,
            this.Username});
            this.dataGridView1.DataSource = this.nhanVienBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(17, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1008, 342);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.bindDataToForm);
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.quanlykhoDataSetBindingSource;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // nhanVienTableAdapter1
            // 
            this.nhanVienTableAdapter1.ClearBeforeFill = true;
            // 
            // MaNv
            // 
            this.MaNv.DataPropertyName = "MaNv";
            this.MaNv.HeaderText = "MaNv";
            this.MaNv.MinimumWidth = 6;
            this.MaNv.Name = "MaNv";
            this.MaNv.ReadOnly = true;
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Ten";
            this.Ten.MinimumWidth = 6;
            this.Ten.Name = "Ten";
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SDT";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "DiaChi";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "GioiTinh";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Username";
            this.Username.MinimumWidth = 6;
            this.Username.Name = "Username";
            // 
            // NhanVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 624);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.inpGioiTinh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inpMail);
            this.Controls.Add(this.inpPhone);
            this.Controls.Add(this.inpAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inpName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inpMa);
            this.Controls.Add(this.label1);
            this.Name = "NhanVienForm";
            this.Text = "NhanVienForm";
            this.Load += new System.EventHandler(this.NhanVienForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanlykhoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlykhoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlykhoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private quanlykhoDataSet quanlykhoDataSet1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inpMail;
        private System.Windows.Forms.TextBox inpPhone;
        private System.Windows.Forms.TextBox inpAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inpName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inpMa;
        private quanlykhoDataSet quanlykhoDataSet;
        private System.Windows.Forms.BindingSource quanlykhoDataSetBindingSource;
        private System.Windows.Forms.BindingSource nhaCungCapBindingSource;
        private System.Windows.Forms.Label label1;
        private quanlykhoDataSetTableAdapters.NhaCungCapTableAdapter nhaCungCapTableAdapter1;
        private System.Windows.Forms.TextBox inpGioiTinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private quanlykhoDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private quanlykhoDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
    }
}