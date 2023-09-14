namespace YilanOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Panel parca;
        Panel elma = new Panel();
        List<Panel> yilan = new List<Panel>();
        string yon = "sað";

        private void lblBaslat_Click(object sender, EventArgs e)
        {
            lblScore.Text = "0";
            paneliTemizle();

            parca = new Panel();
            parca.Location = new Point(200, 200);
            parca.Size = new Size(20, 20);
            parca.BackColor = Color.Gray;
            yilan.Add(parca);
            panel1.Controls.Add(yilan[0]);
            timer1.Start();
            elmaOlustur();

        }

        private void lblScore_Click(object sender, EventArgs e)
        {

        }
        void carpismaKontrol ()
        {
            for (int i = 2; i < yilan.Count; i++)
            {
                if (yilan[0].Location == yilan[i].Location)
                {
                    label1.Visible = true;
                    label1.Text = "Kaybettiniz.";
                    timer1.Stop();
                }
            } 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int pozisyonX = yilan[0].Location.X;
            int pozisyonY = yilan[0].Location.Y;
            elmaYedi();
            hareket();
            carpismaKontrol();
            if (yon == "sað")
            {
                if (pozisyonX < 580)

                    pozisyonX += 20; // panel saysýýndan yýlanýn büyüklüðünü çýkardým. hareket +20 +20 olsun diye.
                else
                    pozisyonX = 0;
            }
            if (yon == "sol")
            {
                if (pozisyonX > 0)

                    pozisyonX -= 20;
                else
                    pozisyonX = 580;
            }
            if (yon == "aþaðý")
            {
                if (pozisyonY < 580)

                    pozisyonY += 20; // panel saysýýndan yýlanýn büyüklüðünü çýkardým. hareket +20 +20 olsun diye.
                else
                    pozisyonY = 0;
            }
            if (yon == "yukarý")
            {
                if (pozisyonY > 0)

                    pozisyonY -= 20;
                else
                    pozisyonY = 580;
            }
            yilan[0].Location = new Point(pozisyonX, pozisyonY);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right && yon != "sol")
                yon = "sað";
            if (e.KeyCode == Keys.Left && yon != "sað")
                yon = "sol";
            if (e.KeyCode == Keys.Up && yon != "aþaðý")
                yon = "yukarý";
            if (e.KeyCode == Keys.Down && yon != "yukarý")
                yon = "aþaðý";
        }
        void elmaOlustur()
        {
            Random  rnd= new Random();
            int elmaX, elmaY;
            elmaX = rnd.Next(580);
            elmaY = rnd.Next(580);
            elmaX -= elmaX % 20;
            elmaY -= elmaY % 20;
            elma.Size = new Size(20, 20);
            elma.BackColor = Color.Yellow;
            elma.Location = new Point(elmaX, elmaY);
            panel1.Controls.Add(elma);

        }
        void elmaYedi()
        {
            int puan = int.Parse(lblScore.Text);
            if (yilan[0].Location == elma.Location)
            {
                panel1.Controls.Remove(elma);
                puan += 50;
                lblScore.Text = puan.ToString();
                elmaOlustur();
                parcaEkle();
                
            }
        }
        void parcaEkle()
        {

            Panel ekParca = new Panel();
            ekParca.Size = new Size(20, 20);
            ekParca.BackColor = Color.Gray;
            yilan.Add( ekParca );
            panel1.Controls.Add( ekParca );
        }
        void hareket()
        {
            for (int i = yilan.Count -1; i > 0; i--)
            {
                yilan[i].Location = yilan[i - 1].Location;
            }
        }
        void paneliTemizle()
        {
            panel1.Controls.Clear();
            yilan.Clear();
            label1.Visible = false;

        }
    }
}