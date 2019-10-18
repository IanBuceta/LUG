using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VL
{
    public partial class NumericBox : UserControl
    {
        public NumericBox()
        {
            InitializeComponent();
            _NumPositivo = Color.Black;
            _NumNegativo = Color.Red;
        }
        

        private void NumericBox_Load(object sender, EventArgs e)
        {
            textBox1.Location = new Point(0, 0);
            textBox1.Size = this.Size;
        }

        private void NumericBox_Resize(object sender, EventArgs e)
        {
            NumericBox_Load(null, null);
        }
        public Color ColorFondo
        {
            get
            {
                return textBox1.BackColor;
            }
            set
            {
                textBox1.BackColor = value;
            }
        }

        public Color _NumPositivo;
        public Color _NumNegativo;
        public Color NumPositivo
        {
            get
            {
                return _NumPositivo;
            }
            set
            {
                _NumPositivo = value;
                textBox1.ForeColor = value;
            }
        }
        public Color NumNegativo
        {
            get
            {
                return _NumNegativo;
            }
            set
            {
                _NumNegativo = value;
                textBox1.ForeColor = value;
            }
        }
        public string Texto
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            }
        }
        //private bool IsNumeric(string texto)
        //{
        //    bool resultado = true;
        //    foreach (char c in texto.ToCharArray())
        //    {
        //        if (!char.IsDigit(c)) 
        //        {
        //            resultado = false;
        //            break;
        //        }
        //    }
        //    return resultado;
        //}
        private bool IsNumeric(char c)
        {
            if (char.IsLetter(c) && c != (char)Keys.Back)
            {
                return false;
            }
            return true;
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char CONST_CANCELAR = '\0';
            try
            {
                if (!IsNumeric(e.KeyChar))
                {
                    e.KeyChar = CONST_CANCELAR;                
                }
                else if (e.KeyChar == '-' && textBox1.Text.First() == '-')
                {
                    e.KeyChar = CONST_CANCELAR;
                }
                else if(e.KeyChar == '-')
                {
                    textBox1.Text = textBox1.Text.Insert(0, e.KeyChar.ToString());
                    e.KeyChar = CONST_CANCELAR;
                }
                else if (e.KeyChar == '(')
                {
                    textBox1.Text = textBox1.Text.Insert(textBox1.Text.Length, ")");
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
