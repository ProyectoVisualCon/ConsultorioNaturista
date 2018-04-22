using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGrupal
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string taba, fr;
        int cs;

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

        private void picDate_Click(object sender, EventArgs e)
        {
            
            QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
            QrCode qrcode = new QrCode();
            qrEncoder.TryEncode("Nombre   "+taba+"\n"+"Fecha     "+fr+"\n"+" Costo       "+cs, out qrcode);//Valores de cadenas de texto o componentes de Texto
            GraphicsRenderer renderer = new GraphicsRenderer(new FixedCodeSize(400, QuietZoneModules.Zero), Brushes.Black, Brushes.White);
            MemoryStream ms = new MemoryStream();
            renderer.WriteToStream(qrcode.Matrix, ImageFormat.Png, ms);
            var imageTempotal = new Bitmap(ms);
            var image = new Bitmap(imageTempotal, new Size(new Point(200, 200)));
            panel1.BackgroundImage = image;


        }

        private void calendario_DateSelected(object sender, DateRangeEventArgs e)
        {
           //  txtNom.Text = calendario.SelectionRange.Start.ToString();// obtener fecha 
        }

        private void rbtnn_CheckedChanged(object sender, EventArgs e)
        {
            txtNom.Visible = true;
            calendario.Visible = false;
        }

        private void rbtnFec_CheckedChanged(object sender, EventArgs e)
        {
            calendario.Visible = true;
            txtNom.Visible = false;
        }

        private void picAgendar_Click(object sender, EventArgs e)
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database = consultorio; Uid=root; pwd=;");
            try
            {
                string nom = txtAnom.Text,ap=txtAp.Text,am=txtAm.Text;
                string com = null,nombre=nom+" "+ap+" "+am;
                int idr=0,cos=Int32.Parse(txtCos.Text);
                
                conectar.Open();
               MySqlCommand comando = new MySqlCommand(string.Format("Select nombre,idPaciente from paciente where nombre like'%{0}%'AND ap like'%{1}%' AND am like'%{2}%'",nom,ap,am), conectar);
                MySqlDataReader almacena = comando.ExecuteReader();
                while (almacena.Read())
                {
                    com = almacena.GetValue(0).ToString();
                    idr =Int32.Parse(almacena.GetValue(1).ToString());

                }
                conectar.Close();
                if (com == null)
                {
                    MessageBox.Show("Paciente no registrado");
                }
                else
                {
                    string date = Calendar.SelectionRange.Start.ToString("yyyy-MM-dd HH-mm-ss");
                    int hor = Int32.Parse(hour.Value.ToString()) ;
                    conectar.Open();
                    comando = new MySqlCommand(string.Format("Insert into consulta values ('{0}','{1}','{2}','{3}','{4}','{5}')","",date,hor,idr,nombre,cos), conectar);
                    MySqlDataReader red = comando.ExecuteReader();
                    conectar.Close();
                    MessageBox.Show("Consulta Registrada");
                    taba = nombre;
                    fr = date;
                    cs = cos;
                 
                }


               
            }
            catch (MySqlException r)
            {
                MessageBox.Show(r.Message);
            }
            // MySqlCommand comando = new MySqlCommand("Select nombre from alumno", conectar);
            
        }

        private void regresar_Click(object sender, EventArgs e)
        {
            
            Form cam = new Form1();
            cam.Show();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string rt = "Consultorios natura. Siempre contigo :)";
            
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            // PdfWriter wri = new PdfWriter();
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(taba+"Factura.pdf", FileMode.Create));
            doc.Open();
            Paragraph paragraph = new Paragraph("Nombre del paciente:   "+taba+"\n");
            doc.Add(paragraph);
            paragraph = new Paragraph("Fecha de la cita   :" + fr);
            doc.Add(paragraph);
            paragraph = new Paragraph("Costo de la cita   :" + cs);
            doc.Add(paragraph);
            paragraph = new Paragraph( "\n"+rt);
            doc.Add(paragraph);
            
            iTextSharp.text.Image im = iTextSharp.text.Image.GetInstance("C:\\Users\\camilo\\Desktop\\Consultorio Naturista\\ConsultorioNaturista-Os\\nat.PNG");
            doc.Add(im);
            doc.Close();
            string pdfPath = Path.Combine(Application.StartupPath, taba+"Factura.pdf");

            Process.Start(pdfPath);
        }

        private void picbus_Click(object sender, EventArgs e)
        {
            string nom = txtNom.Text;
            DateTime da = calendario.SelectionRange.Start;
            string dat = da.ToString("yyyy-MM-dd HH:mm:ss");
            int idr = 0;
            
            if (rbtnn.Checked == true)
            {
              
                MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=consultorio; Uid=root; pwd=;");
                try
                {
                    conectar.Open();
                    MySqlCommand comando = new MySqlCommand(string.Format("select Nombre,fecha,hora,costo from consulta where nombre like '{0}%'", nom), conectar);
                    MySqlDataReader red = comando.ExecuteReader();
                    while (red.Read())
                    {
                        datBus.Rows.Add(red.GetValue(0).ToString(), red.GetValue(1).ToString(), red.GetValue(2).ToString());
                        

                    }
                    conectar.Close();
                }
                catch (MySqlException r)
                {
                    MessageBox.Show(r.Message);
                }
            }
            else
            {
                
                MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=consultorio; Uid=root; pwd=;");
                try
                {
                    
                    conectar.Open();
                    MySqlCommand comando = new MySqlCommand(string.Format("select nombre,fecha,hora from consulta where fecha like'{0}%'", dat), conectar);
                    MySqlDataReader red = comando.ExecuteReader();
                    while (red.Read())
                    { 
                        
                        idr = Int32.Parse(red.GetValue(0).ToString());
                        datBus.Refresh();
                        datBus.Rows.Add(red.GetValue(0), red.GetValue(1).ToString(), red.GetValue(2).ToString());


                    }
                    conectar.Close();
                }
                catch (MySqlException r)
                {
                    MessageBox.Show(r.Message);
                }
            }

        }
    }
}
