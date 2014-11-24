namespace AnimalProg
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
            this.tbxresultat = new System.Windows.Forms.RichTextBox();
            this.btnkör = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxresultat
            // 
            this.tbxresultat.Location = new System.Drawing.Point(26, 12);
            this.tbxresultat.Name = "tbxresultat";
            this.tbxresultat.Size = new System.Drawing.Size(128, 141);
            this.tbxresultat.TabIndex = 0;
            this.tbxresultat.Text = "";
            // 
            // btnkör
            // 
            this.btnkör.Location = new System.Drawing.Point(47, 171);
            this.btnkör.Name = "btnkör";
            this.btnkör.Size = new System.Drawing.Size(75, 23);
            this.btnkör.TabIndex = 1;
            this.btnkör.Text = "kör";
            this.btnkör.UseVisualStyleBackColor = true;
            this.btnkör.Click += new System.EventHandler(this.btnkör_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 207);
            this.Controls.Add(this.btnkör);
            this.Controls.Add(this.tbxresultat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbxresultat;
        private System.Windows.Forms.Button btnkör;
    }
}

