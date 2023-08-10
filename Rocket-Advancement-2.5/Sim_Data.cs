using System.Diagnostics;

namespace Rocket_Advancement_2._5
{
    internal class Sim_Data
    {
        // Scene Properties
        public static float GRAVITY = 9.81f;
        public static Size SCENE = new (700, 700);
        public static Vector START = new Vector(SCENE.Width / 4, SCENE.Height - SCENE.Height / 4);
        public static Vector TARGET = new Vector(SCENE.Width / 2, SCENE.Height / 2);
        public static Vector Initial_Velocity = new Vector(0, 0);
        public static bool SHOW_ALL = false;
        public static bool isLanding = false;
        public static bool targetMoving = false;
        public static Stopwatch timer = new Stopwatch();
        public static int total_time = 60;
        public static double elapsed_time;
        public static int timeWarp = 1;
        public static int pop_size = 750;
        public static Population population;

        // Rocket Properties
        public static float WIDTH = 5;
        public static float HEIGHT = 50;
        public static float FUEL_MASS = 100;
        public static float DRY_MASS = 1;
        public static float MAX_THRUST = 2000;
        public static float THROTTLE_LIMIT = .3f;
        public static float GIMBAL_RANGE = 15f;
        public static float LINEAR_DRAG_CONSTANT = .5f;
        public static float ANGULAR_DRAG_CONSTANT = .5f;
        public static float DEPLETION_RATE = 0f;

    }


}
    