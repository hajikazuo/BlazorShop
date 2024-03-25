﻿using BlazorShop.Api.Entities;

namespace BlazorShop.Api.Repositories.Interfaces
{
    public interface IProdutoRepository
    {
        Task<IEnumerable<Produto>> GetItens();
        Task<Produto> GetItem(int id);  
        Task <IEnumerable<Produto>> GetItensPorCategoria(int id);
    }
}
