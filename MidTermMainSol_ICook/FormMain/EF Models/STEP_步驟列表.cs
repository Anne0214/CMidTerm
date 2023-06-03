namespace FormMain.EF_Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class STEP_步驟列表
    {
        [Key]
        public int STEP_步驟_PK { get; set; }

        [StringLength(50)]
        public string RECIPE_STEP_食譜_FK { get; set; }

        [StringLength(300)]
        public string STEP_DESCRIPTION步驟說明 { get; set; }

        public string STEP_DESCRIPTION_PICTURE步驟附圖 { get; set; }

        [StringLength(255)]
        public string UPDATE_USER { get; set; }

        public DateTime? UPDATE_TIME { get; set; }

        public virtual RECIPE_食譜 RECIPE_食譜 { get; set; }
    }
}
