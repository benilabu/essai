namespace Binairo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb8 = new System.Windows.Forms.RadioButton();
            this.rb10 = new System.Windows.Forms.RadioButton();
            this.rb12 = new System.Windows.Forms.RadioButton();
            this.bOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb12);
            this.groupBox1.Controls.Add(this.rb10);
            this.groupBox1.Controls.Add(this.rb8);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rb8
            // 
            this.rb8.AutoSize = true;
            this.rb8.Checked = true;
            this.rb8.Location = new System.Drawing.Point(19, 19);
            this.rb8.Name = "rb8";
            this.rb8.Size = new System.Drawing.Size(48, 17);
            this.rb8.TabIndex = 1;
            this.rb8.TabStop = true;
            this.rb8.Text = "8 x 8";
            this.rb8.UseVisualStyleBackColor = true;
            // 
            // rb10
            // 
            this.rb10.AutoSize = true;
            this.rb10.Location = new System.Drawing.Point(19, 42);
            this.rb10.Name = "rb10";
            this.rb10.Size = new System.Drawing.Size(57, 17);
            this.rb10.TabIndex = 2;
            this.rb10.Text = "10 x10";
            this.rb10.UseVisualStyleBackColor = true;
            // 
            // rb12
            // 
            this.rb12.AutoSize = true;
            this.rb12.Location = new System.Drawing.Point(19, 65);
            this.rb12.Name = "rb12";
            this.rb12.Size = new System.Drawing.Size(57, 17);
            this.rb12.TabIndex = 3;
            this.rb12.Text = "12 x12";
            this.rb12.UseVisualStyleBackColor = true;
            // 
            // bOK
            // 
            this.bOK.Location = new System.Drawing.Point(207, 111);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(75, 23);
            this.bOK.TabIndex = 1;
            this.bOK.Text = "OK";
            this.bOK.UseVisualStyleBackColor = true;
            this.bOK.Click += new System.EventHandler(this.bOK_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 146);
            this.Controls.Add(this.bOK);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Dimension de la nouvelle grille";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb12;
        private System.Windows.Forms.RadioButton rb10;
        private System.Windows.Forms.RadioButton rb8;
        private System.Windows.Forms.Button bOK;
    }
}