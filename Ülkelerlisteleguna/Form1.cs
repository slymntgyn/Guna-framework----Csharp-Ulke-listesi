using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;
namespace Ülkelerlisteleguna
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string connection = "https://api.livescorexml.com/?user=demo&password=123456&get=areas";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void asya_Click(object sender, EventArgs e)
        {
            XDocument ülkeler = XDocument.Load(connection);
            listBox1.Items.Clear();
            for (int i = 2; i < 50; i++)
            {
                var ülkeadiadi = ülkeler.Descendants("area").ElementAt(i).Attribute("name").Value;
                var kodu = ülkeler.Descendants("area").ElementAt(i).Attribute("countrycode").Value;
                listBox1.Items.Add(ülkeadiadi + " Asya kıtasında bulunmaktadır kodu : " + kodu);
            }
        }

        private void afrika_Click(object sender, EventArgs e)
        {
            XDocument ülkeler = XDocument.Load(connection);
            listBox1.Items.Clear();
            for (int i = 51; i < 110; i++)
            {
                var ülkeadiadi = ülkeler.Descendants("area").ElementAt(i).Attribute("name").Value;
                var kodu = ülkeler.Descendants("area").ElementAt(i).Attribute("countrycode").Value;
                listBox1.Items.Add(ülkeadiadi + " afrika kıtasında bulunmaktadır kodu : " + kodu);
            }
        }

        private void kuzeyamerika_Click(object sender, EventArgs e)
        {
            XDocument ülkeler = XDocument.Load(connection);
            listBox1.Items.Clear();
            for (int i = 111; i < 156; i++)
            {
                var ülkeadiadi = ülkeler.Descendants("area").ElementAt(i).Attribute("name").Value;
                var kodu = ülkeler.Descendants("area").ElementAt(i).Attribute("countrycode").Value;
                listBox1.Items.Add(ülkeadiadi + " kuzey Amerikda bulunmaktadır kodu : " + kodu);
            }
        }

        private void güneyamerika_Click(object sender, EventArgs e)
        {
            XDocument ülkeler = XDocument.Load(connection);
            listBox1.Items.Clear();
            for (int i = 157; i < 169; i++)
            {
                var ülkeadiadi = ülkeler.Descendants("area").ElementAt(i).Attribute("name").Value;
                var kodu = ülkeler.Descendants("area").ElementAt(i).Attribute("countrycode").Value;
                listBox1.Items.Add(ülkeadiadi + " Güney Amerikda bulunmaktadır kodu : " + kodu);
            }
        }

        private void okyanusya_Click(object sender, EventArgs e)
        {

            XDocument ülkeler = XDocument.Load(connection);
            listBox1.Items.Clear();
            for (int i = 170; i < 191; i++)
            {
                var ülkeadiadi = ülkeler.Descendants("area").ElementAt(i).Attribute("name").Value;
                var kodu = ülkeler.Descendants("area").ElementAt(i).Attribute("countrycode").Value;
                listBox1.Items.Add(ülkeadiadi + " Okyanusya'da bulunmaktadır kodu : " + kodu);
            }
        }

        private void avrupa_Click(object sender, EventArgs e)
        {
            XDocument ülkeler = XDocument.Load(connection);
            listBox1.Items.Clear();
            for (int i = 192; i < 260; i++)
            {
                var ülkeadiadi = ülkeler.Descendants("area").ElementAt(i).Attribute("name").Value;
                var kodu = ülkeler.Descendants("area").ElementAt(i).Attribute("countrycode").Value;
                listBox1.Items.Add(ülkeadiadi + " Avrupa'da bulunmaktadır kodu : " + kodu);
            }
        }

        private void adalar_Click(object sender, EventArgs e)
        {
            XDocument ülkeler = XDocument.Load(connection);
            listBox1.Items.Clear();
            for (int i = 260; i < 265; i++)
            {
                var ülkeadiadi = ülkeler.Descendants("area").ElementAt(i).Attribute("name").Value;
                var kodu = ülkeler.Descendants("area").ElementAt(i).Attribute("countrycode").Value;
                listBox1.Items.Add(ülkeadiadi + " Bir ada'dır kodu : " + kodu);
            }
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
