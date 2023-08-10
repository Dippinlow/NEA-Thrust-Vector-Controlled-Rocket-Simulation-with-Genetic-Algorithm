namespace Rocket_Advancement_2._5
{
    internal class PID_Controller
    {
        private double proportional, integral, derivative, output;
        private double max_output, min_output;
        private double current_error, past_error, delta_error;
        private Gain gains;

        public PID_Controller(Gain gains, double min_output, double max_output)
        {
            this.gains = gains;
            this.min_output = min_output;
            this.max_output = max_output;
            integral = 0;
        }

        public double Loop(double delta_time, double target, double position)
        {
            current_error = target - position;
            delta_error = current_error - past_error;
            past_error = current_error;
            proportional = current_error;
            integral += current_error * delta_time;
            derivative = delta_error / delta_time;

            output = gains.pg * proportional + gains.ig * integral + gains.dg * derivative;

            if (output > max_output) output = max_output;
            if (output < min_output) output = min_output;

            return output;
        }
    }
    struct Gain
    {
        public double pg;
        public double ig;
        public double dg;
    }
}
