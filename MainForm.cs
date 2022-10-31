using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace lab_2
{
    public partial class MainForm : Form
    {
        private Color DEFAULT_PEN_COLOR = Color.Black;

        private Color graphicBackColor = Color.White;
        private Color graphicPenColor = Color.Black;
        private float scale = 1.0F;

        const int STEP = 15;  // Пикселей в одном делении оси
        const int ARROW_LENGTH = 10;  // Длина стрелки

        private int TEST = 0;
        private EventType ACTION = EventType.NONE;
        private IFunction function = null;
        private int BACKGROUND = 0;
        private Color BACKGROUND_COLOR = Color.White;

        public MainForm()
        {
            InitializeComponent();
        }

        private void DrawText(Point point, string text, Graphics g, bool isYAxis = false)
        {
            // Рисование текста
            var f = new Font(Font.FontFamily, 6);
            var size = g.MeasureString(text, f);
            var pt = isYAxis
                ? new PointF(point.X + 1, point.Y - size.Height / 2)
                : new PointF(point.X - size.Width / 2, point.Y + 1);
            var rect = new RectangleF(pt, size);
            g.DrawString(text, f, Brushes.Black, rect);
        }

        private void drawGraphic(int width, int height, Graphics graphic)
        {
            // Draw random graphic

            Pen pen = new Pen(graphicPenColor);

            float NUM = 45F;

            //var function = new SquareFunction();

            // x > 0
            int cnt = 0;
            Point[] points = new Point[(int)(width * NUM / STEP)];

            for (float x = 0f; x > -width; x -= (float)(STEP / NUM))
            {
                double realX = x / STEP;
                double realY = function.calc(realX) * STEP;
                points[cnt] = new Point((int)x, -(int)(realY));
                cnt++;
                if (cnt == points.Length)
                {
                    break;
                }
            }
            graphic.DrawLines(pen, points);

            // x < 0
            cnt = 0;
            points = new Point[(int)(width * NUM / STEP)];

            for (float x = 0f; x < width; x += (float)(STEP / NUM))
            {
                double realX = x / STEP;
                double realY = function.calc(realX) * STEP;
                points[cnt] = new Point((int)x, -(int)(realY));
                cnt++;
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
            LinearGradientBrush brush = new LinearGradientBrush(new Point(0, 100), new Point(100, 200), Color.Aqua, Color.Sienna);
            Graphics graphic = e.Graphics;
            graphic.Clear(graphicBackColor);
            graphic.FillRectangle(brush, graphicPanel.ClientRectangle);

            int width = graphicPanel.ClientSize.Width / 2;
            int height = graphicPanel.ClientSize.Height / 2;

            graphic.TranslateTransform(width, height);

            // Coordinate lines
            pen.EndCap = LineCap.ArrowAnchor;
            graphic.DrawLine(pen, -width, 0, width, 0);  // X
            graphic.DrawLine(pen, 0, height, 0, -height);  // Y
            pen.EndCap = LineCap.Flat;

            // X asis
            for (int x = -STEP; x > -width; x -= STEP)
            {
                graphic.DrawLine(pen, x, -3, x, 3);
                DrawText(new Point(x, 3), (x / STEP).ToString(), graphic);
            }

            for (int x = STEP; x < width - ARROW_LENGTH; x += STEP)
            {
                graphic.DrawLine(pen, x, -3, x, 3);
                DrawText(new Point(x, 3), (x / STEP).ToString(), graphic);
            }

            // Y asis
            for (int y = STEP; y < height; y += STEP)
            {
                graphic.DrawLine(pen, -3, y, 3, y);
                DrawText(new Point(3, y), (-y / STEP).ToString(), graphic, true);
            }

            for (int y = -STEP; y > -height + ARROW_LENGTH; y -= STEP)
            {
                graphic.DrawLine(pen, -3, y, 3, y);
                DrawText(new Point(3, y), (-y / STEP).ToString(), graphic, true);
            }

            // Center circle
            pen.DashStyle = DashStyle.Dash;
            var rectangle = new Rectangle(-STEP, -STEP, 2 * STEP, 2 * STEP);
            graphic.DrawEllipse(pen, rectangle);
            pen.DashStyle = DashStyle.Solid;

            if (TEST == 1)
            {
                graphic.DrawLine(pen, 22, height, 22, -height);
            }
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
            }

            //graphic.TranslateTransform(-width, -height);
        }

        private void randomGraphicBtn_Click(object sender, EventArgs e)
        {
            ACTION = EventType.PAINT_RANDOM_PLOT;  // Maybe "ACTION"??
            graphicPanel.Refresh();
        }

        private void changeColorBtn_Click(object sender, EventArgs e)
        {
            if (penColorDialog.ShowDialog() == DialogResult.OK)
            {
                Color color = penColorDialog.Color;
                graphicPenColor = color;
                graphicPanel.Refresh();
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // добавить проверку на наличие графика
            int width = graphicPanel.ClientSize.Width;
            int height = graphicPanel.ClientSize.Height;
            Bitmap bmp = new Bitmap(width, height);
            graphicPanel.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
            bmp.Save("C:/Users/Алёна/Desktop/test/one" + @".png", ImageFormat.Png);
        }

        private void randomGraphicBtn_Paint(object sender, PaintEventArgs e) { }

        private void changeBackgroundBtn_Click(object sender, EventArgs e)
        {
            // Change graphic background
            Form backgroundForm = new changeBackgroundForm();
            DialogResult dr = backgroundForm.ShowDialog(this);

            if (dr == DialogResult.Yes)
            {
                // graphicPanel.BackColor = Color.Gray;

                //graphicPanel.Refresh();
            }
            backgroundForm.Close();
        }
    }
}