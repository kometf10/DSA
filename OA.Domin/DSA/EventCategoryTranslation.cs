﻿using Microsoft.EntityFrameworkCore.Infrastructure;
using OA.Domin.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace OA.Domin.DSA
{
    public class EventCategoryTranslation : BaseEntity
    {

        private readonly ILazyLoader Loader;
        public EventCategoryTranslation(ILazyLoader loader)
        {
            Loader = loader;
        }

        public EventCategoryTranslation()
        {

        }

        public string Name { get; set; }
        public string Description { get; set; }

        [PropFlag("FK")]
        [DisplayName("Event Category")]
        public int EventCategoryId { get; set; }

        private EventCategory _EventCategory;

        [PropFlag("FK_REF")]
        public virtual EventCategory EventCategory 
        { 
            get => Loader.Load(this, ref _EventCategory);
            set => _EventCategory = value;
        }

        public string Language { get; set; }

        public string Slug { get; set; }

        [DisplayName("Active")]
        public bool IsActive { get; set; }

    }
}
