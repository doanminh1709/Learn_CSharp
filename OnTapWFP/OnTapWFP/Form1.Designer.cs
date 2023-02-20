namespace OnTapWFP
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMsv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.btnButtonSoft = new System.Windows.Forms.Button();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NamStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Scores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên sinh viên :";
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(375, 29);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(198, 22);
            this.txtTenSV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã sinh viên :";
            // 
            // txtMsv
            // 
            this.txtMsv.Location = new System.Drawing.Point(375, 81);
            this.txtMsv.Name = "txtMsv";
            this.txtMsv.Size = new System.Drawing.Size(198, 22);
            this.txtMsv.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Điểm : ";
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(375, 138);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(198, 22);
            this.txtDiem.TabIndex = 5;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(189, 209);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 6;
            this.add.Text = "Thêm";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(285, 209);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 23);
            this.edit.TabIndex = 7;
            this.edit.Text = "Sửa";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(391, 209);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 8;
            this.delete.Text = "Xóa";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // btnButtonSoft
            // 
            this.btnButtonSoft.Location = new System.Drawing.Point(498, 209);
            this.btnButtonSoft.Name = "btnButtonSoft";
            this.btnButtonSoft.Size = new System.Drawing.Size(75, 23);
            this.btnButtonSoft.TabIndex = 9;
            this.btnButtonSoft.Text = "Sắp xếp";
            this.btnButtonSoft.UseVisualStyleBackColor = true;
            this.btnButtonSoft.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Location = new System.Drawing.Point(189, 281);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(265, 22);
            this.txtBoxSearch.TabIndex = 10;
            this.txtBoxSearch.TextChanged += new System.EventHandler(this.txtBoxSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(498, 280);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NamStudent,
            this.StudentCode,
            this.Scores});
            this.dataGridView1.Location = new System.Drawing.Point(46, 338);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(598, 150);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // NamStudent
            // 
            this.NamStudent.DataPropertyName = "tensv";
            this.NamStudent.HeaderText = "Tên sinh viên";
            this.NamStudent.MinimumWidth = 6;
            this.NamStudent.Name = "NamStudent";
            this.NamStudent.Width = 200;
            // 
            // StudentCode
            // 
            this.StudentCode.DataPropertyName = "masv";
            this.StudentCode.HeaderText = "Mã sinh viên";
            this.StudentCode.MinimumWidth = 6;
            this.StudentCode.Name = "StudentCode";
            this.StudentCode.Width = 190;
            // 
            // Scores
            // 
            this.Scores.DataPropertyName = "diem";
            this.Scores.HeaderText = "Điểm";
            this.Scores.MinimumWidth = 6;
            this.Scores.Name = "Scores";
            this.Scores.Width = 155;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 554);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.btnButtonSoft);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.add);
            this.Controls.Add(this.txtDiem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMsv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenSV);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMsv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button btnButtonSoft;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Scores;
    }
}

