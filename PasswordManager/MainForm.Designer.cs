namespace PasswordManager
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip = new MenuStrip();
            fichierToolStripMenuItem = new ToolStripMenuItem();
            MenuNewDatabase = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            lockToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            entréeToolStripMenuItem = new ToolStripMenuItem();
            addEntryToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            copyPasswordToolStripMenuItem = new ToolStripMenuItem();
            DtgEntries = new DataGridView();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DtgEntries).BeginInit();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { fichierToolStripMenuItem, entréeToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            fichierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MenuNewDatabase, openToolStripMenuItem, closeToolStripMenuItem, saveToolStripMenuItem, lockToolStripMenuItem, exitToolStripMenuItem });
            fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            fichierToolStripMenuItem.Size = new Size(54, 20);
            fichierToolStripMenuItem.Text = "Fichier";
            // 
            // MenuNewDatabase
            // 
            MenuNewDatabase.Name = "MenuNewDatabase";
            MenuNewDatabase.ShortcutKeys = Keys.Control | Keys.N;
            MenuNewDatabase.Size = new Size(180, 22);
            MenuNewDatabase.Text = "New";
            MenuNewDatabase.Click += NewDatabase;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(180, 22);
            openToolStripMenuItem.Text = "Open";
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.W;
            closeToolStripMenuItem.Size = new Size(180, 22);
            closeToolStripMenuItem.Text = "Close";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(180, 22);
            saveToolStripMenuItem.Text = "Save";
            // 
            // lockToolStripMenuItem
            // 
            lockToolStripMenuItem.Name = "lockToolStripMenuItem";
            lockToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.L;
            lockToolStripMenuItem.Size = new Size(180, 22);
            lockToolStripMenuItem.Text = "Lock";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.U;
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // entréeToolStripMenuItem
            // 
            entréeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addEntryToolStripMenuItem, copyToolStripMenuItem, copyPasswordToolStripMenuItem });
            entréeToolStripMenuItem.Name = "entréeToolStripMenuItem";
            entréeToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.I;
            entréeToolStripMenuItem.Size = new Size(52, 20);
            entréeToolStripMenuItem.Text = "Entrée";
            // 
            // addEntryToolStripMenuItem
            // 
            addEntryToolStripMenuItem.Name = "addEntryToolStripMenuItem";
            addEntryToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.I;
            addEntryToolStripMenuItem.Size = new Size(197, 22);
            addEntryToolStripMenuItem.Text = "Add Entry";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.B;
            copyToolStripMenuItem.Size = new Size(197, 22);
            copyToolStripMenuItem.Text = "Copy User";
            // 
            // copyPasswordToolStripMenuItem
            // 
            copyPasswordToolStripMenuItem.Name = "copyPasswordToolStripMenuItem";
            copyPasswordToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            copyPasswordToolStripMenuItem.Size = new Size(197, 22);
            copyPasswordToolStripMenuItem.Text = "Copy Password";
            // 
            // DtgEntries
            // 
            DtgEntries.BackgroundColor = Color.White;
            DtgEntries.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtgEntries.Dock = DockStyle.Fill;
            DtgEntries.Location = new Point(0, 24);
            DtgEntries.Name = "DtgEntries";
            DtgEntries.Size = new Size(800, 426);
            DtgEntries.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(DtgEntries);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PasswordManager";
            Load += MainForm_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DtgEntries).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem fichierToolStripMenuItem;
        private ToolStripMenuItem entréeToolStripMenuItem;
        private ToolStripMenuItem MenuNewDatabase;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem lockToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem addEntryToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem copyPasswordToolStripMenuItem;
        private DataGridView DtgEntries;
    }
}
