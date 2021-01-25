﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace IpTools_2
{


    public partial class Form1 : Form
    {
        public List<Metalki> metalki = new List<Metalki>();
        public double pitZaryad = 0;
        public string previousIpCountry = "";
        public double pitBuyCost = 0;
        public List<pitItem> itemsGivenToPit = new List<pitItem>();
        public List<pitItem> itemsGetFromPit = new List<pitItem>();
        public double pitFoodCost = 0;
        public double pitIncome = 0;
        public double pitSlotCost = 0;
        public bool pitSinSlot = false;
        public List<IpClass> savedIPList = new List<IpClass>();
        public bool ignoreMods = true;
        public bool ignoreUsils = true;
        public string answer = "";
        public int id_giv = 0;
        public int id_rec = 0;
        public double moneyGiven = 0;
        public double moneyReceived = 0;
        public double moneyBalance = 0;
        public List<Transfer> receivedItems = new List<Transfer>();
        public List<Transfer> givenItems = new List<Transfer>();
        public string currentDate;
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
                string ipList = boxIPInput.Text;
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

                                string answerForCurrentIP = getIpInfo(lineIP).Trim();
                                ipsAlreadyChecked++;
                                btnCheckIPs.Text = "Результат обрабатывается. Пожалуйста, подождите... Готово: " + ipsAlreadyChecked + "/" + numberIpsToCheck;
                                Application.DoEvents();
                            }
                            else
                            {
                                if (lineIP.Contains("Ковчег") || lineIP.Contains("Утес дракона") || lineIP.Contains("Среднеморье") || lineIP.Contains("Лес") || lineIP.Contains("Остров фантазий") || lineIP.Contains("Магический Лес") || lineIP.Length > 11)
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
            if (lineToDetect.Contains("Утес дракона") || lineToDetect.Contains("Остров фантазий") || lineToDetect.Contains("Магический Лес")) 
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
            string[] separateWords = line.TrimStart(' ').Split(' ');
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
                string jsonadress = client.DownloadString("https://ipcalc.co/ipdata/" + ip.TrimStart());
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
                    boxIPAnswer.AppendText(" - " + country.Trim() + ", " + region.Trim() + ", " + okrug.Trim() + ", " + city.Trim() + ", " + asn_organization.Trim() + ", " + org.Trim() + "\n");
                }
                else
                {
                    boxIPAnswer.AppendText(" - " + country.Trim() + ", " + region.Trim() + ", " + okrug.Trim() + ", " + city.Trim() + ", " + asn_organization.Trim() + ", " + org.Trim() + "\n");
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

        //супружеские передачи
        private void chkIgnoreMod_CheckStateChanged(object sender, EventArgs e)
        {
            ignoreMods = chkIgnoreMod.Checked;
        }

        private void chkIgnoreUsils_CheckStateChanged_1(object sender, EventArgs e)
        {
            ignoreUsils = chkIgnoreUsils.Checked;
        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            boxInput.Clear();
            btnCopy.Enabled = false;
            boxResult.Text = "";
            boxResult.Enabled = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            answer = "";
            id_giv = 0;
            id_rec = 0;
            moneyGiven = 0;
            moneyReceived = 0;
            receivedItems.Clear();
            givenItems.Clear();
            string fullLog = boxInput.Text;
            string[] lines = fullLog.Split('\n');
            proccessLines(lines);
        }
        private void proccessLines(string[] lines)
        {
            foreach (string singleLine in lines)
            {
                //checking if line is date
                if (singleLine.Length > 3 && singleLine.Length < 12) currentDate = singleLine.Trim();
                if (singleLine.Length > 15)
                {
                    if (singleLine.Contains("Передал"))
                    {
                        itemGiven(singleLine);
                    }
                    if (singleLine.Contains("Получил"))
                    {
                        itemsReceived(singleLine);
                    }
                    if (singleLine.Contains("Доход :"))
                    {
                        moneyReceivedProccess(singleLine);

                    }
                    if (singleLine.Contains("Расход :"))
                    {
                        moneyGivenProccess(singleLine);
                    }
                }
            }
            moneyBalance = Math.Round(moneyReceived, 2) + Math.Round(moneyGiven, 2);
            if (givenItems.Count > 0 || receivedItems.Count > 0 || moneyBalance != 0)
            {
                processItemsCalculation();
            }
            else
            {
                boxResult.Text = "Всё пучком :)";
            }
        }

        private void processItemsCalculation()
        {
            foreach (Transfer itemG in givenItems)
            {
                if (itemG.IsOk == false)
                {
                    foreach (Transfer itemR in receivedItems)
                    {
                        bool id_passed = false;
                        bool mods_passed = false;
                        bool usils_passed = false;
                        bool count_passed = false;

                        if ((itemG.Trans.Id == itemR.Trans.Id) && (itemR.IsOk == false))
                        {
                            id_passed = true;
                            if ((itemG.Trans.Mod == itemR.Trans.Mod && itemG.Trans.Zakl == itemR.Trans.Zakl) || ignoreMods == true)
                            {
                                mods_passed = true;
                            }
                            if (itemG.Trans.Usil == itemR.Trans.Usil || ignoreUsils == true)
                            {
                                usils_passed = true;
                            }
                            if (itemG.Trans.Count == itemR.Trans.Count)
                            {
                                count_passed = true;
                            }
                            if (id_passed == true && mods_passed == true && usils_passed == true && count_passed == true)
                            {
                                itemG.IsOk = true;
                                itemR.IsOk = true;
                                id_passed = false;
                                mods_passed = false;
                                usils_passed = false;
                                count_passed = false;
                                break;
                            }
                            else
                            {
                                id_passed = false;
                                mods_passed = false;
                                usils_passed = false;
                                count_passed = false;
                            }
                        }
                    }
                }
            }
            answer += "Баланс по соткам: " + Math.Round(moneyBalance, 2) + "\n";
            int countG = 0;
            int countR = 0;
            string tempG = "";
            string tempR = "";
            foreach (Transfer iG in givenItems)
            {
                if (iG.IsOk == false)
                {
                    countG++;
                    tempG += iG.Trans.Date + " Передал: " + iG.Trans.Name + " [" + iG.Trans.Id + "] " + "(" + iG.Trans.Count + " шт.)\n";
                }
            }
            foreach (Transfer iR in receivedItems)
            {
                if (iR.IsOk == false)
                {
                    countR++;
                    tempR += iR.Trans.Date + " Получил: " + iR.Trans.Name + " [" + iR.Trans.Id + "] " + "(" + iR.Trans.Count + " шт.)\n";
                }
            }
            if (countG > 0)
            {
                answer += "\nЗабрать у супруга/супруги:\n" + tempG;
            }
            if (countR > 0)
            {
                answer += "\nВернуть супругу/супруге:\n" + tempR;
            }
            boxResult.Text = answer;
            btnCopy.Enabled = true;
            boxResult.Enabled = true;
        }


        private void moneyGivenProccess(string line)
        {
            int startWord = 0;
            if (line.Contains("Утес дракона") || line.Contains("Остров фантазий"))
            {
                startWord = 5;
            }
            else
            {
                startWord = 4;
            }
            string[] firstParse = line.Split(' ');
            string str = firstParse[startWord];
            int n = str.IndexOf("ст.");
            str = str.Remove(n, 3);
            moneyGiven += Math.Round(Convert.ToSingle(str, System.Globalization.CultureInfo.InvariantCulture), 2);
        }

        private void moneyReceivedProccess(string line)
        {
            if (!line.Trim().Contains("син."))
            {
                int startWord = 0;
                if (line.Contains("Утес дракона") || line.Contains("Остров фантазий"))
                {
                    startWord = 5;
                }
                else
                {
                    startWord = 4;
                }
                string[] firstParse = line.Split(' ');
                string str = firstParse[startWord];
                int n = str.IndexOf("ст.");
                try
                {
                    str = str.Remove(n, 3);
                }
                catch (Exception)
                {
                    char[] charsToRemove = { 'с', 'т', '.' };
                    str = str.Trim(charsToRemove);
                }
                try
                {
                    moneyReceived += Math.Round(toDoubleCustom(str), 2);
                }
                catch (Exception)
                {
                    moneyReceived += Math.Round(toDoubleCustom(str), 2);
                }
            }
        }

        private double toDoubleCustom(String str)
        {
            double res = 0;
            try
            {
                res = double.Parse(str, NumberStyles.AllowDecimalPoint, CultureInfo.CurrentCulture);
            }
            catch (Exception)
            {
                try
                {
                    res = Convert.ToDouble(str.Replace('.', '.'));
                }
                catch (Exception)
                {
                    try
                    {
                        res = Convert.ToDouble(str.Replace('.', ','));
                    }
                    catch (Exception)
                    {
                        try
                        {
                            Convert.ToDouble(str, System.Globalization.CultureInfo.InvariantCulture);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Ошибочка в конвертации Double. Пишите ~root~ ");
                            MessageBox.Show(str);
                        }
                    }

                }
            }
            return res;
        }

        private void itemGiven(string line)
        {
            Transfer item = new Transfer();
            item.Id = id_giv;
            item.IsOk = false;
            item.Trans = proccessItem(line);
            id_giv++;
            givenItems.Add(item);
        }

        private void itemsReceived(string line)
        {
            Transfer item = new Transfer();
            item.Id = id_rec;
            item.IsOk = false;
            item.Trans = proccessItem(line);
            id_rec++;
            receivedItems.Add(item);
        }

        private Event proccessItem(string line)
        {
            int startWord = 0;
            int cityWords = 0;
            if (line.Contains("Утес дракона") || line.Contains("Остров фантазий"))
            {
                startWord = 5;
                cityWords = 2;
            }
            else
            {
                startWord = 4;
                cityWords = 1;
            }
            string itemName = "";
            int startId = 0;
            Event ev = new Event();
            //parse string
            string[] firstParse = line.Split(' ');
            ev.Date = currentDate + " " + firstParse[cityWords];
            //get item name
            for (int i = startWord; i < 20; i++)
            {
                if (!firstParse[i].Contains("["))
                {
                    itemName += firstParse[i] + " ";
                }
                else { startId = i; break; }
            }
            ev.Name = itemName;
            if (itemName.Contains("мод."))
            {
                ev.Mod = true;
            }
            if (itemName.Contains("закл."))
            {
                ev.Zakl = true;
            }
            //Count
            char[] charsToTrimCount = { '(', '-' };
            ev.Count = Convert.ToInt32(firstParse[startId + 1].Trim(charsToTrimCount));
            //usils
            if (itemName.Contains(" +"))
            {
                ev.Usil = firstParse[startId - 2] + firstParse[startId - 1];
            }
            else
            {
                ev.Usil = "";
            }
            //get item id
            char[] charsToTrim = { '[', ']' };
            ev.Id = Convert.ToInt32(firstParse[startId].Trim(charsToTrim));
            return ev;
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            boxLogsFight.Text = "";
            boxLogsReply.Text = "";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            calculateExp();
        }
        private void calculateExp()
        {
            string logs = boxLogsFight.Text;
            string[] logsLines = logs.Split('\n');
            double plusExp = 0;
            double minusExp = 0;
            string reply = "";
            foreach (string str in logsLines)
            {
                if (str.Contains("apeha.ru"))
                {
                    string[] parseLogString = str.Split(' ');
                    char[] charsToTrim = { '+', '-' };
                    int val = Convert.ToInt32(parseLogString[1].Trim(charsToTrim));
                    if (str.Contains("+"))
                    {
                        plusExp += val;
                    }
                    else
                    {
                        minusExp += val;
                    }
                }
            }
            reply += "Итого: ";
            if (plusExp > 0) { reply += "+" + plusExp + " опыта"; }
            if (plusExp > 0 && minusExp > 0) { reply += "/"; }
            if (minusExp > 0) { reply += "-" + minusExp + " опыта"; }
            reply += "\n";
            if (plusExp > 0)
            {
                reply += "Доход: " + Convert.ToDouble(plusExp / 100) + " ст. \n";
                reply += "Штраф: " + Math.Ceiling(Convert.ToDouble(plusExp * 2 / 100)) + " ст. \n";
                reply += "Штраф по опыту: " + Math.Ceiling(Convert.ToDouble(plusExp * 2)) + " опыта";
            }
            boxLogsReply.Text = reply;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Clipboard.SetText(boxLogsReply.Text);
        }

        private void btnPiClear_Click_1(object sender, EventArgs e)
        {
            boxPitInput.Text = "";
            boxPitOutput.Text = "";
            boxPitOutput.Enabled = false;
            checkPitFilter.Checked = false;
        }

        private void btnPitProcess_Click_1(object sender, EventArgs e)
        {
            boxPitOutput.Enabled = true;
            List<String> inputLines = cleanLogForPit();
            if (checkPitFilter.Checked == true)
            {
                simpleFilterOutput(inputLines);
            }
            else
            {
                calculateMetalZaryad();
                calculatePitIncome(inputLines);
                calculateFoodCost(inputLines);
                calculateSlotCost(inputLines);
                calculatePitItems(inputLines);
                calculateBuyPitCost(inputLines);
                generatePitAnswer();
            }
        }
        private void generatePitAnswer()
        {
            String pitAnswer = "";
            String pitItemsAnswer = "";
            String pitItemsBackAnswer = "";
            foreach (pitItem item in itemsGivenToPit)
            {
                if (item.consider == true)
                {
                    pitItemsAnswer += item.name + " [" + item.id + "] " + item.count + "шт.\n";
                }
            }
            foreach (pitItem item in itemsGetFromPit)
            {
                if (item.consider == true)
                {
                    pitItemsBackAnswer += item.name + " [" + item.id + "] " + item.count + "шт.\n";
                }
            }
            if (pitSinSlot == true)
            {
                pitAnswer += "У питомца были открыты доп. слоты за синие сотки:\n\n";
            }
            pitAnswer += "Расходы на питомца:\n";
            pitAnswer += "Покупка питомца: " + pitBuyCost + " соток\n";
            pitAnswer += "Затраты на питание: " + pitFoodCost + " соток\n";
            pitAnswer += "Покупка слотов питомцу: " + pitSlotCost + " соток\n";
            pitAnswer += "Заряд метательного оружия: " + pitZaryad + " соток\n";
            pitAnswer += "Итого расходы: " + Math.Round(pitBuyCost + pitFoodCost + pitSlotCost + pitZaryad, 2) + " соток\n_________________________________\n\n";
            pitAnswer += "Чистый доход от питомца (затраты не вычтены): " + pitIncome + " соток\n";
            pitAnswer += "Доход от питомца за вычетом расходов, указанных выше (без учёта стоимости вещей и упива): " + (pitIncome - Math.Round(pitBuyCost + pitFoodCost + pitSlotCost + pitZaryad, 2)) + " соток \n_________________________________\n\n";
            if (pitItemsAnswer.Length > 1)
            {
                pitAnswer += "Вещи, переданные питомцу и не вернувшиеся хозяину:\n" + pitItemsAnswer + "\n\n";
            }
            else
            {
                pitAnswer += "Нет вещей, оставшихся у пита\n\n";
            }
            if (pitItemsBackAnswer.Length > 1)
            {
                pitAnswer += "Вещи, возвращённые, но, не учтённые выше из-за разного количества вещей при передаче: \n" + pitItemsBackAnswer;
            }
            boxPitOutput.Text = pitAnswer;
        }
        private void calculateBuyPitCost(List<String> inputLines)
        {
            pitBuyCost = 0;
            foreach (String str in inputLines)
            {
                if (str.Contains("Покупка питомца"))
                {
                    pitBuyCost = getIncomeValue(str);
                }
            }
        }

        private void calculatePitItems(List<String> inputLines)
        {
            itemsGivenToPit.Clear();
            itemsGetFromPit.Clear();
            foreach (String str in inputLines)
            {
                if (str.Contains("Передал предмет") && str.Contains("Передача питомцу"))
                {
                    itemsGivenToPit.Add(pitItemProceed(str));
                }
                if (str.Contains("Получил предмет") && str.Contains("Передача от питомца"))
                {
                    itemsGetFromPit.Add(pitItemProceed(str));
                }
            }
            foreach (pitItem itemGot in itemsGetFromPit)
            {
                foreach (pitItem itemGiven in itemsGivenToPit)
                {
                    if (itemGot.name.Equals(itemGiven.name) && itemGot.id == itemGiven.id && itemGot.count == itemGiven.count && itemGot.consider == true && itemGiven.consider == true)
                    {
                        itemGot.consider = false;
                        itemGiven.consider = false;
                    }
                }
            }
        }

        private pitItem pitItemProceed(String str)
        {
            String name = "";
            pitItem item = new pitItem();
            item.consider = true;
            int startItemName = 0;
            int startItemId = 0;
            int i = 0;
            String[] words = str.Split(' ');
            foreach (String st in words)
            {
                if (st.Contains("предмет"))
                {
                    startItemName = i + 1;
                    break;
                }
                if (st.Contains("[") && st.Contains("]"))
                {
                    startItemId = i;
                }
                i++;
            }
            i = 0;
            foreach (String st in words)
            {
                if (st.Contains("[") && st.Contains("]"))
                {
                    startItemId = i;
                    break;
                }
                i++;
            }
            for (int y = startItemName; y < startItemId; y++)
            {
                name += words[y] + " ";
            }
            item.name = name;
            Char[] charsToTrimId = { '[', ']' };
            item.id = words[startItemId].Trim(charsToTrimId);
            Char[] charsToTrimCount = { '(', '-' };
            item.count = Int32.Parse(words[startItemId + 1].Trim(charsToTrimCount));
            return item;
        }

        private void calculateSlotCost(List<String> inputLines)
        {
            pitSlotCost = 0;
            foreach (String str in inputLines)
            {
                if (str.Contains("Покупка слота питомцу"))
                {
                    if (!str.Contains("син. ст"))
                    {
                        pitSlotCost += getIncomeValue(str);
                    }
                    else
                    {
                        pitSinSlot = true;
                    }
                }
            }
        }


        private void calculateFoodCost(List<String> inputLines)
        {
            pitFoodCost = 0;
            foreach (String str in inputLines)
            {
                if (str.Contains("Использовал предмет Большая Упаковка Корма"))
                {
                    pitFoodCost += 25;
                }
                if (str.Contains("Использовал предмет Cредняя Упаковка Корма"))
                {
                    pitFoodCost += 12.5;
                }
                if (str.Contains("Использовал предмет Маленькая Упаковка Корма"))
                {
                    pitFoodCost += 5;
                }
            }
        }

        private void calculatePitIncome(List<String> inputLines)
        {
            pitIncome = 0;
            foreach (String str in inputLines)
            {
                if (str.Contains("Доход от питомца"))
                {
                    pitIncome += getIncomeValue(str);
                }
            }

        }

        private double getIncomeValue(String str)
        {
            String[] words = str.Split(' ');
            int i = 0;
            foreach (String st in words)
            {
                if (st.Contains("ст"))
                {
                    break;
                }
                else
                {
                    i++;
                }
            }
            Char[] charsToTrim = { 'с', 'т', '.', '-' };
            return toDoubleCustom(words[i].Trim(charsToTrim));
        }

        private void simpleFilterOutput(List<String> inputLines)
        {
            String output = "";
            foreach (String str in inputLines)
            {
                output += str + "\n";
            }
            boxPitOutput.Text = output;
        }


        private void calculateMetalZaryad()
        {
            DateTime currLineDate = DateTime.Now;
            pitZaryad = 0;
            metalki.Clear();
            List<String> log = new List<String>();
            String input = boxPitInput.Text;
            String[] lines = input.Split('\n');
            foreach (String str in lines)
            {
                string st = str.Trim();
                if (st.Length == 10 && st.Contains("-20"))
                {
                    currLineDate = DateTime.ParseExact(st, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
                }
                if (st.Length > 12)
                {
                    if (!st.Contains("Вся выборка содержит") && !st.Contains(" по ") && !st.Contains("пользователи"))
                    {
                        if (st.Contains("Получил предмет") && st.Contains("Передача от питомца"))
                        {
                            if (st.Contains("Сякены") || st.Contains("Лук боевой") || st.Contains("Сюрикены") || st.Contains("Рогатка простая") || st.Contains("Метательные ежи") || st.Contains("Сюрикены Ученика") ||
                                st.Contains("Сякены Бронзовые") || st.Contains("Лук простой") || st.Contains("Арбалет учебный") || st.Contains("Лук охотника") || st.Contains("Арбалет лёгкий")
                                 || st.Contains("Лук боевой"))
                            {
                                Metalki met = new Metalki();
                                met.Date = currLineDate;
                                met.Finished = false;
                                met.Summ = 0;
                                met.Id = getIdByLine(st);
                                metalki.Add(met);
                            }
                        }
                        if (st.Contains("Передал предмет") && st.Contains("Передача питомцу"))
                        {
                            if (st.Contains("Сякены") || st.Contains("Лук боевой") || st.Contains("Сюрикены") || st.Contains("Рогатка простая") || st.Contains("Метательные ежи") || st.Contains("Сюрикены Ученика") ||
                                st.Contains("Сякены Бронзовые") || st.Contains("Лук простой") || st.Contains("Арбалет учебный") || st.Contains("Лук охотника") || st.Contains("Арбалет лёгкий")
                                 || st.Contains("Лук боевой"))
                            {
                                string id = getIdByLine(st);
                                foreach (Metalki met in metalki)
                                {
                                    if (met.Id.Equals(id) && !met.Finished)
                                    {
                                        if (DateTime.Compare(currLineDate, met.Date) == 0 || DateTime.Compare(currLineDate, met.Date.AddDays(1)) == 0)
                                        {
                                            met.Finished = true;
                                        }
                                        else
                                        {
                                            met.Summ = 0;
                                            met.Finished = true;
                                        }
                                    }
                                }
                            }
                        }
                        if (st.Contains("Зарядка на"))
                        {
                            string id = getIdByLine(st);
                            foreach (Metalki met in metalki)
                            {
                                if (met.Id.Equals(id) && !met.Finished)
                                {
                                    if (DateTime.Compare(currLineDate, met.Date) == 0 || DateTime.Compare(currLineDate, met.Date.AddDays(1)) == 0)
                                    {
                                        String[] words = st.Split(' ');
                                        foreach (string s in words)
                                        {
                                            if (s.Contains("-") && s.Contains("ст."))
                                            {
                                                char[] charsToTrimForSumm = { '-', 'с', 'т', '.' };
                                                met.Summ += toDoubleCustom(s.Trim(charsToTrimForSumm));
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            foreach (Metalki met in metalki)
            {
                if (met.Finished)
                {
                    pitZaryad += met.Summ;
                }
            }

        }

        private string getIdByLine(string str)
        {
            string result = "";
            String[] words = str.Split(' ');
            foreach (string s in words)
            {
                if (s.Contains("[") && s.Contains("]"))
                {
                    char[] charsToTrimForId = { '[', ']' };
                    result = s.Trim(charsToTrimForId);
                    return result;
                }
            }
            return result;
        }

        private List<String> cleanLogForPit()
        {
            List<String> result = new List<String>();
            String input = boxPitInput.Text;
            String[] lines = input.Split('\n');
            foreach (String str in lines)
            {
                if (str.Trim().Length > 12)
                {
                    if (!str.Contains("Вся выборка содержит") && !str.Contains(" по ") && !str.Contains("пользователи"))
                    {
                        if (str.Trim().Contains("питомц") || (str.Trim().Contains("Использовал предмет") && str.Trim().Contains("Упаковка Корма")) || str.Trim().Contains("Зарядка на"))
                        {
                            result.Add(str.Trim());
                        }
                    }
                }
            }
            return result;
        }
    }
}
