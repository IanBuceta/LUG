using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {

        int[] _Vector;
        int _Mayor = 0;
        string[] _Meses;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                _Vector = new int[10];
                _Meses = new string[] { "Ene", "Feb", "Mar", "Abr", "May", "Jun", "Jul", "Ago", "Sep", "Oct", "Nov", "Dic" };
                Random R = new Random(DateTime.Now.Millisecond);
       
                for (int i = 0; i < _Vector.Length; i++)
                {
                    int valor = i + R.Next(1, 100);
                    _Vector[i] = valor ;
                    listBox1.Items.Add(i);
                    if (_Mayor < valor) _Mayor = valor;
                }               
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message); 
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Random _R = new Random(DateTime.Now.Millisecond);

            Graphics GR = this.CreateGraphics();
            GR.Clear(Color.Black);

            int _OffsetX = 0;
            float desde = 0;
            for (int i = 0; i < _Vector.Length; i++)
            {
                int _AltoADibujar = ((_Vector[i] * 300) / _Mayor);
                //Barra
                SolidBrush _S = new SolidBrush(Color.FromArgb(_R.Next(0, 255), _R.Next(0, 255), _R.Next(0, 255)));
                GR.FillRectangle(_S, 100 + _OffsetX, 100 + 350 - _AltoADibujar, 30, _AltoADibujar); // Dibuja el valor en forma de grafico de barra
                GR.DrawString(_Vector[i].ToString(), new Font("Arial", 12), _S, 105 + _OffsetX, 70 + 350 - _AltoADibujar); // Dibuja el valor en texto
                GR.DrawString(_Meses[i].ToString(), new Font("Arial", 9), _S, 100 + _OffsetX, 450); // Dibuja el mes en texto

                // Torta
                float _Porcentaje = ((float)(_Vector[i]) * 360) / _Vector.Sum();
                GR.FillPie(_S, 600, 5, 300, 300, desde, _Porcentaje); // Dibuja el valor en forma de grafico de torta
                desde += _Porcentaje;

                _OffsetX += 50;
            }
            GR.Dispose();
        }

    }
}
