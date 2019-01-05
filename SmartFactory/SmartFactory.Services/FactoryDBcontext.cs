using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.Services
{
    using SmartFactory.Model;
    using System.Data.Entity;
    /// <summary>
    /// 连接MySql
    /// </summary>
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class FactoryDBcontext:DbContext
    {
        public FactoryDBcontext(): base("name=ArtLineDbContext")
        {
            //阻止EF到数据中打探EdmMetadata（EdmMetadata：用于存储数据库中 EDM 的元数据的实体；
            //EDM的全称为Entity Data Model（实体数据模型），EDM模式在项目中的表现形式就是扩展名为.edmx的文件）
            Database.SetInitializer<FactoryDBcontext>(null);
        }

        /// <summary>
        /// 审批活动表
        /// </summary>
        public DbSet<Activity> Activities { get; set; }
        /// <summary>
        /// 审批节点表
        /// </summary>
        public DbSet<ApprovalNode> ApprovalNode { get; set; }
        /// <summary>
        /// 设备位号表
        /// </summary>
        public DbSet<BitNumber> BitNumber { get; set; }
        /// <summary>
        /// 设备业务表
        /// </summary>
        public DbSet<Business> Business { get; set; }
        /// <summary>
        /// 公司编号表
        /// </summary>
        public DbSet<CompanyCode> CompanyCode { get; set; }
        /// <summary>
        /// 审批条件表
        /// </summary>
        public DbSet<Conditions> Conditions { get; set; }
        /// <summary>
        /// 审批配置表
        /// </summary>
        public DbSet<Configuration> Configurations { get; set; }
        /// <summary>
        /// 设备/零件表
        /// </summary>
        public DbSet<Facility> Facility { get; set; }
        /// <summary>
        /// 设备/零件详情表
        /// </summary>
        public DbSet<FacilityDetails> FacilityDetails { get; set; }
        /// <summary>
        /// 设备安装位置表
        /// </summary>
        public DbSet<FacilityLoca> FacilityLoca { get; set; }
        /// <summary>
        /// 设备种类表
        /// </summary>
        public DbSet<FacilityType> FacilityType { get; set; }
        /// <summary>
        /// 工厂区域表
        /// </summary>
        public DbSet<FactoryArea> FactoryArea { get; set; }
        /// <summary>
        /// 审批记录表
        /// </summary>
        public DbSet<History> History { get; set; }
        /// <summary>
        /// 主机/附机表
        /// </summary>
        public DbSet<Host> Host { get; set; }
        /// <summary>
        /// 功能位置表
        /// </summary>
        public DbSet<LocaTion> LocaTion { get; set; }
        /// <summary>
        /// 位置类型表
        /// </summary>
        public DbSet<LocaType> LocaType { get; set; }
        /// <summary>
        /// 维修工单表
        /// </summary>
        public DbSet<MaintenanceOrder> MaintenanceOrder { get; set; }
        /// <summary>
        /// 权限表
        /// </summary>
        public DbSet<Permission> Permission { get; set; }
        /// <summary>
        /// 权限角色关系表
        /// </summary>
        public DbSet<PermissionRole> PermissionRole { get; set; }
        /// <summary>
        /// 工厂表
        /// </summary>
        public DbSet<Planfactory> Planfactory { get; set; }
        /// <summary>
        /// 计划员组表
        /// </summary>
        public DbSet<Plangroup> Plangroup { get; set; }
        /// <summary>
        /// 审批流程表
        /// </summary>
        public DbSet<Process> Process { get; set; }
        /// <summary>
        /// 机泵表
        /// </summary>
        public DbSet<Pump> Pump { get; set; }
        /// <summary>
        /// 角色表
        /// </summary>
        public DbSet<Role> Role { get; set; }
        /// <summary>
        /// 维护班组
        /// </summary>
        public DbSet<ServiceGroup> ServiceGroup { get; set; }
        /// <summary>
        /// 技术参数表
        /// </summary>
        public DbSet<Specification> Specification { get; set; }
        /// <summary>
        /// 测点表
        /// </summary>
        public DbSet<Station> Station { get; set; }
        /// <summary>
        /// 审批状态表
        /// </summary>
        public DbSet<Status> Status { get; set; }
        /// <summary>
        /// 子系列类表
        /// </summary>
        public DbSet<Subfamily> Subfamily { get; set; }
        /// <summary>
        /// 机组表
        /// </summary>
        public DbSet<Unit> Unit { get; set; }
        /// <summary>
        /// 用户表
        /// </summary>
        public DbSet<Users> Users { get; set; }
        /// <summary>
        /// 用户角色关系表
        /// </summary>
        public DbSet<UsersRole> UsersRole { get; set; }
        /// <summary>
        /// 设备制造商数据表
        /// </summary>
        public DbSet<FacilityManuFacturer> FacilityManuFacturer { get; set; }
        /// <summary>
        /// 设备制造商数据表
        /// </summary>
        public DbSet<FacilityGeneral> FacilityGeneral { get; set; }
        
    }
}
