namespace NotificationManagementSystem
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
            this.btnManageSubsc = new System.Windows.Forms.Button();
            this.btnPublishNoti = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManageSubsc
            // 
            this.btnManageSubsc.Location = new System.Drawing.Point(29, 75);
            this.btnManageSubsc.Name = "btnManageSubsc";
            this.btnManageSubsc.Size = new System.Drawing.Size(126, 37);
            this.btnManageSubsc.TabIndex = 0;
            this.btnManageSubsc.Text = "Manage Subscription";
            this.btnManageSubsc.UseVisualStyleBackColor = true;
            this.btnManageSubsc.Click += new System.EventHandler(this.btnManageSubsc_Click);
            // 
            // btnPublishNoti
            // 
            this.btnPublishNoti.Location = new System.Drawing.Point(184, 75);
            this.btnPublishNoti.Name = "btnPublishNoti";
            this.btnPublishNoti.Size = new System.Drawing.Size(126, 37);
            this.btnPublishNoti.TabIndex = 1;
            this.btnPublishNoti.Text = "Publish Notification";
            this.btnPublishNoti.UseVisualStyleBackColor = true;
            this.btnPublishNoti.Click += new System.EventHandler(this.btnPublishNoti_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(339, 75);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(126, 37);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 193);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPublishNoti);
            this.Controls.Add(this.btnManageSubsc);
            this.Name = "Form1";
            this.Text = "Notification Manager";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManageSubsc;
        private System.Windows.Forms.Button btnPublishNoti;
        private System.Windows.Forms.Button btnExit;
    }
}

