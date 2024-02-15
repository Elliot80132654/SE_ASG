using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkingManagementSystem.Models;

namespace ParkingManagementSystem.Services
{
    public static class SeasonPassRepository
    {
        private static List<SeasonPass> _seasonPasses = new List<SeasonPass>();

        public static void Add(SeasonPass pass)
        {
            _seasonPasses.Add(pass);
        }

        
        public static SeasonPass GetSeasonPassById(string passId)
        {
            return _seasonPasses.FirstOrDefault(sp => sp.PassId == passId);
        }
    }
}
