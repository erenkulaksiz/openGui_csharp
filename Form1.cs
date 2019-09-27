using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace openGui_csharp
{
    public partial class Form1 : Form
    {

        Random rastgeleInt = new Random();

        private bool mouseDown;
        private Point lastLocation;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            genelislembox1.Visible = false;
            bolmebox1.Visible = false;
            rastgelebox1.Visible = false;
        }

        private void Btn_closeForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_lowerForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        private void PBox_moveForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void PBox_moveForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        public bool numaraMi(object girdi)
        {
            try { long x = Convert.ToInt64(girdi);  return true; }
            catch (Exception ex) { Console.Write(ex); return false; }
            
        }

        public void sonucYaz(long sonuc, long girdi1, long girdi2, string islem) {

            string sonucstr = Convert.ToString(sonuc);
            string girdi1str = Convert.ToString(girdi1);
            string girdi2str = Convert.ToString(girdi2);

            
            if(islem == "+")
            {
                genelislembox1.Visible = true;
                bolmebox1.Visible = false;
                rastgelebox1.Visible = false;

                sonuclbltp.Text = sonucstr;
                firstsonuclblTP.Text = girdi1str;
                secondsonuclblTP.Text = girdi2str;
                islemlbl.Text = islem;
            }
            else if(islem == "-")
            {
                genelislembox1.Visible = true;
                bolmebox1.Visible = false;
                rastgelebox1.Visible = false;

                sonuclbltp.Text = sonucstr;
                firstsonuclblTP.Text = girdi1str;
                secondsonuclblTP.Text = girdi2str;
                islemlbl.Text = islem;

            }
            else if(islem == "x")
            {
                genelislembox1.Visible = true;
                bolmebox1.Visible = false;
                rastgelebox1.Visible = false;

                sonuclbltp.Text = sonucstr;
                firstsonuclblTP.Text = girdi1str;
                secondsonuclblTP.Text = girdi2str;
                islemlbl.Text = islem;

            }
            else if(islem == "/")
            {
                genelislembox1.Visible = false;
                bolmebox1.Visible = true;
                rastgelebox1.Visible = false;

                bolunenlbl.Text = girdi1str;
                bolenlbl.Text = girdi2str;
                bolumlbl.Text = sonucstr;

                // Bolme icin ozel

                long modbul = girdi1 % girdi2;
                bolmeklnlbl.Text = Convert.ToString(modbul);

            }
            else if(islem == "rsg")
            {
                genelislembox1.Visible = false;
                bolmebox1.Visible = false;
                rastgelebox1.Visible = true;

                rastgelelbl.Text = "Rastgele: " + Convert.ToString(sonuc);

            }

            

        }

        public int rastgeleAl(int min, int max)
        {
            try { int rastgelereturn = rastgeleInt.Next(min, max); return rastgelereturn; }
            catch (Exception ex) { Console.Write(ex); return 0; }
        }
        
        private void PBox_moveForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Btntopla_Click(object sender, EventArgs e)
        {
            if (numaraMi(girilecekbox1.Text))
            {
                if (numaraMi(girilecekbox2.Text))
                {
                    long girdi1 = Convert.ToInt64(girilecekbox1.Text);
                    long girdi2 = Convert.ToInt64(girilecekbox2.Text);
                    long sonuc = girdi1 + girdi2;
                    sonucYaz(sonuc, girdi1, girdi2, "+");
                    // Birdahakine labela değilde textbox'a yazdırırsan
                    // insanların çıktıyı kopyalaması kolaylaşır.
                }
                else MessageBox.Show("2. kutudaki girdi sadece sayı olabilir!");
            }
            else MessageBox.Show("1. kutudaki girdi sadece sayı olabilir!");
        }

        private void Btncikar_Click(object sender, EventArgs e)
        {
            if (numaraMi(girilecekbox1.Text))
            {
                if (numaraMi(girilecekbox2.Text))
                {
                    long girdi1 = Convert.ToInt64(girilecekbox1.Text);
                    long girdi2 = Convert.ToInt64(girilecekbox2.Text);
                    long sonuc = girdi1 - girdi2;
                    sonucYaz(sonuc, girdi1, girdi2, "-");
                }
                else MessageBox.Show("2. kutudaki girdi sadece sayı olabilir!");
            }
            else MessageBox.Show("1. kutudaki girdi sadece sayı olabilir!");
        }

        private void Btncarp_Click(object sender, EventArgs e)
        {
            if (numaraMi(girilecekbox1.Text))
            {
                if (numaraMi(girilecekbox2.Text))
                {
                    long girdi1 = Convert.ToInt64(girilecekbox1.Text);
                    long girdi2 = Convert.ToInt64(girilecekbox2.Text);
                    long sonuc = girdi1 * girdi2;
                    sonucYaz(sonuc, girdi1, girdi2, "x");
                }
                else MessageBox.Show("2. kutudaki girdi sadece sayı olabilir!");
            }
            else MessageBox.Show("1. kutudaki girdi sadece sayı olabilir!");
        }

        private void Btnbol_Click(object sender, EventArgs e)
        {
            if (numaraMi(girilecekbox1.Text))
            {
                if (numaraMi(girilecekbox2.Text))
                {
                    long girdi1 = Convert.ToInt64(girilecekbox1.Text);
                    long girdi2 = Convert.ToInt64(girilecekbox2.Text);
                    long sonuc = girdi1 / girdi2;

                    sonucYaz(sonuc, girdi1, girdi2, "/");
                }
                else MessageBox.Show("2. kutudaki girdi sadece sayı olabilir!");
            }
            else MessageBox.Show("1. kutudaki girdi sadece sayı olabilir!");
        }

        private void İnfobtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("bu porogram eren kulaksız tarafından yazılmıştır v0.1");
        }

        private void Btnrastgele_Click(object sender, EventArgs e)
        {
            if (numaraMi(girilecekbox1.Text))
            {
                if (numaraMi(girilecekbox2.Text))
                {
                    if(Convert.ToInt32(girilecekbox1.Text) > Convert.ToInt32(girilecekbox2.Text))
                    {
                        MessageBox.Show("Minimum, maximumdan küçük olamaz!");
                        girilecekbox1.Text = "Min";
                        girilecekbox2.Text = "Max";
                    }
                    else
                    {
                        long sonuc = rastgeleAl(Convert.ToInt32(girilecekbox1.Text), Convert.ToInt32(girilecekbox2.Text));
                        sonucYaz(sonuc, 0, 0, "rsg");
                    }
                }
                else MessageBox.Show("Maximum içerisinde harf olamaz!");
            }
            else MessageBox.Show("Minimum içerisinde harf olamaz!");
        }
    }

    
}
