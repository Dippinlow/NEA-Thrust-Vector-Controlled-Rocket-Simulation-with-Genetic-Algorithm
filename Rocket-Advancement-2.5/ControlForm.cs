using System.Diagnostics;
using System.Runtime.Intrinsics.Arm;
using System.Threading;

namespace Rocket_Advancement_2._5
{
    public partial class ControlForm : Form
    {
        public ControlForm()
        {
            InitializeComponent();
        }
        Color lightRed = Color.FromArgb(255, 255, 204, 203);
        Color lightGreen = Color.FromArgb(255, 144, 238, 144);
        private Rocket_Edit rocket_edit = new Rocket_Edit();

        private  StreamReader fileReader;
        private  StreamWriter fileWriter;
        private void ControlForm_Load(object sender, EventArgs e)
        {
            txt_gravity.Text = Convert.ToString(Sim_Data.GRAVITY);
            txt_pop_size.Text = Convert.ToString(Sim_Data.pop_size);
            txt_time.Text = Convert.ToString(Sim_Data.total_time);

            txt_ux_box.Text = Convert.ToString(Sim_Data.Initial_Velocity.x);
            txt_uy_box.Text = Convert.ToString(Sim_Data.Initial_Velocity.y);

            btn_landing.BackColor = lightRed;
            btn_reset.BackColor = lightRed;
            btn_move.BackColor = lightRed;
        }

        private void show_all_btn_Click(object sender, EventArgs e)
        {
            Sim_Data.SHOW_ALL = !Sim_Data.SHOW_ALL;
        }

        private void TimeWarpTrack_Scroll(object sender, EventArgs e)
        {
            Sim_Data.timeWarp = TimeWarpTrack.Value;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Sim_Data.population = new Population();
            Sim_Data.elapsed_time = 0;
            
        }

        private void btn_move_Click(object sender, EventArgs e)
        {
            Sim_Data.targetMoving = !Sim_Data.targetMoving;
            if (Sim_Data.targetMoving)
            {
                btn_move.BackColor = lightGreen;
            }
            else
            {
                btn_move.BackColor = lightRed;
            }
        }

        private void btn_landing_Click(object sender, EventArgs e)
        {
            Sim_Data.isLanding = !Sim_Data.isLanding;
            if (Sim_Data.isLanding)
            {
                btn_landing.BackColor = lightGreen;
            }
            else
            {
                btn_landing.BackColor = lightRed;
            }
        }

        private void txt_time_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ((char)Keys.Enter))
            {
                int tt = Sim_Data.total_time;
                try
                {
                    tt = Convert.ToInt16(txt_time.Text);
                }
                catch
                {
                }
                if (tt < 10)
                {
                    tt = 10;
                    txt_time.Text = "10";
                }
                else if (tt > 240)
                {
                    tt = 240;
                    txt_time.Text = "240";
                }
                Sim_Data.total_time = tt;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            fileWriter = new StreamWriter("data.txt");
            fileWriter.Write
                (   Sim_Data.WIDTH                 + "\n" +
                    Sim_Data.HEIGHT                + "\n" +
                    Sim_Data.FUEL_MASS             + "\n" +
                    Sim_Data.DRY_MASS              + "\n" +
                    Sim_Data.MAX_THRUST            + "\n" +
                    Sim_Data.THROTTLE_LIMIT        + "\n" +
                    Sim_Data.GIMBAL_RANGE          + "\n" +
                    Sim_Data.LINEAR_DRAG_CONSTANT  + "\n" +
                    Sim_Data.ANGULAR_DRAG_CONSTANT + "\n" +
                    Sim_Data.DEPLETION_RATE
                );
            fileWriter.Close();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            fileReader = new StreamReader("data.txt");
            btn_load.BackColor = Color.Green;

            try
            {
                Sim_Data.WIDTH = float.Parse(fileReader.ReadLine());
                Sim_Data.HEIGHT = float.Parse(fileReader.ReadLine());
                Sim_Data.FUEL_MASS = float.Parse(fileReader.ReadLine());
                Sim_Data.DRY_MASS = float.Parse(fileReader.ReadLine());
                Sim_Data.MAX_THRUST = float.Parse(fileReader.ReadLine());
                Sim_Data.THROTTLE_LIMIT = float.Parse(fileReader.ReadLine());
                Sim_Data.GIMBAL_RANGE = float.Parse(fileReader.ReadLine());
                Sim_Data.LINEAR_DRAG_CONSTANT = float.Parse(fileReader.ReadLine());
                Sim_Data.ANGULAR_DRAG_CONSTANT = float.Parse(fileReader.ReadLine());
                Sim_Data.DEPLETION_RATE = float.Parse(fileReader.ReadLine());
            }
            catch (Exception)
            {
                
                btn_load.BackColor = Color.Red;
            }
            fileReader.Close();
        }

        private void btn_rocket_edit_Click(object sender, EventArgs e)
        {
            rocket_edit.Close();
            rocket_edit = new Rocket_Edit();
            rocket_edit.Show();
        }


        private void txt_gravity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                float grv = Sim_Data.GRAVITY;
                try
                {
                    grv = float.Parse(txt_gravity.Text);
                    Debug.WriteLine(grv);
                }

                catch (Exception) { }

                Sim_Data.GRAVITY = grv;
            }
        }

        private void txt_pop_size_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                int size = Sim_Data.pop_size;
                try
                {
                    size = int.Parse(txt_pop_size.Text);
                }
                catch
                {

                }
                Sim_Data.pop_size = size;
            }
        }

        private void txt_uy_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                double ux = Sim_Data.Initial_Velocity.x;
                double uy = Sim_Data.Initial_Velocity.y;

                try
                {
                    uy = Convert.ToDouble(txt_uy_box.Text);
                }
                catch { }

                Sim_Data.Initial_Velocity = new Vector(ux, uy);
            }
        }

        private void txt_ux_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                double ux = Sim_Data.Initial_Velocity.x;
                double uy = Sim_Data.Initial_Velocity.y;

                try
                {
                    ux = Convert.ToDouble(txt_ux_box.Text);
                }
                catch { }

                Sim_Data.Initial_Velocity = new Vector(ux, uy);
            }
        }
    }
}
