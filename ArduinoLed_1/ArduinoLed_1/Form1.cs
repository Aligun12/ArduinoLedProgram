using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace ArduinoLed_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool formTasiniyor = false;
        Point baslangicNoktasi = new Point(0, 0);
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "255";
            textBox2.Text = "0";
            textBox3.Text = "0";
            label2.BackColor = Color.Red;
            label2.ForeColor = Color.Black;
            label2.Text = "Kırmızı";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames(); //Seri portları diziye ekleme
            foreach (string port in ports)
                comboBox1.Items.Add(port);
        }

        private void yesilbuton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "255";
            label2.BackColor = Color.Green;
            label2.ForeColor = Color.Black;
            label2.Text = "Yeşil";
        }

        private void mavibuton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "255";
            textBox3.Text = "0";
            label2.BackColor = Color.Blue;
            label2.ForeColor = Color.Black;
            label2.Text = "Mavi";
        }

        private void buton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "255";
            textBox2.Text = "255";
            textBox3.Text = "255";
            label2.BackColor = Color.Black;
            label2.ForeColor = Color.White;
            label2.Text = "Beyaz";
        }

        private void saributon_Click(object sender, EventArgs e)
        {
            textBox1.Text = "255";
            textBox2.Text = "0";
            textBox3.Text = "255";
            label2.BackColor = Color.Yellow;
            label2.ForeColor = Color.Black;
            label2.Text = "Sarı";
        }

        private void morbuton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "255";
            textBox2.Text = "255";
            textBox3.Text = "0";
            label2.BackColor = Color.Purple;
            label2.ForeColor = Color.Black;
            label2.Text = "Mor";
        }

        private void cyanbuton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "255";
            textBox3.Text = "255";
            label2.BackColor = Color.Cyan;
            label2.ForeColor = Color.Black;
            label2.Text = "Cyan";
        }

        private void kapatbuton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            label2.ForeColor = Color.Black;
            label2.BackColor = Color.White;
            label2.Text = "KAPALI";
        }

        private void renksec_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            label2.BackColor = colorDialog1.Color;
            label2.Text = colorDialog1.Color.Name;
            label2.ForeColor = Color.Black;
            textBox1.Text = colorDialog1.Color.R.ToString();
            textBox2.Text = colorDialog1.Color.B.ToString();
            textBox3.Text = colorDialog1.Color.G.ToString();
        }

        private void baglanbuton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    /* Seri Port Ayarları */
                    serialPort1.PortName = comboBox1.Text;
                    serialPort1.BaudRate = 9600;
                    serialPort1.Parity = Parity.None;
                    serialPort1.DataBits = 8;
                    serialPort1.StopBits = StopBits.One;
                    serialPort1.Open(); //Seri portu aç
                    label6.Text = "Bağlantı Sağlandı.";
                    label6.ForeColor = System.Drawing.Color.Green;
                    baglanbuton.Text = "KES"; //Buton1 yazısını değiştir
                }
                else
                {
                    label6.Text = "Bağlantı Kesildi.";
                    label6.ForeColor = System.Drawing.Color.Red;
                    baglanbuton.Text = "BAĞLAN"; //Buton1 yazısını değiştir
                    serialPort1.Close(); //Seri portu kapa
                }
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message, "Hata"); //Hata mesajı
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text==""|| textBox1.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("Değerler Boş Bırakılamaz !", "Hata");
            }
            else
            {
                try
                {
                    if (serialPort1.IsOpen)
                    {
                        serialPort1.WriteLine(textBox1.Text + "," + textBox2.Text + "," + textBox3.Text); //Değeri port üzerinden gönder

                    }
                }
                catch (Exception ex2)
                {
                    MessageBox.Show(ex2.Message, "Hata"); //Hata mesajı
                }
            }
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            formTasiniyor = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            formTasiniyor = true;
            baslangicNoktasi = new Point(e.X, e.Y);
        }

        private void panel1_Move(object sender, EventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (formTasiniyor)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.baslangicNoktasi.X, p.Y - this.baslangicNoktasi.Y);
            }
        }
    }
}
