namespace dev_toolbox
{
    partial class Toolbox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Toolbox));
            this.Button13 = new System.Windows.Forms.Button();
            this.consoleBox = new System.Windows.Forms.RichTextBox();
            this.Button12 = new System.Windows.Forms.Button();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.TabControl2 = new System.Windows.Forms.TabControl();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.Button8 = new System.Windows.Forms.Button();
            this.Button9 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button11 = new System.Windows.Forms.Button();
            this.Button10 = new System.Windows.Forms.Button();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.TabPage2.SuspendLayout();
            this.TabControl2.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button13
            // 
            this.Button13.Location = new System.Drawing.Point(82, 84);
            this.Button13.Name = "Button13";
            this.Button13.Size = new System.Drawing.Size(70, 70);
            this.Button13.TabIndex = 13;
            this.Button13.Text = "Server Status";
            this.Button13.UseVisualStyleBackColor = true;
            this.Button13.Click += new System.EventHandler(this.serverStatus);
            // 
            // consoleBox
            // 
            this.consoleBox.BackColor = System.Drawing.Color.Black;
            this.consoleBox.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consoleBox.ForeColor = System.Drawing.Color.LightGray;
            this.consoleBox.Location = new System.Drawing.Point(3, 194);
            this.consoleBox.Name = "consoleBox";
            this.consoleBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.consoleBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.consoleBox.Size = new System.Drawing.Size(579, 178);
            this.consoleBox.TabIndex = 19;
            this.consoleBox.Text = "";
            this.consoleBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.consoleBox_KeyDown);
            this.consoleBox.MouseHover += new System.EventHandler(this.consoleHover);
            // 
            // Button12
            // 
            this.Button12.Location = new System.Drawing.Point(8, 8);
            this.Button12.Name = "Button12";
            this.Button12.Size = new System.Drawing.Size(70, 70);
            this.Button12.TabIndex = 2;
            this.Button12.Text = "Restart Todo-App Backend";
            this.Button12.UseVisualStyleBackColor = true;
            this.Button12.Click += new System.EventHandler(this.restartTodo);
            // 
            // TabPage2
            // 
            this.TabPage2.BackColor = System.Drawing.Color.Transparent;
            this.TabPage2.Controls.Add(this.Button12);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(315, 163);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Todo-App";
            // 
            // TabControl2
            // 
            this.TabControl2.Controls.Add(this.TabPage3);
            this.TabControl2.Location = new System.Drawing.Point(333, 2);
            this.TabControl2.Name = "TabControl2";
            this.TabControl2.SelectedIndex = 0;
            this.TabControl2.Size = new System.Drawing.Size(249, 189);
            this.TabControl2.TabIndex = 20;
            // 
            // TabPage3
            // 
            this.TabPage3.BackColor = System.Drawing.Color.Transparent;
            this.TabPage3.Controls.Add(this.Button13);
            this.TabPage3.Controls.Add(this.Button8);
            this.TabPage3.Controls.Add(this.Button9);
            this.TabPage3.Controls.Add(this.Button6);
            this.TabPage3.Controls.Add(this.Button7);
            this.TabPage3.Location = new System.Drawing.Point(4, 22);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage3.Size = new System.Drawing.Size(241, 163);
            this.TabPage3.TabIndex = 0;
            this.TabPage3.Text = "Utilities";
            // 
            // Button8
            // 
            this.Button8.Location = new System.Drawing.Point(6, 8);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(70, 70);
            this.Button8.TabIndex = 7;
            this.Button8.Text = "Launch GitHub app";
            this.Button8.UseVisualStyleBackColor = true;
            this.Button8.Click += new System.EventHandler(this.gitApp);
            // 
            // Button9
            // 
            this.Button9.Location = new System.Drawing.Point(6, 84);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(70, 70);
            this.Button9.TabIndex = 12;
            this.Button9.Text = "Launch\r\nDB Admin";
            this.Button9.UseVisualStyleBackColor = true;
            this.Button9.Click += new System.EventHandler(this.dbAdmin);
            // 
            // Button6
            // 
            this.Button6.Location = new System.Drawing.Point(158, 8);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(70, 70);
            this.Button6.TabIndex = 5;
            this.Button6.Text = "Launch Parse";
            this.Button6.UseVisualStyleBackColor = true;
            this.Button6.Click += new System.EventHandler(this.launchParse);
            // 
            // Button7
            // 
            this.Button7.Location = new System.Drawing.Point(82, 8);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(70, 70);
            this.Button7.TabIndex = 6;
            this.Button7.Text = "Launch\r\nGitHub Shell";
            this.Button7.UseVisualStyleBackColor = true;
            this.Button7.Click += new System.EventHandler(this.gitShell);
            // 
            // Button5
            // 
            this.Button5.Location = new System.Drawing.Point(236, 8);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(70, 70);
            this.Button5.TabIndex = 4;
            this.Button5.Text = "Update Release JSON";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.updateReleaseJSON);
            // 
            // Button11
            // 
            this.Button11.Location = new System.Drawing.Point(236, 84);
            this.Button11.Name = "Button11";
            this.Button11.Size = new System.Drawing.Size(70, 70);
            this.Button11.TabIndex = 14;
            this.Button11.Text = "Sync Git to Web";
            this.Button11.UseVisualStyleBackColor = true;
            this.Button11.Click += new System.EventHandler(this.repoPullWeb);
            // 
            // Button10
            // 
            this.Button10.Location = new System.Drawing.Point(160, 84);
            this.Button10.Name = "Button10";
            this.Button10.Size = new System.Drawing.Size(70, 70);
            this.Button10.TabIndex = 13;
            this.Button10.Text = "Sync Git to Android";
            this.Button10.UseVisualStyleBackColor = true;
            this.Button10.Click += new System.EventHandler(this.repoPullAndroid);
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.tabPage4);
            this.TabControl1.Location = new System.Drawing.Point(3, 2);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(323, 189);
            this.TabControl1.TabIndex = 18;
            // 
            // TabPage1
            // 
            this.TabPage1.BackColor = System.Drawing.Color.Transparent;
            this.TabPage1.Controls.Add(this.Button5);
            this.TabPage1.Controls.Add(this.Button11);
            this.TabPage1.Controls.Add(this.Button10);
            this.TabPage1.Controls.Add(this.Button1);
            this.TabPage1.Controls.Add(this.Button2);
            this.TabPage1.Controls.Add(this.Button3);
            this.TabPage1.Controls.Add(this.Button4);
            this.TabPage1.Controls.Add(this.PictureBox2);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(315, 163);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "zajrikSRV mobile";
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(8, 84);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(70, 70);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "Sync Project to Git";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.projectToGit);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(8, 8);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(70, 70);
            this.Button2.TabIndex = 1;
            this.Button2.Text = "Sync Android to Git";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.androidToGit);
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(84, 8);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(70, 70);
            this.Button3.TabIndex = 2;
            this.Button3.Text = "Sync Web to Git";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.webToGit);
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(160, 8);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(70, 70);
            this.Button4.TabIndex = 3;
            this.Button4.Text = "Sync Releases to Server";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.syncAppRelease);
            // 
            // PictureBox2
            // 
            this.PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBox2.BackgroundImage")));
            this.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PictureBox2.Location = new System.Drawing.Point(143, 79);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(168, 82);
            this.PictureBox2.TabIndex = 14;
            this.PictureBox2.TabStop = false;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Transparent;
            this.tabPage4.Controls.Add(this.button17);
            this.tabPage4.Controls.Add(this.button16);
            this.tabPage4.Controls.Add(this.button15);
            this.tabPage4.Controls.Add(this.button14);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(315, 163);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "Rift Timer";
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(236, 8);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(70, 70);
            this.button17.TabIndex = 6;
            this.button17.Text = "Create Metro Release Rar";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.metroPackageRelease);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(160, 8);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(70, 70);
            this.button16.TabIndex = 5;
            this.button16.Text = "Update Latest Metro Version";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.updateMetroVersion);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(84, 8);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(70, 70);
            this.button15.TabIndex = 4;
            this.button15.Text = "Create Release Rar";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.packageRelease);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(8, 8);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(70, 70);
            this.button14.TabIndex = 3;
            this.button14.Text = "Update Latest Version";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.updateVersion);
            // 
            // Toolbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 374);
            this.Controls.Add(this.consoleBox);
            this.Controls.Add(this.TabControl2);
            this.Controls.Add(this.TabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Toolbox";
            this.Text = "zajrikDEV Toolbox";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Toolbox_FormClosed);
            this.Load += new System.EventHandler(this.Toolbox_Load);
            this.TabPage2.ResumeLayout(false);
            this.TabControl2.ResumeLayout(false);
            this.TabPage3.ResumeLayout(false);
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button Button13;
        internal System.Windows.Forms.RichTextBox consoleBox;
        internal System.Windows.Forms.Button Button12;
        internal System.Windows.Forms.TabPage TabPage2;
        internal System.Windows.Forms.TabControl TabControl2;
        internal System.Windows.Forms.TabPage TabPage3;
        internal System.Windows.Forms.Button Button8;
        internal System.Windows.Forms.Button Button9;
        internal System.Windows.Forms.Button Button6;
        internal System.Windows.Forms.Button Button7;
        internal System.Windows.Forms.Button Button5;
        internal System.Windows.Forms.Button Button11;
        internal System.Windows.Forms.Button Button10;
        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Button Button4;
        internal System.Windows.Forms.PictureBox PictureBox2;
        private System.Windows.Forms.TabPage tabPage4;
        internal System.Windows.Forms.Button button14;
        internal System.Windows.Forms.Button button15;
        internal System.Windows.Forms.Button button17;
        internal System.Windows.Forms.Button button16;


    }
}

