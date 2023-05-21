using System.Collections.Generic;
using WowApplication.Models;

namespace WowApplication.Repositories.Interfaces
{
    public interface IRaceRepository
    {
        void AddRace(RaceModel race);
        void UpdateRace(RaceModel race);
        void DeleteRace(int id);
        RaceModel GetRaceById(int id);
        IEnumerable<RaceModel> GetAllRaces();
        RaceModel GetPopularestStartLocationByFraction();
    }
}
