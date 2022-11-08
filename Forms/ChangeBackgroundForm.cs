using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_2
{
    public partial class changeBackgroundForm : Form
    {
        public Color THEME_COLOR;
        public BackgroundType selectedType;

        public Color Color1;
        public Color Color2;
        public changeBackgroundForm()
        {
            InitializeComponent();
        }

        private void colorBackgroundBtn_Click(object sender, EventArgs e)
        {
            if (themeColorDialog.ShowDialog() == DialogResult.OK)
            {
                THEME_COLOR = themeColorDialog.Color;
                selectedType = BackgroundType.COLOR;
                DialogResult = DialogResult.Yes;
            }
        }

        private void gradientBackgroundBtn_Click(object sender, EventArgs e)
        {
            if (themeColorDialog.ShowDialog() == DialogResult.OK)
            {
                var firstColor = themeColorDialog.Color;
                if (themeColorDialog.ShowDialog() == DialogResult.OK)
                {
                    Color1 = firstColor;
                    Color2 = themeColorDialog.Color;
                    selectedType = BackgroundType.GRADIENT;
                    DialogResult = DialogResult.Yes;
                }
            }
        }

        private void hatchingBackgroundBtn_Click(object sender, EventArgs e)
        {
            selectedType = BackgroundType.HATCHING;
            DialogResult = DialogResult.Yes;
        }

        private void squareBackgroundBtn_Click(object sender, EventArgs e)
        {
            selectedType = BackgroundType.SQUARE;
            DialogResult = DialogResult.Yes;
        }

        private void multicoloredBackgroundBtn_Click(object sender, EventArgs e)
        {
            selectedType = BackgroundType.MULTICOLORED;
            DialogResult = DialogResult.Yes;
        }

        private void imageBackgroundBtn_Click(object sender, EventArgs e)
        {
            selectedType = BackgroundType.IMAGE;
            DialogResult = DialogResult.Yes;
        }
    }
}
