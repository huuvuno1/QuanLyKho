
namespace QuanLyKho
{
    partial class FormSanPhamChiTiet
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
            this.dataGridViewSp = new System.Windows.Forms.DataGridView();
            this.inpMin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inpMax = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSp)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSp
            // 
            this.dataGridViewSp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSp.Location = new System.Drawing.Point(71, 278);
            this.dataGridViewSp.Name = "dataGridViewSp";
            this.dataGridViewSp.RowHeadersWidth = 51;
            this.dataGridViewSp.RowTemplate.Height = 24;
            this.dataGridViewSp.Size = new System.Drawing.Size(900, 305);
            this.dataGridViewSp.TabIndex = 0;
            // 
            // inpMin
            // 
            this.inpMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpMin.Location = new System.Drawing.Point(163, 113);
            this.inpMin.Name = "inpMin";
            this.inpMin.Size = new System.Drawing.Size(281, 30);
            this.inpMin.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Min tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Max tiền";
            // 
            // inpMax
            // 
            this.inpMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpMax.Location = new System.Drawing.Point(163, 164);
            this.inpMax.Name = "inpMax";
            this.inpMax.Size = new System.Drawing.Size(281, 30);
            this.inpMax.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(163, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormSanPhamChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 624);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inpMax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inpMin);
            this.Controls.Add(this.dataGridViewSp);
            this.Name = "FormSanPhamChiTiet";
            this.Text = "FormSanPhamChiTiet";
            this.Load += new System.EventHandler(this.FormSanPhamChiTiet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSp;
        private System.Windows.Forms.TextBox inpMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inpMax;
        private System.Windows.Forms.Button button1;
    }
}