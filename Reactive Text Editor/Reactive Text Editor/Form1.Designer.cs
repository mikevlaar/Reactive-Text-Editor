namespace Reactive_Text_Editor
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
            this.reactiveTextBox = new System.Windows.Forms.TextBox();
            this.assumptionsListBox = new System.Windows.Forms.ListBox();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // reactiveTextBox
            // 
            this.reactiveTextBox.Location = new System.Drawing.Point(12, 12);
            this.reactiveTextBox.Multiline = true;
            this.reactiveTextBox.Name = "reactiveTextBox";
            this.reactiveTextBox.Size = new System.Drawing.Size(190, 22);
            this.reactiveTextBox.TabIndex = 0;
            this.reactiveTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // assumptionsListBox
            // 
            this.assumptionsListBox.FormattingEnabled = true;
            this.assumptionsListBox.Location = new System.Drawing.Point(222, 12);
            this.assumptionsListBox.Name = "assumptionsListBox";
            this.assumptionsListBox.Size = new System.Drawing.Size(147, 95);
            this.assumptionsListBox.TabIndex = 1;
            this.assumptionsListBox.Visible = false;
            this.assumptionsListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(160, 77);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.ReadOnly = true;
            this.textBoxA.Size = new System.Drawing.Size(42, 20);
            this.textBoxA.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "=";
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(12, 77);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(53, 20);
            this.textBoxB.TabIndex = 8;
            this.textBoxB.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(90, 77);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(45, 20);
            this.textBoxC.TabIndex = 9;
            this.textBoxC.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 122);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.assumptionsListBox);
            this.Controls.Add(this.reactiveTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox reactiveTextBox;
        private System.Windows.Forms.ListBox assumptionsListBox;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxC;
    }
}

