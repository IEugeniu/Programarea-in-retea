namespace EmailManager
{
     partial class Form2
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
               this.emailList = new System.Windows.Forms.ListView();
               this.from_list = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
               this.subject_list = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
               this.emailText = new System.Windows.Forms.TextBox();
               this.SuspendLayout();
               // 
               // emailList
               // 
               this.emailList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.from_list,
            this.subject_list});
               this.emailList.HideSelection = false;
               this.emailList.Location = new System.Drawing.Point(26, 41);
               this.emailList.MultiSelect = false;
               this.emailList.Name = "emailList";
               this.emailList.Size = new System.Drawing.Size(380, 350);
               this.emailList.TabIndex = 0;
               this.emailList.UseCompatibleStateImageBehavior = false;
               this.emailList.View = System.Windows.Forms.View.Details;
               this.emailList.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
               // 
               // from_list
               // 
               this.from_list.Text = "From";
               this.from_list.Width = 100;
               // 
               // subject_list
               // 
               this.subject_list.Text = "Subject";
               this.subject_list.Width = 270;
               // 
               // emailText
               // 
               this.emailText.Location = new System.Drawing.Point(430, 41);
               this.emailText.Multiline = true;
               this.emailText.Name = "emailText";
               this.emailText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
               this.emailText.Size = new System.Drawing.Size(346, 350);
               this.emailText.TabIndex = 1;
               // 
               // Form2
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(800, 450);
               this.Controls.Add(this.emailText);
               this.Controls.Add(this.emailList);
               this.Name = "Form2";
               this.Text = "Form2";
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.ListView emailList;
          private System.Windows.Forms.ColumnHeader from_list;
          private System.Windows.Forms.ColumnHeader subject_list;
          private System.Windows.Forms.TextBox emailText;
     }
}