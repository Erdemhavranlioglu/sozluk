using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace dersbindin
{
    public partial class Form1 : Form
    {
        OleDbConnection baglantı = new OleDbConnection("Provider=microsoft.ACE.OLEDB.12.0;Data Source ="+Application.StartupPath+"/sozluk.accdb");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                if (baglantı.State == ConnectionState.Closed) baglantı.Open();
                OleDbDataAdapter adp = new OleDbDataAdapter("select*from tablo1", baglantı);
                adp.Fill(ds);
                lstsonuc.DataSource = ds.Tables[0];
                lstsonuc.DisplayMember = "ingilizce";
                txtsonuc.DataBindings.Clear();
                txtsonuc.DataBindings.Add("text", ds.Tables[0], "türkçe");
                baglantı.Close();
                lstsonuc.SelectedIndex = 0;
                txting.Text = lstsonuc.Text;
                txtturk.Text = txtsonuc.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                baglantı.Close();

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                if (baglantı.State == ConnectionState.Closed) baglantı.Open();
                OleDbDataAdapter adp = new OleDbDataAdapter("select*from tablo1 where ingilizce LIKE'"+txtaranan.Text+"%'", baglantı);
                adp.Fill(ds);
                lstsonuc.DataSource = ds.Tables[0];
                lstsonuc.DisplayMember = "ingilizce";
                txtsonuc.DataBindings.Clear();
                txtsonuc.DataBindings.Add("text", ds.Tables[0], "türkçe");
                baglantı.Close();
                if (lstsonuc.Items.Count > 0)
                {
                    lstsonuc.SelectedIndex = 0;
                    txting.Text = lstsonuc.Text;
                    txtturk.Text = txtsonuc.Text;
                }
                else
                {
                    txting.Clear();
                    txtturk.Clear();
                    txtsonuc.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                baglantı.Close();

            }
        }

        private void lstsonuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            txting.Text = lstsonuc.Text;
            txtturk.Text = txtsonuc.Text;
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ayarlar_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }
    }
}
