using System.ComponentModel.DataAnnotations;

namespace InvestigatingEfCoreRelationship.Database.Entities
{
    internal sealed class Field
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        
    }
}
