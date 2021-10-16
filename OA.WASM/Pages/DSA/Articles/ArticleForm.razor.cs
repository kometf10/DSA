﻿using Microsoft.AspNetCore.Components;
using OA.Domin.DSA;
using OA.WASM.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OA.WASM.Pages.DSA.Articles
{
    public partial class ArticleForm : ComponentBase
    {

        [Parameter]
        public bool IsEdit { get; set; }

        [Parameter]
        public Article Article { get; set; } = new Article();

        [Parameter]
        public Dictionary<string, string> ArticleCatigoryItems { get; set; } = new Dictionary<string, string>();

        public string Active { get; set; } = "";

        public UploadFile FileUploadControl { get; set; }
        public UploadFile ImageUploadControl { get; set; }

        public bool UploadBusy { get; set; }

        protected override void OnInitialized()
        {
            Article.Content ??= "type your content here ...";

            Active = (IsEdit) ? "active" : "";

        }

    }
}
