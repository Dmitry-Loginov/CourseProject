﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Log
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LogEntities : DbContext
    {
        private LogEntities()
            : base("name=LogEntities")
        {
        }

        private static LogEntities _instance;

        private static readonly object _lock = new object();

        public static LogEntities GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new LogEntities();
                        IsExistInstance = true;
                    }
                }
            }

            return _instance;
        }

        public static void DeleteInstance()
        {
            if (_instance != null)
            {
                lock (_lock)
                {
                    if (_instance != null)
                    {
                        _instance.Dispose();
                        IsExistInstance = false;
                    }
                }
            }
        }

        public new int SaveChanges()
        {
            int countObject = 0;
            try
            { countObject = base.SaveChanges(); }
            catch { }
            _instance = null;
            return countObject;
        }

        public static bool IsExistInstance { get; set; }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<student> students { get; set; }
        public virtual DbSet<subject> subjects { get; set; }
        public virtual DbSet<typeMark> typeMarks { get; set; }
        public virtual DbSet<mark> marks { get; set; }

        public virtual DbSet<group> groups { get; set; }
        public virtual DbSet<subjects_to_groups> subjects_to_groups { get; set; }
    }
}
