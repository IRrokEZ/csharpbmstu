namespace MvpApp.Storage
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    /// <summary>
    /// �������� ���� ������
    /// </summary>
    public class Database : DbContext
    {
        /// <summary>
        /// ����������� �� ���������
        /// </summary>
        public Database() : base("Database")
        {
            // https://stackoverflow.com/questions/30084916/no-connection-string-named-could-be-found-in-the-application-config-file
        }

        /// <summary>
        /// �������������� ���������� ��������
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            System.Data.Entity.Database.SetInitializer(new MigrateDatabaseToLatestVersion<Database, Migrations.Configuration>());
        }


        /// <summary>
        /// �������
        /// </summary>
        public virtual DbSet<Chair> Chairs { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        public virtual DbSet<Group> Groups { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public virtual DbSet<Student> Students { get; set; }
    }
}