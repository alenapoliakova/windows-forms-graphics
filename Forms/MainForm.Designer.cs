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
            this.components = new System.ComponentModel.Container();
            this.elementsBox = new System.Windows.Forms.GroupBox();
            this.graphicTypeLabel = new System.Windows.Forms.Label();
            this.scaleValueLabel = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.changeBackgroundBtn = new System.Windows.Forms.Button();
            this.changeColorBtn = new System.Windows.Forms.Button();
            this.randomGraphicBtn = new System.Windows.Forms.Button();
            this.graphicPanel = new System.Windows.Forms.Panel();
            this.penColorDialog = new System.Windows.Forms.ColorDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.rollTheBallBtn = new System.Windows.Forms.Button();
            this.elementsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // elementsBox
            // 
            this.elementsBox.Controls.Add(this.rollTheBallBtn);
            this.elementsBox.Controls.Add(this.graphicTypeLabel);
            this.elementsBox.Controls.Add(this.scaleValueLabel);
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
            // graphicTypeLabel
            // 
            this.graphicTypeLabel.AutoSize = true;
            this.graphicTypeLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.graphicTypeLabel.Location = new System.Drawing.Point(3, 432);
            this.graphicTypeLabel.Name = "graphicTypeLabel";
            this.graphicTypeLabel.Size = new System.Drawing.Size(38, 15);
            this.graphicTypeLabel.TabIndex = 5;
            this.graphicTypeLabel.Text = "label1";
            this.graphicTypeLabel.Visible = false;
            // 
            // scaleValueLabel
            // 
            this.scaleValueLabel.AutoSize = true;
            this.scaleValueLabel.Location = new System.Drawing.Point(134, 0);
            this.scaleValueLabel.Name = "scaleValueLabel";
            this.scaleValueLabel.Size = new System.Drawing.Size(54, 15);
            this.scaleValueLabel.TabIndex = 4;
            this.scaleValueLabel.Text = "Scale = 1";
            this.scaleValueLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.scaleValueLabel.Visible = false;
            // 
            // saveBtn
            // 
            this.saveBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.saveBtn.Location = new System.Drawing.Point(3, 154);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(194, 45);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // changeBackgroundBtn
            // 
            this.changeBackgroundBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.changeBackgroundBtn.Location = new System.Drawing.Point(3, 109);
            this.changeBackgroundBtn.Name = "changeBackgroundBtn";
            this.changeBackgroundBtn.Size = new System.Drawing.Size(194, 45);
            this.changeBackgroundBtn.TabIndex = 2;
            this.changeBackgroundBtn.Text = "Change background";
            this.changeBackgroundBtn.UseVisualStyleBackColor = true;
            this.changeBackgroundBtn.Click += new System.EventHandler(this.changeBackgroundBtn_Click);
            // 
            // changeColorBtn
            // 
            this.changeColorBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.changeColorBtn.Location = new System.Drawing.Point(3, 64);
            this.changeColorBtn.Name = "changeColorBtn";
            this.changeColorBtn.Size = new System.Drawing.Size(194, 45);
            this.changeColorBtn.TabIndex = 1;
            this.changeColorBtn.Text = "Change pen color";
            this.changeColorBtn.UseVisualStyleBackColor = true;
            this.changeColorBtn.Click += new System.EventHandler(this.changeColorBtn_Click);
            // 
            // randomGraphicBtn
            // 
            this.randomGraphicBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.randomGraphicBtn.Location = new System.Drawing.Point(3, 19);
            this.randomGraphicBtn.Name = "randomGraphicBtn";
            this.randomGraphicBtn.Size = new System.Drawing.Size(194, 45);
            this.randomGraphicBtn.TabIndex = 0;
            this.randomGraphicBtn.Text = "Random graphic";
            this.randomGraphicBtn.UseVisualStyleBackColor = true;
            this.randomGraphicBtn.Click += new System.EventHandler(this.randomGraphicBtn_Click);
            this.randomGraphicBtn.Paint += new System.Windows.Forms.PaintEventHandler(this.randomGraphicBtn_Paint);
            // 
            // graphicPanel
            // 
            this.graphicPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphicPanel.Location = new System.Drawing.Point(0, 0);
            this.graphicPanel.Name = "graphicPanel";
            this.graphicPanel.Size = new System.Drawing.Size(800, 450);
            this.graphicPanel.TabIndex = 0;
            this.graphicPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.graphicPanel_Paint);
            this.graphicPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.graphicPanel_MouseDown);
            this.graphicPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.graphicPanel_MouseMove);
            this.graphicPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.graphicPanel_MouseUp);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // rollTheBallBtn
            // 
            this.rollTheBallBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.rollTheBallBtn.Location = new System.Drawing.Point(3, 199);
            this.rollTheBallBtn.Name = "rollTheBallBtn";
            this.rollTheBallBtn.Size = new System.Drawing.Size(194, 45);
            this.rollTheBallBtn.TabIndex = 6;
            this.rollTheBallBtn.Text = "Roll the ball";
            this.rollTheBallBtn.UseVisualStyleBackColor = true;
            this.rollTheBallBtn.Click += new System.EventHandler(this.rollTheBallBtn_Click);
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
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.elementsBox.ResumeLayout(false);
            this.elementsBox.PerformLayout();
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
        private Label scaleValueLabel;
        private Label graphicTypeLabel;
        private ImageList imageList1;
        private Button rollTheBallBtn;
    }
}