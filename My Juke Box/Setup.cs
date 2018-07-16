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
using System.Diagnostics;


namespace My_Juke_Box
{
    public partial class Setup : Form
    {
        public Setup()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Setup_Load(object sender, EventArgs e)
        {
            int counter = 0;
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader("list.txt");
            while ((line = file.ReadLine()) != null)
            {
                listBox2.Items.Add(line);
                counter++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FDB = new FolderBrowserDialog();

            if (FDB.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();
                string[] files = Directory.GetFiles(FDB.SelectedPath);
                string[] dirs = Directory.GetDirectories(FDB.SelectedPath);
                
                foreach (string file in files)
                {
                    listBox1.Items.Add(Path.GetFileName(file));
                }

                foreach (string dir in dirs)
                {
                    listBox1.Items.Add(Path.GetFileName((dir)));
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItems[0]);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a track");
            }
            else
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a track");
            }
            else
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count > 0)
            {
                using (TextWriter TW = new StreamWriter("list.txt"))
                {
                    foreach (string itemText in listBox2.Items)
                    {
                        TW.WriteLine(itemText);
                    }
                }
                Process.Start("list.txt");
                
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
