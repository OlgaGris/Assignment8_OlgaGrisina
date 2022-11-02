namespace Assignment8_OlgaGrisina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void check_Click(object sender, EventArgs e)
        {
            
            List<string> boys = new List<string>();
            List<string> girls = new List<string>();

            
            StreamReader readerBoy, readerGirl;
            readerBoy = File.OpenText("BoyNames.txt");
            readerGirl = File.OpenText("GirlNames.txt");

            while (!readerBoy.EndOfStream)
            {
                boys.Add(readerBoy.ReadLine());
            }

            while (!readerGirl.EndOfStream)
            {
                girls.Add(readerGirl.ReadLine());
            }
            readerBoy.Close();
            readerGirl.Close();

            if (textBoxBoy.Text != "")
            {
                if (boys.Contains(textBoxBoy.Text))
                {
                    result.Text = result.Text + "Name " + textBoxBoy.Text + " is popular\n";
                }
                else
                {
                    result.Text = result.Text + "Name " + textBoxBoy.Text + " isn't popular\n";
                }
            }
            if (textBoxGirl.Text != "")
            {
                if (girls.Contains(textBoxGirl.Text))
                {
                    result.Text = result.Text + "Name " + textBoxGirl.Text + " is popular\n";
                }
                else
                {
                    result.Text = result.Text + "Name " + textBoxGirl.Text + " isn't popular\n";
                }
            }


        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBoxBoy.Text = textBoxGirl.Text = result.Text = "";


        }
    }
}