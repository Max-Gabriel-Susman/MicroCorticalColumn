namespace MicroCorticalColumn
{
    class ChemicalSynapse : Synapse
    {
        ChemicalSynapse(string synapticId, string presynapticNeuronalId, string postSynapticNeuronalId)
        {
            SynapticId = synapticId;

            PreSynapticNeuronalId = presynapticNeuronalId;

            PostSynapticNeuronalId = postSynapticNeuronalId;
        }
    }
}