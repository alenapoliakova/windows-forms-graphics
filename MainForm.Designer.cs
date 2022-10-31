namespace lab_2
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.graphicPanel = new System.Windows.Forms.Panel();
            this.elementsBox = new System.Windows.Forms.GroupBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.changeBackgroundBtn = new System.Windows.Forms.Button();
            this.changeColorBtn = new System.Windows.Forms.Button();
            this.randomGraphicBtn = new System.Windows.Forms.Button();
            this.penColorDialog = new System.Windows.Forms.ColorDialog();
            this.elementsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // graphicPanel
            // 
            this.graphicPanel.Location = new System.Drawing.Point(12, 12);
            this.graphicPanel.Name = "graphicPanel";
            this.graphicPanel.Size = new System.Drawing.Size(571, 426);
            this.graphicPanel.TabIndex = 0;
            this.graphicPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.graphicPanel_Paint);
            // 
            // elementsBox
            // 
            this.elementsBox.Controls.Add(this.saveBtn);
            this.elementsBox.Controls.Add(this.changeBackgroundBtn);
            this.elementsBox.Controls.Add(this.changeColorBtn);
            this.elementsBox.Controls.Add(this.randomGraphicBtn);
            this.elementsBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.elementsBox.Location = new System.Drawing.Point(600, 0);
            this.elementsBox.Name = "elementsBox";
            this.elementsBox.Size = new System.Drawing.Size(200, 450);
            this.elementsBox.TabIndex = 1;
            this.elementsBox.TabStop = false;
            this.elementsBox.Text = "Elements";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(42, 286);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(105, 45);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // changeBackgroundBtn
            // 
            this.changeBackgroundBtn.Location = new System.Drawing.Point(42, 212);
            this.changeBackgroundBtn.Name = "changeBackgroundBtn";
            this.changeBackgroundBtn.Size = new System.Drawing.Size(105, 45);
            this.changeBackgroundBtn.TabIndex = 2;
            this.changeBackgroundBtn.Text = "Change background";
            this.changeBackgroundBtn.UseVisualStyleBackColor = true;
            this.changeBackgroundBtn.Click += new System.EventHandler(this.changeBackgroundBtn_Click);
            // 
            // changeColorBtn
            // 
            this.changeColorBtn.Location = new System.Drawing.Point(42, 139);
            this.changeColorBtn.Name = "changeColorBtn";
            this.changeColorBtn.Size = new System.Drawing.Size(105, 45);
            this.changeColorBtn.TabIndex = 1;
            this.changeColorBtn.Text = "Change pen color";
            this.changeColorBtn.UseVisualStyleBackColor = true;
            this.changeColorBtn.Click += new System.EventHandler(this.changeColorBtn_Click);
            // 
            // randomGraphicBtn
            // 
            this.randomGraphicBtn.Location = new System.Drawing.Point(42, 63);
            this.randomGraphicBtn.Name = "randomGraphicBtn";
            this.randomGraphicBtn.Size = new System.Drawing.Size(105, 45);
            this.randomGraphicBtn.TabIndex = 0;
            this.randomGraphicBtn.Text = "Random graphic";
            this.randomGraphicBtn.UseVisualStyleBackColor = true;
            this.randomGraphicBtn.Click += new System.EventHandler(this.randomGraphicBtn_Click);
            this.randomGraphicBtn.Paint += new System.Windows.Forms.PaintEventHandler(this.randomGraphicBtn_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.elementsBox);
            this.Controls.Add(this.graphicPanel);
            this.Name = "MainForm";
            this.Text = "Graphic App";
            this.elementsBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel graphicPanel;
        private GroupBox elementsBox;
        private Button randomGraphicBtn;
        private Button changeColorBtn;
        private Button changeBackgroundBtn;
        private Button saveBtn;
        private ColorDialog penColorDialog;
    }
}