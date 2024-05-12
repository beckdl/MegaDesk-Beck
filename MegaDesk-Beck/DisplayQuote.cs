using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MegaDesk_Beck
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote()
        {
            InitializeComponent();
        }

        private void DisplayQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            AddQuote addQuote = this.Tag as AddQuote;

            addQuote.Show();
        }

        private void DisplayQuote_Activated(object sender, EventArgs e)
        {
            //Load in data and get quote

            Width.Text = AddQuote.userWidth.ToString();
            Depth.Text = AddQuote.userDepth.ToString();
            Drawers.Text = AddQuote.userDrawers.ToString();
            Material.Text = AddQuote.userMaterial.ToString();
            RushDays.Text = AddQuote.userRushOrderDays.ToString();
            UserDate.Text = AddQuote.userDate.ToString();
            Header.Text += AddQuote.userCustomerName.ToString();

            SubtotalAmount.Text = "";
            SubtotalAmount.Text += AddQuote.price.ToString();
        }

        
    }
}
