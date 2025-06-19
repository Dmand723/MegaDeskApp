namespace MegaDeskApp
{
    public partial class MainMenu : Form
    {
        public DeskQuote[] deskQuotes = new DeskQuote[0];
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

        public int addNewQuote(string custName,string orderDate,decimal width,decimal depth,string material,int deleveryTime,int drawers)
        {
            Array.Resize(ref deskQuotes, deskQuotes.Length+1);
            deskQuotes[deskQuotes.Length - 1] = new DeskQuote(custName, orderDate,
                new Desk(width, depth, material, deleveryTime,drawers));
            return deskQuotes.Length- 1;
        }
        public DeskQuote FetchQuote(int indexOf)
        {
            return deskQuotes[indexOf];
        }

        private void veiwBtn_Click(object sender, EventArgs e)
        {
            ViewQuotes viewQuotes = new ViewQuotes();
            viewQuotes.Tag = this;
            viewQuotes.Show(this);
            Hide();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            addQuote addQuote = new addQuote();
            addQuote.Tag = this;
            addQuote.Show(this);
            Hide();
        }
    }
}
