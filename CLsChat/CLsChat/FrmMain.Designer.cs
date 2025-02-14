namespace CLsChat
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabNewMessage = new System.Windows.Forms.TabPage();
            this.chkSelectAll = new System.Windows.Forms.CheckBox();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.tabInbox = new System.Windows.Forms.TabPage();
            this.btnRefreshInbox = new System.Windows.Forms.Button();
            this.dataGridViewInbox = new System.Windows.Forms.DataGridView();
            this.tabSentItems = new System.Windows.Forms.TabPage();
            this.btnRefreshSentItems = new System.Windows.Forms.Button();
            this.dataGridViewSentItems = new System.Windows.Forms.DataGridView();
            this.tabControlMain.SuspendLayout();
            this.tabNewMessage.SuspendLayout();
            this.tabInbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInbox)).BeginInit();
            this.tabSentItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSentItems)).BeginInit();
            this.SuspendLayout();
            
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabNewMessage);
            this.tabControlMain.Controls.Add(this.tabInbox);
            this.tabControlMain.Controls.Add(this.tabSentItems);
            this.tabControlMain.Location = new System.Drawing.Point(20, 30);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1020, 450);
            this.tabControlMain.TabIndex = 0;

            // 
            // tabNewMessage
            // 
            this.tabNewMessage.Controls.Add(this.listBoxUsers);
            this.tabNewMessage.Controls.Add(this.chkSelectAll);
            this.tabNewMessage.Controls.Add(this.btnSendMessage);
            this.tabNewMessage.Controls.Add(this.lblMessage);
            this.tabNewMessage.Controls.Add(this.lblSubject);
            this.tabNewMessage.Controls.Add(this.txtMessage);
            this.tabNewMessage.Controls.Add(this.txtSubject);
            this.tabNewMessage.Location = new System.Drawing.Point(4, 22);
            this.tabNewMessage.Name = "tabNewMessage";
            this.tabNewMessage.Padding = new System.Windows.Forms.Padding(3);
            this.tabNewMessage.Size = new System.Drawing.Size(1012, 424);
            this.tabNewMessage.TabIndex = 0;
            this.tabNewMessage.Text = "New Message";
            this.tabNewMessage.UseVisualStyleBackColor = true;

            // 
            // chkSelectAll
            // 
            this.chkSelectAll.AutoSize = true;
            this.chkSelectAll.Location = new System.Drawing.Point(780, 25);
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.Size = new System.Drawing.Size(70, 17);
            this.chkSelectAll.TabIndex = 10;
            this.chkSelectAll.Text = "Select All";
            this.chkSelectAll.UseVisualStyleBackColor = true;

            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(110, 370);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(80, 25);
            this.btnSendMessage.TabIndex = 9;
            this.btnSendMessage.Text = "Send";
            this.btnSendMessage.UseVisualStyleBackColor = true;

            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(40, 100);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(50, 13);
            this.lblMessage.TabIndex = 6;
            this.lblMessage.Text = "Message";

            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(40, 30);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(46, 13);
            this.lblSubject.TabIndex = 7;
            this.lblSubject.Text = "Subject";

            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(110, 60);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(620, 300);
            this.txtMessage.TabIndex = 4;

            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(110, 25);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(620, 20);
            this.txtSubject.TabIndex = 5;

            // 
            // listBoxUsers
            // 
            this.listBoxUsers.Location = new System.Drawing.Point(780, 50);
            this.listBoxUsers.Size = new System.Drawing.Size(200, 300);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.TabIndex = 11;

            // 
            // tabInbox
            // 
            this.tabInbox.Controls.Add(this.btnRefreshInbox);
            this.tabInbox.Controls.Add(this.dataGridViewInbox);
            this.tabInbox.Location = new System.Drawing.Point(4, 22);
            this.tabInbox.Name = "tabInbox";
            this.tabInbox.Padding = new System.Windows.Forms.Padding(3);
            this.tabInbox.Size = new System.Drawing.Size(1012, 424);
            this.tabInbox.TabIndex = 1;
            this.tabInbox.Text = "Inbox";
            this.tabInbox.UseVisualStyleBackColor = true;

            // 
            // btnRefreshInbox
            // 
            this.btnRefreshInbox.Location = new System.Drawing.Point(900, 40);
            this.btnRefreshInbox.Name = "btnRefreshInbox";
            this.btnRefreshInbox.Size = new System.Drawing.Size(80, 25);
            this.btnRefreshInbox.TabIndex = 1;
            this.btnRefreshInbox.Text = "Refresh";
            this.btnRefreshInbox.UseVisualStyleBackColor = true;

            // 
            // dataGridViewInbox
            // 
            this.dataGridViewInbox.Location = new System.Drawing.Point(10, 100);
            this.dataGridViewInbox.Size = new System.Drawing.Size(980, 300);
            this.dataGridViewInbox.TabIndex = 0;

            // 
            // tabSentItems
            // 
            this.tabSentItems.Controls.Add(this.btnRefreshSentItems);
            this.tabSentItems.Controls.Add(this.dataGridViewSentItems);
            this.tabSentItems.Location = new System.Drawing.Point(4, 22);
            this.tabSentItems.Name = "tabSentItems";
            this.tabSentItems.Size = new System.Drawing.Size(1012, 424);
            this.tabSentItems.TabIndex = 2;
            this.tabSentItems.Text = "Sent Items";
            this.tabSentItems.UseVisualStyleBackColor = true;

            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabNewMessage;
        private System.Windows.Forms.TabPage tabInbox;
        private System.Windows.Forms.TabPage tabSentItems;
        private System.Windows.Forms.DataGridView dataGridViewInbox;
        private System.Windows.Forms.DataGridView dataGridViewSentItems;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Button btnRefreshInbox;
        private System.Windows.Forms.Button btnRefreshSentItems;
        private System.Windows.Forms.CheckBox chkSelectAll;
        private System.Windows.Forms.ListBox listBoxUsers;
    }
}
