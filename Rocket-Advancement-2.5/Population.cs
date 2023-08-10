using System.Diagnostics;


namespace Rocket_Advancement_2._5
{
    internal class Population : Sim_Data
    {
        private Creature[] creatures;
        private Random rng;
        public int genCount = 1;
        private int lastSurvivorIndex;
        public Population()
        {
            rng = new Random();
            creatures = new Creature[pop_size];
            lastSurvivorIndex = (int)Math.Floor(pop_size * 0.1f);

            for (int i = 0; i < creatures.Length; i++)
            {
                creatures[i] = new Creature();
                creatures[i].total_error = 0;

                creatures[i].throttle_chromosome.pg = rng.NextDouble();
                creatures[i].throttle_chromosome.ig = 0;
                creatures[i].throttle_chromosome.dg = rng.NextDouble();

                creatures[i].angle_chromosome.pg = rng.NextDouble();
                creatures[i].angle_chromosome.ig = 0;
                creatures[i].angle_chromosome.dg = rng.NextDouble();

                creatures[i].gimbal_chromosome.pg = rng.NextDouble();
                creatures[i].gimbal_chromosome.ig = 0;
                creatures[i].gimbal_chromosome.dg = rng.NextDouble();

                creatures[i].rocket = new Rocket(creatures[i].throttle_chromosome, creatures[i].angle_chromosome, creatures[i].gimbal_chromosome);
            }
        }
        public void Update(double delta_time)
        {
            for (int i = 0; i < creatures.Length; i++)
            {
                creatures[i].rocket.Update(delta_time);
                if (!isLanding)
                {
                    double dx = creatures[i].rocket.pos.x - TARGET.x;
                    double dy = creatures[i].rocket.pos.y - TARGET.y;
                    double ang = 180 / Math.PI * Math.Abs(creatures[i].rocket.ang);
                    creatures[i].total_error += (Math.Sqrt(dx * dx + dy * dy) + ang) * elapsed_time;
                }
            }
        }
        public void Show(Graphics graphics)
        {
            if (SHOW_ALL)
            {
                for (int i = 0; i < creatures.Length; i++)
                {
                    creatures[i].rocket.Show(graphics);
                }

                Pen p = new (Color.Green);
                graphics.DrawEllipse(p, (float)creatures[0].rocket.pos.x - 10, (float)creatures[0].rocket.pos.y - 10, 20, 20);
            }
            else
            {
                creatures[0].rocket.Show(graphics);
            }

        }
        public void Sort()
        {
            if (isLanding) { 
                for (int i = 0; i < creatures.Length; i++)
                {
                    double dx = creatures[i].rocket.pos.x - TARGET.x;
                    double dy = creatures[i].rocket.pos.y - TARGET.y;

                    creatures[i].total_error = Math.Sqrt(dx * dx + dy * dy);
                    creatures[i].total_error += creatures[i].rocket.vel.Magnitude();
                    creatures[i].total_error += 180 / Math.PI * Math.Abs(creatures[i].rocket.ang);

                    if (creatures[i].rocket.pos.y < TARGET.y - HEIGHT / 2)
                    {
                        creatures[i].total_error = 10000000000;
                    }
                }
            }
            sortCreatures();
        }
        public void Crossover_Mutation()
        {
            genCount++;

            for (int i = lastSurvivorIndex; i < creatures.Length; i++)
            {
                Creature parentA = creatures[rng.Next(lastSurvivorIndex, creatures.Length)];
                Creature parentB = creatures[rng.Next(lastSurvivorIndex, creatures.Length)];

                creatures[i] = parentA;

                // CROSSOVER!!!!!
                if (rng.NextDouble() > .5) creatures[i].throttle_chromosome.pg = parentB.throttle_chromosome.pg;
                if (rng.NextDouble() > .5) creatures[i].throttle_chromosome.ig = parentB.throttle_chromosome.ig;
                if (rng.NextDouble() > .5) creatures[i].throttle_chromosome.dg = parentB.throttle_chromosome.dg;

                if (rng.NextDouble() > .5) creatures[i].angle_chromosome.pg = parentB.angle_chromosome.pg;
                if (rng.NextDouble() > .5) creatures[i].angle_chromosome.ig = parentB.angle_chromosome.ig;
                if (rng.NextDouble() > .5) creatures[i].angle_chromosome.dg = parentB.angle_chromosome.dg;

                if (rng.NextDouble() > .5) creatures[i].gimbal_chromosome.pg = parentB.gimbal_chromosome.pg;
                if (rng.NextDouble() > .5) creatures[i].gimbal_chromosome.ig = parentB.gimbal_chromosome.ig;
                if (rng.NextDouble() > .5) creatures[i].gimbal_chromosome.dg = parentB.gimbal_chromosome.dg;

                // MUTATION!!!!!
                if(rng.NextDouble() < .25) creatures[i].throttle_chromosome.pg += (rng.NextDouble() - 0.5) * .1;
                if(rng.NextDouble() < .25) creatures[i].throttle_chromosome.ig += (rng.NextDouble() - 0.5) * .01;
                if(rng.NextDouble() < .25) creatures[i].throttle_chromosome.dg += (rng.NextDouble() - 0.5) * .1;

                if(rng.NextDouble() < .25) creatures[i].angle_chromosome.pg += (rng.NextDouble() - 0.5) * .1;
                if(rng.NextDouble() < .25) creatures[i].angle_chromosome.ig += (rng.NextDouble() - 0.5) * .01;
                if(rng.NextDouble() < .25) creatures[i].angle_chromosome.dg += (rng.NextDouble() - 0.5) * .1;

                if(rng.NextDouble() < .25) creatures[i].gimbal_chromosome.pg += (rng.NextDouble() - 0.5) * .1;
                if(rng.NextDouble() < .25) creatures[i].gimbal_chromosome.ig += (rng.NextDouble() - 0.5) * .01;
                if(rng.NextDouble() < .25) creatures[i].gimbal_chromosome.dg += (rng.NextDouble() - 0.5) * .1;

                // NO NEGATIVES ALLOWED!!!!
                if (creatures[i].throttle_chromosome.pg < 0) creatures[i].throttle_chromosome.pg *= -1;
                if (creatures[i].throttle_chromosome.ig < 0) creatures[i].throttle_chromosome.ig *= -1;
                if (creatures[i].throttle_chromosome.dg < 0) creatures[i].throttle_chromosome.dg *= -1;

                if (creatures[i].angle_chromosome.pg < 0) creatures[i].angle_chromosome.pg *= -1;
                if (creatures[i].angle_chromosome.ig < 0) creatures[i].angle_chromosome.ig *= -1;
                if (creatures[i].angle_chromosome.dg < 0) creatures[i].angle_chromosome.dg *= -1;

                if (creatures[i].gimbal_chromosome.pg < 0) creatures[i].gimbal_chromosome.pg *= -1;
                if (creatures[i].gimbal_chromosome.ig < 0) creatures[i].gimbal_chromosome.ig *= -1;
                if (creatures[i].gimbal_chromosome.dg < 0) creatures[i].gimbal_chromosome.dg *= -1;
            }
        }
        public void Restart()
        {
            Debug.WriteLine($"\nGENERATION NUMBER: {genCount}\n");

            Debug.WriteLine($"\nThrottle pg:{creatures[0].throttle_chromosome.pg} " +
                                       $"ig:{creatures[0].throttle_chromosome.ig} " +
                                       $"dg:{creatures[0].throttle_chromosome.dg}");

            Debug.WriteLine($"Angle    pg:{creatures[0].angle_chromosome.pg} " +
                                     $"ig:{creatures[0].angle_chromosome.ig} " +
                                     $"dg:{creatures[0].angle_chromosome.dg}");

            Debug.WriteLine($"Gimbal   pg:{creatures[0].gimbal_chromosome.pg} " +
                                     $"ig:{creatures[0].gimbal_chromosome.ig} " +
                                     $"dg:{creatures[0].gimbal_chromosome.dg}");

            for (int i = 0; i < creatures.Length; i++)
            {
                creatures[i].total_error = 0;
                creatures[i].rocket = new Rocket(creatures[i].throttle_chromosome, creatures[i].angle_chromosome, creatures[i].gimbal_chromosome);
            }
        }

        private struct Creature
        {
            public Rocket rocket;
            public double total_error;
            public Gain throttle_chromosome;
            public Gain angle_chromosome;
            public Gain gimbal_chromosome;

        }

        private void sortCreatures()
        {
            List<Creature> creatureList = creatures.ToList();
            creatures = mergeSort(creatureList).ToArray();
        }

        static List<Creature> mergeSort(List<Creature> list)
        {
            if (list.Count <= 1) return list;

            List<Creature> l1 = new List<Creature>();
            List<Creature> l2 = new List<Creature>();

            for (int i = 0; i < list.Count / 2; i++) l1.Add(list[i]);
            for (int i = list.Count / 2; i < list.Count; i++) l2.Add(list[i]);

            l1 = mergeSort(l1);
            l2 = mergeSort(l2);

            return merge(l1, l2);
        }
        static List<Creature> merge(List<Creature> listA, List<Creature> listB)
        {
            List<Creature> listC = new List<Creature>();
            while (listA.Count > 0 && listB.Count > 0)
            {
                if (listA[0].total_error > listB[0].total_error)
                {
                    listC.Add(listB[0]);
                    listB.RemoveAt(0);
                }
                else
                {
                    listC.Add(listA[0]);
                    listA.RemoveAt(0);
                }
            }
            while (listA.Count > 0)
            {
                listC.Add(listA[0]);
                listA.RemoveAt(0);
            }
            while (listB.Count > 0)
            {
                listC.Add(listB[0]);
                listB.RemoveAt(0);
            }
            return listC;
        }
    }
}
