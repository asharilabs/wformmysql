namespace Mysql_Form_2
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
            this.dgv_data = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_npm = new System.Windows.Forms.TextBox();
            this.txtbox_nama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbox_nohp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbox_asalsma = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbox_umur = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_showdata = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.btn_tambah = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_data
            // 
            this.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_data.Location = new System.Drawing.Point(12, 12);
            this.dgv_data.Name = "dgv_data";
            this.dgv_data.Size = new System.Drawing.Size(478, 275);
            this.dgv_data.TabIndex = 0;
            this.dgv_data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_data_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(504, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "npm";
            // 
            // txtbox_npm
            // 
            this.txtbox_npm.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_npm.Location = new System.Drawing.Point(507, 28);
            this.txtbox_npm.Name = "txtbox_npm";
            this.txtbox_npm.ReadOnly = true;
            this.txtbox_npm.Size = new System.Drawing.Size(233, 27);
            this.txtbox_npm.TabIndex = 2;
            // 
            // txtbox_nama
            // 
            this.txtbox_nama.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_nama.Location = new System.Drawing.Point(507, 83);
            this.txtbox_nama.Name = "txtbox_nama";
            this.txtbox_nama.Size = new System.Drawing.Size(233, 27);
            this.txtbox_nama.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(504, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(504, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Alamat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(504, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Jenis Kelamin";
            // 
            // txtbox_nohp
            // 
            this.txtbox_nohp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_nohp.Location = new System.Drawing.Point(507, 260);
            this.txtbox_nohp.Name = "txtbox_nohp";
            this.txtbox_nohp.Size = new System.Drawing.Size(233, 27);
            this.txtbox_nohp.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(504, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "HP";
            // 
            // txtbox_asalsma
            // 
            this.txtbox_asalsma.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_asalsma.Location = new System.Drawing.Point(507, 314);
            this.txtbox_asalsma.Name = "txtbox_asalsma";
            this.txtbox_asalsma.Size = new System.Drawing.Size(233, 27);
            this.txtbox_asalsma.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(504, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Asal SMA";
            // 
            // txtbox_umur
            // 
            this.txtbox_umur.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_umur.Location = new System.Drawing.Point(507, 367);
            this.txtbox_umur.Name = "txtbox_umur";
            this.txtbox_umur.Size = new System.Drawing.Size(233, 27);
            this.txtbox_umur.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(504, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Umur";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "",
            "Pria",
            "Wanita"});
            this.comboBox1.Location = new System.Drawing.Point(507, 212);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(233, 27);
            this.comboBox1.TabIndex = 15;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(507, 140);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(233, 53);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            // 
            // btn_showdata
            // 
            this.btn_showdata.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btn_showdata.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_showdata.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showdata.Location = new System.Drawing.Point(12, 314);
            this.btn_showdata.Name = "btn_showdata";
            this.btn_showdata.Size = new System.Drawing.Size(115, 54);
            this.btn_showdata.TabIndex = 17;
            this.btn_showdata.Text = "Tampil Data";
            this.btn_showdata.UseVisualStyleBackColor = true;
            this.btn_showdata.Click += new System.EventHandler(this.btn_showdata_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btn_reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_reset.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(375, 314);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(115, 54);
            this.btn_reset.TabIndex = 18;
            this.btn_reset.Text = "Ubah Data";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_hapus
            // 
            this.btn_hapus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btn_hapus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_hapus.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hapus.Location = new System.Drawing.Point(254, 314);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(115, 54);
            this.btn_hapus.TabIndex = 19;
            this.btn_hapus.Text = "Hapus Data";
            this.btn_hapus.UseVisualStyleBackColor = true;
            this.btn_hapus.Click += new System.EventHandler(this.btn_hapus_Click);
            // 
            // btn_tambah
            // 
            this.btn_tambah.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btn_tambah.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_tambah.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tambah.Location = new System.Drawing.Point(133, 314);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(115, 54);
            this.btn_tambah.TabIndex = 20;
            this.btn_tambah.Text = "Tambah Data";
            this.btn_tambah.UseVisualStyleBackColor = true;
            this.btn_tambah.Click += new System.EventHandler(this.btn_tambah_Click);
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(757, 28);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(44, 23);
            this.btn_new.TabIndex = 21;
            this.btn_new.Text = "NEW";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 415);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_tambah);
            this.Controls.Add(this.btn_hapus);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_showdata);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtbox_umur);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtbox_asalsma);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtbox_nohp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbox_nama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbox_npm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_data);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_npm;
        private System.Windows.Forms.TextBox txtbox_nama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbox_nohp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbox_asalsma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbox_umur;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_showdata;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.Button btn_tambah;
        private System.Windows.Forms.Button btn_new;
    }
}

