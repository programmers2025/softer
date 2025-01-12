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

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "pdf file (*.pdf)|*.pdf";
            d.ShowDialog();
            label17.Text = d.FileName;
        }

        private void label17_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(label17.Text))
            {
                try
                {
                    Process.Start(label17.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("تعذر فتح الملف" + ex.Message);
                }

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "pdf file (*.pdf)|*.pdf";
            d.ShowDialog();
            label31.Text = d.FileName;
        }

        private void label31_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(label31.Text))
            {
                try
                {
                    Process.Start(label31.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("تعذر فتح الملف" + ex.Message);
                }
            }
    }

        private void label46_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(label46.Text))
            {
                try
                {
                    Process.Start(label46.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("تعذر فتح الملف" + ex.Message);
                }
            }
    }

        private void button12_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "pdf file (*.pdf)|*.pdf";
            d.ShowDialog();
            label46.Text = d.FileName;
        }

        private void label63_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(label63.Text))
            {
                try
                {
                    Process.Start(label63.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("تعذر فتح الملف" + ex.Message);
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "pdf file (*.pdf)|*.pdf";
            d.ShowDialog();
            label63.Text = d.FileName;
        }
    }
}