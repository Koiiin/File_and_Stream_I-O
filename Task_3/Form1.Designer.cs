namespace Task_3
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
            this.calculate_btn = new System.Windows.Forms.Button();
            this.read_btn = new System.Windows.Forms.Button();
            this.write_btn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // calculate_btn
            // 
            this.calculate_btn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.calculate_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate_btn.Location = new System.Drawing.Point(490, 41);
            this.calculate_btn.Name = "calculate_btn";
            this.calculate_btn.Size = new System.Drawing.Size(181, 68);
            this.calculate_btn.TabIndex = 1;
            this.calculate_btn.Text = "Calculate";
            this.calculate_btn.UseVisualStyleBackColor = false;
            this.calculate_btn.Click += new System.EventHandler(this.calculate_btn_Click);
            // 
            // read_btn
            // 
            this.read_btn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.read_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.read_btn.Location = new System.Drawing.Point(174, 41);
            this.read_btn.Name = "read_btn";
            this.read_btn.Size = new System.Drawing.Size(181, 68);
            this.read_btn.TabIndex = 2;
            this.read_btn.Text = "Read";
            this.read_btn.UseVisualStyleBackColor = false;
            this.read_btn.Click += new System.EventHandler(this.read_btn_Click);
            // 
            // write_btn
            // 
            this.write_btn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.write_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.write_btn.Location = new System.Drawing.Point(841, 41);
            this.write_btn.Name = "write_btn";
            this.write_btn.Size = new System.Drawing.Size(181, 68);
            this.write_btn.TabIndex = 3;
            this.write_btn.Text = "Write";
            this.write_btn.UseVisualStyleBackColor = false;
            this.write_btn.Click += new System.EventHandler(this.write_btn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(23, 195);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(499, 509);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(656, 195);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(499, 509);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 764);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.write_btn);
            this.Controls.Add(this.read_btn);
            this.Controls.Add(this.calculate_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button calculate_btn;
        private System.Windows.Forms.Button read_btn;
        private System.Windows.Forms.Button write_btn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}

