namespace ParticleSystem_KulakovDA_ISTb_21_1
{
    public partial class Form1 : Form
    {
        List<Emitter> emitters = new List<Emitter>();
        Emitter emitter;

        GravityPoint point1; // ������� ���� ��� ������ �����
        GravityPoint point2; // ������� ���� ��� ������ �����

        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);

            this.emitter = new Emitter // ������ ������� � ���������� ��� � ���� emitter
            {
                Direction = 0,
                Spreading = 10,
                SpeedMin = 10,
                SpeedMax = 10,
                ColorFrom = Color.Gold,
                ColorTo = Color.FromArgb(0, Color.Red),
                ParticlesPerTick = 10,
                X = picDisplay.Width / 2,
                Y = picDisplay.Height / 2,
            };

            emitters.Add(this.emitter);

            // ����������� ��������� � �����
            point1 = new GravityPoint
            {
                X = picDisplay.Width / 2 + 100,
                Y = picDisplay.Height / 2,
            };
            point2 = new GravityPoint
            {
                X = picDisplay.Width / 2 - 100,
                Y = picDisplay.Height / 2,
            };

            // ����������� ���� � ��������
            emitter.impactPoints.Add(point1);
            emitter.impactPoints.Add(point2);

        }

        private void picDisplay_Click(object sender, EventArgs e)
        {

        }

        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            emitter.UpdateState(); // ��� ������ ��������� �������

            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.Black);
                emitter.Render(g); // � ��� ������ �������� ����� �������
            }
            picDisplay.Invalidate();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void picDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (var emitter in emitters)
            {
                emitter.MousePositionX = e.X;
                emitter.MousePositionY = e.Y;
            }

            point2.X = e.X;
            point2.Y = e.Y;
        }

        private void tbDirection_Scroll(object sender, EventArgs e)
        {
            emitter.Direction = tbDirection.Value;
            lblDirection1.Text = $"{tbDirection.Value}�";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void tbGraviton_Scroll(object sender, EventArgs e)
        {
            point1.Power = tbGraviton1.Value;
            lblGravitation1.Text = $"{tbGraviton1.Value}�";
        }

        private void tbGraviton2_Scroll(object sender, EventArgs e)
        {
            point2.Power = tbGraviton2.Value;
            lblGravitation2.Text = $"{tbGraviton2.Value}�";
        }

        private void Substrate_CheckedChanged(object sender, EventArgs e)
        {
            if (substrateCheckBox.Checked)
            {
                point1.checkBoxSubstrateCheck = true;
                point2.checkBoxSubstrateCheck = true;
            }
            else
            {
                point1.checkBoxSubstrateCheck = false;
                point2.checkBoxSubstrateCheck = false;
            }
        }
    }
}