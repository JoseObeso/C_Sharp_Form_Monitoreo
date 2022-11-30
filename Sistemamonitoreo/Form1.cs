using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Sistemamonitoreo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            

            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);






        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
         
         


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ping RevisaPing = new Ping();
            PingReply Recibir = RevisaPing.Send(textBox1.Text, 1000);
            String lc_mensaje_intranet = Recibir.Status.ToString();
            if (lc_mensaje_intranet =="Success")
                 
            {
                String  lc_mensaje_tiempo = Recibir.RoundtripTime.ToString(), lc_msg_opciones = Recibir.Options.Ttl.ToString(), lc_msg_buffer = Recibir.Buffer.Length.ToString();
                textBox2.Text = "SERVIDOR INTRANET EXITOSO " + "\r\n Tiempo de  Respuesta : " + lc_mensaje_tiempo + "\r\n Tiempo de Vida (TTL) : " + lc_msg_opciones + "\r\n Buffer : " + lc_msg_buffer;
                textBox2.BackColor = Color.White;
            } else
            {
                textBox2.Text = "NO RESPONDE O NO EXISTE";
                textBox2.BackColor = Color.Red;
            }



            PingReply Recibir2 = RevisaPing.Send(textBox4.Text, 1000);
            String lc_mensaje_intranet2 = Recibir2.Status.ToString();
            if (lc_mensaje_intranet2 == "Success")

            {
                String lc_mensaje_tiempo2 = Recibir2.RoundtripTime.ToString(), lc_msg_opciones2 = Recibir2.Options.Ttl.ToString(), lc_msg_buffer2 = Recibir2.Buffer.Length.ToString();
                textBox3.Text = "SERVIDOR ASISTENCIA EXITOSO " + "\r\n Tiempo de  Respuesta : " + lc_mensaje_tiempo2 + "\r\n Tiempo de Vida (TTL) : " + lc_msg_opciones2 + "\r\n Buffer : " + lc_msg_buffer2;
                textBox3.BackColor = Color.White;
            }
            else
            {
                textBox3.Text = "NO RESPONDE O NO EXISTE";
                textBox3.BackColor = Color.Red;
            }



            PingReply Recibir3 = RevisaPing.Send(textBox6.Text, 1000);
            String lc_mensaje_intranet3 = Recibir3.Status.ToString();
            if (lc_mensaje_intranet3 == "Success")

            {
                String lc_mensaje_tiempo3 = Recibir3.RoundtripTime.ToString(), lc_msg_opciones3 = Recibir3.Options.Ttl.ToString(), lc_msg_buffer3 = Recibir3.Buffer.Length.ToString();
                textBox5.Text = "SERVIDOR SGD EXITOSO " + "\r\n Tiempo de  Respuesta : " + lc_mensaje_tiempo3 + "\r\n Tiempo de Vida (TTL) : " + lc_msg_opciones3 + "\r\n Buffer : " + lc_msg_buffer3;
                textBox5.BackColor = Color.White;
            }
            else
            {
                textBox5.Text = "NO RESPONDE O NO EXISTE";
                textBox5.BackColor = Color.Red;
            }



            PingReply Recibir4 = RevisaPing.Send(textBox8.Text, 1000);
            String lc_mensaje_intranet4 = Recibir4.Status.ToString();
            if (lc_mensaje_intranet4 == "Success")

            {
                String lc_mensaje_tiempo4 = Recibir4.RoundtripTime.ToString(), lc_msg_opciones4 = Recibir4.Options.Ttl.ToString(), lc_msg_buffer4 = Recibir4.Buffer.Length.ToString();
                textBox7.Text = "SERVIDOR SIGA EXITOSO " + "\r\n Tiempo de  Respuesta : " + lc_mensaje_tiempo4 + "\r\n Tiempo de Vida (TTL) : " + lc_msg_opciones4 + "\r\n Buffer : " + lc_msg_buffer4;
                textBox7.BackColor = Color.White;
            }
            else
            {
                textBox7.Text = "NO RESPONDE O NO EXISTE";
                textBox7.BackColor = Color.Red;
            }



            PingReply Recibir5 = RevisaPing.Send(textBox10.Text, 1000);
            String lc_mensaje_intranet5 = Recibir5.Status.ToString();
            if (lc_mensaje_intranet5 == "Success")

            {
                String lc_mensaje_tiempo5 = Recibir5.RoundtripTime.ToString(), lc_msg_opciones5 = Recibir5.Options.Ttl.ToString(), lc_msg_buffer5 = Recibir5.Buffer.Length.ToString();
                textBox9.Text = "SERVIDOR PRODUCCION EXITOSO " + "\r\n Tiempo de  Respuesta : " + lc_mensaje_tiempo5 + "\r\n Tiempo de Vida (TTL) : " + lc_msg_opciones5 + "\r\n Buffer : " + lc_msg_buffer5;
                textBox9.BackColor = Color.White;
            }
            else
            {
                textBox9.Text = "NO RESPONDE O NO EXISTE";
                textBox9.BackColor = Color.Red;

            }

            PingReply Recibir6 = RevisaPing.Send(textBox12.Text, 1000);
            String lc_mensaje_intranet6 = Recibir6.Status.ToString();
            if (lc_mensaje_intranet6 == "Success")

            {
                String lc_mensaje_tiempo6 = Recibir6.RoundtripTime.ToString(), lc_msg_opciones6 = Recibir6.Options.Ttl.ToString(), lc_msg_buffer6 = Recibir6.Buffer.Length.ToString();
                textBox11.Text = "SERVIDOR DE VISITAS EXITOSO " + "\r\n Tiempo de  Respuesta : " + lc_mensaje_tiempo6 + "\r\n Tiempo de Vida (TTL) : " + lc_msg_opciones6 + "\r\n Buffer : " + lc_msg_buffer6;
                textBox11.BackColor = Color.White;
            }
            else
            {
                textBox11.Text = "NO RESPONDE O NO EXISTE";
                textBox11.BackColor = Color.Red;
            }

            textBox13.Clear();
            textBox13.BackColor = Color.White;
            textBox14.Text = "192.168.0.13";




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ping RevisaPing2 = new Ping();
            PingReply Recibir7 = RevisaPing2.Send(textBox14.Text, 1000);
            String lc_mensaje_intranet7 = Recibir7.Status.ToString();
            if (lc_mensaje_intranet7 == "Success")

            {
                String lc_mensaje_tiempo7 = Recibir7.RoundtripTime.ToString(), lc_msg_opciones7 = Recibir7.Options.Ttl.ToString(), lc_msg_buffer7 = Recibir7.Buffer.Length.ToString();
                textBox13.Text = "SERVIDOR INTRANET EXITOSO " + "\r\n Tiempo de  Respuesta : " + lc_mensaje_tiempo7 + "\r\n Tiempo de Vida (TTL) : " + lc_msg_opciones7 + "\r\n Buffer : " + lc_msg_buffer7;
                textBox13.BackColor = Color.White;
            }
            else
            {
                textBox13.Text = "NO RESPONDE O NO EXISTE";
                textBox13.BackColor = Color.Red;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label8.Text = " HORA : " + DateTime.Now.ToString("hh:mm:ss");
            label9.Text = DateTime.Now.ToLongDateString();


        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            textBox13.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MostrarMarcaciones Registros_10 = new MostrarMarcaciones();
            dataGridView1.DataSource = Registros_10.MostrarMarcacionesEnForm();

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Min_Click(object sender, EventArgs e)
        {

            WindowState = FormWindowState.Minimized;

            
             

        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void Btn_Max_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
 
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label10_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://si.irtp.gob.pe/");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://sgd.irtp.com.pe:8181/sgd/login.do");
        
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://srvora01ad:8787/");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://visitas.irtp.gob.pe:5656/visitas/controlVisitas/index.php");


        
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://192.168.0.18:5656/");

        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://172.22.10.25:86/");
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://mpv.irtp.com.pe:8080/iotramitesgd/login.jsf");

        
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://intranet.irtp.gob.pe/");
            
        
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://sgd.irtp.gob.pe:8181/sgd/login.do");

        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
