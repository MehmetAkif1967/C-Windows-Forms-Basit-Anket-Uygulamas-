namespace deneme789456
{
    public partial class Form1 : Form
    {
        private Control[] originalControls;
        private int clickCount = 0;
        private TextBox textBoxSoru;
        private Button btncevap1;
        private Button btncevap2;
        private Button btncevap3;
        private Button btncevap4;
        private int x = 0;
        private int y = 0;
        private int z = 0;
        private int w = 0;
        public Form1()
        {
            InitializeComponent();
            originalControls = Controls.Cast<Control>().ToArray();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controls.Clear();

            textBoxSoru = new TextBox();
            textBoxSoru.Location = new Point(111, 36);
            textBoxSoru.Size = new Size(568, 27);
            textBoxSoru.Text = "Ne Amaçla Yazýlým Öðrenmek Ýstiyorsunuz?";
            Controls.Add(textBoxSoru);

            btncevap1 = new Button();
            btncevap1.Location = new Point(82, 110);
            btncevap1.Size = new Size(461, 31);
            btncevap1.Text = "Para Kazanmak Ýçin";
            btncevap1.Click += btncevap1_Click;
            Controls.Add(btncevap1);

            btncevap2 = new Button();
            btncevap2.Location = new Point(82, 189);
            btncevap2.Size = new Size(461, 31);
            btncevap2.Text = "Web Tasarým Ýçin";
            btncevap2.Click += btncevap2_Click;
            Controls.Add(btncevap2);

            btncevap3 = new Button();
            btncevap3.Location = new Point(82, 259);
            btncevap3.Size = new Size(461, 31);
            btncevap3.Text = "Mobil App Tasarlamak Ýçin";
            btncevap3.Click += btncevap3_Click;
            Controls.Add(btncevap3);

            btncevap4 = new Button();
            btncevap4.Location = new Point(82, 341);
            btncevap4.Size = new Size(461, 31);
            btncevap4.Text = "Oyun Yapmak Ýçin";
            btncevap4.Click += btncevap4_Click;
            Controls.Add(btncevap4);

        }
        private void btncevap1_Click(object sender, EventArgs e)
        {
            clickCount++;
            x++;
            if (clickCount <= 6)
            {


                if (clickCount == 1)
                {

                    string newTextBoxText = "Programlamaya Günde Ne kadar Vakit Ayýrýyorsun?";
                    string newBtnCevap1Text = "5 saat";
                    string newBtnCevap2Text = "3 - 4 saat";
                    string newBtnCevap3Text = "2 saat";
                    string newBtnCevap4Text = "1 saat";


                    textBoxSoru.Text = newTextBoxText;


                    btncevap1.Text = newBtnCevap1Text;
                    btncevap2.Text = newBtnCevap2Text;
                    btncevap3.Text = newBtnCevap3Text;
                    btncevap4.Text = newBtnCevap4Text;

                }
                if (clickCount == 2)
                {

                    string new1TextBoxText = "Ýlerde Ne Ýþ Yapmak Ýstiyorsunuz?";
                    string new1BtnCevap1Text = "Savunma Sanayi";
                    string new1BtnCevap2Text = "Back-end veya Front-end Web Tasarým";
                    string new1BtnCevap3Text = "Týpta Uygulama Geliþtirme";
                    string new1BtnCevap4Text = "Oyun Geliþtirme";


                    textBoxSoru.Text = new1TextBoxText;


                    btncevap1.Text = new1BtnCevap1Text;
                    btncevap2.Text = new1BtnCevap2Text;
                    btncevap3.Text = new1BtnCevap3Text;
                    btncevap4.Text = new1BtnCevap4Text;

                }
                if (clickCount == 3)
                {

                    string new2TextBoxText = "Ýþini Nasýl Yapmak Ýstiyorsun?";
                    string new2BtnCevap1Text = "Tam zamanlý çalýþmak istiyorum";
                    string new2BtnCevap2Text = "Freelance çalýþmak istiyorum";
                    string new2BtnCevap3Text = "Hobi olarak yapýyorum";
                    string new2BtnCevap4Text = "Yarý zamanlý ekstra para kazanmak için yapýyorum ";


                    textBoxSoru.Text = new2TextBoxText;


                    btncevap1.Text = new2BtnCevap1Text;


                    btncevap2.Text = new2BtnCevap2Text;
                    btncevap3.Text = new2BtnCevap3Text;
                    btncevap4.Text = new2BtnCevap4Text;

                }
                if (clickCount == 4)
                {

                    string new3TextBoxText = "Programlama Yaparken En Büyük Rutinin Nedir?";
                    string new3BtnCevap1Text = "Müzik Dinlemek";
                    string new3BtnCevap2Text = "Kahve Ýçmek";
                    string new3BtnCevap3Text = "Kýsa aralýklarla esneme hareketleri yapmak";
                    string new3BtnCevap4Text = "Dizi Ýzlemek";


                    textBoxSoru.Text = new3TextBoxText;


                    btncevap1.Text = new3BtnCevap1Text;
                    btncevap2.Text = new3BtnCevap2Text;
                    btncevap3.Text = new3BtnCevap3Text;
                    btncevap4.Text = new3BtnCevap4Text;

                }
                if (clickCount == 5)
                {

                    string new4TextBoxText = "Hangi Platforma Uygulama Geliþtirmek Ýstersiniz?";
                    string new4BtnCevap1Text = "Android";
                    string new4BtnCevap2Text = "Cross-Platform(Çoklu Platform)";
                    string new4BtnCevap3Text = "Windows";
                    string new4BtnCevap4Text = "macOS/ÝOS";


                    textBoxSoru.Text = new4TextBoxText;


                    btncevap1.Text = new4BtnCevap1Text;
                    btncevap2.Text = new4BtnCevap2Text;
                    btncevap3.Text = new4BtnCevap3Text;
                    btncevap4.Text = new4BtnCevap4Text;

                }
                if (clickCount == 6)
                {

                    string new5TextBoxText = "Son Soru: Neden Yazýlým?";
                    string new5BtnCevap1Text = "Hýzlýlýk yaratmasý";
                    string new5BtnCevap2Text = "Yaratýcý olunabilmesi";
                    string new5BtnCevap3Text = "Ýþ imkaný fazla";
                    string new5BtnCevap4Text = "Küçüklüðümden beri bilgisayara ilgim var";


                    textBoxSoru.Text = new5TextBoxText;


                    btncevap1.Text = new5BtnCevap1Text;
                    btncevap2.Text = new5BtnCevap2Text;
                    btncevap3.Text = new5BtnCevap3Text;
                    btncevap4.Text = new5BtnCevap4Text;

                }
            }
            else
            {
                string resultMessage = $"Sonuçlar:\n" +
                                        $"{x} kadar A þýkký, {y} kadar B þýkký, {z} kadar C þýkký, {w} kadar D þýkký seçtiniz\n" +
                                        $"Cevaplarýnýzda eþitlik varsa tavsiyemiz aþaðýdaki sýraya göre öðrenmenizdir \n" +
                                        $"A þýkký fazla ise: Java dili ve temel web teknolojileri öðrenmelisin \n" +
                                        $"B þýkký fazla ise: HTML,CSS ve JS gibi dilleri öðrenmelisin\n" +
                                        $"C þýkký fazla ise: Python dili ve SQL sorgulama dili öðrenmelisin\n" +
                                        $"D þýkký fazla ise: C,C++ ve C# öðrenmelisin";

                MessageBox.Show(resultMessage, "Anket Sonuçlarý");


                AnketiSifirla();
            }
        }
        private void btncevap2_Click(object sender, EventArgs e)
        {
            clickCount++;
            y++;
            if (clickCount <= 6)
            {


                if (clickCount == 1)
                {

                    string newTextBoxText = "Programlamaya Günde Ne kadar Vakit Ayýrýyorsun?";
                    string newBtnCevap1Text = "5 saat";
                    string newBtnCevap2Text = "3 - 4 saat";
                    string newBtnCevap3Text = "2 saat";
                    string newBtnCevap4Text = "1 saat";


                    textBoxSoru.Text = newTextBoxText;


                    btncevap1.Text = newBtnCevap1Text;
                    btncevap2.Text = newBtnCevap2Text;
                    btncevap3.Text = newBtnCevap3Text;
                    btncevap4.Text = newBtnCevap4Text;

                }
                if (clickCount == 2)
                {

                    string new1TextBoxText = "Ýlerde Ne Ýþ Yapmak Ýstiyorsunuz?";
                    string new1BtnCevap1Text = "Savunma Sanayi";
                    string new1BtnCevap2Text = "Back-end veya Front-end Web Tasarým";
                    string new1BtnCevap3Text = "Týpta Uygulama Geliþtirme";
                    string new1BtnCevap4Text = "Oyun Geliþtirme";


                    textBoxSoru.Text = new1TextBoxText;


                    btncevap1.Text = new1BtnCevap1Text;
                    btncevap2.Text = new1BtnCevap2Text;
                    btncevap3.Text = new1BtnCevap3Text;
                    btncevap4.Text = new1BtnCevap4Text;

                }
                if (clickCount == 3)
                {

                    string new2TextBoxText = "Ýþini Nasýl Yapmak Ýstiyorsun?";
                    string new2BtnCevap1Text = "Tam zamanlý çalýþmak istiyorum";
                    string new2BtnCevap2Text = "Freelance çalýþmak istiyorum";
                    string new2BtnCevap3Text = "Hobi olarak yapýyorum";
                    string new2BtnCevap4Text = "Yarý zamanlý ekstra para kazanmak için yapýyorum ";


                    textBoxSoru.Text = new2TextBoxText;


                    btncevap1.Text = new2BtnCevap1Text;
                    btncevap2.Text = new2BtnCevap2Text;
                    btncevap3.Text = new2BtnCevap3Text;
                    btncevap4.Text = new2BtnCevap4Text;

                }
                if (clickCount == 4)
                {

                    string new3TextBoxText = "Programlama Yaparken En Büyük Rutinin Nedir?";
                    string new3BtnCevap1Text = "Müzik Dinlemek";
                    string new3BtnCevap2Text = "Kahve Ýçmek";
                    string new3BtnCevap3Text = "Kýsa aralýklarla esneme hareketleri yapmak";
                    string new3BtnCevap4Text = "Dizi Ýzlemek";


                    textBoxSoru.Text = new3TextBoxText;


                    btncevap1.Text = new3BtnCevap1Text;
                    btncevap2.Text = new3BtnCevap2Text;
                    btncevap3.Text = new3BtnCevap3Text;
                    btncevap4.Text = new3BtnCevap4Text;

                }
                if (clickCount == 5)
                {

                    string new4TextBoxText = "Hangi Platforma Uygulama Geliþtirmek Ýstersiniz?";
                    string new4BtnCevap1Text = "Android";
                    string new4BtnCevap2Text = "Cross-Platform(Çoklu Platform)";
                    string new4BtnCevap3Text = "Windows";
                    string new4BtnCevap4Text = "macOS/ÝOS";


                    textBoxSoru.Text = new4TextBoxText;


                    btncevap1.Text = new4BtnCevap1Text;
                    btncevap2.Text = new4BtnCevap2Text;
                    btncevap3.Text = new4BtnCevap3Text;
                    btncevap4.Text = new4BtnCevap4Text;

                }
                if (clickCount == 6)
                {

                    string new5TextBoxText = "Son Soru: Neden Yazýlým?";
                    string new5BtnCevap1Text = "Hýzlýlýk yaratmasý";
                    string new5BtnCevap2Text = "Yaratýcý olunabilmesi";
                    string new5BtnCevap3Text = "Ýþ imkaný fazla";
                    string new5BtnCevap4Text = "Küçüklüðümden beri bilgisayara ilgim var";


                    textBoxSoru.Text = new5TextBoxText;


                    btncevap1.Text = new5BtnCevap1Text;
                    btncevap2.Text = new5BtnCevap2Text;
                    btncevap3.Text = new5BtnCevap3Text;
                    btncevap4.Text = new5BtnCevap4Text;

                }
            }
            else
            {
                string resultMessage = $"Sonuçlar:\n" +
                                        $"{x} kadar A þýkký, {y} kadar B þýkký, {z} kadar C þýkký, {w} kadar D þýkký seçtiniz\n" +
                                        $"Cevaplarýnýzda eþitlik varsa tavsiyemiz aþaðýdaki sýraya göre öðrenmenizdir \n" +
                                        $"A þýkký fazla ise: Java dili ve temel web teknolojileri öðrenmelisin \n" +
                                        $"B þýkký fazla ise: HTML,CSS ve JS gibi dilleri öðrenmelisin\n" +
                                        $"C þýkký fazla ise: Python dili ve SQL sorgulama dili öðrenmelisin\n" +
                                        $"D þýkký fazla ise: C,C++ ve C# öðrenmelisin";

                MessageBox.Show(resultMessage, "Anket Sonuçlarý");


                AnketiSifirla();
            }
        }
        private void btncevap3_Click(object sender, EventArgs e)
        {
            clickCount++;
            z++;
            if (clickCount <= 6)
            {


                if (clickCount == 1)
                {

                    string newTextBoxText = "Programlamaya Günde Ne kadar Vakit Ayýrýyorsun?";
                    string newBtnCevap1Text = "5 saat";
                    string newBtnCevap2Text = "3 - 4 saat";
                    string newBtnCevap3Text = "2 saat";
                    string newBtnCevap4Text = "1 saat";


                    textBoxSoru.Text = newTextBoxText;


                    btncevap1.Text = newBtnCevap1Text;
                    btncevap2.Text = newBtnCevap2Text;
                    btncevap3.Text = newBtnCevap3Text;
                    btncevap4.Text = newBtnCevap4Text;

                }
                if (clickCount == 2)
                {

                    string new1TextBoxText = "Ýlerde Ne Ýþ Yapmak Ýstiyorsunuz?";
                    string new1BtnCevap1Text = "Savunma Sanayi";
                    string new1BtnCevap2Text = "Back-end veya Front-end Web Tasarým";
                    string new1BtnCevap3Text = "Týpta Uygulama Geliþtirme";
                    string new1BtnCevap4Text = "Oyun Geliþtirme";


                    textBoxSoru.Text = new1TextBoxText;


                    btncevap1.Text = new1BtnCevap1Text;
                    btncevap2.Text = new1BtnCevap2Text;
                    btncevap3.Text = new1BtnCevap3Text;
                    btncevap4.Text = new1BtnCevap4Text;

                }
                if (clickCount == 3)
                {

                    string new2TextBoxText = "Ýþini Nasýl Yapmak Ýstiyorsun?";
                    string new2BtnCevap1Text = "Tam zamanlý çalýþmak istiyorum";
                    string new2BtnCevap2Text = "Freelance çalýþmak istiyorum";
                    string new2BtnCevap3Text = "Hobi olarak yapýyorum";
                    string new2BtnCevap4Text = "Yarý zamanlý ekstra para kazanmak için yapýyorum ";


                    textBoxSoru.Text = new2TextBoxText;


                    btncevap1.Text = new2BtnCevap1Text;
                    btncevap2.Text = new2BtnCevap2Text;
                    btncevap3.Text = new2BtnCevap3Text;
                    btncevap4.Text = new2BtnCevap4Text;

                }
                if (clickCount == 4)
                {

                    string new3TextBoxText = "Programlama Yaparken En Büyük Rutinin Nedir?";
                    string new3BtnCevap1Text = "Müzik Dinlemek";
                    string new3BtnCevap2Text = "Kahve Ýçmek";
                    string new3BtnCevap3Text = "Kýsa aralýklarla esneme hareketleri yapmak";
                    string new3BtnCevap4Text = "Dizi Ýzlemek";


                    textBoxSoru.Text = new3TextBoxText;


                    btncevap1.Text = new3BtnCevap1Text;
                    btncevap2.Text = new3BtnCevap2Text;
                    btncevap3.Text = new3BtnCevap3Text;
                    btncevap4.Text = new3BtnCevap4Text;

                }
                if (clickCount == 5)
                {

                    string new4TextBoxText = "Hangi Platforma Uygulama Geliþtirmek Ýstersiniz?";
                    string new4BtnCevap1Text = "Android";
                    string new4BtnCevap2Text = "Cross-Platform(Çoklu Platform)";
                    string new4BtnCevap3Text = "Windows";
                    string new4BtnCevap4Text = "macOS/ÝOS";


                    textBoxSoru.Text = new4TextBoxText;


                    btncevap1.Text = new4BtnCevap1Text;
                    btncevap2.Text = new4BtnCevap2Text;
                    btncevap3.Text = new4BtnCevap3Text;
                    btncevap4.Text = new4BtnCevap4Text;

                }
                if (clickCount == 6)
                {

                    string new5TextBoxText = "Son Soru: Neden Yazýlým?";
                    string new5BtnCevap1Text = "Hýzlýlýk yaratmasý";
                    string new5BtnCevap2Text = "Yaratýcý olunabilmesi";
                    string new5BtnCevap3Text = "Ýþ imkaný fazla";
                    string new5BtnCevap4Text = "Küçüklüðümden beri bilgisayara ilgim var";


                    textBoxSoru.Text = new5TextBoxText;


                    btncevap1.Text = new5BtnCevap1Text;
                    btncevap2.Text = new5BtnCevap2Text;
                    btncevap3.Text = new5BtnCevap3Text;
                    btncevap4.Text = new5BtnCevap4Text;

                }
            }
            else
            {
                string resultMessage = $"Sonuçlar:\n" +
                                        $"{x} kadar A þýkký, {y} kadar B þýkký, {z} kadar C þýkký, {w} kadar D þýkký seçtiniz\n" +
                                        $"Cevaplarýnýzda eþitlik varsa tavsiyemiz aþaðýdaki sýraya göre öðrenmenizdir \n" +
                                        $"A þýkký fazla ise: Java dili ve temel web teknolojileri öðrenmelisin \n" +
                                        $"B þýkký fazla ise: HTML,CSS ve JS gibi dilleri öðrenmelisin\n" +
                                        $"C þýkký fazla ise: Python dili ve SQL sorgulama dili öðrenmelisin\n" +
                                        $"D þýkký fazla ise: C,C++ ve C# öðrenmelisin";

                MessageBox.Show(resultMessage, "Anket Sonuçlarý");


                AnketiSifirla();
            }
        }
        private void btncevap4_Click(object sender, EventArgs e)
        {
            clickCount++;
            w++;
            if (clickCount <= 6)
            {


                if (clickCount == 1)
                {

                    string newTextBoxText = "Programlamaya Günde Ne kadar Vakit Ayýrýyorsun?";
                    string newBtnCevap1Text = "5 saat";
                    string newBtnCevap2Text = "3 - 4 saat";
                    string newBtnCevap3Text = "2 saat";
                    string newBtnCevap4Text = "1 saat";


                    textBoxSoru.Text = newTextBoxText;


                    btncevap1.Text = newBtnCevap1Text;
                    btncevap2.Text = newBtnCevap2Text;
                    btncevap3.Text = newBtnCevap3Text;
                    btncevap4.Text = newBtnCevap4Text;

                }
                if (clickCount == 2)
                {

                    string new1TextBoxText = "Ýlerde Ne Ýþ Yapmak Ýstiyorsunuz?";
                    string new1BtnCevap1Text = "Savunma Sanayi";
                    string new1BtnCevap2Text = "Back-end veya Front-end Web Tasarým";
                    string new1BtnCevap3Text = "Týpta Uygulama Geliþtirme";
                    string new1BtnCevap4Text = "Oyun Geliþtirme";


                    textBoxSoru.Text = new1TextBoxText;


                    btncevap1.Text = new1BtnCevap1Text;
                    btncevap2.Text = new1BtnCevap2Text;
                    btncevap3.Text = new1BtnCevap3Text;
                    btncevap4.Text = new1BtnCevap4Text;

                }
                if (clickCount == 3)
                {

                    string new2TextBoxText = "Ýþini Nasýl Yapmak Ýstiyorsun?";
                    string new2BtnCevap1Text = "Tam zamanlý çalýþmak istiyorum";
                    string new2BtnCevap2Text = "Freelance çalýþmak istiyorum";
                    string new2BtnCevap3Text = "Hobi olarak yapýyorum";
                    string new2BtnCevap4Text = "Yarý zamanlý ekstra para kazanmak için yapýyorum ";


                    textBoxSoru.Text = new2TextBoxText;


                    btncevap1.Text = new2BtnCevap1Text;
                    btncevap2.Text = new2BtnCevap2Text;
                    btncevap3.Text = new2BtnCevap3Text;
                    btncevap4.Text = new2BtnCevap4Text;

                }
                if (clickCount == 4)
                {

                    string new3TextBoxText = "Programlama Yaparken En Büyük Rutinin Nedir?";
                    string new3BtnCevap1Text = "Müzik Dinlemek";
                    string new3BtnCevap2Text = "Kahve Ýçmek";
                    string new3BtnCevap3Text = "Kýsa aralýklarla esneme hareketleri yapmak";
                    string new3BtnCevap4Text = "Dizi Ýzlemek";


                    textBoxSoru.Text = new3TextBoxText;


                    btncevap1.Text = new3BtnCevap1Text;
                    btncevap2.Text = new3BtnCevap2Text;
                    btncevap3.Text = new3BtnCevap3Text;
                    btncevap4.Text = new3BtnCevap4Text;

                }
                if (clickCount == 5)
                {

                    string new4TextBoxText = "Hangi Platforma Uygulama Geliþtirmek Ýstersiniz?";
                    string new4BtnCevap1Text = "Android";
                    string new4BtnCevap2Text = "Cross-Platform(Çoklu Platform)";
                    string new4BtnCevap3Text = "Windows";
                    string new4BtnCevap4Text = "macOS/ÝOS";


                    textBoxSoru.Text = new4TextBoxText;


                    btncevap1.Text = new4BtnCevap1Text;
                    btncevap2.Text = new4BtnCevap2Text;
                    btncevap3.Text = new4BtnCevap3Text;
                    btncevap4.Text = new4BtnCevap4Text;

                }
                if (clickCount == 6)
                {

                    string new5TextBoxText = "Son Soru: Neden Yazýlým?";
                    string new5BtnCevap1Text = "Hýzlýlýk yaratmasý";
                    string new5BtnCevap2Text = "Yaratýcý olunabilmesi";
                    string new5BtnCevap3Text = "Ýþ imkaný fazla";
                    string new5BtnCevap4Text = "Küçüklüðümden beri bilgisayara ilgim var";


                    textBoxSoru.Text = new5TextBoxText;


                    btncevap1.Text = new5BtnCevap1Text;
                    btncevap2.Text = new5BtnCevap2Text;
                    btncevap3.Text = new5BtnCevap3Text;
                    btncevap4.Text = new5BtnCevap4Text;

                }
            }
            else
            {
                string resultMessage = $"Sonuçlar:\n" +
                                        $"{x} kadar A þýkký, {y} kadar B þýkký, {z} kadar C þýkký, {w} kadar D þýkký seçtiniz\n" +
                                        $"Cevaplarýnýzda eþitlik varsa tavsiyemiz aþaðýdaki sýraya göre öðrenmenizdir \n" +
                                        $"A þýkký fazla ise: Java dili ve temel web teknolojileri öðrenmelisin \n" +
                                        $"B þýkký fazla ise: HTML,CSS ve JS gibi dilleri öðrenmelisin\n" +
                                        $"C þýkký fazla ise: Python dili ve SQL sorgulama dili öðrenmelisin\n" +
                                        $"D þýkký fazla ise: C,C++ ve C# öðrenmelisin";

                MessageBox.Show(resultMessage, "Anket Sonuçlarý");


                AnketiSifirla();
            }
        }

        private void AnketiSifirla()
        {
            clickCount = 0;


            Controls.Clear();
            Controls.AddRange(originalControls);


            btncevap1.Click += btncevap1_Click;
            btncevap2.Click += btncevap2_Click;
            btncevap3.Click += btncevap3_Click;
            btncevap4.Click += btncevap4_Click;


        }
    }
}