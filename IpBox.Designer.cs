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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.richTxtBoxRes);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Location = new System.Drawing.Point(233, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(633, 289);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 289);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(866, 84);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры открытия логов";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.srvUtes);
            this.groupBox3.Controls.Add(this.srvSmorye);
            this.groupBox3.Controls.Add(this.srvKovcheg);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox3.Size = new System.Drawing.Size(860, 65);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Сервер, на котором открывать логи";
            // 
            // srvUtes
            // 
            this.srvUtes.AutoSize = true;
            this.srvUtes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.srvUtes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.srvUtes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.srvUtes.Location = new System.Drawing.Point(247, 27);
            this.srvUtes.Name = "srvUtes";
            this.srvUtes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.srvUtes.Size = new System.Drawing.Size(73, 29);
            this.srvUtes.TabIndex = 3;
            this.srvUtes.TabStop = true;
            this.srvUtes.Text = "Utes";
            this.srvUtes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.srvUtes.UseVisualStyleBackColor = true;
            this.srvUtes.CheckedChanged += new System.EventHandler(this.srvUtes_CheckedChanged);
            // 
            // srvSmorye
            // 
            this.srvSmorye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.srvSmorye.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.srvSmorye.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.srvSmorye.Location = new System.Drawing.Point(128, 27);
            this.srvSmorye.Name = "srvSmorye";
            this.srvSmorye.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.srvSmorye.Size = new System.Drawing.Size(113, 29);
            this.srvSmorye.TabIndex = 2;
            this.srvSmorye.TabStop = true;
            this.srvSmorye.Text = "Smorye";
            this.srvSmorye.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.srvSmorye.UseVisualStyleBackColor = true;
            this.srvSmorye.CheckedChanged += new System.EventHandler(this.srvSmorye_CheckedChanged);
            // 
            // srvKovcheg
            // 
            this.srvKovcheg.AutoSize = true;
            this.srvKovcheg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.srvKovcheg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.srvKovcheg.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.srvKovcheg.Location = new System.Drawing.Point(9, 27);
            this.srvKovcheg.Name = "srvKovcheg";
            this.srvKovcheg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.srvKovcheg.Size = new System.Drawing.Size(113, 29);
            this.srvKovcheg.TabIndex = 1;
            this.srvKovcheg.TabStop = true;
            this.srvKovcheg.Text = "Kovcheg";
            this.srvKovcheg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.srvKovcheg.UseVisualStyleBackColor = true;
            this.srvKovcheg.CheckedChanged += new System.EventHandler(this.srvKovcheg_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCancel.Enabled = false;
            this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancel.Location = new System.Drawing.Point(3, 206);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(227, 60);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "ПРЕРВАТЬ";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOpenIpPartly100
            // 
            this.btnOpenIpPartly100.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpenIpPartly100.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOpenIpPartly100.Location = new System.Drawing.Point(3, 130);
            this.btnOpenIpPartly100.Name = "btnOpenIpPartly100";
            this.btnOpenIpPartly100.Size = new System.Drawing.Size(227, 38);
            this.btnOpenIpPartly100.TabIndex = 25;
            this.btnOpenIpPartly100.Text = "Открывать логи по 100 штук";
            this.btnOpenIpPartly100.UseVisualStyleBackColor = true;
            this.btnOpenIpPartly100.Click += new System.EventHandler(this.btnOpenIpPartly100_Click);
            // 
            // btnOpenIpPartly150
            // 
            this.btnOpenIpPartly150.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpenIpPartly150.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOpenIpPartly150.Location = new System.Drawing.Point(3, 168);
            this.btnOpenIpPartly150.Name = "btnOpenIpPartly150";
            this.btnOpenIpPartly150.Size = new System.Drawing.Size(227, 38);
            this.btnOpenIpPartly150.TabIndex = 26;
            this.btnOpenIpPartly150.Text = "Открывать логи по 150 штук";
            this.btnOpenIpPartly150.UseVisualStyleBackColor = true;
            this.btnOpenIpPartly150.Click += new System.EventHandler(this.btnOpenIpPartly150_Click);
            // 
            // btnOpenIpPartly
            // 
            this.btnOpenIpPartly.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpenIpPartly.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOpenIpPartly.Location = new System.Drawing.Point(3, 86);
            this.btnOpenIpPartly.Name = "btnOpenIpPartly";
            this.btnOpenIpPartly.Size = new System.Drawing.Size(227, 44);
            this.btnOpenIpPartly.TabIndex = 27;
            this.btnOpenIpPartly.Text = "Открывать логи по 50 штук";
            this.btnOpenIpPartly.UseVisualStyleBackColor = true;
            this.btnOpenIpPartly.Click += new System.EventHandler(this.btnOpenIpPartly_Click);
            // 
            // chkBoxEveryHalfSecond
            // 
            this.chkBoxEveryHalfSecond.AutoSize = true;
            this.chkBoxEveryHalfSecond.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkBoxEveryHalfSecond.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkBoxEveryHalfSecond.Location = new System.Drawing.Point(3, 16);
            this.chkBoxEveryHalfSecond.Name = "chkBoxEveryHalfSecond";
            this.chkBoxEveryHalfSecond.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkBoxEveryHalfSecond.Size = new System.Drawing.Size(227, 17);
            this.chkBoxEveryHalfSecond.TabIndex = 24;
            this.chkBoxEveryHalfSecond.Text = "Открывать логи раз в пол-секунды";
            this.chkBoxEveryHalfSecond.UseVisualStyleBackColor = true;
            // 
            // btnOpenLogs
            // 
            this.btnOpenLogs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpenLogs.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOpenLogs.Location = new System.Drawing.Point(3, 33);
            this.btnOpenLogs.Name = "btnOpenLogs";
            this.btnOpenLogs.Size = new System.Drawing.Size(227, 53);
            this.btnOpenLogs.TabIndex = 23;
            this.btnOpenLogs.Text = "Открыть логи Арены для всех айпи (Внимание. Пауза между открытиями логов - 1 секу" +
    "нда.)";
            this.btnOpenLogs.UseVisualStyleBackColor = true;
            this.btnOpenLogs.Click += new System.EventHandler(this.btnOpenLogs_Click);
            // 
            // richTxtBoxRes
            // 
            this.richTxtBoxRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTxtBoxRes.Location = new System.Drawing.Point(3, 16);
            this.richTxtBoxRes.Name = "richTxtBoxRes";
            this.richTxtBoxRes.Size = new System.Drawing.Size(627, 270);
            this.richTxtBoxRes.TabIndex = 15;
            this.richTxtBoxRes.Text = "";
            this.richTxtBoxRes.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTxtBoxRes_LinkClicked);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCancel);
            this.groupBox4.Controls.Add(this.btnOpenIpPartly150);
            this.groupBox4.Controls.Add(this.btnOpenIpPartly100);
            this.groupBox4.Controls.Add(this.btnOpenIpPartly);
            this.groupBox4.Controls.Add(this.btnOpenLogs);
            this.groupBox4.Controls.Add(this.chkBoxEveryHalfSecond);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(233, 289);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            // 
            // IpBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 373);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "IpBox";
            this.Text = "Статистика проверки по айпи";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.GroupBox groupBox4;
    }
}