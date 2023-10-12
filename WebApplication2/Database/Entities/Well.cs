using System.ComponentModel.DataAnnotations.Schema;

namespace InvestigatingEfCoreRelationship.Database.Entities
{
    internal sealed class Well
    {
        public Guid Id { get; set; }
        public required string WellCode { get; set; }
        public required Guid FieldId { get; set; }
        [ForeignKey(nameof(FieldId))]
        public Field Field { get; set; }
        public List<DrainagePoint> DraiangePoints { get; set; } = new();

       
    }
}
