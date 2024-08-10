namespace ProjetoEstudoTestes.Domain
{
    public sealed class Loans : BaseEntity
    {
        public List<Books> Books { get; set; } = new List<Books>();  
        public List<Users> Users { get; set; } = new List<Users>();
        public DateTime LoanDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public DateTime? ActualReturnDate { get; set; }
    }
}
