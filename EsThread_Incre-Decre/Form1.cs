namespace EsThread_Incre_Decre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private Label numero()
        {
            if (radioButton1.Checked == true)
                return label1;
            if (radioButton2.Checked == true)
                return label2;
            if (radioButton3.Checked == true)
                return label3;
            else
                return null;
        }

        private void ThreadMeno(object a)
        {
            Label label = numero();
            int valore = Convert.ToInt16(label.Text);
            while (true)
            {

                Thread.Sleep(1000);

                label.Text = (valore - 1).ToString();
                valore--;
            }

        }

        private void ThreadPiu(object a)
        {
            Label label = numero();
            int valore = Convert.ToInt16(label.Text);
            while (true)
            {

                Thread.Sleep(1000);
                valore++;
                label.Text = valore.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread threadMeno = new Thread(ThreadMeno);
            threadMeno.Start(numero());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread threadPiu = new Thread(ThreadPiu);
            threadPiu.Start(numero());
        }
    }
}
