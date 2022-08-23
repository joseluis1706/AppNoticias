namespace Noticias.Models.Responses
{
    using System.Collections.Generic;
    using Noticias.Models.Domain;

    public class NewsResponse
    {
        public string Status { get; set; }
        public int TotalResults { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}
