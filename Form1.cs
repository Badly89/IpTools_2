using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace IpTools_2
{


    public partial class Form1 : Form
    {

        public string previousIpCountry = "";
        public List<IpClass> savedIPList = new List<IpClass>();

        public Form1()
        {
            InitializeComponent();
        }

        private void radioWhoisRu_CheckedChanged(object sender, EventArgs e)
        {
            //if (radioWhoisRu.Checked == true)
            //{
            //    radioNicRu.Checked = false;
            //    rbipcom.Checked = false;
            //}
            //else
            //{
            //    radioNicRu.Checked = true;
            //    rbipcom.Checked = true;
            //}
        }

        private void radioNicRu_CheckedChanged(object sender, EventArgs e)
        {
            //if (radioNicRu.Checked == true)
            //{
            //    radioWhoisRu.Checked = false;
            //    rbipcom.Checked = false;
            //}
            //else
            //{
            //    radioWhoisRu.Checked = true;
            //    rbipcom.Checked = true;
            //}
        }

        private void rbipcom_CheckedChanged(object sender, EventArgs e)
        {
            //if (rbipcom.Checked == true)
            //{
            //    radioWhoisRu.Checked = false;
            //    radioNicRu.Checked = false;
            //}
            //else
            //{
            //    radioWhoisRu.Checked = true;
            //    radioWhoisRu.Checked = true;
            //}
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
            if (boxIPInput.Text != String.Empty)
            {
                btnIpCheckStat.Text = "СТАТИСКТИКА ПРОВЕРКИ";
                btnIpCheckStat.Enabled = false;
                radioLinksApehaLogs.Enabled = false;
                radioLinksNicRu.Enabled = false;
                rbipcom.Enabled = false;
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
                //string ipAnswer = "";
                string ipList = boxIPInput.Text.TrimStart(' ');
                string[] ipLines = ipList.Split('\n');
                int numberIpsToCheck = getIpsNumber(ipLines);
                int ipsAlreadyChecked = 0;
                btnCheckIPs.Text = "Результат обрабатывается. Пожалуйста, подождите... Готово: 0/" + numberIpsToCheck;
                foreach (string lineIP in ipLines)
                {
                    if (lineIP.Trim().Length > 7)
                    {
                        //Working here
                        if (lineIP.Length < 12)
                        {
                            if (ipFirstRun)
                            {
                                ipFirstRun = false;
                                boxIPAnswer.AppendText(lineIP + "\n");
                            }
                            else
                            {
                                boxIPAnswer.AppendText("\n" + lineIP + "\n");
                            }

                        }
                        else
                        {

                            if (lineIP.Contains("Логин") || lineIP.Contains("Регистрация"))
                            {

                                string answerForCurrentIP = getIpInfo(lineIP);
                                ipsAlreadyChecked++;
                                btnCheckIPs.Text = "Результат обрабатывается. Пожалуйста, подождите... Готово: " + ipsAlreadyChecked + "/" + numberIpsToCheck;
                                Application.DoEvents();
                            }
                            else
                            {
                                if (lineIP.Contains("Ковчег") || lineIP.Contains("Утес дракона") || lineIP.Contains("Среднеморье") || lineIP.Contains("Лес") || lineIP.Contains("Остров фантазий") || lineIP.Length > 11)
                                {
                                    if (!lineIP.Contains("Вся выборка содержит") && !(lineIP.Contains("с ") && lineIP.Contains(" по ") && lineIP.Length == 38))
                                    {
                                        boxIPAnswer.AppendText(lineIP + "\n");
                                    }

                                }
                            }
                        }
                    }
                }
                btnIpCheckStat.Enabled = true;
                boxIPAnswer.Enabled = true;
                button4.Enabled = true;
                btnCheckIPs.Text = "ПРОВЕРИТЬ IP";
                btnCheckIPs.Enabled = true;
                button4.Enabled = true;
                btnClearIpForm.Enabled = true;
                radioLinksApehaLogs.Enabled = true;
                radioLinksNicRu.Enabled = true;
                radioNoLinksJustText.Enabled = true;
                radioWhoisRu.Enabled = true;
                rbipcom.Enabled = true;
                radioNicRu.Enabled = true;
                btnIpCheckStat.Text = "СТАТИСТИКА ПРОВЕРКИ: " + savedIPList.Count.ToString() + " уникальных айпи.\n Нажмите для детализации";
                btnIpCheckStat.Enabled = true;
                btnClearIpForm.Enabled = true;
            }
            else
            {
                MessageBox.Show("Не чего проверять!");

            }
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
                this.boxIPAnswer.InsertLink(ip, "https://2whois.ru/?t=whois&data=" + ip);
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
                string region = "";
                string okrug = "";
                string country = "";
                string city = "";
                string asn_organization = "";
                string desc = "";
                string org = "";


                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                WebClient client = new WebClient();
                string jsonadress = client.DownloadString("https://ipcalc.co/ipdata/" + ip);
                var jPerson = JsonConvert.DeserializeObject<dynamic>(jsonadress);
                if (jPerson.continent.region_name_2 != null) { region = jPerson.continent.region_name_2; }
                if (jPerson.continent.region_name_1 != null) { okrug = jPerson.continent.region_name_1; }
                if (jPerson.country.name != null) { country = jPerson.country.name; }
                if (jPerson.city.name != null) { city = jPerson.city.name; }
                if (jPerson.isp.asn_organization != null) { asn_organization = jPerson.isp.asn_organization; }
                if (jPerson.isp.name != null) { desc = jPerson.isp.name; }
                if (jPerson.isp.organization != null) { org = jPerson.isp.organization; }

                var temp1 = country.Trim() + ", " + region.Trim() + ", " + okrug.Trim() + ", " + city.Trim() + ", " + asn_organization.Trim() + ", " + desc.Trim() + ", " + org.Trim();
              
                    IpClass ipToSave = new IpClass();
                    ipToSave.Ip = ip;
                ipToSave.City = temp1; //country.Trim() + ", " + region.Trim() + ", " + okrug.Trim() + ", " + city.Trim();
                    savedIPList.Add(ipToSave);
                    if (!previousIpCountry.Equals("") && !previousIpCountry.Equals(country.Trim()))
                    {
                        boxIPAnswer.SelectionColor = Color.Red;
                        boxIPAnswer.AppendText(" - " + country.Trim() + ", " + region.Trim() + ", " + okrug.Trim() + ", " + city.Trim() + ", " + asn_organization.Trim() + ", " + desc.Trim() + ", " + org.Trim() + "\n");
                    }
                    else
                    {
                        boxIPAnswer.AppendText(" - " + country.Trim() + ", " + region.Trim() + ", " + okrug.Trim() + ", " + city.Trim() + ", " + asn_organization.Trim() + ", " + desc.Trim() + ", " + org.Trim() + "\n");
                    }
                    previousIpCountry = country.Trim();
                return temp1; //country.Trim() + ", " + region.Trim() + ", " + okrug.Trim() + ", " + city.Trim() + ", " + asn_organization.Trim() + ", " + desc.Trim() + ", " + org.Trim();

                //return null;
            }

            //Checking using IP.API.COM
            if (rbipcom.Checked == true)
            {
                string region = "";
                string okrug = "";
                string country = "";
                string city = "";
                string asn_organization = "";
               // string desc = "";
                string org = "";


                WebClient client = new WebClient();
                string jsonadress = client.DownloadString("http://ip-api.com/json/" + ip);
                var jPerson = JsonConvert.DeserializeObject<dynamic>(jsonadress);
                if (jPerson.region != null) { region = jPerson.region; }
                if (jPerson.regionName != null) { okrug = jPerson.regionName; }
                if (jPerson.country != null) { country = jPerson.country; }
                if (jPerson.city != null) { city = jPerson.city; }
                if (jPerson.isp != null) { asn_organization = jPerson.isp; }
              //  if (jPerson.as != null) { desc = jPerson.isp.name; }
                if (jPerson.org != null) { org = jPerson.org; }

                var temp1 = country.Trim() + ", " + region.Trim() + ", " + okrug.Trim() + ", " + city.Trim() + ", " + asn_organization.Trim() + ", " + org.Trim();

                IpClass ipToSave = new IpClass();
                ipToSave.Ip = ip;
                ipToSave.City = temp1; //country.Trim() + ", " + region.Trim() + ", " + okrug.Trim() + ", " + city.Trim();
                savedIPList.Add(ipToSave);
                if (!previousIpCountry.Equals("") && !previousIpCountry.Equals(country.Trim()))
                {
                    boxIPAnswer.SelectionColor = Color.Red;
                    boxIPAnswer.AppendText(" - " + country.Trim() + ", " + region.Trim() + ", " + okrug.Trim() + ", " + city.Trim() + ", " + asn_organization.Trim() +  ", " + org.Trim() + "\n");
                }
                else
                {
                    boxIPAnswer.AppendText(" - " + country.Trim() + ", " + region.Trim() + ", " + okrug.Trim() + ", " + city.Trim() + ", " + asn_organization.Trim() +  ", " + org.Trim() + "\n");
                }
                previousIpCountry = country.Trim();
                return temp1; //country.Trim() + ", " + region.Trim() + ", " + okrug.Trim() + ", " + city.Trim() + ", " + asn_organization.Trim() + ", " + desc.Trim() + ", " + org.Trim();

                //return null;
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

        private void btnClearIpForm_Click_1(object sender, EventArgs e)
        {
            btnIpCheckStat.Text = "СТАТИСТИКА ПРОВЕРКИ";
            btnIpCheckStat.Enabled = false;
            btnClearIpForm.Enabled = false;
            boxIPAnswer.Text = "";
            boxIPInput.Text = "";
            button4.Enabled = false;
            btnClearIpForm.Enabled = false;
        }

        private void boxIPAnswer_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            string[] separate = e.LinkText.Split('#');
            System.Diagnostics.Process.Start(separate[1]);
        }

        private void btnIpCheckStat_Click(object sender, EventArgs e)
        {
            IpBox dialog = new IpBox(savedIPList);
            DialogResult dialogresult = dialog.ShowDialog();
            if (dialogresult == DialogResult.OK)
            {
                dialog.Dispose();
            }
        }


    }
}
