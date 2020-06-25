namespace OtdelKadrov
{
    partial class DolzhnostForm
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
            this.dataGridDolzh = new System.Windows.Forms.DataGridView();
            this.idDolzhnostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDolzhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.okladDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dolzhnostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otdelKadrovDataSet = new OtdelKadrov.OtdelKadrovDataSet();
            this.numericUpDownOklad = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dolzhnostTableAdapter = new OtdelKadrov.OtdelKadrovDataSetTableAdapters.DolzhnostTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDolzh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dolzhnostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdelKadrovDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOklad)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridDolzh
            // 
            this.dataGridDolzh.AutoGenerateColumns = false;
            this.dataGridDolzh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDolzh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDolzhnostDataGridViewTextBoxColumn,
            this.nameDolzhDataGridViewTextBoxColumn,
            this.okladDataGridViewTextBoxColumn});
            this.dataGridDolzh.DataSource = this.dolzhnostBindingSource;
            this.dataGridDolzh.Location = new System.Drawing.Point(21, 26);
            this.dataGridDolzh.Name = "dataGridDolzh";
            this.dataGridDolzh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridDolzh.Size = new System.Drawing.Size(430, 310);
            this.dataGridDolzh.TabIndex = 0;
            this.dataGridDolzh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDolzh_CellClick);
            // 
            // idDolzhnostDataGridViewTextBoxColumn
            // 
            this.idDolzhnostDataGridViewTextBoxColumn.DataPropertyName = "Id_Dolzhnost";
            this.idDolzhnostDataGridViewTextBoxColumn.HeaderText = "Id_Dolzhnost";
            this.idDolzhnostDataGridViewTextBoxColumn.Name = "idDolzhnostDataGridViewTextBoxColumn";
            this.idDolzhnostDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDolzhnostDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDolzhDataGridViewTextBoxColumn
            // 
            this.nameDolzhDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDolzhDataGridViewTextBoxColumn.DataPropertyName = "Name_Dolzh";
            this.nameDolzhDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameDolzhDataGridViewTextBoxColumn.Name = "nameDolzhDataGridViewTextBoxColumn";
            // 
            // okladDataGridViewTextBoxColumn
            // 
            this.okladDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.okladDataGridViewTextBoxColumn.DataPropertyName = "Oklad";
            this.okladDataGridViewTextBoxColumn.HeaderText = "Оклад";
            this.okladDataGridViewTextBoxColumn.Name = "okladDataGridViewTextBoxColumn";
            // 
            // dolzhnostBindingSource
            // 
            this.dolzhnostBindingSource.DataMember = "Dolzhnost";
            this.dolzhnostBindingSource.DataSource = this.otdelKadrovDataSet;
            // 
            // otdelKadrovDataSet
            // 
            this.otdelKadrovDataSet.DataSetName = "OtdelKadrovDataSet";
            this.otdelKadrovDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // numericUpDownOklad
            // 
            this.numericUpDownOklad.Location = new System.Drawing.Point(274, 355);
            this.numericUpDownOklad.Maximum = new decimal(new int[] {
            150000,
            0,
            0,
            0});
            this.numericUpDownOklad.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDownOklad.Name = "numericUpDownOklad";
            this.numericUpDownOklad.Size = new System.Drawing.Size(177, 20);
            this.numericUpDownOklad.TabIndex = 2;
            this.numericUpDownOklad.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Оклад";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(21, 355);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(208, 20);
            this.textBoxName.TabIndex = 5;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(21, 406);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(151, 23);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "Добавить";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(178, 406);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(132, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(316, 406);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(135, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dolzhnostTableAdapter
            // 
            this.dolzhnostTableAdapter.ClearBeforeFill = true;
            // 
            // DolzhnostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownOklad);
            this.Controls.Add(this.dataGridDolzh);
            this.Name = "DolzhnostForm";
            this.Text = "Должности";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DolzhnostForm_FormClosed);
            this.Load += new System.EventHandler(this.DolzhnostForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDolzh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dolzhnostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdelKadrovDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOklad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridDolzh;
        private System.Windows.Forms.NumericUpDown numericUpDownOklad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private OtdelKadrovDataSet otdelKadrovDataSet;
        private System.Windows.Forms.BindingSource dolzhnostBindingSource;
        private OtdelKadrovDataSetTableAdapters.DolzhnostTableAdapter dolzhnostTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDolzhnostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDolzhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn okladDataGridViewTextBoxColumn;
    }
}