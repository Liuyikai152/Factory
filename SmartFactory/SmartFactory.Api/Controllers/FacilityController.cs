using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using SmartFactory.IServices;
using SmartFactory.Model;
using SmartFactory.Services;
namespace SmartFactory.Api.Controllers
{
    [RoutePrefix("Facility")]
    public class FacilityController : ApiController
    {
        public IFacilityServices FacilityServices { get; set; }
        /// <summary>
        /// 查看所有零件
        /// </summary>
        /// <returns></returns>
        public const int PAGESIZE = 2;
        [HttpGet]
        [Route("GetFacility")]
        public PageBox GetFacility(FactoryEnum IsSiren, string BitNumbers, string CompanyName, string FactoryName, string TypeName,string FacilityNumber, int PageIndex = 1)
        {
            List<FacilityNotMapp> facilitylist = FacilityServices.GetFacility();
            if (IsSiren != 0)
            {
                facilitylist = facilitylist.Where(n => n.IsSiren.Equals(IsSiren)).ToList();
            }
            if (FacilityNumber != null)
            {
                facilitylist = facilitylist.Where(n => n.FacilityNumber.Equals(FacilityNumber)).ToList();
            }
            if (BitNumbers != null)
            {
                facilitylist = facilitylist.Where(n => n.BitNumbers.Equals(BitNumbers)).ToList();
            }
            if (CompanyName != null)
            {
                facilitylist = facilitylist.Where(n => n.CompanyName.Equals(CompanyName)).ToList();
            }
            if (FactoryName != null)
            {
                facilitylist = facilitylist.Where(n => n.FactoryName.Equals(FactoryName)).ToList();
            }
            if (TypeName != null)
            {
                facilitylist = facilitylist.Where(n => n.TypeName.Equals(TypeName)).ToList();
            }

            PageBox pageBox = new PageBox();
           
            pageBox.PageIndex = PageIndex;
            pageBox.PageSize = PAGESIZE;
            pageBox.PageCount = facilitylist.Count / PAGESIZE + (facilitylist.Count % PAGESIZE == 0 ? 0 : 1);
            pageBox.Data = facilitylist.Skip((PageIndex - 1) * PAGESIZE).Take(PAGESIZE);
            return pageBox;
            
        }
        
        /// <summary>
        /// 根据ID查一个
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("GetById")]
        public FacilityNotMapp GetById(int id)
        {

            var falist = FacilityServices.GetById(id);
            return falist;

           

        }

        /// <summary>
        /// 修改报警状态
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("UpdateSiren")]
        public int UpdateSiren(int ID, int IsSiren)
        {
            var i = FacilityServices.UpdateSiren(ID, IsSiren);
            return i;
        }
    }
}
