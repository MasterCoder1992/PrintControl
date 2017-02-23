namespace PrintControll
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.btnDeactivate = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnActivePrinter = new System.Windows.Forms.Button();
            this.lbCurrentUser = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.höhereRechteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbPrintServiceRunningState = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cancelActionBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeactivate
            // 
            this.btnDeactivate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDeactivate.Location = new System.Drawing.Point(59, 105);
            this.btnDeactivate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeactivate.Name = "btnDeactivate";
            this.btnDeactivate.Size = new System.Drawing.Size(211, 23);
            this.btnDeactivate.TabIndex = 0;
            this.btnDeactivate.Text = "deaktivieren";
            this.btnDeactivate.UseVisualStyleBackColor = true;
            this.btnDeactivate.Click += new System.EventHandler(this.btnDeactivate_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(5, 31);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 57);
            this.button3.TabIndex = 2;
            this.button3.Text = "Übersicht anzeigen";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(11, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Druckauftrag aufgezeichnet";
            this.label1.Visible = false;
            // 
            // btnActivePrinter
            // 
            this.btnActivePrinter.Location = new System.Drawing.Point(40, 33);
            this.btnActivePrinter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActivePrinter.Name = "btnActivePrinter";
            this.btnActivePrinter.Size = new System.Drawing.Size(257, 41);
            this.btnActivePrinter.TabIndex = 5;
            this.btnActivePrinter.Text = "Drucker freischalten";
            this.btnActivePrinter.UseVisualStyleBackColor = true;
            this.btnActivePrinter.Click += new System.EventHandler(this.btnActivePrinter_Click);
            // 
            // lbCurrentUser
            // 
            this.lbCurrentUser.AutoSize = true;
            this.lbCurrentUser.Location = new System.Drawing.Point(11, 31);
            this.lbCurrentUser.Name = "lbCurrentUser";
            this.lbCurrentUser.Size = new System.Drawing.Size(46, 17);
            this.lbCurrentUser.TabIndex = 6;
            this.lbCurrentUser.Text = "label2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(12, 165);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(127, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adminpanel";
            this.groupBox1.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(380, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.höhereRechteToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // höhereRechteToolStripMenuItem
            // 
            this.höhereRechteToolStripMenuItem.Name = "höhereRechteToolStripMenuItem";
            this.höhereRechteToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.höhereRechteToolStripMenuItem.Text = "I want more!";
            this.höhereRechteToolStripMenuItem.Click += new System.EventHandler(this.höhereRechteToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbPrintServiceRunningState);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lbCurrentUser);
            this.groupBox2.Location = new System.Drawing.Point(155, 165);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(213, 132);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Info";
            // 
            // lbPrintServiceRunningState
            // 
            this.lbPrintServiceRunningState.AutoSize = true;
            this.lbPrintServiceRunningState.Location = new System.Drawing.Point(13, 70);
            this.lbPrintServiceRunningState.Name = "lbPrintServiceRunningState";
            this.lbPrintServiceRunningState.Size = new System.Drawing.Size(181, 17);
            this.lbPrintServiceRunningState.TabIndex = 7;
            this.lbPrintServiceRunningState.Text = "Drucker nicht freigeschaltet";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnActivePrinter);
            this.groupBox3.Controls.Add(this.btnDeactivate);
            this.groupBox3.Location = new System.Drawing.Point(12, 27);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(337, 133);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Aktionen:";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // cancelActionBtn
            // 
            this.cancelActionBtn.Location = new System.Drawing.Point(63, 307);
            this.cancelActionBtn.Name = "cancelActionBtn";
            this.cancelActionBtn.Size = new System.Drawing.Size(122, 23);
            this.cancelActionBtn.TabIndex = 11;
            this.cancelActionBtn.Text = "cancelAction";
            this.cancelActionBtn.UseVisualStyleBackColor = true;
            this.cancelActionBtn.Click += new System.EventHandler(this.cancelActionBtn_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnDeactivate;
            this.ClientSize = new System.Drawing.Size(380, 351);
            this.Controls.Add(this.cancelActionBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_Closing);
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeactivate;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnActivePrinter;
        private System.Windows.Forms.Label lbCurrentUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem höhereRechteToolStripMenuItem;
        private System.Windows.Forms.Label lbPrintServiceRunningState;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button cancelActionBtn;
    }
}