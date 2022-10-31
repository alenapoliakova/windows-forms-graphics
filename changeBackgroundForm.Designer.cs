namespace lab_2
{
    partial class changeBackgroundForm
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
            this.textLabel = new System.Windows.Forms.Label();
            this.colorBackgroundBtn = new System.Windows.Forms.Button();
            this.gradientBackgroundBtn = new System.Windows.Forms.Button();
            this.hatchingBackgroundBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textLabel.Location = new System.Drawing.Point(247, 66);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(333, 28);
            this.textLabel.TabIndex = 0;
            this.textLabel.Text = "Choose background type for graphic";
            // 
            // colorBackgroundBtn
            // 
            this.colorBackgroundBtn.Location = new System.Drawing.Point(315, 122);
            this.colorBackgroundBtn.Name = "colorBackgroundBtn";
            this.colorBackgroundBtn.Size = new System.Drawing.Size(200, 36);
            this.colorBackgroundBtn.TabIndex = 1;
            this.colorBackgroundBtn.Text = "Color";
            this.colorBackgroundBtn.UseVisualStyleBackColor = true;
            // 
            // gradientBackgroundBtn
            // 
            this.gradientBackgroundBtn.Location = new System.Drawing.Point(315, 178);
            this.gradientBackgroundBtn.Name = "gradientBackgroundBtn";
            this.gradientBackgroundBtn.Size = new System.Drawing.Size(200, 36);
            this.gradientBackgroundBtn.TabIndex = 2;
            this.gradientBackgroundBtn.Text = "Gradient";
            this.gradientBackgroundBtn.UseVisualStyleBackColor = true;
            // 
            // hatchingBackgroundBtn
            // 
            this.hatchingBackgroundBtn.Location = new System.Drawing.Point(315, 234);
            this.hatchingBackgroundBtn.Name = "hatchingBackgroundBtn";
            this.hatchingBackgroundBtn.Size = new System.Drawing.Size(200, 36);
            this.hatchingBackgroundBtn.TabIndex = 3;
            this.hatchingBackgroundBtn.Text = "Hatching";
            this.hatchingBackgroundBtn.UseVisualStyleBackColor = true;
            // 
            // changeBackgroundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hatchingBackgroundBtn);
            this.Controls.Add(this.gradientBackgroundBtn);
            this.Controls.Add(this.colorBackgroundBtn);
            this.Controls.Add(this.textLabel);
            this.Name = "changeBackgroundForm";
            this.Text = "changeBackgroundForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label textLabel;
        private Button colorBackgroundBtn;
        private Button gradientBackgroundBtn;
        private Button hatchingBackgroundBtn;
    }
}