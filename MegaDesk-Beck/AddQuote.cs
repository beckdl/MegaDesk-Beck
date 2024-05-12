using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MegaDesk_Beck
{
    public partial class AddQuote : Form
    {
        public static double userHeight;
        public static double userWidth;
        public static double userDepth;
        public static int userDrawers;
        public static MaterialType userMaterial;
        public static string userRushOrderDays;
        public static string userDate = DateTime.Now.ToString("MM/dd/yyyy");
        public static string userCustomerName;
        public static string userNotes;
        public static double price;
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
            
                userWidth = double.Parse(numericUpDown1.Text);
                userDepth = double.Parse(numericUpDown2.Text);
                userDrawers = int.Parse(numericUpDown3.Text);
                userRushOrderDays = comboBox2.Text;
                
                userCustomerName = textBox1.Text;
                switch (comboBox1.Text)
                {
                    case "Laminate ($100)":
                        userMaterial = MaterialType.Laminate;
                        break;
                    case "Oak ($200)":
                        userMaterial = MaterialType.Oak;
                        break;
                    case "Rosewood ($300)":
                        userMaterial = MaterialType.Rosewood;
                        break;
                    case "Veneer ($125)":
                        userMaterial = MaterialType.Veneer;
                        break;
                    case "Pine ($50)":
                        userMaterial = MaterialType.Pine;
                        break;
                }
                price = Prices.CalculatePrice(userMaterial, userHeight * userDepth, userDrawers, 0);

                
            
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
