 namespace Rocket_Advancement_2._5
{
    using System.Diagnostics;
    internal class Rocket : Sim_Data
    {
        public double ang, ang_vel, ang_acc, ang_drag, gimbal, mass, inertia, throttle, target_ang;
        public Vector pos, vel, acc, thrust, weight, lin_drag, moment, engine_output;
        private PID_Controller throttle_controller, angle_controller, gimbal_controller;
        private bool crashed;
        public Rocket(Gain throttle_gains, Gain angle_gains, Gain gimbal_gains)
        {
            mass = FUEL_MASS + DRY_MASS;

            pos = START;
            vel = Initial_Velocity;
            ang = 0;
            gimbal = 0;
            throttle = 1;
            crashed = false;

            throttle_controller = new PID_Controller(throttle_gains, THROTTLE_LIMIT, 1);
            angle_controller = new PID_Controller(angle_gains, -10, 10);
            gimbal_controller = new PID_Controller(gimbal_gains, -GIMBAL_RANGE, GIMBAL_RANGE);

        }
        public void Update(double delta_time)
        {
            if (!crashed)
            {  

                throttle = throttle_controller.Loop(delta_time, pos.y, TARGET.y);
                target_ang = angle_controller.Loop(delta_time, TARGET.x, pos.x);
                gimbal = gimbal_controller.Loop(delta_time, target_ang, 180 / Math.PI * ang);
                gimbal *= Math.PI / 180;

                engine_output = new Vector(0, MAX_THRUST * throttle);
                engine_output = engine_output.Rotate(gimbal);


                Linear_Motion(delta_time);
                Angular_Motion(delta_time);
                CheckBorders();

                if (mass > DRY_MASS)
                {
                    mass -= DEPLETION_RATE * throttle * delta_time;
                }
            }

        }

        private void Angular_Motion(double delta_time)
        {
            moment = new Vector(-engine_output.x * (HEIGHT / 2), 0);
            inertia = mass / 12 * (3 * Math.Pow(WIDTH/2, 2) + Math.Pow(HEIGHT, 2));

            ang_drag = ang_vel * ang_vel * ANGULAR_DRAG_CONSTANT * 0.5 * -1;

            ang_acc = (moment.x + ang_drag) / inertia;
            ang_vel += ang_acc * delta_time;
            ang += ang_vel * delta_time;
        }
        private void Linear_Motion(double delta_time)
        {
            weight = new Vector(0, mass * GRAVITY);
            thrust = new Vector(0, -engine_output.y);
            thrust = thrust.Rotate(ang);

            lin_drag = -vel;
            lin_drag = lin_drag.Normalise();
            lin_drag *= vel.Magnitude() * vel.Magnitude() * LINEAR_DRAG_CONSTANT * 0.5;

            acc = (thrust + weight + lin_drag) / mass;
            vel += acc * delta_time;
            pos += vel * delta_time;
        }
        private void CheckBorders()
        {
            if (isLanding)
            {
                if(pos.y > TARGET.y - HEIGHT / 2)
                {
                    crashed = true;
                }
            } 
        }

        public void Show(Graphics frame)
        {
            
            frame.TranslateTransform((float)pos.x, (float)pos.y);
            frame.RotateTransform((float)(180 / Math.PI * ang));
            Pen p = new Pen(Color.FromArgb(50, 255, 0, 0)) { Width = WIDTH };
            Brush b = new SolidBrush(Color.FromArgb(255, 0, 0, 0));
            
            frame.FillRectangle(b, -WIDTH / 2, -HEIGHT / 2, WIDTH, HEIGHT);
            frame.TranslateTransform(0, HEIGHT / 2);
            frame.RotateTransform((float)(180 / Math.PI * -gimbal));
            frame.DrawLine(p, 0, 0, 0, (float)(50 * throttle));
            frame.ResetTransform();
            
        }

    }
}
