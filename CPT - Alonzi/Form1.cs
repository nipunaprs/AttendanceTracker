using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CPT___Alonzi
{
    public partial class Form1 : Form
    {
        string todaysdate;
        string absentclick;
        string presentclick;
        string lateclick;
        string selecteddate;
        int totalabsents = 0;
        int totallates = 0;

        Dictionary<string, string> database = new Dictionary<string, string>();
        Dictionary<string, string> selecteddatelist = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            todaysdate = monthCalendar1.TodayDate.ToShortDateString();


            string[] lines = File.ReadAllLines("studentslist.txt");

            foreach (string item in lines)
            {
                listStudents.Items.Add(item);
                database.Add(item, "P");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            selecteddate = monthCalendar1.SelectionRange.Start.ToShortDateString();
            var oldLines = System.IO.File.ReadAllLines("info.txt");
            var newLines = oldLines.Where(line => !line.Contains(selecteddate));
            System.IO.File.WriteAllLines("info.txt", newLines);

            foreach (KeyValuePair<string, string> items in database)
            {
                using (StreamWriter streamwriter = File.AppendText("info.txt"))
                {
                    streamwriter.WriteLine(selecteddate + "+" + items.Key + "-" + items.Value);
                }

            }




        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void absentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            absentclick = listStudents.SelectedItem.ToString();
            database[absentclick] = "A";

        }

        private void lateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lateclick = listStudents.SelectedItem.ToString();
            database[lateclick] = "L";
        }

        private void presentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            presentclick = listStudents.SelectedItem.ToString();
            database[presentclick] = "P";
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            //Get selected date
            selecteddate = monthCalendar1.SelectionRange.Start.ToShortDateString();
            //Clear text boxes
            txtpresentdisplay.Text = String.Empty;
            txtabsentdisplay.Text = String.Empty;
            txtlatedisplay.Text = String.Empty;

            //search the lines of the text file and split them so I can display them
            foreach (var line in File.ReadLines("info.txt"))
            {
                if (line.Contains(selecteddate))
                {
                    //split the date then the name then the value 
                    string temp = line;
                    string[] temp2 = temp.Split('+');
                    string temp3 = temp2[1];
                    string[] temp4 = temp3.Split('-');
                    string tempname = temp4[0];
                    string tempvalue = temp4[1];

                    //depending on the value add them to the corresponding text box
                    if (tempvalue == "P")
                    {
                        txtpresentdisplay.AppendText(tempname);
                        txtpresentdisplay.AppendText(Environment.NewLine);
                    }
                    if (tempvalue == "A")
                    {
                        txtabsentdisplay.AppendText(tempname);
                        txtabsentdisplay.AppendText(Environment.NewLine);
                    }
                    if (tempvalue == "L")
                    {
                        txtlatedisplay.AppendText(tempname);
                        txtlatedisplay.AppendText(Environment.NewLine);

                    }

                }


            }


        }

        private void viewDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string studentsname = listStudents.GetItemText(listStudents.SelectedItem);

            totalabsents = 0;
            totallates = 0;
            var absentlist = new List<string>();
            var latelist = new List<string>();
            foreach (var line in File.ReadLines("info.txt"))
            {
                if (line.Contains(studentsname))
                {
                    string temp = line;
                    string[] temp2 = temp.Split('+');
                    string temp3 = temp2[1];
                    string[] temp4 = temp3.Split('-');
                    string tempname = temp4[0];
                    string tempvalue = temp4[1];

                    



                    if (tempvalue == "A")
                    {
                        totalabsents = totalabsents + 1;
                        absentlist.Add(temp2[0]);
                    }
                    if (tempvalue == "L")
                    {
                        totallates = totallates + 1;
                        latelist.Add(temp2[0]);
                    }


                }



            }
        
            Form2 studentview = new Form2(studentsname, totallates, totalabsents, absentlist, latelist);
            studentview.Show();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSaintoftheday_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.franciscanmedia.org/source/saint-of-the-day/");
        }
    }
}
