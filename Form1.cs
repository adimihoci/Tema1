using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Humanizer;

namespace Tema
{
    public partial class Tema1 : Form
    {
        public Tema1()
        {
            InitializeComponent();
            Load_Items_to_ListBox();
        }

        private void Load_Items_to_ListBox()
        {
            languages_list.Items.Add("English");
            languages_list.Items.Add("French");
            languages_list.Items.Add("Italian");
            languages_list.Items.Add("Portuguese");
            languages_list.Items.Add("Romanian");
            languages_list.Items.Add("German");
            languages_list.Items.Add("Arabic");
        }

        public static bool IsNumeric(object expression)
        {
            double retNum;

            bool isNum = Double.TryParse(Convert.ToString(expression), NumberStyles.Any, NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            string new_text = text.Text;
            
            if (!IsNumeric(new_text))
                MessageBox.Show("Enter a number !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if ((string)languages_list.SelectedItem == null)
                MessageBox.Show("Choose a language !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            int number = Convert.ToInt32(new_text);
            string language = (string)languages_list.SelectedItem;

            switch (language)
            {
                case "English":
                    MessageBox.Show(number.ToWords(new CultureInfo("en-US")));
                    break;
                case "French":
                    MessageBox.Show(number.ToWords(new CultureInfo("fr")));
                    break;
                case "Italian":
                    MessageBox.Show(number.ToWords(new CultureInfo("it")));
                    break;
                case "Portuguese":
                    MessageBox.Show(number.ToWords(new CultureInfo("pt")));
                    break;
                case "Romanian":
                    MessageBox.Show(number.ToWords(new CultureInfo("ro")));
                    break;
                case "German":
                    MessageBox.Show(number.ToWords(new CultureInfo("de")));
                    break;
                case "Arabic":
                    MessageBox.Show(number.ToWords(new CultureInfo("ar-sa")));
                    break;
            }

        }
    }
}
