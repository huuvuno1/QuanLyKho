
namespace QuanLyKho.Report
{
    partial class ReportHoaDonNhapForm
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.inpMinTien = new System.Windows.Forms.TextBox();
            this.inpMaxTien = new System.Windows.Forms.TextBox();
            this.sdfsdf = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1043, 624);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // inpMinTien
            // 
            this.inpMinTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpMinTien.Location = new System.Drawing.Point(24, 131);
            this.inpMinTien.Name = "inpMinTien";
            this.inpMinTien.Size = new System.Drawing.Size(155, 30);
            this.inpMinTien.TabIndex = 1;
            // 
            // inpMaxTien
            // 
            this.inpMaxTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpMaxTien.Location = new System.Drawing.Point(24, 218);
            this.inpMaxTien.Name = "inpMaxTien";
            this.inpMaxTien.Size = new System.Drawing.Size(155, 30);
            this.inpMaxTien.TabIndex = 2;
            // 
            // sdfsdf
            // 
            this.sdfsdf.AutoSize = true;
            this.sdfsdf.Location = new System.Drawing.Point(21, 111);
            this.sdfsdf.Name = "sdfsdf";
            this.sdfsdf.Size = new System.Drawing.Size(62, 17);
            this.sdfsdf.TabIndex = 3;
            this.sdfsdf.Text = "Min Tiền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Max Tiền";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(24, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReportHoaDonNhapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 624);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sdfsdf);
            this.Controls.Add(this.inpMaxTien);
            this.Controls.Add(this.inpMinTien);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "ReportHoaDonNhapForm";
            this.Text = "ReportHoaDonNhapForm";
            this.Load += new System.EventHandler(this.ReportHoaDonNhapForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.TextBox inpMinTien;
        private System.Windows.Forms.TextBox inpMaxTien;
        private System.Windows.Forms.Label sdfsdf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}