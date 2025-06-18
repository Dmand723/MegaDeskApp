namespace MegaDeskApp
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deskPicBox_Click(object sender, EventArgs e)
        {
            
        }

        private void veiwBtn_Click(object sender, EventArgs e)
        {
            ViewQuotes viewQuotes = new ViewQuotes();
            viewQuotes.Tag = this;
            viewQuotes.Show(this);
            Hide();
        }
    }
}
