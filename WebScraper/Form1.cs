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
            decimal pageNum = numericUpDown1.Value;

            if (textBox1.TextLength != 0 && numericUpDown1.Value != 0)
            {
                if (checkBox1.Checked  || checkBox3.Checked || checkBox4.Checked)
                {
                    if (checkBox2.Checked)
                    {
                        decimal min = numericUpDown4.Value;
                        decimal max = numericUpDown5.Value;
                        if (max > min)
                        {
                            MessageBox.Show("Creating ScrapedProducts folder on Desktop \n Please Wait...", "Downloading Files");
                            if (checkBox1.Checked)
                            {
                                GetEbayHtml(search, pageNum, min, max);
                            }
                            if (checkBox4.Checked)
                            {
                                GetEtsyHtml(search, pageNum,min, max);
                            }
                            if (checkBox3.Checked)
                            {
                                GetAlibabaHtml(search, pageNum,min, max);
                            }
                        }
                        else
                        {
                            MessageBox.Show("max must be bigger than min");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Creating ScrapedProducts folder on Desktop \n Please Wait...", "Downloading Files");
                        decimal defMin = 0;
                        decimal defMax = 10000000;
                        if (checkBox1.Checked)
                        {
                            GetEbayHtml(search, pageNum, defMin, defMax);
                        }
                        if (checkBox4.Checked)
                        {
                            GetEtsyHtml(search, pageNum,defMin,defMax);
                        }
                        if (checkBox3.Checked)
                        {
                            GetAlibabaHtml(search, pageNum,defMin,defMax);
                        }
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
                label15.Text= "35 products per page";
                label16.Text = "48 products per page";
            }
            else
            {      
                label4.Text = $"{numericUpDown1.Value * 50} Products";
                label15.Text = $"{numericUpDown1.Value * 35} Products";
                label16.Text = $"{numericUpDown1.Value * 48} Products";
            }
            if (numericUpDown1.Value > 20)
            {
                MessageBox.Show($"Scraping on {numericUpDown1.Value} pages may take more than 2 minutes\nBut it will successfully do that\nDon't worry","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string search = textBox2.Text;
            decimal pageNum = numericUpDown2.Value;
            var msgOK = MessageBoxButtons.OK;
            var msgWarn = MessageBoxIcon.Warning;

            if (search.Length != 0)
            {
                if (pageNum != 0)
                {
                    MessageBox.Show("Creating ScrapedPeople folder on Desktop \n Please Wait...", "Downloading Files", msgOK, MessageBoxIcon.Information);
                    GetXingHtml(search, pageNum);
                }
                else
                {
                    MessageBox.Show("Please select number of pages to scrape on","Xing",msgOK,msgWarn);
                }
            }
            else
            {
                MessageBox.Show("Please Enter a Name","Xing",msgOK,msgWarn);
            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void NumericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown2.Value == 0)
            {
                label9.Text = "20 people per page";
            }
            else
            { 
                label9.Text = $"{numericUpDown2.Value * 20} people";
            }
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown3.Value == 0)
            {
                label13.Text = "10 jobs per page";
                label14.Text = "20 jobs per page";
            }
            else
            {
                label13.Text = $"{numericUpDown3.Value * 10} jobs";
                label14.Text= $"{numericUpDown3.Value * 20} jobs";
            }
        }

        private void Label13_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            
            string search = textBox3.Text;
            search = search.Trim('&').Trim('=');
            decimal pageNum = numericUpDown3.Value;
            string jobLevel = "";           
            if (comboBox1.Text == "Entry") jobLevel = "entry_level";
            else if (comboBox1.Text == "Senior") jobLevel = "senior_level";
            else if (comboBox1.Text == "Mid") jobLevel = "mid_level";

            string diceJobType = "";
            string indeedJobType = "";
            if (comboBox2.Text == "Full-Time")
            {
                diceJobType = "Full+Time";
                indeedJobType = "fulltime";
            }
            else if (comboBox2.Text == "Part-Time")
            {
                diceJobType = "Part+Time";
                indeedJobType = "parttime";
            }
            else if (comboBox2.Text == "Contracts")
            {
                diceJobType = "Contracts";
                indeedJobType = "contract";
            }
            else if (comboBox2.Text == "Third Party")
            {
                diceJobType = "Third+Party";
                indeedJobType = "internship";
            }
            
            
            if (search.Length != 0)
            {
                if(pageNum != 0)
                {
                    if (checkBox5.Checked || checkBox6.Checked)
                    {
                        MessageBox.Show("Creating ScrapedJobs folder on Desktop \nPlease Wait...", "Downloading Files",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        if (!checkBox7.Checked){
                            if (checkBox5.Checked)
                            {
                                GetIndeedHtml(search, pageNum, jobLevel, indeedJobType);
                            }

                            if (checkBox6.Checked)
                            {
                                GetDiceHtml(search, pageNum, diceJobType);
                            }
                        }
                        else
                        {
                            if (checkBox5.Checked)
                            {
                                GetIndeedHtml(search, 1000, jobLevel, indeedJobType);
                            }

                            if (checkBox6.Checked)
                            {
                                GetDiceHtml(search, 1000, diceJobType);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select at least one Website to Scrape on");
                    }
                }
                else
                {
                    MessageBox.Show("Please select number of pages to scrape on", "Sraping Jobs");
                }
            }
            else
            {
                MessageBox.Show("Please enter a name of a job","Sraping Jobs");
            }
        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void CheckBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Label14_Click(object sender, EventArgs e)
        {

        }

        private void Label15_Click(object sender, EventArgs e)
        {

        }

        private void Label16_Click(object sender, EventArgs e)
        {

        }

        private void NumericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NumericUpDown5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                numericUpDown4.Enabled = true;
                numericUpDown5.Enabled = true;
            }
            else
            {
                numericUpDown4.Enabled = false;
                numericUpDown5.Enabled = false;
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string jobType = comboBox2.Text;
            if (jobType == "Part-Time")
            {
                label22.Text = $"{jobType} jobs are not that many\nSo you may get less Jobs than usual";
            }
            else
            {
                label22.Text = "";
            }
        }

        private void Label22_Click(object sender, EventArgs e)
        {

        }

        private void CheckBox7_CheckedChanged(object sender, EventArgs e)
        {
            string lab13 = label13.Text;
            string lab14 = label14.Text;
            if (checkBox7.Checked)
            {
                numericUpDown3.Enabled = false;
                numericUpDown3.Value = 1;
                label13.Text = "All pages";
                label14.Text = "All pages";
                string message= "Selecting All pages means downloading all available Jobs within your search values\nIt may take a while\nMake Sure You have enough space in your computer";
                MessageBox.Show(message,"Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                label13.Text = lab13;
                label14.Text = lab14;
                numericUpDown3.Enabled = true;
                numericUpDown3.Value = 0;
            }
        }
    }
}
