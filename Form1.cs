using System;
using System.Net;
using System.Windows.Forms;
using System.Diagnostics;
using System.Management;

namespace Lila
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label4.Text = DateTime.Now.ToLongDateString();
            label5.Text = DateTime.Now.ToShortTimeString();
        }
        private string MAC()
        {
            ManagementClass manager = new ManagementClass("Win32_NetworkAdapterConfiguration");
            foreach (ManagementObject obj in manager.GetInstances())
            {
                if ((bool)obj["IPEnabled"])
                {
                    return obj["MacAddress"].ToString();
                }
            }
            return String.Empty;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            IPHostEntry iph;
            string myip = "";
            iph = Dns.GetHostEntry(Dns.GetHostName());
            string bilgisayarAdi = Dns.GetHostName();
            textBox1.Text = bilgisayarAdi;

            foreach (IPAddress ıPAddress in Dns.GetHostAddresses(Dns.GetHostName()))
            {
                listBox1.Items.Add(ıPAddress);
            }
            textBox2.Text = MAC();
            textBox3.Text = (SystemInformation.UserName);
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IPHostEntry iph;
            string myip = "";
            iph = Dns.GetHostEntry(Dns.GetHostName());
            string bilgisayarAdi = Dns.GetHostName();
            textBox1.Text = bilgisayarAdi;
            textBox2.Text = MAC();

            foreach (IPAddress ıPAddress in Dns.GetHostAddresses(Dns.GetHostName()))
            {
                listBox1.Items.Add(ıPAddress);
            }
        }
        Form2 form2;
        private void button2_Click(object sender, EventArgs e)
        {
            if (form2 == null || form2.IsDisposed)
            {
                form2 = new Form2();
                form2.Show();
            }
            else
            {
                MessageBox.Show("zaten açık");

            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string c = "";
            foreach (object item in listBox1.Items) c += item.ToString() + "\r\n";
            {

            }
            Clipboard.SetText(textBox1.Text + Environment.NewLine + textBox2.Text + Environment.NewLine + textBox3.Text + Environment.NewLine + c);
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void hakkındaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Bu program LİLA GROUP BT Destek Ekibi tarafından 2021 yılında yapılmıştır...");
        }

        private void yardımToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Bilgi Teknolojileri ekibine 5959 numaralı kısa koddan ulaşabilirsiniz.");

        }

        private void çıkışToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var ps = new ProcessStartInfo("www.lilabtdestek.com")
            {
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(ps);

        }

        private void bcıkısToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Dispose();


        }
    }
}
