using SQLite;
namespace MauiAppMinhasCompras.Models
{
    public class Produto
    {
        string _descricao;
        double _valor;

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Descricao
        {
            get => _descricao;
            set
            {
                if (value == null)
                {
                    throw new Exception("Por favor, preencha a Descrição");
                }

                _descricao = value;
            }
        }
        public double Quantidade
        {
            get => _valor;
            set
            {
                if (value == 0)
                {
                    throw new Exception("Por favor, preencha a Quantidade");
                }

                _valor = value;
            }
        }
        public double Preco
        {
            get => _valor;
            set
            {
                if (value == 0)
                {
                    throw new Exception("Por favor, preencha o Preço");
                }
            }
        }

        public double Total { get => Quantidade * Preco; }
    }
};