using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGrupal
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            Form lol = new Form1();
            lol.Show();
            this.Close();
        }

        private void btnc1_Click(object sender, EventArgs e)
        {
            Form lol = new Form1();
            lol.Show();
            this.Close();
        }

        private void btnc2_Click(object sender, EventArgs e)
        {
            Form lol = new Form1();
            lol.Show();
            this.Close();
        }

        private void picAdd_Click(object sender, EventArgs e)
        {
            if (txtn.Text == "")
            {
                MessageBox.Show("Todos los campos son obligatorios");
            }
            else if (txtm.Text == "")
            {
                MessageBox.Show("Todos los campos son obligatorios");
            }
            else if (txtp.Text == "")
            {
                MessageBox.Show("Todos los campos son obligatorios");
            }
            else 
            {
                string nom = txtn.Text, ap = txtp.Text, am = txtm.Text;
                char   gen;
                int edad = Int32.Parse(ed.Value.ToString());
                if (radFem.Checked == true)
                {
                    gen = 'F';
                }
                else
                {
                    gen = 'M';
                }
                try
                {
                    MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=consultorio; Uid=root; pws=;");
                    conectar.Open();
                    MySqlCommand comando = new MySqlCommand(string.Format("insert into paciente values('{0}','{1}','{2}','{3}','{4}','{5}')", "", nom, ap, am, edad, gen), conectar);
                    MySqlDataReader alm = comando.ExecuteReader();
                    conectar.Close();
                }
                catch(MySqlException r)
                {
                    MessageBox.Show(r.Message);
                }
            }
        }
    }
}
