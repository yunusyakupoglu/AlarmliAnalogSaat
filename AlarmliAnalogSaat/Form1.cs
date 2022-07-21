using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media; // Ses çalabilmek için eklenen kütüphane

namespace AlarmliAnalogSaat
{
    public partial class Form1 : Form
    {
        Bitmap akrepResim, yelkovanResim, saniyeResim, miliResim;
        int saat, dakika, saniye, mili;
        DateTime zaman;
        SoundPlayer ses = new SoundPlayer("alarm.wav"); // ses dosyası projenin bin/debug klasörü içinde.
        int ertelemeSuresi = 0; // erteleme süresi null hatasına düşmemesi için default değer verildi.
      
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerSaat.Start();
            lblGuncelZaman.Text = DateTime.Now.ToLongTimeString(); //Güncel saati göstermek için
            timer1.Enabled = true; //timer1 çağırıldı. - 2

            //parent - child ( kadran içinde konumlandırma yapabilmek için )
            pictureBoxAkrep.Parent = pictureBoxKadran;
            pictureBoxYelkovan.Parent = pictureBoxAkrep;
            pictureBoxSaniye.Parent = pictureBoxYelkovan;
            pictureBoxMili.Parent = pictureBoxSaniye;

            //location ( kadranın orijin noktasına konumlandırma yapmak için )
            pictureBoxAkrep.Location = new Point(0, 0);
            pictureBoxYelkovan.Location = new Point(0, 0);
            pictureBoxSaniye.Location = new Point(0, 0);
            pictureBoxMili.Location = new Point(0, 0);
            pictureBoxMili.Visible = false;

            //Images
            akrepResim = new Bitmap(AlarmliAnalogSaat.Properties.Resources.akrep);
            yelkovanResim = new Bitmap(AlarmliAnalogSaat.Properties.Resources.yelkovan);
            saniyeResim = new Bitmap(AlarmliAnalogSaat.Properties.Resources.saniye);
            miliResim = new Bitmap(AlarmliAnalogSaat.Properties.Resources.mili);
        }

        private void timerSaat_Tick(object sender, EventArgs e)
        {
            zaman = DateTime.Now;
            saat = zaman.Hour;
            dakika = zaman.Minute;
            saniye = zaman.Second;
            mili = zaman.Millisecond;

            Single miliAci = mili * (float)(360) / (float)(1000);
            Single saniyeAci = saniye * 6 + miliAci / 1000;
            Single dakikaAci = dakika * 6 + saniyeAci / 60;
            Single saatAci = saat * 30 + dakikaAci / 12;

            pictureBoxAkrep.Image = resimCevir(akrepResim, saatAci);
            pictureBoxYelkovan.Image = resimCevir(yelkovanResim, dakikaAci);
            pictureBoxSaniye.Image = resimCevir(saniyeResim, saniyeAci);
            pictureBoxMili.Image = resimCevir(miliResim, miliAci);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblGuncelZaman.Text = DateTime.Now.ToLongTimeString(); //Güncel saati göstermek için
            if (lblGuncelZaman.Text == txtAlarmZamani.Text)
            {
                ses.Play(); //eğer güncel zaman alarm zamanına eşit olursa ses çalınacak.
            }
        }

        private void btnAlarmKur_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime zaman = Convert.ToDateTime(txtAlarmZamani.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtAlarmZamani.Focus();
                txtAlarmZamani.SelectAll();
                return;
            }
        }

        private void btnAlarmDurdur_Click(object sender, EventArgs e)
        {
            ses.Stop(); // ses durdurulacak.
            timer2.Stop();
            lblBilgi.Text = "";
        }

        private void btnAlarmErtele_Click(object sender, EventArgs e)
        {
            ertelemeSuresi = 5; //erteleme süresi çağırılarak istenilen değer set edildi.
            timer2.Enabled = true; //timer2 çağırıldı.
            lblBilgi.Text = ertelemeSuresi.ToString() + "saniye sonra tekrar alarm çalacak";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (ertelemeSuresi == 0)
            {
                ses.Play();
                timer2.Stop();
                lblBilgi.Text = "Kalk !!!";
            }
            else if (ertelemeSuresi > 0)
            {
                ertelemeSuresi--;
                lblBilgi.Text = ertelemeSuresi.ToString() + "saniye sonra tekrar alarm çalacak";
            }

        }

        private Bitmap resimCevir(Bitmap eskiResim, float aci)
        {
            Bitmap yeniResim = new Bitmap(eskiResim.Width, eskiResim.Height);
            using (Graphics g = Graphics.FromImage(yeniResim))
            {
                g.TranslateTransform(eskiResim.Width / 2, eskiResim.Height / 2);
                g.RotateTransform(aci);
                g.TranslateTransform(-eskiResim.Width / 2, -eskiResim.Height / 2);
                g.DrawImage(eskiResim, new Point(0, 0));
            }
            return yeniResim;
        }

    }
}
