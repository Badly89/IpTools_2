namespace IpTools_2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.boxIPInput = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnIpCheckStat = new System.Windows.Forms.Button();
            this.btnCheckIPs = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioLinksNicRu = new System.Windows.Forms.RadioButton();
            this.radioLinksApehaLogs = new System.Windows.Forms.RadioButton();
            this.radioNoLinksJustText = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioWhoisRu = new System.Windows.Forms.RadioButton();
            this.radioNicRu = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.boxIPAnswer = new RichTextBoxLinks.RichTextBoxEx();
            this.btnClearIpForm = new System.Windows.Forms.Button();
            this.rbipcom = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.boxIPInput);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(821, 161);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сюда вставьте логи пишников (внимание, при большом количестве пишников - придётся" +
    " подождать):";
            // 
            // boxIPInput
            // 
            this.boxIPInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxIPInput.Location = new System.Drawing.Point(3, 16);
            this.boxIPInput.Name = "boxIPInput";
            this.boxIPInput.Size = new System.Drawing.Size(815, 142);
            this.boxIPInput.TabIndex = 2;
            this.boxIPInput.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.btnIpCheckStat);
            this.groupBox2.Controls.Add(this.btnCheckIPs);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(821, 149);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры проверки";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Beige;
            this.button4.Enabled = false;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.Coral;
            this.button4.Location = new System.Drawing.Point(531, 84);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(278, 59);
            this.button4.TabIndex = 21;
            this.button4.Text = "Скопировать в буфер обмена";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnIpCheckStat
            // 
            this.btnIpCheckStat.BackColor = System.Drawing.Color.SkyBlue;
            this.btnIpCheckStat.Enabled = false;
            this.btnIpCheckStat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIpCheckStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnIpCheckStat.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnIpCheckStat.Location = new System.Drawing.Point(531, 18);
            this.btnIpCheckStat.Name = "btnIpCheckStat";
            this.btnIpCheckStat.Size = new System.Drawing.Size(278, 60);
            this.btnIpCheckStat.TabIndex = 19;
            this.btnIpCheckStat.Text = "СТАТИСТИКА ПРОВЕРКИ";
            this.btnIpCheckStat.UseVisualStyleBackColor = false;
            this.btnIpCheckStat.Click += new System.EventHandler(this.btnIpCheckStat_Click);
            // 
            // btnCheckIPs
            // 
            this.btnCheckIPs.BackColor = System.Drawing.Color.Teal;
            this.btnCheckIPs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCheckIPs.ForeColor = System.Drawing.Color.Cyan;
            this.btnCheckIPs.Location = new System.Drawing.Point(3, 84);
            this.btnCheckIPs.Name = "btnCheckIPs";
            this.btnCheckIPs.Size = new System.Drawing.Size(451, 59);
            this.btnCheckIPs.TabIndex = 17;
            this.btnCheckIPs.Text = "ПРОВЕРИТЬ IP";
            this.btnCheckIPs.UseVisualStyleBackColor = false;
            this.btnCheckIPs.Click += new System.EventHandler(this.btnCheckIPs_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioLinksNicRu);
            this.groupBox4.Controls.Add(this.radioLinksApehaLogs);
            this.groupBox4.Controls.Add(this.radioNoLinksJustText);
            this.groupBox4.Location = new System.Drawing.Point(225, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(300, 65);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Делать айпишники:";
            // 
            // radioLinksNicRu
            // 
            this.radioLinksNicRu.AutoSize = true;
            this.radioLinksNicRu.Checked = true;
            this.radioLinksNicRu.Location = new System.Drawing.Point(6, 19);
            this.radioLinksNicRu.Name = "radioLinksNicRu";
            this.radioLinksNicRu.Size = new System.Drawing.Size(141, 17);
            this.radioLinksNicRu.TabIndex = 11;
            this.radioLinksNicRu.TabStop = true;
            this.radioLinksNicRu.Text = "Ссылками на 2whois.ru";
            this.radioLinksNicRu.UseVisualStyleBackColor = true;
            this.radioLinksNicRu.CheckedChanged += new System.EventHandler(this.radioLinksNicRu_CheckedChanged);
            // 
            // radioLinksApehaLogs
            // 
            this.radioLinksApehaLogs.AutoSize = true;
            this.radioLinksApehaLogs.Location = new System.Drawing.Point(6, 41);
            this.radioLinksApehaLogs.Name = "radioLinksApehaLogs";
            this.radioLinksApehaLogs.Size = new System.Drawing.Size(155, 17);
            this.radioLinksApehaLogs.TabIndex = 12;
            this.radioLinksApehaLogs.Text = "Ссылками на логи Арены";
            this.radioLinksApehaLogs.UseVisualStyleBackColor = true;
            this.radioLinksApehaLogs.CheckedChanged += new System.EventHandler(this.radioLinksApehaLogs_CheckedChanged);
            // 
            // radioNoLinksJustText
            // 
            this.radioNoLinksJustText.AutoSize = true;
            this.radioNoLinksJustText.Location = new System.Drawing.Point(166, 19);
            this.radioNoLinksJustText.Name = "radioNoLinksJustText";
            this.radioNoLinksJustText.Size = new System.Drawing.Size(131, 17);
            this.radioNoLinksJustText.TabIndex = 13;
            this.radioNoLinksJustText.Text = "Текстом без ссылок";
            this.radioNoLinksJustText.UseVisualStyleBackColor = true;
            this.radioNoLinksJustText.CheckedChanged += new System.EventHandler(this.radioNoLinksJustText_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbipcom);
            this.groupBox3.Controls.Add(this.radioWhoisRu);
            this.groupBox3.Controls.Add(this.radioNicRu);
            this.groupBox3.Location = new System.Drawing.Point(6, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(216, 65);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Использовать сервис:";
            // 
            // radioWhoisRu
            // 
            this.radioWhoisRu.AutoSize = true;
            this.radioWhoisRu.Checked = true;
            this.radioWhoisRu.Location = new System.Drawing.Point(17, 19);
            this.radioWhoisRu.Name = "radioWhoisRu";
            this.radioWhoisRu.Size = new System.Drawing.Size(80, 17);
            this.radioWhoisRu.TabIndex = 6;
            this.radioWhoisRu.Text = "IPCALC.CO";
            this.radioWhoisRu.UseVisualStyleBackColor = true;
            this.radioWhoisRu.CheckedChanged += new System.EventHandler(this.radioWhoisRu_CheckedChanged);
            // 
            // radioNicRu
            // 
            this.radioNicRu.AutoSize = true;
            this.radioNicRu.Location = new System.Drawing.Point(17, 42);
            this.radioNicRu.Name = "radioNicRu";
            this.radioNicRu.Size = new System.Drawing.Size(105, 17);
            this.radioNicRu.TabIndex = 7;
            this.radioNicRu.Text = "IPGEOBASE.RU";
            this.radioNicRu.UseVisualStyleBackColor = true;
            this.radioNicRu.CheckedChanged += new System.EventHandler(this.radioNicRu_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.boxIPAnswer);
            this.groupBox5.Location = new System.Drawing.Point(0, 310);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(821, 128);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Результат проверки";
            // 
            // boxIPAnswer
            // 
            this.boxIPAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxIPAnswer.Enabled = false;
            this.boxIPAnswer.Location = new System.Drawing.Point(3, 16);
            this.boxIPAnswer.Name = "boxIPAnswer";
            this.boxIPAnswer.Size = new System.Drawing.Size(815, 109);
            this.boxIPAnswer.TabIndex = 4;
            this.boxIPAnswer.Text = "";
            this.boxIPAnswer.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.boxIPAnswer_LinkClicked);
            // 
            // btnClearIpForm
            // 
            this.btnClearIpForm.BackColor = System.Drawing.Color.Thistle;
            this.btnClearIpForm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClearIpForm.Enabled = false;
            this.btnClearIpForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearIpForm.Location = new System.Drawing.Point(0, 440);
            this.btnClearIpForm.Name = "btnClearIpForm";
            this.btnClearIpForm.Size = new System.Drawing.Size(821, 42);
            this.btnClearIpForm.TabIndex = 21;
            this.btnClearIpForm.Text = "ОЧИСТИТЬ";
            this.btnClearIpForm.UseVisualStyleBackColor = false;
            this.btnClearIpForm.Click += new System.EventHandler(this.btnClearIpForm_Click_1);
            // 
            // rbipcom
            // 
            this.rbipcom.AutoSize = true;
            this.rbipcom.Location = new System.Drawing.Point(110, 19);
            this.rbipcom.Name = "rbipcom";
            this.rbipcom.Size = new System.Drawing.Size(82, 17);
            this.rbipcom.TabIndex = 8;
            this.rbipcom.Text = "IP.API.COM";
            this.rbipcom.UseVisualStyleBackColor = true;
            this.rbipcom.CheckedChanged += new System.EventHandler(this.rbipcom_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 482);
            this.Controls.Add(this.btnClearIpForm);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ОП IP Tools ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox boxIPInput;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnIpCheckStat;
        private System.Windows.Forms.Button btnCheckIPs;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioLinksNicRu;
        private System.Windows.Forms.RadioButton radioLinksApehaLogs;
        private System.Windows.Forms.RadioButton radioNoLinksJustText;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioWhoisRu;
        private System.Windows.Forms.RadioButton radioNicRu;
        private System.Windows.Forms.GroupBox groupBox5;
        private RichTextBoxLinks.RichTextBoxEx boxIPAnswer;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnClearIpForm;
        private System.Windows.Forms.RadioButton rbipcom;
    }
}

