using Verif_Optional.Models.Base;

namespace Verif_Optional.Models.One_to_Many
{
    public class Model3 : BaseEntity
    {
        public string? Name { get; set; }


        public ICollection<Model4> Model4 { get; set; }
    }
}
