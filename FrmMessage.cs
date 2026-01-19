using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace QzX
{
    public partial class FrmMessage : Form
    {
        public FrmMessage(string text, int points, string correctAns, string exp)
        {
            InitializeComponent();
            Color[] colors = new Color[] { Color.Red, Color.Green, Color.Blue };
            lblResult.ForeColor = text == "Correct" ? Color.Green : Color.Red;
            lblResult.Text = text;
            lblPts.Text = $"{points} pts.";
            lblCorrect.Text = text == "Correct" ? exp : $"Correct - {correctAns}. {exp} ";
        }

        private void btnProcede_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
