using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lila
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            textBox3.Text = "192.168.3.33";
        }
        public void ping2()
        {
            try
            {
                Ping ping = new Ping();
                PingOptions pOptions = new PingOptions();
                pOptions.DontFragment = true;
                byte[] myByte = new byte[32];
                PingReply pingReply = ping.Send(textBox1.Text);
                if (pingReply.Status == IPStatus.Success)
                {
                    listBox3.Items.Add(pingReply.RoundtripTime + "ms");
                    listBox3.Items.Add(pingReply.Options.Ttl + "TTL");
                    listBox3.Items.Add(pingReply.Status);
                }
                else if (pingReply.Status == IPStatus.TimedOut)
                {
                    listBox3.Items.Add("TimedOut");
                }
            }
            catch
            {
                listBox3.Items.Add("HATA!!!!");
            }
        }
        public void ping1()
        {
            try
            {
                Ping ping = new Ping();
                PingOptions pOptions = new PingOptions();
                pOptions.DontFragment = true;
                byte[] myByte = new byte[32];
                PingReply pingReply = ping.Send(textBox1.Text);
                if (pingReply.Status == IPStatus.Success)
                {
                    listBox2.Items.Add(pingReply.RoundtripTime + "ms");
                    listBox2.Items.Add(pingReply.Options.Ttl + "TTL");
                    listBox2.Items.Add(pingReply.Status);
                }
                else if (pingReply.Status == IPStatus.TimedOut)
                {
                    listBox2.Items.Add("TimedOut");
                }
            }
            catch
            {
                listBox2.Items.Add("HATA!!!!");
            }
        }
        public void ping()
        {
            if (textBox3.Text == "")
            {

                MessageBox.Show("Hostname veya IP adresi yok");

                return;

            }
            try
            {
                Ping myPing = new Ping();
                PingOptions pOptions = new PingOptions();
                pOptions.DontFragment = true;
                byte[] myByte = new byte[32];
                PingReply pReply = myPing.Send(textBox3.Text, 5000, myByte, pOptions);
                //IP adresine ulaşabiliyorsak ve yanıtda aldıysak Success olarak dönüş yapacak

                if (pReply.Status == IPStatus.Success)
                {
                    //Gidiş-Dönüş süresini yazar.
                    listBox1.Items.Add(pReply.RoundtripTime + "ms");
                    //saniyede kaç byte gönderdiğini yazar.
                    listBox1.Items.Add(pReply.Options.Ttl + "TTL");
                    //Ping atma durumunu yazar.
                    listBox1.Items.Add(pReply.Status);
                }
                //Ip adresine ulaşamıyorsak TimedOut dönüş yapacak
                else if (pReply.Status == IPStatus.TimedOut)
                {
                    listBox1.Items.Add("Timed Out");
                }

            }
            catch (PingException)
            {
                listBox1.Items.Add("HATA!!!!!");
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            ping();
            ping1();
            ping2();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();

        }
    }
}
