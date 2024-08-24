namespace ProjetoEstudoTestes.Repositories.BooksRepository
{
    public interface IBookRepository
    {
        IQueryable ListBooksAsync();
    }
}
