namespace Chat
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
            this.components = new System.ComponentModel.Container();
            this.portTxt = new System.Windows.Forms.TextBox();
            this.portBtn = new System.Windows.Forms.Button();
            this.sendTxt = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // portTxt
            // 
            this.portTxt.Location = new System.Drawing.Point(13, 13);
            this.portTxt.Name = "portTxt";
            this.portTxt.Size = new System.Drawing.Size(100, 20);
            this.portTxt.TabIndex = 0;
            // 
            // portBtn
            // 
            this.portBtn.Location = new System.Drawing.Point(120, 13);
            this.portBtn.Name = "portBtn";
            this.portBtn.Size = new System.Drawing.Size(75, 23);
            this.portBtn.TabIndex = 1;
            this.portBtn.Text = "Connect";
            this.portBtn.UseVisualStyleBackColor = true;
            this.portBtn.Click += new System.EventHandler(this.portBtn_Click);
            // 
            // sendTxt
            // 
            this.sendTxt.Location = new System.Drawing.Point(13, 201);
            this.sendTxt.Name = "sendTxt";
            this.sendTxt.Size = new System.Drawing.Size(259, 20);
            this.sendTxt.TabIndex = 3;
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(197, 227);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(75, 23);
            this.sendBtn.TabIndex = 4;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.AutoWordSelection = true;
            this.richTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox.Location = new System.Drawing.Point(13, 40);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox.Size = new System.Drawing.Size(259, 155);
            this.richTextBox.TabIndex = 5;
            this.richTextBox.Text = "";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.sendTxt);
            this.Controls.Add(this.portBtn);
            this.Controls.Add(this.portTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox portTxt;
        private System.Windows.Forms.Button portBtn;
        private System.Windows.Forms.TextBox sendTxt;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Timer timer1;
    }
}

