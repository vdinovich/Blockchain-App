namespace Blockchain_Admin_App.Models
{
    using System.Data.Entity;
    class My_Context : DbContext
    {
        public My_Context() : base("name=connection") { }

        public virtual DbSet<User> Users { get; set; }
    }
}
