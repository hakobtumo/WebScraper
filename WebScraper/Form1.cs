using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebScraper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void TabPage2_Click(object sender, EventArgs e)
        {

        }

        private void TabPage3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string search = textBox1.Text;
            MessageBox.Show("Creating ScrapedProducts folder on Desktop \n Please Wait...","Downloading Files");
            decimal pageNum = numericUpDown1.Value;
            if (textBox1.TextLength != 0 && numericUpDown1.Value != 0)
            {
                if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked || checkBox4.Checked)
                {
                    if (checkBox1.Checked)
                    {
                        GetEbayHtml(search, pageNum);
                    }
                    if (checkBox4.Checked)
                    {
                        GetEtsyHtml(search, pageNum);
                    }
                    if (checkBox3.Checked)
                    {
                        GetAlibabaHtml(search, pageNum);
                    }
                }
                else
                {
                    MessageBox.Show("Please select at least one Website to Scrape on");
                }
            }
            else
            {
                MessageBox.Show("All Field of Search Are REQUIRED");
            }

             
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value==0)
            {
                label4.Text = "50 products per page";
            }
            else
            {
                label4.Visible = true;        
                label4.Text = $"{numericUpDown1.Value * 50} Products";
            }

        }

        private void Label4_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
