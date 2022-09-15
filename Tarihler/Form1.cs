using System;

namespace Tarihler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Hesapla";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            
          
            int gun, ay, yil;//günümüz tarihi
            int g, a, y;//girilen tarih
            int fg = 0, fa = 0, fy = 0; //tarihlerin farký
            
            dateTimePicker1.MaxDate = DateTime.Today;

            g = dateTimePicker1.Value.DayOfYear;
            a = dateTimePicker1.Value.Month;
            y=dateTimePicker1.Value.Year;
           
            DateTime dateTime = DateTime.Now;
            gun = Convert.ToInt32(dateTime.Day);
            ay = Convert.ToInt32(dateTime.Month);
            yil = Convert.ToInt32(dateTime.Year);

            if (g > gun)
            {
                fg = (31 - g) + gun;
                ay--;
            }
            else
                fg = gun - g;
            if(a>ay)
            {
                fa = (12 - a) + ay;
                yil--;
            }
            else
                fa = ay - a;

            fy = yil - y;

            textBox1.Text = Convert.ToString(fy) + "  Yaþýndasýnýz.";
        }
    }
}