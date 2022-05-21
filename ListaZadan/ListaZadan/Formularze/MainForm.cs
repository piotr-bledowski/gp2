using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaZadan
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            PokazLoginControl();
        }

        public void PokazLoginControl()
        {
            Controls.Clear();

            Controls.Add(new LoginControl(this));
        }

        public void PokazRegisterControl()
        {
            Controls.Clear();

            Controls.Add(new RegisterControl(this));
        }

        public void PokazTasksControl()
        {
            Controls.Clear();

            Controls.Add(new TasksControl(this));
        }
    }
}
