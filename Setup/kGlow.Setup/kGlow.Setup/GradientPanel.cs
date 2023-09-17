using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace kGlow.Setup
{
    public partial class GradientPanel : Panel
    {
        public GradientPanel()
        {
            InitializeComponent();
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            var TopColor = Color.FromArgb(235, 245, 255);
            var BottomColor = Color.FromArgb(185, 220, 250);
            var Angle = 80;

            ColorBlend colorBlend = new ColorBlend();
            colorBlend.Colors = new Color[] { TopColor, BottomColor };
            colorBlend.Positions = new float[] { 0f, 1f };

            LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, this.Width, this.Height), TopColor, BottomColor, Angle);
            brush.InterpolationColors = colorBlend;

            Graphics g = e.Graphics;
            g.FillRectangle(brush, this.ClientRectangle);

            base.OnPaint(e);
        }

    }
}
