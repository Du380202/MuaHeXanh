namespace QLMuaHeXanh.Report
{
    partial class frmSinhVienReport
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDiaBan = new System.Windows.Forms.ComboBox();
            this.rbtDiaBan = new System.Windows.Forms.RadioButton();
            this.rbtAllDiaBan = new System.Windows.Forms.RadioButton();
            this.rbtDSKhoa = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.cmbDiaBan);
            this.panelControl1.Controls.Add(this.rbtDiaBan);
            this.panelControl1.Controls.Add(this.rbtAllDiaBan);
            this.panelControl1.Controls.Add(this.rbtDSKhoa);
            this.panelControl1.Controls.Add(this.button1);
            this.panelControl1.Location = new System.Drawing.Point(54, 11);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(561, 339);
            this.panelControl1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(318, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Chọn Địa bàn:";
            // 
            // cmbDiaBan
            // 
            this.cmbDiaBan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbDiaBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbDiaBan.FormattingEnabled = true;
            this.cmbDiaBan.Location = new System.Drawing.Point(321, 127);
            this.cmbDiaBan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbDiaBan.Name = "cmbDiaBan";
            this.cmbDiaBan.Size = new System.Drawing.Size(194, 27);
            this.cmbDiaBan.TabIndex = 11;
            // 
            // rbtDiaBan
            // 
            this.rbtDiaBan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtDiaBan.AutoSize = true;
            this.rbtDiaBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbtDiaBan.Location = new System.Drawing.Point(321, 57);
            this.rbtDiaBan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtDiaBan.Name = "rbtDiaBan";
            this.rbtDiaBan.Size = new System.Drawing.Size(203, 23);
            this.rbtDiaBan.TabIndex = 10;
            this.rbtDiaBan.TabStop = true;
            this.rbtDiaBan.Text = "Danh sách theo từng địa bàn ";
            this.rbtDiaBan.UseVisualStyleBackColor = true;
            this.rbtDiaBan.CheckedChanged += new System.EventHandler(this.rbtDiaBan_CheckedChanged);
            // 
            // rbtAllDiaBan
            // 
            this.rbtAllDiaBan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtAllDiaBan.AutoSize = true;
            this.rbtAllDiaBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbtAllDiaBan.Location = new System.Drawing.Point(47, 127);
            this.rbtAllDiaBan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtAllDiaBan.Name = "rbtAllDiaBan";
            this.rbtAllDiaBan.Size = new System.Drawing.Size(179, 23);
            this.rbtAllDiaBan.TabIndex = 9;
            this.rbtAllDiaBan.TabStop = true;
            this.rbtAllDiaBan.Text = "Danh sách tất cả địa bàn ";
            this.rbtAllDiaBan.UseVisualStyleBackColor = true;
            this.rbtAllDiaBan.CheckedChanged += new System.EventHandler(this.rbtAllDiaBan_CheckedChanged);
            // 
            // rbtDSKhoa
            // 
            this.rbtDSKhoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtDSKhoa.AutoSize = true;
            this.rbtDSKhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbtDSKhoa.Location = new System.Drawing.Point(47, 57);
            this.rbtDSKhoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtDSKhoa.Name = "rbtDSKhoa";
            this.rbtDSKhoa.Size = new System.Drawing.Size(154, 23);
            this.rbtDSKhoa.TabIndex = 8;
            this.rbtDSKhoa.TabStop = true;
            this.rbtDSKhoa.Text = "Danh Sách Sinh Viên";
            this.rbtDSKhoa.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Location = new System.Drawing.Point(201, 230);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 52);
            this.button1.TabIndex = 7;
            this.button1.Text = "Preview";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmSinhVienReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 385);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmSinhVienReport";
            this.Text = "Report Sinh Viên";
            this.Load += new System.EventHandler(this.frmSinhVienReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDiaBan;
        private System.Windows.Forms.RadioButton rbtDiaBan;
        private System.Windows.Forms.RadioButton rbtAllDiaBan;
        private System.Windows.Forms.RadioButton rbtDSKhoa;
        private System.Windows.Forms.Button button1;
    }
}