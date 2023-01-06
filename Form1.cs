using System.Diagnostics.Metrics;

namespace ParticleSystem_KulakovDA_ISTb_21_1
{
    public partial class Form1 : Form
    {
        List<Particle> particles = new List<Particle>(); // пустой список для частиц
        public Form1()
        {
            InitializeComponent();

            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);

            for (var i = 0; i < 500; ++i)
            {
                var particle = new Particle();
                // перенос частицы в центр изображения
                particle.X = picDisplay.Image.Width / 2;
                particle.Y = picDisplay.Image.Height / 2;
                particles.Add(particle); // добавление в список
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
                // рисую на изображении сколько насчитал
                g.DrawString(
                    count.ToString(), // значения счетчика в виде строки
                    new Font("Arial", 12), // шрифт
                    new SolidBrush(Color.Black), // цвет
                    new PointF
                    { // по центру экрана
                        X = picDisplay.Image.Width / 2,
                        Y = picDisplay.Image.Height / 2
                    }
                );
            }

            picDisplay.Invalidate(); //обновление дисплея
        }
    }
}