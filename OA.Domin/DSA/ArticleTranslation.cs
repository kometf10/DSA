using Microsoft.EntityFrameworkCore.Infrastructure;
using OA.Domin.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace OA.Domin.DSA
{
    public class ArticleTranslation : BaseEntity
    {

        public ArticleTranslation()
        {

        }

        private readonly ILazyLoader LazyLoader;
        public ArticleTranslation(ILazyLoader lazyLoader)
        {
            LazyLoader = lazyLoader;
        }

        public string Name { get; set; }

        public string Language { get; set; }

        public string Slug { get; set; }

        public string Content { get; set; }

        public bool IsActive { get; set; }

        [PropFlag("FK")]
        [DisplayName("Article")]
        public int ArticleId { get; set; }

        private Article _Article;

        [PropFlag("FK_REF")]
        public virtual Article Article
        {
            get => LazyLoader.Load(this, ref _Article);
            set => _Article = value;
        }

    }
}
