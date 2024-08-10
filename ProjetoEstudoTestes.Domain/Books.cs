namespace ProjetoEstudoTestes.Domain
{
    public sealed class Books : BaseEntity
    {
        public string Title { get; set; }   
        public string? Author { get; set; }  
        public string? IsbnCode { get; set; }   
        public int PublicationYear { get; set; }
        public int CopiesAvailable { get; set; } = 0;
    }
}
