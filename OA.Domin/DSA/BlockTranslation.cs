﻿using Microsoft.EntityFrameworkCore.Infrastructure;
using OA.Domin.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace OA.Domin.DSA
{
    public class BlockTranslation : BaseEntity
    {

        public BlockTranslation()
        {

        }

        private readonly ILazyLoader LazyLoader;
        public BlockTranslation(ILazyLoader lazyLoader)
        {
            LazyLoader = lazyLoader;
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Language { get; set; }

        public string Slug { get; set; }

        [PropFlag("FK")]
        [DisplayName("Block")]
        public int BlockId { get; set; }

        private Block _Block;

        [PropFlag("FK_REF")]
        public virtual Block Block
        { 
            get => LazyLoader.Load(this, ref _Block);
            set => _Block = value;
        }

        [DisplayName("Active")]
        public bool IsActive { get; set; }

    }
}
