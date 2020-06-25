namespace OtdelKadrov
{
    partial class OtdelForm
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
            this.dataGridOtdel = new System.Windows.Forms.DataGridView();
            this.idOtdelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameOtdelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cabNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIOChiefDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otdelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otdelKadrovDataSet = new OtdelKadrov.OtdelKadrovDataSet();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxPhone = new System.Windows.Forms.TextBox();
            this.txtBoxCabinet = new System.Windows.Forms.TextBox();
            this.txtBoxFIO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.otdelTableAdapter = new OtdelKadrov.OtdelKadrovDataSetTableAdapters.OtdelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOtdel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdelKadrovDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridOtdel
            // 
            this.dataGridOtdel.AutoGenerateColumns = false;
            this.dataGridOtdel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOtdel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOtdelDataGridViewTextBoxColumn,
            this.nameOtdelDataGridViewTextBoxColumn,
            this.cabNumberDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.fIOChiefDataGridViewTextBoxColumn});
            this.dataGridOtdel.DataSource = this.otdelBindingSource;
            this.dataGridOtdel.Location = new System.Drawing.Point(12, 21);
            this.dataGridOtdel.Name = "dataGridOtdel";
            this.dataGridOtdel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridOtdel.Size = new System.Drawing.Size(721, 309);
            this.dataGridOtdel.TabIndex = 0;
            this.dataGridOtdel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridOtdel_CellClick);
            // 
            // idOtdelDataGridViewTextBoxColumn
            // 
            this.idOtdelDataGridViewTextBoxColumn.DataPropertyName = "Id_Otdel";
            this.idOtdelDataGridViewTextBoxColumn.HeaderText = "Id_Otdel";
            this.idOtdelDataGridViewTextBoxColumn.Name = "idOtdelDataGridViewTextBoxColumn";
            this.idOtdelDataGridViewTextBoxColumn.ReadOnly = true;
            this.idOtdelDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameOtdelDataGridViewTextBoxColumn
            // 
            this.nameOtdelDataGridViewTextBoxColumn.DataPropertyName = "Name_Otdel";
            this.nameOtdelDataGridViewTextBoxColumn.FillWeight = 63.43627F;
            this.nameOtdelDataGridViewTextBoxColumn.HeaderText = "Название отдела";
            this.nameOtdelDataGridViewTextBoxColumn.Name = "nameOtdelDataGridViewTextBoxColumn";
            this.nameOtdelDataGridViewTextBoxColumn.Width = 120;
            // 
            // cabNumberDataGridViewTextBoxColumn
            // 
            this.cabNumberDataGridViewTextBoxColumn.DataPropertyName = "Cab_Number";
            this.cabNumberDataGridViewTextBoxColumn.FillWeight = 43.74453F;
            this.cabNumberDataGridViewTextBoxColumn.HeaderText = "Кабинет";
            this.cabNumberDataGridViewTextBoxColumn.Name = "cabNumberDataGridViewTextBoxColumn";
            this.cabNumberDataGridViewTextBoxColumn.Width = 64;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 120;
            // 
            // fIOChiefDataGridViewTextBoxColumn
            // 
            this.fIOChiefDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fIOChiefDataGridViewTextBoxColumn.DataPropertyName = "FIO_Chief";
            this.fIOChiefDataGridViewTextBoxColumn.FillWeight = 255F;
            this.fIOChiefDataGridViewTextBoxColumn.HeaderText = "Начальник";
            this.fIOChiefDataGridViewTextBoxColumn.Name = "fIOChiefDataGridViewTextBoxColumn";
            // 
            // otdelBindingSource
            // 
            this.otdelBindingSource.DataMember = "Otdel";
            this.otdelBindingSource.DataSource = this.otdelKadrovDataSet;
            // 
            // otdelKadrovDataSet
            // 
            this.otdelKadrovDataSet.DataSetName = "OtdelKadrovDataSet";
            this.otdelKadrovDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(445, 415);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(135, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(307, 415);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(132, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(150, 415);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(151, 23);
            this.btnInsert.TabIndex = 9;
            this.btnInsert.Text = "Добавить";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(12, 365);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(166, 20);
            this.txtBoxName.TabIndex = 12;
            // 
            // txtBoxPhone
            // 
            this.txtBoxPhone.Location = new System.Drawing.Point(267, 365);
            this.txtBoxPhone.Name = "txtBoxPhone";
            this.txtBoxPhone.Size = new System.Drawing.Size(153, 20);
            this.txtBoxPhone.TabIndex = 13;
            // 
            // txtBoxCabinet
            // 
            this.txtBoxCabinet.Location = new System.Drawing.Point(184, 365);
            this.txtBoxCabinet.Name = "txtBoxCabinet";
            this.txtBoxCabinet.Size = new System.Drawing.Size(77, 20);
            this.txtBoxCabinet.TabIndex = 14;
            // 
            // txtBoxFIO
            // 
            this.txtBoxFIO.Location = new System.Drawing.Point(426, 365);
            this.txtBoxFIO.Name = "txtBoxFIO";
            this.txtBoxFIO.Size = new System.Drawing.Size(307, 20);
            this.txtBoxFIO.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Название отдела";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Кабинет";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Телефон";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "ФИО Начальника";
            // 
            // otdelTableAdapter
            // 
            this.otdelTableAdapter.ClearBeforeFill = true;
            // 
            // OtdelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxFIO);
            this.Controls.Add(this.txtBoxCabinet);
            this.Controls.Add(this.txtBoxPhone);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dataGridOtdel);
            this.Name = "OtdelForm";
            this.Text = "Отделы";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OtdelForm_FormClosed);
            this.Load += new System.EventHandler(this.OtdelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOtdel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdelKadrovDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridOtdel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxPhone;
        private System.Windows.Forms.TextBox txtBoxCabinet;
        private System.Windows.Forms.TextBox txtBoxFIO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private OtdelKadrovDataSet otdelKadrovDataSet;
        private System.Windows.Forms.BindingSource otdelBindingSource;
        private OtdelKadrovDataSetTableAdapters.OtdelTableAdapter otdelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOtdelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameOtdelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cabNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIOChiefDataGridViewTextBoxColumn;
    }
}
