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
            this.themeColorDialog = new System.Windows.Forms.ColorDialog();
            this.squareBackgroundBtn = new System.Windows.Forms.Button();
            this.multicoloredBackgroundBtn = new System.Windows.Forms.Button();
            this.imageBackgroundBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textLabel
            // 
            this.textLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.textLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textLabel.Location = new System.Drawing.Point(0, 0);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(800, 28);
            this.textLabel.TabIndex = 0;
            this.textLabel.Text = "Choose background type for graphic";
            this.textLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // colorBackgroundBtn
            // 
            this.colorBackgroundBtn.Location = new System.Drawing.Point(0, 28);
            this.colorBackgroundBtn.Name = "colorBackgroundBtn";
            this.colorBackgroundBtn.Size = new System.Drawing.Size(800, 36);
            this.colorBackgroundBtn.TabIndex = 1;
            this.colorBackgroundBtn.Text = "Color";
            this.colorBackgroundBtn.UseVisualStyleBackColor = true;
            this.colorBackgroundBtn.Click += new System.EventHandler(this.colorBackgroundBtn_Click);
            // 
            // gradientBackgroundBtn
            // 
            this.gradientBackgroundBtn.Location = new System.Drawing.Point(0, 64);
            this.gradientBackgroundBtn.Name = "gradientBackgroundBtn";
            this.gradientBackgroundBtn.Size = new System.Drawing.Size(800, 36);
            this.gradientBackgroundBtn.TabIndex = 2;
            this.gradientBackgroundBtn.Text = "Gradient";
            this.gradientBackgroundBtn.UseVisualStyleBackColor = true;
            this.gradientBackgroundBtn.Click += new System.EventHandler(this.gradientBackgroundBtn_Click);
            // 
            // hatchingBackgroundBtn
            // 
            this.hatchingBackgroundBtn.Location = new System.Drawing.Point(0, 100);
            this.hatchingBackgroundBtn.Name = "hatchingBackgroundBtn";
            this.hatchingBackgroundBtn.Size = new System.Drawing.Size(800, 36);
            this.hatchingBackgroundBtn.TabIndex = 3;
            this.hatchingBackgroundBtn.Text = "Hatching";
            this.hatchingBackgroundBtn.UseVisualStyleBackColor = true;
            this.hatchingBackgroundBtn.Click += new System.EventHandler(this.hatchingBackgroundBtn_Click);
            // 
            // squareBackgroundBtn
            // 
            this.squareBackgroundBtn.Location = new System.Drawing.Point(0, 136);
            this.squareBackgroundBtn.Name = "squareBackgroundBtn";
            this.squareBackgroundBtn.Size = new System.Drawing.Size(800, 36);
            this.squareBackgroundBtn.TabIndex = 4;
            this.squareBackgroundBtn.Text = "In square";
            this.squareBackgroundBtn.UseVisualStyleBackColor = true;
            this.squareBackgroundBtn.Click += new System.EventHandler(this.squareBackgroundBtn_Click);
            // 
            // multicoloredBackgroundBtn
            // 
            this.multicoloredBackgroundBtn.Location = new System.Drawing.Point(0, 172);
            this.multicoloredBackgroundBtn.Name = "multicoloredBackgroundBtn";
            this.multicoloredBackgroundBtn.Size = new System.Drawing.Size(800, 36);
            this.multicoloredBackgroundBtn.TabIndex = 5;
            this.multicoloredBackgroundBtn.Text = "Multicolored";
            this.multicoloredBackgroundBtn.UseVisualStyleBackColor = true;
            this.multicoloredBackgroundBtn.Click += new System.EventHandler(this.multicoloredBackgroundBtn_Click);
            // 
            // imageBackgroundBtn
            // 
            this.imageBackgroundBtn.Location = new System.Drawing.Point(0, 208);
            this.imageBackgroundBtn.Name = "imageBackgroundBtn";
            this.imageBackgroundBtn.Size = new System.Drawing.Size(800, 36);
            this.imageBackgroundBtn.TabIndex = 6;
            this.imageBackgroundBtn.Text = "Image";
            this.imageBackgroundBtn.UseVisualStyleBackColor = true;
            this.imageBackgroundBtn.Click += new System.EventHandler(this.imageBackgroundBtn_Click);
            // 
            // changeBackgroundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imageBackgroundBtn);
            this.Controls.Add(this.multicoloredBackgroundBtn);
            this.Controls.Add(this.squareBackgroundBtn);
            this.Controls.Add(this.hatchingBackgroundBtn);
            this.Controls.Add(this.gradientBackgroundBtn);
            this.Controls.Add(this.colorBackgroundBtn);
            this.Controls.Add(this.textLabel);
            this.Name = "changeBackgroundForm";
            this.Text = "changeBackgroundForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Label textLabel;
        private Button colorBackgroundBtn;
        private Button gradientBackgroundBtn;
        private Button hatchingBackgroundBtn;
        private ColorDialog themeColorDialog;
        private Button squareBackgroundBtn;
        private Button multicoloredBackgroundBtn;
        private Button imageBackgroundBtn;
    }
}