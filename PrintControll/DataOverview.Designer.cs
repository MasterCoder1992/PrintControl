namespace PrintControll
{
    partial class DataOverview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataOverview));
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.userListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userList = new PrintControll.UserList();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standarddruckerAuswählenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datenImcsvFormatExportierenEXCELToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userList)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "drucken";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 149);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(780, 244);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // userListBindingSource
            // 
            this.userListBindingSource.DataSource = this.userList;
            this.userListBindingSource.Position = 0;
            // 
            // userList
            // 
            this.userList.DataSetName = "UserList";
            this.userList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.einstellungenToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // einstellungenToolStripMenuItem
            // 
            this.einstellungenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standarddruckerAuswählenToolStripMenuItem});
            this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            this.einstellungenToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.einstellungenToolStripMenuItem.Text = "Einstellungen";
            // 
            // standarddruckerAuswählenToolStripMenuItem
            // 
            this.standarddruckerAuswählenToolStripMenuItem.Name = "standarddruckerAuswählenToolStripMenuItem";
            this.standarddruckerAuswählenToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.standarddruckerAuswählenToolStripMenuItem.Text = "Standarddrucker auswählen";
            this.standarddruckerAuswählenToolStripMenuItem.Click += new System.EventHandler(this.standarddruckerAuswählenToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datenImcsvFormatExportierenEXCELToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // datenImcsvFormatExportierenEXCELToolStripMenuItem
            // 
            this.datenImcsvFormatExportierenEXCELToolStripMenuItem.Name = "datenImcsvFormatExportierenEXCELToolStripMenuItem";
            this.datenImcsvFormatExportierenEXCELToolStripMenuItem.Size = new System.Drawing.Size(360, 26);
            this.datenImcsvFormatExportierenEXCELToolStripMenuItem.Text = "Daten im .csv-Format exportieren (EXCEL)";
            this.datenImcsvFormatExportierenEXCELToolStripMenuItem.Click += new System.EventHandler(this.datenImcsvFormatExportierenEXCELToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(124, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "zurücksetzen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(492, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "nie";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "letzter Reset:";
            // 
            // DataOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 405);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "DataOverview";
            this.Text = "DataOverview";
            this.Load += new System.EventHandler(this.DataOverview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userList)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource userListBindingSource;
        private UserList userList;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem einstellungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standarddruckerAuswählenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datenImcsvFormatExportierenEXCELToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}