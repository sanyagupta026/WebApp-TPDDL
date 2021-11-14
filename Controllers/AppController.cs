using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;
using PagedList.Mvc;
using PagedList;
using DbModel = WebApp.Models.DbModel;

namespace WebApp.Controllers
{
    public class AppController : Controller
    {

     

        public ActionResult AppTable(String search ,int? i)
        {

            
            using (DbModel dbs = new DbModel())
            {

              
                return View(dbs.AddApps.ToList().ToPagedList(i??1,5));


            }
        }


        public ActionResult AppVersions()
        {

            DbModel dbs = new DbModel();


            List<AppVersion> appVersions = dbs.AppVersions.ToList();
            List<AddApp> addApps = dbs.AddApps.ToList();


            var multipletable = from ver in appVersions
                                join add in addApps on ver.AppId equals add.AppId into AddAppVersions
                                from add in AddAppVersions.DefaultIfEmpty()
                                select new MultipleClass { AddAppDetails = add, AppVersionDetails = ver };

            return View(multipletable);





        }


        public ActionResult AddCards()
        {

            using (DbModel dbs = new DbModel())
            {

                var cardDetails = dbs.AddApps.ToList();
                return View(cardDetails);


            }
          

        }



        [HttpGet]
        public ActionResult AddApp()
        {
            return View();
        }




        // POST: App/Create
        [HttpPost]
        public ActionResult AddApp(AddApp addApp)
        {
            try
            {
                // TODO: Add insert logic here
               
               

                using (DbModel dbs = new DbModel())
                {
                    dbs.AddApps.Add(addApp);
                    dbs.SaveChanges();
                }
                return RedirectToAction("AppTable");
            }
            catch
            {
                return View();
            }
        }


        [HttpGet]
        public ActionResult AddVersionApp()
        {
            return View();
        }




        // POST: App/Create
        [HttpPost]
        public ActionResult AddVersionApp(AppVersion app)
        {
            try
            {
               
                using (DbModel dbs = new DbModel())
                {
                    dbs.AppVersions.Add(app);
                    dbs.SaveChanges();
                }
                return RedirectToAction("AppTable");
            }
            catch
            {
                return View();
            }
        }


        public ActionResult EditApp(int id)
        {
            using (DbModel dbs = new DbModel())
            {
                return View(dbs.AddApps.Where(x => x.AppId == id).FirstOrDefault());
            }
        }

      


        [HttpPost]
        public ActionResult EditApp( int id, AddApp addApp)
        {
            try
            {
                // TODO: Add update logic here
                using (DbModel dbs = new DbModel())
                {
                    dbs.Entry(addApp).State = System.Data.Entity.EntityState.Modified;
                    dbs.SaveChanges();
                }
                return RedirectToAction("AppTable");
            }
            catch
            {
                return View();
            }
        }

        // GET: App/Delete/5
        public ActionResult DeleteApp(int id)
        {
              using (DbModel dbs = new DbModel())
            {
                return View(dbs.AddApps.Where(x => x.AppId == id).FirstOrDefault());
            }
        }

        // POST: App/Delete/5
        [HttpPost]
        public ActionResult DeleteApp(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
               using (DbModel dbs = new DbModel())
                {
                    AddApp appData = dbs.AddApps.Where(x => x.AppId == id).FirstOrDefault();
                    dbs.AddApps.Remove(appData);
                    dbs.SaveChanges();

                }
                return RedirectToAction("AppTable");
            }
            catch
            {
                return View();
            }
        }
    }
}
