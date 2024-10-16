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
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class LogEntities : DbContext
    {
        public LogEntities()
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
            //try
            countObject = base.SaveChanges();
            //catch { }
            _instance = null;
            return countObject;
        }

        public static bool IsExistInstance { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<subject> subjects { get; set; }
        public virtual DbSet<typeMark> typeMarks { get; set; }
        public virtual DbSet<mark> marks { get; set; }
        public virtual DbSet<group> groups { get; set; }
        public virtual DbSet<subjects_to_groups> subjects_to_groups { get; set; }
        public virtual DbSet<marks_comments> marks_comments { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<subjects_to_teachers> subjects_to_teachers { get; set; }
        public virtual DbSet<teacher> teachers { get; set; }
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<student> students { get; set; }
        public virtual DbSet<marks_history> marks_history { get; set; }
        public virtual DbSet<vw_StudentAvgMarkWithGroup> vw_StudentAvgMarkWithGroup { get; set; }
        public virtual DbSet<vw_TeachersWithSubjectsAndAvgMark> vw_TeachersWithSubjectsAndAvgMark { get; set; }
        public virtual DbSet<vw_TopStudentsByGroup> vw_TopStudentsByGroup { get; set; }
    
        public virtual ObjectResult<sp_GetStudentsWithMarksAbove_Result> sp_GetStudentsWithMarksAbove(Nullable<double> markThreshold)
        {
            var markThresholdParameter = markThreshold.HasValue ?
                new ObjectParameter("MarkThreshold", markThreshold) :
                new ObjectParameter("MarkThreshold", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetStudentsWithMarksAbove_Result>("sp_GetStudentsWithMarksAbove", markThresholdParameter);
        }
    
        public virtual ObjectResult<sp_GetTeachersWithSubjects_Result> sp_GetTeachersWithSubjects()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetTeachersWithSubjects_Result>("sp_GetTeachersWithSubjects");
        }
    
        public virtual ObjectResult<Nullable<int>> sp_GetTotalMarksCountByGroup(string groupId)
        {
            var groupIdParameter = groupId != null ?
                new ObjectParameter("GroupId", groupId) :
                new ObjectParameter("GroupId", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_GetTotalMarksCountByGroup", groupIdParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> sp_GetTotalMarksCountInGroupBySubject(string groupId, Nullable<int> subjectId)
        {
            var groupIdParameter = groupId != null ?
                new ObjectParameter("GroupId", groupId) :
                new ObjectParameter("GroupId", typeof(string));
    
            var subjectIdParameter = subjectId.HasValue ?
                new ObjectParameter("SubjectId", subjectId) :
                new ObjectParameter("SubjectId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_GetTotalMarksCountInGroupBySubject", groupIdParameter, subjectIdParameter);
        }
    
        public virtual int sp_UpdateSubject(Nullable<int> subjectId, string newName)
        {
            var subjectIdParameter = subjectId.HasValue ?
                new ObjectParameter("SubjectId", subjectId) :
                new ObjectParameter("SubjectId", typeof(int));
    
            var newNameParameter = newName != null ?
                new ObjectParameter("NewName", newName) :
                new ObjectParameter("NewName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_UpdateSubject", subjectIdParameter, newNameParameter);
        }
    }
}
