namespace labrab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Btn_click(object sender, EventArgs e)
        {
            textBox1.Text += ((Button)sender).Text;
        }
        private double a = 0;
        private double b = 0;
        private string action = "";
        private void Btn_action_click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                action = ((Button)sender).Text;
                textBox1.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Btn_res_click(object sender, EventArgs e)
        {
            try
            {
                b = Convert.ToDouble(textBox1.Text);
                switch (action)
                {
                    case "+":
                        textBox1.Text = (a + b).ToString();
                        break;
                    case "-":
                        textBox1.Text = (a - b).ToString();
                        break;
                    case "*":
                        textBox1.Text = (a * b).ToString();
                        break;
                    case "/":
                        textBox1.Text = (a / b).ToString();
                        break;
                    case "^x":
                        textBox1.Text = (Math.Pow(a, b)).ToString();
                        break;
                    case "logx":
                        textBox1.Text = (Math.Log(a, b)).ToString();
                        break;
                    case "^1/x":

                        if (a < 0 || b % 2 == 0)
                        {
                            MessageBox.Show("Невозможно выполнить операцию");
                        }
                        else
                        {
                            textBox1.Text = (Math.Pow(a, 1 / b)).ToString();

                        }
                        break;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void butn_reset_Click(object sender, EventArgs e)
        {
            //textBox1.clear;
            a = 0;
            b = 0;
            action = "";
            textBox1.Text = "";

        }
        private void butn_lastdel_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }


        private void button_point_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains(','))
            {
                MessageBox.Show("Может быть только одна точка!");
            }
            else
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text += "0,";
                }
                else
                {
                    textBox1.Text += ",";
                }
            }
        }
    }

}

  

