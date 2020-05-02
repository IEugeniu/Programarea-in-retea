namespace EmailManager
{
     partial class Form3
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
               this.RecipientTextBox = new System.Windows.Forms.TextBox();
               this.Recipient = new System.Windows.Forms.Label();
               this.SubjectTextBox = new System.Windows.Forms.TextBox();
               this.label1 = new System.Windows.Forms.Label();
               this.MessageTextBox = new System.Windows.Forms.TextBox();
               this.label2 = new System.Windows.Forms.Label();
               this.SendButton = new System.Windows.Forms.Button();
               this.SuspendLayout();
               // 
               // RecipientTextBox
               // 
               this.RecipientTextBox.Location = new System.Drawing.Point(259, 64);
               this.RecipientTextBox.Name = "RecipientTextBox";
               this.RecipientTextBox.Size = new System.Drawing.Size(297, 20);
               this.RecipientTextBox.TabIndex = 0;
               // 
               // Recipient
               // 
               this.Recipient.AutoSize = true;
               this.Recipient.Location = new System.Drawing.Point(190, 71);
               this.Recipient.Name = "Recipient";
               this.Recipient.Size = new System.Drawing.Size(52, 13);
               this.Recipient.TabIndex = 1;
               this.Recipient.Text = "Recipient";
               // 
               // SubjectTextBox
               // 
               this.SubjectTextBox.Location = new System.Drawing.Point(259, 107);
               this.SubjectTextBox.Name = "SubjectTextBox";
               this.SubjectTextBox.Size = new System.Drawing.Size(297, 20);
               this.SubjectTextBox.TabIndex = 2;
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(190, 110);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(43, 13);
               this.label1.TabIndex = 3;
               this.label1.Text = "Subject";
               // 
               // MessageTextBox
               // 
               this.MessageTextBox.Location = new System.Drawing.Point(259, 150);
               this.MessageTextBox.Multiline = true;
               this.MessageTextBox.Name = "MessageTextBox";
               this.MessageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
               this.MessageTextBox.Size = new System.Drawing.Size(297, 195);
               this.MessageTextBox.TabIndex = 4;
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Location = new System.Drawing.Point(190, 150);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(50, 13);
               this.label2.TabIndex = 5;
               this.label2.Text = "Message";
               // 
               // SendButton
               // 
               this.SendButton.Location = new System.Drawing.Point(368, 377);
               this.SendButton.Name = "SendButton";
               this.SendButton.Size = new System.Drawing.Size(75, 23);
               this.SendButton.TabIndex = 6;
               this.SendButton.Text = "Send";
               this.SendButton.UseVisualStyleBackColor = true;
               this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
               // 
               // Form3
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(800, 450);
               this.Controls.Add(this.SendButton);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.MessageTextBox);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.SubjectTextBox);
               this.Controls.Add(this.Recipient);
               this.Controls.Add(this.RecipientTextBox);
               this.Name = "Form3";
               this.Text = "Form3";
               this.ResumeLayout(false);
               this.PerformLayout();

          }

        #endregion

        private System.Windows.Forms.TextBox RecipientTextBox;
        private System.Windows.Forms.Label Recipient;
        private System.Windows.Forms.TextBox SubjectTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SendButton;
    }
}