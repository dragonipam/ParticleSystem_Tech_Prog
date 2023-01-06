using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSystem_KulakovDA_ISTb_21_1
{
    class Particle // Класс частицы
    {
        public int Radius; // радуис
        public float X; // X координата частицы
        public float Y; // Y координата частицы

        public float Direction; // направление движения частицы
        public float Speed; // скорость перемещения частицы

        // добавили генератор случайных чисел
        public static Random rand = new Random();

        public float Life; // запас здоровья частицы

        // конструктор по умолчанию будет создавать кастомную частицу
        public Particle()
        {
            // я не трогаю координаты X, Y потому что хочу, чтобы все частицы возникали из одного места
            Direction = rand.Next(360);
            Speed = 1 + rand.Next(10);
            Radius = 2 + rand.Next(10);
            Life = 20 + rand.Next(100);
        }

        public void Draw(Graphics g)
        {
            // рассчитываем коэффициент прозрачности по шкале от 0 до 1.0
            float k = Math.Min(1f, Life / 100);
            // рассчитываем значение альфа канала в шкале от 0 до 255
            // по аналогии с RGB, он используется для задания прозрачности
            int alpha = (int)(k * 255);

            // создаем цвет из уже существующего, но привязываем к нему еще и значение альфа канала
            var color = Color.FromArgb(alpha, Color.Black);
            var b = new SolidBrush(color);

            // остальное все так же
            g.FillEllipse(b, X - Radius, Y - Radius, Radius * 2, Radius * 2);

            b.Dispose();
        }
    }
}
