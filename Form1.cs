namespace G26W06WFCounter
{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void OnAdd(object sender, EventArgs e)
        {
            label1.Text = $"{++count}";
        }

        private void OnSub(object sender, EventArgs e)
        {
            label1.Text = $"{--count}";
        }

        private void OnReset(object sender, EventArgs e)
        {
            count = 0;
            label1.Text = $"{count}";
        }
    }
}
