namespace FormMain.EF_Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FOOD_食材
    {
        [Key]
        public int FOOD_食材_PK { get; set; }

        [StringLength(50)]
        public string RECIPE_FOOD_食譜_FK { get; set; }

        [StringLength(200)]
        public string FOOD_NAME食材名稱 { get; set; }

        [StringLength(200)]
        public string FOOD_AMOUNT食材數量 { get; set; }

        [StringLength(255)]
        public string UPDATE_USER { get; set; }

        public DateTime? UPDATE_TIME { get; set; }

        public virtual RECIPE_食譜 RECIPE_食譜 { get; set; }
    }
}
