using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRM_API.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRM_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("cors")]//设置跨域处理的代理
    public class BaseInfoController : ControllerBase
    {
        public CRMContext db;
        public BaseInfoController(CRMContext db) { this.db = db; }

        /// <summary>
        /// 添加员工
        /// </summary>
        /// <param name="em"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<int>> AddEMp(EmployeeInfo em)
        {

            db.EmployeeInfo.Add(em);
            return await db.SaveChangesAsync();

        }

        /// <summary>
        /// 修改员工
        /// </summary>
        /// <param name="em"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> UpdateEMp(EmployeeInfo em)
        {

            db.Entry(em).State = EntityState.Modified;
             await db.SaveChangesAsync();
            return NoContent();

        }

        /// <summary>
        /// 获取所有员工
        /// </summary>
        /// <returns></returns>
        [Route("GetEmp")]
        public async Task<ActionResult< IEnumerable<EmployeeInfo>>> GetEmp()
        {

            return await db.EmployeeInfo.ToListAsync();

        }

    }
}