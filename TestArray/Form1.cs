namespace TestArray
{
    public partial class Form1 : Form
    {
        // Initialize the button array with existing buttons
        private Button[] buttonArray;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Add existing buttons to array
            buttonArray = [button1, button2, button3];

            // Subscribe to button click events
            foreach (var button in buttonArray)
            {
                button.Click += Button_Click;
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            // Get the button that was clicked
            Button? clickedButton = sender as Button;

            // Perform actions based on which button was clicked
            int index = Array.IndexOf(buttonArray, clickedButton);
            if (index >= 0)
            {
                textBox1.Text = ($"Button {index + 1} clicked!");
                buttonArray[index].BackColor = Color.LightBlue;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            buttonArray[0].BackColor = Color.Red;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            buttonArray[1].BackColor = Color.Yellow;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            buttonArray[2].BackColor = Color.Green;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
