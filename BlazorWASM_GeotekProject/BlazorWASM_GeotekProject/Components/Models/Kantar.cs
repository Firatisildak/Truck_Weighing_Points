namespace BlazorWASM_GeotekProject.Components.Models
{
    public class Kantar
    {
        public Guid Id { get; set; }
        public int KamyonKg { get; set; }
        public bool OnayDurum { get; set; }
        public string Plaka { get; set; }
        public Kamyon Kamyon { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid KamyonId { get; set; }
    }
}
