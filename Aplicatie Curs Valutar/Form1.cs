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
using System.Xml;

namespace Aplicatie_Curs_Valutar
{
    public partial class Form1 : Form
    {

        //pe 10 zile string url = @"https://www.bnr.ro/nbrfxrates10days.xml";
        public string url = @"https://www.bnr.ro/files/xml/years/nbrfxrates2019.xml";
        
        public Form1()
        {
         
            InitializeComponent();

             XmlDocument xmlDoc = new XmlDocument();
             xmlDoc.Load(url);

            //facem lista de noduri
            XmlNodeList Lista_Cuburi = xmlDoc.DocumentElement.GetElementsByTagName("Cube");
            foreach (XmlNode Cube in Lista_Cuburi)
            {
                XmlAttributeCollection atr = Cube.Attributes;
                XmlAttribute atr_Data = atr["date"];
                cmb_date.Items.Add(atr_Data.InnerText);

            }
            //xmlDoc.
        }
        
        private void btn_fa_conversie_Click(object sender, EventArgs e)
        {
            if (cmb_date.SelectedItem != null)
            {
                string datee = cmb_date.SelectedItem.ToString();
                string currency = cmb_alege_valuta.SelectedItem.ToString();
               

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(url);

                XmlNodeList Lista_Cuburi = xmlDoc.DocumentElement.GetElementsByTagName("Cube");
                foreach (XmlNode Cube in Lista_Cuburi)
                {
                    XmlAttributeCollection atr = Cube.Attributes;
                    XmlAttribute atr_Data = atr["date"];
                    if (atr_Data.InnerText == datee)
                    {
                        XmlNode Rate_Node = Cube.FirstChild;

                        while (Rate_Node != null)
                        {
                            XmlAttribute atr_curr = Rate_Node.Attributes["currency"];
                            if (atr_curr.InnerText == currency)
                            {
                                txt_afiseaza_rata_conv.Text = Rate_Node.InnerText;
                            }

                            Rate_Node = Rate_Node.NextSibling;
                        }
                    }


                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ////////////////////
        }

        private void dtm_alege_data_DropDown(object sender, EventArgs e)
        {

        }

        private void cmb_alege_valuta_DropDown(object sender, EventArgs e)
        {
            cmb_alege_valuta.Items.Clear();

            if (cmb_date.SelectedItem != null)
            {
                string datee = cmb_date.SelectedItem.ToString();


                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(url);

                XmlNodeList Lista_Cuburi = xmlDoc.DocumentElement.GetElementsByTagName("Cube");
                foreach (XmlNode Cube in Lista_Cuburi)
                {
                    XmlAttributeCollection atr = Cube.Attributes;
                    XmlAttribute atr_Data = atr["date"];
                    if (atr_Data.InnerText == datee)
                    {
                        XmlNode Rate_Node = Cube.FirstChild;
                        while (Rate_Node != null)
                        {
                            XmlAttribute atr_rate = Rate_Node.Attributes["currency"];
                            cmb_alege_valuta.Items.Add(atr_rate.InnerText.ToString());
                            Rate_Node = Rate_Node.NextSibling;
                        }
                    }


                }
            }


        }

        private void dtm_alege_data_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmb_alege_valuta_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void cmb_alege_valuta_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void cmb_alege_valuta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_date.SelectedItem != null)
            {
                string datee = cmb_date.SelectedItem.ToString();
                string currency = cmb_alege_valuta.SelectedItem.ToString();

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(url);

                XmlNodeList Lista_Cuburi = xmlDoc.DocumentElement.GetElementsByTagName("Cube");
                foreach (XmlNode Cube in Lista_Cuburi)
                {
                    XmlAttributeCollection atr = Cube.Attributes;
                    XmlAttribute atr_Data = atr["date"];
                    if (atr_Data.InnerText == datee)
                    {
                        XmlNode Rate_Node = Cube.FirstChild;

                        while (Rate_Node != null)
                        {
                            XmlAttribute atr_curr = Rate_Node.Attributes["currency"];
                            if (atr_curr.InnerText == currency)
                            {
                                txt_afiseaza_rata_conv.Text = Rate_Node.InnerText;
                            }

                            Rate_Node = Rate_Node.NextSibling;
                        }
                    }


                }
            }
        }

        private void valideazaXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ValideazaXML v = new Form_ValideazaXML();
                v.Show();
        }
    }
}
