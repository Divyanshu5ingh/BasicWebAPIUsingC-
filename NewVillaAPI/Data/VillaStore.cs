using NewVillaAPI.Models;

namespace NewVillaAPI.Data
{
    public class VillaStore
    {
        public static List<Villa> villaList = new List<Villa>()
        {
            new Villa{ Id = 1, Name = "Beach view" },
            new Villa{ Id = 2, Name = "Sea View"}
        };
    }
}
