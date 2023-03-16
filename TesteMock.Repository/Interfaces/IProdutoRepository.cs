using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteMock.Models.Entities;

namespace TesteMock.Repository.Interfaces
{
    public interface IProdutoRepository
    {
        Produto SaveProduto(int id, string nome, string codigo);

        Produto GetProduto(int id);
    }


}
