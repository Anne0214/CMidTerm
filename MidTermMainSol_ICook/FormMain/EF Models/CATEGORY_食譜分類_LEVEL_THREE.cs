namespace FormMain.EF_Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CATEGORY_食譜分類_LEVEL_THREE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CATEGORY_食譜分類_LEVEL_THREE()
        {
            RECIPE_食譜 = new HashSet<RECIPE_食譜>();
        }

        [Key]
        public int FEATURED_CATEGORY精選分類LEVEL_THREE_PK { get; set; }

        [StringLength(40)]
        public string FEATURED_CATEGORY精選分類LEVEL_THREE_NAME名稱 { get; set; }

        public int? LEVEL_TWO_FK { get; set; }

        [StringLength(255)]
        public string UPDATE_USER { get; set; }

        public DateTime? UPDATE_TIME { get; set; }

        public virtual CATEGORY_食譜分類_LEVEL_TWO CATEGORY_食譜分類_LEVEL_TWO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RECIPE_食譜> RECIPE_食譜 { get; set; }
    }
}
