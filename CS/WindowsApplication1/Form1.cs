using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.XtraEditors;
using DevExpress.LookAndFeel;

namespace WindowsApplication1
{
    public partial class Form1 : XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        static Image GetImage(Image image, Color color)
        {
            Bitmap b = new Bitmap(image.Width, image.Height);
            Graphics g = Graphics.FromImage(b);
            g.FillRectangle(new SolidBrush(color), new Rectangle(new Point(0, 0), image.Size));
            g.Dispose();
            return b;
        }

        void SetElementColor(string elementName, Color c)
        {
            Skin currentSkin = FormSkins.GetSkin(defaultLookAndFeel1.LookAndFeel);
            SkinElement element = currentSkin[elementName];
            element.Image.SetImage(GetImage(element.Image.Image, c), Color.Transparent);
        }

        void ChangeFormElements(Color c)
        {
            SetElementColor(FormSkins.SkinFormCaption, c);
            SetElementColor(FormSkins.SkinFormFrameBottom, c);
            SetElementColor(FormSkins.SkinFormFrameLeft, c);
            SetElementColor(FormSkins.SkinFormFrameRight, c);
        }

        void ChangeFormColor()
        {
            ChangeFormElements(colorEdit1.Color);
            LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
        }

        private void colorEdit1_EditValueChanged(object sender, EventArgs e)
        {
            ChangeFormColor();
            ColorToValues(colorEdit1.Color);
        }


        Color ValuesToColor()
        {
            return Color.FromArgb(trackBarControl1.Value, trackBarControl2.Value, trackBarControl3.Value);
        }

        void ColorToValues(Color c)
        {
            trackBarControl1.Value = c.R;
            trackBarControl2.Value = c.G;
            trackBarControl3.Value = c.B;
        }

        private void trackBarControl1_EditValueChanged(object sender, EventArgs e)
        {
            Color c = ValuesToColor();
            colorEdit1.Color = c;
        }
    }
}