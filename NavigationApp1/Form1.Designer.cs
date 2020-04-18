namespace NavigationApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.procBtn = new System.Windows.Forms.Button();
            this.wbBox = new System.Windows.Forms.WebBrowser();
            this.fromBox = new System.Windows.Forms.TextBox();
            this.toBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FROM:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "TO:";
            // 
            // procBtn
            // 
            this.procBtn.Location = new System.Drawing.Point(639, 13);
            this.procBtn.Name = "procBtn";
            this.procBtn.Size = new System.Drawing.Size(75, 23);
            this.procBtn.TabIndex = 2;
            this.procBtn.Text = "Process";
            this.procBtn.UseVisualStyleBackColor = true;
            this.procBtn.Click += new System.EventHandler(this.procBtn_Click);
            // 
            // wbBox
            // 
            this.wbBox.Location = new System.Drawing.Point(16, 55);
            this.wbBox.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBox.Name = "wbBox";
            this.wbBox.Size = new System.Drawing.Size(772, 383);
            this.wbBox.TabIndex = 4;
            // 
            // fromBox
            // 
            this.fromBox.Location = new System.Drawing.Point(61, 10);
            this.fromBox.Name = "fromBox";
            this.fromBox.Size = new System.Drawing.Size(175, 20);
            this.fromBox.TabIndex = 5;
            // 
            // toBox
            // 
            this.toBox.Location = new System.Drawing.Point(350, 10);
            this.toBox.Name = "toBox";
            this.toBox.Size = new System.Drawing.Size(219, 20);
            this.toBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toBox);
            this.Controls.Add(this.fromBox);
            this.Controls.Add(this.wbBox);
            this.Controls.Add(this.procBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "NavApp V1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button procBtn;
        private System.Windows.Forms.WebBrowser wbBox;
        private System.Windows.Forms.TextBox fromBox;
        private System.Windows.Forms.TextBox toBox;
    }
}

