using Microsoft.EntityFrameworkCore;
//Configuraçãop banco de dados
//1-Instalar blibliotecas
//2-Cria a classe de dados
//3- Criar herança com biblioteca
//4-Indicar as classes de modelo que vão virar tabelas no banco
//5- Sobrescrever o metodo de configuração, com banco utilizando e a string de conexão


public class AppDataContext : DbContext
{
    public DbSet <Produto>TabelaProdutos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=Ecommerce.db");
    }
}