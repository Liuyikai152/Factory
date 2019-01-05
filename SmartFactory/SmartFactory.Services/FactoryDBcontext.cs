using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.Services
{
    using SmartFactory.Model;
    using System.Data.Entity;

    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class FactoryDBcontext:DbContext
    {
        public FactoryDBcontext(string nameOrConnectionString): base(nameOrConnectionString)
        {
            //阻止EF到数据中打探EdmMetadata（EdmMetadata：用于存储数据库中 EDM 的元数据的实体；
            //EDM的全称为Entity Data Model（实体数据模型），EDM模式在项目中的表现形式就是扩展名为.edmx的文件）
            Database.SetInitializer<FactoryDBcontext>(null);
        }

      
        public DbSet<Activity> Activities { get; set; }
        public DbSet<ApprovalNode> ApprovalNode { get; set; }
        public DbSet<BitNumber> BitNumber { get; set; }
        public DbSet<Business> Business { get; set; }
        public DbSet<CompanyCode> CompanyCode { get; set; }
        public DbSet<Conditions> Conditions { get; set; }
        public DbSet<Configuration> Configurations { get; set; }
        public DbSet<Facility> Facility { get; set; }
        public DbSet<FacilityDetails> FacilityDetails { get; set; }
        public DbSet<FacilityLoca> FacilityLoca { get; set; }
        public DbSet<FacilityType> FacilityType { get; set; }
        public DbSet<FactoryArea> FactoryArea { get; set; }
        public DbSet<History> History { get; set; }
        public DbSet<Host> Host { get; set; }
        public DbSet<LocaTion> LocaTion { get; set; }
        public DbSet<LocaType> locaType { get; set; }
        public DbSet<MaintenanceOrder> MaintenanceOrder { get; set; }
        public DbSet<Permission> Permission { get; set; }
        public DbSet<PermissionRole> PermissionRole { get; set; }
        public DbSet<Planfactory> Planfactory { get; set; }
        public DbSet<Plangroup> Plangroup { get; set; }
        public DbSet<Process> Process { get; set; }
        public DbSet<Pump> Pump { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<ServiceGroup> ServiceGroup { get; set; }
        public DbSet<Specification> Specification { get; set; }
        public DbSet<Station> Station { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Subfamily> Subfamily { get; set; }
        public DbSet<Unit> Unit { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<UsersRole> UsersRole { get; set; }
    }
}
