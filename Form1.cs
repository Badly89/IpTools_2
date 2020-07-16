﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace IpTools_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioWhoisRu_CheckedChanged(object sender, EventArgs e)
        {
            if (radioWhoisRu.Checked == true)
            {
                radioNicRu.Checked = false;
            }
            else
            {
                radioNicRu.Checked = true;
            }
        }

        private void radioNicRu_CheckedChanged(object sender, EventArgs e)
        {
            if (radioNicRu.Checked == true)
            {
                radioWhoisRu.Checked = false;
            }
            else
            {
                radioWhoisRu.Checked = true;
            }
        }

        private void IpLinkRadioChangedToggle()
        {
            if (radioLinksNicRu.Checked)
            {
                radioLinksApehaLogs.Checked = false;
                radioNoLinksJustText.Checked = false;
            }
            if (radioNoLinksJustText.Checked)
            {
                radioLinksNicRu.Checked = false;
                radioLinksApehaLogs.Checked = false;
            }
            if (radioLinksApehaLogs.Checked)
            {
                radioLinksNicRu.Checked = false;
                radioNoLinksJustText.Checked = false;
            }
        }

        private void radioLinksNicRu_CheckedChanged(object sender, EventArgs e)
        {
            IpLinkRadioChangedToggle();
        }

        private void radioLinksApehaLogs_CheckedChanged(object sender, EventArgs e)
        {
            IpLinkRadioChangedToggle();
        }

        private void radioNoLinksJustText_CheckedChanged(object sender, EventArgs e)
        {
            IpLinkRadioChangedToggle();
        }

        private void btnClearIpForm_Click(object sender, EventArgs e)
        {
            btnIpCheckStat.Text = "Статистика проверки";
            btnIpCheckStat.Enabled = false;
            btnClearIpForm.Enabled = false;
            boxIPAnswer.Text = "";
            boxIPInput.Text = "";
            button4.Enabled = false;
            btnClearIpForm.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(boxIPAnswer.Text);
        }

        private void btnCheckIPs_Click(object sender, EventArgs e)
        {
            btnIpCheckStat.Text = "Статистика проверки";
            btnIpCheckStat.Enabled = false;
            radioLinksApehaLogs.Enabled = false;
            radioLinksNicRu.Enabled = false;
            radioNoLinksJustText.Enabled = false;
            radioWhoisRu.Enabled = false;
            radioNicRu.Enabled = false;
            btnClearIpForm.Enabled = false;
            previousIpCountry = "";
            bool ipFirstRun = true;
            savedIPList.Clear();
            btnCheckIPs.Enabled = false;
            button4.Enabled = false;
            boxIPAnswer.Text = "";
            boxIPAnswer.Enabled = false;
            string ipAnswer = "";
            string ipList = boxIPInput.Text;
            string[] ipLines = ipList.Split('\n');
            int numberIpsToCheck = getIpsNumber(ipLines);
            int ipsAlreadyChecked = 0;
            btnCheckIPs.Text = "Результат обрабатывается. Пожалуйста, подождите... Готово: 0/" + numberIpsToCheck;
        }

        private int getIpsNumber(string[] ipLines)
        {
            int counter = 0;
            foreach (string str in ipLines)
            {
                if (str.Contains("Логин") || str.Contains("Регистрация"))
                {
                    counter++;
                }
            }
            return counter;
        }

        private string generateIpNumber(string ip)
        {
            string[] ipSeparate = ip.Trim().Split('.');
            long result = Convert.ToInt64(ipSeparate[0]) * 256 * 256 * 256 + Convert.ToInt64(ipSeparate[1]) * 256 * 256 + Convert.ToInt64(ipSeparate[2]) * 256 + Convert.ToInt64(ipSeparate[3]);
            return result + "";
        }

        private int detectCity(string lineToDetect)
        {
            if (lineToDetect.Contains("Утес дракона") || lineToDetect.Contains("Остров фантазий"))
            {
                return 5;
            }
            else
            {
                if (lineToDetect.Contains("Ковчег") || lineToDetect.Contains("Среднеморье") || lineToDetect.Contains("Лес"))
                {
                    return 4;
                }
                else
                    if (lineToDetect.Contains("Неизвестный город #6"))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        private string getIpInfo(string line)
        {
            int startIndex = detectCity(line);
            string[] separateWords = line.Split(' ');
            string ip = separateWords[startIndex];
            string answerIpLine = "";
            for (int i = 0; i < startIndex; i++)
            {
                answerIpLine += separateWords[i] + " ";
            }
            boxIPAnswer.AppendText(answerIpLine);
            if (radioLinksNicRu.Checked)
            {
                this.boxIPAnswer.InsertLink(text, "https://2whois.ru/?t=whois&data=" + text);
            }
            if (radioNoLinksJustText.Checked)
            {
                boxIPAnswer.AppendText(ip);
            }
            if (radioLinksApehaLogs.Checked)
            {
                boxIPAnswer.InsertLink(ip, "http://kovcheg.apeha.ru/ulog_ip" + "_" + generateIpNumber(ip) + "_" + "showall_1.lhtml");
            }
            boxIPAnswer.AppendText(" ");
            foreach (IpClass ipFromSavedList in savedIPList)
            {
                if (ip == ipFromSavedList.Ip)
                {
                    if (radioWhoisRu.Checked)
                    {
                        string[] savedDescr = ipFromSavedList.City.Split('-');
                        string[] savedDescrMore = savedDescr[1].Split(',');
                        if (!previousIpCountry.Equals("") && !previousIpCountry.Equals(savedDescrMore[0].Trim()))
                        {
                            boxIPAnswer.SelectionColor = Color.Red;
                            boxIPAnswer.AppendText(" - " + ipFromSavedList.City + "\n");
                        }
                        else
                        {
                            boxIPAnswer.AppendText(" - " + ipFromSavedList.City + "\n");
                        }
                        previousIpCountry = savedDescrMore[0].Trim();
                    }
                    else
                    {
                        string[] savedDescr = ipFromSavedList.City.Split(',');
                        if (!previousIpCountry.Equals("") && !previousIpCountry.Equals(savedDescr[0].Trim()))
                        {
                            boxIPAnswer.SelectionColor = Color.Red;
                            boxIPAnswer.AppendText(" - " + ipFromSavedList.City + "\n");
                        }
                        else
                        {
                            boxIPAnswer.AppendText(" - " + ipFromSavedList.City + "\n");
                        }
                        previousIpCountry = savedDescr[0].Trim();
                    }

                    return ipFromSavedList.City;
                }
            }
            //Checking using 1whois.ru
            if (radioWhoisRu.Checked == true)
            {
                WebClient client = new WebClient();
                string downloadString = client.DownloadString("https://ipcalc.co/ipdata/" + ip);

                foreach (string str in htmlLines)
                {
                    if (str.Contains("<br />Location:"))
                    {
                       

                        IpClass ipToSave = new IpClass();
                        ipToSave.Ip = ip;
                        ipToSave.City = temp1;
                        savedIPList.Add(ipToSave);
                        if (!previousIpCountry.Equals("") && !previousIpCountry.Equals(splitDescrMore[0].Trim()))
                        {
                            boxIPAnswer.SelectionColor = Color.Red;
                            boxIPAnswer.AppendText(" - " + temp1 + "\n");
                        }
                        else
                        {
                            boxIPAnswer.AppendText(" - " + temp1 + "\n");
                        }
                        previousIpCountry = splitDescrMore[0].Trim();
                        return temp1;
                    }
                }
            }
            //checking using nic.ru/whois
            if (radioNicRu.Checked == true)
            {
                WebClient client = new WebClient();
                string downloadString = client.DownloadString("http://ipgeobase.ru/?address=" + ip);
                string[] htmlLines = downloadString.Split('\n');
                int cityIndex = 0;
                int regionIndex = 0;
                int okrugIndex = 0;
                int countryIndex = 0;
                int counter = 0;
                foreach (string str in htmlLines)
                {
                    if (str.Contains("Город"))
                    {
                        cityIndex = counter;

                    }
                    if (str.Contains("Регион"))
                    {
                        regionIndex = counter;
                    }
                    if (str.Contains("Округ"))
                    {
                        okrugIndex = counter;
                    }
                    if (str.Contains("Страна"))
                    {
                        countryIndex = counter;
                        break;
                    }
                    counter++;
                }
                string HTML_TAG_PATTERN = "<.*?>";
                string country = "";
                string region = "";
                string okrug = "";
                string city = "";
                if (countryIndex != 0) country = Regex.Replace(htmlLines[countryIndex + 1], HTML_TAG_PATTERN, string.Empty);
                if (cityIndex != 0) city = Regex.Replace(htmlLines[cityIndex + 1], HTML_TAG_PATTERN, string.Empty);
                if (regionIndex != 0) region = Regex.Replace(htmlLines[regionIndex + 1], HTML_TAG_PATTERN, string.Empty);
                if (okrugIndex != 0) okrug = Regex.Replace(htmlLines[okrugIndex + 1], HTML_TAG_PATTERN, string.Empty);
                IpClass ipToSave = new IpClass();
                ipToSave.Ip = ip;
                ipToSave.City = country.Trim() + ", " + region.Trim() + ", " + okrug.Trim() + ", " + city.Trim();
                savedIPList.Add(ipToSave);
                if (!previousIpCountry.Equals("") && !previousIpCountry.Equals(country.Trim()))
                {
                    boxIPAnswer.SelectionColor = Color.Red;
                    boxIPAnswer.AppendText(" - " + country.Trim() + ", " + region.Trim() + ", " + okrug.Trim() + ", " + city.Trim() + "\n");
                }
                else
                {
                    boxIPAnswer.AppendText(" - " + country.Trim() + ", " + region.Trim() + ", " + okrug.Trim() + ", " + city.Trim() + "\n");
                }
                previousIpCountry = country.Trim();
                return country.Trim() + ", " + region.Trim() + ", " + okrug.Trim() + ", " + city.Trim();
            }
            return null;

        }
    }
}
