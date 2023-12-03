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
            textBoxSoru.Text = "Ne Ama�la Yaz�l�m ��renmek �stiyorsunuz?";
            Controls.Add(textBoxSoru);

            btncevap1 = new Button();
            btncevap1.Location = new Point(82, 110);
            btncevap1.Size = new Size(461, 31);
            btncevap1.Text = "Para Kazanmak ��in";
            btncevap1.Click += btncevap1_Click;
            Controls.Add(btncevap1);

            btncevap2 = new Button();
            btncevap2.Location = new Point(82, 189);
            btncevap2.Size = new Size(461, 31);
            btncevap2.Text = "Web Tasar�m ��in";
            btncevap2.Click += btncevap2_Click;
            Controls.Add(btncevap2);

            btncevap3 = new Button();
            btncevap3.Location = new Point(82, 259);
            btncevap3.Size = new Size(461, 31);
            btncevap3.Text = "Mobil App Tasarlamak ��in";
            btncevap3.Click += btncevap3_Click;
            Controls.Add(btncevap3);

            btncevap4 = new Button();
            btncevap4.Location = new Point(82, 341);
            btncevap4.Size = new Size(461, 31);
            btncevap4.Text = "Oyun Yapmak ��in";
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

                    string newTextBoxText = "Programlamaya G�nde Ne kadar Vakit Ay�r�yorsun?";
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

                    string new1TextBoxText = "�lerde Ne �� Yapmak �stiyorsunuz?";
                    string new1BtnCevap1Text = "Savunma Sanayi";
                    string new1BtnCevap2Text = "Back-end veya Front-end Web Tasar�m";
                    string new1BtnCevap3Text = "T�pta Uygulama Geli�tirme";
                    string new1BtnCevap4Text = "Oyun Geli�tirme";


                    textBoxSoru.Text = new1TextBoxText;


                    btncevap1.Text = new1BtnCevap1Text;
                    btncevap2.Text = new1BtnCevap2Text;
                    btncevap3.Text = new1BtnCevap3Text;
                    btncevap4.Text = new1BtnCevap4Text;

                }
                if (clickCount == 3)
                {

                    string new2TextBoxText = "��ini Nas�l Yapmak �stiyorsun?";
                    string new2BtnCevap1Text = "Tam zamanl� �al��mak istiyorum";
                    string new2BtnCevap2Text = "Freelance �al��mak istiyorum";
                    string new2BtnCevap3Text = "Hobi olarak yap�yorum";
                    string new2BtnCevap4Text = "Yar� zamanl� ekstra para kazanmak i�in yap�yorum ";


                    textBoxSoru.Text = new2TextBoxText;


                    btncevap1.Text = new2BtnCevap1Text;


                    btncevap2.Text = new2BtnCevap2Text;
                    btncevap3.Text = new2BtnCevap3Text;
                    btncevap4.Text = new2BtnCevap4Text;

                }
                if (clickCount == 4)
                {

                    string new3TextBoxText = "Programlama Yaparken En B�y�k Rutinin Nedir?";
                    string new3BtnCevap1Text = "M�zik Dinlemek";
                    string new3BtnCevap2Text = "Kahve ��mek";
                    string new3BtnCevap3Text = "K�sa aral�klarla esneme hareketleri yapmak";
                    string new3BtnCevap4Text = "Dizi �zlemek";


                    textBoxSoru.Text = new3TextBoxText;


                    btncevap1.Text = new3BtnCevap1Text;
                    btncevap2.Text = new3BtnCevap2Text;
                    btncevap3.Text = new3BtnCevap3Text;
                    btncevap4.Text = new3BtnCevap4Text;

                }
                if (clickCount == 5)
                {

                    string new4TextBoxText = "Hangi Platforma Uygulama Geli�tirmek �stersiniz?";
                    string new4BtnCevap1Text = "Android";
                    string new4BtnCevap2Text = "Cross-Platform(�oklu Platform)";
                    string new4BtnCevap3Text = "Windows";
                    string new4BtnCevap4Text = "macOS/�OS";


                    textBoxSoru.Text = new4TextBoxText;


                    btncevap1.Text = new4BtnCevap1Text;
                    btncevap2.Text = new4BtnCevap2Text;
                    btncevap3.Text = new4BtnCevap3Text;
                    btncevap4.Text = new4BtnCevap4Text;

                }
                if (clickCount == 6)
                {

                    string new5TextBoxText = "Son Soru: Neden Yaz�l�m?";
                    string new5BtnCevap1Text = "H�zl�l�k yaratmas�";
                    string new5BtnCevap2Text = "Yarat�c� olunabilmesi";
                    string new5BtnCevap3Text = "�� imkan� fazla";
                    string new5BtnCevap4Text = "K���kl���mden beri bilgisayara ilgim var";


                    textBoxSoru.Text = new5TextBoxText;


                    btncevap1.Text = new5BtnCevap1Text;
                    btncevap2.Text = new5BtnCevap2Text;
                    btncevap3.Text = new5BtnCevap3Text;
                    btncevap4.Text = new5BtnCevap4Text;

                }
            }
            else
            {
                string resultMessage = $"Sonu�lar:\n" +
                                        $"{x} kadar A ��kk�, {y} kadar B ��kk�, {z} kadar C ��kk�, {w} kadar D ��kk� se�tiniz\n" +
                                        $"Cevaplar�n�zda e�itlik varsa tavsiyemiz a�a��daki s�raya g�re ��renmenizdir \n" +
                                        $"A ��kk� fazla ise: Java dili ve temel web teknolojileri ��renmelisin \n" +
                                        $"B ��kk� fazla ise: HTML,CSS ve JS gibi dilleri ��renmelisin\n" +
                                        $"C ��kk� fazla ise: Python dili ve SQL sorgulama dili ��renmelisin\n" +
                                        $"D ��kk� fazla ise: C,C++ ve C# ��renmelisin";

                MessageBox.Show(resultMessage, "Anket Sonu�lar�");


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

                    string newTextBoxText = "Programlamaya G�nde Ne kadar Vakit Ay�r�yorsun?";
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

                    string new1TextBoxText = "�lerde Ne �� Yapmak �stiyorsunuz?";
                    string new1BtnCevap1Text = "Savunma Sanayi";
                    string new1BtnCevap2Text = "Back-end veya Front-end Web Tasar�m";
                    string new1BtnCevap3Text = "T�pta Uygulama Geli�tirme";
                    string new1BtnCevap4Text = "Oyun Geli�tirme";


                    textBoxSoru.Text = new1TextBoxText;


                    btncevap1.Text = new1BtnCevap1Text;
                    btncevap2.Text = new1BtnCevap2Text;
                    btncevap3.Text = new1BtnCevap3Text;
                    btncevap4.Text = new1BtnCevap4Text;

                }
                if (clickCount == 3)
                {

                    string new2TextBoxText = "��ini Nas�l Yapmak �stiyorsun?";
                    string new2BtnCevap1Text = "Tam zamanl� �al��mak istiyorum";
                    string new2BtnCevap2Text = "Freelance �al��mak istiyorum";
                    string new2BtnCevap3Text = "Hobi olarak yap�yorum";
                    string new2BtnCevap4Text = "Yar� zamanl� ekstra para kazanmak i�in yap�yorum ";


                    textBoxSoru.Text = new2TextBoxText;


                    btncevap1.Text = new2BtnCevap1Text;
                    btncevap2.Text = new2BtnCevap2Text;
                    btncevap3.Text = new2BtnCevap3Text;
                    btncevap4.Text = new2BtnCevap4Text;

                }
                if (clickCount == 4)
                {

                    string new3TextBoxText = "Programlama Yaparken En B�y�k Rutinin Nedir?";
                    string new3BtnCevap1Text = "M�zik Dinlemek";
                    string new3BtnCevap2Text = "Kahve ��mek";
                    string new3BtnCevap3Text = "K�sa aral�klarla esneme hareketleri yapmak";
                    string new3BtnCevap4Text = "Dizi �zlemek";


                    textBoxSoru.Text = new3TextBoxText;


                    btncevap1.Text = new3BtnCevap1Text;
                    btncevap2.Text = new3BtnCevap2Text;
                    btncevap3.Text = new3BtnCevap3Text;
                    btncevap4.Text = new3BtnCevap4Text;

                }
                if (clickCount == 5)
                {

                    string new4TextBoxText = "Hangi Platforma Uygulama Geli�tirmek �stersiniz?";
                    string new4BtnCevap1Text = "Android";
                    string new4BtnCevap2Text = "Cross-Platform(�oklu Platform)";
                    string new4BtnCevap3Text = "Windows";
                    string new4BtnCevap4Text = "macOS/�OS";


                    textBoxSoru.Text = new4TextBoxText;


                    btncevap1.Text = new4BtnCevap1Text;
                    btncevap2.Text = new4BtnCevap2Text;
                    btncevap3.Text = new4BtnCevap3Text;
                    btncevap4.Text = new4BtnCevap4Text;

                }
                if (clickCount == 6)
                {

                    string new5TextBoxText = "Son Soru: Neden Yaz�l�m?";
                    string new5BtnCevap1Text = "H�zl�l�k yaratmas�";
                    string new5BtnCevap2Text = "Yarat�c� olunabilmesi";
                    string new5BtnCevap3Text = "�� imkan� fazla";
                    string new5BtnCevap4Text = "K���kl���mden beri bilgisayara ilgim var";


                    textBoxSoru.Text = new5TextBoxText;


                    btncevap1.Text = new5BtnCevap1Text;
                    btncevap2.Text = new5BtnCevap2Text;
                    btncevap3.Text = new5BtnCevap3Text;
                    btncevap4.Text = new5BtnCevap4Text;

                }
            }
            else
            {
                string resultMessage = $"Sonu�lar:\n" +
                                        $"{x} kadar A ��kk�, {y} kadar B ��kk�, {z} kadar C ��kk�, {w} kadar D ��kk� se�tiniz\n" +
                                        $"Cevaplar�n�zda e�itlik varsa tavsiyemiz a�a��daki s�raya g�re ��renmenizdir \n" +
                                        $"A ��kk� fazla ise: Java dili ve temel web teknolojileri ��renmelisin \n" +
                                        $"B ��kk� fazla ise: HTML,CSS ve JS gibi dilleri ��renmelisin\n" +
                                        $"C ��kk� fazla ise: Python dili ve SQL sorgulama dili ��renmelisin\n" +
                                        $"D ��kk� fazla ise: C,C++ ve C# ��renmelisin";

                MessageBox.Show(resultMessage, "Anket Sonu�lar�");


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

                    string newTextBoxText = "Programlamaya G�nde Ne kadar Vakit Ay�r�yorsun?";
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

                    string new1TextBoxText = "�lerde Ne �� Yapmak �stiyorsunuz?";
                    string new1BtnCevap1Text = "Savunma Sanayi";
                    string new1BtnCevap2Text = "Back-end veya Front-end Web Tasar�m";
                    string new1BtnCevap3Text = "T�pta Uygulama Geli�tirme";
                    string new1BtnCevap4Text = "Oyun Geli�tirme";


                    textBoxSoru.Text = new1TextBoxText;


                    btncevap1.Text = new1BtnCevap1Text;
                    btncevap2.Text = new1BtnCevap2Text;
                    btncevap3.Text = new1BtnCevap3Text;
                    btncevap4.Text = new1BtnCevap4Text;

                }
                if (clickCount == 3)
                {

                    string new2TextBoxText = "��ini Nas�l Yapmak �stiyorsun?";
                    string new2BtnCevap1Text = "Tam zamanl� �al��mak istiyorum";
                    string new2BtnCevap2Text = "Freelance �al��mak istiyorum";
                    string new2BtnCevap3Text = "Hobi olarak yap�yorum";
                    string new2BtnCevap4Text = "Yar� zamanl� ekstra para kazanmak i�in yap�yorum ";


                    textBoxSoru.Text = new2TextBoxText;


                    btncevap1.Text = new2BtnCevap1Text;
                    btncevap2.Text = new2BtnCevap2Text;
                    btncevap3.Text = new2BtnCevap3Text;
                    btncevap4.Text = new2BtnCevap4Text;

                }
                if (clickCount == 4)
                {

                    string new3TextBoxText = "Programlama Yaparken En B�y�k Rutinin Nedir?";
                    string new3BtnCevap1Text = "M�zik Dinlemek";
                    string new3BtnCevap2Text = "Kahve ��mek";
                    string new3BtnCevap3Text = "K�sa aral�klarla esneme hareketleri yapmak";
                    string new3BtnCevap4Text = "Dizi �zlemek";


                    textBoxSoru.Text = new3TextBoxText;


                    btncevap1.Text = new3BtnCevap1Text;
                    btncevap2.Text = new3BtnCevap2Text;
                    btncevap3.Text = new3BtnCevap3Text;
                    btncevap4.Text = new3BtnCevap4Text;

                }
                if (clickCount == 5)
                {

                    string new4TextBoxText = "Hangi Platforma Uygulama Geli�tirmek �stersiniz?";
                    string new4BtnCevap1Text = "Android";
                    string new4BtnCevap2Text = "Cross-Platform(�oklu Platform)";
                    string new4BtnCevap3Text = "Windows";
                    string new4BtnCevap4Text = "macOS/�OS";


                    textBoxSoru.Text = new4TextBoxText;


                    btncevap1.Text = new4BtnCevap1Text;
                    btncevap2.Text = new4BtnCevap2Text;
                    btncevap3.Text = new4BtnCevap3Text;
                    btncevap4.Text = new4BtnCevap4Text;

                }
                if (clickCount == 6)
                {

                    string new5TextBoxText = "Son Soru: Neden Yaz�l�m?";
                    string new5BtnCevap1Text = "H�zl�l�k yaratmas�";
                    string new5BtnCevap2Text = "Yarat�c� olunabilmesi";
                    string new5BtnCevap3Text = "�� imkan� fazla";
                    string new5BtnCevap4Text = "K���kl���mden beri bilgisayara ilgim var";


                    textBoxSoru.Text = new5TextBoxText;


                    btncevap1.Text = new5BtnCevap1Text;
                    btncevap2.Text = new5BtnCevap2Text;
                    btncevap3.Text = new5BtnCevap3Text;
                    btncevap4.Text = new5BtnCevap4Text;

                }
            }
            else
            {
                string resultMessage = $"Sonu�lar:\n" +
                                        $"{x} kadar A ��kk�, {y} kadar B ��kk�, {z} kadar C ��kk�, {w} kadar D ��kk� se�tiniz\n" +
                                        $"Cevaplar�n�zda e�itlik varsa tavsiyemiz a�a��daki s�raya g�re ��renmenizdir \n" +
                                        $"A ��kk� fazla ise: Java dili ve temel web teknolojileri ��renmelisin \n" +
                                        $"B ��kk� fazla ise: HTML,CSS ve JS gibi dilleri ��renmelisin\n" +
                                        $"C ��kk� fazla ise: Python dili ve SQL sorgulama dili ��renmelisin\n" +
                                        $"D ��kk� fazla ise: C,C++ ve C# ��renmelisin";

                MessageBox.Show(resultMessage, "Anket Sonu�lar�");


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

                    string newTextBoxText = "Programlamaya G�nde Ne kadar Vakit Ay�r�yorsun?";
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

                    string new1TextBoxText = "�lerde Ne �� Yapmak �stiyorsunuz?";
                    string new1BtnCevap1Text = "Savunma Sanayi";
                    string new1BtnCevap2Text = "Back-end veya Front-end Web Tasar�m";
                    string new1BtnCevap3Text = "T�pta Uygulama Geli�tirme";
                    string new1BtnCevap4Text = "Oyun Geli�tirme";


                    textBoxSoru.Text = new1TextBoxText;


                    btncevap1.Text = new1BtnCevap1Text;
                    btncevap2.Text = new1BtnCevap2Text;
                    btncevap3.Text = new1BtnCevap3Text;
                    btncevap4.Text = new1BtnCevap4Text;

                }
                if (clickCount == 3)
                {

                    string new2TextBoxText = "��ini Nas�l Yapmak �stiyorsun?";
                    string new2BtnCevap1Text = "Tam zamanl� �al��mak istiyorum";
                    string new2BtnCevap2Text = "Freelance �al��mak istiyorum";
                    string new2BtnCevap3Text = "Hobi olarak yap�yorum";
                    string new2BtnCevap4Text = "Yar� zamanl� ekstra para kazanmak i�in yap�yorum ";


                    textBoxSoru.Text = new2TextBoxText;


                    btncevap1.Text = new2BtnCevap1Text;
                    btncevap2.Text = new2BtnCevap2Text;
                    btncevap3.Text = new2BtnCevap3Text;
                    btncevap4.Text = new2BtnCevap4Text;

                }
                if (clickCount == 4)
                {

                    string new3TextBoxText = "Programlama Yaparken En B�y�k Rutinin Nedir?";
                    string new3BtnCevap1Text = "M�zik Dinlemek";
                    string new3BtnCevap2Text = "Kahve ��mek";
                    string new3BtnCevap3Text = "K�sa aral�klarla esneme hareketleri yapmak";
                    string new3BtnCevap4Text = "Dizi �zlemek";


                    textBoxSoru.Text = new3TextBoxText;


                    btncevap1.Text = new3BtnCevap1Text;
                    btncevap2.Text = new3BtnCevap2Text;
                    btncevap3.Text = new3BtnCevap3Text;
                    btncevap4.Text = new3BtnCevap4Text;

                }
                if (clickCount == 5)
                {

                    string new4TextBoxText = "Hangi Platforma Uygulama Geli�tirmek �stersiniz?";
                    string new4BtnCevap1Text = "Android";
                    string new4BtnCevap2Text = "Cross-Platform(�oklu Platform)";
                    string new4BtnCevap3Text = "Windows";
                    string new4BtnCevap4Text = "macOS/�OS";


                    textBoxSoru.Text = new4TextBoxText;


                    btncevap1.Text = new4BtnCevap1Text;
                    btncevap2.Text = new4BtnCevap2Text;
                    btncevap3.Text = new4BtnCevap3Text;
                    btncevap4.Text = new4BtnCevap4Text;

                }
                if (clickCount == 6)
                {

                    string new5TextBoxText = "Son Soru: Neden Yaz�l�m?";
                    string new5BtnCevap1Text = "H�zl�l�k yaratmas�";
                    string new5BtnCevap2Text = "Yarat�c� olunabilmesi";
                    string new5BtnCevap3Text = "�� imkan� fazla";
                    string new5BtnCevap4Text = "K���kl���mden beri bilgisayara ilgim var";


                    textBoxSoru.Text = new5TextBoxText;


                    btncevap1.Text = new5BtnCevap1Text;
                    btncevap2.Text = new5BtnCevap2Text;
                    btncevap3.Text = new5BtnCevap3Text;
                    btncevap4.Text = new5BtnCevap4Text;

                }
            }
            else
            {
                string resultMessage = $"Sonu�lar:\n" +
                                        $"{x} kadar A ��kk�, {y} kadar B ��kk�, {z} kadar C ��kk�, {w} kadar D ��kk� se�tiniz\n" +
                                        $"Cevaplar�n�zda e�itlik varsa tavsiyemiz a�a��daki s�raya g�re ��renmenizdir \n" +
                                        $"A ��kk� fazla ise: Java dili ve temel web teknolojileri ��renmelisin \n" +
                                        $"B ��kk� fazla ise: HTML,CSS ve JS gibi dilleri ��renmelisin\n" +
                                        $"C ��kk� fazla ise: Python dili ve SQL sorgulama dili ��renmelisin\n" +
                                        $"D ��kk� fazla ise: C,C++ ve C# ��renmelisin";

                MessageBox.Show(resultMessage, "Anket Sonu�lar�");


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