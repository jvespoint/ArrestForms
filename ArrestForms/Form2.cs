using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrestForms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void saveNewCrime_Click(object sender, EventArgs e)
        {
            Form1.crimesList.Add(new crime(this.newCrimeTitle.Text, this.newCrimeDescription.Text));
            Form1.WriteToJsonFile<List<crime>>(Form1.crimesFile, Form1.crimesList, false);
            
            this.Close();
        }
    }
}
