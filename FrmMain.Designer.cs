namespace WFADB_osszefoglalas
{
    partial class FrmMain
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb = new System.Windows.Forms.CheckBox();
            this.dtpSzul = new System.Windows.Forms.DateTimePicker();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.rbFF = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbNO = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpSzulMOD = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.rbNoMOD = new System.Windows.Forms.RadioButton();
            this.rbFfMOD = new System.Windows.Forms.RadioButton();
            this.tbNevMOD = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv.Location = new System.Drawing.Point(12, 12);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 29;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(773, 271);
            this.dgv.TabIndex = 0;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CellClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 1F;
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.FillWeight = 5F;
            this.Column2.HeaderText = "Név";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.FillWeight = 3F;
            this.Column3.HeaderText = "Nem";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.FillWeight = 5F;
            this.Column4.HeaderText = "Született";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // cb
            // 
            this.cb.AutoSize = true;
            this.cb.Location = new System.Drawing.Point(65, 336);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(124, 24);
            this.cb.TabIndex = 1;
            this.cb.Text = "csak nagykorú";
            this.cb.UseVisualStyleBackColor = true;
            this.cb.CheckedChanged += new System.EventHandler(this.Cb_CheckedChanged);
            // 
            // dtpSzul
            // 
            this.dtpSzul.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSzul.Location = new System.Drawing.Point(77, 93);
            this.dtpSzul.Name = "dtpSzul";
            this.dtpSzul.Size = new System.Drawing.Size(167, 27);
            this.dtpSzul.TabIndex = 2;
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(77, 27);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(167, 27);
            this.tbNev.TabIndex = 3;
            // 
            // rbFF
            // 
            this.rbFF.AutoSize = true;
            this.rbFF.Location = new System.Drawing.Point(165, 62);
            this.rbFF.Name = "rbFF";
            this.rbFF.Size = new System.Drawing.Size(57, 24);
            this.rbFF.TabIndex = 4;
            this.rbFF.TabStop = true;
            this.rbFF.Text = "férfi";
            this.rbFF.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpSzul);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rbNO);
            this.groupBox1.Controls.Add(this.rbFF);
            this.groupBox1.Controls.Add(this.tbNev);
            this.groupBox1.Location = new System.Drawing.Point(518, 306);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 175);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Új ember hozzáadása:";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(16, 137);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(228, 32);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "HOZZÁAD";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "szül:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "nem:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "név:";
            // 
            // rbNO
            // 
            this.rbNO.AutoSize = true;
            this.rbNO.Checked = true;
            this.rbNO.Location = new System.Drawing.Point(94, 62);
            this.rbNO.Name = "rbNO";
            this.rbNO.Size = new System.Drawing.Size(47, 24);
            this.rbNO.TabIndex = 4;
            this.rbNO.TabStop = true;
            this.rbNO.Text = "nő";
            this.rbNO.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dtpSzulMOD);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.rbNoMOD);
            this.groupBox2.Controls.Add(this.rbFfMOD);
            this.groupBox2.Controls.Add(this.tbNevMOD);
            this.groupBox2.Location = new System.Drawing.Point(245, 306);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 175);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "módosítás:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(16, 137);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(228, 32);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "MÓDOSÍTÁS";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "szül:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "nem:";
            // 
            // dtpSzulMOD
            // 
            this.dtpSzulMOD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSzulMOD.Location = new System.Drawing.Point(77, 93);
            this.dtpSzulMOD.Name = "dtpSzulMOD";
            this.dtpSzulMOD.Size = new System.Drawing.Size(167, 27);
            this.dtpSzulMOD.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "név:";
            // 
            // rbNoMOD
            // 
            this.rbNoMOD.AutoSize = true;
            this.rbNoMOD.Checked = true;
            this.rbNoMOD.Location = new System.Drawing.Point(94, 62);
            this.rbNoMOD.Name = "rbNoMOD";
            this.rbNoMOD.Size = new System.Drawing.Size(47, 24);
            this.rbNoMOD.TabIndex = 4;
            this.rbNoMOD.TabStop = true;
            this.rbNoMOD.Text = "nő";
            this.rbNoMOD.UseVisualStyleBackColor = true;
            // 
            // rbFfMOD
            // 
            this.rbFfMOD.AutoSize = true;
            this.rbFfMOD.Location = new System.Drawing.Point(165, 62);
            this.rbFfMOD.Name = "rbFfMOD";
            this.rbFfMOD.Size = new System.Drawing.Size(57, 24);
            this.rbFfMOD.TabIndex = 4;
            this.rbFfMOD.TabStop = true;
            this.rbFfMOD.Text = "férfi";
            this.rbFfMOD.UseVisualStyleBackColor = true;
            // 
            // tbNevMOD
            // 
            this.tbNevMOD.Location = new System.Drawing.Point(77, 27);
            this.tbNevMOD.Name = "tbNevMOD";
            this.tbNevMOD.Size = new System.Drawing.Size(167, 27);
            this.tbNevMOD.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightCoral;
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Location = new System.Drawing.Point(24, 404);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(215, 77);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "törlés:";
            // 
            // button1
            // 
            this.btnDelete.Location = new System.Drawing.Point(6, 26);
            this.btnDelete.Name = "button1";
            this.btnDelete.Size = new System.Drawing.Size(203, 32);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "KIJELÖLT RECORD TÖRLÉSE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 509);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cb);
            this.Controls.Add(this.dgv);
            this.Name = "FrmMain";
            this.Text = "ÖSSZEFOGLALAS";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private CheckBox cb;
        private DateTimePicker dtpSzul;
        private TextBox tbNev;
        private RadioButton rbFF;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private RadioButton rbNO;
        private Button btnInsert;
        private GroupBox groupBox2;
        private Button btnUpdate;
        private Label label4;
        private Label label5;
        private DateTimePicker dtpSzulMOD;
        private Label label6;
        private RadioButton rbNoMOD;
        private RadioButton rbFfMOD;
        private TextBox tbNevMOD;
        private GroupBox groupBox3;
        private Button btnDelete;
    }
}