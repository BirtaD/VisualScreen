using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace VisualScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //A többi eszköz ip cím alapján való "felderítése": https://stackoverflow.com/questions/54030495/discover-all-devices-on-lan
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddList_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBoxIP.Text);
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
        }

        private void buttonUnselect_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmScreen().Show();
        }
    }
}
