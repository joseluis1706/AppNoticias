using Noticias.Models.Domain;
using Noticias.Models.Responses;
using Noticias.Services;
using Noticias.Utils;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace Noticias.ViewModels
{
    public class NewsViewModel : ViewModelBase
    {
        private readonly IApiService apiService;
        private ObservableCollection<Article> articles;

        public NewsViewModel(INavigationService navigationService,
            IApiService apiService) : base(navigationService)
        {
            this.apiService = apiService;
            _ = LoadNews();            
        }

        public ObservableCollection<Article> Articles
        {
            get => articles;
            private set => SetProperty(ref articles, value);
        }

        private async Task LoadNews()
        {
            NewsResponse newsResponse = await apiService.GetAsync<NewsResponse>(
                $"{Constant.BaseUrl}{Endpoint.TopHeadLines}?country=co&apikey={Constant.NewsApiKey}");

            if (newsResponse.Status == "ok")
            {
                Articles = new ObservableCollection<Article>(newsResponse.Articles);
            }
        }
    }
}