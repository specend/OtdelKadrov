namespace OtdelKadrov
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSotrudnik = new System.Windows.Forms.Button();
            this.btnOtdel = new System.Windows.Forms.Button();
            this.btnDolzh = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSotrudnik
            // 
            this.btnSotrudnik.Location = new System.Drawing.Point(29, 30);
            this.btnSotrudnik.Name = "btnSotrudnik";
            this.btnSotrudnik.Size = new System.Drawing.Size(146, 23);
            this.btnSotrudnik.TabIndex = 0;
            this.btnSotrudnik.Text = "Сотрудники";
            this.btnSotrudnik.UseVisualStyleBackColor = true;
            this.btnSotrudnik.Click += new System.EventHandler(this.btnSotrudnik_Click);
            // 
            // btnOtdel
            // 
            this.btnOtdel.Location = new System.Drawing.Point(191, 30);
            this.btnOtdel.Name = "btnOtdel";
            this.btnOtdel.Size = new System.Drawing.Size(157, 23);
            this.btnOtdel.TabIndex = 1;
            this.btnOtdel.Text = "Отделы";
            this.btnOtdel.UseVisualStyleBackColor = true;
            this.btnOtdel.Click += new System.EventHandler(this.btnOtdel_Click);
            // 
            // btnDolzh
            // 
            this.btnDolzh.Location = new System.Drawing.Point(29, 104);
            this.btnDolzh.Name = "btnDolzh";
            this.btnDolzh.Size = new System.Drawing.Size(146, 23);
            this.btnDolzh.TabIndex = 2;
            this.btnDolzh.Text = "Должности";
            this.btnDolzh.UseVisualStyleBackColor = true;
            this.btnDolzh.Click += new System.EventHandler(this.btnDolzh_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(191, 104);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(157, 23);
            this.btnQuery.TabIndex = 3;
            this.btnQuery.Text = "Запросы";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 164);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.btnDolzh);
            this.Controls.Add(this.btnOtdel);
            this.Controls.Add(this.btnSotrudnik);
            this.Name = "MainForm";
            this.Text = "Главное меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSotrudnik;
        private System.Windows.Forms.Button btnOtdel;
        private System.Windows.Forms.Button btnDolzh;
        private System.Windows.Forms.Button btnQuery;
    }
}

