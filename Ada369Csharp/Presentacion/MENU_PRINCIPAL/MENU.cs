using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ada369Csharp.Presentacion.MENU_PRINCIPAL
{
    public partial class MENU : UserControl
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strCustomMessage = "Mensaje que obtienes de la DB";
            MessageBox.Show(strCustomMessage);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
