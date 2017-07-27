namespace My_Story_
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
            this.user = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.goal = new System.Windows.Forms.TextBox();
            this.reason = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.finished = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(47, 13);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(348, 20);
            this.user.TabIndex = 0;
            this.user.Tag = "";
            this.user.Text = "User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Goal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-3, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Reason";
            // 
            // goal
            // 
            this.goal.Location = new System.Drawing.Point(47, 41);
            this.goal.Name = "goal";
            this.goal.Size = new System.Drawing.Size(348, 20);
            this.goal.TabIndex = 4;
            // 
            // reason
            // 
            this.reason.Location = new System.Drawing.Point(47, 69);
            this.reason.Name = "reason";
            this.reason.Size = new System.Drawing.Size(348, 20);
            this.reason.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // finished
            // 
            this.finished.Location = new System.Drawing.Point(12, 124);
            this.finished.Name = "finished";
            this.finished.Size = new System.Drawing.Size(408, 105);
            this.finished.TabIndex = 7;
            this.finished.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "As a <user>, I want <goal> so that <reason>.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 241);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.finished);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reason);
            this.Controls.Add(this.goal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.user);
            this.Name = "Form1";
            this.Text = "My Story!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox goal;
        private System.Windows.Forms.TextBox reason;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox finished;
        private System.Windows.Forms.Label label4;
    }
}

