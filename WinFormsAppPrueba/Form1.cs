namespace WinFormsAppPrueba
{
    public partial class Form1 : Form
    {
        private string operador = "";
        public string Operador
        {
            get { return operador; }
            set { operador = value; }
        }
        private double num_1 = 0;
        private double num_2 = 0;
        public double Num_1
        {
            get { return num_1; }
            set { num_1 = value; }
        }
        public double Num_2
        {
            get { return num_2; }
            set { num_2 = value; }
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void addText(string text, string cPrincipal)
        {
            if (!cPrincipal.Contains(text))
            {
                cPrincipal += text;
            }
            else
            {
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // btn eliminar un elemento 
            if (textBox1.Text.Length == 1) textBox1.Text = "0";
            else textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Num_2 = Convert.ToDouble(textBox1.Text);
            switch (Operador)
            {
                case "+":
                    textBox1.Text = $"{Num_1+ Num_2}";
                break;
                case "-":
                    textBox1.Text = $"{Num_1 - Num_2}";
                break;
                case "*":
                    textBox1.Text = $"{Num_1 * Num_2}";
                break;
                default:
                    textBox1.Text = $"{Num_1 / Num_2}";
                break;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // btn 1
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text += "1";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // btn 2
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text += "2";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            // btn 3
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text += "3";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // btn 4
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text += "4";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // btn 5
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text += "5";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            // btn 6
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text += "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // btn 7
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text += "7";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // btn 8
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text += "8";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            // btn 9
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text += "9";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // btn 0
            textBox1.Text += "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // btn * 
            Num_1 = Convert.ToDouble(textBox1.Text);
            Operador = "*";
            textBox1.Text = "0";
        }
        //btn CE
        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            Operador = "";
            Num_1 = 0;
            Num_2 = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Num_1 = Convert.ToDouble(textBox1.Text);
            Operador = "+";
            textBox1.Text = "0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Num_1 = Convert.ToDouble(textBox1.Text);
            Operador = "-";
            textBox1.Text = "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Num_1 = Convert.ToDouble(textBox1.Text);
            Operador = "/";
            textBox1.Text = "0"; 
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // btn 0
            textBox1.Text += ",";
        }
    }
}
