﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSystem_KulakovDA_ISTb_21_1
{
    public class Particle // Класс частицы
    {
        public int Radius; // радуис
        public float X; // X координата частицы
        public float Y; // Y координата частицы

        public float SpeedX; // скорость перемещения по оси X
        public float SpeedY; // скорость перемещения по оси Y

        // добавили генератор случайных чисел
        public static Random rand = new Random();

        public float Life; // запас здоровья частицы

        // конструктор по умолчанию будет создавать кастомную частицу
        public Particle()
        {
            // генерируем произвольное направление и скорость
            var direction = (double)rand.Next(360);
            var speed = 1 + rand.Next(10);

            // рассчитываем вектор скорости
            SpeedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed);
            SpeedY = -(float)(Math.Sin(direction / 180 * Math.PI) * speed);

            Radius = 2 + rand.Next(10);
            Life = 20 + rand.Next(100);
        }

        public virtual void Draw(Graphics g)
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

        public class ParticleColorful : Particle
        {
            // два новых поля под цвет начальный и конечный
            public Color FromColor;
            public Color ToColor;

            // для смеси цветов
            public static Color MixColor(Color color1, Color color2, float k)
            {
                return Color.FromArgb(
                    (int)(color2.A * k + color1.A * (1 - k)),
                    (int)(color2.R * k + color1.R * (1 - k)),
                    (int)(color2.G * k + color1.G * (1 - k)),
                    (int)(color2.B * k + color1.B * (1 - k))
                );
            }

            // ну и отрисовку перепишем
            public override void Draw(Graphics g)
            {
                float k = Math.Min(1f, Life / 100);

                // так как k уменьшается от 1 до 0, то порядок цветов обратный
                var color = MixColor(ToColor, FromColor, k);
                var b = new SolidBrush(color);

                g.FillEllipse(b, X - Radius, Y - Radius, Radius * 2, Radius * 2);

                b.Dispose();
            }
        }

    }
}
