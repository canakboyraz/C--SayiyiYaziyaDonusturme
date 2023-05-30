namespace Hesapla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.Width = 400;
            this.Height = 400;

            var btnHesapla = new Button();

            btnHesapla.Text = " HESAPLA ";
            btnHesapla.Left = 150;
            btnHesapla.Top = 300;
            btnHesapla.Width = 150;
            btnHesapla.Height = 40;
            btnHesapla.Click += btnHesaplaClick;
            Controls.Add(btnHesapla);
            

        }

        string bir, on, yuz, bin;
       
        private void btnHesaplaClick(object sender, EventArgs e)
        {
            var lblYazi = new Label();
            lblYazi.Left = 150;
            lblYazi.Top = 200;
            lblYazi.Width = 300;
            lblYazi.Height = 300;
            Controls.Add(lblYazi);

            int sayi;
            sayi = Convert.ToInt32(txtSayi.Text);
            int birler, onlar, yuzler, binler;

            birler = sayi % 10;
            sayi = sayi - birler;
            onlar = sayi % 100;
            sayi = sayi - onlar;
            yuzler = sayi % 1000;
            sayi = sayi - yuzler;
            binler = sayi % 10000;

            switch (binler)
            {
                case 0: bin = ""; break;
                case 1000: bin = "bin "; break;
                case 2000: bin = "ikibin "; break;
                case 3000: bin = "üçbin "; break;
                case 4000: bin = "dörtbin "; break;
                case 5000: bin = "beþbin "; break;
                case 6000: bin = "altýbin "; break;
                case 7000: bin = "yedibin "; break;
                case 8000: bin = "sekizbin "; break;
                case 9000: bin = "dokuzbin "; break;
            }
            switch (yuzler)
            {
                case 0: yuz = ""; break;
                case 100: yuz = "yüz "; break;
                case 200: yuz = "ikiyüz "; break;
                case 300: yuz = "üçyüz "; break;
                case 400: yuz = "dörtyüz "; break;
                case 500: yuz = "beþyüz "; break;
                case 600: yuz = "altýyüz "; break;
                case 700: yuz = "yediyüz "; break;
                case 800: yuz = "sekizyüz "; break;
                case 900: yuz = "dokuzyüz "; break;
            }
            switch (onlar)
            {
                case 0: on = ""; break;
                case 10: on = "on "; break;
                case 20: on = "yirmi "; break;
                case 30: on = "otuz "; break;
                case 40: on = "kýrk "; break;
                case 50: on = "elli "; break;
                case 60: on = "altmýþ "; break;
                case 70: on = "yetmiþ "; break;
                case 80: on = "seksen "; break;
                case 90: on = "doksan "; break;
            }
            switch (birler)
            {
                case 0: bir = ""; break;
                case 1: bir = "bir"; break;
                case 2: bir = "iki"; break;
                case 3: bir = "üç"; break;
                case 4: bir = "dört"; break;
                case 5: bir = "beþ"; break;
                case 6: bir = "altý"; break;
                case 7: bir = "yedi"; break;
                case 8: bir = "sekiz"; break;
                case 9: bir = "dokuz"; break;

            }

            lblYazi.Text = bin + yuz + on + bir;
        }

    }

}