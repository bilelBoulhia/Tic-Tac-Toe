namespace tic_tac_tow
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
            this.materialButtonstart = new MaterialSkin.Controls.MaterialButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.xoboard1 = new tic_tac_tow.XOBOARD();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialButtonstart
            // 
            this.materialButtonstart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonstart.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.materialButtonstart.Depth = 0;
            this.materialButtonstart.DrawShadows = true;
            this.materialButtonstart.HighEmphasis = true;
            this.materialButtonstart.Icon = null;
            this.materialButtonstart.Location = new System.Drawing.Point(24, 96);
            this.materialButtonstart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonstart.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonstart.Name = "materialButtonstart";
            this.materialButtonstart.Size = new System.Drawing.Size(67, 36);
            this.materialButtonstart.TabIndex = 0;
            this.materialButtonstart.Text = "start";
            this.materialButtonstart.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonstart.UseAccentColor = false;
            this.materialButtonstart.UseVisualStyleBackColor = false;
            this.materialButtonstart.Click += new System.EventHandler(this.materialButtonstart_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Poppins", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "TIC TAC TOE";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.materialButtonstart);
            this.panel1.Location = new System.Drawing.Point(18, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 186);
            this.panel1.TabIndex = 3;
            // 
            // xoboard1
            // 
            this.xoboard1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.xoboard1.BackColor = System.Drawing.Color.MidnightBlue;
            this.xoboard1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("xoboard1.BackgroundImage")));
            this.xoboard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.xoboard1.Location = new System.Drawing.Point(12, 194);
            this.xoboard1.Name = "xoboard1";
            this.xoboard1.Size = new System.Drawing.Size(402, 382);
            this.xoboard1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(429, 597);
            this.Controls.Add(this.xoboard1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton materialButtonstart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private XOBOARD xoboard1;
    }
}

