using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace FormMain.EF_Models
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
            : base("name=AppDbContext")
        {
        }

        public virtual DbSet<CATEGORY_食譜分類_LEVEL_ONE> CATEGORY_食譜分類_LEVEL_ONE { get; set; }
        public virtual DbSet<CATEGORY_食譜分類_LEVEL_THREE> CATEGORY_食譜分類_LEVEL_THREE { get; set; }
        public virtual DbSet<CATEGORY_食譜分類_LEVEL_TWO> CATEGORY_食譜分類_LEVEL_TWO { get; set; }
        public virtual DbSet<FOOD_食材> FOOD_食材 { get; set; }
        public virtual DbSet<MEMBER_會員> MEMBER_會員 { get; set; }
        public virtual DbSet<RECIPE_食譜> RECIPE_食譜 { get; set; }
        public virtual DbSet<STEP_步驟列表> STEP_步驟列表 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CATEGORY_食譜分類_LEVEL_ONE>()
                .HasMany(e => e.CATEGORY_食譜分類_LEVEL_TWO)
                .WithOptional(e => e.CATEGORY_食譜分類_LEVEL_ONE)
                .HasForeignKey(e => e.LEVEL_ONE_FK);

            modelBuilder.Entity<CATEGORY_食譜分類_LEVEL_THREE>()
                .HasMany(e => e.RECIPE_食譜)
                .WithOptional(e => e.CATEGORY_食譜分類_LEVEL_THREE)
                .HasForeignKey(e => e.FEATURED_CATEGORY精選分類LEVEL_THREE);

            modelBuilder.Entity<CATEGORY_食譜分類_LEVEL_TWO>()
                .HasMany(e => e.CATEGORY_食譜分類_LEVEL_THREE)
                .WithOptional(e => e.CATEGORY_食譜分類_LEVEL_TWO)
                .HasForeignKey(e => e.LEVEL_TWO_FK);

            modelBuilder.Entity<MEMBER_會員>()
                .HasMany(e => e.RECIPE_食譜)
                .WithOptional(e => e.MEMBER_會員)
                .HasForeignKey(e => e.AUTHOR_作者);

            modelBuilder.Entity<RECIPE_食譜>()
                .HasMany(e => e.FOOD_食材)
                .WithOptional(e => e.RECIPE_食譜)
                .HasForeignKey(e => e.RECIPE_FOOD_食譜_FK)
                .WillCascadeOnDelete();

            modelBuilder.Entity<RECIPE_食譜>()
                .HasMany(e => e.STEP_步驟列表)
                .WithOptional(e => e.RECIPE_食譜)
                .HasForeignKey(e => e.RECIPE_STEP_食譜_FK)
                .WillCascadeOnDelete();
        }
    }
}
