using Verif_Optional.Models.Base;

namespace Verif_Optional.Models.One_to_Many
{
    public class Model4 : BaseEntity
    {
        public string? Name { get; set; }

        public Model3 Model3 { get; set; }

        public Guid Model3Id { get; set; }
    }
}
