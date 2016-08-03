namespace AutoClickerTyper
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
            this.tmrGeneric = new System.Windows.Forms.Timer(this.components);
            this.tmrProgram = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAlwaysOnTop = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.gbProgram = new System.Windows.Forms.GroupBox();
            this.btSimulate = new System.Windows.Forms.Button();
            this.btAddRow = new System.Windows.Forms.Button();
            this.btCopyRow = new System.Windows.Forms.Button();
            this.btDeleteRow = new System.Windows.Forms.Button();
            this.btEditRow = new System.Windows.Forms.Button();
            this.btExport = new System.Windows.Forms.Button();
            this.btImport = new System.Windows.Forms.Button();
            this.dgvProgram = new System.Windows.Forms.DataGridView();
            this.gbInfoXY = new System.Windows.Forms.GroupBox();
            this.cbxConfirm = new System.Windows.Forms.CheckBox();
            this.btStop = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.txbCurY = new System.Windows.Forms.TextBox();
            this.txbCurX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbNewProgY = new System.Windows.Forms.TextBox();
            this.txbNewProgX = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txbNewProgDelay = new System.Windows.Forms.TextBox();
            this.btNewRow = new System.Windows.Forms.Button();
            this.txbNewProgText = new System.Windows.Forms.TextBox();
            this.cbNewProgFunction = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btNewProgDetection = new System.Windows.Forms.Button();
            this.tmrSimulate = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.gbProgram.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgram)).BeginInit();
            this.gbInfoXY.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrGeneric
            // 
            this.tmrGeneric.Enabled = true;
            this.tmrGeneric.Interval = 1;
            this.tmrGeneric.Tick += new System.EventHandler(this.tmrGeneric_Tick);
            // 
            // tmrProgram
            // 
            this.tmrProgram.Tick += new System.EventHandler(this.tmrProgram_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFile,
            this.tsmView,
            this.tsmAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmFile
            // 
            this.tsmFile.Name = "tsmFile";
            this.tsmFile.Size = new System.Drawing.Size(51, 20);
            this.tsmFile.Text = "Dosya";
            // 
            // tsmView
            // 
            this.tsmView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAlwaysOnTop});
            this.tsmView.Name = "tsmView";
            this.tsmView.Size = new System.Drawing.Size(70, 20);
            this.tsmView.Text = "Görünüm";
            // 
            // tsmAlwaysOnTop
            // 
            this.tsmAlwaysOnTop.Checked = true;
            this.tsmAlwaysOnTop.CheckOnClick = true;
            this.tsmAlwaysOnTop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmAlwaysOnTop.Name = "tsmAlwaysOnTop";
            this.tsmAlwaysOnTop.Size = new System.Drawing.Size(160, 22);
            this.tsmAlwaysOnTop.Text = "Her zaman üstte";
            this.tsmAlwaysOnTop.Click += new System.EventHandler(this.tsmAlwaysOnTop_Click);
            // 
            // tsmAbout
            // 
            this.tsmAbout.Name = "tsmAbout";
            this.tsmAbout.Size = new System.Drawing.Size(69, 20);
            this.tsmAbout.Text = "Hakkında";
            // 
            // gbProgram
            // 
            this.gbProgram.Controls.Add(this.btSimulate);
            this.gbProgram.Controls.Add(this.btAddRow);
            this.gbProgram.Controls.Add(this.btCopyRow);
            this.gbProgram.Controls.Add(this.btDeleteRow);
            this.gbProgram.Controls.Add(this.btEditRow);
            this.gbProgram.Controls.Add(this.btExport);
            this.gbProgram.Controls.Add(this.btImport);
            this.gbProgram.Controls.Add(this.dgvProgram);
            this.gbProgram.Location = new System.Drawing.Point(14, 34);
            this.gbProgram.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.gbProgram.Name = "gbProgram";
            this.gbProgram.Padding = new System.Windows.Forms.Padding(10);
            this.gbProgram.Size = new System.Drawing.Size(335, 269);
            this.gbProgram.TabIndex = 2;
            this.gbProgram.TabStop = false;
            this.gbProgram.Text = "Liste";
            // 
            // btSimulate
            // 
            this.btSimulate.Location = new System.Drawing.Point(10, 200);
            this.btSimulate.Name = "btSimulate";
            this.btSimulate.Size = new System.Drawing.Size(70, 25);
            this.btSimulate.TabIndex = 14;
            this.btSimulate.Text = "Simule Et";
            this.btSimulate.UseVisualStyleBackColor = true;
            this.btSimulate.Click += new System.EventHandler(this.btSimulate_Click);
            // 
            // btAddRow
            // 
            this.btAddRow.Location = new System.Drawing.Point(89, 200);
            this.btAddRow.Name = "btAddRow";
            this.btAddRow.Size = new System.Drawing.Size(60, 25);
            this.btAddRow.TabIndex = 13;
            this.btAddRow.Text = "Öne Ekle";
            this.btAddRow.UseVisualStyleBackColor = true;
            this.btAddRow.Click += new System.EventHandler(this.btInsertRow_Click);
            // 
            // btCopyRow
            // 
            this.btCopyRow.Location = new System.Drawing.Point(155, 200);
            this.btCopyRow.Name = "btCopyRow";
            this.btCopyRow.Size = new System.Drawing.Size(60, 25);
            this.btCopyRow.TabIndex = 12;
            this.btCopyRow.Text = "Kopyala";
            this.btCopyRow.UseVisualStyleBackColor = true;
            this.btCopyRow.Click += new System.EventHandler(this.btCopyRow_Click);
            // 
            // btDeleteRow
            // 
            this.btDeleteRow.Location = new System.Drawing.Point(287, 200);
            this.btDeleteRow.Name = "btDeleteRow";
            this.btDeleteRow.Size = new System.Drawing.Size(38, 25);
            this.btDeleteRow.TabIndex = 11;
            this.btDeleteRow.Text = "Sil";
            this.btDeleteRow.UseVisualStyleBackColor = true;
            this.btDeleteRow.Click += new System.EventHandler(this.btDeleteRow_Click);
            // 
            // btEditRow
            // 
            this.btEditRow.Location = new System.Drawing.Point(221, 200);
            this.btEditRow.Name = "btEditRow";
            this.btEditRow.Size = new System.Drawing.Size(60, 25);
            this.btEditRow.TabIndex = 10;
            this.btEditRow.Text = "Tümü";
            this.btEditRow.UseVisualStyleBackColor = true;
            this.btEditRow.Click += new System.EventHandler(this.btEditRow_Click);
            // 
            // btExport
            // 
            this.btExport.Location = new System.Drawing.Point(175, 231);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(150, 25);
            this.btExport.TabIndex = 9;
            this.btExport.Text = "Kaydet";
            this.btExport.UseVisualStyleBackColor = true;
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // btImport
            // 
            this.btImport.Location = new System.Drawing.Point(10, 231);
            this.btImport.Name = "btImport";
            this.btImport.Size = new System.Drawing.Size(150, 25);
            this.btImport.TabIndex = 8;
            this.btImport.Text = "Aç";
            this.btImport.UseVisualStyleBackColor = true;
            this.btImport.Click += new System.EventHandler(this.btImport_Click);
            // 
            // dgvProgram
            // 
            this.dgvProgram.AllowUserToAddRows = false;
            this.dgvProgram.AllowUserToDeleteRows = false;
            this.dgvProgram.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProgram.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvProgram.Location = new System.Drawing.Point(10, 23);
            this.dgvProgram.MultiSelect = false;
            this.dgvProgram.Name = "dgvProgram";
            this.dgvProgram.RowHeadersVisible = false;
            this.dgvProgram.Size = new System.Drawing.Size(315, 171);
            this.dgvProgram.TabIndex = 0;
            // 
            // gbInfoXY
            // 
            this.gbInfoXY.Controls.Add(this.cbxConfirm);
            this.gbInfoXY.Controls.Add(this.btStop);
            this.gbInfoXY.Controls.Add(this.btStart);
            this.gbInfoXY.Controls.Add(this.txbCurY);
            this.gbInfoXY.Controls.Add(this.txbCurX);
            this.gbInfoXY.Controls.Add(this.label3);
            this.gbInfoXY.Controls.Add(this.label2);
            this.gbInfoXY.Location = new System.Drawing.Point(359, 34);
            this.gbInfoXY.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.gbInfoXY.Name = "gbInfoXY";
            this.gbInfoXY.Padding = new System.Windows.Forms.Padding(10);
            this.gbInfoXY.Size = new System.Drawing.Size(211, 96);
            this.gbInfoXY.TabIndex = 3;
            this.gbInfoXY.TabStop = false;
            this.gbInfoXY.Text = "Koordinatlar";
            // 
            // cbxConfirm
            // 
            this.cbxConfirm.AutoSize = true;
            this.cbxConfirm.Location = new System.Drawing.Point(13, 66);
            this.cbxConfirm.Name = "cbxConfirm";
            this.cbxConfirm.Size = new System.Drawing.Size(70, 17);
            this.cbxConfirm.TabIndex = 7;
            this.cbxConfirm.Text = "Onay iste";
            this.cbxConfirm.UseVisualStyleBackColor = true;
            this.cbxConfirm.CheckedChanged += new System.EventHandler(this.cbxConfirm_CheckedChanged);
            // 
            // btStop
            // 
            this.btStop.BackColor = System.Drawing.Color.OrangeRed;
            this.btStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btStop.Location = new System.Drawing.Point(148, 53);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(50, 30);
            this.btStop.TabIndex = 6;
            this.btStop.Text = "Durdur";
            this.btStop.UseVisualStyleBackColor = false;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btStart
            // 
            this.btStart.BackColor = System.Drawing.Color.LimeGreen;
            this.btStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btStart.Location = new System.Drawing.Point(92, 53);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(50, 30);
            this.btStart.TabIndex = 5;
            this.btStart.Text = "Başlat";
            this.btStart.UseVisualStyleBackColor = false;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // txbCurY
            // 
            this.txbCurY.BackColor = System.Drawing.SystemColors.Control;
            this.txbCurY.Location = new System.Drawing.Point(153, 20);
            this.txbCurY.Name = "txbCurY";
            this.txbCurY.Size = new System.Drawing.Size(45, 20);
            this.txbCurY.TabIndex = 3;
            this.txbCurY.Text = "0";
            this.txbCurY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txbCurX
            // 
            this.txbCurX.BackColor = System.Drawing.SystemColors.Control;
            this.txbCurX.Location = new System.Drawing.Point(94, 20);
            this.txbCurX.Name = "txbCurX";
            this.txbCurX.Size = new System.Drawing.Size(45, 20);
            this.txbCurX.TabIndex = 2;
            this.txbCurX.Text = "0";
            this.txbCurX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = ",";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "İşretçi Konumu:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txbNewProgY);
            this.groupBox1.Controls.Add(this.txbNewProgX);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txbNewProgDelay);
            this.groupBox1.Controls.Add(this.btNewRow);
            this.groupBox1.Controls.Add(this.txbNewProgText);
            this.groupBox1.Controls.Add(this.cbNewProgFunction);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(359, 141);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(211, 162);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlem";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = ",";
            // 
            // txbNewProgY
            // 
            this.txbNewProgY.Location = new System.Drawing.Point(152, 19);
            this.txbNewProgY.Name = "txbNewProgY";
            this.txbNewProgY.Size = new System.Drawing.Size(46, 20);
            this.txbNewProgY.TabIndex = 16;
            this.txbNewProgY.Text = "0";
            // 
            // txbNewProgX
            // 
            this.txbNewProgX.Location = new System.Drawing.Point(93, 19);
            this.txbNewProgX.Name = "txbNewProgX";
            this.txbNewProgX.Size = new System.Drawing.Size(46, 20);
            this.txbNewProgX.TabIndex = 15;
            this.txbNewProgX.Text = "0";
            this.txbNewProgX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(145, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "ms";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Gecikme:";
            // 
            // txbNewProgDelay
            // 
            this.txbNewProgDelay.Location = new System.Drawing.Point(93, 98);
            this.txbNewProgDelay.Name = "txbNewProgDelay";
            this.txbNewProgDelay.Size = new System.Drawing.Size(46, 20);
            this.txbNewProgDelay.TabIndex = 11;
            this.txbNewProgDelay.Text = "100";
            this.txbNewProgDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btNewRow
            // 
            this.btNewRow.Location = new System.Drawing.Point(16, 124);
            this.btNewRow.Name = "btNewRow";
            this.btNewRow.Size = new System.Drawing.Size(182, 25);
            this.btNewRow.TabIndex = 9;
            this.btNewRow.Text = "Ekle";
            this.btNewRow.UseVisualStyleBackColor = true;
            this.btNewRow.Click += new System.EventHandler(this.btNewRow_Click);
            // 
            // txbNewProgText
            // 
            this.txbNewProgText.Location = new System.Drawing.Point(93, 72);
            this.txbNewProgText.Name = "txbNewProgText";
            this.txbNewProgText.Size = new System.Drawing.Size(105, 20);
            this.txbNewProgText.TabIndex = 10;
            // 
            // cbNewProgFunction
            // 
            this.cbNewProgFunction.FormattingEnabled = true;
            this.cbNewProgFunction.Location = new System.Drawing.Point(93, 45);
            this.cbNewProgFunction.Name = "cbNewProgFunction";
            this.cbNewProgFunction.Size = new System.Drawing.Size(105, 21);
            this.cbNewProgFunction.TabIndex = 6;
            this.cbNewProgFunction.SelectedIndexChanged += new System.EventHandler(this.cbNewProgFunction_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Yazı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "İşlem:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Koordinat:";
            // 
            // btNewProgDetection
            // 
            this.btNewProgDetection.Location = new System.Drawing.Point(0, 0);
            this.btNewProgDetection.Name = "btNewProgDetection";
            this.btNewProgDetection.Size = new System.Drawing.Size(75, 23);
            this.btNewProgDetection.TabIndex = 5;
            // 
            // tmrSimulate
            // 
            this.tmrSimulate.Tick += new System.EventHandler(this.tmrSimulate_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 316);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbInfoXY);
            this.Controls.Add(this.gbProgram);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btNewProgDetection);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "AutoMKControl";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbProgram.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgram)).EndInit();
            this.gbInfoXY.ResumeLayout(false);
            this.gbInfoXY.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.Timer tmrGeneric;
        private System.Windows.Forms.Timer tmrProgram;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmFile;
        private System.Windows.Forms.ToolStripMenuItem tsmAbout;
        private System.Windows.Forms.GroupBox gbProgram;
        private System.Windows.Forms.GroupBox gbInfoXY;
        private System.Windows.Forms.DataGridView dgvProgram;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbCurY;
        private System.Windows.Forms.TextBox txbCurX;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbNewProgDelay;
        private System.Windows.Forms.TextBox txbNewProgText;
        private System.Windows.Forms.Button btNewRow;
        private System.Windows.Forms.ComboBox cbNewProgFunction;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbNewProgY;
        private System.Windows.Forms.TextBox txbNewProgX;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.CheckBox cbxConfirm;
        private System.Windows.Forms.Button btEditRow;
        private System.Windows.Forms.Button btExport;
        private System.Windows.Forms.Button btImport;
        private System.Windows.Forms.Button btNewProgDetection;
        private System.Windows.Forms.Button btSimulate;
        private System.Windows.Forms.Button btAddRow;
        private System.Windows.Forms.Button btCopyRow;
        private System.Windows.Forms.Button btDeleteRow;
        private System.Windows.Forms.Timer tmrSimulate;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem tsmView;
        private System.Windows.Forms.ToolStripMenuItem tsmAlwaysOnTop;
    }
}

