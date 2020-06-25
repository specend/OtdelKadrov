namespace OtdelKadrov
{
    partial class SotrudnikForm
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
            this.dataGridSotrudnik = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxFIO = new System.Windows.Forms.TextBox();
            this.txtBoxNumber = new System.Windows.Forms.TextBox();
            this.comboBoxOtdel = new System.Windows.Forms.ComboBox();
            this.comboBoxDolzh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.otdelKadrovDataSet = new OtdelKadrov.OtdelKadrovDataSet();
            this.otdelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otdelTableAdapter = new OtdelKadrov.OtdelKadrovDataSetTableAdapters.OtdelTableAdapter();
            this.dolzhnostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dolzhnostTableAdapter = new OtdelKadrov.OtdelKadrovDataSetTableAdapters.DolzhnostTableAdapter();
            this.Id_Sotrudnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Table_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameOtdel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameDolzh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSotrudnik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdelKadrovDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dolzhnostBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridSotrudnik
            // 
            this.dataGridSotrudnik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSotrudnik.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Sotrudnik,
            this.Table_Number,
            this.FIO,
            this.NameOtdel,
            this.NameDolzh});
            this.dataGridSotrudnik.Location = new System.Drawing.Point(12, 26);
            this.dataGridSotrudnik.Name = "dataGridSotrudnik";
            this.dataGridSotrudnik.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSotrudnik.Size = new System.Drawing.Size(776, 335);
            this.dataGridSotrudnik.TabIndex = 0;
            this.dataGridSotrudnik.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSotrudnik_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "ФИО";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Табельный номер";
            // 
            // txtBoxFIO
            // 
            this.txtBoxFIO.Location = new System.Drawing.Point(114, 381);
            this.txtBoxFIO.Name = "txtBoxFIO";
            this.txtBoxFIO.Size = new System.Drawing.Size(307, 20);
            this.txtBoxFIO.TabIndex = 21;
            // 
            // txtBoxNumber
            // 
            this.txtBoxNumber.Location = new System.Drawing.Point(12, 381);
            this.txtBoxNumber.Name = "txtBoxNumber";
            this.txtBoxNumber.Size = new System.Drawing.Size(96, 20);
            this.txtBoxNumber.TabIndex = 20;
            // 
            // comboBoxOtdel
            // 
            this.comboBoxOtdel.DataSource = this.otdelBindingSource;
            this.comboBoxOtdel.DisplayMember = "Name_Otdel";
            this.comboBoxOtdel.FormattingEnabled = true;
            this.comboBoxOtdel.Location = new System.Drawing.Point(427, 380);
            this.comboBoxOtdel.Name = "comboBoxOtdel";
            this.comboBoxOtdel.Size = new System.Drawing.Size(174, 21);
            this.comboBoxOtdel.TabIndex = 24;
            this.comboBoxOtdel.ValueMember = "Id_Otdel";
            // 
            // comboBoxDolzh
            // 
            this.comboBoxDolzh.DataSource = this.dolzhnostBindingSource;
            this.comboBoxDolzh.DisplayMember = "Name_Dolzh";
            this.comboBoxDolzh.FormattingEnabled = true;
            this.comboBoxDolzh.Location = new System.Drawing.Point(607, 380);
            this.comboBoxDolzh.Name = "comboBoxDolzh";
            this.comboBoxDolzh.Size = new System.Drawing.Size(181, 21);
            this.comboBoxDolzh.TabIndex = 25;
            this.comboBoxDolzh.ValueMember = "Id_Dolzhnost";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(604, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Должность";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Отдел";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(483, 415);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(135, 23);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(345, 415);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(132, 23);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(188, 415);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(151, 23);
            this.btnInsert.TabIndex = 28;
            this.btnInsert.Text = "Добавить";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // otdelKadrovDataSet
            // 
            this.otdelKadrovDataSet.DataSetName = "OtdelKadrovDataSet";
            this.otdelKadrovDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // otdelBindingSource
            // 
            this.otdelBindingSource.DataMember = "Otdel";
            this.otdelBindingSource.DataSource = this.otdelKadrovDataSet;
            // 
            // otdelTableAdapter
            // 
            this.otdelTableAdapter.ClearBeforeFill = true;
            // 
            // dolzhnostBindingSource
            // 
            this.dolzhnostBindingSource.DataMember = "Dolzhnost";
            this.dolzhnostBindingSource.DataSource = this.otdelKadrovDataSet;
            // 
            // dolzhnostTableAdapter
            // 
            this.dolzhnostTableAdapter.ClearBeforeFill = true;
            // 
            // Id_Sotrudnik
            // 
            this.Id_Sotrudnik.DataPropertyName = "Id_Sotrudnik";
            this.Id_Sotrudnik.Frozen = true;
            this.Id_Sotrudnik.HeaderText = "Id_Sotrudnik";
            this.Id_Sotrudnik.Name = "Id_Sotrudnik";
            this.Id_Sotrudnik.ReadOnly = true;
            this.Id_Sotrudnik.Visible = false;
            // 
            // Table_Number
            // 
            this.Table_Number.DataPropertyName = "Table_Number";
            this.Table_Number.Frozen = true;
            this.Table_Number.HeaderText = "Номер";
            this.Table_Number.Name = "Table_Number";
            this.Table_Number.ReadOnly = true;
            // 
            // FIO
            // 
            this.FIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FIO.DataPropertyName = "FIO";
            this.FIO.HeaderText = "ФИО Сотрудника";
            this.FIO.Name = "FIO";
            this.FIO.ReadOnly = true;
            // 
            // NameOtdel
            // 
            this.NameOtdel.DataPropertyName = "NameOtdel";
            this.NameOtdel.HeaderText = "Отдел";
            this.NameOtdel.Name = "NameOtdel";
            this.NameOtdel.ReadOnly = true;
            this.NameOtdel.Width = 211;
            // 
            // NameDolzh
            // 
            this.NameDolzh.DataPropertyName = "NameDolzh";
            this.NameDolzh.HeaderText = "Должность";
            this.NameDolzh.Name = "NameDolzh";
            this.NameDolzh.ReadOnly = true;
            this.NameDolzh.Width = 211;
            // 
            // SotrudnikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxDolzh);
            this.Controls.Add(this.comboBoxOtdel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxFIO);
            this.Controls.Add(this.txtBoxNumber);
            this.Controls.Add(this.dataGridSotrudnik);
            this.Name = "SotrudnikForm";
            this.Text = "Сотрудники";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SotrudnikForm_FormClosed);
            this.Load += new System.EventHandler(this.SotrudnikForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSotrudnik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdelKadrovDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dolzhnostBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridSotrudnik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxFIO;
        private System.Windows.Forms.TextBox txtBoxNumber;
        private System.Windows.Forms.ComboBox comboBoxOtdel;
        private System.Windows.Forms.ComboBox comboBoxDolzh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private OtdelKadrovDataSet otdelKadrovDataSet;
        private System.Windows.Forms.BindingSource otdelBindingSource;
        private OtdelKadrovDataSetTableAdapters.OtdelTableAdapter otdelTableAdapter;
        private System.Windows.Forms.BindingSource dolzhnostBindingSource;
        private OtdelKadrovDataSetTableAdapters.DolzhnostTableAdapter dolzhnostTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Sotrudnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Table_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOtdel;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameDolzh;
    }
}
