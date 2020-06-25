using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtdelKadrov
{
    public partial class QueryForm : Form
    {
        public QueryForm()
        {
            InitializeComponent();
            using (Context db = new Context())
            {
                comboBoxSotrudnik.DataSource = db.Sotrudniks.ToList();
                comboBoxDolzh.DataSource = db.Dolzhnosts.ToList();
            }
        }

        private void QueryForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "otdelKadrovDataSet.Sotrudnik". При необходимости она может быть перемещена или удалена.
            this.sotrudnikTableAdapter.Fill(this.otdelKadrovDataSet.Sotrudnik);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "otdelKadrovDataSet.Dolzhnost". При необходимости она может быть перемещена или удалена.
            this.dolzhnostTableAdapter.Fill(this.otdelKadrovDataSet.Dolzhnost);

        }

        private void btnDolzh_Click(object sender, EventArgs e)
        {
            //Вывести список должностей с окладом менее 10000 руб.с указанием размера оклада;
            using (Context db = new Context())
            {
                var dolzhnosti = from d in db.Dolzhnosts
                                 where d.Oklad < 10000
                                 select new
                                 {
                                     Должность = d.Name_Dolzh,
                                     Оклад = d.Oklad
                                 };
                dataGridQuery.DataSource = dolzhnosti.ToList();
            }
        }

        private void btnSotrudniki_Click(object sender, EventArgs e)
        {
            //Отобразить список сотрудников (табельный номер, ФИО, отдел), занимающих определенную должность;
            int id = (int)comboBoxDolzh.SelectedValue;
            using (Context db = new Context())
            {
                var listSotrudniki = from s in db.Sotrudniks
                                     join o in db.Otdels on s.Id_Otdel equals o.Id_Otdel
                                     join d in db.Dolzhnosts on s.Id_Dolzhnost equals d.Id_Dolzhnost
                                     where s.Id_Dolzhnost == id
                                     select new
                                     {
                                         Табельный_номер = s.Table_Number,
                                         ФИО_Сотрудника = s.FIO,
                                         Отдел = o.Name_Otdel
                                     };
                dataGridQuery.DataSource = listSotrudniki.ToList();
            }
        }

        private void btnInfoSotrudnik_Click(object sender, EventArgs e)
        {
            //Вывести следующую информацию об определенном сотруднике: 
            //ФИО, отдел, должность, номер кабинета, телефон.
            int id = (int)comboBoxSotrudnik.SelectedValue;
            using (Context db = new Context())
            {
                var infoSotrudnik = from s in db.Sotrudniks
                                     join o in db.Otdels on s.Id_Otdel equals o.Id_Otdel
                                     join d in db.Dolzhnosts on s.Id_Dolzhnost equals d.Id_Dolzhnost
                                     where s.Id_Sotrudnik == id
                                     select new
                                     {
                                         ФИО_Сотрудника = s.FIO,
                                         Отдел = o.Name_Otdel,
                                         Должность = d.Name_Dolzh,
                                         Номер_кабинета = o.Cab_Number,
                                         Телефон = o.Phone
                                     };
                dataGridQuery.DataSource = infoSotrudnik.ToList();
            }
        }

        private void QueryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.f.Show();
        }
    }
}
