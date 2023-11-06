using Json.Net;
using Newtonsoft.Json;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ArrestForms
{
   public partial class Form1 : Form
    {
        public static string crimesFile = "./crimes.txt";
        public static void WriteToJsonFile<T>(string filePath, T objectToWrite, bool append = false) where T : new()
        {
            TextWriter writer = null;
            try
            {
                var contentsToWriteToFile = JsonConvert.SerializeObject(objectToWrite);
                writer = new StreamWriter(filePath, append);
                writer.Write(contentsToWriteToFile);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }
        public static T ReadFromJsonFile<T>(string filePath) where T : new()
        {
            TextReader reader = null;
            try
            {
                reader = new StreamReader(filePath);
                var fileContents = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<T>(fileContents);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }
        public static List<crime> crimesList = new List<crime>();
        public void loadCrimes()
        {
            try
            {
                crimesList = ReadFromJsonFile<List<crime>>(crimesFile);
            }
            catch (FileNotFoundException)
            {
                //file not found, create one
                List<crime> defaultCrimes = new List<crime>();
                defaultCrimes.Add(new crime("Theft", "No person.. blah, blah, blah"));
                crimesList = defaultCrimes;

                //save the file
                WriteToJsonFile<List<crime>>(crimesFile, crimesList, true);
            }
        }
        public Form1()
        {
            InitializeComponent();
            loadCrimes();

            //Setup data binding
            this.crimeSelector.DataSource = crimesList;
            this.crimeSelector.DisplayMember = "Name";
            this.crimeSelector.ValueMember = "Value";

            // make it readonly
            this.crimeSelector.DropDownStyle = ComboBoxStyle.DropDownList;

            //Add event to listen for when combobox is changed
            this.crimeSelector.SelectedIndexChanged += new System.EventHandler(crimeSelector_SelectedIndexChanged);
        }
        private void crimeSelector_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.crimeTitle.Text = this.crimeSelector.Text;
            this.crimeDescription.Text = this.crimeSelector.SelectedValue.ToString();
        }



        private void newCrime_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Form2 class
            Form2 newCrimeForm = new Form2();

            // Show the settings form
            newCrimeForm.ShowDialog();

            Application.Restart();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void printButton_Click(object sender, EventArgs e)
        {

        }
    }

    public class crime
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public override string ToString() { return this.Name; }
        public crime(string name, string value)
        {
            this.Name = name;
            this.Value = value;
        }

    }
}
