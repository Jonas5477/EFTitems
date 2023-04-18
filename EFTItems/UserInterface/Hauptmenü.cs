using EFTItems.UserInterface;
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
    public partial class Hauptmenü : UserControl
    {
        private readonly Form1 _form1;
        public Hauptmenü(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
        }

        private void buttonTrades_Click(object sender, EventArgs e)
        {
            _form1.ChangePanel(new Trades());
        }

        private void buttonHideout_Click(object sender, EventArgs e)
        {
            _form1.ChangePanel(new Hideout());
        }

        private void buttonItems_Click(object sender, EventArgs e)
        {
            _form1.ChangePanel(new Items());
        }
    }
}
