using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace softer
{
    public partial class accept : Form
    {
        public accept()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "pdf file (*.pdf)|*.pdf";
            d.ShowDialog();
            label3.Text = d.FileName;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(label3.Text))
            {
                try
                {
                    Process.Start(label3.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("تعذر فتح الملف" + ex.Message);
                }

            }
        }

        private void back_to_tableg_Click(object sender, EventArgs e)
        {
            home hom = (home)Application.OpenForms["home"];
            if (hom != null)
            {
                hom.form_panel.Controls.Clear();

                tableg tab = new tableg();
                tab.TopLevel = false;
                tab.FormBorderStyle = FormBorderStyle.None;
                tab.Dock = DockStyle.Fill;
            hom.form_panel.Controls.Add(tab);
            tab.Show();
            }
        }
    }
}
