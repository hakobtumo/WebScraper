using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;

namespace WebScraper
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label19 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label26 = new System.Windows.Forms.Label();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.progressBar6 = new System.Windows.Forms.ProgressBar();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.label22 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(597, 338);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label25);
            this.tabPage1.Controls.Add(this.label24);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.progressBar3);
            this.tabPage1.Controls.Add(this.progressBar2);
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.checkBox2);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.numericUpDown5);
            this.tabPage1.Controls.Add(this.numericUpDown4);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.checkBox4);
            this.tabPage1.Controls.Add(this.checkBox3);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.pictureBox3);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(589, 312);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Products";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.TabPage1_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(130, 263);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(101, 13);
            this.label25.TabIndex = 29;
            this.label25.Text = "0 items downloaded";
            this.label25.Visible = false;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(130, 166);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(101, 13);
            this.label24.TabIndex = 28;
            this.label24.Text = "0 items downloaded";
            this.label24.Visible = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(129, 72);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(101, 13);
            this.label23.TabIndex = 27;
            this.label23.Text = "0 items downloaded";
            this.label23.Visible = false;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(17, 278);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(211, 15);
            this.progressBar3.TabIndex = 26;
            this.progressBar3.Visible = false;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(17, 181);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(211, 15);
            this.progressBar2.TabIndex = 25;
            this.progressBar2.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(17, 87);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(211, 15);
            this.progressBar1.TabIndex = 24;
            this.progressBar1.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(563, 133);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(14, 15);
            this.label19.TabIndex = 23;
            this.label19.Text = "$";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(287, 131);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(109, 21);
            this.checkBox2.TabIndex = 22;
            this.checkBox2.Text = "enable price:";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged_1);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(476, 132);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(33, 17);
            this.label18.TabIndex = 21;
            this.label18.Text = "max";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(394, 132);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(30, 17);
            this.label17.TabIndex = 20;
            this.label17.Text = "min";
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Enabled = false;
            this.numericUpDown5.Location = new System.Drawing.Point(509, 132);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown5.TabIndex = 19;
            this.numericUpDown5.ValueChanged += new System.EventHandler(this.NumericUpDown5_ValueChanged);
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Enabled = false;
            this.numericUpDown4.Location = new System.Drawing.Point(423, 132);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(52, 20);
            this.numericUpDown4.TabIndex = 18;
            this.numericUpDown4.ValueChanged += new System.EventHandler(this.NumericUpDown4_ValueChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(88, 217);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(144, 17);
            this.label16.TabIndex = 17;
            this.label16.Text = "48 products per page";
            this.label16.Click += new System.EventHandler(this.Label16_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(80, 120);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(144, 17);
            this.label15.TabIndex = 16;
            this.label15.Text = "35 products per page";
            this.label15.Click += new System.EventHandler(this.Label15_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(80, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "50 products per page";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(424, 95);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(63, 20);
            this.numericUpDown1.TabIndex = 14;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(302, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Number of Pages:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(302, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Product Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Search For Products";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(94, 239);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(54, 21);
            this.checkBox4.TabIndex = 9;
            this.checkBox4.Text = "Etsy";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.CheckBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(89, 143);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(74, 21);
            this.checkBox3.TabIndex = 8;
            this.checkBox3.Text = "Alibaba";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.CheckBox3_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(90, 47);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(59, 21);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Ebay";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::WebScraper.Properties.Resources.alibaba;
            this.pictureBox3.Location = new System.Drawing.Point(17, 120);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(55, 55);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::WebScraper.Properties.Resources.etsy;
            this.pictureBox2.Location = new System.Drawing.Point(17, 217);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::WebScraper.Properties.Resources.ebay;
            this.pictureBox1.Location = new System.Drawing.Point(17, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(424, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(459, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label26);
            this.tabPage2.Controls.Add(this.progressBar4);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.numericUpDown2);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.pictureBox5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(589, 312);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "People";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.TabPage2_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(444, 107);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(129, 13);
            this.label26.TabIndex = 10;
            this.label26.Text = "0 people info downloaded";
            this.label26.Visible = false;
            this.label26.Click += new System.EventHandler(this.Label26_Click);
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(332, 124);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(240, 20);
            this.progressBar4.TabIndex = 9;
            this.progressBar4.Visible = false;
            this.progressBar4.Click += new System.EventHandler(this.ProgressBar4_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(441, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "20 people per page";
            this.label9.Click += new System.EventHandler(this.Label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(327, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Pages:";
            this.label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(382, 76);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(52, 20);
            this.numericUpDown2.TabIndex = 6;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.NumericUpDown2_ValueChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(462, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 31);
            this.button2.TabIndex = 5;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(327, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(458, 60);
            this.label6.TabIndex = 3;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(338, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Search For People In XING";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(382, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Image = global::WebScraper.Properties.Resources.xing;
            this.pictureBox5.Location = new System.Drawing.Point(6, 6);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(281, 113);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label28);
            this.tabPage3.Controls.Add(this.label27);
            this.tabPage3.Controls.Add(this.progressBar6);
            this.tabPage3.Controls.Add(this.progressBar5);
            this.tabPage3.Controls.Add(this.checkBox7);
            this.tabPage3.Controls.Add(this.label22);
            this.tabPage3.Controls.Add(this.comboBox2);
            this.tabPage3.Controls.Add(this.label21);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Controls.Add(this.checkBox6);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.pictureBox7);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.numericUpDown3);
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.checkBox5);
            this.tabPage3.Controls.Add(this.pictureBox6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(589, 312);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Jobs";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.TabPage3_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(174, 85);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(96, 13);
            this.label28.TabIndex = 21;
            this.label28.Text = "0 jobs downloaded";
            this.label28.Visible = false;
            this.label28.Click += new System.EventHandler(this.Label28_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(174, 193);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(96, 13);
            this.label27.TabIndex = 20;
            this.label27.Text = "0 jobs downloaded";
            this.label27.Visible = false;
            this.label27.Click += new System.EventHandler(this.Label27_Click);
            // 
            // progressBar6
            // 
            this.progressBar6.Location = new System.Drawing.Point(31, 101);
            this.progressBar6.Name = "progressBar6";
            this.progressBar6.Size = new System.Drawing.Size(239, 17);
            this.progressBar6.TabIndex = 19;
            this.progressBar6.Visible = false;
            this.progressBar6.Click += new System.EventHandler(this.ProgressBar6_Click);
            // 
            // progressBar5
            // 
            this.progressBar5.Location = new System.Drawing.Point(31, 209);
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(239, 17);
            this.progressBar5.TabIndex = 18;
            this.progressBar5.Visible = false;
            this.progressBar5.Click += new System.EventHandler(this.ProgressBar5_Click);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox7.Location = new System.Drawing.Point(473, 173);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(76, 19);
            this.checkBox7.TabIndex = 17;
            this.checkBox7.Text = "All pages";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.CheckBox7_CheckedChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(352, 204);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(0, 17);
            this.label22.TabIndex = 16;
            this.label22.Click += new System.EventHandler(this.Label22_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Full-Time",
            "Part-Time",
            "Contracts",
            "Third Party"});
            this.comboBox2.Location = new System.Drawing.Point(414, 142);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 15;
            this.comboBox2.Text = "None";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(333, 142);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(71, 17);
            this.label21.TabIndex = 14;
            this.label21.Text = "Job Type:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(340, 112);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(68, 17);
            this.label20.TabIndex = 13;
            this.label20.Text = "Job level:";
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.DisplayMember = "Senior";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Entry",
            "Mid",
            "Senior",
            "All Levels"});
            this.comboBox1.Location = new System.Drawing.Point(414, 111);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.Text = "None";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox6.Location = new System.Drawing.Point(160, 167);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(55, 21);
            this.checkBox6.TabIndex = 11;
            this.checkBox6.Text = "Dice";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.CheckBox6_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(155, 145);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 17);
            this.label14.TabIndex = 10;
            this.label14.Text = "20 jobs per page";
            this.label14.Click += new System.EventHandler(this.Label14_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::WebScraper.Properties.Resources.dice;
            this.pictureBox7.Location = new System.Drawing.Point(31, 142);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(117, 59);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 9;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.PictureBox7_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(155, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 17);
            this.label13.TabIndex = 8;
            this.label13.Text = "10 jobs per page";
            this.label13.Click += new System.EventHandler(this.Label13_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(454, 263);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 31);
            this.button3.TabIndex = 7;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(414, 172);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(46, 20);
            this.numericUpDown3.TabIndex = 6;
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.NumericUpDown3_ValueChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(414, 82);
            this.textBox3.MaxLength = 1700;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(113, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(352, 174);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "Pages:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(332, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "Job Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(351, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 24);
            this.label10.TabIndex = 2;
            this.label10.Text = "Search For Jobs";
            this.label10.Click += new System.EventHandler(this.Label10_Click);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.Location = new System.Drawing.Point(162, 61);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(70, 21);
            this.checkBox5.TabIndex = 1;
            this.checkBox5.Text = "Indeed";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.CheckBox5_CheckedChanged);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox6.Image = global::WebScraper.Properties.Resources.indeed;
            this.pictureBox6.Location = new System.Drawing.Point(31, 36);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(117, 59);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 341);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "WebScraper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;

        private async void GetEbayHtml(string search, decimal pageNum, decimal min, decimal max)
        {
            int i = 0;
            int itemsPerPage = 50;
            progressBar1.Visible = true;
            label23.Visible = true;
            var httpClient = new HttpClient();
            var htmlDocument = new HtmlDocument();
            var msgWarining = System.Windows.Forms.MessageBoxIcon.Warning;
            var msgButtonOk = System.Windows.Forms.MessageBoxButtons.OK;
            var msgError = System.Windows.Forms.MessageBoxIcon.Error;
            int skc = 200;
            for (int page = 1; page < pageNum + 1; page++)
            {
                string url = "";              
                if (page == 1)
                {
                    url = $"https://www.ebay.com/sch/i.html?_nkw={search}&_in_kw=1&_ex_kw=&_sacat=0&_udlo={min}&_udhi={max}&_ftrt=901&_ftrv=1&_sabdlo=&_sabdhi=&_samilow=&_samihi=&_sadis=15&_stpos=&_sargn=-1%26saslc%3D1&_salic=1&_sop=12&_dmd=1&_ipg=50&_fosrp=1";
                }
                else if (page > 1)
                {
                    url = $"https://www.ebay.com/sch/i.html?_sacat=0&_udlo={min}&_udhi={max}&_ftrt=901&_ftrv=1&_sabdlo=&_sabdhi=&_samilow=&_samihi=&_sadis=15&_stpos=&_sop=12&_dmd=1&_fosrp=1&_nkw={search}&_pgn={page}&_skc={page*skc}&rt=nc";
                }
                
                try
                {
                    var html = await httpClient.GetStringAsync(url);
                    await System.Threading.Tasks.Task.Run(() => htmlDocument.LoadHtml(html));
                }
                catch (HttpRequestException)
                {
                    System.Windows.Forms.MessageBox.Show("Problem with search or internet connection\nPlease make sure that you have searched something that exists\nAnd make sure you have internet connection\n\nAnd try again", "Warning", msgButtonOk, msgWarining);
                    System.Windows.Forms.Application.Exit();
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("something went wrong", ":(", msgButtonOk, msgError);
                    System.Windows.Forms.Application.Exit();
                }
                var ProductsHtml = htmlDocument.DocumentNode.Descendants("ul")
                    .Where(node => node.GetAttributeValue("id", "")
                    .Equals("ListViewInner")).ToList();
                if (ProductsHtml.Count == 0) break;

                var ProductsItemsList = ProductsHtml[0].Descendants("li")
                    .Where(node => node.GetAttributeValue("id", "")
                    .Contains("item")).ToList();
                if (ProductsItemsList.Count == 0) break;

                var Pagination = htmlDocument.DocumentNode.Descendants("td")
                    .Where(node => node.GetAttributeValue("class", "")
                    .Equals("pages")).ToList()[0].Descendants("a").ToList();

                bool isLoopNeeded = IsLoopNeeded(Pagination, page);
                
                if (!isLoopNeeded) break;
                foreach (var ProductItem in ProductsItemsList)
                {
                    try
                    {
                        i++;

                        int numberOfItemsToDownload = Convert.ToInt32(pageNum) * itemsPerPage;
                        int percentage = (i * 100) / numberOfItemsToDownload;

                        label23.Text = $"{i} items downloaded";
                        label23.Refresh();

                        progressBar1.Value = percentage;
                        var ProductImgSrc = ProductItem.Descendants("img")
                        .Where(node => node.GetAttributeValue("src", "")
                        .Contains("https")).ToList()[0];

                        var TitleOfProduct = ProductItem.Descendants("h3")
                        .Where(node => node.GetAttributeValue("class", "")
                        .Equals("lvtitle")).ToList()[0];

                        string ProductName = TitleOfProduct.InnerText;
                        string urlToProduct = TitleOfProduct.Descendants("a")
                                .ToList()[0].GetAttributeValue("href", "");

                        var ProductPrice = ProductItem.Descendants("span")
                        .Where(node => node.GetAttributeValue("class", "")
                        .Contains("bold")).ToList()[0].InnerText;

                        var ProductLocation = ProductItem.Descendants("ul")
                            .Where(node => node.GetAttributeValue("class", "")
                            .Equals("lvdetails left space-zero full-width")).ToList()[0].InnerText.Trim();

                        var ProductRatingDiv = ProductItem.Descendants("div")
                        .Where(node => node.GetAttributeValue("class", "")
                        .Contains("star-rating")).ToList();
                        string ProductRating = "NO RATING";
                        string reviewNum = "NO REVIEW";
                        if (ProductRatingDiv.Count == 1)
                        {
                            ProductRatingDiv = ProductRatingDiv[0].Descendants("a").ToList();
                            ProductRating = ProductRatingDiv[0].GetAttributeValue("aria-label", "").Split(',')[0];
                            reviewNum = "NUMBER OF REVIEWS: " + ProductRatingDiv[1].InnerText.Split(',')[0];
                        }

                        string textToWriteTXT = $"PRODUCT NAME: {ProductName} \nPRODUCT PRICE: {ProductPrice.Trim()}\nPRODUCT LOCATION:{ProductLocation}\n{ProductRating}\n{reviewNum}\n\nLINK TO PRODUCT: {urlToProduct}";

                        string urlOfImage = "";

                        if (ProductImgSrc.GetAttributeValue("src", "").Contains("gif"))
                        {
                            urlOfImage = ProductImgSrc.GetAttributeValue("imgurl", "");
                        }
                        else
                        {
                            urlOfImage = ProductImgSrc.GetAttributeValue("src", "");
                        }

                        if (urlOfImage.Length != 0)
                        {
                             CreateDirectoryAndFiles("ScrapedProducts", "Ebay", urlOfImage, i.ToString(), textToWriteTXT, false);
                        }
                    }
                    catch {  }     
                }

            }
            if (i == 0)
            {
                System.Windows.Forms.MessageBox.Show($"Ebay Done: {i} products were scraaped\nNothing was found with your search in Ebay.com", "Ebay", msgButtonOk, msgWarining);
                progressBar1.Value = 0;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show($"Ebay Done: {i} products were found and scraaped", "Ebay", msgButtonOk, System.Windows.Forms.MessageBoxIcon.Information);
                progressBar1.Value = 100;
            }
        }
        public async void GetEtsyHtml(string WhatToSearch, decimal pageNum, decimal min, decimal max)
        {
            int i = 0;
            int itemsPerPage = 48;
            progressBar3.Visible = true;
            label25.Visible = true;
            var msgWarining = System.Windows.Forms.MessageBoxIcon.Warning;
            var msgButtonOk = System.Windows.Forms.MessageBoxButtons.OK;
            var msgError = System.Windows.Forms.MessageBoxIcon.Error;
            var htmlDocument = new HtmlDocument();
            var httpClient = new HttpClient();
            try
            {
                var html = await httpClient.GetStringAsync($"https://www.etsy.com/search?q={WhatToSearch}&min={min}&max={max}");
                htmlDocument.LoadHtml(html);
            }
            catch (HttpRequestException)
            {
                System.Windows.Forms.MessageBox.Show("Problem with search or internet connection\nPlease make sure that you have searched something that exists\nAnd make sure you have internet connection\n\nAnd try again", "Warning", msgButtonOk, msgWarining);
                System.Windows.Forms.Application.Exit();
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Something Went Wrong", ":(", msgButtonOk, msgError);
                System.Windows.Forms.Application.Exit();
            }
            int x = 1;
            try
            {
                var paginationTab = htmlDocument.DocumentNode.Descendants("ul")
                       .Where(node => node.GetAttributeValue("class", "")
                       .Contains("wt-action-group")).ToList();

                var paginationLastTab = paginationTab[paginationTab.Count - 1].Descendants("a")
                       .Where(node => node.GetAttributeValue("class", "")
                       .Equals("wt-btn wt-btn--small wt-action-group__item")).ToList();

                var PaginationLastItem = paginationLastTab[paginationLastTab.Count - 1].Descendants("span")
                    .Where(node => node.GetAttributeValue("aria-hidden", "").
                    Equals("true")).ToList()[0].InnerText.Trim();
                Int32.TryParse(PaginationLastItem, out x);
            }
            catch { x = 30; }

            for (int page = 1; page < pageNum + 1; page++)
            {
                if (page > x) break;
                string url = "";

                if (page == 1)
                {
                    url = $"https://www.etsy.com/search?q={WhatToSearch}&min={min}&max={max}";
                }
                else if (page > 1)
                {
                    url = $"https://www.etsy.com/search?q={WhatToSearch}&ref=pagination&page={page}&min={min}&max={max}";
                }

                
                try
                {
                    var html = await httpClient.GetStringAsync(url);
                    await System.Threading.Tasks.Task.Run(() => htmlDocument.LoadHtml(html));
                }
                catch (HttpRequestException)
                {
                    System.Windows.Forms.MessageBox.Show("Problem with search or internet connection\nPlease make sure that you have searched something that exists\nAnd make sure you have internet connection\n\nAnd try again", "Warning", msgButtonOk, msgWarining);
                    System.Windows.Forms.Application.Exit();
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("Something Went Wrong", ":(", msgButtonOk, msgError);
                    System.Windows.Forms.Application.Exit();
                }

                var ProductsHtml = htmlDocument.DocumentNode.Descendants("ul")
                    .Where(node => node.GetAttributeValue("class", "")
                    .Contains("responsive-listing-grid")).ToList();
                if (ProductsHtml.Count == 0)
                {
                    break;
                }

                var ProductsItemsList = ProductsHtml[0].Descendants("li")
                    .Where(node => node.GetAttributeValue("class", "")
                    .Contains("wt-list-unstyled")).ToList();
                if (ProductsItemsList.Count == 0) break;


                foreach (var ProductItem in ProductsItemsList)
                {
                    try
                    {
                        i++;
                        int numberOfItemsToDownload = Convert.ToInt32(pageNum) * itemsPerPage;
                        int percentage = (i * 100) / numberOfItemsToDownload;

                        label25.Text = $"{i} items downloaded";
                        label25.Refresh();

                        progressBar3.Value = percentage;

                        var ProductImgSrc = ProductItem.Descendants("img")
                        .Where(node => node.GetAttributeValue("class", "")
                        .Contains("width-full")).ToList()[0].GetAttributeValue("src", "");

                        var ProductName = ProductItem.Descendants("h2")
                        .Where(node => node.GetAttributeValue("class", "")
                        .Contains("text-gray")).ToList()[0].InnerText;

                        var ProductPrice = ProductItem.Descendants("span")
                        .Where(node => node.GetAttributeValue("class", "")
                        .Contains("currency-value")).ToList()[0].InnerText;

                        var urlToProduct = ProductItem.Descendants("a")
                        .Where(node => node.GetAttributeValue("class", "")
                        .Contains("organic-impression")).ToList()[0].GetAttributeValue("href", "");


                        string textToWriteTXT = $"PRODUCT NAME: {ProductName.Trim()} \n\nPRODUCT PRICE: ${ProductPrice}\n\nLINK TO PRODUCT: {urlToProduct}";

                        if (ProductImgSrc.Length != 0)
                        {
                            CreateDirectoryAndFiles("ScrapedProducts", "Etsy", ProductImgSrc, i.ToString(), textToWriteTXT, false);
                        }
                        else if (ProductImgSrc.Length == 0)
                        {
                            ProductImgSrc = ProductItem.Descendants("img")
                               .Where(node => node.GetAttributeValue("class", "")
                               .Contains("w")).ToList()[0].GetAttributeValue("data-src", "");
                            CreateDirectoryAndFiles("ScrapedProducts", "Etsy", ProductImgSrc, i.ToString(), textToWriteTXT, false);
                        }
                    }
                    catch {  }
                }

            }
            if (i == 0)
            {
                System.Windows.Forms.MessageBox.Show($"Etsy Done: {i} products were scraaped\nNothing was found with your search in Etsy.com", "Etsy", msgButtonOk, msgWarining);
                progressBar3.Value = 0;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show($"Etsy Done: {i} products were found and scraaped", "Etsy", msgButtonOk, System.Windows.Forms.MessageBoxIcon.Information);
                progressBar3.Value = 100;
            }
        }
        public async void GetAlibabaHtml(string search, decimal pageNum, decimal min, decimal max)
        {
            int i = 0;
            int itemsPerPage = 35;
            var msgWarining = System.Windows.Forms.MessageBoxIcon.Warning;
            var msgButtonOk = System.Windows.Forms.MessageBoxButtons.OK;
            var msgError = System.Windows.Forms.MessageBoxIcon.Error;
            progressBar2.Visible = true;
            label24.Visible = true;
            var httpClient = new HttpClient();
            var htmlDocument = new HtmlDocument();
            for (int page = 1; page < pageNum + 1; page++)
            {
                string url = "";
                if (page == 1)
                {
                    url = $"https://www.alibaba.com/trade/search?SearchText={search}&pricef={min}&pricet={max}";
                }
                else if (page > 1)
                {
                    url = $"https://www.alibaba.com/trade/search?SearchText={search}&page={page}&pricef={min}&pricet={max}";
                }
                bool isUrlOk = false;
                string html;
                int infiniteLoopStoper = 0;
                bool isLoopNeeded = true;
                do
                {
                    infiniteLoopStoper++;
                    if (infiniteLoopStoper > 2)
                    {
                        isLoopNeeded = false;
                        break;
                    }
                    try
                    {
                        html = await httpClient.GetStringAsync(url);
                        htmlDocument.LoadHtml(html);
                    }
                    catch (HttpRequestException)
                    {
                        System.Windows.Forms.MessageBox.Show("Problem with search or internet connection\nPlease make sure that you have searched something that exists\nAnd make sure you have internet connection\n\nAnd try again", "Warning", msgButtonOk, msgWarining);
                        System.Windows.Forms.Application.Exit();
                    }
                    catch
                    {
                        System.Windows.Forms.MessageBox.Show("Something Went Wrong", ":(", msgButtonOk, msgError);
                        System.Windows.Forms.Application.Exit();
                    }
                    var ProductsHtmlTest = htmlDocument.DocumentNode.Descendants("div")
                        .Where(node => node.GetAttributeValue("data-content", "")
                        .Contains("ProductNormalList")).ToList();
                    if (ProductsHtmlTest.Count != 0)
                    {
                        isUrlOk = true;
                    }
                } while (!isUrlOk);
                if (!isLoopNeeded) break;

                var ProductsHtml = htmlDocument.DocumentNode.Descendants("div")
                        .Where(node => node.GetAttributeValue("data-content", "")
                        .Contains("ProductNormalList")).ToList();

                if (ProductsHtml.Count == 0) break;

                var ProductsItemsList = ProductsHtml[0].Descendants("div")
                    .Where(node => node.GetAttributeValue("class", "")
                    .Equals("item-main")).ToList();

                if (ProductsItemsList.Count <= 2)
                {
                    ProductsItemsList = ProductsHtml[0].Descendants("div")
                    .Where(node => node.GetAttributeValue("class", "")
                    .Contains("m-product-item list-item__v2")).ToList();

                }

                if (ProductsItemsList.Count == 0) break;


                foreach (var ProductItem in ProductsItemsList)
                {
                    try
                    {
                        var ProductPriceTest = ProductItem.Descendants("div")
                        .Where(node => node.GetAttributeValue("class", "")
                        .Contains("price")).ToList();

                        var ProductPrice = "";

                        if (ProductPriceTest.Count == 0)
                        {
                            ProductPrice = ProductItem.Descendants("div")
                        .Where(node => node.GetAttributeValue("class", "")
                        .Contains("list-item")).ToList()[0].InnerText.Trim();
                        }
                        else
                        {
                            ProductPrice = ProductPriceTest[0].InnerText.Trim();
                        }

                        i++;
                        int numberOfItemsToDownload = Convert.ToInt32(pageNum) * itemsPerPage;
                        int percentage = (i * 100) / numberOfItemsToDownload;

                        label24.Text = $"{i} items downloaded";
                        label24.Refresh();

                        progressBar2.Value = percentage;
                        var ImgTest = ProductItem.Descendants("img")
                        .Where(node => node.GetAttributeValue("src", "")
                        .Contains("//sc")).ToList();

                        var forNotPopularItems = ProductItem.Descendants("img")
                        .Where(node => node.GetAttributeValue("data-jssrc", "")
                        .Contains("//sc")).ToList();

                        var ProductImgSrc = "";
                        if (forNotPopularItems.Count != 1)
                        {
                            if (ImgTest.Count >= 1)
                            {
                                ProductImgSrc = ImgTest[0].GetAttributeValue("src", "");
                            }
                            else
                            {
                                ProductImgSrc = ProductItem.Descendants("img")
                            .Where(node => node.GetAttributeValue("src", "")
                            .Contains("//img")).ToList()[0].GetAttributeValue("data-src", "");
                            }
                        }
                        else
                        {
                            ProductImgSrc = forNotPopularItems[0].GetAttributeValue("data-jssrc", "");
                        }
                        var ProductName = ProductItem.Descendants("img")
                        .Where(node => node.GetAttributeValue("src", "")
                        .Contains("//")).ToList()[0].GetAttributeValue("alt", "");

                        if (ProductName == "")
                        {
                            ProductName = ProductItem.Descendants("a")
                                .Where(node => node.GetAttributeValue("data-topranking", "")
                                .Contains("record")).ToList()[0].InnerText.Trim();
                        }

                        var urlToProduct = "https:" + ProductItem.Descendants("h2")
                        .Where(node => node.GetAttributeValue("class", "")
                        .Contains("title")).ToList()[0].Descendants("a").ToList()[0].GetAttributeValue("href", "");

                        var ProductDate = ProductItem.Descendants("div")
                        .Where(node => node.GetAttributeValue("class", "")
                        .Contains("s-gold-supplier-year-icon")).ToList()[0].InnerText;

                        var ProductReview = ProductItem.Descendants("span")
                       .Where(node => node.GetAttributeValue("class", "")
                       .Equals("list-item__company-record-num")).ToList();

                        var ProductReviewNum = ProductItem.Descendants("span")
                       .Where(node => node.GetAttributeValue("class", "")
                       .Equals("li-reviews-score__review-count")).ToList();

                        string ProductRating = "";
                        string ProductsOwnerEarned = "";
                        string ProductsOwnerContactInPercantage = "";

                        foreach (var el in ProductReview)
                        {
                            string elText = el.InnerText.Trim();
                            if (elText.Contains("+")) ProductsOwnerEarned = "MONEY EARNED BY PRODUCT\'S OWNER IN ALIBABA: " + "$" + elText + "\n";
                            if (elText.Contains("%")) ProductsOwnerContactInPercantage = "\nPERCENTAGE OF PEOPLE WHO COULD GET IN TOUCH WITH PRODUCT\'S OWNER WITHIN 24 HOUR AFTER BUYING THE PRODUCT: " + elText + "\n";
                            else ProductRating = "PRODUCT REVIEW: " + elText + " out of 5 ";
                        }
                        if (ProductReviewNum.Count == 1) ProductRating += $"NUMBER OF REVIEWS: {ProductReviewNum[0].InnerText.Trim()}\n";
                        string textToWriteTXT = $"PRODUCT NAME: {ProductName} \nPRODUCT PRICE: {ProductPrice.Trim()}\nPRODUCT DATE:{ProductDate.Trim()}\n{ProductRating}{ProductsOwnerEarned}{ProductsOwnerContactInPercantage}\nLINK TO PRODUCT:\n{urlToProduct}";

                        if (ProductImgSrc.Length != 0)
                        {
                            CreateDirectoryAndFiles("ScrapedProducts", "Alibaba", ProductImgSrc, i.ToString(), textToWriteTXT, true);
                        }

                    }
                    catch { }
                }

            }
            if (i == 0)
            {
                System.Windows.Forms.MessageBox.Show($"Alibaba Done: {i} products were scraaped\nNothing was found with your search in Alibaba.com", "Alibaba", msgButtonOk, msgWarining);
                progressBar2.Value = 0;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show($"Alibaba Done: {i} products were found and scraaped", "Alibaba", msgButtonOk, System.Windows.Forms.MessageBoxIcon.Information);
                progressBar2.Value = 100;
            }
        }
        public async void GetXingHtml(string name, decimal pageNum)
        {
            int i = 0;
            var msgWarining = System.Windows.Forms.MessageBoxIcon.Warning;
            var msgButtonOk = System.Windows.Forms.MessageBoxButtons.OK;
            var msgError=  System.Windows.Forms.MessageBoxIcon.Error;
            progressBar4.Visible = true;
            label26.Visible = true;
            int itemsPerPage = 20;
            var httpClient = new HttpClient();
            var htmlDocument = new HtmlDocument();
            for (int page = 1; page < pageNum + 1; page++)
            {
                string url = "";

                if (page == 1)
                {
                    url = $"https://www.xing.com/publicsearch/query?utf8=%E2%9C%93&q={name}";
                }
                else if (page > 1)
                {
                    url = $"https://www.xing.com/publicsearch/query?page={page}&q={name}";
                }

                try
                {
                    var html = await httpClient.GetStringAsync(url);
                    htmlDocument.LoadHtml(html);
                }
                catch (HttpRequestException)
                {
                    System.Windows.Forms.MessageBox.Show("Problem with search or internet connection\nPlease make sure that you have searched something that exists\nAnd make sure you have internet connection\n\nAnd try again", "Warning",msgButtonOk,msgWarining);
                    System.Windows.Forms.Application.Exit();
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("Something Went Wrong", ":(",msgButtonOk,msgError);
                    System.Windows.Forms.Application.Exit();
                }

                var ProductsHtml = htmlDocument.DocumentNode.Descendants("div")
                    .Where(node => node.GetAttributeValue("class", "")
                    .Equals("SearchResultsContainer")).ToList();

                if (ProductsHtml.Count == 0) break;

                var ProductsItemsList = ProductsHtml[0].Descendants("li")
                    .Where(node => node.GetAttributeValue("class", "")
                    .Equals("SearchResults-item")).ToList();

                if (ProductsItemsList.Count == 0) break;

                var Pagination = htmlDocument.DocumentNode.Descendants("li")
                    .Where(node => node.GetAttributeValue("class", "")
                    .Equals("foundation-hide-phone")).ToList()[0].Descendants("a").ToList();

                bool isLoopNeeded = IsLoopNeeded(Pagination, page);
                if (!isLoopNeeded)
                {
                    break;
                }
                foreach (var ProductItem in ProductsItemsList)
                {
                    try
                    {
                        i++;
                        var userImg = ProductItem.Descendants("img")
                        .Where(node => node.GetAttributeValue("class", "")
                        .Contains("user-photo")).ToList()[0].GetAttributeValue("src", "");

                        userImg = userImg.Replace("96", "256");

                        var userName = ProductItem.Descendants("a")
                        .Where(node => node.GetAttributeValue("class", "")
                        .Equals("name-page-link")).ToList()[0].InnerText;

                        var userLocation = ProductItem.Descendants("div")
                        .Where(node => node.GetAttributeValue("class", "")
                        .Equals("SearchResults-location")).ToList()[0].InnerText.Trim();

                        var userOccupation = ProductItem.Descendants("div")
                        .Where(node => node.GetAttributeValue("class", "")
                        .Equals("SearchResults-occupation")).ToList()[0].InnerText.Trim();
                        //ProductPrice=ProductPrice[0].ToString()=="\n" ?  ProductPrice.Split(new[] { "\n\t\t\t\t\t" }, StringSplitOptions.None)[0] : ProductPrice;


                        string textToWriteTXT = $"USER'S NAME: {userName} \nUSER LOCATION: {userLocation}\n USER OCCUPATION: {userOccupation}";

                        int numberOfItemsToDownload = Convert.ToInt32(pageNum) * itemsPerPage;
                        int percentage = (i * 100) / numberOfItemsToDownload;

                        label26.Text = $"{i} people info downloaded";
                        label26.Refresh();

                        progressBar4.Value = percentage;

                        try
                        {
                            CreateDirectoryAndFiles("ScrapedPeople", "Xing", userImg, i.ToString(), textToWriteTXT, false);
                        }
                        catch
                        {
                            userImg = userImg.Replace("256", "96");
                            CreateDirectoryAndFiles("ScrapedPeople", "Xing", userImg, i.ToString(), textToWriteTXT, false);
                        }
                    }
                    catch { }
                }

            }

            if (i == 0)
            {
                System.Windows.Forms.MessageBox.Show($"Xing Done: {i} people were scraaped\nNothing was found with your search in Xing.com", "Xing", msgButtonOk, msgWarining);
                progressBar4.Value = 0;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show($"Xing Done: {i} people were found and scraaped", "Xing", msgButtonOk, System.Windows.Forms.MessageBoxIcon.Information);
                progressBar4.Value = 100;
            }
        }
        public async void GetIndeedHtml(string name,decimal pageNum, string jobLevel,string jobType)
        {    
            int i = 0;
            int itemsPerPage = 10;
            var httpClient = new HttpClient();
            var htmlDocument = new HtmlDocument();
            var msgWarining = System.Windows.Forms.MessageBoxIcon.Warning;
            var msgButtonOk = System.Windows.Forms.MessageBoxButtons.OK;
            var msgError = System.Windows.Forms.MessageBoxIcon.Error;
            progressBar6.Visible = true;
            label28.Visible = true;
            for (int page = 1; page < pageNum+1; page++)
            {
                string url = "";

                if (page == 1)
                {
                    url = $"https://www.indeed.com/jobs?q={name}&jt={jobType}&explvl={jobLevel}";
                }
                else if (page > 1)
                {
                    url = $"https://www.indeed.com/jobs?q={name}&jt={jobType}&explvl={jobLevel}&start={(page - 1) * 10}";
                }
                
                try
                {
                    var html = await httpClient.GetStringAsync(url);
                    htmlDocument.LoadHtml(html);
                }
                catch (HttpRequestException)
                {
                    System.Windows.Forms.MessageBox.Show("Problem with search or internet connection\nPlease make sure that you have searched something that exists\nAnd make sure you have internet connection\n\nAnd try again", "Warning", msgButtonOk, msgWarining);
                    System.Windows.Forms.Application.Exit();
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("Something Went Wrong", ":(", msgButtonOk, msgError);
                    System.Windows.Forms.Application.Exit();
                }

                var ProductsHtml = htmlDocument.DocumentNode.Descendants("td")
                    .Where(node => node.GetAttributeValue("id", "")
                    .Equals("resultsCol")).ToList();

                if (ProductsHtml.Count == 0) break;

                var ProductsItemsList = ProductsHtml[0].Descendants("div")
                    .Where(node => node.GetAttributeValue("class", "")
                    .Contains("jobsearch-SerpJobCard unifiedRow")).ToList();
                if (ProductsItemsList.Count == 0) break;

                var Pagination = ProductsHtml[0].Descendants("span")
                   .Where(node => node.GetAttributeValue("class", "")
                   .Equals("pn")).ToList();


                bool isLoopNeeded = IsLoopNeeded(Pagination, page);

                if (!isLoopNeeded)
                {                  
                    break;
                }

                foreach (var ProductItem in ProductsItemsList)
                {
                    try
                    {
                        i++;
                        var jobTitle = ProductItem.Descendants("div")
                        .Where(node => node.GetAttributeValue("class", "")
                        .Contains("title")).ToList()[0];

                        string jobName = jobTitle.Descendants("a").ToList()[0].InnerText.Trim();

                        string idForUrl = jobTitle.Descendants("a")
                        .Where(node => node.GetAttributeValue("target", "")
                        .Equals("_blank")).ToList()[0].GetAttributeValue("id", "");

                        string[] trimmedUrl = idForUrl.Split(new[] { "jl_" }, StringSplitOptions.None);
                        string urlToJob = "No Url";

                        if (trimmedUrl.Length == 2)
                        {
                            urlToJob = "https://www.indeed.com/viewjob?jk=" + trimmedUrl[1];
                        }

                        var companyName = ProductItem.Descendants("span")
                        .Where(node => node.GetAttributeValue("class", "")
                        .Equals("company")).ToList()[0].InnerText.Trim();


                        var jobLocationArr = ProductItem.Descendants("span")
                        .Where(node => node.GetAttributeValue("class", "")
                        .Contains("location")).ToList();

                        string jobLocation = "Location does not exist";

                        if (jobLocationArr.Count != 0)
                        {
                            jobLocation = jobLocationArr[0].InnerText.Trim();
                        }

                        label28.Text = $"{i} jobs downloaded";
                        label28.Refresh();
                        if (!checkBox7.Checked)
                        {
                            
                            int numberOfItemsToDownload = Convert.ToInt32(pageNum) * itemsPerPage;
                            int percentage = (i * 100) / numberOfItemsToDownload;
                            progressBar6.Value = percentage;
                        }
                        else
                        {
                            
                            progressBar6.Style.Equals("Continuous");
                            progressBar6.Value = 30;
                           
                        }
                        

                        var jobReviewArr = ProductItem.Descendants("span")
                        .Where(node => node.GetAttributeValue("class", "")
                        .Equals("slNoUnderline")).ToList();

                        string jobReviewNum = jobReviewArr.Count == 0 ? "No Reviews" : jobReviewArr[0].InnerText;
                        string jobRating = "";
                        if (jobReviewNum != "No Reviews")
                        {
                            jobRating = ProductItem.Descendants("span")
                                .Where(node => node.GetAttributeValue("aria-label", "")
                                .Contains("rating")).ToList()[0].GetAttributeValue("aria-label", "");
                        }

                        string jobSummary = ProductItem.Descendants("div")
                                .Where(node => node.GetAttributeValue("class", "")
                                .Equals("summary")).ToList()[0].InnerText.Trim();

                        string textForTXT = $"Job Name: {jobName}\n\nCompany Name: {companyName}\n\nJob Location: {jobLocation}\n\nNumber of reviews: {jobReviewNum}\t-\t{(jobRating.Length == 0 ? "" : jobRating)}\n\nSummary Of Job: \n{jobSummary}\n\nUrl To Job:{urlToJob}";

                        CreateFolderAndTXT("ScrapedJobs", "Indeed", i.ToString(), textForTXT);
                    }
                    catch {  }
                }
            }
            if (i == 0)
            {
                System.Windows.Forms.MessageBox.Show($"Indeed Done: {i} jobs were scraaped\nNothing was found with your search in Indeed.com", "Indeed", msgButtonOk, msgWarining);
                progressBar6.Value = 0;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show($"Indeed Done: {i} jobs scraaped", "Indeed", msgButtonOk, System.Windows.Forms.MessageBoxIcon.Information);
                progressBar6.Value = 100;
            }
        }
        public async void GetDiceHtml(string name, decimal pageNum, string jobType)
        {
            int i = 0;
            var msgWarining = System.Windows.Forms.MessageBoxIcon.Warning;
            var msgButtonOk = System.Windows.Forms.MessageBoxButtons.OK;
            var msgError = System.Windows.Forms.MessageBoxIcon.Error;
            progressBar5.Visible = true;
            label27.Visible = true;
            int itemsPerPage = 20;
            for (int page = 1; page < pageNum + 1; page++)
            {
                string url = "";

                if (page == 1)
                {
                    url = $"https://www.dice.com/jobs?q={name}&jtype={jobType}";
                }
                else if (page > 1)
                {
                    url = $"https://www.dice.com/jobs?q={name}&jtype={jobType}&p={page}";
                }
                var httpClient = new HttpClient();
                var htmlDocument = new HtmlDocument();
                try
                {
                    var html = await httpClient.GetStringAsync(url);
                    htmlDocument.LoadHtml(html);
                }
                catch (HttpRequestException)
                {
                    System.Windows.Forms.MessageBox.Show("Problem with search or internet connection\nPlease make sure that you have searched something that exists\nAnd make sure you have internet connection\n\nAnd try again", "Warning", msgButtonOk, msgWarining);
                    System.Windows.Forms.Application.Exit();
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("Something Went Wrong", ":(", msgButtonOk, msgError);
                    System.Windows.Forms.Application.Exit();
                }


                var ProductsHtml = htmlDocument.DocumentNode.Descendants("div")
                    .Where(node => node.GetAttributeValue("id", "")
                    .Equals("search-results-control")).ToList();
                if (ProductsHtml.Count == 0) break;

                var ProductsItemsList = ProductsHtml[0].Descendants("div")
                    .Where(node => node.GetAttributeValue("class", "")
                    .Contains("serp-result-conten")).ToList();

                if (ProductsItemsList.Count == 0) break;
                var Pagination = ProductsHtml[0].Descendants("a")
                    .Where(node => node.GetAttributeValue("title", "")
                    .Contains("Go to page")).ToList();

                bool isLoopNeeded = IsLoopNeeded(Pagination, page);

                if (!isLoopNeeded) break;

                foreach (var ProductItem in ProductsItemsList)
                {
                    i++;
                    var job = ProductItem.Descendants("a")
                    .Where(node => node.GetAttributeValue("class", "")
                    .Contains("loggedInVisited")).ToList()[0];

                    string jobTitle = job.InnerText.Trim();
                    string urlToJob = "https://www.dice.com" + job.GetAttributeValue("href", "");

                    var companyName = ProductItem.Descendants("span")
                    .Where(node => node.GetAttributeValue("class", "")
                    .Equals("compName")).ToList()[0].InnerText.Trim();

                    label27.Text = $"{i} jobs downloaded";
                    label27.Refresh();
                    if (!checkBox7.Checked)
                    {
                        int numberOfItemsToDownload = Convert.ToInt32(pageNum) * itemsPerPage;
                        int percentage = (i * 100) / numberOfItemsToDownload;
                        progressBar5.Value = percentage;
                    }
                    else
                    {
                        progressBar5.Style.Equals("Continuous");
                        progressBar5.Value = 30;
                    }
                    var jobLocation = ProductItem.Descendants("span")
                    .Where(node => node.GetAttributeValue("class", "")
                    .Equals("jobLoc")).ToList()[0].InnerText.Trim();

                    var jobDate = ProductItem.Descendants("li")
                    .Where(node => node.GetAttributeValue("class", "")
                    .Contains("posted")).ToList()[0].Descendants("span")
                        .Where(node => node.GetAttributeValue("style", "")
                        .Equals("display:none;")).ToList()[0].InnerText.Trim();

                    var imgUrlArr = ProductItem.Descendants("img")
                        .Where(node => node.GetAttributeValue("src", "")
                        .Contains("//")).ToList();

                    string imgUrl = "";
                    if (imgUrlArr.Count != 0)
                    {
                        imgUrl = "https:" + imgUrlArr[0].GetAttributeValue("src", "");
                    }


                    string jobSummary = ProductItem.Descendants("div")
                                .Where(node => node.GetAttributeValue("class", "")
                                .Contains("shortdesc")).ToList()[0].InnerText.Trim();

                    string textForTXT = $"Job Name: {jobTitle}\n\nCompany Name: {companyName}\n\nJob Location: {jobLocation}\n\nJob Posted Date: {jobDate}\n\nJob Summary:\n{jobSummary}\n\nUrl To Job:{urlToJob}";

                    CreateDirectoryAndFiles("ScrapedJobs", "Dice", imgUrl, i.ToString(), textForTXT, false);

                }
            }
            if (i == 0)
            {
                System.Windows.Forms.MessageBox.Show($"Dice Done: {i} jobs were scraaped\nNothing was found with your search in Dice.com", "Dice", msgButtonOk, msgWarining);
                progressBar5.Value = 0;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show($"Dice Done: {i} jobs were found and scraaped", "Dice", msgButtonOk, System.Windows.Forms.MessageBoxIcon.Information);
                progressBar5.Value = 100;
            }
        }
        private static void CreateFolderAndTXT(string categoryName, string webSiteName, string nameOfImageAndFolder, string textToWriteTXT)
        {
            
            string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string finalPath = path + "\\Desktop\\" + categoryName + "\\" + webSiteName;
            var a = Directory.CreateDirectory(finalPath);
            var myFile = File.Create(finalPath + $"\\{nameOfImageAndFolder}.txt");
            myFile.Close();
            CreateAndWriteTXT(textToWriteTXT, finalPath + $"\\{nameOfImageAndFolder}.txt");
            
        }
        private static void CreateDirectoryAndFiles(string categoryName,string webSiteName, string url, string nameOfImageAndFolder, string textToWriteTXT, bool isAlibabaScraping)
        {
            WebClient client = new WebClient();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            
            string finalPath = path + "\\Desktop\\" + categoryName + "\\" + webSiteName + "\\" + nameOfImageAndFolder;
            var a = Directory.CreateDirectory(finalPath);
            var myFile = File.Create(finalPath + $"\\{nameOfImageAndFolder}.txt");
            myFile.Close();
            CreateAndWriteTXT(textToWriteTXT, finalPath + $"\\{nameOfImageAndFolder}.txt");
            if (isAlibabaScraping)
            {
                try
                {
                    client.DownloadFileAsync(new Uri("https:" + url), $@"{finalPath}\{nameOfImageAndFolder}.jpg");
                }
                catch
                {
                    client.DownloadFile("https://www.kvanetwork.com/images/no_uploaded.png", $@"{finalPath}\{nameOfImageAndFolder}.jpg");
                }
            }
            else
            {
                if (url != "")
                {
                    try
                    {
                        client.DownloadFileAsync(new Uri(url), $@"{finalPath}\{nameOfImageAndFolder}.jpg");
                    }catch
                    {
                        client.DownloadFile("https://www.kvanetwork.com/images/no_uploaded.png", $@"{finalPath}\{nameOfImageAndFolder}.jpg");
                    }
                }             
            }
            
        }
        public static bool IsLoopNeeded(List<HtmlNode> Pagination, int page)
        {
            bool isLoopNeeded = false;

            foreach (var item in Pagination)
            {
                int x = -1;
                Int32.TryParse(item.InnerText, out x);
                if (x >= page)
                {
                    isLoopNeeded = true;
                }
                if (isLoopNeeded) break;
            }
            return isLoopNeeded;
        }
        public static void CreateAndWriteTXT(string text, string path)
        {
            if (!File.Exists(path))
            {

                TextWriter tw = new StreamWriter(path);
                tw.WriteAsync(text);
                tw.Close();
                File.Delete(path);
            }
            else if (File.Exists(path))
            {
                using (var tw = new StreamWriter(path, true))
                {
                    tw.WriteLine(text);
                }
            }
        }
      
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.ProgressBar progressBar6;
        private System.Windows.Forms.ProgressBar progressBar5;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
    }
}

