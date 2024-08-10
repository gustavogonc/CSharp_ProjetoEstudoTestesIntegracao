namespace ProjetoEstudoTestes.Domain
{
    public sealed class Users : BaseEntity
    {
        public string Name { get; set; }
        public Guid Role { get; set; }
        public string? Email { get ; set; }  
        public string? PhoneNumber { get; set; }
    }
}
