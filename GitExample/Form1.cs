using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void englishButton_Click(object sender, EventArgs e)
        {
            greetingLabel.Text = "Hello World!";
        }

        private void germanButton_Click(object sender, EventArgs e)
        {
            greetingLabel.Text = "Hallo Welt!";
        }

        private void frenchButton_Click(object sender, EventArgs e)
        {
            greetingLabel.Text = "Bonjour Monde!";
        }

        private void italianButton_Click(object sender, EventArgs e)
        {
            greetingLabel.Text = "Ciao Mondo!";
        }

        private void dutchButton_Click(object sender, EventArgs e)
        {
            greetingLabel.Text = "Hallo Wereld!";
        }

        private void spanishButton_Click(object sender, EventArgs e)
        {
            greetingLabel.Text = "Hola Mundo!";
        }
    }
}
