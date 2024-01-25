namespace Verif_Optional.Models.Base
{
    public interface IBaseEntity
    {
        Guid Id { get; set; }
        DateTime? DateTime { get; set; }
        DateTime? LastModified { get; set; }
    }
}
