using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtdelKadrov
{
    public partial class DolzhnostForm : Form
    {
        public DolzhnostForm()
        {
            InitializeComponent();
            using (Context db = new Context())
            {
                dataGridDolzh.DataSource = db.Dolzhnosts.ToList();
            }
        }

        private void DolzhnostForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "otdelKadrovDataSet.Dolzhnost". При необходимости она может быть перемещена или удалена.
            this.dolzhnostTableAdapter.Fill(this.otdelKadrovDataSet.Dolzhnost);
            dataGridDolzh.ClearSelection();
        }
        private void reload(Context db)
        {
            try
            {
                db.SaveChanges();
                dataGridDolzh.DataSource = db.Dolzhnosts.ToList();
                dataGridDolzh.ClearSelection();
                Clear();
            }
            catch (DbUpdateException)
            {
                MessageBox.Show("Такая должность уже есть, либо введены не все данные!");
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            using (Context db = new Context())
            {
                db.Dolzhnosts.Add(new Dolzhnost
                {
                    Name_Dolzh = textBoxName.Text,
                    Oklad = (int)numericUpDownOklad.Value,
                });
                reload(db);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridDolzh.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строку для удаления!");
            }
            else
            {
                using (Context db = new Context())
                {
                    foreach (DataGridViewRow row in dataGridDolzh.SelectedRows)
                    {
                        DialogResult answer;
                        int id = (int)dataGridDolzh[0, row.Index].Value;
                        Dolzhnost delete_d = db.Dolzhnosts.Where(d => d.Id_Dolzhnost == id).FirstOrDefault();
                        answer = MessageBox.Show($"Вы действительно хотите удалить должность {delete_d.Name_Dolzh}?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (answer == (DialogResult)6)
                        {
                            db.Dolzhnosts.Remove(delete_d);
                        }
                    }
                    reload(db);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridDolzh.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строку для изменения!");
            }
            else
            {
                int id = (int)dataGridDolzh[0, dataGridDolzh.SelectedRows[0].Index].Value;
                using (Context db = new Context())
                {
                    Dolzhnost update_d = db.Dolzhnosts.Where(d => d.Id_Dolzhnost == id).FirstOrDefault();
                    update_d.Name_Dolzh = textBoxName.Text;
                    update_d.Oklad = (int)numericUpDownOklad.Value;
                    reload(db);
                }
            }
        }

        private void DolzhnostForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.f.Show();
        }

        private void dataGridDolzh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridDolzh.SelectedRows[0].Index;

            textBoxName.Text = dataGridDolzh[1, row].Value.ToString();
            numericUpDownOklad.Value = (int)dataGridDolzh[2, row].Value;
        }

        private void Clear()
        {
            textBoxName.Clear();
            numericUpDownOklad.Value = 5000;
        }
    }
}
