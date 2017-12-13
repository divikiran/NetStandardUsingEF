using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using NetStandard2.Entities;

namespace NetStandard2.DbConnection
{
    public class DatabaseContext : DbContext
    {
        public string DatabasePath
        {
            get;
            set;
        }

        public DbSet<PersonEntity> PersonEntity
        {
            get;
            set;
        }

        public DatabaseContext()
        {
            DatabasePath = GetDatabasePath();
        }

        private string GetDatabasePath()
        {
            var sqliteFilename = "NetStandard.db";
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, sqliteFilename);
            return path;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite($"Data Source={DatabasePath}");
        }
    }
}
