﻿namespace Aplikasi_Kontak_dengan_Database
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.btnCari = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnPerbarui = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtTelepon = new System.Windows.Forms.TextBox();
            this.txtPekerjaan = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.txtNamaBelakang = new System.Windows.Forms.TextBox();
            this.txtNamaDepan = new System.Windows.Forms.TextBox();
            this.txtNomorKamar = new System.Windows.Forms.TextBox();
            this.labelTelepon = new System.Windows.Forms.Label();
            this.labelPekerjaan = new System.Windows.Forms.Label();
            this.labelAlamat = new System.Windows.Forms.Label();
            this.labelNamaBelakang = new System.Windows.Forms.Label();
            this.labelNamaDepan = new System.Windows.Forms.Label();
            this.labelKamar = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnView = new System.Windows.Forms.Button();
            this.kosnigelDataSet1 = new Aplikasi_Kontak_dengan_Database.kosnigelDataSet1();
            this.kosnigelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kosnigelTableAdapter = new Aplikasi_Kontak_dengan_Database.kosnigelDataSet1TableAdapters.kosnigelTableAdapter();
            this.nomorKamarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namadepanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namabelakangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pekerjaanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teleponDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kosnigelDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kosnigelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 528);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(12, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(610, 86);
            this.panel5.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(396, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "KONTAK KOS NIGEL PAMULANGAN";
            // 
            // txtCari
            // 
            this.txtCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCari.Location = new System.Drawing.Point(456, 20);
            this.txtCari.Multiline = true;
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(144, 19);
            this.txtCari.TabIndex = 0;
            // 
            // btnCari
            // 
            this.btnCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCari.Location = new System.Drawing.Point(489, 44);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(75, 23);
            this.btnCari.TabIndex = 6;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(489, 69);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(363, 116);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(363, 91);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.Location = new System.Drawing.Point(363, 66);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 2;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnPerbarui
            // 
            this.btnPerbarui.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerbarui.Location = new System.Drawing.Point(363, 41);
            this.btnPerbarui.Name = "btnPerbarui";
            this.btnPerbarui.Size = new System.Drawing.Size(75, 23);
            this.btnPerbarui.TabIndex = 1;
            this.btnPerbarui.Text = "Perbarui";
            this.btnPerbarui.UseVisualStyleBackColor = true;
            this.btnPerbarui.Click += new System.EventHandler(this.btnPerbarui_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.Location = new System.Drawing.Point(363, 16);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 23);
            this.btnTambah.TabIndex = 0;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnView);
            this.panel2.Controls.Add(this.btnCari);
            this.panel2.Controls.Add(this.txtCari);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.txtTelepon);
            this.panel2.Controls.Add(this.txtPekerjaan);
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Controls.Add(this.txtAlamat);
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.txtNamaBelakang);
            this.panel2.Controls.Add(this.btnHapus);
            this.panel2.Controls.Add(this.txtNamaDepan);
            this.panel2.Controls.Add(this.btnPerbarui);
            this.panel2.Controls.Add(this.txtNomorKamar);
            this.panel2.Controls.Add(this.btnTambah);
            this.panel2.Controls.Add(this.labelTelepon);
            this.panel2.Controls.Add(this.labelPekerjaan);
            this.panel2.Controls.Add(this.labelAlamat);
            this.panel2.Controls.Add(this.labelNamaBelakang);
            this.panel2.Controls.Add(this.labelNamaDepan);
            this.panel2.Controls.Add(this.labelKamar);
            this.panel2.Location = new System.Drawing.Point(12, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(610, 412);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomorKamarDataGridViewTextBoxColumn,
            this.namadepanDataGridViewTextBoxColumn,
            this.namabelakangDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn,
            this.pekerjaanDataGridViewTextBoxColumn,
            this.teleponDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kosnigelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(4, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(602, 227);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtTelepon
            // 
            this.txtTelepon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelepon.Location = new System.Drawing.Point(170, 141);
            this.txtTelepon.Multiline = true;
            this.txtTelepon.Name = "txtTelepon";
            this.txtTelepon.Size = new System.Drawing.Size(177, 19);
            this.txtTelepon.TabIndex = 10;
            // 
            // txtPekerjaan
            // 
            this.txtPekerjaan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPekerjaan.Location = new System.Drawing.Point(170, 116);
            this.txtPekerjaan.Multiline = true;
            this.txtPekerjaan.Name = "txtPekerjaan";
            this.txtPekerjaan.Size = new System.Drawing.Size(177, 19);
            this.txtPekerjaan.TabIndex = 9;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlamat.Location = new System.Drawing.Point(170, 91);
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(177, 19);
            this.txtAlamat.TabIndex = 8;
            // 
            // txtNamaBelakang
            // 
            this.txtNamaBelakang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaBelakang.Location = new System.Drawing.Point(170, 66);
            this.txtNamaBelakang.Multiline = true;
            this.txtNamaBelakang.Name = "txtNamaBelakang";
            this.txtNamaBelakang.Size = new System.Drawing.Size(177, 19);
            this.txtNamaBelakang.TabIndex = 7;
            // 
            // txtNamaDepan
            // 
            this.txtNamaDepan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaDepan.Location = new System.Drawing.Point(170, 41);
            this.txtNamaDepan.Multiline = true;
            this.txtNamaDepan.Name = "txtNamaDepan";
            this.txtNamaDepan.Size = new System.Drawing.Size(177, 19);
            this.txtNamaDepan.TabIndex = 6;
            // 
            // txtNomorKamar
            // 
            this.txtNomorKamar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomorKamar.Location = new System.Drawing.Point(170, 16);
            this.txtNomorKamar.Multiline = true;
            this.txtNomorKamar.Name = "txtNomorKamar";
            this.txtNomorKamar.Size = new System.Drawing.Size(177, 19);
            this.txtNomorKamar.TabIndex = 1;
            // 
            // labelTelepon
            // 
            this.labelTelepon.AutoSize = true;
            this.labelTelepon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelepon.Location = new System.Drawing.Point(25, 144);
            this.labelTelepon.Name = "labelTelepon";
            this.labelTelepon.Size = new System.Drawing.Size(58, 16);
            this.labelTelepon.TabIndex = 5;
            this.labelTelepon.Text = "Telepon";
            // 
            // labelPekerjaan
            // 
            this.labelPekerjaan.AutoSize = true;
            this.labelPekerjaan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPekerjaan.Location = new System.Drawing.Point(25, 119);
            this.labelPekerjaan.Name = "labelPekerjaan";
            this.labelPekerjaan.Size = new System.Drawing.Size(69, 16);
            this.labelPekerjaan.TabIndex = 4;
            this.labelPekerjaan.Text = "Pekerjaan";
            // 
            // labelAlamat
            // 
            this.labelAlamat.AutoSize = true;
            this.labelAlamat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlamat.Location = new System.Drawing.Point(25, 94);
            this.labelAlamat.Name = "labelAlamat";
            this.labelAlamat.Size = new System.Drawing.Size(49, 16);
            this.labelAlamat.TabIndex = 3;
            this.labelAlamat.Text = "Alamat";
            // 
            // labelNamaBelakang
            // 
            this.labelNamaBelakang.AutoSize = true;
            this.labelNamaBelakang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaBelakang.Location = new System.Drawing.Point(25, 69);
            this.labelNamaBelakang.Name = "labelNamaBelakang";
            this.labelNamaBelakang.Size = new System.Drawing.Size(105, 16);
            this.labelNamaBelakang.TabIndex = 2;
            this.labelNamaBelakang.Text = "Nama Belakang";
            // 
            // labelNamaDepan
            // 
            this.labelNamaDepan.AutoSize = true;
            this.labelNamaDepan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaDepan.Location = new System.Drawing.Point(25, 44);
            this.labelNamaDepan.Name = "labelNamaDepan";
            this.labelNamaDepan.Size = new System.Drawing.Size(88, 16);
            this.labelNamaDepan.TabIndex = 1;
            this.labelNamaDepan.Text = "Nama Depan";
            // 
            // labelKamar
            // 
            this.labelKamar.AutoSize = true;
            this.labelKamar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKamar.Location = new System.Drawing.Point(25, 19);
            this.labelKamar.Name = "labelKamar";
            this.labelKamar.Size = new System.Drawing.Size(90, 16);
            this.labelKamar.TabIndex = 0;
            this.labelKamar.Text = "Nomor Kamar";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(363, 141);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 7;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // kosnigelDataSet1
            // 
            this.kosnigelDataSet1.DataSetName = "kosnigelDataSet1";
            this.kosnigelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kosnigelBindingSource
            // 
            this.kosnigelBindingSource.DataMember = "kosnigel";
            this.kosnigelBindingSource.DataSource = this.kosnigelDataSet1;
            // 
            // kosnigelTableAdapter
            // 
            this.kosnigelTableAdapter.ClearBeforeFill = true;
            // 
            // nomorKamarDataGridViewTextBoxColumn
            // 
            this.nomorKamarDataGridViewTextBoxColumn.DataPropertyName = "NomorKamar";
            this.nomorKamarDataGridViewTextBoxColumn.HeaderText = "NomorKamar";
            this.nomorKamarDataGridViewTextBoxColumn.Name = "nomorKamarDataGridViewTextBoxColumn";
            // 
            // namadepanDataGridViewTextBoxColumn
            // 
            this.namadepanDataGridViewTextBoxColumn.DataPropertyName = "Namadepan";
            this.namadepanDataGridViewTextBoxColumn.HeaderText = "Namadepan";
            this.namadepanDataGridViewTextBoxColumn.Name = "namadepanDataGridViewTextBoxColumn";
            // 
            // namabelakangDataGridViewTextBoxColumn
            // 
            this.namabelakangDataGridViewTextBoxColumn.DataPropertyName = "Namabelakang";
            this.namabelakangDataGridViewTextBoxColumn.HeaderText = "Namabelakang";
            this.namabelakangDataGridViewTextBoxColumn.Name = "namabelakangDataGridViewTextBoxColumn";
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "Alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "Alamat";
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            // 
            // pekerjaanDataGridViewTextBoxColumn
            // 
            this.pekerjaanDataGridViewTextBoxColumn.DataPropertyName = "Pekerjaan";
            this.pekerjaanDataGridViewTextBoxColumn.HeaderText = "Pekerjaan";
            this.pekerjaanDataGridViewTextBoxColumn.Name = "pekerjaanDataGridViewTextBoxColumn";
            // 
            // teleponDataGridViewTextBoxColumn
            // 
            this.teleponDataGridViewTextBoxColumn.DataPropertyName = "Telepon";
            this.teleponDataGridViewTextBoxColumn.HeaderText = "Telepon";
            this.teleponDataGridViewTextBoxColumn.Name = "teleponDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 528);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kosnigelDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kosnigelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnPerbarui;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtTelepon;
        private System.Windows.Forms.TextBox txtPekerjaan;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.TextBox txtNamaBelakang;
        private System.Windows.Forms.TextBox txtNamaDepan;
        private System.Windows.Forms.TextBox txtNomorKamar;
        private System.Windows.Forms.Label labelTelepon;
        private System.Windows.Forms.Label labelPekerjaan;
        private System.Windows.Forms.Label labelAlamat;
        private System.Windows.Forms.Label labelNamaBelakang;
        private System.Windows.Forms.Label labelNamaDepan;
        private System.Windows.Forms.Label labelKamar;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private kosnigelDataSet1 kosnigelDataSet1;
        private System.Windows.Forms.BindingSource kosnigelBindingSource;
        private kosnigelDataSet1TableAdapters.kosnigelTableAdapter kosnigelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomorKamarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namadepanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namabelakangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pekerjaanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teleponDataGridViewTextBoxColumn;
    }
}

