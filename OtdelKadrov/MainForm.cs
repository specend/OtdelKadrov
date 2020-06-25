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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSotrudnik_Click(object sender, EventArgs e)
        {
            SotrudnikForm f = new SotrudnikForm();
            f.Show();
            this.Hide();
        }

        private void btnOtdel_Click(object sender, EventArgs e)
        {
            OtdelForm f = new OtdelForm();
            f.Show();
            this.Hide();
        }

        private void btnDolzh_Click(object sender, EventArgs e)
        {
            DolzhnostForm f = new DolzhnostForm();
            f.Show();
            this.Hide();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            QueryForm f = new QueryForm();
            f.Show();
            this.Hide();
        }
    }
}
