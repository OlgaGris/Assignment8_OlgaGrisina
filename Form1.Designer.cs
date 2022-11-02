namespace Assignment8_OlgaGrisina
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxBoy = new System.Windows.Forms.TextBox();
            this.textBoxGirl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.check = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxBoy
            // 
            this.textBoxBoy.Location = new System.Drawing.Point(99, 38);
            this.textBoxBoy.Name = "textBoxBoy";
            this.textBoxBoy.Size = new System.Drawing.Size(100, 23);
            this.textBoxBoy.TabIndex = 0;
            // 
            // textBoxGirl
            // 
            this.textBoxGirl.Location = new System.Drawing.Point(99, 89);
            this.textBoxGirl.Name = "textBoxGirl";
            this.textBoxGirl.Size = new System.Drawing.Size(100, 23);
            this.textBoxGirl.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Boy\'s name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Girl\'s name";
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(261, 41);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(97, 66);
            this.check.TabIndex = 4;
            this.check.Text = "Check in Top list";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // result
            // 
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.result.Location = new System.Drawing.Point(25, 138);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(333, 173);
            this.result.TabIndex = 5;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(216, 333);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 6;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(99, 333);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 7;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 368);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.result);
            this.Controls.Add(this.check);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxGirl);
            this.Controls.Add(this.textBoxBoy);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxBoy;
        private TextBox textBoxGirl;
        private Label label1;
        private Label label2;
        private Button check;
        private Label result;
        private Button exit;
        private Button clear;
    }
}