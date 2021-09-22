
namespace ArduinoLed_1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.renksec = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.baglanbuton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.saributon = new System.Windows.Forms.Button();
            this.buton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.morbuton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.mavibuton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cyanbuton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.yesilbuton = new System.Windows.Forms.Button();
            this.gonderbuton = new System.Windows.Forms.Button();
            this.kapatbuton = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.kirmizibuton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 33);
            this.panel1.TabIndex = 12;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            this.panel1.Move += new System.EventHandler(this.panel1_Move);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ArduinoLed_1.Properties.Resources.close;
            this.pictureBox1.Location = new System.Drawing.Point(560, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ArduinoLed_1.Properties.Resources.negative;
            this.pictureBox2.Location = new System.Drawing.Point(529, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ArduinoLed_1.Properties.Resources._1200px_Led_light_bulb___led_lamp_1;
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Mavi Değeri :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Kırmızı Değeri : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Yeşil Değeri : ";
            // 
            // renksec
            // 
            this.renksec.Location = new System.Drawing.Point(6, 238);
            this.renksec.Name = "renksec";
            this.renksec.Size = new System.Drawing.Size(100, 75);
            this.renksec.TabIndex = 8;
            this.renksec.Text = "RENK SEÇ";
            this.renksec.UseVisualStyleBackColor = true;
            this.renksec.Click += new System.EventHandler(this.renksec_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 336);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 20);
            this.textBox1.TabIndex = 14;
            // 
            // baglanbuton
            // 
            this.baglanbuton.Location = new System.Drawing.Point(293, 332);
            this.baglanbuton.Name = "baglanbuton";
            this.baglanbuton.Size = new System.Drawing.Size(100, 56);
            this.baglanbuton.TabIndex = 0;
            this.baglanbuton.Text = "Bağlan";
            this.baglanbuton.UseVisualStyleBackColor = true;
            this.baglanbuton.Click += new System.EventHandler(this.baglanbuton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "RENK : ";
            // 
            // saributon
            // 
            this.saributon.BackColor = System.Drawing.Color.Yellow;
            this.saributon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saributon.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saributon.Location = new System.Drawing.Point(148, 111);
            this.saributon.Name = "saributon";
            this.saributon.Size = new System.Drawing.Size(100, 100);
            this.saributon.TabIndex = 4;
            this.saributon.Text = "SARI";
            this.saributon.UseVisualStyleBackColor = false;
            this.saributon.Click += new System.EventHandler(this.saributon_Click);
            // 
            // buton
            // 
            this.buton.BackColor = System.Drawing.Color.White;
            this.buton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buton.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buton.Location = new System.Drawing.Point(434, 15);
            this.buton.Name = "buton";
            this.buton.Size = new System.Drawing.Size(100, 100);
            this.buton.TabIndex = 3;
            this.buton.Text = "BEYAZ";
            this.buton.UseVisualStyleBackColor = false;
            this.buton.Click += new System.EventHandler(this.buton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(293, 255);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(241, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // morbuton
            // 
            this.morbuton.BackColor = System.Drawing.Color.Fuchsia;
            this.morbuton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.morbuton.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.morbuton.Location = new System.Drawing.Point(293, 111);
            this.morbuton.Name = "morbuton";
            this.morbuton.Size = new System.Drawing.Size(100, 100);
            this.morbuton.TabIndex = 5;
            this.morbuton.Text = "MOR";
            this.morbuton.UseVisualStyleBackColor = false;
            this.morbuton.Click += new System.EventHandler(this.morbuton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(111, 368);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(113, 20);
            this.textBox2.TabIndex = 15;
            // 
            // mavibuton
            // 
            this.mavibuton.BackColor = System.Drawing.Color.Blue;
            this.mavibuton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mavibuton.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mavibuton.Location = new System.Drawing.Point(293, 15);
            this.mavibuton.Name = "mavibuton";
            this.mavibuton.Size = new System.Drawing.Size(100, 100);
            this.mavibuton.TabIndex = 2;
            this.mavibuton.Text = "MAVİ";
            this.mavibuton.UseVisualStyleBackColor = false;
            this.mavibuton.Click += new System.EventHandler(this.mavibuton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(378, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 2;
            // 
            // cyanbuton
            // 
            this.cyanbuton.BackColor = System.Drawing.Color.Aqua;
            this.cyanbuton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cyanbuton.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cyanbuton.Location = new System.Drawing.Point(6, 111);
            this.cyanbuton.Name = "cyanbuton";
            this.cyanbuton.Size = new System.Drawing.Size(100, 100);
            this.cyanbuton.TabIndex = 6;
            this.cyanbuton.Text = "CYAN";
            this.cyanbuton.UseVisualStyleBackColor = false;
            this.cyanbuton.Click += new System.EventHandler(this.cyanbuton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 10;
            // 
            // yesilbuton
            // 
            this.yesilbuton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.yesilbuton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yesilbuton.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesilbuton.Location = new System.Drawing.Point(148, 15);
            this.yesilbuton.Name = "yesilbuton";
            this.yesilbuton.Size = new System.Drawing.Size(100, 100);
            this.yesilbuton.TabIndex = 1;
            this.yesilbuton.Text = "YEŞİL";
            this.yesilbuton.UseVisualStyleBackColor = false;
            this.yesilbuton.Click += new System.EventHandler(this.yesilbuton_Click);
            // 
            // gonderbuton
            // 
            this.gonderbuton.Location = new System.Drawing.Point(422, 332);
            this.gonderbuton.Name = "gonderbuton";
            this.gonderbuton.Size = new System.Drawing.Size(96, 56);
            this.gonderbuton.TabIndex = 3;
            this.gonderbuton.Text = "Gönder";
            this.gonderbuton.UseVisualStyleBackColor = true;
            this.gonderbuton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // kapatbuton
            // 
            this.kapatbuton.BackColor = System.Drawing.Color.Gray;
            this.kapatbuton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kapatbuton.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kapatbuton.Location = new System.Drawing.Point(434, 111);
            this.kapatbuton.Name = "kapatbuton";
            this.kapatbuton.Size = new System.Drawing.Size(100, 100);
            this.kapatbuton.TabIndex = 7;
            this.kapatbuton.Text = "KAPAT";
            this.kapatbuton.UseVisualStyleBackColor = false;
            this.kapatbuton.Click += new System.EventHandler(this.kapatbuton_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(111, 399);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(110, 20);
            this.textBox3.TabIndex = 16;
            // 
            // kirmizibuton
            // 
            this.kirmizibuton.BackColor = System.Drawing.Color.Red;
            this.kirmizibuton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kirmizibuton.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kirmizibuton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.kirmizibuton.Location = new System.Drawing.Point(6, 15);
            this.kirmizibuton.Name = "kirmizibuton";
            this.kirmizibuton.Size = new System.Drawing.Size(100, 100);
            this.kirmizibuton.TabIndex = 0;
            this.kirmizibuton.Text = "KIRMIZI";
            this.kirmizibuton.UseVisualStyleBackColor = false;
            this.kirmizibuton.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.panel2.Controls.Add(this.kirmizibuton);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.kapatbuton);
            this.panel2.Controls.Add(this.gonderbuton);
            this.panel2.Controls.Add(this.yesilbuton);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cyanbuton);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.mavibuton);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.morbuton);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.buton);
            this.panel2.Controls.Add(this.saributon);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.baglanbuton);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.renksec);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(7, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(573, 458);
            this.panel2.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(588, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Şerit LED Renk Seç";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button renksec;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button baglanbuton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saributon;
        private System.Windows.Forms.Button buton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button morbuton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button mavibuton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cyanbuton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button yesilbuton;
        private System.Windows.Forms.Button gonderbuton;
        private System.Windows.Forms.Button kapatbuton;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button kirmizibuton;
        private System.Windows.Forms.Panel panel2;
    }
}

