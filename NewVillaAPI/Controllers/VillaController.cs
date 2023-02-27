using Microsoft.AspNetCore.Mvc;
using NewVillaAPI.Data;
using NewVillaAPI.Models;

namespace NewVillaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillaController : ControllerBase
    {        
        [HttpGet]
        public ActionResult<IEnumerable<VillaStore>> Get()
        {
            return Ok(VillaStore.villaList);
        }
        
        [HttpGet("{id}")]
        public ActionResult<Villa> Get(int id)
        {
            var villa = VillaStore.villaList.FirstOrDefault(x => x.Id == id);
            return Ok(villa);
        }
        
        [HttpPost]
        public ActionResult<Villa> Post([FromBody] Villa value)
        {
            VillaStore.villaList.Add(value);
            return CreatedAtRoute(new { Id= value.Id }, value);
        }
        
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Villa newVilla)
        {
            var villa = VillaStore.villaList.FirstOrDefault(u =>u.Id == id);
            villa.Name = newVilla.Name;
           return NoContent();
            
        }
       
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
           var villa = VillaStore.villaList.FirstOrDefault(x=> x.Id == id);
            VillaStore.villaList.Remove(villa);
            return NoContent();
        }
    }
}
