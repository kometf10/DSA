using OA.Domin.DSA;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OA.Domin
{
    [NotMapped]
    public static class StaticIndexes
    {

        public static Dictionary<string, string> Genders = new Dictionary<string, string>
        {
            {"Male", "Male" },
            {"Female", "Female" }
        };

        public static Dictionary<string, string> DonarTypes = new Dictionary<string, string>
        {
            {"Person", "Person Donator"},
            {"Corp", "Corporate Donator"},
        };

        public static Dictionary<string, string> BlockCategoryTypes = new Dictionary<string, string>
        {
            { "Main Page", "Main Page" },
            { "Images Galleary", "Images Galleary"},
            { "Videos Galleary", "Videos Galleary"},
            { "Blog", "Blog"},
            { "Link", "Link"}
        };

        public static Dictionary<string, string> PageTypes = new Dictionary<string, string>
        {
            { "Call Us", "Call Us" },
            { "Normal Page", "Normal Page" },
        };

        public static Dictionary<string, string> MenueTypes = new Dictionary<string, string>
        {
            { "Page", "Page"},
            { "DropDown Menu", "DropDown Menu"},
            { "External Link", " External Link"},
            { "Enternal Link", " Enternal Link"},
            { "File", "File"},
        };

        public static Dictionary<string, string> Language = new Dictionary<string, string>
        {
            { "AR", "Arabic"},
            { "EN", "English"}
        };

        public static Dictionary<string, string> ArticleCategoryTypes = new Dictionary<string, string>
        {
            { "News", "News"},
            { "Sport", "Sport"}
        };

        public static Dictionary<string, string> AttachmentTypes = new Dictionary<string, string>
        {
            { "Image", "Image" },
            { "Video", "Video"},
            { "File", "File"}
        };

        public static Dictionary<string, string> AttachemntReferences = new Dictionary<string, string>
        {
            { nameof(Block), "Block" },
            { nameof(Event), "Event" },
            { nameof(Menue), "Menu"},
            { nameof(Page), "Page"},
            { nameof(Article), "Article"}
        };

    }
}
