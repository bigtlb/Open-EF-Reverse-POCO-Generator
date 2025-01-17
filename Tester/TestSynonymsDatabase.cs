﻿

// ------------------------------------------------------------------------------------------------
// This code was generated by EntityFramework Reverse POCO Generator (http://www.reversepoco.com/).
// Created by Simon Hughes (https://about.me/simon.hughes).
//
// Do not make changes directly to this file - edit the template instead.
//
// The following connection settings were used to generate this file:
//     Configuration file:     "Tester\App.config"
//     Connection String Name: "TestSynonymsDatabase"
//     Connection String:      "Data Source=(local);Initial Catalog=EfrpgTest_Synonyms;Integrated Security=True;Application Name=EntityFramework Reverse POCO Generator"
// ------------------------------------------------------------------------------------------------
// Database Edition        : Developer Edition (64-bit)
// Database Engine Edition : Enterprise
// Database Version        : 14.0.2027.2

// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.5
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace TestSynonymsDatabase
{
    using System.Linq;

    #region Unit of work

    public interface ITestDbContext : System.IDisposable
    {
        System.Data.Entity.DbSet<Child> Children { get; set; } // Child
        System.Data.Entity.DbSet<Parent> Parents { get; set; } // Parent

        int SaveChanges();
        System.Threading.Tasks.Task<int> SaveChangesAsync();
        System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken);
        System.Data.Entity.Infrastructure.DbChangeTracker ChangeTracker { get; }
        System.Data.Entity.Infrastructure.DbContextConfiguration Configuration { get; }
        System.Data.Entity.Database Database { get; }
        System.Data.Entity.Infrastructure.DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        System.Data.Entity.Infrastructure.DbEntityEntry Entry(object entity);
        System.Collections.Generic.IEnumerable<System.Data.Entity.Validation.DbEntityValidationResult> GetValidationErrors();
        System.Data.Entity.DbSet Set(System.Type entityType);
        System.Data.Entity.DbSet<TEntity> Set<TEntity>() where TEntity : class;
        string ToString();

        // Stored Procedures
        System.Collections.Generic.List<SimpleStoredProcReturnModel> SimpleStoredProc(int? inputInt);
        System.Collections.Generic.List<SimpleStoredProcReturnModel> SimpleStoredProc(int? inputInt, out int procResult);
        System.Threading.Tasks.Task<System.Collections.Generic.List<SimpleStoredProcReturnModel>> SimpleStoredProcAsync(int? inputInt);


        // Table Valued Functions
    }

    #endregion

    #region Database context

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.5.0")]
    public class TestDbContext : System.Data.Entity.DbContext, ITestDbContext
    {
        public System.Data.Entity.DbSet<Child> Children { get; set; } // Child
        public System.Data.Entity.DbSet<Parent> Parents { get; set; } // Parent

        static TestDbContext()
        {
            System.Data.Entity.Database.SetInitializer<TestDbContext>(null);
        }

        public TestDbContext()
            : base("Name=TestSynonymsDatabase")
        {
        }

        public TestDbContext(string connectionString)
            : base(connectionString)
        {
        }

        public TestDbContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model)
            : base(connectionString, model)
        {
        }

        public TestDbContext(System.Data.Common.DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {
        }

        public TestDbContext(System.Data.Common.DbConnection existingConnection, System.Data.Entity.Infrastructure.DbCompiledModel model, bool contextOwnsConnection)
            : base(existingConnection, model, contextOwnsConnection)
        {
        }

        public TestDbContext(System.Data.Entity.Core.Objects.ObjectContext objectContext, bool dbContextOwnsObjectContext)
            : base(objectContext, dbContextOwnsObjectContext)
        {
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public bool IsSqlParameterNull(System.Data.SqlClient.SqlParameter param)
        {
            var sqlValue = param.SqlValue;
            var nullableValue = sqlValue as System.Data.SqlTypes.INullable;
            if (nullableValue != null)
                return nullableValue.IsNull;
            return (sqlValue == null || sqlValue == System.DBNull.Value);
        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Add(new CodeFirstStoreFunctions.FunctionsConvention<TestDbContext>("dbo"));

            modelBuilder.Configurations.Add(new ChildConfiguration());
            modelBuilder.Configurations.Add(new ParentConfiguration());
        }

        public static System.Data.Entity.DbModelBuilder CreateModel(System.Data.Entity.DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new ChildConfiguration(schema));
            modelBuilder.Configurations.Add(new ParentConfiguration(schema));
            return modelBuilder;
        }

        // Stored Procedures
        public System.Collections.Generic.List<SimpleStoredProcReturnModel> SimpleStoredProc(int? inputInt)
        {
            int procResult;
            return SimpleStoredProc(inputInt, out procResult);
        }

        public System.Collections.Generic.List<SimpleStoredProcReturnModel> SimpleStoredProc(int? inputInt, out int procResult)
        {
            var inputIntParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@InputInt", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = inputInt.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!inputInt.HasValue)
                inputIntParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
            var procResultData = Database.SqlQuery<SimpleStoredProcReturnModel>("EXEC @procResult = [Synonyms].[SimpleStoredProc] @InputInt", inputIntParam, procResultParam).ToList();

            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public async System.Threading.Tasks.Task<System.Collections.Generic.List<SimpleStoredProcReturnModel>> SimpleStoredProcAsync(int? inputInt)
        {
            var inputIntParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@InputInt", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = inputInt.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!inputInt.HasValue)
                inputIntParam.Value = System.DBNull.Value;

            var procResultData = await Database.SqlQuery<SimpleStoredProcReturnModel>("EXEC [Synonyms].[SimpleStoredProc] @InputInt", inputIntParam).ToListAsync();

            return procResultData;
        }

        // Table Valued Functions
    }
    #endregion

    #region Database context factory

    public class TestDbContextFactory : System.Data.Entity.Infrastructure.IDbContextFactory<TestDbContext>
    {
        public TestDbContext Create()
        {
            return new TestDbContext();
        }
    }

    #endregion

    #region Fake Database context

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.5.0")]
    public class FakeTestDbContext : ITestDbContext
    {
        public System.Data.Entity.DbSet<Child> Children { get; set; }
        public System.Data.Entity.DbSet<Parent> Parents { get; set; }

        public FakeTestDbContext()
        {
            _changeTracker = null;
            _configuration = null;
            _database = null;

            Children = new FakeDbSet<Child>("ChildId");
            Parents = new FakeDbSet<Parent>("ParentId");
        }

        public int SaveChangesCount { get; private set; }
        public int SaveChanges()
        {
            ++SaveChangesCount;
            return 1;
        }

        public System.Threading.Tasks.Task<int> SaveChangesAsync()
        {
            ++SaveChangesCount;
            return System.Threading.Tasks.Task<int>.Factory.StartNew(() => 1);
        }

        public System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken)
        {
            ++SaveChangesCount;
            return System.Threading.Tasks.Task<int>.Factory.StartNew(() => 1, cancellationToken);
        }

        protected virtual void Dispose(bool disposing)
        {
        }

        public void Dispose()
        {
            Dispose(true);
        }

        private System.Data.Entity.Infrastructure.DbChangeTracker _changeTracker;
        public System.Data.Entity.Infrastructure.DbChangeTracker ChangeTracker { get { return _changeTracker; } }
        private System.Data.Entity.Infrastructure.DbContextConfiguration _configuration;
        public System.Data.Entity.Infrastructure.DbContextConfiguration Configuration { get { return _configuration; } }
        private System.Data.Entity.Database _database;
        public System.Data.Entity.Database Database { get { return _database; } }
        public System.Data.Entity.Infrastructure.DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.Infrastructure.DbEntityEntry Entry(object entity)
        {
            throw new System.NotImplementedException();
        }
        public System.Collections.Generic.IEnumerable<System.Data.Entity.Validation.DbEntityValidationResult> GetValidationErrors()
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.DbSet Set(System.Type entityType)
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.DbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            throw new System.NotImplementedException();
        }
        public override string ToString()
        {
            throw new System.NotImplementedException();
        }


        // Stored Procedures
        public System.Collections.Generic.List<SimpleStoredProcReturnModel> SimpleStoredProc(int? inputInt)
        {
            int procResult;
            return SimpleStoredProc(inputInt, out procResult);
        }

        public System.Collections.Generic.List<SimpleStoredProcReturnModel> SimpleStoredProc(int? inputInt, out int procResult)
        {

            procResult = 0;
            return new System.Collections.Generic.List<SimpleStoredProcReturnModel>();
        }

        public System.Threading.Tasks.Task<System.Collections.Generic.List<SimpleStoredProcReturnModel>> SimpleStoredProcAsync(int? inputInt)
        {
            int procResult;
            return System.Threading.Tasks.Task.FromResult(SimpleStoredProc(inputInt, out procResult));
        }

        // Table Valued Functions
    }

    // ************************************************************************
    // Fake DbSet
    // Implementing Find:
    //      The Find method is difficult to implement in a generic fashion. If
    //      you need to test code that makes use of the Find method it is
    //      easiest to create a test DbSet for each of the entity types that
    //      need to support find. You can then write logic to find that
    //      particular type of entity, as shown below:
    //      public class FakeBlogDbSet : FakeDbSet<Blog>
    //      {
    //          public override Blog Find(params object[] keyValues)
    //          {
    //              var id = (int) keyValues.Single();
    //              return this.SingleOrDefault(b => b.BlogId == id);
    //          }
    //      }
    //      Read more about it here: https://msdn.microsoft.com/en-us/data/dn314431.aspx
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.5.0")]
    public class FakeDbSet<TEntity> : System.Data.Entity.DbSet<TEntity>, IQueryable, System.Collections.Generic.IEnumerable<TEntity>, System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TEntity> where TEntity : class
    {
        private readonly System.Reflection.PropertyInfo[] _primaryKeys;
        private readonly System.Collections.ObjectModel.ObservableCollection<TEntity> _data;
        private readonly IQueryable _query;

        public FakeDbSet()
        {
            _data = new System.Collections.ObjectModel.ObservableCollection<TEntity>();
            _query = _data.AsQueryable();
        }

        public FakeDbSet(params string[] primaryKeys)
        {
            _primaryKeys = typeof(TEntity).GetProperties().Where(x => primaryKeys.Contains(x.Name)).ToArray();
            _data = new System.Collections.ObjectModel.ObservableCollection<TEntity>();
            _query = _data.AsQueryable();
        }

        public override TEntity Find(params object[] keyValues)
        {
            if (_primaryKeys == null)
                throw new System.ArgumentException("No primary keys defined");
            if (keyValues.Length != _primaryKeys.Length)
                throw new System.ArgumentException("Incorrect number of keys passed to Find method");

            var keyQuery = this.AsQueryable();
            keyQuery = keyValues
                .Select((t, i) => i)
                .Aggregate(keyQuery,
                    (current, x) =>
                        current.Where(entity => _primaryKeys[x].GetValue(entity, null).Equals(keyValues[x])));

            return keyQuery.SingleOrDefault();
        }

        public override System.Threading.Tasks.Task<TEntity> FindAsync(System.Threading.CancellationToken cancellationToken, params object[] keyValues)
        {
            return System.Threading.Tasks.Task<TEntity>.Factory.StartNew(() => Find(keyValues), cancellationToken);
        }

        public override System.Threading.Tasks.Task<TEntity> FindAsync(params object[] keyValues)
        {
            return System.Threading.Tasks.Task<TEntity>.Factory.StartNew(() => Find(keyValues));
        }

        public override System.Collections.Generic.IEnumerable<TEntity> AddRange(System.Collections.Generic.IEnumerable<TEntity> entities)
        {
            if (entities == null) throw new System.ArgumentNullException("entities");
            var items = entities.ToList();
            foreach (var entity in items)
            {
                _data.Add(entity);
            }
            return items;
        }

        public override TEntity Add(TEntity item)
        {
            if (item == null) throw new System.ArgumentNullException("item");
            _data.Add(item);
            return item;
        }

        public override System.Collections.Generic.IEnumerable<TEntity> RemoveRange(System.Collections.Generic.IEnumerable<TEntity> entities)
        {
            if (entities == null) throw new System.ArgumentNullException("entities");
            var items = entities.ToList();
            foreach (var entity in items)
            {
                _data.Remove(entity);
            }
            return items;
        }

        public override TEntity Remove(TEntity item)
        {
            if (item == null) throw new System.ArgumentNullException("item");
            _data.Remove(item);
            return item;
        }

        public override TEntity Attach(TEntity item)
        {
            if (item == null) throw new System.ArgumentNullException("item");
            _data.Add(item);
            return item;
        }

        public override TEntity Create()
        {
            return System.Activator.CreateInstance<TEntity>();
        }

        public override TDerivedEntity Create<TDerivedEntity>()
        {
            return System.Activator.CreateInstance<TDerivedEntity>();
        }

        public override System.Collections.ObjectModel.ObservableCollection<TEntity> Local
        {
            get { return _data; }
        }

        System.Type IQueryable.ElementType
        {
            get { return _query.ElementType; }
        }

        System.Linq.Expressions.Expression IQueryable.Expression
        {
            get { return _query.Expression; }
        }

        IQueryProvider IQueryable.Provider
        {
            get { return new FakeDbAsyncQueryProvider<TEntity>(_query.Provider); }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        System.Collections.Generic.IEnumerator<TEntity> System.Collections.Generic.IEnumerable<TEntity>.GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TEntity> System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TEntity>.GetAsyncEnumerator()
        {
            return new FakeDbAsyncEnumerator<TEntity>(_data.GetEnumerator());
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.5.0")]
    public class FakeDbAsyncQueryProvider<TEntity> : System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
    {
        private readonly IQueryProvider _inner;

        public FakeDbAsyncQueryProvider(IQueryProvider inner)
        {
            _inner = inner;
        }

        public IQueryable CreateQuery(System.Linq.Expressions.Expression expression)
        {
            var m = expression as System.Linq.Expressions.MethodCallExpression;
            if (m != null)
            {
                var resultType = m.Method.ReturnType; // it shoud be IQueryable<T>
                var tElement = resultType.GetGenericArguments()[0];
                var queryType = typeof(FakeDbAsyncEnumerable<>).MakeGenericType(tElement);
                return (IQueryable) System.Activator.CreateInstance(queryType, expression);
            }
            return new FakeDbAsyncEnumerable<TEntity>(expression);
        }

        public IQueryable<TElement> CreateQuery<TElement>(System.Linq.Expressions.Expression expression)
        {
            var queryType = typeof(FakeDbAsyncEnumerable<>).MakeGenericType(typeof(TElement));
            return (IQueryable<TElement>)System.Activator.CreateInstance(queryType, expression);
        }

        public object Execute(System.Linq.Expressions.Expression expression)
        {
            return _inner.Execute(expression);
        }

        public TResult Execute<TResult>(System.Linq.Expressions.Expression expression)
        {
            return _inner.Execute<TResult>(expression);
        }

        public System.Threading.Tasks.Task<object> ExecuteAsync(System.Linq.Expressions.Expression expression, System.Threading.CancellationToken cancellationToken)
        {
            return System.Threading.Tasks.Task.FromResult(Execute(expression));
        }

        public System.Threading.Tasks.Task<TResult> ExecuteAsync<TResult>(System.Linq.Expressions.Expression expression, System.Threading.CancellationToken cancellationToken)
        {
            return System.Threading.Tasks.Task.FromResult(Execute<TResult>(expression));
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.5.0")]
    public class FakeDbAsyncEnumerable<T> : EnumerableQuery<T>, System.Data.Entity.Infrastructure.IDbAsyncEnumerable<T>, IQueryable<T>
    {
        public FakeDbAsyncEnumerable(System.Collections.Generic.IEnumerable<T> enumerable)
            : base(enumerable)
        { }

        public FakeDbAsyncEnumerable(System.Linq.Expressions.Expression expression)
            : base(expression)
        { }

        public System.Data.Entity.Infrastructure.IDbAsyncEnumerator<T> GetAsyncEnumerator()
        {
            return new FakeDbAsyncEnumerator<T>(this.AsEnumerable().GetEnumerator());
        }

        System.Data.Entity.Infrastructure.IDbAsyncEnumerator System.Data.Entity.Infrastructure.IDbAsyncEnumerable.GetAsyncEnumerator()
        {
            return GetAsyncEnumerator();
        }

        IQueryProvider IQueryable.Provider
        {
            get { return new FakeDbAsyncQueryProvider<T>(this); }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.5.0")]
    public class FakeDbAsyncEnumerator<T> : System.Data.Entity.Infrastructure.IDbAsyncEnumerator<T>
    {
        private readonly System.Collections.Generic.IEnumerator<T> _inner;

        public FakeDbAsyncEnumerator(System.Collections.Generic.IEnumerator<T> inner)
        {
            _inner = inner;
        }

        public void Dispose()
        {
            _inner.Dispose();
        }

        public System.Threading.Tasks.Task<bool> MoveNextAsync(System.Threading.CancellationToken cancellationToken)
        {
            return System.Threading.Tasks.Task.FromResult(_inner.MoveNext());
        }

        public T Current
        {
            get { return _inner.Current; }
        }

        object System.Data.Entity.Infrastructure.IDbAsyncEnumerator.Current
        {
            get { return Current; }
        }
    }

    #endregion

    #region POCO classes

    // Child
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.5.0")]
    public class Child
    {
        public int ChildId { get; set; } // ChildId (Primary key)
        public int ParentId { get; set; } // ParentId
        public string ChildName { get; set; } // ChildName (length: 100)

        // Foreign keys

        /// <summary>
        /// Parent Parent pointed by [Child].([ParentId]) (FK_Child_Parent)
        /// </summary>
        public virtual Parent Parent { get; set; } // FK_Child_Parent
    }

    // Parent
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.5.0")]
    public class Parent
    {
        public int ParentId { get; set; } // ParentId (Primary key)
        public string ParentName { get; set; } // ParentName (length: 100)

        // Reverse navigation

        /// <summary>
        /// Child Children where [Child].[ParentId] point to this entity (FK_Child_Parent)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Child> Children { get; set; } // Child.FK_Child_Parent

        public Parent()
        {
            Children = new System.Collections.Generic.List<Child>();
        }
    }

    #endregion

    #region POCO Configuration

    // Child
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.5.0")]
    public class ChildConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Child>
    {
        public ChildConfiguration()
            : this("Synonyms")
        {
        }

        public ChildConfiguration(string schema)
        {
            ToTable("Child", schema);
            HasKey(x => x.ChildId);

            Property(x => x.ChildId).HasColumnName(@"ChildId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ParentId).HasColumnName(@"ParentId").HasColumnType("int").IsRequired();
            Property(x => x.ChildName).HasColumnName(@"ChildName").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);

            // Foreign keys
            HasRequired(a => a.Parent).WithMany(b => b.Children).HasForeignKey(c => c.ParentId).WillCascadeOnDelete(false); // FK_Child_Parent
        }
    }

    // Parent
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.5.0")]
    public class ParentConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Parent>
    {
        public ParentConfiguration()
            : this("Synonyms")
        {
        }

        public ParentConfiguration(string schema)
        {
            ToTable("Parent", schema);
            HasKey(x => x.ParentId);

            Property(x => x.ParentId).HasColumnName(@"ParentId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ParentName).HasColumnName(@"ParentName").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
        }
    }

    #endregion

    #region Stored procedure return models

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.5.0")]
    public class SimpleStoredProcReturnModel
    {
        public System.String ReturnValue { get; set; }
    }

    #endregion

}
// </auto-generated>

