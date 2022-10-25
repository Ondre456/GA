using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cai2
{
    public partial class Form1 : Form
    {
        int min = Function.GetMin();
        Population current;
        public Form1()
        {
            InitializeComponent();
            functionLabel.Text += Function.GetMin();
            this.chart1.Series[0].Points.Clear();
            for (int i = -10; i <= 53; i++)
            {
                this.chart1.Series[0].Points.AddXY(i, Function.GetFitnessFunction(i));
            }
            this.chart1.Series[1].Color = Color.Red;
        }

        private void Create_Click(object sender, EventArgs e)
        {
            current = new Population(int.Parse(numberOfPopulation.Text));
            populationGrid.DataSource = current.Pop;
            createGraph();
        }

        private void createGraph()
        {
            this.chart1.Series[1].Points.Clear();

            foreach (var e in current.Pop)
            {
                this.chart1.Series[1].Points.AddXY(e.Genome, -e.Fitness);
            }
        }

        private void Step_Click(object sender, EventArgs e)
        {
            current = current.NextPopulation();

            populationGrid.DataSource = current.Pop;

            createGraph();
        }

        private void Complete_Click(object sender, EventArgs e)
        {
            var fit = current.Pop[current.Pop.Length - 1].Genome;
            while (fit != min)
            {
                current = current.NextPopulation();
                Array.Sort(current.Pop);
                fit = current.Pop[current.Pop.Length-1].Genome;
                populationGrid.DataSource = current.Pop;
            }
        }

        private void Perhaps_Click(object sender, EventArgs e)
        {
            current = current.Perhaps;
            populationGrid.DataSource = current.Pop;
        }

        private void Next_Click(object sender, EventArgs e)
        {
            current = current.Next;
            populationGrid.DataSource = current.Pop;
        }
    }
}
