using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtdelKadrov
{
    public partial class SotrudnikForm : Form
    {
        int Id_sotrudnik;
        Regex regexFIO = new Regex(@"^[А-Я][а-я]{0,15}\s[А-Я][а-я]{0,15}\s[А-Я][а-я]{0,15}$");
        Regex regexNumber = new Regex(@"^\d{6}");
        public SotrudnikForm()
        {
            InitializeComponent();
            using (Context db = new Context())
            {
                ExecQuery(db);
                comboBoxOtdel.DataSource = db.Otdels.ToList();
                comboBoxDolzh.DataSource = db.Dolzhnosts.ToList();
            }
        }
        private bool Correct()
        {
            string fio = txtBoxFIO.Text;
            string number = txtBoxNumber.Text;
            if (!regexFIO.IsMatch(fio) || !regexNumber.IsMatch(number))
            {
                MessageBox.Show("Некорректные ФИО или табельный номер!");
                return false;
            }
            else return true;
        }

        void Clear()
        {
            txtBoxFIO.Clear();
            txtBoxNumber.Clear();
        }
        void reload(Context db)
        {
            try
            {
                db.SaveChanges();
                ExecQuery(db);
                dataGridSotrudnik.ClearSelection();
                Clear();
            }
            catch (DbUpdateException)
            {
                MessageBox.Show("Сотрудник с данным номером уже есть, либо введены не все данные!");
            }
        }

        void ExecQuery(Context db)
        {
            dataGridSotrudnik.DataSource = db.Sotrudniks.Join(db.Otdels, s => s.Id_Otdel, o => o.Id_Otdel,
                (s, o) =>
                new
                {
                    s.Id_Sotrudnik,
                    s.Table_Number,
                    s.FIO,
                    o.Name_Otdel,
                    NameOtdel = o.Name_Otdel,
                    Id_Dolzhnost = s.Id_Dolzhnost
                }
                ).Join(db.Dolzhnosts, so => so.Id_Dolzhnost, d => d.Id_Dolzhnost,
                (so, d) =>
                new
                {
                    so.Id_Sotrudnik,
                    so.Table_Number,
                    so.FIO,
                    NameOtdel = so.Name_Otdel,
                    NameDolzh = d.Name_Dolzh
                }).ToList();
        }
        private void dataGridSotrudnik_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridSotrudnik.SelectedRows[0].Index;
            Id_sotrudnik = (int)dataGridSotrudnik[0, row].Value;

            txtBoxNumber.Text = dataGridSotrudnik[1, row].Value.ToString();
            txtBoxFIO.Text = dataGridSotrudnik[2, row].Value.ToString();
            comboBoxOtdel.Text = dataGridSotrudnik[3, row].Value.ToString();
            comboBoxDolzh.Text = dataGridSotrudnik[4, row].Value.ToString();
        }

        private void SotrudnikForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.f.Show();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (Correct())
            {
                using (Context db = new Context())
                {
                    db.Sotrudniks.Add(new Sotrudnik
                    {
                        Table_Number = txtBoxNumber.Text,
                        FIO = txtBoxFIO.Text,
                        Id_Otdel = (int)comboBoxOtdel.SelectedValue,
                        Id_Dolzhnost = (int)comboBoxDolzh.SelectedValue
                    });
                    reload(db);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridSotrudnik.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строку для удаления!");
            }
            else if (Correct())
            {
                using (Context db = new Context())
                {
                    foreach (DataGridViewRow row in dataGridSotrudnik.SelectedRows)
                    {
                        int Id_sotrudnik = (int)dataGridSotrudnik[0, row.Index].Value;
                        DialogResult answer;
                        Sotrudnik delete_sot = db.Sotrudniks.Where(s => s.Id_Sotrudnik == Id_sotrudnik).FirstOrDefault();
                        answer = MessageBox.Show($"Вы действительно хотите удалить сотрудника {delete_sot.FIO} с табельным номером {delete_sot.Table_Number}?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (answer == (DialogResult)6)
                        {
                            db.Sotrudniks.Remove(delete_sot);
                        }
                    }
                    reload(db);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridSotrudnik.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строку для изменения!");
            }
            else if (Correct())
            {
                using (Context db = new Context())
                {
                    Sotrudnik update_sot = db.Sotrudniks.Where(s => s.Id_Sotrudnik == Id_sotrudnik).FirstOrDefault();
                    update_sot.Table_Number = txtBoxNumber.Text;
                    update_sot.FIO = txtBoxFIO.Text;
                    update_sot.Id_Otdel = (int)comboBoxOtdel.SelectedValue;
                    update_sot.Id_Dolzhnost = (int)comboBoxDolzh.SelectedValue;
                    reload(db);
                }
            }
        }

        private void SotrudnikForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "otdelKadrovDataSet.Dolzhnost". При необходимости она может быть перемещена или удалена.
            this.dolzhnostTableAdapter.Fill(this.otdelKadrovDataSet.Dolzhnost);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "otdelKadrovDataSet.Otdel". При необходимости она может быть перемещена или удалена.
            this.otdelTableAdapter.Fill(this.otdelKadrovDataSet.Otdel);
            dataGridSotrudnik.ClearSelection();
        }
    }
}
