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

            for (var i = 0; i < 500; ++i)
            {
                var particle = new Particle();
                // ������� ������� � ����� �����������
                particle.X = picDisplay.Image.Width / 2;
                particle.Y = picDisplay.Image.Height / 2;
                particles.Add(particle); // ���������� � ������
            }
        }

        private void picDisplay_Click(object sender, EventArgs e)
        {

        }
        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.White);
                // ����� �� ����������� ������� ��������
                g.DrawString(
                    count.ToString(), // �������� �������� � ���� ������
                    new Font("Arial", 12), // �����
                    new SolidBrush(Color.Black), // ����
                    new PointF
                    { // �� ������ ������
                        X = picDisplay.Image.Width / 2,
                        Y = picDisplay.Image.Height / 2
                    }
                );
            }

            picDisplay.Invalidate(); //���������� �������
        }
    }
}