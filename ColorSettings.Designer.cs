namespace Game2024
{
    partial class ColorSettings
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
            this.BS_CS_Select_BackColor = new System.Windows.Forms.Button();
            this.BS_CS_Select_TextColor = new System.Windows.Forms.Button();
            this.L_Info_SelectColor = new System.Windows.Forms.Label();
            this.BS_CS_Apply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BS_CS_Select_BackColor
            // 
            this.BS_CS_Select_BackColor.BackColor = System.Drawing.Color.DarkOrange;
            this.BS_CS_Select_BackColor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BS_CS_Select_BackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BS_CS_Select_BackColor.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BS_CS_Select_BackColor.ForeColor = System.Drawing.Color.Black;
            this.BS_CS_Select_BackColor.Location = new System.Drawing.Point(12, 37);
            this.BS_CS_Select_BackColor.Name = "BS_CS_Select_BackColor";
            this.BS_CS_Select_BackColor.Size = new System.Drawing.Size(143, 28);
            this.BS_CS_Select_BackColor.TabIndex = 3;
            this.BS_CS_Select_BackColor.Text = "Select Back color";
            this.BS_CS_Select_BackColor.UseVisualStyleBackColor = false;
            this.BS_CS_Select_BackColor.Click += new System.EventHandler(this.BS_CS_Select_BackColor_Click);
            // 
            // BS_CS_Select_TextColor
            // 
            this.BS_CS_Select_TextColor.BackColor = System.Drawing.Color.DarkOrange;
            this.BS_CS_Select_TextColor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BS_CS_Select_TextColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BS_CS_Select_TextColor.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BS_CS_Select_TextColor.ForeColor = System.Drawing.Color.Black;
            this.BS_CS_Select_TextColor.Location = new System.Drawing.Point(175, 37);
            this.BS_CS_Select_TextColor.Name = "BS_CS_Select_TextColor";
            this.BS_CS_Select_TextColor.Size = new System.Drawing.Size(143, 28);
            this.BS_CS_Select_TextColor.TabIndex = 2;
            this.BS_CS_Select_TextColor.Text = "Select Text color";
            this.BS_CS_Select_TextColor.UseVisualStyleBackColor = false;
            this.BS_CS_Select_TextColor.Click += new System.EventHandler(this.BS_CS_Select_TextColor_Click);
            // 
            // L_Info_SelectColor
            // 
            this.L_Info_SelectColor.AutoSize = true;
            this.L_Info_SelectColor.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.L_Info_SelectColor.Location = new System.Drawing.Point(109, 6);
            this.L_Info_SelectColor.Name = "L_Info_SelectColor";
            this.L_Info_SelectColor.Size = new System.Drawing.Size(116, 23);
            this.L_Info_SelectColor.TabIndex = 4;
            this.L_Info_SelectColor.Text = "Color settings";
            // 
            // BS_CS_Apply
            // 
            this.BS_CS_Apply.BackColor = System.Drawing.Color.DarkOrange;
            this.BS_CS_Apply.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BS_CS_Apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BS_CS_Apply.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BS_CS_Apply.ForeColor = System.Drawing.Color.Black;
            this.BS_CS_Apply.Location = new System.Drawing.Point(12, 90);
            this.BS_CS_Apply.Name = "BS_CS_Apply";
            this.BS_CS_Apply.Size = new System.Drawing.Size(306, 28);
            this.BS_CS_Apply.TabIndex = 5;
            this.BS_CS_Apply.Text = "Apply color settings";
            this.BS_CS_Apply.UseVisualStyleBackColor = false;
            this.BS_CS_Apply.Click += new System.EventHandler(this.BS_CS_Apply_Click);
            // 
            // ColorSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(330, 130);
            this.Controls.Add(this.BS_CS_Apply);
            this.Controls.Add(this.L_Info_SelectColor);
            this.Controls.Add(this.BS_CS_Select_BackColor);
            this.Controls.Add(this.BS_CS_Select_TextColor);
            this.Font = new System.Drawing.Font("Roboto Condensed", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ColorSettings";
            this.Text = "Color Settings";
            this.Load += new System.EventHandler(this.ColorSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BS_CS_Select_BackColor;
        private System.Windows.Forms.Button BS_CS_Select_TextColor;
        private System.Windows.Forms.Label L_Info_SelectColor;
        private System.Windows.Forms.Button BS_CS_Apply;
    }
}