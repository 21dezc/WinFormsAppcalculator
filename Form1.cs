namespace WinFormsAppcalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ตัวอักษร
            string inputNum1 = Num1.Text;
            string inputNum2 = Num2.Text;

            // เปลี่ยนstringเปนint
            int iNum1 = Int32.Parse(inputNum1);
            int iNum2 = Int32.Parse(inputNum2);
            // เปนintละ จะ บวก ลบ คูณ หาร ตัวเลขได้

            int iResult = iNum1 + iNum2;

            // แปลงตัวเลขให้เป็นstring
            Result.Text = iResult.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // ตัวอักษร
            string inputNum1 = Num1.Text;
            string inputNum2 = Num2.Text;

            // เปลี่ยนstringเปนint
            int iNum1 = Int32.Parse(inputNum1);
            int iNum2 = Int32.Parse(inputNum2);
            // เปนintละ จะ บวก ลบ คูณ หาร ตัวเลขได้

            int iResult = iNum1 - iNum2;

            // แปลงตัวเลขให้เป็นstring
            Result.Text = iResult.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // ตัวอักษร
            string inputNum1 = Num1.Text;
            string inputNum2 = Num2.Text;

            // เปลี่ยนstringเปนint
            int iNum1 = Int32.Parse(inputNum1);
            int iNum2 = Int32.Parse(inputNum2);
            // เปนintละ จะ บวก ลบ คูณ หาร ตัวเลขได้

            int iResult = iNum1 * iNum2;

            // แปลงตัวเลขให้เป็นstring
            Result.Text = iResult.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // ตัวอักษร
            string inputNum1 = Num1.Text;
            string inputNum2 = Num2.Text;

            // เปลี่ยนstringเปนint
            int iNum1 = Int32.Parse(inputNum1);
            int iNum2 = Int32.Parse(inputNum2);
            // เปนintละ จะ บวก ลบ คูณ หาร ตัวเลขได้

            int iResult = iNum1 / iNum2;

            // แปลงตัวเลขให้เป็นstring
            Result.Text = iResult.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Num1.Text = "";
            Num2.Text = "";
            Result.Text = "";
        }
    }
}
