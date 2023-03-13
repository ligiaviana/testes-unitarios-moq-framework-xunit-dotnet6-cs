﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TesteMock.Models.Entities;
using TesteMock.Repository.Interfaces;
using TesteMock.Services.Interfaces;

[assembly: InternalsVisibleTo("TesteMock.Tests")]
namespace TesteMock.Services
{
    internal class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _repository;

        public ProdutoService(IProdutoRepository repository)
        {
            _repository = repository;
        }
        public Produto AddProduto(int id, string nome, string codigo)
        {
            return _repository.AddProduto(id, nome, codigo);
        }
    }
}
