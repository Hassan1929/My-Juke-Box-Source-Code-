using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace My_Juke_Box
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
            player.SoundLocation = ("Sleep Away.wav");
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Setup setup = new Setup();
            setup.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void clickevent(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int counter = 0;
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader("list.txt");
            while ((line = file.ReadLine()) != null)
            {
                listBox1.Items.Add(line);
                counter++;
            }

        }

        private void double_click(object sender, EventArgs e)
        {

            player.Play();

            textBox1.Text = listBox1.SelectedItem.ToString();
            
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
    }
}
