using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kidslearning
{
    internal class round : PictureBox
    {
        private int boardersize = 0;
        private int boarderradious = 20;
        private Color boardercolor = Color.PaleVioletRed;
        [Category("RJ Code Advance")]
        public int Boardersize { get => boardersize; set => boardersize = value; }
        [Category("RJ Code Advance")]
        public int Boarderradious { get => boarderradious; set => boarderradious = value; }
        [Category("RJ Code Advance")]
        public Color Boardercolor { get => boardercolor; set => boardercolor = value; }

        [Category("RJ Code Advance")]
        public Color BorderColor
        {
            get
            {
                return this.Boardercolor;
            }
            set
            {
                this.Boardercolor = value;

            }
        }
        [Category("RJ Code Advance")]
        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }
        [Category("RJ Code Advance")]
        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }
        public round()
        {
         
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
            this.Resize += new EventHandler(Button_Resize);

        }
        private void Button_Resize(object sender, EventArgs e)
        {
            if (boarderradious > this.Height)
                boarderradious = this.Height;
        }
        private GraphicsPath GetFigurePath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -boardersize, -boardersize);
            int smoothSize = 2;
            if (boardersize > 0)
                smoothSize = boardersize;
            if (boarderradious > 2) //Rounded button
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, boarderradious))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, boarderradious - boardersize))
                using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(boardercolor, boardersize))
                {
                    pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    //Button surface
                    this.Region = new Region(pathSurface);
                    //Draw surface border for HD result
                    pevent.Graphics.DrawPath(penSurface, pathSurface);
                    //Button border                    
                    if (boardersize >= 1)
                        //Draw control border
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else //Normal button
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.None;
                //Button surface
                this.Region = new Region(rectSurface);
                //Button border
                if (boardersize >= 1)
                {
                    using (Pen penBorder = new Pen(boardercolor, boardersize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }

        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }
        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
