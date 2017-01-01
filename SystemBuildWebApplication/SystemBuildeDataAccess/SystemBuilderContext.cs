using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using SystemBuilderDataModels;
using SystemBuilderDataModels.Fields;
using System.Data.Entity.ModelConfiguration.Conventions;

//using SystemBuildeDataAccess.Migrations;

namespace SystemBuildeDataAccess
{
    public class SystemBuilderContext : DbContext
    {

        public SystemBuilderContext() : base()
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<SystemBuilderContext, Configuration>(true));
            Database.SetInitializer(new DbContextInitializer());
        }
        public SystemBuilderContext(string connectionString) : base(connectionString)
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<SystemBuilderContext, Configuration>(true));
            Database.SetInitializer(new DbContextInitializer());
        }
        /// <summary>
        /// The OnModelCreating method
        /// </summary>
        /// <param name="modelBuilder">The modelBuilder parameter</param>        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<FieldInstance>();
            modelBuilder.Entity<FieldType>().HasKey(ft => ft.Id)
                .Property(ft => ft.Id)
                .HasDatabaseGeneratedOption
                (System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        public virtual DbSet<NodeType> NodeTypes { get; set; }

        public virtual DbSet<Node> Nodes { get; set; }

        public virtual DbSet<Field> Fields { get; set; }

        public virtual DbSet<Organizer> Organizers { get; set; }

        public virtual DbSet<UserInterface> UserInterfaces { get; set; }

        public virtual DbSet<ImageField> ImageFields { get; set; }

        public virtual DbSet<NumberField> NumberFields { get; set; }

        public virtual DbSet<StringField> StringFields { get; set; }

        public virtual DbSet<FieldType> FieldTypes { get; set; }

    }

    public class DbContextInitializer : DropCreateDatabaseIfModelChanges<SystemBuilderContext>
    {

        protected override void Seed(SystemBuilderContext context)
        {
            base.Seed(context);
            this.FieldTypeInit(context);
            this.BuildNodeTypes(context);
            this.NodeStartingPoint(context);
        }

        protected void BuildNodeTypes(SystemBuilderContext context)
        {
            NodeType defaultType = new NodeType()
            {
                Name = "base"
            };
            defaultType.Fields = new List<Field>();
            defaultType.Fields.Add(new Field()
            {
                Name = "Name",
                FieldTypeId = (int)FieldType.FieldTypes.text,
                Order = 0
            });
            context.NodeTypes.AddOrUpdate(defaultType);
            context.SaveChanges();
        }

        protected void FieldTypeInit(SystemBuilderContext context)
        {
            foreach(FieldType.FieldTypes type in Enum.GetValues(typeof(FieldType.FieldTypes)))
            {
                context.FieldTypes.AddOrUpdate(new FieldType()
                {
                    Id = (int)type,
                    Name = type.ToString()
                });
            }
            context.SaveChanges();
        }

        protected void NodeStartingPoint(SystemBuilderContext context)
        {
            Node startingNode = new Node()
            {
                NodeTypeId = 1,
            };
            startingNode.Fields = new List<FieldInstance>();
            startingNode.Fields.Add(new StringField()
            {
                FieldId = 1
            });
            context.Nodes.AddOrUpdate(startingNode);
            context.SaveChanges();
        }
    }

}
