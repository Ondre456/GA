using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cai2
{
    public class Individe : IComparable
    {
        public byte Genome { get; set; }
        public string ByteGenome => Convert.ToString(Genome, 2);

        public int Fitness => -Function.GetFitnessFunction(Genome);

        private double mutationRate = 0.4;

        public Individe()
        {
            var rnd = new Random();
            Genome = rnd.Next(-10, 53);
        }
        public Individe(int genome)
        {
            Genome = genome;
        }

        public void Mutate()
        {
            var rnd = new Random();
            if (rnd.NextDouble() < mutationRate)
            {
                if (rnd.NextDouble() >= 0.5)
                {
                    Genome += rnd.Next(1, 53 - Genome);
                }
                else
                {
                    Genome -= rnd.Next(1, 10 + Genome);
                }
            }
            //for (int i = 0; i < 128; i++)
            //{
            //    if (rnd.NextDouble() < mutationRate)
            //    {
            //        var mask = (int)Math.Pow(2, i);
            //        if ((mask & Genome) != 0)
            //        {
            //            if (!((Genome - mask) < -10) && !((Genome + mask) > 53))
            //            {
            //                Genome -= mask;
            //            }
            //        }
            //        else
            //        {
            //            if (!((Genome + mask) > 53) && !((Genome - mask) < -10))
            //            {
            //                Genome += mask;
            //            }
            //        }
            //    }
            //}
        }
        public static int Crossover(Individe a, Individe b)
        {
            int newGene = 0;
            int mask;
            var rnd = new Random();
            for (int i = 0; i < 128; i++)
            {
                mask = (int)Math.Pow(2, i);
                if ((mask & a.Genome) != 0)
                {
                    newGene += mask;
                }
                
            }
            return newGene;
        }
        public int CompareTo(object obj)
        {
            return Fitness.CompareTo((obj as Individe).Fitness);
        }
    }
}
