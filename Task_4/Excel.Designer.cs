namespace Task_4
{
    partial class Excel
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
            this.input_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.show_btn = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // input_btn
            // 
            this.input_btn.Location = new System.Drawing.Point(69, 151);
            this.input_btn.Name = "input_btn";
            this.input_btn.Size = new System.Drawing.Size(142, 58);
            this.input_btn.TabIndex = 0;
            this.input_btn.Text = "Input";
            this.input_btn.UseVisualStyleBackColor = true;
            this.input_btn.Click += new System.EventHandler(this.input_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(69, 258);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(142, 58);
            this.save_btn.TabIndex = 1;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // show_btn
            // 
            this.show_btn.Location = new System.Drawing.Point(69, 378);
            this.show_btn.Name = "show_btn";
            this.show_btn.Size = new System.Drawing.Size(142, 58);
            this.show_btn.TabIndex = 2;
            this.show_btn.Text = "Show";
            this.show_btn.UseVisualStyleBackColor = true;
            this.show_btn.Click += new System.EventHandler(this.show_btn_Click);
            // 
            // list
            // 
            this.list.HideSelection = false;
            this.list.Location = new System.Drawing.Point(307, 40);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(1120, 582);
            this.list.TabIndex = 3;
            this.list.UseCompatibleStateImageBehavior = false;
            // 
            // Excel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1505, 667);
            this.Controls.Add(this.list);
            this.Controls.Add(this.show_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.input_btn);
            this.Name = "Excel";
            this.Text = "Excel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button input_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button show_btn;
        private System.Windows.Forms.ListView list;
    }
}