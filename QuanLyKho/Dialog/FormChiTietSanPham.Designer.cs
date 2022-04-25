
namespace QuanLyKho.Dialog
{
    partial class FormChiTietSanPham
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
            this.dataGridViewChiTiet = new System.Windows.Forms.DataGridView();
            this.inpTen = new System.Windows.Forms.TextBox();
            this.inpDonViTinh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inpMoTa = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inpMa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewChiTiet
            // 
            this.dataGridViewChiTiet.AllowUserToAddRows = false;
            this.dataGridViewChiTiet.AllowUserToDeleteRows = false;
            this.dataGridViewChiTiet.AllowUserToResizeColumns = false;
            this.dataGridViewChiTiet.AllowUserToResizeRows = false;
            this.dataGridViewChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChiTiet.Location = new System.Drawing.Point(48, 204);
            this.dataGridViewChiTiet.Name = "dataGridViewChiTiet";
            this.dataGridViewChiTiet.ReadOnly = true;
            this.dataGridViewChiTiet.RowHeadersWidth = 51;
            this.dataGridViewChiTiet.RowTemplate.Height = 24;
            this.dataGridViewChiTiet.Size = new System.Drawing.Size(700, 255);
            this.dataGridViewChiTiet.TabIndex = 0;
            // 
            // inpTen
            // 
            this.inpTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpTen.Location = new System.Drawing.Point(161, 86);
            this.inpTen.Name = "inpTen";
            this.inpTen.ReadOnly = true;
            this.inpTen.Size = new System.Drawing.Size(237, 30);
            this.inpTen.TabIndex = 1;
            // 
            // inpDonViTinh
            // 
            this.inpDonViTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpDonViTinh.Location = new System.Drawing.Point(161, 134);
            this.inpDonViTinh.Name = "inpDonViTinh";
            this.inpDonViTinh.ReadOnly = true;
            this.inpDonViTinh.Size = new System.Drawing.Size(237, 30);
            this.inpDonViTinh.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Đơn vị tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(430, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mô tả";
            // 
            // inpMoTa
            // 
            this.inpMoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpMoTa.Location = new System.Drawing.Point(509, 36);
            this.inpMoTa.Name = "inpMoTa";
            this.inpMoTa.ReadOnly = true;
            this.inpMoTa.Size = new System.Drawing.Size(239, 129);
            this.inpMoTa.TabIndex = 7;
            this.inpMoTa.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mã sp";
            // 
            // inpMa
            // 
            this.inpMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpMa.Location = new System.Drawing.Point(161, 30);
            this.inpMa.Name = "inpMa";
            this.inpMa.ReadOnly = true;
            this.inpMa.Size = new System.Drawing.Size(237, 30);
            this.inpMa.TabIndex = 8;
            // 
            // FormChiTietSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 482);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inpMa);
            this.Controls.Add(this.inpMoTa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inpDonViTinh);
            this.Controls.Add(this.inpTen);
            this.Controls.Add(this.dataGridViewChiTiet);
            this.Name = "FormChiTietSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết sản phẩm";
            this.Load += new System.EventHandler(this.FormChiTietSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTiet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewChiTiet;
        private System.Windows.Forms.TextBox inpTen;
        private System.Windows.Forms.TextBox inpDonViTinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox inpMoTa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inpMa;
    }
}