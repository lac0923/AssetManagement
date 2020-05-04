using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OtakuAssetManagement.Models;

namespace OtakuAssetManagement.Controllers
{
    public class AssetController : Controller
    {
        private OtakuAssetEntities db = new OtakuAssetEntities();

        // GET: Asset
        public ActionResult Index()
        {
            return View(db.GetAssetList().ToList());
        }

        // GET: Asset/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            M_Asset m_Asset = db.M_Asset.Find(id);
            if (m_Asset == null)
            {
                return HttpNotFound();
            }
            return View(m_Asset);
        }

        // GET: Asset/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Asset/Create
        // 過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        // 詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AssetID,AssetNo,AssetName,UseCategory,Amount,Status,GetDate,GetReason,TransferDate,TransferReason,BelongingID,PlaceID,InsertDate,UpdateDate")] M_Asset m_Asset)
        {
            if (ModelState.IsValid)
            {
                db.M_Asset.Add(m_Asset);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(m_Asset);
        }

        // GET: Asset/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            M_Asset m_Asset = db.M_Asset.Find(id);
            if (m_Asset == null)
            {
                return HttpNotFound();
            }
            return View(m_Asset);
        }

        // POST: Asset/Edit/5
        // 過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        // 詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AssetID,AssetNo,AssetName,UseCategory,Amount,Status,GetDate,GetReason,TransferDate,TransferReason,BelongingID,PlaceID,InsertDate,UpdateDate")] M_Asset m_Asset)
        {
            if (ModelState.IsValid)
            {
                db.Entry(m_Asset).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(m_Asset);
        }

        // GET: Asset/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            M_Asset m_Asset = db.M_Asset.Find(id);
            if (m_Asset == null)
            {
                return HttpNotFound();
            }
            return View(m_Asset);
        }

        // POST: Asset/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            M_Asset m_Asset = db.M_Asset.Find(id);
            db.M_Asset.Remove(m_Asset);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
