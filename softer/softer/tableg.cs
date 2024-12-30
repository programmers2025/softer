using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace softer
{
    public partial class tableg : Form
    {
        SqlConnection cn = new SqlConnection("Data Source = TEMPROG\\SQLEXPRESS; Initial Catalog = Mubalg; User Id = sa; Password = 123");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter Da = new SqlDataAdapter();
        public tableg()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (!tabControl1.TabPages.Contains(Form_astqtab1))
            {
                tabControl1.Visible = true;
                tabControl1.Dock = DockStyle.Fill;
                tabControl1.TabPages.Add(Form_astqtab1);

                //home home = new home();
                //var x = Application.OpenForms["home"] as home;
                //x.btn_slide_main.Enabled = false;
            }
            tabControl1.SelectedTab = Form_astqtab1;
            //MessageBox.Show("hhhh");
          
            
        }

        private void tableg_Load(object sender, EventArgs e)
        {
            tabControl1.Visible = false;
            tabControl1.TabPages.Clear();
            FillComboBox(comnamemadabok, "SelectSubMComb", null, "SubName", "IDSub");
            FillComboBox(ma_book, "SelectSubStoh", null, "SubName", "IDSub");
            FillComboBox(ma_book_alia, "SelectSubStohA", null, "SubName", "IDSub");
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
        private void HandleTabAndInsert(string tableName, TabPage targetTab, TabControl tabControl, TextBox idTextBox, SqlConnection cn)
        {
            // فتح التبويب إذا لم يكن مفتوحًا
            if (!tabControl.TabPages.Contains(targetTab))
            {
                tabControl.TabPages.Add(targetTab);
            }
            tabControl.SelectedTab = targetTab;

            // التحقق من صحة ID
            if (!string.IsNullOrEmpty(idTextBox.Text) && int.TryParse(idTextBox.Text, out int currentID))
            {
                try
                {
                    if (cn.State != ConnectionState.Open)
                        cn.Open();

                    // التحقق مما إذا كان السجل موجودًا
                    string checkQuery = $"SELECT COUNT(*) FROM {tableName} WHERE id = @ID";
                    int count;

                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, cn))
                    {
                        checkCmd.Parameters.AddWithValue("@ID", currentID);
                        count = (int)checkCmd.ExecuteScalar();
                    }

                    // إذا لم يكن السجل موجودًا، قم بإدخاله
                    if (count == 0)
                    {
                        string insertQuery = $"INSERT INTO {tableName} (id) VALUES (@ID)";
                        using (SqlCommand insertCmd = new SqlCommand(insertQuery, cn))
                        {
                            insertCmd.Parameters.AddWithValue("@ID", currentID);
                            insertCmd.ExecuteNonQuery();
                            MessageBox.Show($"تم إنشاء سجل جديد في الجدول {tableName}.");
                        }
                    }
                    else
                    {
                        MessageBox.Show($"السجل موجود بالفعل في الجدول {tableName}.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"خطأ أثناء معالجة البيانات: {ex.Message}");
                }
                finally
                {
                    cn.Close();
                }
            }
            else
            {
                MessageBox.Show("يجب إدخال معرف رقمي صالح.");
            }
        }
        private void btnnext2_Click(object sender, EventArgs e)
        {
            HandleTabAndInsert("Mukadmat", Form_astqtab3, tabControl1, id, cn);
        }

        private void transfer_Click(object sender, EventArgs e)
        {
            HandleTabAndInsert("Stoh", Form_astqtab4, tabControl1, id, cn);

            cmd = new SqlCommand("UpdateMukadmat", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id", long.Parse(id.Text));
            cmd.Parameters.AddWithValue("@commutaba", commutaba.Text);
            cmd.Parameters.AddWithValue("@txtyear", txtyear.Text);
            cmd.Parameters.AddWithValue("@comhalahoza", comhalahoza.Text);
            cmd.Parameters.AddWithValue("@txthallea", txthallea.Text);
            cmd.Parameters.AddWithValue("@txtnamehallea", txtnamehallea.Text);
            cmd.Parameters.AddWithValue("@txtyearmnhg1", comyearmnhg1.Text);
            cmd.Parameters.AddWithValue("@txtyearmnhg2", comyearmnhg2.Text);
            cmd.Parameters.AddWithValue("@txtyearmnhg3", comyearmnhg3.Text);
            cmd.Parameters.AddWithValue("@txtyearmnhg4", comyearmnhg4.Text);
            cmd.Parameters.AddWithValue("@txtnamehoza1", txtnamehoza1.Text);
            cmd.Parameters.AddWithValue("@txtnamehoza2", txtnamehoza2.Text);
            cmd.Parameters.AddWithValue("@txtnamehoza3", txtnamehoza3.Text);
            cmd.Parameters.AddWithValue("@txtnamehoza4", txtnamehoza4.Text);
            cmd.Parameters.AddWithValue("@txtmocanhoza1", txtmocanhoza1.Text);
            cmd.Parameters.AddWithValue("@txtmocanhoza2", txtmocanhoza2.Text);
            cmd.Parameters.AddWithValue("@txtmocanhoza3", txtmocanhoza3.Text);
            cmd.Parameters.AddWithValue("@txtmocanhoza4", txtmocanhoza4.Text);
            cmd.Parameters.AddWithValue("@txtstarthoza1", txtstarthoza1.Text);
            cmd.Parameters.AddWithValue("@txtstarthoza2", txtstarthoza2.Text);
            cmd.Parameters.AddWithValue("@txtstarthoza3", txtstarthoza3.Text);
            cmd.Parameters.AddWithValue("@txtstarthoza4", txtstarthoza4.Text);
            cmd.Parameters.AddWithValue("@txtlasthoza1", txtlasthoza1.Text);
            cmd.Parameters.AddWithValue("@txtlasthoza2", txtlasthoza2.Text);
            cmd.Parameters.AddWithValue("@txtlasthoza3", txtlasthoza3.Text);
            cmd.Parameters.AddWithValue("@txtlasthoza4", txtlasthoza4.Text);
            cn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("تمت العملية بنجاح");
            cn.Close();
        }

        private void transfer_out_Click(object sender, EventArgs e)
        {
            HandleTabAndInsert("Kharej", Form_astqtab6, tabControl1, id, cn);

            cmd = new SqlCommand("UpdateStohA", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id", long.Parse(id.Text));
            cmd.Parameters.AddWithValue("@com_year_mnhg_alia", com_year_mnhg_alia.Text);
            cmd.Parameters.AddWithValue("@com_year_mnhg_alia1", com_year_mnhg_alia1.Text);
            cmd.Parameters.AddWithValue("@com_year_mnhg_alia2", com_year_mnhg_alia2.Text);
            cmd.Parameters.AddWithValue("@com_year_mnhg_alia3", com_year_mnhg_alia3.Text);
            cmd.Parameters.AddWithValue("@txt_tech_alia", txt_tech_alia.Text);
            cmd.Parameters.AddWithValue("@txt_tech_alia1", txt_tech_alia1.Text);
            cmd.Parameters.AddWithValue("@txt_tech_alia2", txt_tech_alia2.Text);
            cmd.Parameters.AddWithValue("@txt_tech_alia3", txt_tech_alia3.Text);
            cmd.Parameters.AddWithValue("@txt_place_alia", txt_place_alia.Text);
            cmd.Parameters.AddWithValue("@txt_place_alia1", txt_place_alia1.Text);
            cmd.Parameters.AddWithValue("@txt_place_alia2", txt_place_alia2.Text);
            cmd.Parameters.AddWithValue("@txt_place_alia3", txt_place_alia3.Text);
            cmd.Parameters.AddWithValue("@txt_date_start_alia", txt_date_start_alia.Text);
            cmd.Parameters.AddWithValue("@txt_date_start_alia1", txt_date_start_alia1.Text);
            cmd.Parameters.AddWithValue("@txt_date_start_alia2", txt_date_start_alia2.Text);
            cmd.Parameters.AddWithValue("@txt_date_start_alia3", txt_date_start_alia3.Text);
            cmd.Parameters.AddWithValue("@txt_date_end_alia", txt_date_end_alia.Text);
            cmd.Parameters.AddWithValue("@txt_date_end_alia1", txt_date_end_alia1.Text);
            cmd.Parameters.AddWithValue("@txt_date_end_alia2", txt_date_end_alia2.Text);
            cmd.Parameters.AddWithValue("@txt_date_end_alia3", txt_date_end_alia3.Text);

            cn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("تمت العملية بنجاح");
            cn.Close();
        }

        private void transfer_first_Click(object sender, EventArgs e)
        {
            HandleTabAndInsert("StohA", Form_astqtab5, tabControl1, id, cn);

            cmd = new SqlCommand("UpdateStoh", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", long.Parse(id.Text));
            cmd.Parameters.AddWithValue("@com_year_mnhg", com_year_mnhg.Text);
            cmd.Parameters.AddWithValue("@com_year_mnhg1", com_year_mnhg1.Text);
            cmd.Parameters.AddWithValue("@com_year_mnhg2", com_year_mnhg2.Text);
            cmd.Parameters.AddWithValue("@com_year_mnhg3", com_year_mnhg3.Text);
            cmd.Parameters.AddWithValue("@txt_tech_hwza", txt_tech_hwza.Text);
            cmd.Parameters.AddWithValue("@txt_tech_hwza1", txt_tech_hwza1.Text);
            cmd.Parameters.AddWithValue("@txt_tech_hwza2", txt_tech_hwza2.Text);
            cmd.Parameters.AddWithValue("@txt_tech_hwza3", txt_tech_hwza3.Text);
            cmd.Parameters.AddWithValue("@txt_place", txt_place.Text);
            cmd.Parameters.AddWithValue("@txt_place1", txt_place1.Text);
            cmd.Parameters.AddWithValue("@txt_place2", txt_place2.Text);
            cmd.Parameters.AddWithValue("@txt_place3", txt_place3.Text);
            cmd.Parameters.AddWithValue("@txt_date_start", txt_date_start.Text);
            cmd.Parameters.AddWithValue("@txt_date_start1", txt_date_start1.Text);
            cmd.Parameters.AddWithValue("@txt_date_start2", txt_date_start2.Text);
            cmd.Parameters.AddWithValue("@txt_date_start3", txt_date_start3.Text);
            cmd.Parameters.AddWithValue("@txt_date_end", txt_date_end.Text);
            cmd.Parameters.AddWithValue("@txt_date_end1", txt_date_end1.Text);
            cmd.Parameters.AddWithValue("@txt_date_end2", txt_date_end2.Text);
            cmd.Parameters.AddWithValue("@txt_date_end3", txt_date_end3.Text);

            cn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("تمت العملية بنجاح");
            cn.Close();
        }

        private void transfer_thired_Click(object sender, EventArgs e)
        {
            if (!tabControl1.TabPages.Contains(Form_astqtab7))
            {
                tabControl1.TabPages.Add(Form_astqtab7);
                tabControl1.SelectedTab = Form_astqtab7;
            }
            tabControl1.SelectedTab = Form_astqtab7;

            cmd = new SqlCommand("UpdateKharej", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id", long.Parse(id.Text)); // تأكد أن لديك عنصر id في النموذج
            cmd.Parameters.AddWithValue("@com_year_mnhg_out", com_year_mnhg_out.Text);
            cmd.Parameters.AddWithValue("@com_year_mnhg_out1", com_year_mnhg_out1.Text);
            cmd.Parameters.AddWithValue("@com_year_mnhg_out2", com_year_mnhg_out2.Text);
            cmd.Parameters.AddWithValue("@com_year_mnhg_out3", com_year_mnhg_out3.Text);
            cmd.Parameters.AddWithValue("@txt_tech_out", txt_tech_out.Text);
            cmd.Parameters.AddWithValue("@txt_tech_out1", txt_tech_out1.Text);
            cmd.Parameters.AddWithValue("@txt_tech_out2", txt_tech_out2.Text);
            cmd.Parameters.AddWithValue("@txt_tech_out3", txt_tech_out3.Text);
            cmd.Parameters.AddWithValue("@txt_place_out", txt_place_out.Text);
            cmd.Parameters.AddWithValue("@txt_place_out1", txt_place_out1.Text);
            cmd.Parameters.AddWithValue("@txt_place_out2", txt_place_out2.Text);
            cmd.Parameters.AddWithValue("@txt_place_out3", txt_place_out3.Text);
            cmd.Parameters.AddWithValue("@txt_date_start_out", txt_date_start_out.Text);
            cmd.Parameters.AddWithValue("@txt_date_start_out1", txt_date_start_out1.Text);
            cmd.Parameters.AddWithValue("@txt_date_start_out2", txt_date_start_out2.Text);
            cmd.Parameters.AddWithValue("@txt_date_start_out3", txt_date_start_out3.Text);
            cmd.Parameters.AddWithValue("@txt_date_end_out", txt_date_end_out.Text);
            cmd.Parameters.AddWithValue("@txt_date_end_out1", txt_date_end_out1.Text);
            cmd.Parameters.AddWithValue("@txt_date_end_out2", txt_date_end_out2.Text);
            cmd.Parameters.AddWithValue("@txt_date_end_out3", txt_date_end_out3.Text);

            cn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("تمت العملية بنجاح");
            cn.Close();
        }

        private void btnsavelast_Click(object sender, EventArgs e)
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

        private void btnblas_Click(object sender, EventArgs e)
        {
            List<Panel> panelsToMove = new List<Panel> { panelwtha, panelcart, paneldwra, panelcarttd,panelbut };
            PanelExpander expander = new PanelExpander(panelaml, panelsToMove, btnblas, 150);
            expander.ExpandPanel();
        }

        private void btnblas2_Click(object sender, EventArgs e)
        {
            List<Panel> panelsToMove = new List<Panel> { panelcart, paneldwra, panelcarttd, panelbut };
            PanelExpander expander = new PanelExpander(panelwtha, panelsToMove, btnblas2, 150);
            expander.ExpandPanel();
        }

        private void btnblas3_Click(object sender, EventArgs e)
        {
            List<Panel> panelsToMove = new List<Panel> { paneldwra, panelcarttd, panelbut };
            PanelExpander expander = new PanelExpander(panelcart, panelsToMove, btnblas3, 150);
            expander.ExpandPanel();
        }

        private void btnblas4_Click(object sender, EventArgs e)
        {
            List<Panel> panelsToMove = new List<Panel> { panelcarttd, panelbut };
            PanelExpander expander = new PanelExpander(paneldwra, panelsToMove, btnblas4, 150);
            expander.ExpandPanel();
        }

        private void btnblas5_Click(object sender, EventArgs e)
        {
            // هنا تمرير Panel3 كـ scrollablePanel للتحكم في التمرير
            List<Panel> panelsToMove = new List<Panel> { panelbut };
            PanelExpander expander = new PanelExpander(panelcarttd, panelsToMove, btnblas5, 150, panelbut);
            expander.ExpandPanel();
        }

        private void btnblas6_Click(object sender, EventArgs e)
        {
            List<Panel> panelsToMove = new List<Panel> { };
            PanelExpander expander = new PanelExpander(panalmqdmat, panelsToMove, btnblas6, 150);
            expander.ExpandPanel();
        }

        private void btnblas7_Click(object sender, EventArgs e)
        {
            List<Panel> panelsToMove = new List<Panel> { };
            PanelExpander expander = new PanelExpander(panelstoh1, panelsToMove, btnblas7, 150);
            expander.ExpandPanel();
        }

        private void btnblas8_Click(object sender, EventArgs e)
        {
            List<Panel> panelsToMove = new List<Panel> { };
            PanelExpander expander = new PanelExpander(panelstoh2, panelsToMove, btnblas8, 150);
            expander.ExpandPanel();
        }

        private void btnblas9_Click(object sender, EventArgs e)
        {
            List<Panel> panelsToMove = new List<Panel> { };
            PanelExpander expander = new PanelExpander(panelout, panelsToMove, btnblas9, 150);
            expander.ExpandPanel();
        }

        private void btnblas10_Click(object sender, EventArgs e)
        {
            List<Panel> panelsToMove = new List<Panel> { };
            PanelExpander expander = new PanelExpander(panelmoarfon, panelsToMove, btnblas10, 150);
            expander.ExpandPanel();
        }

        private void scanpic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files |*.jpg;*.jpeg;*.png;*.bmb";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pic_scan_moa.Image = Image.FromFile(openFileDialog.FileName);
                pic_scan_moa.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label57_Click(object sender, EventArgs e)
        {

        }

        private void textBox47_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btn_pic_info_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files |*.jpg;*.jpeg;*.png;*.bmb";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureinfo.Image = Image.FromFile(openFileDialog.FileName);
                pictureinfo.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if (!tabControl1.TabPages.Contains(Form_astqtab2))
            {
                tabControl1.TabPages.Add(Form_astqtab2);
                tabControl1.SelectedTab = Form_astqtab2;
            }
            tabControl1.SelectedTab = Form_astqtab2;
        }

        private void btntadqeq_Click(object sender, EventArgs e)
        {
            if (!tabControl1.TabPages.Contains(Form_astqtab8))
            {
                tabControl1.TabPages.Add(Form_astqtab8);
                tabControl1.SelectedTab = Form_astqtab8;
                tabControl1.Visible = true;
                tabControl1.Dock = DockStyle.Fill;
                home home = new home();
                var x = Application.OpenForms["home"] as home;
                x.btn_slide_main.Enabled = false;
            }
            tabControl1.SelectedTab = Form_astqtab8;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ستتوفر قريباً");
        }

        private void button3_Click(object sender, EventArgs e)
        {

            MessageBox.Show("ستتوفر قريباً");
        }

        private void btntkarer_Click(object sender, EventArgs e)
        {

            MessageBox.Show("ستتوفر قريباً");
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            home home = new home();
            var x = Application.OpenForms["home"] as home;
            x.btn_slide_main.Enabled = true;
            //home home = new home();
            home.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (MessageBox.Show("هل انت متأكد من الرجوع", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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

        private void btn_back_Click(object sender, EventArgs e)
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

        private void comnamemadabok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comnamemadabok.SelectedValue != null)
            {
                int selectedIDSub = Convert.ToInt32(comnamemadabok.SelectedValue); // تحويل القيمة المختارة إلى رقم
                                                                                   // إعداد مصفوفة SqlParameter لإضافة المعاملات
                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@IDSub", selectedIDSub) // تمرير القيمة المطلوبة إلى الإجراء المخزن
                };

                // استدعاء الدالة لتعبئة الكومبو الثاني بناءً على القيمة المختارة
                FillComboBox(comnamebookmq, "SelectBooKMComb", parameters, "BookName", "IDBook");
            }
        }

        private void btnsendbook_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("InsterSubBookM", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id.Text);
            cmd.Parameters.AddWithValue("@Sub", comnamemadabok.Text);
            cmd.Parameters.AddWithValue("@Book", comnamebookmq.Text);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            int idd = int.Parse(id.Text);
            LoadDataIntoGrid("SelectSubandBookDataGrid", idd, dataGridbookmq, 1);
        }

        private void btn_add_tech_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("InsterMTeachers", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id.Text);
            cmd.Parameters.AddWithValue("@Year", ma_tech.Text);
            cmd.Parameters.AddWithValue("@TeacherName", bo_tech.Text);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            int idd = int.Parse(id.Text);
            LoadDataIntoGrid("SelectMTeachersComb", idd, dataView_tech, 2);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "pdf file (*.pdf)|*.pdf";
            d.ShowDialog();
            label2.Text = d.FileName;

        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(label2.Text))
            {
                try
                {
                    Process.Start(label2.Text);
                }
                catch ( Exception ex)
                {
                    MessageBox.Show("تعذر فتح الملف"+ex.Message);
                }

            }
        }

        private void dataGridbookmq_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadDataIntoGrid(string storedProcedure, int id, DataGridView dataGrid, int columnConfig)
        {
            using (SqlCommand cmd = new SqlCommand(storedProcedure, cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);

                Da = new SqlDataAdapter(cmd);
                DataTable Dt = new DataTable();
                Da.Fill(Dt);

                // تعيين البيانات في الـ DataGrid
                dataGrid.DataSource = Dt;

                // تخصيص الأعمدة إذا لزم الأمر
                if (columnConfig == 1)
                {
                    dataGrid.Columns[0].Visible = false;
                    dataGrid.Columns[1].HeaderText = "id";
                    dataGrid.Columns[2].HeaderText = "اسم المادة";
                    dataGrid.Columns[3].HeaderText = "اسم الكتاب";
                }
                else if (columnConfig == 2)
                {
                    dataGrid.Columns[0].Visible = false;
                    dataGrid.Columns[1].HeaderText = "id";
                    dataGrid.Columns[2].HeaderText = "السنة المنهجية";
                    dataGrid.Columns[3].HeaderText = "اسم الاستاذ";
                }

                dataGrid.Refresh();
            }

        }


        // دالة عامة لتعبئة أي ComboBox بناءً على إجراء مخزن
        private void FillComboBox(ComboBox comboBox, string storedProcedureName, SqlParameter[] parameters, string displayMember, string valueMember)
        {
            try
            {
                // إعداد SqlCommand مع الإجراء المخزن
                SqlCommand cmd = new SqlCommand(storedProcedureName, cn);
                cmd.CommandType = CommandType.StoredProcedure;

                // إضافة المعاملات إلى SqlCommand (إن وجدت)
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                // استخدام SqlDataAdapter لملء DataTable بالبيانات
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                // فتح الاتصال
                cn.Open();

                // تعبئة DataTable
                da.Fill(dt);

                // ضبط مصدر البيانات لـ ComboBox
                comboBox.DataSource = dt;
                comboBox.DisplayMember = displayMember; // العمود الذي يحتوي على النصوص
                comboBox.ValueMember = valueMember;     // العمود الذي يحتوي على القيم

                // إغلاق الاتصال
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل البيانات: " + ex.Message);
            }
        }

        private void ma_book_SelectedIndexChanged(object sender, EventArgs e)
        {
            // تحقق مما إذا كان قد تم اختيار قيمة صحيحة في الكومبو الأول
            if (ma_book.SelectedValue != null)
            {
                int selectedIDSub = Convert.ToInt32(ma_book.SelectedValue); // تحويل القيمة المختارة إلى رقم
                                                                                   // إعداد مصفوفة SqlParameter لإضافة المعاملات
                SqlParameter[] parameters = new SqlParameter[]
                {
                      new SqlParameter("@IDSub", selectedIDSub) // تمرير القيمة المطلوبة إلى الإجراء المخزن
                };

                // استدعاء الدالة لتعبئة الكومبو الثاني بناءً على القيمة المختارة
                FillComboBox(name_book, "SelectBookStohComb", parameters, "BookName", "IDBook");
            }
        }

        private void ma_book_alia_SelectedIndexChanged(object sender, EventArgs e)
        {
            // تحقق مما إذا كان قد تم اختيار قيمة صحيحة في الكومبو الأول
            if (ma_book_alia.SelectedValue != null)
            {
                int selectedIDSub = Convert.ToInt32(ma_book_alia.SelectedValue); // تحويل القيمة المختارة إلى رقم
                                                                            // إعداد مصفوفة SqlParameter لإضافة المعاملات
                SqlParameter[] parameters = new SqlParameter[]
                {
                      new SqlParameter("@IDSub", selectedIDSub) // تمرير القيمة المطلوبة إلى الإجراء المخزن
                };

                // استدعاء الدالة لتعبئة الكومبو الثاني بناءً على القيمة المختارة
                FillComboBox(name_book_alia, "SelectBooKStohAComb", parameters, "BookName", "IDBook");
            }
        }

        private void add_book_stoh_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("InsterSubBookStoh", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id.Text);
            cmd.Parameters.AddWithValue("@Sub", ma_book.Text);
            cmd.Parameters.AddWithValue("@Book", name_book.Text);
            cn.Open();
            cmd.ExecuteNonQuery();
            int idd = int.Parse(id.Text);
            LoadDataIntoGrid("SelectSubandBookStohDataGrid", idd, dataView_books, 1);
            cn.Close();
        }

        private void add_tech_stoh_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("InsterStohTeachers", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id.Text);
            cmd.Parameters.AddWithValue("@Year", stage_tech.Text);
            cmd.Parameters.AddWithValue("@TeacherName", names_tech.Text);
            cn.Open();
            cmd.ExecuteNonQuery();
            int idd = int.Parse(id.Text);
            LoadDataIntoGrid("SelectStohTeachersDataGrid", idd, dataView_techs, 2);
            cn.Close();
        }

        private void add_book_alia_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("InsterSubBookStohA", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id.Text);
            cmd.Parameters.AddWithValue("@Sub", ma_book_alia.Text);
            cmd.Parameters.AddWithValue("@Book", name_book_alia.Text);
            cn.Open();
            cmd.ExecuteNonQuery();
            int idd = int.Parse(id.Text);
            LoadDataIntoGrid("SelectSubandBookStohADataGrid", idd, dataView_book_alia, 1);
            cn.Close();
        }

        private void add_tech_alia_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("InsterStohATeachers", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id.Text);
            cmd.Parameters.AddWithValue("@Year", stage_tech_alia.Text);
            cmd.Parameters.AddWithValue("@TeacherName", name_tech_alia.Text);
            cn.Open();
            cmd.ExecuteNonQuery();
            int idd = int.Parse(id.Text);
            LoadDataIntoGrid("SelectStohATeachersDataGrid", idd, dataView_tech_alia, 2);
            cn.Close();
        }

        private void add_tech_out_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("InsterKhTeachers", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id.Text);
            cmd.Parameters.AddWithValue("@Year", stage_tech_out.Text);
            cmd.Parameters.AddWithValue("@TeacherName", name_tech_out.Text);
            cn.Open();
            cmd.ExecuteNonQuery();
            int idd = int.Parse(id.Text);
            LoadDataIntoGrid("SelectKhTeachersDataGrid", idd, dataView_out, 2);
            name_tech_out.Text = "";
            cn.Close();
        }
    }
}
