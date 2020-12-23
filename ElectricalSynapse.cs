namespace MicroCorticalColumn
{
    class ElectricalSynapse : Synapse 
    {
        ElectricalSynapse(string synapticId, string presynapticNeuronalId, string postSynapticNeuronalId)
        {
            SynapticId = synapticId;

            PreSynapticNeuronalId = presynapticNeuronalId;

            PostSynapticNeuronalId = postSynapticNeuronalId;
        }
    }
}