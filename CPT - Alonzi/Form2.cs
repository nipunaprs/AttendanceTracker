using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPT___Alonzi
{

    public partial class Form2 : Form
    {
        string name;
        int totallates;
        int totalabsents;
        List<string> absentlist = new List<string>();
        List<string> latelist = new List<string>();
        public Form2(string x, int y, int z, List<string> q, List<string> l)
        {
            InitializeComponent();
            name = x;
            totallates = y;
            totalabsents = z;
            absentlist = q;
            latelist = l;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lbltotalabsents.Text = totalabsents.ToString();
            lbltotallates.Text = totallates.ToString();
            label1.Text = name;

            foreach(string s in absentlist)
            {
                textBox1.AppendText(s);
                textBox1.AppendText(Environment.NewLine);
            }

            foreach (string s in latelist)
            {
                textBox2.AppendText(s);
                textBox2.AppendText(Environment.NewLine);
            }


        }
    }
}
