using System.Diagnostics.Metrics;

namespace ParticleSystem_KulakovDA_ISTb_21_1
{
    public partial class Form1 : Form
    {
        List<Particle> particles = new List<Particle>(); // ������ ������ ��� ������
        public Form1()
        {
            InitializeComponent();

            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);

            /*for (var i = 0; i < 500; ++i) ����� ������ � ������
            {
                var particle = new Particle();
                // ������� ������� � ����� �����������
                particle.X = picDisplay.Image.Width / 2;
                particle.Y = picDisplay.Image.Height / 2;
                particles.Add(particle); // ���������� � ������
            }
            */
        }

        private void picDisplay_Click(object sender, EventArgs e)
        {

        }
        private void UpdateState()
        {
            foreach (var particle in particles)
            {
                particle.Life -= 1;
                if (particle.Life < 0)
                {
                    particle.X = MousePositionX;
                    particle.Y = MousePositionY;
                    particle.Life = 20 + Particle.rand.Next(100); // ��� �� �������
                                                                  // ����� ��������� ������������ ������� � ��� ��, ���� ��������� ������
                    particle.Direction = Particle.rand.Next(360);
                    particle.Speed = 1 + Particle.rand.Next(10);
                    particle.Radius = 2 + Particle.rand.Next(10);
                }
                else
                {
                    var directionInRadians = particle.Direction / 180 * Math.PI;
                    particle.X += (float)(particle.Speed * Math.Cos(directionInRadians));
                    particle.Y -= (float)(particle.Speed * Math.Sin(directionInRadians));
                }
            }
            for (var i = 0; i < 10; ++i)
            {
                if (particles.Count < 500) // ���� ������ ������ 500 ���������� �����
                {
                    var particle = new Particle();
                    particle.X = MousePositionX;
                    particle.Y = MousePositionY;
                    particles.Add(particle);
                }
                else
                {
                    break; // � ���� ������ ��� 500 ����, �� ������ �� ���������
                }
            }
        }

        // ������� ����������
        private void Render(Graphics g)
        {
            foreach (var particle in particles)
            {
                particle.Draw(g);
            }
        }

        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateState(); // ������ ��� ��������� �������

            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.White);
                Render(g); // �������� �������
            }

            /*
                g.DrawString(count.ToString(), new Font("Arial", 12), new SolidBrush(Color.Black), new PointF{X = picDisplay.Image.Width / 2, Y = picDisplay.Image.Height / 2});
                ������ ������ ������� �������� ������� � ������ ������
            */
            picDisplay.Invalidate(); //���������� �������
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private int MousePositionX = 0;
        private int MousePositionY = 0;

        private void picDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            MousePositionX = e.X;
            MousePositionY = e.Y;
        }
    }
}