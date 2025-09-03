namespace biblioteca.Models
{
    public class Usuario
    {
        public int id { get; set; }
        public string? nome { get; set; }
        public string? email { get; set; }
        public string? senha_hash { get; set; }
        public string? role { get; set; }
        public Int16 ativo { get; set; }
        public DateTime criado_em { get; set; }

    }
}
