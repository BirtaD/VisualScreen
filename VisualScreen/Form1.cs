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
using Xamarin.Forms;
using System.Net.NetworkInformation;
using System.Threading;
using MediaBrowser.Model.Ssdp;

namespace VisualScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Ping_all();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        static string NetworkGateway()
        {
            string ip = null;

            foreach (NetworkInterface f in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (f.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (GatewayIPAddressInformation d in f.GetIPProperties().GatewayAddresses)
                    {
                        ip = d.Address.ToString();
                    }
                }
            }

            return ip;
        }
        public void Ping_all()
        {

            string gate_ip = NetworkGateway();

            //Extracting and pinging all other ip's.
            string[] array = gate_ip.Split('.');

            for (int i = 2; i <= 255; i++)
            {

                string ping_var = array[0] + "." + array[1] + "." + array[2] + "." + i;

                //time in milliseconds
                Ping(ping_var, 1, 1000);

            }

        }

        public void Ping(string host, int attempts, int timeout)
        {
            for (int i = 0; i < attempts; i++)
            {
                new Thread(delegate ()
                {
                    try
                    {
                        System.Net.NetworkInformation.Ping ping = new System.Net.NetworkInformation.Ping();
                        ping.PingCompleted += new PingCompletedEventHandler(PingCompleted);
                        ping.SendAsync(host, timeout, host);
                    }
                    catch
                    {
                        MessageBox.Show("rossz ip");
                    }
                }).Start();
            }
        }
        private void PingCompleted(object sender, PingCompletedEventArgs e)
        {
            string ip = (string)e.UserState;
            if (e.Reply != null && e.Reply.Status == IPStatus.Success)
            {
                string hostname = GetHostName(ip);
                string macaddres = GetMacAddress(ip);
                //store all three parameters to be shown on ListView
                // Logic for Ping Reply Success
                if (this.InvokeRequired)
                {
                    this.Invoke(new Action(() =>
                    {
                        listBox1.Items.Add(ip);
                    }));
                }
            }
            else
            {
                // MessageBox.Show(e.Reply.Status.ToString());
            }
        }
        public string GetHostName(string ipAddress)
        {
            try
            {
                IPHostEntry entry = Dns.GetHostEntry(ipAddress);
                if (entry != null)
                {
                    return entry.HostName;
                }
            }
            catch (SocketException)
            {
                // MessageBox.Show(e.Message.ToString());
            }

            return null;
        }


        //Get MAC address
        public string GetMacAddress(string ipAddress)
        {
            string macAddress = string.Empty;
            System.Diagnostics.Process Process = new System.Diagnostics.Process();
            Process.StartInfo.FileName = "arp";
            Process.StartInfo.Arguments = "-a " + ipAddress;
            Process.StartInfo.UseShellExecute = false;
            Process.StartInfo.RedirectStandardOutput = true;
            Process.StartInfo.CreateNoWindow = true;
            Process.Start();
            string strOutput = Process.StandardOutput.ReadToEnd();
            string[] substrings = strOutput.Split('-');
            if (substrings.Length >= 8)
            {
                macAddress = substrings[3].Substring(Math.Max(0, substrings[3].Length - 2))
                         + "-" + substrings[4] + "-" + substrings[5] + "-" + substrings[6]
                         + "-" + substrings[7] + "-"
                         + substrings[8].Substring(0, 2);
                return macAddress;
            }

            else
            {
                return "OWN Machine";
            }
        }

        private void buttonAddList_Click(object sender, EventArgs e)
        {
            try
            {
                string ipadd = comboBox1.Text;
                Ping(ipadd, 1, 4000);
                comboBox1.Items.Add(ipadd);
            }
            catch
            {
                MessageBox.Show("Rossz IP-címet adott meg!");
            }
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
