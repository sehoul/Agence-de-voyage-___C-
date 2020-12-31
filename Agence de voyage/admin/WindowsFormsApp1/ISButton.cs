using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WindowsFormsApp6
{
    [DefaultEvent("Click")]
    public partial class ISButton : UserControl
    {
        int wh = 20;
        float ang = 1;
        Color cl0 = Color.Blue;
        Color cl1 = Color.Green;
        Timer t = new Timer();
        string txt = "IS Button";
        public ISButton()
        {
            DoubleBuffered = true;
            t.Interval = 40;
            t.Start();
            t.Tick += (s, e) => { Angle = Angle % 360 + 1; };
            ForeColor = Color.White;
        }
      public float Angle
        {
            get { return ang; }
            set { ang = value; Invalidate(); }
        }
        public int BorderRadius
        {
            get { return wh; }
            set { wh = value; Invalidate(); }
        }

        public Color Color0
        {
            get { return cl0; }
            set { cl0 = value; Invalidate(); }
        }
        public Color Color1
        {
            get { return cl1; }
            set { cl1 = value; Invalidate(); }
        }

        public string Contenue
        {
            get { return txt; }
            set { txt = value; Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            GraphicsPath gp = new GraphicsPath();
            gp.AddArc(new Rectangle(0, 0, wh, wh), 180, 90);
            gp.AddArc(new Rectangle(Width-wh, 0, wh, wh), -90, 90);
            gp.AddArc(new Rectangle(Width-wh, Height-wh, wh, wh), 0, 90);
            gp.AddArc(new Rectangle(0, Height-wh, wh, wh), 90, 90);

            e.Graphics.FillPath(new LinearGradientBrush(ClientRectangle,cl0,cl1,ang), gp);
            e.Graphics.DrawString(Contenue, Font, new SolidBrush(ForeColor), ClientRectangle, new StringFormat() { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center });
            base.OnPaint(e);
        }


    }
}
