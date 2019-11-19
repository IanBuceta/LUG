using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Vista
{
    public partial class ControlEmpleado : UserControl
    {
        public ControlEmpleado()
        {
            InitializeComponent();
        }
        public bool IdValido()
        {
            Regex regex = new Regex("[A-Z]{3}[-][0-9]{3}");
            if (regex.IsMatch(textBoxIdEmp.Text)) return true;
            return false;
        }
    }
}
