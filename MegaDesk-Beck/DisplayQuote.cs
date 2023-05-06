using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
