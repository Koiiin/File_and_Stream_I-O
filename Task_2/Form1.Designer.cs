﻿namespace Task_2
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
            this.read_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fileName_box = new System.Windows.Forms.TextBox();
            this.url_box = new System.Windows.Forms.TextBox();
            this.line_box = new System.Windows.Forms.TextBox();
            this.word_box = new System.Windows.Forms.TextBox();
            this.char_box = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // read_btn
            // 
            this.read_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.read_btn.Location = new System.Drawing.Point(300, 65);
            this.read_btn.Name = "read_btn";
            this.read_btn.Size = new System.Drawing.Size(279, 126);
            this.read_btn.TabIndex = 0;
            this.read_btn.Text = "Read File";
            this.read_btn.UseVisualStyleBackColor = true;
            this.read_btn.Click += new System.EventHandler(this.read_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "File name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Url";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 473);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "Num of line";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 558);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 37);
            this.label4.TabIndex = 4;
            this.label4.Text = "Num of word";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 635);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(265, 37);
            this.label5.TabIndex = 5;
            this.label5.Text = "Num of character";
            // 
            // fileName_box
            // 
            this.fileName_box.Location = new System.Drawing.Point(300, 304);
            this.fileName_box.Name = "fileName_box";
            this.fileName_box.Size = new System.Drawing.Size(401, 31);
            this.fileName_box.TabIndex = 6;
            // 
            // url_box
            // 
            this.url_box.Location = new System.Drawing.Point(300, 390);
            this.url_box.Name = "url_box";
            this.url_box.Size = new System.Drawing.Size(401, 31);
            this.url_box.TabIndex = 7;
            // 
            // line_box
            // 
            this.line_box.Location = new System.Drawing.Point(300, 479);
            this.line_box.Name = "line_box";
            this.line_box.Size = new System.Drawing.Size(401, 31);
            this.line_box.TabIndex = 8;
            // 
            // word_box
            // 
            this.word_box.Location = new System.Drawing.Point(300, 564);
            this.word_box.Name = "word_box";
            this.word_box.Size = new System.Drawing.Size(401, 31);
            this.word_box.TabIndex = 9;
            // 
            // char_box
            // 
            this.char_box.Location = new System.Drawing.Point(300, 641);
            this.char_box.Name = "char_box";
            this.char_box.Size = new System.Drawing.Size(401, 31);
            this.char_box.TabIndex = 10;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(748, 82);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(574, 674);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 825);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.char_box);
            this.Controls.Add(this.word_box);
            this.Controls.Add(this.line_box);
            this.Controls.Add(this.url_box);
            this.Controls.Add(this.fileName_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.read_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button read_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fileName_box;
        private System.Windows.Forms.TextBox url_box;
        private System.Windows.Forms.TextBox line_box;
        private System.Windows.Forms.TextBox word_box;
        private System.Windows.Forms.TextBox char_box;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

