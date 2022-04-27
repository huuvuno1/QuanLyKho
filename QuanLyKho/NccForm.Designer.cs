namespace QuanLyKho
{
    partial class NccForm
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
            this.dataGridView_Ncc = new System.Windows.Forms.DataGridView();
            this.MaNcc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quanlykhoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlykhoDataSet = new QuanLyKho.quanlykhoDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.inpMa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inpName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inpAddress = new System.Windows.Forms.TextBox();
            this.inpEmail = new System.Windows.Forms.TextBox();
            this.inpPhoneNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.quanlykhoDataSet1 = new QuanLyKho.quanlykhoDataSet();
            this.nhanVienTableAdapter1 = new QuanLyKho.quanlykhoDataSetTableAdapters.NhanVienTableAdapter();
            this.nhaCungCapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhaCungCapTableAdapter1 = new QuanLyKho.quanlykhoDataSetTableAdapters.NhaCungCapTableAdapter();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ncc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlykhoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlykhoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlykhoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Ncc
            // 
            this.dataGridView_Ncc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Ncc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Ncc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Ncc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNcc,
            this.Ten,
            this.DiaChi,
            this.Email,
            this.SDT});
            this.dataGridView_Ncc.Location = new System.Drawing.Point(42, 198);
            this.dataGridView_Ncc.Name = "dataGridView_Ncc";
            this.dataGridView_Ncc.RowHeadersWidth = 51;
            this.dataGridView_Ncc.RowTemplate.Height = 24;
            this.dataGridView_Ncc.Size = new System.Drawing.Size(945, 324);
            this.dataGridView_Ncc.TabIndex = 0;
            this.dataGridView_Ncc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selectRow);
            this.dataGridView_Ncc.SelectionChanged += new System.EventHandler(this.selectRow);
            // 
            // MaNcc
            // 
            this.MaNcc.DataPropertyName = "MaNcc";
            this.MaNcc.HeaderText = "MaNcc";
            this.MaNcc.MinimumWidth = 6;
            this.MaNcc.Name = "MaNcc";
            this.MaNcc.ReadOnly = true;
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Ten";
            this.Ten.MinimumWidth = 6;
            this.Ten.Name = "Ten";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "DiaChi";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SDT";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            // 
            // quanlykhoDataSetBindingSource
            // 
            this.quanlykhoDataSetBindingSource.DataSource = this.quanlykhoDataSet;
            this.quanlykhoDataSetBindingSource.Position = 0;
            // 
            // quanlykhoDataSet
            // 
            this.quanlykhoDataSet.DataSetName = "quanlykhoDataSet";
            this.quanlykhoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã nhà cung cấp";
            // 
            // inpMa
            // 
            this.inpMa.Enabled = false;
            this.inpMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpMa.Location = new System.Drawing.Point(230, 36);
            this.inpMa.Name = "inpMa";
            this.inpMa.Size = new System.Drawing.Size(98, 30);
            this.inpMa.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên nhà cung cấp";
            // 
            // inpName
            // 
            this.inpName.Enabled = false;
            this.inpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpName.Location = new System.Drawing.Point(230, 86);
            this.inpName.Name = "inpName";
            this.inpName.Size = new System.Drawing.Size(312, 30);
            this.inpName.TabIndex = 4;
            this.inpName.TextChanged += new System.EventHandler(this.inpName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(578, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(578, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Địa chỉ";
            // 
            // inpAddress
            // 
            this.inpAddress.Enabled = false;
            this.inpAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpAddress.Location = new System.Drawing.Point(655, 38);
            this.inpAddress.Name = "inpAddress";
            this.inpAddress.Size = new System.Drawing.Size(312, 30);
            this.inpAddress.TabIndex = 7;
            // 
            // inpEmail
            // 
            this.inpEmail.Enabled = false;
            this.inpEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpEmail.Location = new System.Drawing.Point(655, 86);
            this.inpEmail.Name = "inpEmail";
            this.inpEmail.Size = new System.Drawing.Size(312, 30);
            this.inpEmail.TabIndex = 8;
            // 
            // inpPhoneNumber
            // 
            this.inpPhoneNumber.Enabled = false;
            this.inpPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpPhoneNumber.Location = new System.Drawing.Point(655, 134);
            this.inpPhoneNumber.Name = "inpPhoneNumber";
            this.inpPhoneNumber.Size = new System.Drawing.Size(312, 30);
            this.inpPhoneNumber.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(578, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "SĐT";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(167, 577);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(142, 47);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(355, 577);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(142, 47);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(545, 577);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(142, 47);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // quanlykhoDataSet1
            // 
            this.quanlykhoDataSet1.DataSetName = "quanlykhoDataSet";
            this.quanlykhoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanVienTableAdapter1
            // 
            this.nhanVienTableAdapter1.ClearBeforeFill = true;
            // 
            // nhaCungCapBindingSource
            // 
            this.nhaCungCapBindingSource.DataMember = "NhaCungCap";
            this.nhaCungCapBindingSource.DataSource = this.quanlykhoDataSetBindingSource;
            // 
            // nhaCungCapTableAdapter1
            // 
            this.nhaCungCapTableAdapter1.ClearBeforeFill = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(735, 577);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(142, 47);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // NccForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 653);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inpPhoneNumber);
            this.Controls.Add(this.inpEmail);
            this.Controls.Add(this.inpAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inpName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inpMa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_Ncc);
            this.Name = "NccForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closeingForm);
            this.Load += new System.EventHandler(this.NccForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ncc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlykhoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlykhoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlykhoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_Ncc;
        private System.Windows.Forms.BindingSource quanlykhoDataSetBindingSource;
        private quanlykhoDataSet quanlykhoDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inpMa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inpName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inpAddress;
        private System.Windows.Forms.TextBox inpEmail;
        private System.Windows.Forms.TextBox inpPhoneNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private quanlykhoDataSet quanlykhoDataSet1;
        private quanlykhoDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNcc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.BindingSource nhaCungCapBindingSource;
        private quanlykhoDataSetTableAdapters.NhaCungCapTableAdapter nhaCungCapTableAdapter1;
        private System.Windows.Forms.Button btnCancel;
    }
}