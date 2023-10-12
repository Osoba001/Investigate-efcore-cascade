using System.ComponentModel.DataAnnotations.Schema;

namespace InvestigatingEfCoreRelationship.Database.Entities
{
    internal class DrainagePoint
    {
        public Guid Id { get; set; }
        public required Guid WellId { get; set; }
        [ForeignKey(nameof(WellId))]
        public Well Well { get; set; }
        public required Guid ReservoirId { get; set; }
        [ForeignKey(nameof(ReservoirId))]
        public Reservoir Reservoir { get; set; }
        public required string StringCode { get; set; }
        
    }
}
