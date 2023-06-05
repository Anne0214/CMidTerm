namespace FormMain.EF_Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MEMBER_會員
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MEMBER_會員()
        {
            RECIPE_食譜 = new HashSet<RECIPE_食譜>();
        }

        [Key]
        [StringLength(50)]
        public string MEMBER_ID會員_PK { get; set; }

        public string MEMBER_EMAIL { get; set; }

        [StringLength(32)]
        public string MEMBER_PASSWORD { get; set; }

        [Column(TypeName = "date")]
        public DateTime? REGISTER_TIME註冊時間 { get; set; }

        [StringLength(40)]
        public string NICK_NAME暱稱 { get; set; }

        public string PROFILE_PHOTO頭貼 { get; set; }

        [StringLength(400)]
        public string SELF_INTRO自介 { get; set; }

        [StringLength(200)]
        public string RECEIVED_PERSON_NAME收件人姓名 { get; set; }

        [StringLength(200)]
        public string RECEIVED_PERSON_PHONE收件人電話 { get; set; }

        [StringLength(200)]
        public string RECEIVED_PERSON_ADDRESS收件人地址 { get; set; }

        [StringLength(200)]
        public string UPDATE_USER { get; set; }

        [StringLength(200)]
        public string UPDATE_TIME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RECIPE_食譜> RECIPE_食譜 { get; set; }
    }
}
