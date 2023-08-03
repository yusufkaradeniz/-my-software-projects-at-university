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



namespace Teklas
{
    public partial class Form1 : Form
    {
        OleDbConnection conn;
        OleDbDataAdapter adapter;
        OleDbCommand cmd;
        DataTable dt;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }
        void rapordoldur()
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=okul.accdb");
            dt = new DataTable();
            adapter = new OleDbDataAdapter("SElect *from rapor", conn);
            ds = new DataSet();
            conn.Open();
            adapter.Fill(ds, "rapor");
            dataGridView2.DataSource = ds.Tables["rapor"];
            conn.Close();
        }
        void griddoldur()
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=okul.accdb");
           dt= new DataTable();
            adapter = new OleDbDataAdapter("SElect *from ogrenci", conn);
            ds = new DataSet();
            conn.Open();
            adapter.Fill(ds, "ogrenci");
            dataGridView1.DataSource = ds.Tables["ogrenci"];
            conn.Close();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
            griddoldur();
            rapordoldur();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO ogrenci (Name,Surname,BirthDate,Class,ClassTeacher) VALUES" + 
                "(@name,@surname,@birthdate,@class,@classteacher)";
            cmd = new OleDbCommand(query,conn);
            cmd.Parameters.AddWithValue("@name",ad.Text);
            cmd.Parameters.AddWithValue("@surname", syad.Text);
            cmd.Parameters.AddWithValue("@birthdate", dtarih.Value);
            cmd.Parameters.AddWithValue("@class", snf.Text);
            cmd.Parameters.AddWithValue("@classteacher", snfog.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close() ;
            MessageBox.Show("Öğrenci Eklenmiştir");
            griddoldur();

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            syad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dtarih.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            snf.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            snfog.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "UPDATE ogrenci " +
            "SET Name=@name,Surname=@surname,BirthDate=@birthdate,Class=@class,ClassTeacher=@classteacher " +
            "WHERE Id=@id";
            cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", ad.Text);
            cmd.Parameters.AddWithValue("@surname", syad.Text);
            cmd.Parameters.AddWithValue("@birthdate", dtarih.Value);
            cmd.Parameters.AddWithValue("@class", snf.Text);
            cmd.Parameters.AddWithValue("@classteacher", snfog.Text);
            cmd.Parameters.AddWithValue("@id",Convert.ToInt32(Id.Text));
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Öğrenci Bilgisi Güncellenmiştir");
            griddoldur();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM ogrenci Where Id=@id ";


            cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(Id.Text));
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Öğrenci Bilgisi Silinmiştir");
            griddoldur();
        }

        private void ara_TextChanged(object sender, EventArgs e)
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=okul.accdb");
            adapter = new OleDbDataAdapter("SElect *from ogrenci where Name like '" + ara.Text + "%'", conn);
            ds = new DataSet();
            conn.Open();
            adapter.Fill(ds, "ogrenci");
            dataGridView1.DataSource = ds.Tables["ogrenci"];
            conn.Close();
        }

        private void snf_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(snf.SelectedIndex == 0)
            {

                snfog.Items.Clear();
                snfog.Text = "";
                snfog.Items.Add("DERMAN KURTOĞLU");
            }
            else if (snf.SelectedIndex == 1)
            {
                snfog.Items.Clear();
                snfog.Text = "";
                snfog.Items.Add("MEHMET ÖZGÜR ŞİVİL");

            }
            else if (snf.SelectedIndex == 2)
            {
                snfog.Items.Clear();
                snfog.Text = "";
                snfog.Items.Add("MÜGE BAYSAL");
            }
            else
            {

            }
        }
    }
}
