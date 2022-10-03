using System.Windows.Forms.VisualStyles;

namespace assigment4
{
    public partial class Form1 : Form
    {
        private String calculateFactorial(int number)
        {
            int factorial = 1;

            if (number >= 0)
            {
                for (int i = 1; i <= number; i++)
                {
                    factorial *= i;
                }
                return String.Format("{0}! = {1}", number, factorial);
            }
            else
            {
                return String.Format("{0}! = {1}", number, "isn't correct value");
            }
        }

        private int checkForNumber(String number)
        {
            try
            {
                Int16 convertedNumber = Int16.Parse(number);
                return convertedNumber;

            }
            catch
            {
                new Exception("Your number is incorrect");
                return 0;
            }

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String number = textBox1.Text;
            int checkedNumber = checkForNumber(number);

            textBox2.Text = calculateFactorial(checkedNumber);
        }
    }
}