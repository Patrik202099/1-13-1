
namespace futasidejuKomponens
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
            this.Eredmeny = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(36, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kattints a form egy üres területén! Létrejön egy új címke, rajta egy 1 és 100 köz" +
    "ötti szám.";
            // 
            // Eredmeny
            // 
            this.Eredmeny.AutoSize = true;
            this.Eredmeny.Location = new System.Drawing.Point(47, 59);
            this.Eredmeny.Name = "Eredmeny";
            this.Eredmeny.Size = new System.Drawing.Size(0, 13);
            this.Eredmeny.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(791, 323);
            this.Controls.Add(this.Eredmeny);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Dinamikus komponensek";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Eredmeny;
    }
}

