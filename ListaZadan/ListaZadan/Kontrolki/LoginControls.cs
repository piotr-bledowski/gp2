using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaZadan.Kontrolki
{
    public partial class LoginControls : UserControl
    {
        private MainForm _mainForm;
        public LoginControls(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;

            Dock = DockStyle.Fill;
        }

        private void btnZaloguj_Click(object sender, EventArgs e)
        {
            _mainForm.PokazTasksControl();
        }

        private void btnZalozKonto_Click(object sender, EventArgs e)
        {
            _mainForm.PokazRegisterControl();
        }
    }
}
