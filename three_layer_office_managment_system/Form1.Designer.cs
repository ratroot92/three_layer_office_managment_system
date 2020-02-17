namespace three_layer_office_managment_system
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_2 = new System.Windows.Forms.TextBox();
            this.txt_1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_4 = new System.Windows.Forms.TextBox();
            this.txt_3 = new System.Windows.Forms.TextBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(123, 57);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(28, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(126, 88);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(45, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // txt_2
            // 
            this.txt_2.Location = new System.Drawing.Point(302, 81);
            this.txt_2.Name = "txt_2";
            this.txt_2.Size = new System.Drawing.Size(217, 20);
            this.txt_2.TabIndex = 2;
            // 
            // txt_1
            // 
            this.txt_1.Location = new System.Drawing.Point(302, 49);
            this.txt_1.Name = "txt_1";
            this.txt_1.Size = new System.Drawing.Size(217, 20);
            this.txt_1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 126);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5);
            this.label3.Size = new System.Drawing.Size(44, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cell #";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 162);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5);
            this.label4.Size = new System.Drawing.Size(55, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Address";
            // 
            // txt_4
            // 
            this.txt_4.Location = new System.Drawing.Point(302, 155);
            this.txt_4.Name = "txt_4";
            this.txt_4.Size = new System.Drawing.Size(217, 20);
            this.txt_4.TabIndex = 2;
            // 
            // txt_3
            // 
            this.txt_3.Location = new System.Drawing.Point(302, 123);
            this.txt_3.Name = "txt_3";
            this.txt_3.Size = new System.Drawing.Size(217, 20);
            this.txt_3.TabIndex = 3;
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(317, 231);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 23);
            this.btn_insert.TabIndex = 4;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(723, 476);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.txt_3);
            this.Controls.Add(this.txt_1);
            this.Controls.Add(this.txt_4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_2;
        private System.Windows.Forms.TextBox txt_1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_4;
        private System.Windows.Forms.TextBox txt_3;
        private System.Windows.Forms.Button btn_insert;
    }
}

