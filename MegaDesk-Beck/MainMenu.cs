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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var addQuoteForm = new AddQuote();

            addQuoteForm.Tag = this;

            addQuoteForm.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var viewAllQuoteForm = new ViewAllQuotes();

            viewAllQuoteForm.Tag = this;

            viewAllQuoteForm.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var searchQuoteForm = new SearchQuotes();

            searchQuoteForm.Tag = this;

            searchQuoteForm.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
