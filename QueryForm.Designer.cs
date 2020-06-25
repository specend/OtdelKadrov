namespace OtdelKadrov
{
    partial class QueryForm
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
            this.dataGridQuery = new System.Windows.Forms.DataGridView();
            this.btnDolzh = new System.Windows.Forms.Button();
            this.btnSotrudniki = new System.Windows.Forms.Button();
            this.btnInfoSotrudnik = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxDolzh = new System.Windows.Forms.ComboBox();
            this.otdelKadrovDataSet = new OtdelKadrov.OtdelKadrovDataSet();
            this.dolzhnostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dolzhnostTableAdapter = new OtdelKadrov.OtdelKadrovDataSetTableAdapters.DolzhnostTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSotrudnik = new System.Windows.Forms.ComboBox();
            this.sotrudnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sotrudnikTableAdapter = new OtdelKadrov.OtdelKadrovDataSetTableAdapters.SotrudnikTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdelKadrovDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dolzhnostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridQuery
            // 
            this.dataGridQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridQuery.Location = new System.Drawing.Point(27, 26);
            this.dataGridQuery.Name = "dataGridQuery";
            this.dataGridQuery.Size = new System.Drawing.Size(587, 374);
            this.dataGridQuery.TabIndex = 0;
            // 
            // btnDolzh
            // 
            this.btnDolzh.Location = new System.Drawing.Point(620, 55);
            this.btnDolzh.Name = "btnDolzh";
            this.btnDolzh.Size = new System.Drawing.Size(196, 23);
            this.btnDolzh.TabIndex = 1;
            this.btnDolzh.Text = "Список должностей < 10000 руб.";
            this.btnDolzh.UseVisualStyleBackColor = true;
            this.btnDolzh.Click += new System.EventHandler(this.btnDolzh_Click);
            // 
            // btnSotrudniki
            // 
            this.btnSotrudniki.Location = new System.Drawing.Point(620, 120);
            this.btnSotrudniki.Name = "btnSotrudniki";
            this.btnSotrudniki.Size = new System.Drawing.Size(196, 23);
            this.btnSotrudniki.TabIndex = 2;
            this.btnSotrudniki.Text = "Список сотрудников по должности";
            this.btnSotrudniki.UseVisualStyleBackColor = true;
            this.btnSotrudniki.Click += new System.EventHandler(this.btnSotrudniki_Click);
            // 
            // btnInfoSotrudnik
            // 
            this.btnInfoSotrudnik.Location = new System.Drawing.Point(620, 183);
            this.btnInfoSotrudnik.Name = "btnInfoSotrudnik";
            this.btnInfoSotrudnik.Size = new System.Drawing.Size(196, 23);
            this.btnInfoSotrudnik.TabIndex = 3;
            this.btnInfoSotrudnik.Text = "Информация о сотруднике";
            this.btnInfoSotrudnik.UseVisualStyleBackColor = true;
            this.btnInfoSotrudnik.Click += new System.EventHandler(this.btnInfoSotrudnik_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(617, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Должность";
            // 
            // comboBoxDolzh
            // 
            this.comboBoxDolzh.DataSource = this.dolzhnostBindingSource;
            this.comboBoxDolzh.DisplayMember = "Name_Dolzh";
            this.comboBoxDolzh.FormattingEnabled = true;
            this.comboBoxDolzh.Location = new System.Drawing.Point(620, 244);
            this.comboBoxDolzh.Name = "comboBoxDolzh";
            this.comboBoxDolzh.Size = new System.Drawing.Size(181, 21);
            this.comboBoxDolzh.TabIndex = 28;
            this.comboBoxDolzh.ValueMember = "Id_Dolzhnost";
            // 
            // otdelKadrovDataSet
            // 
            this.otdelKadrovDataSet.DataSetName = "OtdelKadrovDataSet";
            this.otdelKadrovDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(617, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Сотрудник";
            // 
            // comboBoxSotrudnik
            // 
            this.comboBoxSotrudnik.DataSource = this.sotrudnikBindingSource;
            this.comboBoxSotrudnik.DisplayMember = "FIO";
            this.comboBoxSotrudnik.FormattingEnabled = true;
            this.comboBoxSotrudnik.Location = new System.Drawing.Point(620, 311);
            this.comboBoxSotrudnik.Name = "comboBoxSotrudnik";
            this.comboBoxSotrudnik.Size = new System.Drawing.Size(181, 21);
            this.comboBoxSotrudnik.TabIndex = 30;
            this.comboBoxSotrudnik.ValueMember = "Id_Sotrudnik";
            // 
            // sotrudnikBindingSource
            // 
            this.sotrudnikBindingSource.DataMember = "Sotrudnik";
            this.sotrudnikBindingSource.DataSource = this.otdelKadrovDataSet;
            // 
            // sotrudnikTableAdapter
            // 
            this.sotrudnikTableAdapter.ClearBeforeFill = true;
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxSotrudnik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxDolzh);
            this.Controls.Add(this.btnInfoSotrudnik);
            this.Controls.Add(this.btnSotrudniki);
            this.Controls.Add(this.btnDolzh);
            this.Controls.Add(this.dataGridQuery);
            this.Name = "QueryForm";
            this.Text = "Запросы";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.QueryForm_FormClosed);
            this.Load += new System.EventHandler(this.QueryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdelKadrovDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dolzhnostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridQuery;
        private System.Windows.Forms.Button btnDolzh;
        private System.Windows.Forms.Button btnSotrudniki;
        private System.Windows.Forms.Button btnInfoSotrudnik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxDolzh;
        private OtdelKadrovDataSet otdelKadrovDataSet;
        private System.Windows.Forms.BindingSource dolzhnostBindingSource;
        private OtdelKadrovDataSetTableAdapters.DolzhnostTableAdapter dolzhnostTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSotrudnik;
        private System.Windows.Forms.BindingSource sotrudnikBindingSource;
        private OtdelKadrovDataSetTableAdapters.SotrudnikTableAdapter sotrudnikTableAdapter;
    }
}