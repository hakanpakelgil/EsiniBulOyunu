namespace EsiniBulOyunu
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int boyut = 2;//satýr ve sütün sayýsý
        List<string> resimler = new List<string>();
        List<string> kartlar = new List<string>();
        List<PictureBox> aciklar = new List<PictureBox>();
        int yokedilenAdet = 0;
        public Form1()
        {
            ResimleriYukle();
            InitializeComponent();

        }

        private void KartlariDiz()
        {
            int bosluk = 10;
            int gen = (pnlKartlar.Width - ((boyut - 1) * bosluk)) / boyut;
            int yuk = (pnlKartlar.Height - ((boyut - 1) * bosluk)) / boyut;

            int i = 0;
            for (int y = 0; y < boyut; y++)
            {
                for (int x = 0; x < boyut; x++)
                {
                    PictureBox resimKutusu = new PictureBox();
                    resimKutusu.Tag = i;
                    resimKutusu.BackColor = Color.LightGreen;
                    resimKutusu.Size = new Size(gen, yuk);
                    resimKutusu.Left = x * (resimKutusu.Width + bosluk);
                    resimKutusu.Top = y * (resimKutusu.Height + bosluk);
                    resimKutusu.ImageLocation = "back.jpg";
                    resimKutusu.SizeMode = PictureBoxSizeMode.Zoom;
                    resimKutusu.Click += ResimKutusu_Click;
                    pnlKartlar.Controls.Add(resimKutusu);
                    i++;
                }
            }
        }
        //sender: Týklanan resim kutusunu taþýr
        private void ResimKutusu_Click(object sender, EventArgs e)
        {
            PictureBox tiklanan = (PictureBox)sender;
            //eðer ayný karta 2.kez týklandýysa birþey yapmadan çýk
            if (aciklar.Count == 1 && aciklar[0] == tiklanan)
                return;

            //yeni bir resim kutusuna týklandýðýnda önceden açýlanlarýn kapanmasý
            if (aciklar.Count == 2)
            {
                AciklariKapat();
            }

            aciklar.Add(tiklanan);
            int kartIndeks = (int)tiklanan.Tag;
            string resim = kartlar[kartIndeks];
            tiklanan.ImageLocation = @"img\" + resim;
            //2.Kartý açtýðýnda yapýlacak eþleþme kontrolü
            if (aciklar.Count == 2 && aciklar[0].ImageLocation == aciklar[1].ImageLocation)
            {
                Application.DoEvents();
                AciklariGecikmeliYoket();
                AciklariKapat();

                //OYUN BÝTTÝ MÝ?
                if (yokedilenAdet == kartlar.Count)
                {
                    MessageBox.Show("Oyun Bitti!");
                    OyunuSifirla();
                }
            }
        }

        private void OyunuSifirla()
        {
            pnlKartlar.Controls.Clear();
            yokedilenAdet = 0;
            groupBox1.Show();
            aciklar.Clear();
            groupBox1.Show();
            pnlKartlar.BackColor = Color.Transparent;
        }

        private void AciklariGecikmeliYoket()
        {
            Thread.Sleep(500);
            foreach (PictureBox kutu in aciklar)
            {
                pnlKartlar.Controls.Remove(kutu);
                yokedilenAdet++;
            }
        }

        private void AciklariKapat()
        {
            foreach (PictureBox kutu in aciklar)
            {
                kutu.ImageLocation = "back.jpg";
            }
            aciklar.Clear();
        }

        private void KartlariSec()
        {
            int ciftAdet = boyut * boyut / 2;

            while (kartlar.Count < ciftAdet)
            {
                string resim = resimler[rnd.Next(resimler.Count)];

                if (!kartlar.Contains(resim))
                    kartlar.Add(resim);
            }
            kartlar.AddRange(kartlar);
            KartlarýKaristir();
        }

        private void KartlarýKaristir()
        {
            string yedek;
            int talihliIndeks;
            for (int i = 0; i < kartlar.Count - 1; i++)
            {
                talihliIndeks = rnd.Next(i, kartlar.Count);
                yedek = kartlar[i];
                kartlar[i] = kartlar[talihliIndeks];
                kartlar[talihliIndeks] = yedek;
            }
        }

        private void ResimleriYukle()
        {
            DirectoryInfo klasor = new DirectoryInfo("img");
            FileInfo[] dosyalar = klasor.GetFiles();

            foreach (FileInfo dosya in dosyalar)
                resimler.Add(dosya.Name);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OyunuBaslat();
        }

        private void OyunuBaslat()
        {
            pnlKartlar.BackColor = Color.WhiteSmoke;
            SeviyeyeKararVer();
            groupBox1.Hide();
            KartlariSec();
            KartlariDiz();
        }

        private void SeviyeyeKararVer()
        {
            if (rb1.Checked) boyut = 2;
            else if (rb2.Checked) boyut = 4;
            else if (rb3.Checked) boyut = 6;
            else if (radioButton4.Checked) boyut = 8;
            else boyut = 10;
        }

        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            OyunuSifirla();
        }
    }
}

