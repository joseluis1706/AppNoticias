using System;
using System.Collections.Generic;
using System.Text;

namespace Noticias.Models.Domain
{
    public class Article
    {
        public Source Source { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Uri Url { get; set; }
        public Uri UrlToImage { get; set; }
        public DateTimeOffset PublishedAt { get; set; }
        public string Content { get; set; }
    }
}
