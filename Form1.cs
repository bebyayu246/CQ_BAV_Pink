using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PraktikumADO
{
    public partial class Form1: Form
    {
        SqlConnection conn;
        SqlCommand cmd;

        public Form1()
        {
            InitializeComponent();
        }

        //membuat method koneksi database
        private void koneksi()
        {
            conn = new SqlConnection(
                "Data Source=LAPTOP-V3CL2RKG\\BEBEB;Initial Catalog=DBAkademikADO;Integrated Security=True" );
        }

        // Praktikum 1 - Membuka koneksi ke database
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                conn.Open();

                MessageBox.Show("Koneksi ke database berhasil");

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
