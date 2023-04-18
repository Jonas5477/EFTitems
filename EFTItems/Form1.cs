using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFTItems
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            OpenHauptmenue();
        }

        private void OpenHauptmenue()
        {
            panel1.Controls.Add(new Hauptmenü(this));
        }

        public void ChangePanel(UserControl UserControl)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add((Control)UserControl);
        }
    }
}
