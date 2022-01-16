using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WiiU_External_Gui_Example
{
    public partial class Form1 : Form
    {
        public TCPGecko tcp;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            tcp = new TCPGecko(textBoxIp.Text, 7331);
            tcp.Connect();
            labelStatus.Text = "Connected";
            labelStatus.ForeColor = Color.Green;
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            tcp.Disconnect();
            labelStatus.Text = "Disconnected!";
            labelStatus.ForeColor = Color.Red;
        }

        private void textBoxIp_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelStatus_Click(object sender, EventArgs e)
        {

        }

        private void infraredPlayer_CheckedChanged(object sender, EventArgs e)
        {
            if (infraredPlayer.Checked)
            {
                tcp.poke32(0x21419DC, 0x2C030001);
                tcp.poke32(0x20FE084, 0x2C030001);
            }
            else
            {
                tcp.poke32(0x20FE084, 0x2C030000);
                tcp.poke32(0x21419DC, 0x2C030000);
            }
        }

        private void thirdPerson_CheckedChanged(object sender, EventArgs e)
        {
            if (thirdPerson.Checked)
            {
                tcp.poke32(0x219E2C0, 0x2C030001);
            }
            else
            {
                tcp.poke32(0x219E2C0, 0x2C030000);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UCUzbWL_N0KOUU_VZ7rjANBA/featured");
        }

        private void proMod_CheckedChanged(object sender, EventArgs e)
        {
            if (proMod.Checked)
            {
                tcp.poke32(0x1088EDA8, 0x3F800000);
            }
            else
            {
                tcp.poke32(0x1088EDA8, 0x3F000000);
            }
        }

        private void suppSloth_CheckedChanged(object sender, EventArgs e)
        {
            if (suppSloth.Checked)
            {
                tcp.poke32(0x02B49E24, 0x38800001);
            }
            else
            {
                tcp.poke32(0x02B49E24, 0x38800000);
            }
        }

        private void checkBoxExample2_CheckedChanged(object sender, EventArgs e)
        {
            //Make somethings
        }

        private void checkBoxExample_CheckedChanged(object sender, EventArgs e)
        {
            //Make somethings
        }
    }
}
