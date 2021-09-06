using OA.Domin.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace OA.Domin.DSA
{
    public class MenueTranslation : BaseEntity
    {
        [DisplayName("Translation")]
        public string Name { get; set; }

        public string Language { get; set; }

        [DisplayName("Active")]
        public bool IsActive { get; set; }

        [DisplayName("Content")]
        public string HTMLContent { get; set; }

        [PropFlag("FK")]
        [DisplayName("Menue")]
        public int MenueId { get; set; }

        [PropFlag("FK_REF")]
        public virtual Menue Menue { get; set; }

    }
}
