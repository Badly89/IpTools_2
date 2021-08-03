using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Net;
using System.Windows.Forms;


namespace OpTools
{


    public partial class Form1 : Form
    {
        public List<Metalki> metalki = new List<Metalki>();
        public double pitZaryad = 0;
        public string previousIpCountry = "";
        public double pitBuyCost = 0;
        public List<pitItem> itemsGivenToPit = new List<pitItem>();
        public List<pitItem> itemsGetFromPit = new List<pitItem>();
        public List<ReqIpRest> SaveIpRequest = new List<ReqIpRest>();
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
        public int reqPerMonth = 10000; //запросы в месяц для сервиса IpShois
        public int reqComplete = 0; //выполненных запросов

        public Form1()
        {
            InitializeComponent();

        }

        private void radioNicRu_CheckedChanged(object sender, EventArgs e)
        {
            rdIpShois.Text = "https://ipwhois.io/";
        }

        private void IpLinkRadioChangedToggle()
        {
            if (radioLinksNicRu.Checked == true)
            {
                radioLinksApehaLogs.Checked = false;
                radioNoLinksJustText.Checked = false;
            }
            else if (radioNoLinksJustText.Checked == true)
            {
                radioLinksNicRu.Checked = false;
                radioLinksApehaLogs.Checked = false;
            }
            else if (radioLinksApehaLogs.Checked == true)
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
            rdIpShois.Text = "https://ipwhois.io/";
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
                btnIpCheckStat.Text = "СТАТИСТИКА ПРОВЕРКИ";
                btnIpCheckStat.Enabled = false;
                radioLinksApehaLogs.Enabled = false;
                radioLinksNicRu.Enabled = false;
                rdIpShois.Text = "https://ipwhois.io/";
                radioNoLinksJustText.Enabled = false;
                radioIpcalc.Enabled = false;
                radioRipe.Enabled = false;
                rdIpShois.Enabled = false;
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

                                string answerForCurrentIP = getIpInfo(lineIP);

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
                rdIpShois.Text = "https://ipwhois.io/ - Осталось запросов: " + ReqCalc(reqComplete) + " из " + reqPerMonth + "/мес";
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

                radioIpcalc.Enabled = true;
                rdIpShois.Enabled = true;
                radioRipe.Enabled = true;

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
                    if (lineToDetect.Contains("Неизвестный город #6") || lineToDetect.Contains("Неизвестный город #7"))
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
            if (radioLinksNicRu.Checked == true)
            {

                boxIPAnswer.InsertLink(ip, "https://ipinfo.io/" + ip);
            }
            else if (radioNoLinksJustText.Checked == true)
            {
                boxIPAnswer.AppendText(ip);
            }
            else if (radioLinksApehaLogs.Checked == true)
            {
                boxIPAnswer.InsertLink(ip, "http://kovcheg.apeha.ru/ulog_ip" + "_" + generateIpNumber(ip) + "_" + "showall_1.lhtml");
            }


            boxIPAnswer.AppendText(" ");
            foreach (IpClass ipFromSavedList in savedIPList)
            {
                if (ip == ipFromSavedList.Ip)
                {
                    if (radioIpcalc.Checked)
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
                            //boxIPAnswer.SelectionColor = Color.Green;
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
            #region ipcalc.co
            //Checking using ipcalc.co
            if (radioIpcalc.Checked == true)
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
                ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
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

                IpClass ipToSave = new IpClass
                {
                    Ip = ip,
                    City = temp1
                };

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
                return temp1;
            }
            #endregion


            #region ripe.net
            if (radioRipe.Checked == true)
            {
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
                WebClient client = new WebClient();
                string jsonadress = client.DownloadString("https://rest.db.ripe.net/search.json?query-string=" + ip + "&flags=no-referenced&flags=no-irt&flags=no-filtering&source=RIPE");
                var jPerson = JsonConvert.DeserializeObject<Welcome>(jsonadress, Converter.Settings);
                string temp1 = "";
                //string country = "";
                int count = jPerson.Objects.Object[0].Attributes.Attribute.Count;
                for (int i = 0; i < count; i++)
                {
                    temp1 = temp1 + " " + jPerson.Objects.Object[0].Attributes.Attribute[i].Name + ": " + jPerson.Objects.Object[0].Attributes.Attribute[i].Value + ", ";

                }


                IpClass ipToSave = new IpClass
                {
                    Ip = ip,
                    City = temp1
                };
                savedIPList.Add(ipToSave);
                boxIPAnswer.AppendText(" - " + temp1 + "\n");
                return temp1;
            }

            #endregion

            #region ipgeobase XMLparse
            //if (radioNicRu.Checked == true)
            //{
            //    string country = "";
            //    string region = "";
            //    string district = "";
            //    string city = "";
            //    XmlDocument xDoc = new XmlDocument();
            //    xDoc.Load("http://ipgeobase.ru:7020/geo?ip="+ip);

            //    XmlElement xRoot = xDoc.DocumentElement;



            //        foreach (XmlNode xnode in xRoot)
            //        {
            //            // получаем атрибут name
            //            if (xnode.Attributes.Count > 0)
            //            {
            //                XmlNode attr = xnode.Attributes.GetNamedItem("name");
            //                if (attr != null)
            //                    Console.WriteLine(attr.Value);
            //            }
            //            // обходим все дочерние узлы элемента user
            //            foreach (XmlNode childnode in xnode.ChildNodes)
            //            {
            //                // если узел - company
            //                if (childnode.Name == "country")
            //                {
            //                    country = childnode.InnerText;
            //                }
            //                // если узел age
            //                if (childnode.Name == "city")
            //                {
            //                   city = childnode.InnerText;
            //            }
            //                if (childnode.Name == "region")
            //                {
            //                region = childnode.InnerText;
            //            }
            //                if (childnode.Name == "district")
            //                {
            //                district = childnode.InnerText;
            //            }

            //            }

            //            Console.WriteLine();
            //        }
            //        Console.Read();

            //    IpClass ipToSave = new IpClass
            //    {
            //        Ip = ip,
            //        City = country.Trim() + ", " + region.Trim() + ", " + district.Trim() + ", " + city.Trim()
            //    };
            //    savedIPList.Add(ipToSave);
            //    if (!previousIpCountry.Equals("") && !previousIpCountry.Equals(country.Trim()))
            //    {
            //        boxIPAnswer.SelectionColor = Color.Red;
            //        boxIPAnswer.AppendText(" - " + country.Trim() + ", " + region.Trim() + ", " + district.Trim() + ", " + city.Trim() + "\n");
            //    }
            //    else
            //    {
            //        boxIPAnswer.AppendText(" - " + country.Trim() + ", " + region.Trim() + ", " + district.Trim() + ", " + city.Trim() + "\n");
            //    }
            //    previousIpCountry = country.Trim();
            //    return country.Trim() + ", " + region.Trim() + ", " + district.Trim() + ", " + city.Trim();
            //}
            #endregion

            #region apiiplocation.co

            //if (rbIploc.Checked == true)
            //{                
            //    string country = "";
            //    string desc = "";

            //    ServicePointManager.Expect100Continue = true;
            //    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            //    ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
            //    WebClient client = new WebClient();

            //    string jsonadress = client.DownloadString("https://api.iplocation.net/?ip=" + ip.TrimStart());
            //    var jPerson = JsonConvert.DeserializeObject<dynamic>(jsonadress);
            //    if (jPerson.country_name != null) { country = jPerson.country_name; }
            //    if (jPerson.isp != null) { desc = jPerson.isp; }

            //    // var temp1 = country.Trim() + ", " + region.Trim() + ", " + okrug.Trim() + ", " + city.Trim() + ", " + asn_organization.Trim() + ", " + desc.Trim() + ", " + org.Trim();
            //    var temp1 = country.Trim() + ", " + desc.Trim();

            //    IpClass ipToSave = new IpClass
            //    {
            //        Ip = ip,
            //        City = temp1
            //    };

            //    savedIPList.Add(ipToSave);
            //    if (!previousIpCountry.Equals("") && !previousIpCountry.Equals(country.Trim()))
            //    {
            //        boxIPAnswer.SelectionColor = Color.Red;
            //        //   boxIPAnswer.AppendText(" - " + country.Trim() + ", " + region.Trim() + ", " + okrug.Trim() + ", " + city.Trim() + ", " + asn_organization.Trim() + ", " + desc.Trim() + ", " + org.Trim() + "\n");
            //        boxIPAnswer.AppendText(" - " + country.Trim() + ", " + desc.Trim() + "\n");
            //    }
            //    else
            //    {
            //        //boxIPAnswer.AppendText(" - " + country.Trim() + ", " + region.Trim() + ", " + okrug.Trim() + ", " + city.Trim() + ", " + asn_organization.Trim() + ", " + desc.Trim() + ", " + org.Trim() + "\n");
            //        boxIPAnswer.AppendText(" - " + country.Trim() + ", " + desc.Trim() + "\n");
            //    }
            //    previousIpCountry = country.Trim();
            //    return temp1;
            //}
            #endregion

            return null;

        }
        #region classJSonParse
        public partial class Welcome
        {
            [JsonProperty("service")]
            public Service Service { get; set; }

            [JsonProperty("parameters")]
            public Parameters Parameters { get; set; }

            [JsonProperty("objects")]
            public Objects Objects { get; set; }

            [JsonProperty("terms-and-conditions")]
            public TermsAndConditions TermsAndConditions { get; set; }

            [JsonProperty("version")]
            public Version Version { get; set; }
        }

        public partial class Objects
        {
            [JsonProperty("object")]
            public List<Object> Object { get; set; }
        }

        public partial class Object
        {
            [JsonProperty("type")]
            public string Type { get; set; }

            [JsonProperty("link")]
            public TermsAndConditions Link { get; set; }

            [JsonProperty("source")]
            public Source Source { get; set; }

            [JsonProperty("primary-key")]
            public PrimaryKey PrimaryKey { get; set; }

            [JsonProperty("attributes")]
            public Attributes Attributes { get; set; }

            [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
            public Tags Tags { get; set; }
        }

        public partial class Attributes
        {
            [JsonProperty("attribute")]
            public List<AttributesAttribute> Attribute { get; set; }
        }

        public partial class AttributesAttribute
        {
            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("value")]
            public string Value { get; set; }

            [JsonProperty("link", NullValueHandling = NullValueHandling.Ignore)]
            public TermsAndConditions Link { get; set; }

            [JsonProperty("referenced-type", NullValueHandling = NullValueHandling.Ignore)]
            public string ReferencedType { get; set; }

            [JsonProperty("comment", NullValueHandling = NullValueHandling.Ignore)]
            public string Comment { get; set; }
        }

        public partial class TermsAndConditions
        {
            [JsonProperty("type")]
            public string Type { get; set; }

            [JsonProperty("href")]
            public Uri Href { get; set; }
        }

        public partial class PrimaryKey
        {
            [JsonProperty("attribute")]
            public List<PrimaryKeyAttribute> Attribute { get; set; }
        }

        public partial class PrimaryKeyAttribute
        {
            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("value")]
            public string Value { get; set; }
        }

        public partial class Source
        {
            [JsonProperty("id")]
            public string Id { get; set; }
        }

        public partial class Tags
        {
            [JsonProperty("tag")]
            public List<Source> Tag { get; set; }
        }

        public partial class Parameters
        {
            [JsonProperty("inverse-lookup")]
            public InverseLookup InverseLookup { get; set; }

            [JsonProperty("type-filters")]
            public InverseLookup TypeFilters { get; set; }

            [JsonProperty("flags")]
            public Flags Flags { get; set; }

            [JsonProperty("query-strings")]
            public QueryStrings QueryStrings { get; set; }

            [JsonProperty("sources")]
            public Sources Sources { get; set; }
        }

        public partial class Flags
        {
            [JsonProperty("flag")]
            public List<Flag> Flag { get; set; }
        }

        public partial class Flag
        {
            [JsonProperty("value")]
            public string Value { get; set; }
        }

        public partial class InverseLookup
        {
        }

        public partial class QueryStrings
        {
            [JsonProperty("query-string")]
            public List<Flag> QueryString { get; set; }
        }

        public partial class Sources
        {
            [JsonProperty("source")]
            public List<Source> Source { get; set; }
        }

        public partial class Service
        {
            [JsonProperty("name")]
            public string Name { get; set; }
        }

        public partial class Version
        {
            [JsonProperty("version")]
            public string VersionVersion { get; set; }

            [JsonProperty("timestamp")]
            public DateTimeOffset Timestamp { get; set; }

            [JsonProperty("commit-id")]
            public string CommitId { get; set; }
        }

        internal static class Converter
        {
            public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
                Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
            };
        }

        #endregion

        private int ReqCalc(int req)
        {
            var ReqLeft = reqPerMonth - req;


            return ReqLeft;
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
            string[] lines = fullLog.TrimStart().Split('\n');

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
            string[] firstParse = line.TrimStart().Split(' ');
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

                string[] firstParse = line.TrimStart().Split(' ');
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
            Transfer item = new Transfer
            {
                Id = id_giv,
                IsOk = false,
                Trans = proccessItem(line)
            };
            id_giv++;
            givenItems.Add(item);
        }

        private void itemsReceived(string line)
        {
            Transfer item = new Transfer
            {
                Id = id_rec,
                IsOk = false,
                Trans = proccessItem(line)
            };
            id_rec++;
            receivedItems.Add(item);
        }

        private Event proccessItem(string line)
        {
            int startWord;
            int cityWords;
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
            rtbexPitOutPut.Text = "";
            rtbexPitOutPut.Enabled = false;
            checkPitFilter.Checked = false;
        }

        private void btnPitProcess_Click_1(object sender, EventArgs e)
        {
            rtbexPitOutPut.Text = "";
            rtbexPitOutPut.Enabled = true;
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
            //String pitItemsAnswer = "";
            String pitItemsBackAnswer = "";


            if (pitSinSlot)
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

            rtbexPitOutPut.AppendText(pitAnswer);
           
            var itemGivPitCount = itemsGetFromPit.Count;
            var itemGetPitCount = itemsGetFromPit.Count;

           // MessageBox.Show(itemGivPitCount.ToString());
           // MessageBox.Show(itemGetPitCount.ToString());
            if (itemGivPitCount ==0)
            {
                rtbexPitOutPut.AppendText("Нет вещей, оставшихся у пита\n");
                

            }
            else
            {
                rtbexPitOutPut.AppendText("Вещи, переданные питомцу и не вернувшиеся хозяину:\n");
                foreach (pitItem item in itemsGivenToPit)
                {

                    if (item.consider == true)
                    {

                        rtbexPitOutPut.AppendText(item.name + " ");
                        rtbexPitOutPut.InsertLink("[" + item.id + "]", "https://kovcheg.apeha.ru/ulog_showall_1_item_" + item.id + ".lhtml");
                        rtbexPitOutPut.AppendText(" -" + item.count + "шт.\n");

                    }


                }

            }
           
                foreach (pitItem item in itemsGetFromPit)
                {

                    if (item.consider == true)
                    {
                        pitItemsBackAnswer += item.name + " "+ " [" + item.id + "] "+ " -" + item.count + "шт.\n";
                    }


                }
            
            

            //if (pitItemsAnswer.Length > 1)
            //{
            //    pitAnswer += "Вещи, переданные питомцу и не вернувшиеся хозяину:\n" + pitItemsAnswer + "\n";
            //    MessageBox.Show(pitItemsAnswer);
            //}
            //else
            //{
            //    pitAnswer += "Нет вещей, оставшихся у пита\n";
            //}
            if (pitItemsBackAnswer.Length > 1)
            {
                rtbexPitOutPut.Text += "Вещи, возвращённые, но, не учтённые выше из-за разного количества вещей при передаче: \n" + pitItemsBackAnswer;

            }




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
            pitItem item = new pitItem
            {
                consider = true
            };
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
            rtbexPitOutPut.Text = output;
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
                if (st.Length == 10 && st.Contains("-19"))
                {
                    currLineDate = DateTime.ParseExact(st, "dd-MM-yyyy", CultureInfo.InvariantCulture);

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
                                Metalki met = new Metalki
                                {
                                    Date = currLineDate,
                                    Finished = false,
                                    Summ = 0,
                                    Id = getIdByLine(st)
                                };
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

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "OPTools " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //            this.Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(boxResult.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtbexPitOutPut.Text);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            boxIPAnswer.SelectAll();

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            boxIPAnswer.Copy();
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            boxIPInput.Paste();
        }

        private void rdIpShois_CheckedChanged(object sender, EventArgs e)
        {
            rdIpShois.Text = "Дается: " + reqPerMonth + "/мес запросов. В конце показывает остаток запросов";
        }

        private void RtbexPitOutPut_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            string[] separate = e.LinkText.Split('#');
            System.Diagnostics.Process.Start(separate[1]);
        }
    }
}
