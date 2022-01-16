
namespace WiiU_External_Gui_Example
{
    partial class Form1
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
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.textBoxIp = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.groupBoxBo2 = new System.Windows.Forms.GroupBox();
            this.checkBoxExample = new System.Windows.Forms.CheckBox();
            this.thirdPerson = new System.Windows.Forms.CheckBox();
            this.infraredPlayer = new System.Windows.Forms.CheckBox();
            this.groupBoxMinecraft = new System.Windows.Forms.GroupBox();
            this.creatorName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.proMod = new System.Windows.Forms.CheckBox();
            this.suppSloth = new System.Windows.Forms.CheckBox();
            this.checkBoxExample2 = new System.Windows.Forms.CheckBox();
            this.groupBoxBo2.SuspendLayout();
            this.groupBoxMinecraft.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(12, 12);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(199, 15);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(75, 23);
            this.buttonDisconnect.TabIndex = 1;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // textBoxIp
            // 
            this.textBoxIp.Location = new System.Drawing.Point(93, 15);
            this.textBoxIp.Name = "textBoxIp";
            this.textBoxIp.Size = new System.Drawing.Size(100, 20);
            this.textBoxIp.TabIndex = 2;
            this.textBoxIp.TextChanged += new System.EventHandler(this.textBoxIp_TextChanged);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.ForeColor = System.Drawing.Color.Red;
            this.labelStatus.Location = new System.Drawing.Point(280, 20);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(79, 13);
            this.labelStatus.TabIndex = 3;
            this.labelStatus.Text = "Not Connected";
            this.labelStatus.Click += new System.EventHandler(this.labelStatus_Click);
            // 
            // groupBoxBo2
            // 
            this.groupBoxBo2.Controls.Add(this.checkBoxExample);
            this.groupBoxBo2.Controls.Add(this.thirdPerson);
            this.groupBoxBo2.Controls.Add(this.infraredPlayer);
            this.groupBoxBo2.ForeColor = System.Drawing.Color.Maroon;
            this.groupBoxBo2.Location = new System.Drawing.Point(12, 66);
            this.groupBoxBo2.Name = "groupBoxBo2";
            this.groupBoxBo2.Size = new System.Drawing.Size(300, 54);
            this.groupBoxBo2.TabIndex = 4;
            this.groupBoxBo2.TabStop = false;
            this.groupBoxBo2.Text = "Call Of Duty Black Ops II";
            // 
            // checkBoxExample
            // 
            this.checkBoxExample.AutoSize = true;
            this.checkBoxExample.ForeColor = System.Drawing.Color.Black;
            this.checkBoxExample.Location = new System.Drawing.Point(204, 20);
            this.checkBoxExample.Name = "checkBoxExample";
            this.checkBoxExample.Size = new System.Drawing.Size(66, 17);
            this.checkBoxExample.TabIndex = 2;
            this.checkBoxExample.Text = "Example";
            this.checkBoxExample.UseVisualStyleBackColor = true;
            this.checkBoxExample.CheckedChanged += new System.EventHandler(this.checkBoxExample_CheckedChanged);
            // 
            // thirdPerson
            // 
            this.thirdPerson.AutoSize = true;
            this.thirdPerson.ForeColor = System.Drawing.Color.Black;
            this.thirdPerson.Location = new System.Drawing.Point(112, 20);
            this.thirdPerson.Name = "thirdPerson";
            this.thirdPerson.Size = new System.Drawing.Size(86, 17);
            this.thirdPerson.TabIndex = 1;
            this.thirdPerson.Text = "Third Person";
            this.thirdPerson.UseVisualStyleBackColor = true;
            this.thirdPerson.CheckedChanged += new System.EventHandler(this.thirdPerson_CheckedChanged);
            // 
            // infraredPlayer
            // 
            this.infraredPlayer.AutoSize = true;
            this.infraredPlayer.ForeColor = System.Drawing.Color.Black;
            this.infraredPlayer.Location = new System.Drawing.Point(7, 20);
            this.infraredPlayer.Name = "infraredPlayer";
            this.infraredPlayer.Size = new System.Drawing.Size(99, 17);
            this.infraredPlayer.TabIndex = 0;
            this.infraredPlayer.Text = "Infrared Players";
            this.infraredPlayer.UseVisualStyleBackColor = true;
            this.infraredPlayer.CheckedChanged += new System.EventHandler(this.infraredPlayer_CheckedChanged);
            // 
            // groupBoxMinecraft
            // 
            this.groupBoxMinecraft.Controls.Add(this.checkBoxExample2);
            this.groupBoxMinecraft.Controls.Add(this.suppSloth);
            this.groupBoxMinecraft.Controls.Add(this.proMod);
            this.groupBoxMinecraft.ForeColor = System.Drawing.Color.Green;
            this.groupBoxMinecraft.Location = new System.Drawing.Point(12, 126);
            this.groupBoxMinecraft.Name = "groupBoxMinecraft";
            this.groupBoxMinecraft.Size = new System.Drawing.Size(300, 53);
            this.groupBoxMinecraft.TabIndex = 5;
            this.groupBoxMinecraft.TabStop = false;
            this.groupBoxMinecraft.Text = "Minecraft";
            // 
            // creatorName
            // 
            this.creatorName.AutoSize = true;
            this.creatorName.Location = new System.Drawing.Point(9, 195);
            this.creatorName.Name = "creatorName";
            this.creatorName.Size = new System.Drawing.Size(108, 13);
            this.creatorName.TabIndex = 6;
            this.creatorName.Text = "\"Creator Name Here\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Thank";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Purple;
            this.linkLabel1.Location = new System.Drawing.Point(187, 195);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(83, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "DarkModZOFW";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Maroon;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "for the gui base";
            // 
            // proMod
            // 
            this.proMod.AutoSize = true;
            this.proMod.ForeColor = System.Drawing.Color.Black;
            this.proMod.Location = new System.Drawing.Point(7, 20);
            this.proMod.Name = "proMod";
            this.proMod.Size = new System.Drawing.Size(87, 17);
            this.proMod.TabIndex = 0;
            this.proMod.Text = "Fov Changer";
            this.proMod.UseVisualStyleBackColor = true;
            this.proMod.CheckedChanged += new System.EventHandler(this.proMod_CheckedChanged);
            // 
            // suppSloth
            // 
            this.suppSloth.AutoSize = true;
            this.suppSloth.ForeColor = System.Drawing.Color.Black;
            this.suppSloth.Location = new System.Drawing.Point(100, 20);
            this.suppSloth.Name = "suppSloth";
            this.suppSloth.Size = new System.Drawing.Size(94, 17);
            this.suppSloth.TabIndex = 1;
            this.suppSloth.Text = "Add 1 Slot Bar";
            this.suppSloth.UseVisualStyleBackColor = true;
            this.suppSloth.CheckedChanged += new System.EventHandler(this.suppSloth_CheckedChanged);
            // 
            // checkBoxExample2
            // 
            this.checkBoxExample2.AutoSize = true;
            this.checkBoxExample2.ForeColor = System.Drawing.Color.Black;
            this.checkBoxExample2.Location = new System.Drawing.Point(204, 19);
            this.checkBoxExample2.Name = "checkBoxExample2";
            this.checkBoxExample2.Size = new System.Drawing.Size(66, 17);
            this.checkBoxExample2.TabIndex = 3;
            this.checkBoxExample2.Text = "Example";
            this.checkBoxExample2.UseVisualStyleBackColor = true;
            this.checkBoxExample2.CheckedChanged += new System.EventHandler(this.checkBoxExample2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 224);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.creatorName);
            this.Controls.Add(this.groupBoxMinecraft);
            this.Controls.Add(this.groupBoxBo2);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.textBoxIp);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.buttonConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxBo2.ResumeLayout(false);
            this.groupBoxBo2.PerformLayout();
            this.groupBoxMinecraft.ResumeLayout(false);
            this.groupBoxMinecraft.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.TextBox textBoxIp;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.GroupBox groupBoxBo2;
        private System.Windows.Forms.GroupBox groupBoxMinecraft;
        private System.Windows.Forms.Label creatorName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox infraredPlayer;
        private System.Windows.Forms.CheckBox checkBoxExample;
        private System.Windows.Forms.CheckBox thirdPerson;
        private System.Windows.Forms.CheckBox proMod;
        private System.Windows.Forms.CheckBox suppSloth;
        private System.Windows.Forms.CheckBox checkBoxExample2;
    }
}

