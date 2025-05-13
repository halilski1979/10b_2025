using System.Drawing;

namespace OnPaint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.BackColor = Color.Black;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int a = 256, freq = 10;
            Random c = new Random();
            for (int i = 1; i <= 40; i++)
            {
                g.Clear(Color.FromArgb(c.Next() % a, c.Next() % a, c.Next() % a));
               
            }
        }



    }
}
