namespace FormMain.EF_Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RECIPE_食譜
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RECIPE_食譜()
        {
            FOOD_食材 = new HashSet<FOOD_食材>();
            STEP_步驟列表 = new HashSet<STEP_步驟列表>();
        }

        [Key]
        [StringLength(50)]
        public string RECIPE食譜_PK { get; set; }

        [StringLength(40)]
        public string RECIPE_NAME食譜名稱 { get; set; }

        public DateTime? UPDATE_TIME更新時間 { get; set; }

        public DateTime? PUBLISHED_TIME出版時間 { get; set; }

        public int? FEATURED_CATEGORY精選分類LEVEL_ONE { get; set; }

        public int? FEATURED_CATEGORY精選分類LEVEL_TWO { get; set; }

        public int? FEATURED_CATEGORY精選分類LEVEL_THREE { get; set; }

        public DateTime? PUBLISHED_TIME發表時間 { get; set; }

        [StringLength(50)]
        public string AUTHOR_作者 { get; set; }

        public int? LIKES_讚數 { get; set; }

        public string RECIPE_COVER { get; set; }

        [StringLength(400)]
        public string SHORT_DESCRIPTION簡短說明 { get; set; }

        [StringLength(20)]
        public string COST_MINUTES花費時間 { get; set; }

        [StringLength(20)]
        public string AMOUNT_份量 { get; set; }

        public int? CALORIES_熱量 { get; set; }

        [StringLength(300)]
        public string TIPS_小撇步 { get; set; }

        public int? FAVORITE_NUMBER收藏數 { get; set; }

        public virtual CATEGORY_食譜分類_LEVEL_THREE CATEGORY_食譜分類_LEVEL_THREE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FOOD_食材> FOOD_食材 { get; set; }

        public virtual MEMBER_會員 MEMBER_會員 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STEP_步驟列表> STEP_步驟列表 { get; set; }
    }
}
