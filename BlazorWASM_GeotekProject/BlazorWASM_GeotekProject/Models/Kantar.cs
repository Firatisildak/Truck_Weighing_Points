namespace BlazorWASM_GeotekProject.Models
{
    public class Kantar
    {
        public int KamyonKg { get; set; }
        public bool OnayDurum { get; set; }
        public Guid KamyonId { get; set; }
        public Kamyon Kamyon { get; set; }
    }
}
