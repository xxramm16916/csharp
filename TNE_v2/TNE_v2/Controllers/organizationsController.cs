using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using TNE_v2.Database;

namespace TNE_v2.Controllers
{
    public class organizationsController : ApiController
    {
        private DatabasaTNE db = new DatabasaTNE();

        // GET: api/organizations
        public IQueryable<organization> Getorganization()
        {
            return db.organization;
        }

        // GET: api/organizations/5
        [ResponseType(typeof(organization))]
        public async Task<IHttpActionResult> Getorganization(int id)
        {
            organization organization = await db.organization.FindAsync(id);
            if (organization == null)
            {
                return NotFound();
            }

            return Ok(organization);
        }

        // PUT: api/organizations/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putorganization(int id, organization organization)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != organization.organizationId)
            {
                return BadRequest();
            }

            db.Entry(organization).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!organizationExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/organizations
        [ResponseType(typeof(organization))]
        public async Task<IHttpActionResult> Postorganization(organization organization)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.organization.Add(organization);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = organization.organizationId }, organization);
        }

        // DELETE: api/organizations/5
        [ResponseType(typeof(organization))]
        public async Task<IHttpActionResult> Deleteorganization(int id)
        {
            organization organization = await db.organization.FindAsync(id);
            if (organization == null)
            {
                return NotFound();
            }

            db.organization.Remove(organization);
            await db.SaveChangesAsync();

            return Ok(organization);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool organizationExists(int id)
        {
            return db.organization.Count(e => e.organizationId == id) > 0;
        }
    }
}