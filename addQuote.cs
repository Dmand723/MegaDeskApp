using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MegaDeskApp
{
    public partial class addQuote : Form
    {

        DateTime todaysDate = DateTime.Today;
        int ErrorAmmount = 0;
        string[] DeskMaterials =
        {
            "Pine",
            "Laminate",
            "Veneer",
            "Oak",
            "Rosewood"
        };
        int[] shipingAmounts =
        {
            3,5,7,14

        };
        
        public addQuote()
        {
            InitializeComponent();
        }
        String convertToShort(DateTime date)
        {
            return date.ToShortDateString();
        }
        private void returnToMain()
        {
            var mainMenu = (MainMenu)Tag; ;
            mainMenu.Show();
            Close();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            submitErrProvider.Clear();
            if(ErrorAmmount <= 0)
            {
                int time =0;
                int drawers = 0;
                if(int.TryParse(shipingDropdown.Text, out int res))
                {
                    time = res;
                }
                if (int.TryParse(drawerAmountDropDown.Text, out res))
                {
                    drawers = res;
                }
                var mainMenu = (MainMenu)Tag; ;
                int indexof = mainMenu.addNewQuote(nameTxtBox.Text, todaysDateLbl.Text, widthNumberBox.Value, depthNumberBox.Value,
                    materialDropDown.Text, time,drawers);
                showQuote(indexof);
            }
            else
            {
                submitErrProvider.SetError(submitBtn, "Plese Fix All Errors");
            }
            
        }
        void showQuote(int indexOf)
        {
            DisplayQuote display = new DisplayQuote(indexOf);
            display.Tag = Tag;
            display.Show();
            Close();
        }

        private void addQuote_Load(object sender, EventArgs e)
        {
            todaysDateLbl.Text = convertToShort(todaysDate);
        }

        private void mainMenuBtn_Click(object sender, EventArgs e)
        {
            returnToMain();
        }

        private void nameTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nameErrProvider.GetError(nameTxtBox)))
            {
                nameErrProvider.Clear();
                ErrorAmmount--;
            }
            
            if (string.IsNullOrEmpty(nameTxtBox.Text))
            {
                nameErrProvider.SetError(nameTxtBox, "Please Enter Your Name");
                ErrorAmmount++;
            }
        }

        private void widthNumberBox_ValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(widthErrProvider.GetError(widthNumberBox)))
            {
                widthErrProvider.Clear();
                ErrorAmmount--;
            }
                
            if (widthNumberBox.Value < 24 || widthNumberBox.Value > 96)
            {
                widthErrProvider.SetError(widthNumberBox, "Please Set a Width Between 24 and 96");
                ErrorAmmount++;
            }
        }

        private void depthNumberBox_ValueChanged(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(depthErrProvider.GetError(depthNumberBox)))
            {
                depthErrProvider.Clear();
                ErrorAmmount--;
            }
            
            if (depthNumberBox.Value < 12 || depthNumberBox.Value > 48)
            {
                depthErrProvider.SetError(depthNumberBox, "Please Set a Depth Between 12 and 48");
                ErrorAmmount++;
            }
        }


        private void drawerAmountDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            cl.Text = drawerAmountDropDown.Text;
            if (!string.IsNullOrEmpty(drawerErrProvider.GetError(drawerAmountDropDown)))
            {
                drawerErrProvider.Clear();
                ErrorAmmount--;
            }
            
            if (int.TryParse(drawerAmountDropDown.Text, out int drawerAmmount))
            {
                if(drawerAmmount <1 || drawerAmmount > 7)
                {
                    drawerErrProvider.SetError(drawerAmountDropDown, "Please Select a Number Between 1 and 7 1");
                    ErrorAmmount++;
                }
            }
            if(string.IsNullOrEmpty(drawerAmountDropDown.Text))
            {
                drawerErrProvider.SetError(drawerAmountDropDown, "Please Select a Number Between 1 and 7 1");
                ErrorAmmount++;
            }
        }

        private void materialDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(materialErrProvider.GetError(materialDropDown)))
            {
                materialErrProvider.Clear();
                ErrorAmmount--;
            }
            if (!DeskMaterials.Contains(materialDropDown.Text))
            {
                materialErrProvider.SetError(materialDropDown, "Please Select from Dropdown");
                ErrorAmmount++;
            }
        }

        private void shipingDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(shippingErrProvider.GetError(shipingDropdown)))
            {
                shippingErrProvider.Clear();
                ErrorAmmount--;
            }
            if(int.TryParse(shipingDropdown.Text, out int shipingAmmount))
            {
                if (!shipingAmounts.Contains(shipingAmmount))
                {
                    shippingErrProvider.SetError(shipingDropdown, "Please Select from Dropdown");
                    ErrorAmmount++;
                }
            }
            else
            {
                shippingErrProvider.SetError(shipingDropdown, "Please Select from Dropdown");
                ErrorAmmount++;
            }
        }

        
    }
}
