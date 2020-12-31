using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    class ISPanel : Panel
    {
        int wh = 10;
        public Color ColorTop { get; set; }
        public Color ColorBottom { get; set; }
        public int Angle { get; set; }
        public int BorderRadius
        {
            get { return wh; }
            set { wh = value; Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            GraphicsPath gp = new GraphicsPath();
            gp.AddArc(new Rectangle(0, 0, wh, wh), 180, 90);
            gp.AddArc(new Rectangle(Width - wh, 0, wh, wh), -90, 90);
            gp.AddArc(new Rectangle(Width - wh, Height - wh, wh, wh), 0, 90);
            gp.AddArc(new Rectangle(0, Height - wh, wh, wh), 90, 90);
            // LinearGradientBrush lgb = new LinearGradientBrush(this.ClientRectangle, this.ColorTop, this.ColorBottom, this.Angle);
            //  Graphics g = e.Graphics;           
            //  g.FillRectangle(lgb, this.ClientRectangle);
            e.Graphics.FillPath(new LinearGradientBrush(this.ClientRectangle, this.ColorTop, this.ColorBottom, this.Angle), gp);
            base.OnPaint(e);
        }
    }
}
