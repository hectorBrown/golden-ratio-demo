using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Golden_Ratio
{
    public partial class FRM_phi : Form
    {
        private readonly int ELLIPSESIZE = 10;
        private readonly int NOELLIPSE = 10000;

        private double angle;

        public FRM_phi()
        {
            InitializeComponent();
            angle = 1.61803398875f;
        }

        private void TB_angle_Scroll(object sender, EventArgs e)
        {
            angle = Convert.ToDouble((TB_angle.Value / 500f) * 1.61803398875);
            Text = "Golden Ratio - " + angle.ToString() + " rad";
            if (angle.ToString() == "1.61803398875")
            {
                PB_main.BackColor = Color.Green;
            }
            else
            {
                PB_main.BackColor = Color.Black;
            }
            PB_main.Refresh();
        }

        private void PB_main_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Point centre = new Point(PB_main.Width / 2, PB_main.Height / 2);
            int radius;
            double totAngle = 0;

            for (int i = 0; i < NOELLIPSE; i++)
            {
                radius = i * ELLIPSESIZE;
                int x = centre.X + Convert.ToInt32((radius / 30) * Math.Sin(totAngle));
                int y = centre.Y - Convert.ToInt32((radius / 30) * Math.Cos(totAngle));
                g.FillEllipse(new SolidBrush(Color.White), x, y, ELLIPSESIZE, ELLIPSESIZE);
                totAngle += angle;
            }
        }
    }
}
