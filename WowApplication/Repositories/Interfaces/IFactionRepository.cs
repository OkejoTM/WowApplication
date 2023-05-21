using System.Collections.Generic;
using WowApplication.Models;

namespace WowApplication.Repositories.Interfaces
{
    public interface IFactionRepository
    {
        void AddFaction(FactionModel faction);
        void UpdateFaction(FactionModel faction);
        void DeleteFaction(int id);
        FactionModel GetFactionById(int id);
        IEnumerable<FactionModel> GetAllFactions();
        FactionModel GetPopularestFaction();
        /*FactionModel GetPopularFaction();*/ // Аналитический запрос.
    }
}
