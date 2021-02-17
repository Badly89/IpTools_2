using System;
using System.Collections.Generic;
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

            if (savedIp.Count <= 50)
            {
                btnOpenIpPartly.Enabled = true;
                //  btnOpenIpPartly.BackColor = System.Drawing.Color.Black;
                btnOpenIpPartly100.Enabled = false;
                btnOpenIpPartly100.BackColor = System.Drawing.Color.Black;
                btnOpenIpPartly150.Enabled = false;
                btnOpenIpPartly150.BackColor = System.Drawing.Color.Black;
            }
            if (savedIp.Count <= 100)
            {
                btnOpenIpPartly.Enabled = true;
                btnOpenIpPartly100.Enabled = true;
                btnOpenIpPartly150.Enabled = false;
                btnOpenIpPartly150.BackColor = System.Drawing.Color.Black;
            }
            if (savedIp.Count <= 150)
            {
                btnOpenIpPartly.Enabled = true;
                btnOpenIpPartly100.Enabled = true;
                btnOpenIpPartly150.Enabled = true;
            }
            groupBox2.Text = "Уникальных айпи: " + savedIpList.Count.ToString();
            // lblUnique.Text = "Уникальных айпи: " + savedIpList.Count.ToString();
            foreach (IpClass obj in savedIpList)
            {
                richTxtBoxRes.AppendText(obj.Ip + " - " + obj.City + " ");
                richTxtBoxRes.InsertLink("Link to 2whois.ru", "https://2whois.ru/?t=whois&data=" + obj.Ip);
                richTxtBoxRes.AppendText("  ");
                richTxtBoxRes.InsertLink("Link to extreme-ip-lookup.com", "https://extreme-ip-lookup.com/" + obj.Ip);
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

        private void btnOpenIpPartly_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = true;
            btnOpenLogs.Enabled = false;
            btnOpenIpPartly.Enabled = false;
            btnOpenIpPartly100.Enabled = false;
            btnOpenIpPartly150.Enabled = false;
            int savedCount = partialOpenedCount;
            for (int i = savedCount; i < (savedCount + 50); i++)
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
                btnOpenIpPartly.Text = "Открыто " + partialOpenedCount + " из " + savedIp.Count;
                Application.DoEvents();
                if (partialOpenedCount == savedIp.Count)
                {
                    btnOpenIpPartly.Text = "Продолжить открывать. Сейчас открыто " + partialOpenedCount + " из " + savedIp.Count;
                    Application.DoEvents();
                    partialOpenedCount = 0;
                    btnOpenLogs.Enabled = true;
                    //btnOpenIpPartly100.Enabled = true;
                    //btnOpenIpPartly150.Enabled = true;
                    btnOpenIpPartly.Enabled = true;
                    btnCancel.Enabled = false;
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
                btnOpenIpPartly.Text = "Завершено. Открыто " + partialOpenedCount + " из " + savedIp.Count;

                Application.DoEvents();
                btnOpenLogs.Enabled = true;
                btnOpenIpPartly100.Enabled = true;
                btnOpenIpPartly150.Enabled = true;
                btnOpenIpPartly.Enabled = true;
                btnCancel.Enabled = false; ;
            }
            btnOpenLogs.Enabled = true;
            btnOpenIpPartly100.Enabled = true;
            btnOpenIpPartly150.Enabled = true;
            btnOpenIpPartly.Enabled = true;
            btnCancel.Enabled = false; ;
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



        private void btnOpenIpPartly100_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = true;
            btnOpenLogs.Enabled = false;
            btnOpenIpPartly100.Enabled = false;
            btnOpenIpPartly150.Enabled = false;
            btnOpenIpPartly.Enabled = false;
            int savedCount = partialOpenedCount;
            for (int i = savedCount; i < (savedCount + 100); i++)
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
                btnOpenIpPartly100.Text = "Открыто " + partialOpenedCount + " из " + savedIp.Count;
                Application.DoEvents();
                if (partialOpenedCount == savedIp.Count)
                {
                    btnOpenIpPartly100.Text = "Продолжить открывать. Сейчас открыто " + partialOpenedCount + " из " + savedIp.Count;
                    Application.DoEvents();
                    partialOpenedCount = 0;
                    btnOpenLogs.Enabled = true;
                    btnOpenIpPartly100.Enabled = true;
                    //btnOpenIpPartly150.Enabled = true;
                    //btnOpenIpPartly.Enabled = true;
                    btnCancel.Enabled = false;
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
                btnOpenIpPartly100.Text = "Завершено. Открыто " + partialOpenedCount + " из " + savedIp.Count;

                Application.DoEvents();
                btnOpenLogs.Enabled = true;
                btnOpenIpPartly100.Enabled = true;
                btnOpenIpPartly150.Enabled = true;
                btnCancel.Enabled = false; ;
            }
            btnOpenLogs.Enabled = true;
            btnOpenIpPartly100.Enabled = true;
            btnOpenIpPartly150.Enabled = true;
            btnOpenIpPartly.Enabled = true;
            btnCancel.Enabled = false;
        }

        private void btnOpenIpPartly150_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = true;
            btnOpenLogs.Enabled = false;
            btnOpenIpPartly100.Enabled = false;
            btnOpenIpPartly150.Enabled = false;
            btnOpenIpPartly.Enabled = false;
            int savedCount = partialOpenedCount;
            for (int i = savedCount; i < (savedCount + 150); i++)
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
                btnOpenIpPartly150.Text = "Открыто " + partialOpenedCount + " из " + savedIp.Count;
                Application.DoEvents();
                if (partialOpenedCount == savedIp.Count)
                {
                    btnOpenIpPartly150.Text = "Продолжить открывать. Сейчас открыто " + partialOpenedCount + " из " + savedIp.Count;

                    Application.DoEvents();
                    partialOpenedCount = 0;
                    btnOpenLogs.Enabled = true;
                    //btnOpenIpPartly100.Enabled = true;
                    btnOpenIpPartly150.Enabled = true;
                    //btnOpenIpPartly.Enabled = true;
                    btnCancel.Enabled = false;
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
                btnOpenIpPartly150.Text = "Завершено. Открыто " + partialOpenedCount + " из " + savedIp.Count;
                Application.DoEvents();
                btnOpenLogs.Enabled = true;
                btnOpenIpPartly100.Enabled = true;
                btnOpenIpPartly150.Enabled = true;
                btnOpenIpPartly.Enabled = true;
                btnCancel.Enabled = false;
            }
            btnOpenLogs.Enabled = true;
            btnOpenIpPartly100.Enabled = true;
            btnOpenIpPartly150.Enabled = true;
            btnOpenIpPartly.Enabled = true;
            btnCancel.Enabled = false; ;
        }

        private void btnOpenLogs_Click(object sender, EventArgs e)
        {
            btnOpenLogs.Enabled = false;
            btnOpenIpPartly.Enabled = false;
            btnCancel.Enabled = true;
            int i = 0;
            foreach (IpClass obj in savedIp)
            {
                System.Diagnostics.Process.Start("http://" + ipServer + ".apeha.ru/ulog_ip" + "_" + generateIpNumber(obj.Ip) + "_" + "showall_1.lhtml");
                if (chkBoxEveryHalfSecond.Checked == true)
                {
                    System.Threading.Thread.Sleep(500);
                }
                else
                {
                    System.Threading.Thread.Sleep(1000);
                }
                i++;
                btnOpenLogs.Text = "Открыто: " + i + " из " + savedIp.Count;
                Application.DoEvents();
                if (cancelPressed)
                {
                    cancelPressed = false;
                    break;
                }
            }
            btnCancel.Enabled = false;
            btnOpenLogs.Enabled = true;
            btnOpenIpPartly.Enabled = false;
            btnOpenLogs.Text = "Открыть логи Арены для всех айпи (Внимание. Пауза между открытиями логов - 1 секунда.)";
        }
    }
}
