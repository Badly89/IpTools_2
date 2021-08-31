namespace OpTools
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IpBox));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTxtBoxRes = new RichTextBoxLinks.RichTextBoxEx();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.srvUtes = new System.Windows.Forms.RadioButton();
            this.srvSmorye = new System.Windows.Forms.RadioButton();
            this.srvKovcheg = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkBoxEveryHalfSecond = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnOpenCount = new System.Windows.Forms.Button();
            this.numUD = new System.Windows.Forms.NumericUpDown();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.notifyIcon2 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.richTxtBoxRes);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(643, 547);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            this.groupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter);
            // 
            // richTxtBoxRes
            // 
            this.richTxtBoxRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTxtBoxRes.Location = new System.Drawing.Point(3, 16);
            this.richTxtBoxRes.Name = "richTxtBoxRes";
            this.richTxtBoxRes.Size = new System.Drawing.Size(637, 528);
            this.richTxtBoxRes.TabIndex = 15;
            this.richTxtBoxRes.Text = "";
            this.richTxtBoxRes.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTxtBoxRes_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(219, 155);
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
            this.groupBox3.Size = new System.Drawing.Size(213, 136);
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
            this.srvUtes.Location = new System.Drawing.Point(9, 98);
            this.srvUtes.Name = "srvUtes";
            this.srvUtes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.srvUtes.Size = new System.Drawing.Size(73, 29);
            this.srvUtes.TabIndex = 3;
            this.srvUtes.Tag = "2";
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
            this.srvSmorye.Location = new System.Drawing.Point(9, 62);
            this.srvSmorye.Name = "srvSmorye";
            this.srvSmorye.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.srvSmorye.Size = new System.Drawing.Size(113, 29);
            this.srvSmorye.TabIndex = 2;
            this.srvSmorye.Tag = "1";
            this.srvSmorye.Text = "Smorye";
            this.srvSmorye.UseVisualStyleBackColor = true;
            this.srvSmorye.CheckedChanged += new System.EventHandler(this.srvSmorye_CheckedChanged);
            // 
            // srvKovcheg
            // 
            this.srvKovcheg.AutoSize = true;
            this.srvKovcheg.Checked = true;
            this.srvKovcheg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.srvKovcheg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.srvKovcheg.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.srvKovcheg.Location = new System.Drawing.Point(9, 27);
            this.srvKovcheg.Name = "srvKovcheg";
            this.srvKovcheg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.srvKovcheg.Size = new System.Drawing.Size(113, 29);
            this.srvKovcheg.TabIndex = 1;
            this.srvKovcheg.TabStop = true;
            this.srvKovcheg.Tag = "0";
            this.srvKovcheg.Text = "Kovcheg";
            this.srvKovcheg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.srvKovcheg.UseVisualStyleBackColor = true;
            this.srvKovcheg.CheckedChanged += new System.EventHandler(this.srvKovcheg_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightGray;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCancel.Enabled = false;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancel.Location = new System.Drawing.Point(3, 97);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(213, 60);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "ПРЕРВАТЬ";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chkBoxEveryHalfSecond
            // 
            this.chkBoxEveryHalfSecond.AutoSize = true;
            this.chkBoxEveryHalfSecond.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkBoxEveryHalfSecond.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkBoxEveryHalfSecond.Location = new System.Drawing.Point(3, 16);
            this.chkBoxEveryHalfSecond.Name = "chkBoxEveryHalfSecond";
            this.chkBoxEveryHalfSecond.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkBoxEveryHalfSecond.Size = new System.Drawing.Size(213, 17);
            this.chkBoxEveryHalfSecond.TabIndex = 24;
            this.chkBoxEveryHalfSecond.Text = "Открывать логи раз в пол-секунды";
            this.chkBoxEveryHalfSecond.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCancel);
            this.groupBox4.Controls.Add(this.btnOpenCount);
            this.groupBox4.Controls.Add(this.numUD);
            this.groupBox4.Controls.Add(this.chkBoxEveryHalfSecond);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 155);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(219, 392);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            // 
            // btnOpenCount
            // 
            this.btnOpenCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpenCount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpenCount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOpenCount.Location = new System.Drawing.Point(3, 53);
            this.btnOpenCount.Name = "btnOpenCount";
            this.btnOpenCount.Size = new System.Drawing.Size(213, 44);
            this.btnOpenCount.TabIndex = 30;
            this.btnOpenCount.Text = "Открывать логи";
            this.btnOpenCount.UseVisualStyleBackColor = true;
            this.btnOpenCount.Click += new System.EventHandler(this.Button1_Click);
            // 
            // numUD
            // 
            this.numUD.Dock = System.Windows.Forms.DockStyle.Top;
            this.numUD.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUD.Location = new System.Drawing.Point(3, 33);
            this.numUD.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numUD.Name = "numUD";
            this.numUD.Size = new System.Drawing.Size(213, 20);
            this.numUD.TabIndex = 31;
            this.numUD.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(866, 547);
            this.splitContainer1.SplitterDistance = 219;
            this.splitContainer1.TabIndex = 16;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // notifyIcon2
            // 
            this.notifyIcon2.Text = "notifyIcon1";
            this.notifyIcon2.Visible = true;
            // 
            // IpBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 547);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IpBox";
            this.Text = "Статистика проверки по айпи";
            this.Resize += new System.EventHandler(this.IpBox_Resize);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
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
        private System.Windows.Forms.CheckBox chkBoxEveryHalfSecond;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnOpenCount;
        private System.Windows.Forms.NumericUpDown numUD;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NotifyIcon notifyIcon2;
    }
}