﻿using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

using SmartFactory.IServices;
using SmartFactory.Services;
using Autofac.Integration.WebApi;
using System.Web.Http;
using Autofac.Integration.Mvc;

namespace SmartFactory.Api
{
    public static class AutofacConfig
    {
        /// <summary>
        /// 项目初始化，实例化IOC容器
        /// </summary>
        public static void Register()
        {
            var builder = new ContainerBuilder();
            SetupResolveRules(builder);

            //注册所有的ApiControllers
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly()).PropertiesAutowired();
            var container = builder.Build();

            //注册api容器需要使用HttpConfiguration对象
            HttpConfiguration config = GlobalConfiguration.Configuration;
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }

        /// <summary>
        /// 将实现类与接口注入到IOC容器中
        /// </summary>
        /// <param name="builder"></param>
        public static void SetupResolveRules(ContainerBuilder container)
        {

           //container.RegisterType<UsersServices>().As<IUsersServices>();          
            container.RegisterType<CompanyCodeServices>().As<ICompanyCodeServices>();
            container.RegisterType<PlanfactoryServices>().As<IPlanfactoryServices>();
            container.RegisterType<FactoryAreaServices>().As<IFactoryAreaServices>();
            container.RegisterType<PlangroupServices>().As<IPlangroupServices>();
            container.RegisterType<ServiceGroupServices>().As<IServiceGroupServices>();
            container.RegisterType<BusinesServices>().As<IBusinesServices>();
            container.RegisterType<LocalionServices>().As<ILocalionServices>();
            container.RegisterType<LocaTypeServices>().As<ILocaTypeServices>();
            container.RegisterType<ApprovalNodeServices>().As<IApprovalNodeServices>();
            container.RegisterType<ActivityServices>().As<IActivityServices>();
            container.RegisterType<BitNumberServices>().As<IBitNumberServices>();
            container.RegisterType<ConditionsServices>().As<IConditionsServices>();
            container.RegisterType<ConfigurationServices>().As<IConfigurationsServices>();
            container.RegisterType<FacilityDetailsServices>().As<IFacilityDetailsServices>();
            container.RegisterType<FacilityGeneralServices>().As<IFacilityGeneralServices>();
            container.RegisterType<FacilityLocaServices>().As<IFacilityLocaServices>();
            container.RegisterType<FacilityManuFacturerServices>().As<IFacilityManuFacturerServices>();
            container.RegisterType<FacilityServices>().As<IFacilityServices>();
            container.RegisterType<FacilityTypeServices>().As<IFacilityTypeServices>();
            container.RegisterType<MaintenanceOrderServices>().As<IMaintenanceOrderServices>();
            container.RegisterType<PermissionRoleServices>().As<IPermissionRoleServices>();
            container.RegisterType<PermissionServices>().As<IPermissionServices>();
            container.RegisterType<PlanfactoryServices>().As<IPlanfactoryServices>();
            container.RegisterType<PlangroupServices>().As<IPlangroupServices>();
            container.RegisterType<ProcessServices>().As<IProcessServices>();
            container.RegisterType<RoleServices>().As<IRoleServices>();
            container.RegisterType<PlangroupServices>().As<IPlangroupServices>();
            container.RegisterType<SpeciFicationServices>().As<ISpecificationServices>();
            container.RegisterType<StationServices>().As<IStationServices>();
            container.RegisterType<StatusServices>().As<IStatusServices>();
            container.RegisterType<SubfamilyServices>().As<ISubfamilyServices>();
            container.RegisterType<UnitServices>().As<IUnitServices>();
            container.RegisterType<UsersRoleServices>().As<IUsersRoleServices>();
        }
    }
}