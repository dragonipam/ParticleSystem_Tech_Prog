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

            /*for (var i = 0; i < 500; ++i) взрыв частиц в начале
            {
                var particle = new Particle();
                // перенос частицы в центр изображения
                particle.X = picDisplay.Image.Width / 2;
                particle.Y = picDisplay.Image.Height / 2;
                particles.Add(particle); // добавление в список
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
                    particle.Life = 20 + Particle.rand.Next(100); // это не трогаем
                                                                  // новое начальное расположение частицы — это то, куда указывает курсор
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
                if (particles.Count < 500) // пока частиц меньше 500 генерируем новые
                {
                    var particle = new Particle();
                    particle.X = MousePositionX;
                    particle.Y = MousePositionY;
                    particles.Add(particle);
                }
                else
                {
                    break; // а если частиц уже 500 штук, то ничего не генерирую
                }
            }
        }

        // функция рендеринга
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
            UpdateState(); // каждый тик обновляем систему

            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.White);
                Render(g); // рендерим систему
            }

            /*
                g.DrawString(count.ToString(), new Font("Arial", 12), new SolidBrush(Color.Black), new PointF{X = picDisplay.Image.Width / 2, Y = picDisplay.Image.Height / 2});
                Данная строка выводит значения таймера в центре экрана
            */
            picDisplay.Invalidate(); //обновление дисплея
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