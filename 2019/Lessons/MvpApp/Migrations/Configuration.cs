namespace MvpApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    /// <summary>
    /// ������������ ��������
    /// Add-Migration nnn -- ���������� ��������� ��������
    /// Update-Database -TargetMigration nnn -- ������� � ������ ��������
    /// </summary>
    internal sealed class Configuration : DbMigrationsConfiguration<MvpApp.Storage.Database>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        /// <summary>
        /// ��������� ���������� ���� ������
        /// </summary>
        /// <param name="context"></param>
        protected override void Seed(MvpApp.Storage.Database db)
        {
            // ���� ��� �� ������ ��������
            if (db.Students.Count() == 0)
            {
                var g = new Storage.Group()
                {
                    Number = 1
                };
                db.Groups.Add(g);
                var s = new Storage.Student()
                {
                    Name = "����",
                    FamilyName = "������",                   
                    Group = g
                };
                db.Students.Add(s);
                db.SaveChanges();
            }
        }
    }
}
