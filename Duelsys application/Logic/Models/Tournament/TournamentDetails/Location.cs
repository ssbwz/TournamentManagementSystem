
using System.ComponentModel.DataAnnotations;

namespace DuelSysLogic.Models.Tournament.TournamentDetails
{
    public class Location
    {

        public Location(string street, string buildingNum, string zipcode)
        {
            this.Street = street;
            this.BuidlingNum = buildingNum;
            this.ZipCode = zipcode;
        }

        
        public string Street { get; set; }

        
        public string BuidlingNum { get; set; }

        
        public string ZipCode { get; set; }

    }
}
