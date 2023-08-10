

namespace Rocket_Advancement_2._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ClientSize = Sim_Data.SCENE;
        }
        
        ControlForm cf;
        bool draggingTarget;
        bool draggingStart;

        private double delta_time, current_time, past_time;
        private void Form1_Load(object sender, EventArgs e)
        {
            Sim_Data.timer.Start();

            Sim_Data.elapsed_time = 0;
            Sim_Data.population = new Population();

            cf = new ControlForm();
            cf.Show();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            draggingStart = false;
            draggingTarget = false;
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (Math.Abs(e.X - Sim_Data.TARGET.x) <= 8 && Math.Abs(e.Y - Sim_Data.TARGET.y) <= 8)
            {
                draggingTarget = true;
            }
            else if (Math.Abs(e.X - Sim_Data.START.x) <= 8 && Math.Abs(e.Y - Sim_Data.START.y) <= 8)
            {
                draggingStart = true;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (draggingTarget)
            {
                Sim_Data.TARGET = new Vector(e.X, e.Y);

                if (Sim_Data.TARGET.x < 0) Sim_Data.TARGET = new Vector(0, Sim_Data.TARGET.y);
                if (Sim_Data.TARGET.x > Sim_Data.SCENE.Width) Sim_Data.TARGET = new Vector(Sim_Data.SCENE.Width, Sim_Data.TARGET.y);

                if (Sim_Data.TARGET.y < 0) Sim_Data.TARGET = new Vector(Sim_Data.TARGET.x, 0);
                if (Sim_Data.TARGET.y > Sim_Data.SCENE.Height) Sim_Data.TARGET = new Vector(Sim_Data.TARGET.x, Sim_Data.SCENE.Height);

            } else if (draggingStart)
            {
                Sim_Data.START = new Vector(e.X, e.Y);

                if (Sim_Data.START.x < 0) Sim_Data.START = new Vector(0, Sim_Data.START.y);
                if (Sim_Data.START.x > Sim_Data.SCENE.Width) Sim_Data.START = new Vector(Sim_Data.SCENE.Width, Sim_Data.START.y);

                if (Sim_Data.START.y < 0) Sim_Data.START = new Vector(Sim_Data.START.x, 0);
                if (Sim_Data.START.y > Sim_Data.SCENE.Height) Sim_Data.START = new Vector(Sim_Data.START.x, Sim_Data.SCENE.Height);
            }
        }



        private void physics_timer_Tick(object sender, EventArgs e)
        {
            current_time = Sim_Data.timer.Elapsed.TotalSeconds;
            delta_time = (current_time - past_time) * Sim_Data.timeWarp;
            Sim_Data.elapsed_time += delta_time;
            past_time = current_time;

            Sim_Data.population.Update(delta_time);

            if (Sim_Data.elapsed_time > Sim_Data.total_time)
            {
                Sim_Data.timer.Restart();
                Sim_Data.elapsed_time = 0;
                past_time = 0;
                Sim_Data.population.Sort();
                Sim_Data.population.Crossover_Mutation();
                Sim_Data.population.Restart();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Sim_Data.population.Show(e.Graphics);
            Brush b;

            if (Sim_Data.isLanding)
            {
                b = new SolidBrush(Color.Green);
                int x1 = 0;
                int x2 = Sim_Data.SCENE.Width;
                int y1 = (int)Sim_Data.TARGET.y;
                int y2 = (int)(Sim_Data.SCENE.Height - Sim_Data.TARGET.y);
                e.Graphics.FillRectangle(b, x1, y1, x2, y2);

                b = new SolidBrush(Color.Gray);
                e.Graphics.FillRectangle(b, (int)Sim_Data.TARGET.x - 40, (int)Sim_Data.TARGET.y-5, 80, 20);
            }
            if (!Sim_Data.isLanding) { 
                b = new SolidBrush(Color.Red);
                e.Graphics.FillEllipse(b, (float)Sim_Data.TARGET.x - 8, (float)Sim_Data.TARGET.y - 8, 16, 16);

                if (Sim_Data.targetMoving)
                {
                    double x = Sim_Data.SCENE.Width  / 2 + Math.Sin(Sim_Data.elapsed_time / 20) * Sim_Data.SCENE.Width  / 4;
                    double y = Sim_Data.SCENE.Height / 2 + Math.Cos(Sim_Data.elapsed_time / 20) * Sim_Data.SCENE.Height / 4;
                    Sim_Data.TARGET = new Vector(x, y);
                }

            }

            b = new SolidBrush(Color.Blue);
            e.Graphics.FillEllipse(b, (float)Sim_Data.START.x - 8, (float)Sim_Data.START.y - 8, 16, 16);


            label1.Text = $"Reset T-{Sim_Data.total_time - Math.Truncate(Sim_Data.elapsed_time)}s";
            label2.Text = $"generation: {Sim_Data.population.genCount}";
        }

        private void frame_timer_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }
        private void Form1_ClientSizeChanged(object sender, EventArgs e)
        {
            Sim_Data.SCENE = ClientSize;

            if (Sim_Data.TARGET.x < 0) Sim_Data.TARGET = new Vector(0, Sim_Data.TARGET.y);
            if (Sim_Data.TARGET.x > Sim_Data.SCENE.Width) Sim_Data.TARGET = new Vector(Sim_Data.SCENE.Width, Sim_Data.TARGET.y);

            if (Sim_Data.TARGET.y < 0) Sim_Data.TARGET = new Vector(Sim_Data.TARGET.x, 0);
            if (Sim_Data.TARGET.y > Sim_Data.SCENE.Height) Sim_Data.TARGET = new Vector(Sim_Data.TARGET.x, Sim_Data.SCENE.Height);

            if (Sim_Data.START.x < 0) Sim_Data.START = new Vector(0, Sim_Data.START.y);
            if (Sim_Data.START.x > Sim_Data.SCENE.Width) Sim_Data.START = new Vector(Sim_Data.SCENE.Width, Sim_Data.START.y);

            if (Sim_Data.START.y < 0) Sim_Data.START = new Vector(Sim_Data.START.x, 0);
            if (Sim_Data.START.y > Sim_Data.SCENE.Height) Sim_Data.START = new Vector(Sim_Data.START.x, Sim_Data.SCENE.Height);
        }
    }
}