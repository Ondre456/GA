using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cai2
{
    public class Population
    {
        public Individe[] Pop ; 
        public int PopulationCount;

        public Population Perhaps;
        public Population Next;

        public Population(int popCount)
        {
            PopulationCount = popCount;
            Pop = new Individe[PopulationCount];
            for (var i=0; i < Pop.Length; i++)
                Pop[i] = new Individe();
        }
        public Population(Individe[] pop)
        {
            PopulationCount = pop.Length;
            Pop = pop;
        }

        public Population NextPopulation() 
        {
            Array.Sort(Pop);
            var arr = new Individe[PopulationCount];
            for (int i = 0; i < PopulationCount; i++)
            {
                arr[i] = new Individe(Pop.Last().Genome);
            }
            var nextPop = new Population(arr);
            for (var i = 1; i < nextPop.Pop.Length; i++)
            {
                nextPop.Pop[i].Mutate();
            }
            nextPop.Perhaps = this;
            Next = nextPop;

            return nextPop;
        }
    }
}
