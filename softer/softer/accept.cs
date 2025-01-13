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
        private void accept_Load(object sender, EventArgs e)
        {
            tabControl1.Visible = false;
            tabControl1.TabPages.Clear();
        }

        private void btnadd_Click_1(object sender, EventArgs e)
        {
            if (!tabControl1.TabPages.Contains(tab_accept_ast))
            {
                tabControl1.Visible = true;
                tabControl1.Dock = DockStyle.Fill;
                tabControl1.TabPages.Add(tab_accept_ast);
            }
            tabControl1.SelectedTab = tab_accept_ast;

        }

        private void btntadqeq_Click_1(object sender, EventArgs e)
        {
            if (!tabControl1.TabPages.Contains(tab_accept_exam))
            {
                tabControl1.Visible = true;
                tabControl1.Dock = DockStyle.Fill;
                tabControl1.TabPages.Add(tab_accept_exam);
            }
            tabControl1.SelectedTab = tab_accept_exam;
        }

        private void btn_accept_Click_1(object sender, EventArgs e)
        {
            if (!tabControl1.TabPages.Contains(tab_interveiw))
            {
                tabControl1.Visible = true;
                tabControl1.Dock = DockStyle.Fill;
                tabControl1.TabPages.Add(tab_interveiw);
            }
            tabControl1.SelectedTab = tab_interveiw;
        }

        private void btntkarer_Click_1(object sender, EventArgs e)
        {
            if (!tabControl1.TabPages.Contains(tab_information))
            {
                tabControl1.Visible = true;
                tabControl1.Dock = DockStyle.Fill;
                tabControl1.TabPages.Add(tab_information);
            }
            tabControl1.SelectedTab = tab_information;
        }

        private void btn_user_Click_1(object sender, EventArgs e)
        {
            if (!tabControl1.TabPages.Contains(tab_manger))
            {
                tabControl1.Visible = true;
                tabControl1.Dock = DockStyle.Fill;
                tabControl1.TabPages.Add(tab_manger);
            }
            tabControl1.SelectedTab = tab_manger;
        }

        private void back_to_home_Click_1(object sender, EventArgs e)
        {
            if (!tabControl1.TabPages.Contains(tab_tagreby))
            {
                tabControl1.Visible = true;
                tabControl1.Dock = DockStyle.Fill;
                tabControl1.TabPages.Add(tab_tagreby);
            }
            tabControl1.SelectedTab = tab_tagreby;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("هل انت متأكد من الرجوع", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                home hom = (home)Application.OpenForms["home"];
                if (hom != null)
                {
                    hom.form_panel.Controls.Clear();

                    accept tab = new accept();
                    tab.TopLevel = false;
                    tab.FormBorderStyle = FormBorderStyle.None;
                    tab.Dock = DockStyle.Fill;
                    hom.form_panel.Controls.Add(tab);
                    tab.Show();
                }
            }
    }

        private void button19_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد من الرجوع", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                home hom = (home)Application.OpenForms["home"];
                if (hom != null)
                {
                    hom.form_panel.Controls.Clear();

                    accept tab = new accept();
                    tab.TopLevel = false;
                    tab.FormBorderStyle = FormBorderStyle.None;
                    tab.Dock = DockStyle.Fill;
                    hom.form_panel.Controls.Add(tab);
                    tab.Show();
                }
            }
    }

        private void back_to_tableg_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد من الرجوع", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                home hom = (home)Application.OpenForms["home"];
                if (hom != null)
                {
                    hom.form_panel.Controls.Clear();

                    accept tab = new accept();
                    tab.TopLevel = false;
                    tab.FormBorderStyle = FormBorderStyle.None;
                    tab.Dock = DockStyle.Fill;
                    hom.form_panel.Controls.Add(tab);
                    tab.Show();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد من الرجوع", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                home hom = (home)Application.OpenForms["home"];
                if (hom != null)
                {
                    hom.form_panel.Controls.Clear();

                    accept tab = new accept();
                    tab.TopLevel = false;
                    tab.FormBorderStyle = FormBorderStyle.None;
                    tab.Dock = DockStyle.Fill;
                    hom.form_panel.Controls.Add(tab);
                    tab.Show();
                }
    }
}

        private void button11_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد من الرجوع", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                home hom = (home)Application.OpenForms["home"];
                if (hom != null)
                {
                    hom.form_panel.Controls.Clear();

                    accept tab = new accept();
                    tab.TopLevel = false;
                    tab.FormBorderStyle = FormBorderStyle.None;
                    tab.Dock = DockStyle.Fill;
                    hom.form_panel.Controls.Add(tab);
                    tab.Show();
                }
    }
    }

        private void button15_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد من الرجوع", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                home hom = (home)Application.OpenForms["home"];
                if (hom != null)
                {
                    hom.form_panel.Controls.Clear();

                    accept tab = new accept();
                    tab.TopLevel = false;
                    tab.FormBorderStyle = FormBorderStyle.None;
                    tab.Dock = DockStyle.Fill;
                    hom.form_panel.Controls.Add(tab);
                    tab.Show();
                }
            }
        }

        private void tab_accept_exam_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label78_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView8_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView11_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}