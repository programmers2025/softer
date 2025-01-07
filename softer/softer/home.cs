﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace softer
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_slide_main_Click(object sender, EventArgs e)
        {
            if (flomenu.Width == 50)
            {
                flomenu.Width = 173;
            }
            else
            {
                flomenu.Width = 50;
                paneltableg.Visible = false;
                depsidebar.Width = 0;
                sittingsidebar.Width = 0;
            }
        }

        private void btnaksam_Click(object sender, EventArgs e)
        {
            if (flomenu.Width == 50)
            {
            }
            else if (flomenu.Width > 50)
            {
                if (depsidebar.Width == 0 || sittingsidebar.Width == 290)
                {
                    //sittingsidebar.Width = 0;
                    depsidebar.Width = 290;

                }
                else
                {
                    depsidebar.Width = 0;
                    paneltableg.Visible = false;
                }
            }
        }

        private void btnsetting_Click(object sender, EventArgs e)
        {
           if (sittingsidebar.Height == 0)
            {
                sittingsidebar.Height = 265;

 
            }
           else
            {
                sittingsidebar.Height = 0;
            }
        }

        private void btntableg_Click(object sender, EventArgs e)
        {
            if (paneltableg.Visible == true)
            {
                paneltableg.Visible = false;
            }
            else
            {
                paneltableg.Visible = true;
                paneltableg.BringToFront();
            }
        }

        private void btnastqtab_Click(object sender, EventArgs e)
        {

            depsidebar.Width = 0;
            tableg tab = new tableg();
            tab.TopLevel = false;
            tab.FormBorderStyle = FormBorderStyle.None;
            tab.Dock = DockStyle.Fill;
            form_panel.Controls.Clear();
            form_panel.Controls.Add(tab);
            tab.Show();
            flomenu.Width = 50;
            home home = new home();
            var x = Application.OpenForms["home"] as home;
            x.btn_slide_main.Enabled = false;
            paneltableg.Visible = false;
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           btn_slide_main.Visible = false;
        }

        private void btnedara_Click(object sender, EventArgs e)
        {

        }

        private void home_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(1350, 730);
        }

        private void button2_Click(object sender, EventArgs e)
        {


            MessageBox.Show("ستتوفر قريباً");
        }

        private void button3_Click(object sender, EventArgs e)
        {


            MessageBox.Show("ستتوفر قريباً");
        }

        private void btn_aa_Click(object sender, EventArgs e)
        {

            MessageBox.Show("ستتوفر قريباً");
        }

        private void btn_a_Click(object sender, EventArgs e)
        {

            MessageBox.Show("ستتوفر قريباً");
        }

        private void btn_aaa_Click(object sender, EventArgs e)
        {

            MessageBox.Show("ستتوفر قريباً");
        }

        private void btn_aaaa_Click(object sender, EventArgs e)
        {

            MessageBox.Show("ستتوفر قريباً");
        }

        private void btn_aaaaa_Click(object sender, EventArgs e)
        {

            MessageBox.Show("ستتوفر قريباً");
        }
    }
}
