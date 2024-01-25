namespace Verif_Optional.Models.Many_to_Many
{
    public class AutoriCarti
    {
        public Guid Model1Id { get; set; }
        public Model1 Model1 { get; set; }

        public Guid Model2Id { get; set; }
        public Model2 Model2 { get; set; }
    }
}
