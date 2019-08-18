﻿using HtmlAgilityPack;
using System;
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.checkBox4);
            this.tabPage1.Controls.Add(this.checkBox3);
            this.tabPage1.Controls.Add(this.checkBox2);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.pictureBox4);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(426, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "50 products per page";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(357, 118);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(63, 20);
            this.numericUpDown1.TabIndex = 14;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(229, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Number of Pages:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Product Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Search For Products";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(96, 255);
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
            this.checkBox3.Location = new System.Drawing.Point(96, 188);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(74, 21);
            this.checkBox3.TabIndex = 8;
            this.checkBox3.Text = "Alibaba";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.CheckBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(96, 118);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(78, 21);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "Amazon";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(96, 49);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(59, 21);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Ebay";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Image = global::WebScraper.Properties.Resources.amazon;
            this.pictureBox4.Location = new System.Drawing.Point(31, 93);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::WebScraper.Properties.Resources.alibaba;
            this.pictureBox3.Location = new System.Drawing.Point(31, 163);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::WebScraper.Properties.Resources.etsy;
            this.pictureBox2.Location = new System.Drawing.Point(31, 230);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::WebScraper.Properties.Resources.ebay;
            this.pictureBox1.Location = new System.Drawing.Point(31, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(357, 84);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(589, 312);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "People";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.TabPage2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(589, 312);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Jobs";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.TabPage3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 341);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;

        private static async void GetEbayHtml(string WhatToSearch,decimal pageNum)
        {
            
            string search = WhatToSearch;
            int i = 0;
            for (int page = 1; page < pageNum+1; page++)
            {
                string url = "";
                int skc = 200;
                if (page == 1)
                {
                    url = $"https://www.ebay.com/sch/i.html?_sacat=0&LH_Complete=1&_udlo=&_udhi=&_samilow=&_samihi=&_sadis=15&_stpos=&_sop=12&_dmd=1&_fosrp=1&_nkw={search}&rt=nc";
                }
                else if (page > 1)
                {
                    url = $"https://www.ebay.com/sch/i.html?_sacat=0&LH_Complete=1&_udlo=&_udhi=&_samilow=&_samihi=&_sadis=15&_stpos=&_sop=12&_dmd=1&_fosrp=1&_nkw={search}&_pgn={page}&_skc={page * skc}&rt=nc";
                }

                var httpClient = new HttpClient();
                var html = await httpClient.GetStringAsync(url);
                var htmlDocument = new HtmlDocument();
                htmlDocument.LoadHtml(html);

                var ProductsHtml = htmlDocument.DocumentNode.Descendants("ul")
                    .Where(node => node.GetAttributeValue("id", "")
                    .Equals("ListViewInner")).ToList();

                var ProductsItemsList = ProductsHtml[0].Descendants("li")
                    .Where(node => node.GetAttributeValue("id", "")
                    .Contains("item")).ToList();

                foreach (var ProductItem in ProductsItemsList)
                {
                    i++;
                    var ProductImgSrc = ProductItem.Descendants("img")
                    .Where(node => node.GetAttributeValue("src", "")
                    .Contains("https")).ToList()[0];

                    var ProductName = ProductItem.Descendants("h3")
                    .Where(node => node.GetAttributeValue("class", "")
                    .Equals("lvtitle")).ToList()[0].InnerText;

                    var ProductPrice = ProductItem.Descendants("span")
                    .Where(node => node.GetAttributeValue("class", "")
                    .Contains("bold")).ToList()[0].InnerText;

                    //ProductPrice=ProductPrice[0].ToString()=="\n" ?  ProductPrice.Split(new[] { "\n\t\t\t\t\t" }, StringSplitOptions.None)[0] : ProductPrice;

                    var ProductDate = ProductItem.Descendants("span")
                    .Where(node => node.GetAttributeValue("class", "")
                    .Equals("tme")).ToList()[0].Descendants("span").ToList()[0].InnerText;

                    string textToWriteTXT = $"PRODUCT NAME: {ProductName} \nPRODUCT PRICE: {ProductPrice.Trim()}\nPRODUCT DATE:{ProductDate}";

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
                        CreateDirectoryAndFiles("ScrapedProducts","Ebay",urlOfImage, i.ToString(), textToWriteTXT,false);
                    }              
                }

            }

        }
        public static async void GetEtsyHtml(string WhatToSearch, decimal pageNum)
        {
            int i = 0;
            
            for (int page = 1; page < pageNum+1; page++)
            {
                string url = "";

                if (page == 1)
                {
                    url = $"https://www.etsy.com/search?q={WhatToSearch}";
                }
                else if (page > 1)
                {
                    url = $"https://www.etsy.com/search?q={WhatToSearch}&ref=pagination&page={page}";
                }

                var httpClient = new HttpClient();
                var html = await httpClient.GetStringAsync(url);
                var htmlDocument = new HtmlDocument();
                htmlDocument.LoadHtml(html);

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

                foreach (var ProductItem in ProductsItemsList)
                {
                    i++;
                    var ProductImgSrc = ProductItem.Descendants("img")
                    .Where(node => node.GetAttributeValue("class", "")
                    .Contains("width-full")).ToList()[0].GetAttributeValue("src", "");

                    var ProductName = ProductItem.Descendants("h2")
                    .Where(node => node.GetAttributeValue("class", "")
                    .Contains("text-gray")).ToList()[0].InnerText;

                    var ProductPrice = ProductItem.Descendants("span")
                    .Where(node => node.GetAttributeValue("class", "")
                    .Contains("currency-value")).ToList()[0].InnerText;

                    //ProductPrice=ProductPrice[0].ToString()=="\n" ?  ProductPrice.Split(new[] { "\n\t\t\t\t\t" }, StringSplitOptions.None)[0] : ProductPrice;


                    string textToWriteTXT = $"PRODUCT NAME: {ProductName.Trim()} \nPRODUCT PRICE: ${ProductPrice}\n";

                    if (ProductImgSrc.Length != 0)
                    {
                        CreateDirectoryAndFiles("ScrapedProducts", "Etsy", ProductImgSrc, i.ToString(), textToWriteTXT,false);
                    }
                    else if (ProductImgSrc.Length == 0)
                    {
                        ProductImgSrc = ProductItem.Descendants("img")
                           .Where(node => node.GetAttributeValue("class", "")
                           .Contains("w")).ToList()[0].GetAttributeValue("data-src", "");
                        CreateDirectoryAndFiles("ScrapedProducts", "Etsy", ProductImgSrc, i.ToString(), textToWriteTXT,false);
                    }
                }

            }

        }
        public static async void GetAlibabaHtml(string search,decimal pageNum)
        {           
            int i = 0;
            
            for (int page = 1; page < pageNum+1; page++)
            {
                string url = "";
                var httpClient = new HttpClient();
                var htmlDocument = new HtmlDocument();
                if (page == 1)
                {
                    url = $"https://www.alibaba.com/trade/search?SearchText={search}";
                }
                else if (page > 1)
                {
                    url = $"https://www.alibaba.com/trade/search?SearchText={search}&page={page}";
                }
                bool isUrlOk = false;
                string html;
                do
                {
                    html = await httpClient.GetStringAsync(url);
                    htmlDocument.LoadHtml(html);
                    Console.WriteLine("yeeeeeeeeeeeeeeeeeeee");
                    var ProductsHtmlTest = htmlDocument.DocumentNode.Descendants("div")
                        .Where(node => node.GetAttributeValue("data-content", "")
                        .Contains("ProductNormalList")).ToList();
                    if (ProductsHtmlTest.Count != 0)
                    {
                        isUrlOk = true;
                    }
                } while (!isUrlOk);

                var ProductsHtml = htmlDocument.DocumentNode.Descendants("div")
                        .Where(node => node.GetAttributeValue("data-content", "")
                        .Contains("ProductNormalList")).ToList();

                var ProductsItemsList = ProductsHtml[0].Descendants("div")
                    .Where(node => node.GetAttributeValue("class", "")
                    .Equals("item-main")).ToList();
                if (ProductsItemsList.Count <= 2)
                {
                    ProductsItemsList = ProductsHtml[0].Descendants("div")
                    .Where(node => node.GetAttributeValue("class", "")
                    .Contains("m-product-item list-item__v2")).ToList();
                    Console.WriteLine("inside");
                }

                foreach (var ProductItem in ProductsItemsList)
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
                    //ProductPrice=ProductPrice[0].ToString()=="\n" ?  ProductPrice.Split(new[] { "\n\t\t\t\t\t" }, StringSplitOptions.None)[0] : ProductPrice;

                    var ProductDate = ProductItem.Descendants("div")
                    .Where(node => node.GetAttributeValue("class", "")
                    .Contains("s-gold-supplier-year-icon")).ToList()[0].InnerText;

                    string textToWriteTXT = $"PRODUCT NAME: {ProductName} \nPRODUCT PRICE: {ProductPrice}\nPRODUCT DATE:{ProductDate}";

                    if (ProductImgSrc.Length != 0)
                    {
                            CreateDirectoryAndFiles("ScrapedProducts", "Alibaba", ProductImgSrc, i.ToString(), textToWriteTXT, true);      
                    }


                }

            }

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
                client.DownloadFile(new Uri("https:"+url), $@"{finalPath}\{nameOfImageAndFolder}.jpg");
            }
            else
            {
                client.DownloadFile(new Uri(url), $@"{finalPath}\{nameOfImageAndFolder}.jpg");
            }
            
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

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

