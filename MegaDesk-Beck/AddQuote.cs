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
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenu mainMenu = this.Tag as MainMenu;

            mainMenu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                label9.Visible = true; return;
            }
            if (comboBox2.Text == "")
            {
                label10.Visible = true; return;
            }
            if (textBox1.Text == "")
            {
                label11.Visible = true; return;
            }
            else
            {
                var displayQuoteForm = new DisplayQuote();

                displayQuoteForm.Tag = this;

                displayQuoteForm.Show();

                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;

                this.Hide();
            }
        }
    }
}
