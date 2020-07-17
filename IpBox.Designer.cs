using RichTextBoxLinks;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IpBox));
            this.lblUnique = new System.Windows.Forms.Label();
            this.btnOpenLogs = new System.Windows.Forms.Button();
            this.chkBoxEveryHalfSecond = new System.Windows.Forms.CheckBox();
            this.btnOpenIpPartly = new System.Windows.Forms.Button();
            this.richTxtBoxRes = new RichTextBoxLinks.RichTextBoxEx();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.srvForest = new System.Windows.Forms.RadioButton();
            this.srvUtes = new System.Windows.Forms.RadioButton();
            this.srvSmorye = new System.Windows.Forms.RadioButton();
            this.srvKovcheg = new System.Windows.Forms.RadioButton();
            this.srcOstrov = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUnique
            // 
            resources.ApplyResources(this.lblUnique, "lblUnique");
            this.lblUnique.Name = "lblUnique";
            // 
            // btnOpenLogs
            // 
            resources.ApplyResources(this.btnOpenLogs, "btnOpenLogs");
            this.btnOpenLogs.Name = "btnOpenLogs";
            this.btnOpenLogs.UseVisualStyleBackColor = true;
            this.btnOpenLogs.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkBoxEveryHalfSecond
            // 
            resources.ApplyResources(this.chkBoxEveryHalfSecond, "chkBoxEveryHalfSecond");
            this.chkBoxEveryHalfSecond.Name = "chkBoxEveryHalfSecond";
            this.chkBoxEveryHalfSecond.UseVisualStyleBackColor = true;
            // 
            // btnOpenIpPartly
            // 
            resources.ApplyResources(this.btnOpenIpPartly, "btnOpenIpPartly");
            this.btnOpenIpPartly.Name = "btnOpenIpPartly";
            this.btnOpenIpPartly.UseVisualStyleBackColor = true;
            this.btnOpenIpPartly.Click += new System.EventHandler(this.btnOpenIpPartly_Click);
            // 
            // richTxtBoxRes
            // 
            resources.ApplyResources(this.richTxtBoxRes, "richTxtBoxRes");
            this.richTxtBoxRes.Name = "richTxtBoxRes";
            this.richTxtBoxRes.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTxtBoxRes_LinkClicked);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.srvForest);
            this.groupBox1.Controls.Add(this.srvUtes);
            this.groupBox1.Controls.Add(this.srvSmorye);
            this.groupBox1.Controls.Add(this.srvKovcheg);
            this.groupBox1.Controls.Add(this.srcOstrov);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // srvForest
            // 
            resources.ApplyResources(this.srvForest, "srvForest");
            this.srvForest.Name = "srvForest";
            this.srvForest.TabStop = true;
            this.srvForest.UseVisualStyleBackColor = true;
            this.srvForest.CheckedChanged += new System.EventHandler(this.srvForest_CheckedChanged);
            // 
            // srvUtes
            // 
            resources.ApplyResources(this.srvUtes, "srvUtes");
            this.srvUtes.Name = "srvUtes";
            this.srvUtes.TabStop = true;
            this.srvUtes.UseVisualStyleBackColor = true;
            this.srvUtes.CheckedChanged += new System.EventHandler(this.srvUtes_CheckedChanged);
            // 
            // srvSmorye
            // 
            resources.ApplyResources(this.srvSmorye, "srvSmorye");
            this.srvSmorye.Name = "srvSmorye";
            this.srvSmorye.TabStop = true;
            this.srvSmorye.UseVisualStyleBackColor = true;
            this.srvSmorye.CheckedChanged += new System.EventHandler(this.srvSmorye_CheckedChanged);
            // 
            // srvKovcheg
            // 
            resources.ApplyResources(this.srvKovcheg, "srvKovcheg");
            this.srvKovcheg.Name = "srvKovcheg";
            this.srvKovcheg.TabStop = true;
            this.srvKovcheg.UseVisualStyleBackColor = true;
            this.srvKovcheg.CheckedChanged += new System.EventHandler(this.srvKovcheg_CheckedChanged);
            // 
            // srcOstrov
            // 
            resources.ApplyResources(this.srcOstrov, "srcOstrov");
            this.srcOstrov.Checked = true;
            this.srcOstrov.Name = "srcOstrov";
            this.srcOstrov.TabStop = true;
            this.srcOstrov.UseVisualStyleBackColor = true;
            this.srcOstrov.CheckedChanged += new System.EventHandler(this.srcOstrov_CheckedChanged);
            // 
            // IpBox
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOpenIpPartly);
            this.Controls.Add(this.chkBoxEveryHalfSecond);
            this.Controls.Add(this.btnOpenLogs);
            this.Controls.Add(this.richTxtBoxRes);
            this.Controls.Add(this.lblUnique);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "IpBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IpBox_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUnique;
        private RichTextBoxLinks.RichTextBoxEx richTxtBoxRes;
        private System.Windows.Forms.Button btnOpenLogs;
        private System.Windows.Forms.CheckBox chkBoxEveryHalfSecond;
        private System.Windows.Forms.Button btnOpenIpPartly;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton srvForest;
        private System.Windows.Forms.RadioButton srvUtes;
        private System.Windows.Forms.RadioButton srvSmorye;
        private System.Windows.Forms.RadioButton srvKovcheg;
        private System.Windows.Forms.RadioButton srcOstrov;
    }
}