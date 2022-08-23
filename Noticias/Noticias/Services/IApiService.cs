using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Noticias.Services
{
    public interface IApiService
    {
        Task<TModel> GetAsync<TModel>(string url);
    }
}
