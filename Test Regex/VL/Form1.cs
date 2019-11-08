using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

/// <summary>
/// Regular expressions crea patrones que sirve para filtrar textos que cumplan con ese patron.
/// </summary>
namespace VL
{
    public partial class Form1 : Form
    {
        Regex _Re;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _Re = new Regex("");
        }

        private void textBoxFiltro_TextChanged(object sender, EventArgs e)
        {

        }

        private void textChanged(object sender, EventArgs e)
        {
            try
            {
                _Re = new Regex(textBoxFiltro.Text);
                MatchCollection matchCollection = _Re.Matches(textBoxIngresar.Text);
                textBoxMatches.Text = $"Matches Found: { matchCollection.Count }\r\n\r\n";
                foreach (Match match in matchCollection)
                {
                    textBoxMatches.Text += "\r\n" + match.Value;
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
