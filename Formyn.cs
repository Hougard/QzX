using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QzX
{
    public partial class Formyn : Form
    {
        public Formyn(string answer, int value, string exp)
        {
            InitializeComponent();
            lblanswer.Text = answer;
            lblvalue.Text = $"{value.ToString()} pts.";
            lblexp.Text = exp;

        }
        public bool ansResult { get; private set; }




        private void correct_Click(object sender, EventArgs e)
        {
            ansResult = true;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void wrong_Click(object sender, EventArgs e)
        {
            ansResult = false;
            DialogResult = DialogResult.OK;
            Close();
        }
    }


}
