namespace modul2_1302204031
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            isOperationPerformed = false;
            Button button = (Button)sender;
            label1.Text = label1.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationPerformed = button.Text;
            resultValue = Double.Parse(label1.Text);
            label2.Text = resultValue + " " + operationPerformed + " =";
            isOperationPerformed = true;
        }

        private void buttonequal_Click(object sender, EventArgs e)
        {
            switch(operationPerformed)
            {
                case "+":
                    label1.Text = (resultValue + Double.Parse(label1.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}