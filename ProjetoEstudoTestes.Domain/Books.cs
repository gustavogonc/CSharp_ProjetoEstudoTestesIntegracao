using Flunt.Validations;

namespace ProjetoEstudoTestes.Domain
{
    public sealed class Books : BaseEntity
    {
        public string Title { get; set; }   
        public string? Author { get; set; }  
        public string? IsbnCode { get; set; }   
        public int PublicationYear { get; set; }
        public int CopiesAvailable { get; set; } = 0;

        public Books()
        {
            
        }

        public Books(string title, string? author, string? isbnCode, int publicationYear, int copiesAvailable)
        {
            Title = title;
            Author = author;
            IsbnCode = isbnCode;
            PublicationYear = publicationYear;
            CopiesAvailable = copiesAvailable;
            EditedOn = DateTime.Now;
            DateTime = DateTime.Now;

            Validate();
        }

        private void Validate()
        {
            var contract = new Contract<Books>()
                .IsNotNullOrEmpty(Title, "Title", "Título do livro não pode estar vazio")
                .IsGreaterThan(Title, 3, "Title", "Título precisa ser maior que 3 caracteres")
                .IsGreaterThan(PublicationYear, 0, "PublicationYear", "Ano de publicação precisa ser maior que 0")
                .IsGreaterThan(CopiesAvailable, 0, "CopiesAvailable", "Quantidade de cópias precisa ser maior que 0");
                 

            AddNotifications(contract);
        }

        public void EditInfo(string title, string? author, string? isbnCode, int publicationYear, int copiesAvailable)
        {
            Title = title;
            Author = author;
            IsbnCode = isbnCode;
            PublicationYear = publicationYear;
            CopiesAvailable = copiesAvailable;
            EditedOn = DateTime.Now;

            Validate();
        }
    }
}
