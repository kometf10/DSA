﻿using OA.Domin.Attributes;
using OA.Domin.RequestFeatures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OA.Domin.DSA
{
    public class PageTranslation : BaseEntity
    {
        [DisplayName("Translation")]
        public string Name { get; set; }

        public string Language { get; set; }

        public string Slug { get; set; }

        [DisplayName("Active")]
        public bool IsActive { get; set; }

        [DisplayName("Content")]
        public string HTMLContent { get; set; }

        [DisplayName("Link 1")]
        public string Link1 { get; set; }

        [DisplayName("Link 2")]
        public string Link2 { get; set; }

        public string FilePath { get; set; }

        [DisplayName("Page")]
        [PropFlag("FK")]
        public int PageId { get; set; }

        [PropFlag("FK_REF")]
        public virtual Page Page { get; set; }

        [NotMapped]
        [PropFlag("IGNORE")]
        public virtual RequestFileData File { get; set; }

    }
}
