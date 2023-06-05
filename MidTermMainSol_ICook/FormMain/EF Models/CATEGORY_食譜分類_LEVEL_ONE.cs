namespace FormMain.EF_Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CATEGORY_食譜分類_LEVEL_ONE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CATEGORY_食譜分類_LEVEL_ONE()
        {
            CATEGORY_食譜分類_LEVEL_TWO = new HashSet<CATEGORY_食譜分類_LEVEL_TWO>();
        }

        [Key]
        public int FEATURED_CATEGORY精選分類LEVEL_ONE_PK { get; set; }

        [StringLength(40)]
        public string FEATURED_CATEGORY精選分類LEVEL_ONE_NAME名稱 { get; set; }

        [StringLength(255)]
        public string UPDATE_USER { get; set; }

        public DateTime? UPDATE_TIME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CATEGORY_食譜分類_LEVEL_TWO> CATEGORY_食譜分類_LEVEL_TWO { get; set; }
    }
}
