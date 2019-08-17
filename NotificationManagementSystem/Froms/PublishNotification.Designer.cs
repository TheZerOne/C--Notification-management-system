namespace NotificationManagementSystem
{
    partial class PublishNotification
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
            this.txtNotificationCont2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPublish2 = new System.Windows.Forms.Button();
            this.btnExit2 = new System.Windows.Forms.Button();
            this.txtOutput2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNotificationCont2
            // 
            this.txtNotificationCont2.Location = new System.Drawing.Point(183, 42);
            this.txtNotificationCont2.Name = "txtNotificationCont2";
            this.txtNotificationCont2.Size = new System.Drawing.Size(357, 20);
            this.txtNotificationCont2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Notification Content";
            // 
            // btnPublish2
            // 
            this.btnPublish2.Location = new System.Drawing.Point(39, 110);
            this.btnPublish2.Name = "btnPublish2";
            this.btnPublish2.Size = new System.Drawing.Size(75, 23);
            this.btnPublish2.TabIndex = 2;
            this.btnPublish2.Text = "Publish";
            this.btnPublish2.UseVisualStyleBackColor = true;
            this.btnPublish2.Click += new System.EventHandler(this.btnPublish2_Click);
            // 
            // btnExit2
            // 
            this.btnExit2.Location = new System.Drawing.Point(464, 109);
            this.btnExit2.Name = "btnExit2";
            this.btnExit2.Size = new System.Drawing.Size(75, 23);
            this.btnExit2.TabIndex = 3;
            this.btnExit2.Text = "Exit";
            this.btnExit2.UseVisualStyleBackColor = true;
            this.btnExit2.Click += new System.EventHandler(this.btnExit2_Click);
            // 
            // txtOutput2
            // 
            this.txtOutput2.Location = new System.Drawing.Point(39, 156);
            this.txtOutput2.Multiline = true;
            this.txtOutput2.Name = "txtOutput2";
            this.txtOutput2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput2.Size = new System.Drawing.Size(500, 370);
            this.txtOutput2.TabIndex = 4;
            // 
            // PublishNotification
            // 
            this.ClientSize = new System.Drawing.Size(578, 569);
            this.Controls.Add(this.txtOutput2);
            this.Controls.Add(this.btnExit2);
            this.Controls.Add(this.btnPublish2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNotificationCont2);
            this.Name = "PublishNotification";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PublishNotification_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNotificationCont2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPublish2;
        private System.Windows.Forms.Button btnExit2;
        private System.Windows.Forms.TextBox txtOutput2;
    }
}