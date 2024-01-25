using Verif_Optional.Models.Base;

namespace Verif_Optional.Models.Many_to_Many
{
    public class Model1 : BaseEntity
    {
        public string? Name { get; set; }

        public ICollection<AutoriCarti> AutoriCarti { get; set; }
    }
}
