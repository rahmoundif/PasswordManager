namespace PasswordManager
{
    partial class NewDatabaseForm
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
            btnAccept = new Button();
            btnCancel = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tbxRepeatMasterPassword = new TextBox();
            tbxMasterPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(204, 102);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(75, 23);
            btnAccept.TabIndex = 0;
            btnAccept.Text = "Ok";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += button1_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(285, 102);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += button2_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tbxRepeatMasterPassword, 1, 1);
            tableLayoutPanel1.Controls.Add(tbxMasterPassword, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(348, 84);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // tbxRepeatMasterPassword
            // 
            tbxRepeatMasterPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbxRepeatMasterPassword.Location = new Point(177, 51);
            tbxRepeatMasterPassword.Name = "tbxRepeatMasterPassword";
            tbxRepeatMasterPassword.Size = new Size(168, 23);
            tbxRepeatMasterPassword.TabIndex = 1;
            tbxRepeatMasterPassword.UseSystemPasswordChar = true;
            tbxRepeatMasterPassword.TextChanged += textBox2_TextChanged;
            // 
            // tbxMasterPassword
            // 
            tbxMasterPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbxMasterPassword.Location = new Point(177, 9);
            tbxMasterPassword.Name = "tbxMasterPassword";
            tbxMasterPassword.Size = new Size(168, 23);
            tbxMasterPassword.TabIndex = 0;
            tbxMasterPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(3, 13);
            label1.Name = "label1";
            label1.Size = new Size(168, 15);
            label1.TabIndex = 2;
            label1.Text = "Master Password :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 55);
            label2.Name = "label2";
            label2.Size = new Size(168, 15);
            label2.TabIndex = 3;
            label2.Text = "Recheck master password :";
            label2.Click += label2_Click;
            // 
            // NewDatabaseForm
            // 
            AcceptButton = btnAccept;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(372, 137);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btnCancel);
            Controls.Add(btnAccept);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NewDatabaseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Master Pasword";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAccept;
        private Button btnCancel;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox tbxRepeatMasterPassword;
        private TextBox tbxMasterPassword;
        private Label label1;
        private Label label2;
    }
}