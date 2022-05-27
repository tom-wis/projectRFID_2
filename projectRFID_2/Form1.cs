using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace projectRFID_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetForm1();
            dataGridView2.DataSource = GetForm2();
        }
        private DataTable GetForm1()
        {
            DataTable dtForm1 = new DataTable();
            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Users", con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    dtForm1.Load(reader);

                }

            }
            return dtForm1;
        }
            public DataTable GetForm2()
            {
                DataTable dtForm2 = new DataTable();
                string connString1 = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
                using (SqlConnection con = new SqlConnection(connString1))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Registries", con))
                    {
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        dtForm2.Load(reader);

                    }

                }
                return dtForm2;
            }
        }
    }

