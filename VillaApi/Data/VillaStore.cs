using VillaApi.Models.Dto;

namespace VillaApi.Data
{
    public  static class VillaStore
    {
        public static List<VillaDto> villaList = new List<VillaDto> { new VillaDto { Id=1, Name = "Pool Side", Occupancy=3,Sqft=200},
            new VillaDto { Id=2 , Name = "Beach Side", Occupancy = 5 , Sqft = 400} }; 
    }
}
