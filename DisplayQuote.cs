using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDeskApp
{
    public partial class DisplayQuote : Form
    {
        int quoteIndex;
        public DisplayQuote(int quoteIndex)
        {
            InitializeComponent();
            this.quoteIndex = quoteIndex;
        }
        private void returnToMain()
        {
            var mainMenu = (MainMenu)Tag; ;
            mainMenu.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            returnToMain();
        }

        private void DisplayQuote_Load_1(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag; ;
            DeskQuote quote = mainMenu.FetchQuote(quoteIndex);
            if (quote != null)
            {
                customerNameLbl.Text = quote.customerName;
                quoteDateLbl.Text = quote.orderDate;
                widthLbl.Text = quote.desk.Width.ToString();
                depthLbl.Text = quote.desk.Depth.ToString();
                drawersLbl.Text = quote.desk.Drawers.ToString();
                sizeLbl.Text = (quote.desk.Width * quote.desk.Depth).ToString();
                materialLbl.Text = quote.desk.Material;
                timeLbl.Text = quote.desk.DeliveryTime.ToString();
            }
        }
    }
}
