using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Labirent
{
    public partial class Labirent : Form
    {
        public int OyunModu { get; set; }
        private void Labirent_Load(object sender, EventArgs e)
        {
            //LabirentOlustur();
            //if (OyunModu == 2)
            //{
            //    BilgisayarBekletme.Start();
            //}
            TCP();

        }
        public Labirent()
        {
            InitializeComponent();

        }
        public Labirent(int _oyunModu)
        {
            InitializeComponent();
            this.OyunModu = _oyunModu;
           
        }
        int duvar = 999;
        int yol = 1;
        int peynir = -998;
        int FareXCurrent = 1;
        int FareYCurrent = 8;
        int HamleSayisi = 0;
        private void LabirentOlustur()
        {
            
            int tableBuyukluk = 10;
            for (int i = 0; i < tableBuyukluk; i++)
            {
                DataGridViewImageColumn sutunlar = new DataGridViewImageColumn();
                sutunlar.ImageLayout = DataGridViewImageCellLayout.Stretch;
                dGVLabirent.Columns.Add(sutunlar);
            }
            dGVLabirent.Rows.Add(tableBuyukluk);

            dGVLabirent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            foreach (DataGridViewRow hucre in dGVLabirent.Rows)
            {
                hucre.Height = dGVLabirent.Columns[0].Width;
            }
            foreach (DataGridViewImageCell hucre in dGVLabirent.Rows[0].Cells)
            {
                hucre.Value = Image.FromFile("duvar.jpg");
                hucre.Tag = duvar;
            }
            foreach (DataGridViewImageCell hucre in dGVLabirent.Rows[9].Cells)
            {
                hucre.Value = Image.FromFile("duvar.jpg");
                hucre.Tag = duvar;
            }
            for (int i = 0; i < dGVLabirent.Rows.Count - 1; i++)
            {
                dGVLabirent[0, i].Value = Image.FromFile("duvar.jpg");
                dGVLabirent[0, i].Tag = duvar;
                dGVLabirent[dGVLabirent.Rows.Count - 1, i].Value = Image.FromFile("duvar.jpg");
                dGVLabirent[dGVLabirent.Rows.Count - 1, i].Tag = duvar;
            }
            LabirentModel();
        }
        private void LabirentModel()
        {
            dGVLabirent[1, 7].Value = Image.FromFile("duvar.jpg");
            dGVLabirent[1, 7].Tag = duvar;
            dGVLabirent[2, 1].Value = Image.FromFile("duvar.jpg");
            dGVLabirent[2, 1].Tag = duvar;
            dGVLabirent[2, 2].Value = Image.FromFile("duvar.jpg");
            dGVLabirent[2, 2].Tag = duvar;
            dGVLabirent[2, 4].Value = Image.FromFile("duvar.jpg");
            dGVLabirent[2, 4].Tag = duvar;
            dGVLabirent[2, 5].Value = Image.FromFile("duvar.jpg");
            dGVLabirent[2, 5].Tag = duvar;
            dGVLabirent[2, 7].Value = Image.FromFile("duvar.jpg");
            dGVLabirent[2, 7].Tag = duvar;
            dGVLabirent[3, 2].Value = Image.FromFile("duvar.jpg");
            dGVLabirent[3, 2].Tag = duvar;
            dGVLabirent[3, 5].Value = Image.FromFile("duvar.jpg");
            dGVLabirent[3, 5].Tag = duvar;
            dGVLabirent[4, 5].Value = Image.FromFile("duvar.jpg");
            dGVLabirent[4, 5].Tag = duvar;
            dGVLabirent[4, 6].Value = Image.FromFile("duvar.jpg");
            dGVLabirent[4, 6].Tag = duvar;
            dGVLabirent[4, 7].Value = Image.FromFile("duvar.jpg");
            dGVLabirent[4, 7].Tag = duvar;
            dGVLabirent[4, 8].Value = Image.FromFile("duvar.jpg");
            dGVLabirent[4, 8].Tag = duvar;
            dGVLabirent[5, 1].Value = Image.FromFile("duvar.jpg");
            dGVLabirent[5, 1].Tag = duvar;
            dGVLabirent[5, 2].Value = Image.FromFile("duvar.jpg");
            dGVLabirent[5, 2].Tag = duvar;
            dGVLabirent[6, 2].Value = Image.FromFile("duvar.jpg");
            dGVLabirent[6, 2].Tag = duvar;
            dGVLabirent[6, 4].Value = Image.FromFile("duvar.jpg");
            dGVLabirent[6, 4].Tag = duvar;
            dGVLabirent[6, 5].Value = Image.FromFile("duvar.jpg");
            dGVLabirent[6, 5].Tag = duvar;
            dGVLabirent[6, 6].Value = Image.FromFile("duvar.jpg");
            dGVLabirent[6, 6].Tag = duvar;
            dGVLabirent[6, 7].Value = Image.FromFile("duvar.jpg");
            dGVLabirent[6, 7].Tag = duvar;
            dGVLabirent[7, 2].Value = Image.FromFile("duvar.jpg");
            dGVLabirent[7, 2].Tag = duvar;
            dGVLabirent[7, 3].Value = Image.FromFile("duvar.jpg");
            dGVLabirent[7, 3].Tag = duvar;
            dGVLabirent[7, 4].Value = Image.FromFile("duvar.jpg");
            dGVLabirent[7, 4].Tag = duvar;
            for (int i = 0; i < dGVLabirent.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dGVLabirent.Rows.Count - 1; j++)
                {
                    if (dGVLabirent[i, j].Value == null)
                    {
                        dGVLabirent[i, j].Value = Image.FromFile("yol.jpeg");
                        dGVLabirent[i, j].Tag = yol;
                    }
                }
            }

            dGVLabirent[1, 8].Value = Image.FromFile("fare.png");
            dGVLabirent[8, 1].Value = Image.FromFile("peynir.png");
            dGVLabirent[8, 1].Tag = peynir;

        }   
        private void HareketEt(object sender, KeyEventArgs e)
        {
            if (this.OyunModu == 1)
            {
                if (e.KeyData == Keys.Right && (int)dGVLabirent[FareXCurrent + 1, FareYCurrent].Tag != duvar)
                {
                    if (e.KeyData == Keys.Right && (int)dGVLabirent[FareXCurrent + 1, FareYCurrent].Tag == peynir)
                    {
                        HamleSayisi += 1;
                        dGVLabirent[FareXCurrent, FareYCurrent].Value = null;
                        dGVLabirent[FareXCurrent, FareYCurrent].Value = Image.FromFile("yol.jpeg");
                        dGVLabirent[++FareXCurrent, FareYCurrent].Value = Image.FromFile("fare.png");
                        MessageBox.Show("Peynir " + HamleSayisi + " hamlede bulundu.");
                        AnaSayfa anaSayfa = new AnaSayfa();
                        anaSayfa.Show();
                        this.Hide();
                    }
                    else
                    {
                        HamleSayisi += 1;
                        dGVLabirent[FareXCurrent, FareYCurrent].Value = null;
                        dGVLabirent[FareXCurrent, FareYCurrent].Value = Image.FromFile("yol.jpeg");
                        dGVLabirent[++FareXCurrent, FareYCurrent].Value = Image.FromFile("fare.png");
                    }


                }
                if (e.KeyData == Keys.Left && (int)dGVLabirent[FareXCurrent - 1, FareYCurrent].Tag != duvar)
                {

                    if (e.KeyData == Keys.Left && (int)dGVLabirent[FareXCurrent - 1, FareYCurrent].Tag == peynir)
                    {
                        HamleSayisi += 1;
                        dGVLabirent[FareXCurrent, FareYCurrent].Value = null;
                        dGVLabirent[FareXCurrent, FareYCurrent].Value = Image.FromFile("yol.jpeg");
                        dGVLabirent[--FareXCurrent, FareYCurrent].Value = Image.FromFile("fare.png");
                        MessageBox.Show("Peynir " + HamleSayisi + " hamlede bulundu."); AnaSayfa anaSayfa = new AnaSayfa();
                        anaSayfa.Show();
                        this.Hide();
                    }
                    else
                    {
                        HamleSayisi += 1;
                        dGVLabirent[FareXCurrent, FareYCurrent].Value = null;
                        dGVLabirent[FareXCurrent, FareYCurrent].Value = Image.FromFile("yol.jpeg");
                        dGVLabirent[--FareXCurrent, FareYCurrent].Value = Image.FromFile("fare.png");
                    }

                }
                if (e.KeyData == Keys.Up && (int)dGVLabirent[FareXCurrent, FareYCurrent - 1].Tag != duvar)
                {
                    if (e.KeyData == Keys.Up && (int)dGVLabirent[FareXCurrent, FareYCurrent - 1].Tag == peynir)
                    {
                        HamleSayisi += 1;
                        dGVLabirent[FareXCurrent, FareYCurrent].Value = null;
                        dGVLabirent[FareXCurrent, FareYCurrent].Value = Image.FromFile("yol.jpeg");
                        dGVLabirent[FareXCurrent, --FareYCurrent].Value = Image.FromFile("fare.png");
                        MessageBox.Show("Peynir " + HamleSayisi + " hamlede bulundu."); AnaSayfa anaSayfa = new AnaSayfa();
                        anaSayfa.Show();
                        this.Hide();
                    }
                    else
                    {
                        HamleSayisi += 1;
                        dGVLabirent[FareXCurrent, FareYCurrent].Value = null;
                        dGVLabirent[FareXCurrent, FareYCurrent].Value = Image.FromFile("yol.jpeg");
                        dGVLabirent[FareXCurrent, --FareYCurrent].Value = Image.FromFile("fare.png");
                    }



                }
                if (e.KeyData == Keys.Down && (int)dGVLabirent[FareXCurrent, FareYCurrent + 1].Tag != duvar)
                {
                    if (e.KeyData == Keys.Down && (int)dGVLabirent[FareXCurrent, FareYCurrent + 1].Tag == peynir)
                    {
                        HamleSayisi += 1;
                        dGVLabirent[FareXCurrent, FareYCurrent].Value = null;
                        dGVLabirent[FareXCurrent, FareYCurrent].Value = Image.FromFile("yol.jpeg");
                        dGVLabirent[FareXCurrent, ++FareYCurrent].Value = Image.FromFile("fare.png");
                        MessageBox.Show("Peynir " + HamleSayisi + " hamlede bulundu."); AnaSayfa anaSayfa = new AnaSayfa();
                        anaSayfa.Show();
                        this.Hide();
                    }
                    else
                    {
                        HamleSayisi += 1;
                        dGVLabirent[FareXCurrent, FareYCurrent].Value = null;
                        dGVLabirent[FareXCurrent, FareYCurrent].Value = Image.FromFile("yol.jpeg");
                        dGVLabirent[FareXCurrent, ++FareYCurrent].Value = Image.FromFile("fare.png");
                    }

                }
            }


        }
        private void OtomatikHareketEt()
        {

            int kuzey = (int)dGVLabirent[FareXCurrent, FareYCurrent - 1].Tag;
            int guney = (int)dGVLabirent[FareXCurrent, FareYCurrent + 1].Tag;
            int bati = (int)dGVLabirent[FareXCurrent - 1, FareYCurrent].Tag;
            int dogu = (int)dGVLabirent[FareXCurrent + 1, FareYCurrent].Tag;

            if (kuzey <= guney && kuzey <= bati && kuzey <= dogu && kuzey != 999)
            {
                if ((int)dGVLabirent[FareXCurrent, FareYCurrent - 1].Tag == peynir)
                {
                    HamleSayisi += 1;
                    dGVLabirent[FareXCurrent, FareYCurrent].Value = null;
                    dGVLabirent[FareXCurrent, FareYCurrent].Value = Image.FromFile("yol.jpeg");
                    dGVLabirent[FareXCurrent, --FareYCurrent].Value = Image.FromFile("fare.png");
                    BilgisayarBekletme.Stop();
                    BilgisayarBekletme.Enabled = false;
                    MessageBox.Show("Peynir " + HamleSayisi + " hamlede bulundu."); AnaSayfa anaSayfa = new AnaSayfa();
                    anaSayfa.Show();
                    this.Hide();
                }
                else
                {
                    HamleSayisi += 1;
                    dGVLabirent[FareXCurrent, FareYCurrent].Value = null;
                    dGVLabirent[FareXCurrent, FareYCurrent].Value = Image.FromFile("yol.jpeg");
                    dGVLabirent[FareXCurrent, --FareYCurrent].Value = Image.FromFile("fare.png");
                    dGVLabirent[FareXCurrent, FareYCurrent].Tag = (int)dGVLabirent[FareXCurrent, FareYCurrent].Tag + 1;
                }
            }
            else if (guney <= kuzey && guney <= bati && guney <= dogu && guney != 999)
            {
                if ((int)dGVLabirent[FareXCurrent, FareYCurrent + 1].Tag == peynir)
                {
                    HamleSayisi += 1;
                    dGVLabirent[FareXCurrent, FareYCurrent].Value = null;
                    dGVLabirent[FareXCurrent, FareYCurrent].Value = Image.FromFile("yol.jpeg");
                    dGVLabirent[FareXCurrent, ++FareYCurrent].Value = Image.FromFile("fare.png");
                    BilgisayarBekletme.Stop();
                    BilgisayarBekletme.Enabled = false;
                    MessageBox.Show("Peynir " + HamleSayisi + " hamlede bulundu."); AnaSayfa anaSayfa = new AnaSayfa();
                    anaSayfa.Show();               
                    this.Hide();
                }
                else
                {
                    HamleSayisi += 1;
                    dGVLabirent[FareXCurrent, FareYCurrent].Value = null;
                    dGVLabirent[FareXCurrent, FareYCurrent].Value = Image.FromFile("yol.jpeg");
                    dGVLabirent[FareXCurrent, ++FareYCurrent].Value = Image.FromFile("fare.png");
                    dGVLabirent[FareXCurrent, FareYCurrent].Tag = (int)dGVLabirent[FareXCurrent, FareYCurrent].Tag + 1;
                }
            }
            else if (bati <= guney && bati <= kuzey && bati <= dogu && bati != 999)
            {
                if ((int)dGVLabirent[FareXCurrent - 1, FareYCurrent].Tag == peynir)
                {
                    HamleSayisi += 1;
                    dGVLabirent[FareXCurrent, FareYCurrent].Value = null;
                    dGVLabirent[FareXCurrent, FareYCurrent].Value = Image.FromFile("yol.jpeg");
                    dGVLabirent[--FareXCurrent, FareYCurrent].Value = Image.FromFile("fare.png");
                    BilgisayarBekletme.Stop();
                    BilgisayarBekletme.Enabled = false;
                    MessageBox.Show("Peynir " + HamleSayisi + " hamlede bulundu."); AnaSayfa anaSayfa = new AnaSayfa();
                    anaSayfa.Show();
                    this.Hide();
                }
                else
                {
                    HamleSayisi += 1;
                    dGVLabirent[FareXCurrent, FareYCurrent].Value = null;
                    dGVLabirent[FareXCurrent, FareYCurrent].Value = Image.FromFile("yol.jpeg");
                    dGVLabirent[--FareXCurrent, FareYCurrent].Value = Image.FromFile("fare.png");
                    dGVLabirent[FareXCurrent, FareYCurrent].Tag = (int)dGVLabirent[FareXCurrent, FareYCurrent].Tag + 1;
                }
            }
            else if (dogu <= guney && dogu <= bati && dogu <= kuzey && dogu != 999)
            {
                if ((int)dGVLabirent[FareXCurrent + 1, FareYCurrent].Tag == peynir)
                {
                    HamleSayisi += 1;
                    dGVLabirent[FareXCurrent, FareYCurrent].Value = null;
                    dGVLabirent[FareXCurrent, FareYCurrent].Value = Image.FromFile("yol.jpeg");
                    dGVLabirent[++FareXCurrent, FareYCurrent].Value = Image.FromFile("fare.png");
                    BilgisayarBekletme.Stop();
                    BilgisayarBekletme.Enabled = false;
                    MessageBox.Show("Peynir " + HamleSayisi + " hamlede bulundu."); AnaSayfa anaSayfa = new AnaSayfa();
                    anaSayfa.Show();
                    this.Hide();
                }
                else
                {
                    HamleSayisi += 1;
                    dGVLabirent[FareXCurrent, FareYCurrent].Value = null;
                    dGVLabirent[FareXCurrent, FareYCurrent].Value = Image.FromFile("yol.jpeg");
                    dGVLabirent[++FareXCurrent, FareYCurrent].Value = Image.FromFile("fare.png");
                    dGVLabirent[FareXCurrent, FareYCurrent].Tag = (int)dGVLabirent[FareXCurrent, FareYCurrent].Tag + 1;
                }
            }
        }

        private void BilgisayarBekletme_Tick(object sender, EventArgs e)
        {
            OtomatikHareketEt();
        }

        private void TCP()
        {
            //Bilgi alisverisi için bilgi almak istedigimiz port numarasini TcpListener sinifi ile gerçeklestiriyoruz

            TcpListener TcpDinleyicisi = new TcpListener(1234);
            TcpDinleyicisi.Start();

            MessageBox.Show("Sunucu baslatildi...");

            //Soket baglantimizi yapiyoruz.Bunu TcpListener sinifinin AcceptSocket metodu ile yaptigimiza dikkat edin
            Socket IstemciSoketi = TcpDinleyicisi.AcceptSocket();


            // Baglantının olup olmadığını kontrol ediyoruz
            if (!IstemciSoketi.Connected)
            {
                MessageBox.Show("Sunucu baslatilamiyor...");
            }
            else
            {
                //Sonsuz döngü sayesinde AgAkimini sürekli okuyoruz
                while (true)
                {
                    MessageBox.Show("Istemci baglantisi saglandi...");

                    //IstemciSoketi verilerini NetworkStream sinifi türünden nesneye aktariyoruz.
                    NetworkStream AgAkimi = new NetworkStream(IstemciSoketi);

                    //Soketteki bilgilerle islem yapabilmek için StreamReader ve StreamWriter siniflarini kullaniyoruz
                    StreamWriter AkimYazici = new StreamWriter(AgAkimi);
                    StreamReader AkimOkuyucu = new StreamReader(AgAkimi);


                    //StreamReader ile String veri tipine aktarma islemi önceden bir hata olursa bunu handle etmek gerek
                    try
                    {
                        string IstemciString = AkimOkuyucu.ReadLine();

                        MessageBox.Show("Gelen Bilgi:" + IstemciString);

                        //Istemciden gelen bilginin uzunlugu hesaplaniyor
                        int uzunluk = IstemciString.Length;

                        //AgAkimina, AkimYazını ile IstemciString inin uzunluğunu yazıyoruz
                        AkimYazici.WriteLine(uzunluk.ToString());

                        AkimYazici.Flush();
                    }

                    catch
                    {
                        MessageBox.Show("Sunucu kapatiliyor...");
                        return;
                    }
                }
            }

            IstemciSoketi.Close();
            MessageBox.Show("Sunucu Kapatiliyor...");
        }
    }

}

