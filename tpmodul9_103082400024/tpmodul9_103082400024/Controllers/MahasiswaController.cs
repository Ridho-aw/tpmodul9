using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using tpmodul9_103082400024.Model;

[Route("api/[controller]")]
[ApiController]
public class MahasiswaController : ControllerBase
{
    private static List<ModelMahasiswa> daftarMahasiswa = new List<ModelMahasiswa>
    {
        new ModelMahasiswa("Ridho Ananta Wibowo", "103082400024"),
        new ModelMahasiswa("LeBron James", "1302000001"),
        new ModelMahasiswa("Stephen Curry", "1302000002")
    };

    [HttpGet]
    public IEnumerable<ModelMahasiswa> Get()
    {
        return daftarMahasiswa;
    }

    [HttpGet("{id}")]
    public ModelMahasiswa Get(int id)
    {
        return daftarMahasiswa[id];
    }

    [HttpPost]
    public void Post([FromBody] ModelMahasiswa mahasiswaBaru)
    {
        daftarMahasiswa.Add(mahasiswaBaru);
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        daftarMahasiswa.RemoveAt(id);
    }
}
