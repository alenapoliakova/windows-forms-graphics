using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Reflection;

namespace lab_2
{
    public partial class MainForm : Form
    {
        private Color DEFAULT_PEN_COLOR = Color.Black;

        private Color graphicBackColor = Color.White;
        private Color graphicPenColor = Color.Black;

        const int STEP = 15;
        const int ARROW_LENGTH = 10;
        const float NUM = 45F;
        private float SCALE = 1F;

        private EventType ACTION = EventType.NONE;
        private IFunction function = null;
        private BackgroundType BACKGROUND;

        private float ellipsX1 = 0;
        private float ellipsX2 = 0;
        private bool drawEllips = false;

        private Color Color1;
        private Color Color2;

        private bool MOUSE_DOWN = false;
        private float moveByX = 0;
        private float moveByY = 0;

        private float startX = 0F;
        private float startY = 0F;

        public MainForm()
        {
            InitializeComponent();
            this.graphicPanel.MouseWheel += new MouseEventHandler(graphicPanel_MouseWheel);
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, 
                null, graphicPanel, new object[] { true }); ;  // Double buffer for graphic
        }

        private void DrawText(Point point, string text, Graphics g, bool isYAxis = false)
        {
            // Draw numbers
            var f = new Font(Font.FontFamily, (int)5 * SCALE);
            var size = g.MeasureString(text, f);
            var pt = isYAxis
                ? new PointF(point.X + 1, point.Y - size.Height / 2)
                : new PointF(point.X - size.Width / 2, point.Y + 1);
            var rect = new RectangleF(pt, size);
            g.DrawString(text, f, Brushes.Black, rect);
        }

        private void drawGraphic(int width, int height, Graphics graphic)
        {
            // Draw graphic
            Pen pen = new Pen(graphicPenColor);

            // x > 0
            int cnt = 0;
            var stepScale = STEP * SCALE;

            Point[] points = new Point[(int)(width * NUM / stepScale)];

            for (float x = 0F - moveByX * SCALE * STEP; x > -width - moveByX * SCALE * STEP; x -= (float)(stepScale / NUM))
            {
                double realX = x / stepScale;
                double realY = function.calc(realX) * stepScale;
                points[cnt] = new Point((int)(x + moveByX * SCALE * STEP), -(int)(realY - moveByY * SCALE * STEP));
                cnt++;
                if (drawEllips)
                {
                    if (Math.Abs(ellipsX1 - x) <= 1 && ellipsX1 != 0)
                    {
                        graphic.FillEllipse(Brushes.Black, new Rectangle((int)(x + moveByX * SCALE * STEP), -(int)(realY - moveByY * SCALE * STEP) - 10, 15, 15));
                    }
                }
                if (cnt == points.Length)
                {
                    break;
                }
            }
            graphic.DrawLines(pen, points);

            // x < 0
            cnt = 0;
            points = new Point[(int)(width * NUM / stepScale)];

            for (float x = 0F - moveByX * stepScale; x < width - moveByX * SCALE * STEP; x += (float)(stepScale / NUM))
            {
                double realX = x / stepScale;
                double realY = function.calc(realX) * stepScale;
                points[cnt] = new Point((int)(x + moveByX * stepScale), -(int)(realY - moveByY * stepScale));
                cnt++;
                if (drawEllips)
                {
                    if (Math.Abs(ellipsX2 - x) <= 1 && ellipsX2 != 0)
                    {
                        graphic.FillEllipse(Brushes.Black, new Rectangle((int)(x + moveByX * stepScale), -(int)(realY - moveByY * stepScale) - 10, 15, 15));
                    }
                }
                if (cnt == points.Length)
                {
                    break;
                }
            }
            graphic.DrawLines(pen, points);
            graphic.TranslateTransform(-width, -height);
        }

        private void graphicPanel_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(DEFAULT_PEN_COLOR);
            Graphics graphic = e.Graphics;

            int width = (graphicPanel.ClientSize.Width - elementsBox.Width) / 2;
            int height = graphicPanel.ClientSize.Height / 2;

            // Scaling
            if (SCALE <= 1F)
            {
                SCALE = 1F;
                scaleValueLabel.Visible = false;
            }
            else
            {
                scaleValueLabel.Visible = true;
                scaleValueLabel.Text = "scale = " + SCALE.ToString();
            }
            var stepScale = STEP * SCALE;

            // Change background
            Pen backgroundPen = new Pen(Color.Gray);

            switch (BACKGROUND)
            {
                case BackgroundType.COLOR:
                    graphic.Clear(graphicBackColor);
                    break;
                case BackgroundType.GRADIENT:
                    LinearGradientBrush brush = new LinearGradientBrush(new Point(0, 0), new Point(width * 2, height * 2), Color1, Color2);
                    graphic.Clear(DefaultBackColor);
                    graphic.FillRectangle(brush, graphicPanel.ClientRectangle);
                    break;
                case BackgroundType.HATCHING:

                    for (int x = 0; x < width * 2; x += (int)stepScale / 2)
                    {
                        graphic.DrawLine(backgroundPen, x, 0, x, height * 2);
                    }
                    break;
                case BackgroundType.SQUARE:
                    graphic.Clear(DefaultBackColor);

                    for (int x = 0; x < width * 2; x += (int)stepScale)
                    {
                        graphic.DrawLine(backgroundPen, x, 0, x, height * 2);
                    }
                    for (int y = 0; y < height * 2; y += (int)stepScale)
                    {
                        graphic.DrawLine(backgroundPen, 0, y, width * 2, y);
                    }
                    break;
                case BackgroundType.MULTICOLORED:
                    graphic.Clear(DefaultBackColor);

                    Rectangle rectangle1 = new Rectangle(0, 0, width, height);
                    Rectangle rectangle2 = new Rectangle(width, 0, width * 2, height);
                    Rectangle rectangle3 = new Rectangle(0, height, width, height * 2);
                    Rectangle rectangle4 = new Rectangle(width, height, width * 2, height * 2);

                    graphic.FillRectangle(new SolidBrush(Color.Red), rectangle1);
                    graphic.FillRectangle(new SolidBrush(Color.Yellow), rectangle2);
                    graphic.FillRectangle(new SolidBrush(Color.Green), rectangle3);
                    graphic.FillRectangle(new SolidBrush(Color.Blue), rectangle4);

                    break;
                case BackgroundType.IMAGE:
                    graphicPanel.BackgroundImage = Image.FromFile(@"C:\Users\Алёна\source\repos\windows-forms-graphics\theme.jpg");
                    break;
            }

            graphic.TranslateTransform(width, height);

            // Coordinate lines
            pen.EndCap = LineCap.ArrowAnchor;
            graphic.DrawLine(pen, -width, 0, width, 0);  // X
            graphic.DrawLine(pen, 0, height, 0, -height);  // Y
            pen.EndCap = LineCap.Flat;

            // X asis
            for (float x = 0; x < width - ARROW_LENGTH; x += stepScale)
            {
                graphic.DrawLine(pen, x, -3, x, 3);
                DrawText(new Point((int)x, 3), (x / stepScale).ToString(), graphic);
            }
            for (float x = 0; x > -width; x -= stepScale)
            {
                graphic.DrawLine(pen, x, -3, x, 3);
                DrawText(new Point((int)x, 3), (x / stepScale).ToString(), graphic);
            }

            // Y asis
            for (float y = 0; y < height; y += stepScale)
            {
                graphic.DrawLine(pen, -3, y, 3, y);
                DrawText(new Point(3, (int)y), (-y / stepScale).ToString(), graphic, true);
            }

            for (float y = 0; y > -height + ARROW_LENGTH; y -= stepScale)
            {
                graphic.DrawLine(pen, -3, y, 3, y);
                DrawText(new Point(3, (int)y), (-y / stepScale).ToString(), graphic, true);
            }

            // Center circle
            pen.DashStyle = DashStyle.Dash;
            var rectangle = new RectangleF(-stepScale, -stepScale, 2 * stepScale, 2 * stepScale);
            graphic.DrawEllipse(pen, rectangle);
            pen.DashStyle = DashStyle.Solid;

            // Handle events types
            if (ACTION == EventType.PAINT_RANDOM_PLOT)
            {
                Random random = new Random();
                int randomGraphicNum = random.Next(0, 5);

                switch (randomGraphicNum)
                {
                    case 0:
                        function = new CubeFunction();
                        break;
                    case 1:
                        function = new SinFunction();
                        break;
                    case 2:
                        function = new SquareFunction();
                        break;
                    case 3:
                        function = new TangFunction();
                        break;
                    case 4:
                        function = new UserFunction();
                        break;
                }
                ACTION = EventType.NONE;
            }
            if (function != null)
            {
                drawGraphic(width, height, graphic);
                graphicTypeLabel.Visible = true;
                graphicTypeLabel.Text = function.ToString();
            }
        }

        private void randomGraphicBtn_Click(object sender, EventArgs e)
        {
            // Generate random graphic button
            ACTION = EventType.PAINT_RANDOM_PLOT;
            SCALE = 1F;

            MOUSE_DOWN = false;

            startX = 0;
            startY = 0;
            moveByX = 0;
            moveByY = 0;

            graphicPanel.Refresh();
        }

        private void changeColorBtn_Click(object sender, EventArgs e)
        {
            // Change graphic color (pen)
            if (penColorDialog.ShowDialog() == DialogResult.OK)
            {
                Color color = penColorDialog.Color;
                graphicPenColor = color;
                graphicPanel.Refresh();
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // Save graphic in file system
            int width = graphicPanel.ClientSize.Width;
            int height = graphicPanel.ClientSize.Height;

            var saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Images (*.png,*.jpeg)|*.png;*.jpeg";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                DialogResult dialogResult = MessageBox.Show("Are you really want to save file?", "Save your plot", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Bitmap bmp = new Bitmap(width, height);
                    graphicPanel.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width - elementsBox.Width, bmp.Height));
                    bmp.Save(saveDialog.FileName, ImageFormat.Png);
                }
            }
        }

        private void randomGraphicBtn_Paint(object sender, PaintEventArgs e) { }

        private void changeBackgroundBtn_Click(object sender, EventArgs e)
        {
            // Handle changing background color in another form
            changeBackgroundForm backgroundForm = new changeBackgroundForm();
            DialogResult dr = backgroundForm.ShowDialog(this);

            if (dr == DialogResult.Yes)
            {
                Color1 = backgroundForm.Color1;
                Color2 = backgroundForm.Color2;
                graphicBackColor = backgroundForm.THEME_COLOR;
                BACKGROUND = backgroundForm.selectedType;
                graphicPanel.Refresh();
            }
            backgroundForm.Close();
        }

        private void graphicPanel_MouseWheel(object sender, MouseEventArgs e)
        {
            // Update scale if user wheeled mouse
            int mouseWheelType = e.Delta / 120;

            if (mouseWheelType >= 0)
            {
                SCALE += 1F;
            }
            else
            {
                SCALE -= 1F;

                if (SCALE <= 1F)
                {
                    SCALE = 1F;
                    scaleValueLabel.Visible = false;
                }
                else
                {
                    scaleValueLabel.Visible = true;
                    scaleValueLabel.Text = "scale = " + SCALE.ToString();
                }
            }
            graphicPanel.Invalidate();
        }

        private void graphicPanel_MouseDown(object sender, MouseEventArgs e)
        {
            // Press left mouse button
            if (e.Button == MouseButtons.Left)
            {
                startX = e.X / (SCALE * STEP);
                startY = e.Y / (SCALE * STEP);

                MOUSE_DOWN = true;
            }
            else
            {
                MOUSE_DOWN = false;
            }
        }

        private void graphicPanel_MouseUp(object sender, MouseEventArgs e)
        {
            // Up left mouse button
            if (e.Button == MouseButtons.Left)
            {
                MOUSE_DOWN = false;
            }
        }

        private void graphicPanel_MouseMove(object sender, MouseEventArgs e)
        {
            // Move mouse and move graphic
            if (MOUSE_DOWN)
            {
                moveByX += e.X / (SCALE * STEP) - startX;
                moveByY += e.Y / (SCALE * STEP) - startY;

                startX = e.X / (SCALE * STEP);
                startY = e.Y / (SCALE * STEP);

                graphicPanel.Refresh();
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            // Update graphic if user resized form
            graphicPanel.Invalidate();
        }

        private void rollTheBallBtn_Click(object sender, EventArgs e)
        {
            // Draw a circle that rolls according to the plot
            int width = (graphicPanel.ClientSize.Width - elementsBox.Width) / 2;
            var stepScale = STEP * SCALE;

            drawEllips = true;

            // x < 0
            int cnt = 0;
            for (float x = -width - moveByX * stepScale; x < 0F - moveByX * stepScale; x += (float)(stepScale / NUM))
            {
                if (cnt % 10 == 0)
                {
                    ellipsX1 = x;
                    graphicPanel.Refresh();
                    Thread.Sleep(1);
                }
                cnt++;
            }

            // x > 0
            cnt = 0;
            ellipsX1 = 0;
            for (float x = 0F - moveByX * stepScale; x < width - moveByX * stepScale; x += (float)(stepScale / NUM))
            {
                if (cnt % 10 == 0)
                {
                    ellipsX2 = x;
                    graphicPanel.Refresh();
                    Thread.Sleep(1);
                }
                cnt++;
            }
            drawEllips = false;
        }
    }
}