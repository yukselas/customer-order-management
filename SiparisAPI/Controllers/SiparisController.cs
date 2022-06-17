using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SiparisAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SiparisController : ControllerBase
    {
        private readonly DataContext _context;

        public SiparisController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Siparis>>> Get()
        {
            return Ok(await _context.Siparisler.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Siparis>> Get(int id)
        {
            var siparis = await _context.Siparisler.FindAsync(id);
            if (siparis == null)
                return BadRequest("Order not found.");
            return Ok(siparis);
        }

        [HttpPost]
        public async Task<ActionResult<List<Siparis>>> AddSiparis(Siparis siparis)
        {
            
            _context.Siparisler.Add(siparis);
            await _context.SaveChangesAsync();

            return Ok(await _context.Siparisler.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<Siparis>>> UpdateSiparis(Siparis request)
        {
            var dbsiparis = await _context.Siparisler.FindAsync(request.Id);
            if (dbsiparis == null)
                return BadRequest("Order not found.");

            dbsiparis.customerOrderNo = request.customerOrderNo;
            dbsiparis.departureAddress = request.departureAddress;
            dbsiparis.destinationAddress = request.destinationAddress;
            dbsiparis.quantity = request.quantity;
            dbsiparis.quantityUnit = request.quantityUnit;
            dbsiparis.weight = request.weight;
            dbsiparis.weightUnit = request.weightUnit;
            dbsiparis.materialCode = request.materialCode;
            dbsiparis.material = request.material;
            dbsiparis.note = request.note;
            dbsiparis.status = request.status;


            await _context.SaveChangesAsync();

            return Ok(await _context.Siparisler.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Siparis>>> Delete(int id)
        {
            var dbsiparis = await _context.Siparisler.FindAsync(id);
            if (dbsiparis == null)
                return BadRequest("Order not found.");

            _context.Siparisler.Remove(dbsiparis);
            await _context.SaveChangesAsync();

            return Ok(await _context.Siparisler.ToListAsync());
        }

    }
}
