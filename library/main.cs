using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Threading;

namespace library
{
    public partial class main : MetroFramework.Forms.MetroForm
    {
        OleDbConnection con;
        OleDbDataAdapter da;
        OleDbDataAdapter da2;
        OleDbDataAdapter da3;
        OleDbDataAdapter da4;
        DataSet ds;
        DataSet ds2;
        DataSet ds3;
        DataSet ds4;

        public main()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        void fillthegrid()
        {
            con = new OleDbConnection(Localization.oledbcon);
            da = new OleDbDataAdapter(Localization.oledbbook, con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, Localization._maingridbook);
            maingrid.DataSource = ds.Tables[Localization._maingridbook];
            con.Close();
        }
        void fillthelang()
        {
            con = new OleDbConnection(Localization.oledbcon);
            da3 = new OleDbDataAdapter(Localization.oledblang, con);
            ds3 = new DataSet();
            con.Open();
            da3.Fill(ds3, Localization.langcolumn);
            data_lang.DataSource = ds3.Tables[Localization.langcolumn];
            con.Close();

            cmb_lang_search.Items.Clear();
            cmb_addlang.Items.Clear();
            cmb_lang.Items.Clear();

            for (int i = 0; i < data_lang.Rows.Count - 1; i++)
            {
                cmb_lang_search.Items.Add(data_lang.Rows[i].Cells[0].Value.ToString());
                cmb_addlang.Items.Add(data_lang.Rows[i].Cells[0].Value.ToString());
                cmb_lang.Items.Add(data_lang.Rows[i].Cells[0].Value.ToString());
            }

            cmb_lang.BackColor = Color.White;
            cmb_lang.ForeColor = Color.Black;
            cmb_lang_search.BackColor = Color.White;
            cmb_lang_search.ForeColor = Color.Black;
            cmb_addlang.BackColor = Color.White;
            cmb_addlang.ForeColor = Color.Black;
        }
        void filltheshelf()
        {
            con = new OleDbConnection(Localization.oledbcon);
            da2 = new OleDbDataAdapter(Localization.oledbshelf, con);
            ds2 = new DataSet();
            con.Open();
            da2.Fill(ds2, Localization._maingridshelfname);
            data_shelf.DataSource = ds2.Tables[Localization._maingridshelfname];

            con.Close();

            cmb_shelf.Items.Clear();
            cmb_shelf_search.Items.Clear();
            cmb_addshelf.Items.Clear();

            for (int i = 0; i < data_shelf.Rows.Count - 1; i++)
            {
                cmb_shelf.Items.Add(data_shelf.Rows[i].Cells[0].Value.ToString());
                cmb_shelf_search.Items.Add(data_shelf.Rows[i].Cells[0].Value.ToString());
                cmb_addshelf.Items.Add(data_shelf.Rows[i].Cells[0].Value.ToString());
            }

            cmb_shelf.BackColor = Color.White;
            cmb_shelf.ForeColor = Color.Black;
            cmb_shelf_search.BackColor = Color.White;
            cmb_shelf_search.ForeColor = Color.Black;
            cmb_addshelf.BackColor = Color.White;
            cmb_addshelf.ForeColor = Color.Black;
        }
        void fillthefloor()
        {
            con = new OleDbConnection(Localization.oledbcon);
            da4 = new OleDbDataAdapter(Localization.oledbfloor, con);
            ds4 = new DataSet();
            con.Open();
            da4.Fill(ds4, Localization.floor);
            data_floor.DataSource = ds4.Tables[Localization.floor];
            con.Close();

            cmb_floor.Items.Clear();
            cmb_addfloor.Items.Clear();

            for (int i = 0; i < data_floor.Rows.Count - 1; i++)
            {
                cmb_floor.Items.Add(data_floor.Rows[i].Cells[0].Value.ToString());
                cmb_addfloor.Items.Add(data_floor.Rows[i].Cells[0].Value.ToString());
            }

            cmb_floor.BackColor = Color.White;
            cmb_floor.ForeColor = Color.Black;
            cmb_addfloor.BackColor = Color.White;
            cmb_addfloor.ForeColor = Color.Black;
        }
        void designthegrid()
        {
            maingrid.Columns[0].Width = 350;
            maingrid.Columns[1].Width = 150;
            maingrid.Columns[2].Width = 40;
            maingrid.Columns[3].Width = 70;
            maingrid.Columns[4].Width = 130;
            maingrid.Columns[5].Width = 30;
            maingrid.Columns[6].Width = 50;

            maingrid.DefaultCellStyle.BackColor = Color.White;
            maingrid.DefaultCellStyle.ForeColor = Color.Black;
            maingrid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 0, 148);
            maingrid.DefaultCellStyle.SelectionForeColor = Color.White;
            maingrid.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            maingrid.DefaultCellStyle.Font = new Font(Localization.font, 8, FontStyle.Regular);

            maingrid.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            maingrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            maingrid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
            maingrid.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black;
            maingrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            maingrid.ColumnHeadersDefaultCellStyle.Font = new Font(Localization.font, 8, FontStyle.Regular);

            maingrid.Columns[7].Visible = false;
            maingrid.ClearSelection();
        }
        void openthemode()
        {
            groupBoxedit.Enabled = true;
            btn_add.Enabled = true;
            btn_update.Enabled = true;
            btn_delete.Enabled = true;

            txt_name.Enabled = true;
            txt_author.Enabled = true;
            txt_year.Enabled = true;
            txt_bookid.Enabled = true;

            btn_add.Style = MetroFramework.MetroColorStyle.Blue;
            btn_update.Style = MetroFramework.MetroColorStyle.Blue;
            btn_delete.Style = MetroFramework.MetroColorStyle.Blue;
        }
        void closethemode()
        {
            groupBoxedit.Enabled = false;
            btn_add.Enabled = false;
            btn_update.Enabled = false;
            btn_delete.Enabled = false;

            txt_name.Enabled = false;
            txt_author.Enabled = false;
            txt_year.Enabled = false;
            txt_bookid.Enabled = false;

            btn_add.Style = MetroFramework.MetroColorStyle.White;
            btn_update.Style = MetroFramework.MetroColorStyle.White;
            btn_delete.Style = MetroFramework.MetroColorStyle.White;

            txt_id.Clear();
            txt_control.Clear();
            txt_dgscontrol.Clear();
        }
        void searchprocesses()
        {
            if (cmb_shelf_search.Text == string.Empty && txt_year1.Text == string.Empty && cmb_lang_search.Text == string.Empty && txt_search.Text != string.Empty && txt_year2.Text == string.Empty)//1
            {
                DataView dv = ds.Tables[0].DefaultView;
                dv.RowFilter = "isim Like '%" + txt_search.Text.ToString().Replace("'", "’") + "%' or yazar Like '%" + txt_search.Text.ToString().Replace("'", "’") + "%'";
                maingrid.DataSource = dv;

                lbl_matched.Text = maingrid.Rows.Count.ToString();
            }
            else if (cmb_shelf_search.Text != string.Empty && txt_year1.Text == string.Empty && cmb_lang_search.Text == string.Empty && txt_search.Text != string.Empty && txt_year2.Text == string.Empty)//2
            {
                DataView dv = ds.Tables[0].DefaultView;
                dv.RowFilter = "rafismi Like '%" + cmb_shelf_search.Text + "%' and " +
                    "isim like '%" + txt_search.Text.ToString().Replace("'", "’") + "%' or " +
                    "rafismi Like '%" + cmb_shelf_search.Text + "%' and " +
                    "yazar like '%" + txt_search.Text.ToString().Replace("'", "’") + "%'";
                maingrid.DataSource = dv;

                lbl_matched.Text = maingrid.Rows.Count.ToString();
            }
            else if (cmb_shelf_search.Text == string.Empty && txt_year1.Text != string.Empty && cmb_lang_search.Text == string.Empty && txt_search.Text != string.Empty && txt_year2.Text == string.Empty)//3
            {
                DataView dv = ds.Tables[0].DefaultView;
                dv.RowFilter = "yil Like '%" + txt_year1.Text + "%' and " +
                    "isim like '%" + txt_search.Text.ToString().Replace("'", "’") + "%' or " +
                    "yil Like '%" + txt_year1.Text + "%' and " +
                    "yazar like '%" + txt_search.Text.ToString().Replace("'", "’") + "%'";
                maingrid.DataSource = dv;

                lbl_matched.Text = maingrid.Rows.Count.ToString();
            }
            else if (cmb_shelf_search.Text != string.Empty && txt_year1.Text != string.Empty && cmb_lang_search.Text == string.Empty && txt_search.Text != string.Empty && txt_year2.Text == string.Empty)//4
            {
                DataView dv = ds.Tables[0].DefaultView;
                dv.RowFilter = "yil Like '%" + txt_year1.Text + "%' and " +
                    "rafismi Like '%" + cmb_shelf_search.Text + "%' and " +
                    "isim like '%" + txt_search.Text.ToString().Replace("'", "’") + "%' or " +
                    "yil Like '%" + txt_year1.Text + "%' and " +
                    "rafismi Like '%" + cmb_shelf_search.Text + "%' and " +
                    "yazar like '%" + txt_search.Text.ToString().Replace("'", "’") + "%'";
                maingrid.DataSource = dv;

                lbl_matched.Text = maingrid.Rows.Count.ToString();
            }
            else if (cmb_shelf_search.Text != string.Empty && txt_year1.Text != string.Empty && cmb_lang_search.Text != string.Empty && txt_search.Text != string.Empty && txt_year2.Text == string.Empty)//5
            {
                DataView dv = ds.Tables[0].DefaultView;
                dv.RowFilter = "yil Like '%" + txt_year1.Text + "%' and " +
                    "rafismi Like '%" + cmb_shelf_search.Text + "%' and " +
                    "isim like '%" + txt_search.Text.ToString().Replace("'", "’") + "%' and " +
                    "dil like '%" + cmb_lang_search.Text + "%' or " +
                    "yil Like '%" + txt_year1.Text + "%' and " +
                    "rafismi Like '%" + cmb_shelf_search.Text + "%' and " +
                    "yazar like '%" + txt_search.Text.ToString().Replace("'", "’") + "%' and " +
                    "dil like '%" + cmb_lang_search.Text + "%'";
                maingrid.DataSource = dv;

                lbl_matched.Text = maingrid.Rows.Count.ToString();
            }
            else if (cmb_shelf_search.Text == string.Empty && txt_year1.Text != string.Empty && cmb_lang_search.Text != string.Empty && txt_search.Text != string.Empty && txt_year2.Text == string.Empty)//6
            {
                DataView dv = ds.Tables[0].DefaultView;
                dv.RowFilter = "yil Like '%" + txt_year1.Text + "%' and " +
                    "isim like '%" + txt_search.Text.ToString().Replace("'", "’") + "%' and " +
                    "dil like '%" + cmb_lang_search.Text + "%' or " +
                    "yil Like '%" + txt_year1.Text + "%' and " +
                    "yazar like '%" + txt_search.Text.ToString().Replace("'", "’") + "%' and " +
                    "dil like '%" + cmb_lang_search.Text + "%'";
                maingrid.DataSource = dv;

                lbl_matched.Text = maingrid.Rows.Count.ToString();
            }
            else if (cmb_shelf_search.Text != string.Empty && txt_year1.Text == string.Empty && cmb_lang_search.Text != string.Empty && txt_search.Text != string.Empty && txt_year2.Text == string.Empty)//7
            {
                DataView dv = ds.Tables[0].DefaultView;
                dv.RowFilter = "rafismi Like '%" + cmb_shelf_search.Text + "%' and " +
                    "isim like '%" + txt_search.Text.ToString().Replace("'", "’") + "%' and " +
                    "dil like '%" + cmb_lang_search.Text + "%' or " +
                    "rafismi Like '%" + cmb_shelf_search.Text + "%' and " +
                    "yazar like '%" + txt_search.Text.ToString().Replace("'", "’") + "%' and " +
                    "dil like '%" + cmb_lang_search.Text + "%'";
                maingrid.DataSource = dv;

                lbl_matched.Text = maingrid.Rows.Count.ToString();
            }
            else if (cmb_shelf_search.Text == string.Empty && txt_year1.Text == string.Empty && cmb_lang_search.Text != string.Empty && txt_search.Text != string.Empty && txt_year2.Text == string.Empty)//8
            {
                DataView dv = ds.Tables[0].DefaultView;
                dv.RowFilter = "isim like '%" + txt_search.Text.ToString().Replace("'", "’") + "%' and " +
                    "dil like '%" + cmb_lang_search.Text + "%' or " +
                    "yazar like '%" + txt_search.Text.ToString().Replace("'", "’") + "%' and " +
                    "dil like '%" + cmb_lang_search.Text + "%'";
                maingrid.DataSource = dv;

                lbl_matched.Text = maingrid.Rows.Count.ToString();
            }
            else if (cmb_shelf_search.Text != string.Empty && txt_year1.Text != string.Empty && cmb_lang_search.Text != string.Empty && txt_search.Text == string.Empty && txt_year2.Text == string.Empty)//9
            {
                DataView dv = ds.Tables[0].DefaultView;
                dv.RowFilter = "yil Like '%" + txt_year1.Text + "%' and " +
                    "rafismi Like '%" + cmb_shelf_search.Text + "%' and " +
                    "dil like '%" + cmb_lang_search.Text + "%'";
                maingrid.DataSource = dv;

                lbl_matched.Text = maingrid.Rows.Count.ToString();
            }
            else if (cmb_shelf_search.Text != string.Empty && txt_year1.Text != string.Empty && cmb_lang_search.Text == string.Empty && txt_search.Text == string.Empty && txt_year2.Text == string.Empty)//10
            {
                DataView dv = ds.Tables[0].DefaultView;
                dv.RowFilter = "yil Like '%" + txt_year1.Text + "%' and " +
                    "rafismi Like '%" + cmb_shelf_search.Text + "%'";
                maingrid.DataSource = dv;

                lbl_matched.Text = maingrid.Rows.Count.ToString();
            }
            else if (cmb_shelf_search.Text != string.Empty && txt_year1.Text == string.Empty && cmb_lang_search.Text != string.Empty && txt_search.Text == string.Empty && txt_year2.Text == string.Empty)//11
            {
                DataView dv = ds.Tables[0].DefaultView;
                dv.RowFilter = "rafismi Like '%" + cmb_shelf_search.Text + "%' and " +
                    "dil like '%" + cmb_lang_search.Text + "%'";
                maingrid.DataSource = dv;

                lbl_matched.Text = maingrid.Rows.Count.ToString();
            }
            else if (cmb_shelf_search.Text != string.Empty && txt_year1.Text == string.Empty && cmb_lang_search.Text == string.Empty && txt_search.Text == string.Empty && txt_year2.Text == string.Empty)//12
            {
                DataView dv = ds.Tables[0].DefaultView;
                dv.RowFilter = "rafismi Like '%" + cmb_shelf_search.Text + "%'";
                maingrid.DataSource = dv;

                lbl_matched.Text = maingrid.Rows.Count.ToString();
            }
            else if (cmb_shelf_search.Text == string.Empty && txt_year1.Text != string.Empty && cmb_lang_search.Text != string.Empty && txt_search.Text == string.Empty && txt_year2.Text == string.Empty)//13
            {
                DataView dv = ds.Tables[0].DefaultView;
                dv.RowFilter = "yil Like '%" + txt_year1.Text + "%' and " +
                    "dil like '%" + cmb_lang_search.Text + "%'";
                maingrid.DataSource = dv;

                lbl_matched.Text = maingrid.Rows.Count.ToString();
            }
            else if (cmb_shelf_search.Text == string.Empty && txt_year1.Text != string.Empty && cmb_lang_search.Text == string.Empty && txt_search.Text == string.Empty && txt_year2.Text == string.Empty)//14
            {
                DataView dv = ds.Tables[0].DefaultView;
                dv.RowFilter = "yil Like '%" + txt_year1.Text + "%'";
                maingrid.DataSource = dv;

                lbl_matched.Text = maingrid.Rows.Count.ToString();
            }
            else if (cmb_shelf_search.Text == string.Empty && txt_year1.Text == string.Empty && cmb_lang_search.Text != string.Empty && txt_search.Text == string.Empty && txt_year2.Text == string.Empty)//15
            {
                DataView dv = ds.Tables[0].DefaultView;
                dv.RowFilter = "dil Like '%" + cmb_lang_search.Text + "%'";
                maingrid.DataSource = dv;

                lbl_matched.Text = maingrid.Rows.Count.ToString();
            }
            else if (cmb_shelf_search.Text == string.Empty && txt_year1.Text != string.Empty && cmb_lang_search.Text == string.Empty && txt_search.Text == string.Empty && txt_year2.Text != string.Empty)//16
            {
                con.Open();
                string sql = Localization.oledbsearchbetweenyear;
                DataTable dt_cmb2 = new DataTable();
                OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
                adp.SelectCommand.Parameters.AddWithValue(Localization.oledbtar1, txt_year1.Text.ToString());
                adp.SelectCommand.Parameters.AddWithValue(Localization.oledbtar2, txt_year2.Text.ToString());
                adp.Fill(dt_cmb2);
                con.Close();
                maingrid.DataSource = dt_cmb2;

                lbl_matched.Text = maingrid.Rows.Count.ToString();
            }
            else if (cmb_shelf_search.Text == string.Empty && txt_year1.Text != string.Empty && cmb_lang_search.Text == string.Empty && txt_search.Text != string.Empty && txt_year2.Text != string.Empty)//17
            {
                con.Open();
                string sql = Localization.oledbsearchbetweenyear;
                DataTable dt_cmb2 = new DataTable();
                OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
                adp.SelectCommand.Parameters.AddWithValue(Localization.oledbtar1, txt_year1.Text.ToString());
                adp.SelectCommand.Parameters.AddWithValue(Localization.oledbtar2, txt_year2.Text.ToString());
                adp.Fill(dt_cmb2);
                con.Close();
                maingrid.DataSource = dt_cmb2;

                DataView dv = dt_cmb2.AsDataView();
                dv.RowFilter = "isim Like '%" + txt_search.Text.ToString().Replace("'", "’") + "%' or yazar Like '%" + txt_search.Text.ToString().Replace("'", "’") + "%'";
                maingrid.DataSource = dv;

                lbl_matched.Text = maingrid.Rows.Count.ToString();
            }
            else if (cmb_shelf_search.Text == string.Empty && txt_year1.Text != string.Empty && cmb_lang_search.Text != string.Empty && txt_search.Text == string.Empty && txt_year2.Text != string.Empty)//18
            {
                con.Open();
                string sql = Localization.oledbsearchbetweenyear;
                DataTable dt_cmb2 = new DataTable();
                OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
                adp.SelectCommand.Parameters.AddWithValue(Localization.oledbtar1, txt_year1.Text.ToString());
                adp.SelectCommand.Parameters.AddWithValue(Localization.oledbtar2, txt_year2.Text.ToString());
                adp.Fill(dt_cmb2);
                con.Close();
                maingrid.DataSource = dt_cmb2;

                DataView dv = dt_cmb2.AsDataView();
                dv.RowFilter = "dil Like '%" + cmb_lang_search.Text + "%'";
                maingrid.DataSource = dv;

                lbl_matched.Text = maingrid.Rows.Count.ToString();
            }
            else if (cmb_shelf_search.Text != string.Empty && txt_year1.Text != string.Empty && cmb_lang_search.Text == string.Empty && txt_search.Text == string.Empty && txt_year2.Text != string.Empty)//19
            {
                con.Open();
                string sql = Localization.oledbsearchbetweenyear;
                DataTable dt_cmb2 = new DataTable();
                OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
                adp.SelectCommand.Parameters.AddWithValue(Localization.oledbtar1, txt_year1.Text.ToString());
                adp.SelectCommand.Parameters.AddWithValue(Localization.oledbtar2, txt_year2.Text.ToString());
                adp.Fill(dt_cmb2);
                con.Close();
                maingrid.DataSource = dt_cmb2;

                DataView dv = dt_cmb2.AsDataView();
                dv.RowFilter = "rafismi Like '%" + cmb_shelf_search.Text + "%'";
                maingrid.DataSource = dv;

                lbl_matched.Text = maingrid.Rows.Count.ToString();
            }
            else if (cmb_shelf_search.Text != string.Empty && txt_year1.Text != string.Empty && cmb_lang_search.Text != string.Empty && txt_search.Text == string.Empty && txt_year2.Text != string.Empty)//20
            {
                con.Open();
                string sql = Localization.oledbsearchbetweenyear;
                DataTable dt_cmb2 = new DataTable();
                OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
                adp.SelectCommand.Parameters.AddWithValue(Localization.oledbtar1, txt_year1.Text.ToString());
                adp.SelectCommand.Parameters.AddWithValue(Localization.oledbtar2, txt_year2.Text.ToString());
                adp.Fill(dt_cmb2);
                con.Close();
                maingrid.DataSource = dt_cmb2;

                DataView dv = dt_cmb2.AsDataView();
                dv.RowFilter = "rafismi Like '%" + cmb_shelf_search.Text + "%' and " +
                    "dil like '%" + cmb_lang_search.Text + "%'";
                maingrid.DataSource = dv;

                lbl_matched.Text = maingrid.Rows.Count.ToString();
            }
            else if (cmb_shelf_search.Text != string.Empty && txt_year1.Text != string.Empty && cmb_lang_search.Text == string.Empty && txt_search.Text != string.Empty && txt_year2.Text != string.Empty)//21
            {
                con.Open();
                string sql = Localization.oledbsearchbetweenyear;
                DataTable dt_cmb2 = new DataTable();
                OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
                adp.SelectCommand.Parameters.AddWithValue(Localization.oledbtar1, txt_year1.Text.ToString());
                adp.SelectCommand.Parameters.AddWithValue(Localization.oledbtar2, txt_year2.Text.ToString());
                adp.Fill(dt_cmb2);
                con.Close();
                maingrid.DataSource = dt_cmb2;

                DataView dv = dt_cmb2.AsDataView();
                dv.RowFilter = "rafismi Like '%" + cmb_shelf_search.Text + "%' and " +
                    "isim like '%" + txt_search.Text.ToString().Replace("'", "’") + "%' or " +
                    "rafismi Like '%" + cmb_shelf_search.Text + "%' and " +
                    "yazar like '%" + txt_search.Text.ToString().Replace("'", "’") + "%'";
                maingrid.DataSource = dv;

                lbl_matched.Text = maingrid.Rows.Count.ToString();
            }
            else if (cmb_shelf_search.Text == string.Empty && txt_year1.Text != string.Empty && cmb_lang_search.Text != string.Empty && txt_search.Text != string.Empty && txt_year2.Text != string.Empty)//22
            {
                con.Open();
                string sql = Localization.oledbsearchbetweenyear;
                DataTable dt_cmb2 = new DataTable();
                OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
                adp.SelectCommand.Parameters.AddWithValue(Localization.oledbtar1, txt_year1.Text.ToString());
                adp.SelectCommand.Parameters.AddWithValue(Localization.oledbtar2, txt_year2.Text.ToString());
                adp.Fill(dt_cmb2);
                con.Close();
                maingrid.DataSource = dt_cmb2;

                DataView dv = dt_cmb2.AsDataView();
                dv.RowFilter = "isim like '%" + txt_search.Text.ToString().Replace("'", "’") + "%' and " +
                    "dil like '%" + cmb_lang_search.Text + "%' or " +
                    "yazar like '%" + txt_search.Text.ToString().Replace("'", "’") + "%' and " +
                    "dil like '%" + cmb_lang_search.Text + "%'";
                maingrid.DataSource = dv;

                lbl_matched.Text = maingrid.Rows.Count.ToString();
            }
            else if (cmb_shelf_search.Text != string.Empty && txt_year1.Text != string.Empty && cmb_lang_search.Text != string.Empty && txt_search.Text != string.Empty && txt_year2.Text != string.Empty)//23
            {
                con.Open();
                string sql = Localization.oledbsearchbetweenyear;
                DataTable dt_cmb2 = new DataTable();
                OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
                adp.SelectCommand.Parameters.AddWithValue(Localization.oledbtar1, txt_year1.Text.ToString());
                adp.SelectCommand.Parameters.AddWithValue(Localization.oledbtar2, txt_year2.Text.ToString());
                adp.Fill(dt_cmb2);
                con.Close();
                maingrid.DataSource = dt_cmb2;

                DataView dv = dt_cmb2.AsDataView();
                dv.RowFilter = "rafismi Like '%" + cmb_shelf_search.Text + "%' and " +
                    "isim like '%" + txt_search.Text.ToString().Replace("'", "’") + "%' and " +
                    "dil like '%" + cmb_lang_search.Text + "%' or " +
                    "rafismi Like '%" + cmb_shelf_search.Text + "%' and " +
                    "yazar like '%" + txt_search.Text.ToString().Replace("'", "’") + "%' and " +
                    "dil like '%" + cmb_lang_search.Text + "%'";
                maingrid.DataSource = dv;

                lbl_matched.Text = maingrid.Rows.Count.ToString();
            }
            else if (cmb_shelf_search.Text == string.Empty && txt_year1.Text == string.Empty && cmb_lang_search.Text == string.Empty && txt_search.Text == string.Empty && txt_year2.Text == string.Empty)//24
            {
                fillthegrid();

                lbl_matched.Text = maingrid.Rows.Count.ToString();

                maingrid.ClearSelection();
            }
        }
        void sayi_tüm()
        {
            int x;
            x = maingrid.RowCount;
            string y = x.ToString();
            lbl_all.Text = y;
        }
        void cleanleft()
        {
            txt_name.Clear();
            txt_author.Clear();
            txt_year.Clear();
            cmb_lang.SelectedIndex = -1;
            cmb_shelf.SelectedIndex = -1;
            cmb_floor.SelectedIndex = -1;
            txt_bookid.Clear();
            txt_id.Clear();
            maingrid.ClearSelection();
        }
        void cleanright()
        {
            txt_search.Clear();
            txt_year2.Clear();
            txt_year1.Clear();
            cmb_shelf_search.SelectedIndex = -1;
            cmb_lang_search.SelectedIndex = -1;
            lbl_matched.Text = "";
            rbyear1.Checked = true;
            rbyear2.Checked = false;
            txt_year2.Visible = false;
            fillthegrid();
            maingrid.ClearSelection();
        }
        void add()
        {
            try
            {
                string y1 = Localization.oledbcon;
                OleDbConnection baglanti1 = new OleDbConnection(y1);
                baglanti1.Open();
                string ekle1 = Localization.oledbaddbook;
                OleDbCommand komut1 = new OleDbCommand(ekle1, baglanti1);

                if (txt_author.Text == "")
                {
                    komut1.Parameters.AddWithValue(Localization._maingrid_oledname, txt_name.Text.ToString().Replace("'", "’"));
                    komut1.Parameters.AddWithValue(Localization._maingrid_oledauthor, "-");
                    komut1.Parameters.AddWithValue(Localization._maingrid_oledyear, txt_year.Text);

                    komut1.Parameters.AddWithValue(Localization.langoledb, cmb_lang.Text);
                    komut1.Parameters.AddWithValue(Localization._maingrid_oledshelfname, cmb_shelf.Text);
                    komut1.Parameters.AddWithValue(Localization._maingrid_oledshelffloor, cmb_floor.Text);
                    komut1.Parameters.AddWithValue(Localization._maingrid_oledshelfno, txt_bookid.Text);

                    komut1.ExecuteNonQuery();
                }
                else if (txt_year.Text == "")
                {
                    komut1.Parameters.AddWithValue(Localization._maingrid_oledname, txt_name.Text.ToString().Replace("'", "’"));
                    komut1.Parameters.AddWithValue(Localization._maingrid_oledauthor, txt_author.Text.ToString().Replace("'", "’"));
                    komut1.Parameters.AddWithValue(Localization._maingrid_oledyear, "-");

                    komut1.Parameters.AddWithValue(Localization.langoledb, cmb_lang.Text);
                    komut1.Parameters.AddWithValue(Localization._maingrid_oledshelfname, cmb_shelf.Text);
                    komut1.Parameters.AddWithValue(Localization._maingrid_oledshelffloor, cmb_floor.Text);
                    komut1.Parameters.AddWithValue(Localization._maingrid_oledshelfno, txt_bookid.Text);

                    komut1.ExecuteNonQuery();
                }
                else if (txt_author.Text == "" && txt_year.Text == "")
                {
                    komut1.Parameters.AddWithValue(Localization._maingrid_oledname, txt_name.Text.ToString().Replace("'", "’"));
                    komut1.Parameters.AddWithValue(Localization._maingrid_oledauthor, "-");
                    komut1.Parameters.AddWithValue(Localization._maingrid_oledyear, "-");

                    komut1.Parameters.AddWithValue(Localization.langoledb, cmb_lang.Text);
                    komut1.Parameters.AddWithValue(Localization._maingrid_oledshelfname, cmb_shelf.Text);
                    komut1.Parameters.AddWithValue(Localization._maingrid_oledshelffloor, cmb_floor.Text);
                    komut1.Parameters.AddWithValue(Localization._maingrid_oledshelfno, txt_bookid.Text);

                    komut1.ExecuteNonQuery();
                }
                else
                {
                    komut1.Parameters.AddWithValue(Localization._maingrid_oledname, txt_name.Text.ToString().Replace("'", "’"));
                    komut1.Parameters.AddWithValue(Localization._maingrid_oledauthor, txt_author.Text.ToString().Replace("'", "’"));
                    komut1.Parameters.AddWithValue(Localization._maingrid_oledyear, txt_year.Text);

                    komut1.Parameters.AddWithValue(Localization.langoledb, cmb_lang.Text);
                    komut1.Parameters.AddWithValue(Localization._maingrid_oledshelfname, cmb_shelf.Text);
                    komut1.Parameters.AddWithValue(Localization._maingrid_oledshelffloor, cmb_floor.Text);
                    komut1.Parameters.AddWithValue(Localization._maingrid_oledshelfno, txt_bookid.Text);

                    komut1.ExecuteNonQuery();
                }

                baglanti1.Close();
            }
            catch
            {
                MessageBox.Show(Localization.messageaddbookerror, Localization.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void update()
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;

                cmd.CommandText = Localization.oledbupdatebook;

                cmd.Parameters.AddWithValue(Localization._maingrid_oledname, txt_name.Text.ToString().Replace("'", "’"));
                cmd.Parameters.AddWithValue(Localization._maingrid_oledauthor, txt_author.Text.ToString().Replace("'", "’"));
                cmd.Parameters.AddWithValue(Localization._maingrid_oledyear, txt_year.Text);
                cmd.Parameters.AddWithValue(Localization.langoledb, cmb_lang.Text);
                cmd.Parameters.AddWithValue(Localization._maingrid_oledshelfname, cmb_shelf.Text);
                cmd.Parameters.AddWithValue(Localization._maingrid_oledshelffloor, cmb_floor.Text);
                cmd.Parameters.AddWithValue(Localization._maingrid_oledshelfno, txt_bookid.Text);
                cmd.Parameters.AddWithValue(Localization._maingrid_oledbid, txt_id.Text);
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch
            {
                MessageBox.Show(Localization.messageupdatebookerror, Localization.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void delete()
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;

                cmd.CommandText = Localization.oledbdeletebook;

                cmd.Parameters.AddWithValue(Localization._maingrid_oledbid, txt_id.Text);
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch
            {
                MessageBox.Show(Localization.messagedeletebookerror, Localization.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void correction()
        {
            fillthegrid();
            sayi_tüm();
            cleanleft();
            cleanright();

            cmb_lang.BackColor = Color.White;
            cmb_lang.ForeColor = Color.Black;
            cmb_lang_search.BackColor = Color.White;
            cmb_lang_search.ForeColor = Color.Black;
            cmb_addlang.BackColor = Color.White;
            cmb_addlang.ForeColor = Color.Black;

            cmb_shelf.BackColor = Color.White;
            cmb_shelf.ForeColor = Color.Black;
            cmb_shelf_search.BackColor = Color.White;
            cmb_shelf_search.ForeColor = Color.Black;
            cmb_addshelf.BackColor = Color.White;
            cmb_addshelf.ForeColor = Color.Black;

            cmb_floor.BackColor = Color.White;
            cmb_floor.ForeColor = Color.Black;
            cmb_addfloor.BackColor = Color.White;
            cmb_addfloor.ForeColor = Color.Black;
        }
        void view()
        {
            if (lang.Default.language == Localization.turkce)
            {
                Localization.Culture = new System.Globalization.CultureInfo(Localization._maintr);
            }
            else if (lang.Default.language == Localization.english)
            {
                Localization.Culture = new System.Globalization.CultureInfo(Localization._mainen);
            }

            lbl_createbook.Text = Localization._maingrid_headername;
            lbl_createauthor.Text = Localization._maingrid_headerauthor;
            lbl_createyear.Text = Localization._maingrid_headeryear;
            lbl_createlang.Text = Localization._maingrid_headerlang;
            lbl_createshelf.Text = Localization._maingrid_headershelf;
            lbl_createfloor.Text = Localization._maingrid_headerfloor;
            lbl_createno.Text = Localization._maingrid_headerno;
            lnk_lang.Text = Localization.lnk_lang;
            lnk_shelf.Text = Localization.lnk_shelf;
            lnk_floor.Text = Localization.lnk_floor;
            checkbox_editing.Text = Localization.checkbox_editing;
            this.Text = Localization._main;
            this.Refresh(); //that's work
            btn_add.Text = Localization.btn_add;
            btn_update.Text = Localization.btn_update;
            btn_delete.Text = Localization.btn_delete;
            lbledittitle.Text = Localization.editing;
            lnk_revertback.Text = Localization.revert;
            lblsearchtitle.Text = Localization.searchlbl;
            lblinfo.Text = Localization.warningedit;
            lbl_underline.Text = Localization.underline2;
            lbl_underline2.Text = Localization.underline;
            lblallbook.Text = Localization.allbook;
            lblmatchedsearch.Text = Localization.availablebook;
            lbllangsearch.Text = Localization.langlbl;
            lblyearsearch.Text = Localization.yearlbl;
            lblshelfsearch.Text = Localization.shelflbl;
            lblsearchnameorauthor.Text = Localization.nameorauthorlbl;
            rbyear1.Text = Localization.rbsingle;
            rbyear2.Text = Localization.rbspaced;
            lbl_libraryorderinfo.Text = Localization.lbl_libraryorderinfo;
            lbl_searchinfo.Text = Localization.lbl_searchinfo;
            lbl_orderinfo.Text = Localization.lbl_orderinfo;
            lbl_programmeinfo.Text = Localization.lbl_programmeinfo;
            lbl_otherissuesinfo.Text = Localization.lbl_otherissuesinfo;
            lbl_floorinfo.Text = Localization.lbl_floorinfo;
            lblinfo2.Text = Localization.infoaboutsystem;

            maingrid.Columns[0].HeaderText = Localization._maingrid_headername;
            maingrid.Columns[1].HeaderText = Localization._maingrid_headerauthor;
            maingrid.Columns[2].HeaderText = Localization._maingrid_headeryear;
            maingrid.Columns[3].HeaderText = Localization._maingrid_headerlang;
            maingrid.Columns[4].HeaderText = Localization._maingrid_headershelf;
            maingrid.Columns[5].HeaderText = Localization._maingrid_headerfloor;
            maingrid.Columns[6].HeaderText = Localization._maingrid_headerno;
        }
        void enform()
        {
            lbl_createbook.Location = new Point(20, 16);
            lbl_createbook.Size = new Size(48, 29);

            lbl_createauthor.Location = new Point(11, 51);
            lbl_createauthor.Size = new Size(57, 29);

            lbl_createyear.Location = new Point(33, 86);
            lbl_createyear.Size = new Size(35, 29);

            lbl_createlang.Location = new Point(1, 121);
            lbl_createlang.Size = new Size(68, 29);

            lbl_createshelf.Location = new Point(27, 156);
            lbl_createshelf.Size = new Size(41, 29);

            lbl_createfloor.Location = new Point(25, 191);
            lbl_createfloor.Size = new Size(43, 29);

            lnk_lang.Location = new Point(226, 121);
            lnk_lang.Size = new Size(100, 29);

            lnk_shelf.Location = new Point(226, 156);
            lnk_shelf.Size = new Size(100, 29);

            lnk_floor.Location = new Point(226, 191);
            lnk_floor.Size = new Size(100, 29);

            lblyearsearch.Location = new Point(78, 86);
            lblyearsearch.Size = new Size(35, 29);

            lbllangsearch.Location = new Point(46, 156);
            lbllangsearch.Size = new Size(66, 29);

            lblmatchedsearch.Location = new Point(7, 188);
            lblmatchedsearch.Size = new Size(104, 29);
        }
        void trform()
        {
            lbl_createbook.Location = new Point(29, 16);
            lbl_createbook.Size = new Size(39, 29);

            lbl_createauthor.Location = new Point(20, 51);
            lbl_createauthor.Size = new Size(48, 29);

            lbl_createyear.Location = new Point(42, 86);
            lbl_createyear.Size = new Size(26, 29);

            lbl_createlang.Location = new Point(37, 121);
            lbl_createlang.Size = new Size(31, 29);

            lbl_createshelf.Location = new Point(36, 156);
            lbl_createshelf.Size = new Size(32, 29);

            lbl_createfloor.Location = new Point(34, 191);
            lbl_createfloor.Size = new Size(34, 29);

            lnk_lang.Location = new Point(226, 121);
            lnk_lang.Size = new Size(100, 29);

            lnk_shelf.Location = new Point(226, 156);
            lnk_shelf.Size = new Size(100, 29);

            lnk_floor.Location = new Point(226, 191);
            lnk_floor.Size = new Size(100, 29);

            lblyearsearch.Location = new Point(87, 86);
            lblyearsearch.Size = new Size(26, 29);

            lbllangsearch.Location = new Point(86, 156);
            lbllangsearch.Size = new Size(27, 29);

            lblmatchedsearch.Location = new Point(16, 188);
            lblmatchedsearch.Size = new Size(97, 29);
        }
        void open()
        {
            lbl_createauthor.Visible = true;
            lbl_createbook.Visible = true;
            lbl_createfloor.Visible = true;
            lbl_createlang.Visible = true;
            lbl_createno.Visible = true;
            lbl_createshelf.Visible = true;
            lbl_createyear.Visible = true;
            txt_name.Visible = true;
            txt_author.Visible = true;
            txt_year.Visible = true;
            txt_bookid.Visible = true;
            cmb_lang.Visible = true;
            cmb_shelf.Visible = true;
            cmb_floor.Visible = true;
            lblinfo.Visible = true;
            btnclean.Visible = true;
            lnk_lang.Visible = true;
            lnk_shelf.Visible = true;
            lnk_floor.Visible = true;
        }
        void close()
        {
            txt_delshelf.Visible = false;
            txt_delfloor.Visible = false;
            txt_dellang.Visible = false;
            cmb_addshelf.Visible = false;
            cmb_addfloor.Visible = false;
            cmb_addlang.Visible = false;
            btn_addshelf.Visible = false;
            btn_delshelf.Visible = false;
            btn_addfloor.Visible = false;
            btn_delfloor.Visible = false;
            btn_addlang.Visible = false;
            btn_dellang.Visible = false;
            lbl_adding.Visible = false;
            lbl_deleting.Visible = false;
            btn_back.Visible = false;

            btn_delshelf.Location = new Point(30, 100);
            btn_delshelf.Size = new Size(1, 1);

            btn_addshelf.Location = new Point(30, 100);
            btn_addshelf.Size = new Size(1, 1);

            btn_delfloor.Location = new Point(30, 100);
            btn_delfloor.Size = new Size(1, 1);

            btn_addfloor.Location = new Point(30, 100);
            btn_addfloor.Size = new Size(1, 1);

            btn_dellang.Location = new Point(30, 100);
            btn_dellang.Size = new Size(1, 1);

            btn_addlang.Location = new Point(30, 100);
            btn_addlang.Size = new Size(1, 1);

            cmb_addshelf.Location = new Point(30, 100);
            cmb_addshelf.Size = new Size(1, 1);

            cmb_addfloor.Location = new Point(30, 100);
            cmb_addfloor.Size = new Size(1, 1);

            cmb_addlang.Location = new Point(30, 100);
            cmb_addlang.Size = new Size(1, 1);

            txt_delshelf.Location = new Point(30, 100);
            txt_delshelf.Size = new Size(1, 1);

            txt_delfloor.Location = new Point(30, 100);
            txt_delfloor.Size = new Size(1, 1);

            txt_dellang.Location = new Point(30, 100);
            txt_dellang.Size = new Size(1, 1);

            lbl_adding.Location = new Point(30, 100);
            lbl_adding.Size = new Size(1, 1);

            lbl_deleting.Location = new Point(30, 100);
            lbl_deleting.Size = new Size(1, 1);

            btn_back.Location = new Point(30, 100);
            btn_back.Size = new Size(1, 1);
        }
        void linkclick()
        {
            btn_add.Enabled = false;
            btn_update.Enabled = false;
            btn_delete.Enabled = false;
            btn_add.Style = MetroFramework.MetroColorStyle.White;
            btn_update.Style = MetroFramework.MetroColorStyle.White;
            btn_delete.Style = MetroFramework.MetroColorStyle.White;

            lbl_createbook.Visible = false;
            lbl_createauthor.Visible = false;
            lbl_createfloor.Visible = false;
            lbl_createlang.Visible = false;
            lbl_createno.Visible = false;
            lbl_createshelf.Visible = false;
            lbl_createyear.Visible = false;
            txt_name.Visible = false;
            txt_author.Visible = false;
            txt_year.Visible = false;
            txt_bookid.Visible = false;
            cmb_lang.Visible = false;
            cmb_shelf.Visible = false;
            cmb_floor.Visible = false;
            lblinfo.Visible = false;
            btnclean.Visible = false;
            lnk_lang.Visible = false;
            lnk_shelf.Visible = false;
            lnk_floor.Visible = false;
        }

        private void checkbox_editing_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_editing.Checked == true)
            {
                if (lbl_createauthor.Visible == false)
                {
                    btn_add.Enabled = false;
                    btn_update.Enabled = false;
                    btn_delete.Enabled = false;

                    btn_add.Style = MetroFramework.MetroColorStyle.White;
                    btn_update.Style = MetroFramework.MetroColorStyle.White;
                    btn_delete.Style = MetroFramework.MetroColorStyle.White;

                    groupBoxedit.Enabled = true;

                    cmb_addlang.Enabled = true;
                    txt_dellang.Enabled = true;
                    btn_addlang.Enabled = true;
                    btn_dellang.Enabled = true;

                    cmb_addfloor.Enabled = true;
                    txt_delfloor.Enabled = true;
                    btn_addfloor.Enabled = true;
                    btn_delfloor.Enabled = true;

                    cmb_addshelf.Enabled = true;
                    txt_delshelf.Enabled = true;
                    btn_addshelf.Enabled = true;
                    btn_delshelf.Enabled = true;
                }
                else
                {
                    openthemode();
                }
            }
            else
            {
                if (txt_name.Text != "" || txt_author.Text != "" || txt_year.Text != "" || txt_bookid.Text != "" || cmb_lang.Text != "" || cmb_floor.Text != "" || cmb_shelf.Text != "")
                {
                    checkbox_editing.Checked = true;
                    MessageBox.Show(Localization.warningaboutupdate, Localization.warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (lbl_createauthor.Visible == false)
                    {
                        btn_add.Enabled = false;
                        btn_update.Enabled = false;
                        btn_delete.Enabled = false;

                        btn_add.Style = MetroFramework.MetroColorStyle.White;
                        btn_update.Style = MetroFramework.MetroColorStyle.White;
                        btn_delete.Style = MetroFramework.MetroColorStyle.White;

                        groupBoxedit.Enabled = false;

                        cmb_addlang.Enabled = false;
                        txt_dellang.Enabled = false;
                        btn_addlang.Enabled = false;
                        btn_dellang.Enabled = false;

                        cmb_addfloor.Enabled = false;
                        txt_delfloor.Enabled = false;
                        btn_addfloor.Enabled = false;
                        btn_delfloor.Enabled = false;

                        cmb_addshelf.Enabled = false;
                        txt_delshelf.Enabled = false;
                        btn_addshelf.Enabled = false;
                        btn_delshelf.Enabled = false;
                    }
                    else
                    {
                        closethemode();
                        checkbox_editing.Checked = false;
                    }
                }
            }
        }
        private void pict_changelang_Click(object sender, EventArgs e)
        {
            if (lang.Default.language == Localization.turkce)
            {
                pict_changelang.Image = Properties.Resources.en;
                Localization.Culture = new System.Globalization.CultureInfo(Localization._mainen);
                lang.Default.language = Localization.english;
                lang.Default.Save();
                enform();
                view();

                if (btn_addlang.Visible == true)
                {
                    lbl_adding.Location = new Point(70, 101);
                    lbl_adding.Size = new Size(120, 29);

                    lbl_deleting.Location = new Point(73, 136);
                    lbl_deleting.Size = new Size(117, 29);

                    lbl_adding.Text = Localization.lbladdlang;
                    lbl_deleting.Text = Localization.lbldellang;
                    btn_addlang.Text = Localization.btnadd;
                    btn_dellang.Text = Localization.btndel;
                    btn_back.Text = Localization.btnback;
                }
                else if (btn_addshelf.Visible == true)
                {
                    lbl_adding.Text = Localization.lbladdshelf;
                    lbl_deleting.Text = Localization.lbldelshelf;
                    btn_addshelf.Text = Localization.btnadd;
                    btn_delshelf.Text = Localization.btndel;
                    btn_back.Text = Localization.btnback;
                }
                else if (btn_addfloor.Visible == true)
                {
                    lbl_adding.Text = Localization.lbladdfloor;
                    lbl_deleting.Text = Localization.lbldelfloor;
                    btn_addfloor.Text = Localization.btnadd;
                    btn_delfloor.Text = Localization.btndel;
                    btn_back.Text = Localization.btnback;
                }
            }
            else if (lang.Default.language == Localization.english)
            {
                pict_changelang.Image = Properties.Resources.tr;
                Localization.Culture = new System.Globalization.CultureInfo(Localization._maintr);
                lang.Default.language = Localization.turkce;
                lang.Default.Save();
                trform();
                view();

                if (btn_addlang.Visible == true)
                {
                    lbl_adding.Location = new Point(100, 101);
                    lbl_adding.Size = new Size(90, 29);

                    lbl_deleting.Location = new Point(103, 136);
                    lbl_deleting.Size = new Size(87, 29);

                    lbl_adding.Text = Localization.lbladdlang;
                    lbl_deleting.Text = Localization.lbldellang;
                    btn_addlang.Text = Localization.btnadd;
                    btn_dellang.Text = Localization.btndel;
                    btn_back.Text = Localization.btnback;
                }
                else if (btn_addshelf.Visible == true)
                {
                    lbl_adding.Text = Localization.lbladdshelf;
                    lbl_deleting.Text = Localization.lbldelshelf;
                    btn_addshelf.Text = Localization.btnadd;
                    btn_delshelf.Text = Localization.btndel;
                    btn_back.Text = Localization.btnback;
                }
                else if (btn_addfloor.Visible == true)
                {
                    lbl_adding.Text = Localization.lbladdfloor;
                    lbl_deleting.Text = Localization.lbldelfloor;
                    btn_addfloor.Text = Localization.btnadd;
                    btn_delfloor.Text = Localization.btndel;
                    btn_back.Text = Localization.btnback;
                }
            }
        }
        private void main_Load(object sender, EventArgs e)
        {
            closethemode();
            fillthegrid();
            designthegrid();
            fillthelang();
            fillthefloor();
            filltheshelf();

            lbl_all.Text = maingrid.Rows.Count.ToString();
            txt_year.MaxLength = 4;
            txt_bookid.MaxLength = 4;
            lbl_libraryorderinfo.DisplayFocus = false;

            if (lang.Default.language == Localization.turkce)
            {
                pict_changelang.Image = Properties.Resources.tr;
                view();
                trform();
            }
            else if (lang.Default.language == Localization.english)
            {
                pict_changelang.Image = Properties.Resources.en;
                view();
                enform();
            }
        }
        private void lnk_revertback_Click(object sender, EventArgs e)
        {
            maingrid.Columns[0].Width = 350;
            maingrid.Columns[1].Width = 150;
            maingrid.Columns[2].Width = 40;
            maingrid.Columns[3].Width = 70;
            maingrid.Columns[4].Width = 130;
            maingrid.Columns[5].Width = 30;
            maingrid.Columns[6].Width = 50;

            maingrid.Sort(maingrid.Columns[0], ListSortDirection.Ascending);
            maingrid.ClearSelection();
        }
        private void maingrid_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkbox_editing.Checked == false)
            {

            }
            else
            {
                txt_name.Text = maingrid.CurrentRow.Cells[0].Value.ToString();
                txt_author.Text = maingrid.CurrentRow.Cells[1].Value.ToString();
                txt_year.Text = maingrid.CurrentRow.Cells[2].Value.ToString();
                cmb_lang.Text = maingrid.CurrentRow.Cells[3].Value.ToString();
                cmb_shelf.Text = maingrid.CurrentRow.Cells[4].Value.ToString();
                cmb_floor.Text = maingrid.CurrentRow.Cells[5].Value.ToString();
                txt_bookid.Text = maingrid.CurrentRow.Cells[6].Value.ToString();
                txt_id.Text = maingrid.CurrentRow.Cells[7].Value.ToString();
            }
        }
        private void maingrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            maingrid.ClearSelection();
            btnclean.PerformClick();
        }
        private void lbl_otherissuesinfo_Click(object sender, EventArgs e)
        {
            suggestions x = new suggestions();
            x.Show();
        }
        private void lbl_programmeinfo_Click(object sender, EventArgs e)
        {
            programmersnote x = new programmersnote();
            x.Show();
        }
        private void lbl_floorinfo_Click(object sender, EventArgs e)
        {
            aboutfloorsystem x = new aboutfloorsystem();
            x.Show();
        }
        private void lbl_orderinfo_Click(object sender, EventArgs e)
        {
            aboutediting x = new aboutediting();
            x.Show();
        }
        private void lbl_searchinfo_Click(object sender, EventArgs e)
        {
            aboutsearching x = new aboutsearching();
            x.Show();
        }
        private void lbl_libraryorderinfo_Click(object sender, EventArgs e)
        {
            aboutlibrarysystem x = new aboutlibrarysystem();
            x.Show();
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_name.Text) == true || string.IsNullOrEmpty(cmb_shelf.Text) == true || string.IsNullOrEmpty(cmb_floor.Text) == true || string.IsNullOrEmpty(txt_bookid.Text) == true || string.IsNullOrEmpty(cmb_lang.Text) == true)
            {
                MessageBox.Show(Localization._mainwarningemptybox, Localization.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txt_id.Text) == true)
            {
                MessageBox.Show(Localization._mainwarningdeletebook, Localization.warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dialog = MessageBox.Show(Localization.questiondeletebook, Localization.question, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    new Thread(() => new loading().ShowDialog()).Start();

                    delete();
                    correction();

                    loading f = new loading();
                    f = (loading)Application.OpenForms[Localization.loadloading];
                    f.Close();

                    txt_name.Focus();

                    MessageBox.Show(Localization._mainsuccessfulldeletebook, Localization.information, MessageBoxButtons.OK, MessageBoxIcon.Information); //catch kısmı*/
                }
                else
                {
                    MessageBox.Show(Localization.messagecancel);
                }
            }
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_name.Text) == true || string.IsNullOrEmpty(cmb_shelf.Text) == true || string.IsNullOrEmpty(cmb_floor.Text) == true || string.IsNullOrEmpty(txt_bookid.Text) == true || string.IsNullOrEmpty(cmb_lang.Text) == true)
            {
                MessageBox.Show(Localization._mainwarningemptybox, Localization.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txt_id.Text) == true)
            {
                MessageBox.Show(Localization._mainwarningupdatebook, Localization.warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_name.Text == maingrid.CurrentRow.Cells[0].Value.ToString() && txt_author.Text == maingrid.CurrentRow.Cells[1].Value.ToString() && txt_year.Text == maingrid.CurrentRow.Cells[2].Value.ToString() && txt_bookid.Text == maingrid.CurrentRow.Cells[5].Value.ToString() && cmb_lang.Text == maingrid.CurrentRow.Cells[7].Value.ToString() && cmb_shelf.Text == maingrid.CurrentRow.Cells[3].Value.ToString() && cmb_floor.Text == maingrid.CurrentRow.Cells[4].Value.ToString())
            {
                MessageBox.Show(Localization.warningupdate, Localization.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dialog = MessageBox.Show(Localization.questionupdatebook, Localization.question, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    new Thread(() => new loading().ShowDialog()).Start();

                    update();
                    correction();

                    loading f = new loading();
                    f = (loading)Application.OpenForms[Localization.loadloading];
                    f.Close();

                    txt_name.Focus();

                    MessageBox.Show(Localization._mainsuccessfullupdatebook, Localization.information, MessageBoxButtons.OK, MessageBoxIcon.Information); //catch kısmı
                }
                else
                {
                    MessageBox.Show(Localization.messagecancel);
                }
            }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_name.Text) == true || string.IsNullOrEmpty(cmb_shelf.Text) == true || string.IsNullOrEmpty(cmb_floor.Text) == true || string.IsNullOrEmpty(txt_bookid.Text) == true || string.IsNullOrEmpty(cmb_lang.Text))
            {
                MessageBox.Show(Localization._mainwarningemptybox, Localization.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txt_id.Text) == false)
            {
                MessageBox.Show(Localization._mainwarningaddbook, Localization.warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dialog = MessageBox.Show(Localization.questionaddbook, Localization.question, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    new Thread(() => new loading().ShowDialog()).Start();

                    add();
                    correction();

                    loading f = new loading();
                    f = (loading)Application.OpenForms[Localization.loadloading];
                    f.Close();

                    txt_name.Focus();

                    MessageBox.Show(Localization._mainsuccessfulladdbook, Localization.information, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(Localization.messagecancel);
                }
            }
        }
        private void btnclean_Click(object sender, EventArgs e)
        {
            cleanleft();
            maingrid.ClearSelection();
        }
        private void btnclean2_Click(object sender, EventArgs e)
        {
            cleanright();
            maingrid.ClearSelection();
        }
        private void txt_bookid_Leave(object sender, EventArgs e)
        {
            btn_add.Focus();
        }
        private void txt_bookid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void txt_year_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void lnk_floor_Click(object sender, EventArgs e)
        {
            fillthefloor();
            linkclick();

            txt_delfloor.Visible = true;
            cmb_addfloor.Visible = true;
            btn_addlang.Visible = false;
            btn_dellang.Visible = false;
            btn_addshelf.Visible = false;
            btn_delshelf.Visible = false;
            btn_addfloor.Visible = true;
            btn_delfloor.Visible = true;
            lbl_adding.Visible = true;
            lbl_deleting.Visible = true;
            btn_back.Visible = true;

            lbl_adding.Text = Localization.lbladdfloor;
            lbl_deleting.Text = Localization.lbldelfloor;
            btn_addfloor.Text = Localization.btnadd;
            btn_delfloor.Text = Localization.btndel;
            btn_back.Text = Localization.btnback;
            btn_addfloor.BringToFront();
            btn_delfloor.BringToFront();

            btn_delfloor.Location = new Point(339, 136);
            btn_delfloor.Size = new Size(75, 29);

            btn_addfloor.Location = new Point(339, 101);
            btn_addfloor.Size = new Size(75, 29);

            btn_back.Location = new Point(339, 171);
            btn_back.Size = new Size(75, 29);

            cmb_addfloor.Location = new Point(196, 136);
            cmb_addfloor.Size = new Size(137, 29);

            txt_delfloor.Location = new Point(196, 101);
            txt_delfloor.Size = new Size(138, 29);

            lbl_adding.Location = new Point(100, 101);
            lbl_adding.Size = new Size(90, 29);

            lbl_deleting.Location = new Point(103, 136);
            lbl_deleting.Size = new Size(87, 29);
        }
        private void lnk_shelf_Click(object sender, EventArgs e)
        {
            filltheshelf();
            linkclick();

            txt_delshelf.Visible = true;
            cmb_addshelf.Visible = true;
            btn_addlang.Visible = false;
            btn_dellang.Visible = false;
            btn_addfloor.Visible = false;
            btn_delfloor.Visible = false;
            btn_addshelf.Visible = true;
            btn_delshelf.Visible = true;
            lbl_adding.Visible = true;
            lbl_deleting.Visible = true;
            btn_back.Visible = true;

            lbl_adding.Text = Localization.lbladdshelf;
            lbl_deleting.Text = Localization.lbldelshelf;
            btn_addshelf.Text = Localization.btnadd;
            btn_delshelf.Text = Localization.btndel;
            btn_back.Text = Localization.btnback;
            btn_addshelf.BringToFront();
            btn_delshelf.BringToFront();

            btn_delshelf.Location = new Point(339, 136);
            btn_delshelf.Size = new Size(75, 29);

            btn_addshelf.Location = new Point(339, 101);
            btn_addshelf.Size = new Size(75, 29);

            btn_back.Location = new Point(339, 171);
            btn_back.Size = new Size(75, 29);

            cmb_addshelf.Location = new Point(196, 136);
            cmb_addshelf.Size = new Size(137, 29);

            txt_delshelf.Location = new Point(196, 101);
            txt_delshelf.Size = new Size(138, 29);

            lbl_adding.Location = new Point(97, 101);
            lbl_adding.Size = new Size(93, 29);

            lbl_deleting.Location = new Point(103, 136);
            lbl_deleting.Size = new Size(87, 29);
        }
        private void lnk_lang_Click(object sender, EventArgs e)
        {
            fillthelang();
            linkclick();

            txt_dellang.Visible = true;
            cmb_addlang.Visible = true;
            btn_addlang.Visible = true;
            btn_dellang.Visible = true;
            btn_addshelf.Visible = false;
            btn_delshelf.Visible = false;
            btn_addfloor.Visible = false;
            btn_delfloor.Visible = false;
            lbl_adding.Visible = true;
            lbl_deleting.Visible = true;
            btn_back.Visible = true;

            lbl_adding.Text = Localization.lbladdlang;
            lbl_deleting.Text = Localization.lbldellang;
            btn_addlang.Text = Localization.btnadd;
            btn_dellang.Text = Localization.btndel;
            btn_back.Text = Localization.btnback;
            btn_addlang.BringToFront();
            btn_dellang.BringToFront();

            btn_dellang.Location = new Point(339, 136);
            btn_dellang.Size = new Size(75, 29);

            btn_addlang.Location = new Point(339, 101);
            btn_addlang.Size = new Size(75, 29);

            btn_back.Location = new Point(339, 171);
            btn_back.Size = new Size(75, 29);

            cmb_addlang.Location = new Point(196, 136);
            cmb_addlang.Size = new Size(137, 29);

            txt_dellang.Location = new Point(196, 101);
            txt_dellang.Size = new Size(138, 29);

            if (lang.Default.language == Localization.turkce)
            {
                lbl_adding.Location = new Point(100, 101);
                lbl_adding.Size = new Size(90, 29);

                lbl_deleting.Location = new Point(103, 136);
                lbl_deleting.Size = new Size(87, 29);
            }
            else if (lang.Default.language == Localization.english)
            {
                lbl_adding.Location = new Point(70, 101);
                lbl_adding.Size = new Size(120, 29);

                lbl_deleting.Location = new Point(73, 136);
                lbl_deleting.Size = new Size(117, 29);
            }
        }
        private void cmb_lang_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchprocesses();
            maingrid.ClearSelection();

            if (txt_search.Text == "" && cmb_shelf_search.Text == "" && txt_year1.Text == "" && txt_year2.Text == "" && cmb_lang_search.Text == "")
            {
                lbl_matched.Text = "";
            }
        }
        private void rbyear1_CheckedChanged(object sender, EventArgs e)
        {
            txt_year2.Visible = false;
        }
        private void rbyear2_CheckedChanged(object sender, EventArgs e)
        {
            txt_year2.Visible = true;
        }
        private void txt_year1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void txt_year1_TextChanged(object sender, EventArgs e)
        {
            searchprocesses();
            maingrid.ClearSelection();

            if (txt_search.Text == "" && cmb_shelf_search.Text == "" && txt_year1.Text == "" && txt_year2.Text == "" && cmb_lang_search.Text == "")
            {
                lbl_matched.Text = "";
            }
        }
        private void txt_year2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void txt_year2_TextChanged(object sender, EventArgs e)
        {
            searchprocesses();
            maingrid.ClearSelection();

            if (txt_search.Text == "" && cmb_shelf_search.Text == "" && txt_year1.Text == "" && txt_year2.Text == "" && cmb_lang_search.Text == "")
            {
                lbl_matched.Text = "";
            }
        }
        private void cmb_shelf_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchprocesses();
            maingrid.ClearSelection();

            if (txt_search.Text == "" && cmb_shelf_search.Text == "" && txt_year1.Text == "" && txt_year2.Text == "" && cmb_lang_search.Text == "")
            {
                lbl_matched.Text = "";
            }
        }
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            searchprocesses();
            maingrid.ClearSelection();

            if (txt_search.Text == "" && cmb_shelf_search.Text == "" && txt_year1.Text == "" && txt_year2.Text == "" && cmb_lang_search.Text == "")
            {
                lbl_matched.Text = "";
            }
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            cleanleft();
            cleanright();
            cmb_addlang.SelectedIndex = -1;
            cmb_addfloor.SelectedIndex = -1;
            cmb_addshelf.SelectedIndex = -1;

            btn_add.Enabled = true;
            btn_update.Enabled = true;
            btn_delete.Enabled = true;
            btn_add.Style = MetroFramework.MetroColorStyle.Blue;
            btn_update.Style = MetroFramework.MetroColorStyle.Blue;
            btn_delete.Style = MetroFramework.MetroColorStyle.Blue;

            close();

            lbl_createauthor.Visible = true;
            lbl_createbook.Visible = true;
            lbl_createfloor.Visible = true;
            lbl_createlang.Visible = true;
            lbl_createno.Visible = true;
            lbl_createshelf.Visible = true;
            lbl_createyear.Visible = true;
            txt_name.Visible = true;
            txt_author.Visible = true;
            txt_year.Visible = true;
            txt_bookid.Visible = true;
            cmb_lang.Visible = true;
            cmb_shelf.Visible = true;
            cmb_floor.Visible = true;
            lblinfo.Visible = true;
            btnclean.Visible = true;
            lnk_lang.Visible = true;
            lnk_shelf.Visible = true;
            lnk_floor.Visible = true;
        }
        private void btn_addlang_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_dellang.Text) == true)
            {
                MessageBox.Show(Localization._mainwarningemptybox, Localization.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cmb_addlang.SelectedIndex = -1;

                DialogResult x = MessageBox.Show(Localization.questionaddlang, Localization.question, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (x == DialogResult.Yes)
                {
                    string vtyolu = Localization.oledbcon;
                    OleDbConnection baglanti = new OleDbConnection(vtyolu);
                    baglanti.Open();
                    string ekle = Localization.oledbaddlang;
                    OleDbCommand komut = new OleDbCommand(ekle, baglanti);
                    komut.Parameters.AddWithValue(Localization.oledbname, txt_dellang.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    txt_dellang.Clear();
                    fillthelang();
                    open();
                    close();
                }
            }
        }
        private void btn_dellang_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmb_addlang.Text) == true)
            {
                MessageBox.Show(Localization._mainwarningemptybox, Localization.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txt_dellang.Clear();

                DialogResult x = MessageBox.Show(Localization.questiondeletelang, Localization.question, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (x == DialogResult.Yes)
                {
                    string vtyolu = Localization.oledbcon;
                    OleDbConnection baglanti = new OleDbConnection(vtyolu);
                    baglanti.Open();
                    string sorgu = Localization.oledbdeletelang;
                    OleDbCommand komut = new OleDbCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue(Localization.oledbname, cmb_addlang.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    cmb_addlang.SelectedIndex = -1;
                    cmb_addlang.Items.Clear();
                    fillthelang();
                    open();
                    close();
                }
            }
        }
        private void btn_addfloor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_delfloor.Text) == true)
            {
                MessageBox.Show(Localization._mainwarningemptybox, Localization.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cmb_addfloor.SelectedIndex = -1;

                DialogResult x = MessageBox.Show(Localization.questionaddfloor, Localization.question, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (x == DialogResult.Yes)
                {
                    string vtyolu = Localization.oledbcon;
                    OleDbConnection baglanti = new OleDbConnection(vtyolu);
                    baglanti.Open();
                    string ekle = Localization.oledbaddfloor;
                    OleDbCommand komut = new OleDbCommand(ekle, baglanti);
                    komut.Parameters.AddWithValue(Localization.oledbname, txt_delfloor.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    txt_delfloor.Clear();
                    fillthefloor();
                    open();
                    close();
                }
            }
        }
        private void btn_delfloor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmb_addfloor.Text) == true)
            {
                MessageBox.Show(Localization._mainwarningemptybox, Localization.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txt_delfloor.Clear();

                DialogResult x = MessageBox.Show(Localization.questiondeletefloor, Localization.question, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (x == DialogResult.Yes)
                {
                    string vtyolu = Localization.oledbcon;
                    OleDbConnection baglanti = new OleDbConnection(vtyolu);
                    baglanti.Open();
                    string sorgu = Localization.oledbdeletefloor;
                    OleDbCommand komut = new OleDbCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue(Localization.oledbname, cmb_addfloor.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    cmb_addfloor.SelectedIndex = -1;
                    cmb_addfloor.Items.Clear();
                    fillthefloor();
                    open();
                    close();
                }
            }
        }
        private void btn_addshelf_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_delshelf.Text) == true)
            {
                MessageBox.Show(Localization._mainwarningemptybox, Localization.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cmb_addshelf.SelectedIndex = -1;
                cmb_addshelf.Items.Clear();

                DialogResult x = MessageBox.Show(Localization.questionshelfadd, Localization.question, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (x == DialogResult.Yes)
                {
                    string vtyolu = Localization.oledbcon;
                    OleDbConnection baglanti = new OleDbConnection(vtyolu);
                    baglanti.Open();
                    string ekle = Localization.oledbaddshelf;
                    OleDbCommand komut = new OleDbCommand(ekle, baglanti);
                    komut.Parameters.AddWithValue(Localization.oledbname, txt_delshelf.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    txt_delshelf.Clear();
                    filltheshelf();
                    open();
                    close();
                }
            }
        }
        private void btn_delshelf_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmb_addshelf.Text) == true)
            {
                MessageBox.Show(Localization._mainwarningemptybox, Localization.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txt_delshelf.Clear();

                DialogResult x = MessageBox.Show(Localization.questionshelfdelete, Localization.question, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (x == DialogResult.Yes)
                {
                    string vtyolu = Localization.oledbcon;
                    OleDbConnection baglanti = new OleDbConnection(vtyolu);
                    baglanti.Open();
                    string sorgu = Localization.oledbdeleteshelf;
                    OleDbCommand komut = new OleDbCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue(Localization.oledbname, cmb_addshelf.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    cmb_addshelf.SelectedIndex = -1;
                    cmb_addshelf.Items.Clear();
                    filltheshelf();
                    open();
                    close();
                }
            }
        }

    }
}
