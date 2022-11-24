namespace time
{
    public partial class Form1 : Form
    {
        int saat = 0;
        int dakika = 0;
        int saniye = 0;
        int salise = 0;
        public Form1()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button1.Enabled = true;
            button1.Text = "Devam Et";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button1.Text = "Baþla";
            timer1.Stop();
            label1.Text = "00";
            label2.Text = "00";
            label3.Text = "00";
            label4.Text = "00";
            listBox1.Items.Clear();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            salise++;
            if (salise == 100)
            {
                salise = 0;
                saniye++;
            }
            if (saniye == 60)
            {
                salise = 0;
                dakika++;
            }
            if (dakika == 60)
            {
                dakika = 0;
                saat++;
            }
            label1.Text = saat.ToString();
            label2.Text = dakika.ToString();
            label3.Text = saniye.ToString();
            label4.Text = salise.ToString();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(saat + ":" + dakika + ":" + saniye + ":" + salise);
        }
    }
}