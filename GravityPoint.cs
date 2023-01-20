using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSystem_KulakovDA_ISTb_21_1
{
    public class GravityPoint : IImpactPoint
    {
        public int Power = 100;
        public bool checkBoxSubstrateCheck = false;
        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;
            float r2 = (float)Math.Max(100, gX * gX + gY * gY);

            particle.SpeedX += gX * Power / r2;
            particle.SpeedY += gY * Power / r2;
        }
        
        public override void Render(Graphics g)
        {
            // буду рисовать окружность с диаметром равным Power
            g.DrawEllipse(new Pen(Color.Red), X - Power / 2, Y - Power / 2, Power, Power);

            var stringFormat = new StringFormat(); // создаем экземпляр класса
            stringFormat.Alignment = StringAlignment.Center; // выравнивание по горизонтали
            stringFormat.LineAlignment = StringAlignment.Center; // выравнивание по вертикали

            // обязательно выносим текст и шрифт в переменные
            var text = $"Я гравитон\nc силой {Power}";
            var font = new Font("Verdana", 10);

            // вызываем MeasureString, чтобы померить размеры текста
            var size = g.MeasureString(text, font);

            if (Power > 0)
            {
                if (checkBoxSubstrateCheck)// рисуем подложнку под текст, условием
                {
                    g.FillRectangle(new SolidBrush(Color.Red), X - size.Width / 2, Y - size.Height / 2, size.Width, size.Height);
                }
                // ну и текст рисую уже на базе переменных
                g.DrawString(text, font, new SolidBrush(Color.White), X, Y, stringFormat);
            }
        }
    }
}