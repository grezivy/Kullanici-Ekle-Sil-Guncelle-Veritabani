namespace hft2_nesnetabanli
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnadd = new Button();
            btndelete = new Button();
            btnupdate = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtad = new TextBox();
            txtsoyad = new TextBox();
            txtmail = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnadd
            // 
            btnadd.Location = new Point(473, 34);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(94, 76);
            btnadd.TabIndex = 0;
            btnadd.Text = "Ekle";
            btnadd.UseVisualStyleBackColor = true;
            // 
            // btndelete
            // 
            btndelete.Location = new Point(473, 126);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(94, 76);
            btndelete.TabIndex = 1;
            btndelete.Text = "Sil";
            btndelete.UseVisualStyleBackColor = true;
            // 
            // btnupdate
            // 
            btnupdate.Location = new Point(573, 34);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(94, 74);
            btnupdate.TabIndex = 2;
            btnupdate.Text = "Güncelle";
            btnupdate.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 208);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(776, 230);
            dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 34);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 4;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 88);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 5;
            label2.Text = "Soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 139);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 6;
            label3.Text = "Email";
            // 
            // txtad
            // 
            txtad.Location = new Point(124, 27);
            txtad.Name = "txtad";
            txtad.Size = new Size(231, 27);
            txtad.TabIndex = 7;
            // 
            // txtsoyad
            // 
            txtsoyad.Location = new Point(124, 81);
            txtsoyad.Name = "txtsoyad";
            txtsoyad.Size = new Size(231, 27);
            txtsoyad.TabIndex = 8;
            // 
            // txtmail
            // 
            txtmail.Location = new Point(124, 139);
            txtmail.Name = "txtmail";
            txtmail.Size = new Size(231, 27);
            txtmail.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtmail);
            Controls.Add(txtsoyad);
            Controls.Add(txtad);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btnupdate);
            Controls.Add(btndelete);
            Controls.Add(btnadd);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnadd;
        private Button btndelete;
        private Button btnupdate;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtad;
        private TextBox txtsoyad;
        private TextBox txtmail;
    }
}
