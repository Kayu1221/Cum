using NitroxClient.Communication.Packets.Processors.Abstract;
using NitroxClient.GameLogic;
using NitroxModel.Packets;
using UWE;

namespace NitroxClient.Communication.Packets.Processors
{
    class CellEntitiesProcessor : ClientPacketProcessor<CellEntities>
    {
        private readonly Entities entities;

        public CellEntitiesProcessor(Entities entities)
        {
            this.entities = entities;
        }

        public override void Process(CellEntities packet)
        {
            CoroutineHost.StartCoroutine(entities.SpawnAsync(packet.Entities));
        }
    }
}
