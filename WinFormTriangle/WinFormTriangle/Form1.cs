namespace WinFormTriangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.IndianRed, 4);
            int x1 = 100;
            int y1 = 100;
            int x2 = 300;
            int y2 = 100;
            int x3 = 300;
            int y3 = 300;
            for (int i = 101 - 1; i >= 0; i-=10)
            {
                g.DrawLine(p, x1+i, y1+i, x2-i, y2+i);
                g.DrawLine(p, x1+i, y1+i, x1+i, y3-i);
                g.DrawLine(p, x1+i, y3-i, x2-i, y3-i);
                g.DrawLine(p, x2-i, y2+i, x2-i, y3-i);
            }
            base.OnPaint(e);
        }
    }
}
