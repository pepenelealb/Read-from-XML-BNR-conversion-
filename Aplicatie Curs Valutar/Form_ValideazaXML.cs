using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;

namespace Aplicatie_Curs_Valutar
{
    public partial class Form_ValideazaXML : Form
    {
        
        public Form_ValideazaXML()
        {
            InitializeComponent();
        }
      

        private void Form_ValideazaXML_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\Users\\pdumitru\\Desktop\\XML";
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)

                {
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }

                }
                //try
                //{
                //    XmlReaderSettings settings = new XmlReaderSettings();
                //    settings.Schemas.Add("schema", "myConfig.config.xsd"); //!!Here is where I just put "schema" as the namespace
                //    settings.ValidationType = ValidationType.Schema;
                //    settings.ValidationFlags |= XmlSchemaValidationFlags.ProcessInlineSchema;
                //    settings.ValidationFlags |= XmlSchemaValidationFlags.ProcessSchemaLocation;
                //    settings.ValidationFlags |= XmlSchemaValidationFlags.ReportValidationWarnings;
                //    ValidationEventHandler eventHandler = ValidationCallback;

                //    XmlReader reader = XmlReader.Create("output.xml", settings);
                //    XmlDocument document = new XmlDocument();
                //    document.Load(reader);
                //    ValidationEventHandler eventHandler = new ValidationEventHandler(ValidationEventHandler);
                //    //^Here is the problem line that won't let me build this program

                //    document.Validate(eventHandler);

                //}
                //catch (Exception e)
                //{
                //    Console.WriteLine(e.Message);
                //}
            }
        private static void ValidationCallback(object sender, ValidationEventArgs args)
        {
            if (args.Severity == XmlSeverityType.Warning)
                Console.WriteLine("\tWarning: Matching schema not found.  No validation occurred." + args.Message);
            else
                Console.WriteLine("\tValidation error: " + args.Message);
        }
        static void ValidationEventHandler(object sender, ValidationEventArgs e)
        {
            XmlSeverityType type = XmlSeverityType.Warning;
            if (Enum.TryParse<XmlSeverityType>("Error", out type))
            {
                if (type == XmlSeverityType.Error) throw new Exception(e.Message);
            }
        }
    }
}
