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
    public partial class ViewQuotes : Form
    {
        public ViewQuotes()
        {
            InitializeComponent();
        }
        private void returnToMain()
        {
            var mainMenu = (MainMenu)Tag; ;
            mainMenu.Show();
            Close();
        }
        private void GoBackBtn(object sender, EventArgs e)
        {
            returnToMain();
        }
    }
}
