using System.Collections.Generic;

namespace MicroCorticalColumn
{
    abstract class Neuron 
    {
        // Neuron(string id, string columnId)
        // {
        //     Id = id;

        //     ColumnId = columnId;

        //     MembranPotential = 0.0;


        // }

        public string Id { get; }

        public string ColumnId { get; }

        public double MembranPotential { get; set; } // can I make this unsigned? I think I should

        // public List<(string, double)> 

        // what are synapses referred to as when possessed by the subject neuron and vice-versa?

        // I need to figure out what the quality is caled in neurons where they may be exitatory or inhibatory
    }
}