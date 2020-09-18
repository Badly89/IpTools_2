namespace IpTools_2
{
    partial class IpBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.srvUtes = new System.Windows.Forms.RadioButton();
            this.srvSmorye = new System.Windows.Forms.RadioButton();
            this.srvKovcheg = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOpenIpPartly100 = new System.Windows.Forms.Button();
            this.btnOpenIpPartly150 = new System.Windows.Forms.Button();
            this.btnOpenIpPartly = new System.Windows.Forms.Button();
            this.chkBoxEveryHalfSecond = new System.Windows.Forms.CheckBox();
            this.btnOpenLogs = new System.Windows.Forms.Button();
            this.richTxtBoxRes = new RichTextBoxLinks.RichTextBoxEx();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.richTxtBoxRes);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 475);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnOpenIpPartly100);
            this.groupBox1.Controls.Add(this.btnOpenIpPartly150);
            this.groupBox1.Controls.Add(this.btnOpenIpPartly);
            this.groupBox1.Controls.Add(this.chkBoxEveryHalfSecond);
            this.groupBox1.Controls.Add(this.btnOpenLogs);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(3, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 182);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры открытия логов";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.srvUtes);
            this.groupBox3.Controls.Add(this.srvSmorye);
            this.groupBox3.Controls.Add(this.srvKovcheg);
            this.groupBox3.Location = new System.Drawing.Point(5, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(783, 52);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Сервер, на котором открывать логи";
            // 
            // srvUtes
            // 
            this.srvUtes.AutoSize = true;
            this.srvUtes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.srvUtes.Location = new System.Drawing.Point(379, 19);
            this.srvUtes.Name = "srvUtes";
            this.srvUtes.Size = new System.Drawing.Size(47, 17);
            this.srvUtes.TabIndex = 3;
            this.srvUtes.TabStop = true;
            this.srvUtes.Text = "Utes";
            this.srvUtes.UseVisualStyleBackColor = true;
            this.srvUtes.CheckedChanged += new System.EventHandler(this.srvUtes_CheckedChanged);
            // 
            // srvSmorye
            // 
            this.srvSmorye.AutoSize = true;
            this.srvSmorye.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.srvSmorye.Location = new System.Drawing.Point(201, 19);
            this.srvSmorye.Name = "srvSmorye";
            this.srvSmorye.Size = new System.Drawing.Size(60, 17);
            this.srvSmorye.TabIndex = 2;
            this.srvSmorye.TabStop = true;
            this.srvSmorye.Text = "Smorye";
            this.srvSmorye.UseVisualStyleBackColor = true;
            this.srvSmorye.CheckedChanged += new System.EventHandler(this.srvSmorye_CheckedChanged);
            // 
            // srvKovcheg
            // 
            this.srvKovcheg.AutoSize = true;
            this.srvKovcheg.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.srvKovcheg.Location = new System.Drawing.Point(15, 19);
            this.srvKovcheg.Name = "srvKovcheg";
            this.srvKovcheg.Size = new System.Drawing.Size(68, 17);
            this.srvKovcheg.TabIndex = 1;
            this.srvKovcheg.TabStop = true;
            this.srvKovcheg.Text = "Kovcheg";
            this.srvKovcheg.UseVisualStyleBackColor = true;
            this.srvKovcheg.CheckedChanged += new System.EventHandler(this.srvKovcheg_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancel.Location = new System.Drawing.Point(701, 100);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 60);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "ПРЕРВАТЬ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOpenIpPartly100
            // 
            this.btnOpenIpPartly100.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOpenIpPartly100.Location = new System.Drawing.Point(224, 129);
            this.btnOpenIpPartly100.Name = "btnOpenIpPartly100";
            this.btnOpenIpPartly100.Size = new System.Drawing.Size(217, 44);
            this.btnOpenIpPartly100.TabIndex = 25;
            this.btnOpenIpPartly100.Text = "Открывать логи по 100 штук";
            this.btnOpenIpPartly100.UseVisualStyleBackColor = true;
            this.btnOpenIpPartly100.Click += new System.EventHandler(this.btnOpenIpPartly100_Click);
            // 
            // btnOpenIpPartly150
            // 
            this.btnOpenIpPartly150.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOpenIpPartly150.Location = new System.Drawing.Point(447, 129);
            this.btnOpenIpPartly150.Name = "btnOpenIpPartly150";
            this.btnOpenIpPartly150.Size = new System.Drawing.Size(241, 44);
            this.btnOpenIpPartly150.TabIndex = 26;
            this.btnOpenIpPartly150.Text = "Открывать логи по 150 штук";
            this.btnOpenIpPartly150.UseVisualStyleBackColor = true;
            this.btnOpenIpPartly150.Click += new System.EventHandler(this.btnOpenIpPartly150_Click);
            // 
            // btnOpenIpPartly
            // 
            this.btnOpenIpPartly.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOpenIpPartly.Location = new System.Drawing.Point(1, 129);
            this.btnOpenIpPartly.Name = "btnOpenIpPartly";
            this.btnOpenIpPartly.Size = new System.Drawing.Size(217, 44);
            this.btnOpenIpPartly.TabIndex = 27;
            this.btnOpenIpPartly.Text = "Открывать логи по 50 штук";
            this.btnOpenIpPartly.UseVisualStyleBackColor = true;
            this.btnOpenIpPartly.Click += new System.EventHandler(this.btnOpenIpPartly_Click);
            // 
            // chkBoxEveryHalfSecond
            // 
            this.chkBoxEveryHalfSecond.AutoSize = true;
            this.chkBoxEveryHalfSecond.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkBoxEveryHalfSecond.Location = new System.Drawing.Point(5, 77);
            this.chkBoxEveryHalfSecond.Name = "chkBoxEveryHalfSecond";
            this.chkBoxEveryHalfSecond.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkBoxEveryHalfSecond.Size = new System.Drawing.Size(205, 17);
            this.chkBoxEveryHalfSecond.TabIndex = 24;
            this.chkBoxEveryHalfSecond.Text = "Открывать логи раз в пол-секунды";
            this.chkBoxEveryHalfSecond.UseVisualStyleBackColor = true;
            // 
            // btnOpenLogs
            // 
            this.btnOpenLogs.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOpenLogs.Location = new System.Drawing.Point(1, 100);
            this.btnOpenLogs.Name = "btnOpenLogs";
            this.btnOpenLogs.Size = new System.Drawing.Size(693, 23);
            this.btnOpenLogs.TabIndex = 23;
            this.btnOpenLogs.Text = "Открыть логи Арены для всех айпи (Внимание. Пауза между открытиями логов - 1 секу" +
    "нда.)";
            this.btnOpenLogs.UseVisualStyleBackColor = true;
            this.btnOpenLogs.Click += new System.EventHandler(this.btnOpenLogs_Click);
            // 
            // richTxtBoxRes
            // 
            this.richTxtBoxRes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTxtBoxRes.Location = new System.Drawing.Point(6, 19);
            this.richTxtBoxRes.Name = "richTxtBoxRes";
            this.richTxtBoxRes.Size = new System.Drawing.Size(782, 281);
            this.richTxtBoxRes.TabIndex = 15;
            this.richTxtBoxRes.Text = "";
            this.richTxtBoxRes.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTxtBoxRes_LinkClicked);
            // 
            // IpBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.groupBox2);
            this.Name = "IpBox";
            this.Text = "Статистика проверки по айпи";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private RichTextBoxLinks.RichTextBoxEx richTxtBoxRes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton srvUtes;
        private System.Windows.Forms.RadioButton srvSmorye;
        private System.Windows.Forms.RadioButton srvKovcheg;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOpenIpPartly100;
        private System.Windows.Forms.Button btnOpenIpPartly150;
        private System.Windows.Forms.Button btnOpenIpPartly;
        private System.Windows.Forms.CheckBox chkBoxEveryHalfSecond;
        private System.Windows.Forms.Button btnOpenLogs;
    }
}