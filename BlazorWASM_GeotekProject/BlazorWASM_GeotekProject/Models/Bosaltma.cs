namespace BlazorWASM_GeotekProject.Models
{
    public class Bosaltma
    {
        public Guid Id { get; set; }
        public bool BosaltmaDurumu { get; set; }
        public string Plaka { get; set; }
        public Kamyon Kamyon { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid KamyonId { get; set; }
    }
}
