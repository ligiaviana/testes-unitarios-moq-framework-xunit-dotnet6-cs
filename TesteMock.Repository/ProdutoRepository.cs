using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteMock.Models.Entities;
using TesteMock.Repository.Interfaces;

namespace TesteMock.Repository
{
    internal class ProdutoRepository : IProdutoRepository
    {
        public Produto AddProduto(int id, string nome, string codigo)
        {
            StreamWriter file = new StreamWriter("./produto.txt", true);
            file.WriteLine($"{id}; {nome}; {codigo}");
            file.Close();
            return new Produto
            {
                ProdutoId = id,
                Nome = nome,
                Codigo = codigo
            };
        }
    }
}
