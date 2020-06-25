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
    public partial class OtdelForm : Form
    {
        Regex regexFIO = new Regex(@"^[А-Я][а-я]{0,15}\s[А-Я][а-я]{0,15}\s[А-Я][а-я]{0,15}$");
        Regex regexPhone = new Regex(@"^[+79]\d{9}");
        public OtdelForm()
        {
            InitializeComponent();
            using (Context db = new Context())
            {
                dataGridOtdel.DataSource = db.Otdels.ToList();
            }
        }
        private void Clear()
        {
            txtBoxName.Clear();
            txtBoxCabinet.Clear();
            txtBoxPhone.Clear();
            txtBoxFIO.Clear();
        }
        private void reload(Context db)
        {
            try
            {
                db.SaveChanges();
                dataGridOtdel.DataSource = db.Otdels.ToList();
                dataGridOtdel.ClearSelection();
                Clear();
            }
            catch (DbUpdateException)
            {
                MessageBox.Show("Отдел с такими данными уже есть, либо введены некорректные данные!");
            }
        }

        private bool Correct()
        {
            string fio = txtBoxFIO.Text;
            string phone = txtBoxPhone.Text;
            if (!regexFIO.IsMatch(fio) || !regexPhone.IsMatch(phone))
            {
                MessageBox.Show("Некорректные ФИО или телефон!");
                return false;
            }
            else return true;
        }
        private void OtdelForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "otdelKadrovDataSet.Otdel". При необходимости она может быть перемещена или удалена.
            this.otdelTableAdapter.Fill(this.otdelKadrovDataSet.Otdel);
            dataGridOtdel.ClearSelection();
        }

        private void dataGridOtdel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridOtdel.SelectedRows[0].Index;

            txtBoxName.Text = dataGridOtdel[1, row].Value.ToString();
            txtBoxCabinet.Text = dataGridOtdel[2, row].Value.ToString();
            txtBoxPhone.Text = dataGridOtdel[3, row].Value.ToString();
            txtBoxFIO.Text = dataGridOtdel[4, row].Value.ToString();
        }

        private void OtdelForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.f.Show();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (Correct())
            {
                using (Context db = new Context())
                {
                    db.Otdels.Add(new Otdel
                    {
                        Name_Otdel = txtBoxName.Text,
                        Cab_Number = int.Parse(txtBoxCabinet.Text),
                        Phone = txtBoxPhone.Text,
                        FIO_Chief = txtBoxFIO.Text
                    });
                    reload(db);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridOtdel.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строку для удаления!");
            }
            else if (Correct())
            {
                using (Context db = new Context())
                {
                    foreach (DataGridViewRow row in dataGridOtdel.SelectedRows)
                    {
                        DialogResult answer;
                        int id = (int)dataGridOtdel[0, row.Index].Value;

                        Otdel delete_otdel = db.Otdels.Where(o => o.Id_Otdel == id).FirstOrDefault();
                        answer = MessageBox.Show($"Вы действительно хотите удалить отдел {delete_otdel.Name_Otdel}?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (answer == (DialogResult)6)
                        {
                            db.Otdels.Remove(delete_otdel);
                        }
                    }
                    reload(db);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridOtdel.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строку для изменения!");
            }
            else if (Correct())
            {  
                    int id = (int)dataGridOtdel[0, dataGridOtdel.SelectedRows[0].Index].Value;

                    using (Context db = new Context())
                    {
                        Otdel update_otdel = db.Otdels.Where(o => o.Id_Otdel == id).FirstOrDefault();
                        update_otdel.Name_Otdel = txtBoxName.Text;
                        update_otdel.Cab_Number = int.Parse(txtBoxCabinet.Text);
                        update_otdel.Phone = txtBoxPhone.Text;
                        update_otdel.FIO_Chief = txtBoxFIO.Text;
                        reload(db);
                    }
            }
        }
    }
}
