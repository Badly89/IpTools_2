using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OpTools
{
    public partial class IpBox : Form
    {
        public String ipServer = "kovcheg";
        Boolean cancelPressed = false;
        public int partialOpenedCount = 0;
        public List<IpClass> savedIp = new List<IpClass>();
        public IpBox(List<IpClass> savedIpList)
        {

            InitializeComponent();
            //savedIp.Clear();
            savedIp = savedIpList;
            toolTip1.SetToolTip(numUD, "если количество уникальных меньше 50, то равно количеству уникальных IP. Увеличение идет по 50, максимально до 200.");


            groupBox2.Text = "Уникальных айпи: " + savedIpList.Count.ToString();
            if (numUD.Value > savedIpList.Count) { numUD.Value = savedIpList.Count; }

            foreach (IpClass obj in savedIpList)
            {
                richTxtBoxRes.AppendText(obj.Ip + " - " + obj.City + " ");
                richTxtBoxRes.InsertLink("Link to ip.osnova.news", "https://ip.osnova.news/ip/" + obj.Ip + "/");
                richTxtBoxRes.AppendText("  ");
                richTxtBoxRes.InsertLink("Link to ipinfo.io", "https://ipinfo.io/" + obj.Ip);
                richTxtBoxRes.AppendText("  ");
                richTxtBoxRes.InsertLink("Link to APEHA logs", "http://" + ipServer + ".apeha.ru/ulog_ip" + "_" + generateIpNumber(obj.Ip) + "_" + "showall_1.lhtml");
                richTxtBoxRes.AppendText("\n");
            }
        }



        private string generateIpNumber(string ip)
        {
            string[] ipSeparate = ip.Trim().Split('.');
            long result = Convert.ToInt64(ipSeparate[0]) * 256 * 256 * 256 + Convert.ToInt64(ipSeparate[1]) * 256 * 256 + Convert.ToInt64(ipSeparate[2]) * 256 + Convert.ToInt64(ipSeparate[3]);
            return result + "";
        }


        private void richTxtBoxRes_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            string[] separate = e.LinkText.Split('#');
            System.Diagnostics.Process.Start(separate[1]);
        }

        private void IpBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            //savedIp.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancelPressed = true;
        }

        private void srvKovcheg_CheckedChanged(object sender, EventArgs e)
        {
            if (srvKovcheg.Checked)
            {
                ipServer = "kovcheg";
            }
        }

        private void srvSmorye_CheckedChanged(object sender, EventArgs e)
        {
            if (srvSmorye.Checked)
            {
                ipServer = "smorye";
            }
        }

        private void srvUtes_CheckedChanged(object sender, EventArgs e)
        {
            if (srvUtes.Checked)
            {
                ipServer = "utes";
            }
        }
        

        private void Button1_Click(object sender, EventArgs e)
        {
            numUD.Enabled = false;
            btnOpenCount.Enabled = false;
            btnCancel.Enabled = true;
            btnCancel.Focus();
            btnCancel.BackColor = Color.Red;
            srvKovcheg.Enabled = false;
            srvSmorye.Enabled = false;
            srvUtes.Enabled = false;
            int savedCount = partialOpenedCount;

            for (int i = savedCount; i < (savedCount + numUD.Value); i++)
            {
                IpClass obj = savedIp[i];
                System.Diagnostics.Process.Start("http://" + ipServer + ".apeha.ru/ulog_ip" + "_" + generateIpNumber(obj.Ip) + "_" + "showall_1.lhtml");
                if (chkBoxEveryHalfSecond.Checked == true)
                {
                    System.Threading.Thread.Sleep(500);
                }
                else
                {
                    System.Threading.Thread.Sleep(1000);
                }
                partialOpenedCount++;
                btnOpenCount.Text = "Открыто " + partialOpenedCount + " из " + savedIp.Count;
                Application.DoEvents();
                if (partialOpenedCount == savedIp.Count)
                {
                    btnOpenCount.Text = "Продолжить открывать? Сейчас открыто" + partialOpenedCount + " из " + savedIp.Count;
                    Application.DoEvents();
                    partialOpenedCount = 0;
                    btnOpenCount.Enabled = true;
                    btnCancel.Enabled = false;
                    btnCancel.BackColor = Color.Aquamarine;
                    srvKovcheg.Enabled = true;
                    srvSmorye.Enabled = true;
                    srvUtes.Enabled = true;
                    numUD.Enabled = true;
                    break;
                }
                if (cancelPressed)
                {
                    cancelPressed = false;
                    break;
                }
            }
            if (partialOpenedCount < savedIp.Count)
            {
                btnOpenCount.Text = "Завершено. Открыто: " + partialOpenedCount + " из " + savedIp.Count;

                Application.DoEvents();
                numUD.Enabled = true;
                btnOpenCount.Enabled = true;
                btnCancel.Enabled = false;
                btnCancel.BackColor = Color.Aquamarine;
                srvKovcheg.Enabled = true;
                srvSmorye.Enabled = true;
                srvUtes.Enabled = true;
            }
            numUD.Enabled = true;
            btnOpenCount.Enabled = true;
            btnCancel.Enabled = false;
            srvKovcheg.Enabled = true;
            srvSmorye.Enabled = true;
            srvUtes.Enabled = true;
        }


    }
}
