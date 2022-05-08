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
    public partial class Form2 : Form
    {
        OleDbConnection baglantı = new OleDbConnection("Provider=microsoft.ACE.OLEDB.12.0;Data Source =" + Application.StartupPath + "/sozluk.accdb");

        BindingManagerBase bmb;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
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
                bmb = this.BindingContext[ds.Tables[0]];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                baglantı.Close();

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txting.Text)|string.IsNullOrEmpty(txtturk.Text))
            {
                MessageBox.Show("lütfen bütün alanları doldurunuz", "hata");
                return;
            }
            try
            {
                if (baglantı.State == ConnectionState.Closed) baglantı.Open();
                DataSet ds = new DataSet();
                OleDbDataAdapter adp=new OleDbDataAdapter("insert into tablo1(ingilizce,türkçe)values('"+txting.Text+"','"+txtturk.Text+"')",baglantı);
                adp.Fill(ds);
                ds.Clear();
                adp = new OleDbDataAdapter("select*from tablo1", baglantı);
                adp.Fill(ds);
                lstsonuc.DataSource = ds.Tables[0];
                lstsonuc.DisplayMember = "ingilizce";
                txtsonuc.DataBindings.Clear();
                txtsonuc.DataBindings.Add("text", ds.Tables[0], "türkçe");
                bmb = this.BindingContext[ds.Tables[0]];
                baglantı.Close();
                txting.Clear();
                txtturk.Clear();
                MessageBox.Show("kayıt eklendi", "bilgi");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglantı.State == ConnectionState.Closed) baglantı.Open();
                DataSet ds = new DataSet();
                OleDbDataAdapter adp = new OleDbDataAdapter("update tablo1 set türkçe='" + txtturk.Text + "'where ingilizce='" + txting.Text + "'", baglantı);
                adp.Fill(ds);
                ds.Clear();
                adp = new OleDbDataAdapter("select*from tablo1", baglantı);
                adp.Fill(ds);
                lstsonuc.DataSource = ds.Tables[0];
                lstsonuc.DisplayMember = "ingilizce";
                txtsonuc.DataBindings.Clear();
                txtsonuc.DataBindings.Add("text", ds.Tables[0], "türkçe");
                bmb = this.BindingContext[ds.Tables[0]];
                baglantı.Close();
                txting.Clear();
                txtturk.Clear();
                MessageBox.Show("kayıt güncellendi", "bilgi");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglantı.State == ConnectionState.Closed) baglantı.Open();
                DataSet ds = new DataSet();
                OleDbDataAdapter adp = new OleDbDataAdapter("delete from tablo1 where ingilizce='"+txting.Text+"'",baglantı);
                adp.Fill(ds);
                ds.Clear();
                adp = new OleDbDataAdapter("select*from tablo1", baglantı);
                adp.Fill(ds);
                lstsonuc.DataSource = ds.Tables[0];
                lstsonuc.DisplayMember = "ingilizce";
                txtsonuc.DataBindings.Clear();
                txtsonuc.DataBindings.Add("text", ds.Tables[0], "türkçe");
                bmb = this.BindingContext[ds.Tables[0]];
                baglantı.Close();
                txting.Clear();
                txtturk.Clear();
                MessageBox.Show("kayıt silindi", "bilgi");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();

        }

        private void lstsonuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            txting.Text = lstsonuc.Text;
            txtturk.Text = lstsonuc.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (bmb.Position == 0)
                MessageBox.Show("Zaten ilk kayıttasınız");
            else
                bmb.Position = 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (bmb.Position == bmb.Count - 1)
                MessageBox.Show("zaten son kayıttasınız");
            else
                bmb.Position = bmb.Count - 1;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (bmb.Position == bmb.Count - 1)
                MessageBox.Show("son kayıttasınız");
            else
                bmb.Position = bmb.Position + 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txting.Clear();
            txtturk.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (bmb.Position == 0)
                MessageBox.Show("ilk kayıttasınız");
            else
                bmb.Position = bmb.Position - 1;
        }
    }
}
