using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using NSE.WebApp.MVC.Models;

namespace NSE.WebApp.MVC.Services
{
    public interface ICatalogoService
    {
        Task<IEnumerable<ProdutoViewModel>> OberTodos();
        Task<ProdutoViewModel> ObertePorId(Guid id);
    }
}