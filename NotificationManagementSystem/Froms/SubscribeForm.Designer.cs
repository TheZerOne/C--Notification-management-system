namespace NotificationManagementSystem
{
    partial class SubscribeForm
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
            this.chkEmail = new System.Windows.Forms.CheckBox();
            this.chkMobile = new System.Windows.Forms.CheckBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.btnSubscribe = new System.Windows.Forms.Button();
            this.btnUnsubscribe = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblErrorEmail = new System.Windows.Forms.Label();
            this.lblErrorMobile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkEmail
            // 
            this.chkEmail.AutoSize = true;
            this.chkEmail.Location = new System.Drawing.Point(13, 36);
            this.chkEmail.Name = "chkEmail";
            this.chkEmail.Size = new System.Drawing.Size(136, 17);
            this.chkEmail.TabIndex = 0;
            this.chkEmail.Text = "Message Sent by Email";
            this.chkEmail.UseVisualStyleBackColor = true;
            // 
            // chkMobile
            // 
            this.chkMobile.AutoSize = true;
            this.chkMobile.Location = new System.Drawing.Point(13, 86);
            this.chkMobile.Name = "chkMobile";
            this.chkMobile.Size = new System.Drawing.Size(142, 17);
            this.chkMobile.TabIndex = 1;
            this.chkMobile.Text = "Message Sent by Mobile";
            this.chkMobile.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(203, 33);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(229, 20);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.Text = "Email Address";
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(203, 83);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(229, 20);
            this.txtMobile.TabIndex = 3;
            this.txtMobile.Text = "xxx-xxx-xxxx";
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.Location = new System.Drawing.Point(30, 136);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(75, 23);
            this.btnSubscribe.TabIndex = 4;
            this.btnSubscribe.Text = "Subscribe";
            this.btnSubscribe.UseVisualStyleBackColor = true;
            this.btnSubscribe.Click += new System.EventHandler(this.btnSubscribe_Click);
            // 
            // btnUnsubscribe
            // 
            this.btnUnsubscribe.Location = new System.Drawing.Point(213, 136);
            this.btnUnsubscribe.Name = "btnUnsubscribe";
            this.btnUnsubscribe.Size = new System.Drawing.Size(75, 23);
            this.btnUnsubscribe.TabIndex = 5;
            this.btnUnsubscribe.Text = "Unsubscribe";
            this.btnUnsubscribe.UseVisualStyleBackColor = true;
            this.btnUnsubscribe.Click += new System.EventHandler(this.btnUnsubscribe_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(387, 136);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblErrorEmail
            // 
            this.lblErrorEmail.AutoSize = true;
            this.lblErrorEmail.ForeColor = System.Drawing.Color.Red;
            this.lblErrorEmail.Location = new System.Drawing.Point(200, 56);
            this.lblErrorEmail.Name = "lblErrorEmail";
            this.lblErrorEmail.Size = new System.Drawing.Size(0, 13);
            this.lblErrorEmail.TabIndex = 7;
            // 
            // lblErrorMobile
            // 
            this.lblErrorMobile.AutoSize = true;
            this.lblErrorMobile.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMobile.Location = new System.Drawing.Point(203, 110);
            this.lblErrorMobile.Name = "lblErrorMobile";
            this.lblErrorMobile.Size = new System.Drawing.Size(0, 13);
            this.lblErrorMobile.TabIndex = 8;
            // 
            // SubscribeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 193);
            this.Controls.Add(this.lblErrorMobile);
            this.Controls.Add(this.lblErrorEmail);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUnsubscribe);
            this.Controls.Add(this.btnSubscribe);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.chkMobile);
            this.Controls.Add(this.chkEmail);
            this.Name = "SubscribeForm";
            this.Text = "SubscribeForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SubscribeForm_FormClosed);
            this.Load += new System.EventHandler(this.SubscribeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkEmail;
        private System.Windows.Forms.CheckBox chkMobile;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Button btnSubscribe;
        private System.Windows.Forms.Button btnUnsubscribe;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblErrorEmail;
        private System.Windows.Forms.Label lblErrorMobile;
    }
}