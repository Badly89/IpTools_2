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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.boxIPInput = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioWhoisRu = new System.Windows.Forms.RadioButton();
            this.radioNicRu = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioLinksNicRu = new System.Windows.Forms.RadioButton();
            this.radioLinksApehaLogs = new System.Windows.Forms.RadioButton();
            this.radioNoLinksJustText = new System.Windows.Forms.RadioButton();
            this.btnCheckIPs = new System.Windows.Forms.Button();
            this.btnIpCheckStat = new System.Windows.Forms.Button();
            this.btnClearIpForm = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.boxIPAnswer = new RichTextBoxLinks.RichTextBoxEx();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.boxIPInput);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(744, 161);
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
            this.boxIPInput.Size = new System.Drawing.Size(738, 142);
            this.boxIPInput.TabIndex = 2;
            this.boxIPInput.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClearIpForm);
            this.groupBox2.Controls.Add(this.btnIpCheckStat);
            this.groupBox2.Controls.Add(this.btnCheckIPs);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(744, 132);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры проверки";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioWhoisRu);
            this.groupBox3.Controls.Add(this.radioNicRu);
            this.groupBox3.Location = new System.Drawing.Point(3, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(145, 65);
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
            this.radioWhoisRu.Size = new System.Drawing.Size(68, 17);
            this.radioWhoisRu.TabIndex = 6;
            this.radioWhoisRu.TabStop = true;
            this.radioWhoisRu.Text = "ipcalc.co";
            this.radioWhoisRu.UseVisualStyleBackColor = true;
            this.radioWhoisRu.CheckedChanged += new System.EventHandler(this.radioWhoisRu_CheckedChanged);
            // 
            // radioNicRu
            // 
            this.radioNicRu.AutoSize = true;
            this.radioNicRu.Location = new System.Drawing.Point(17, 42);
            this.radioNicRu.Name = "radioNicRu";
            this.radioNicRu.Size = new System.Drawing.Size(86, 17);
            this.radioNicRu.TabIndex = 7;
            this.radioNicRu.Text = "ipgeobase.ru";
            this.radioNicRu.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioLinksNicRu);
            this.groupBox4.Controls.Add(this.radioLinksApehaLogs);
            this.groupBox4.Controls.Add(this.radioNoLinksJustText);
            this.groupBox4.Location = new System.Drawing.Point(154, 13);
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
            // 
            // btnCheckIPs
            // 
            this.btnCheckIPs.BackColor = System.Drawing.Color.Teal;
            this.btnCheckIPs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCheckIPs.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCheckIPs.Location = new System.Drawing.Point(3, 84);
            this.btnCheckIPs.Name = "btnCheckIPs";
            this.btnCheckIPs.Size = new System.Drawing.Size(451, 42);
            this.btnCheckIPs.TabIndex = 17;
            this.btnCheckIPs.Text = "ПРОВЕРИТЬ IP";
            this.btnCheckIPs.UseVisualStyleBackColor = false;
            // 
            // btnIpCheckStat
            // 
            this.btnIpCheckStat.BackColor = System.Drawing.Color.SkyBlue;
            this.btnIpCheckStat.Enabled = false;
            this.btnIpCheckStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnIpCheckStat.Location = new System.Drawing.Point(460, 18);
            this.btnIpCheckStat.Name = "btnIpCheckStat";
            this.btnIpCheckStat.Size = new System.Drawing.Size(278, 60);
            this.btnIpCheckStat.TabIndex = 19;
            this.btnIpCheckStat.Text = "СТАТИСТИКА ПРОВЕРКИ";
            this.btnIpCheckStat.UseVisualStyleBackColor = false;
            // 
            // btnClearIpForm
            // 
            this.btnClearIpForm.BackColor = System.Drawing.Color.Thistle;
            this.btnClearIpForm.Enabled = false;
            this.btnClearIpForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearIpForm.Location = new System.Drawing.Point(460, 84);
            this.btnClearIpForm.Name = "btnClearIpForm";
            this.btnClearIpForm.Size = new System.Drawing.Size(278, 42);
            this.btnClearIpForm.TabIndex = 20;
            this.btnClearIpForm.Text = "ОЧИСТИТЬ";
            this.btnClearIpForm.UseVisualStyleBackColor = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.boxIPAnswer);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(0, 293);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(744, 145);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Результат проверки";
            // 
            // boxIPAnswer
            // 
            this.boxIPAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxIPAnswer.Enabled = false;
            this.boxIPAnswer.Location = new System.Drawing.Point(3, 16);
            this.boxIPAnswer.Name = "boxIPAnswer";
            this.boxIPAnswer.Size = new System.Drawing.Size(738, 126);
            this.boxIPAnswer.TabIndex = 4;
            this.boxIPAnswer.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 450);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "ОП IP Tools ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox boxIPInput;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClearIpForm;
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
    }
}

