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
    public partial class DASH : Form
    {
        public DASH()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            //button1.BackgroundImage = Properties.Resources.naranja;
           
            //panelVisorMenu.Controls.Clear();
            var frm = new MENU();
            //frm.Dock = DockStyle.Fill;
          panelVisorMenu.Controls.Add(frm);
            frm.Show();
         




        }
    }
}
