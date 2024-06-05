using BL.BLApi;
using BL.BLModels;
using Common;
using DAL;
using DAL.DALImplementation;
using DAL.DALModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BLImplementation;

public class BLAtractionsToTourService : IBLAtractionsToTourService
{
    DALAttractionsToTourService ATTService;
    public BLAtractionsToTourService(DALManager ATTService)
    {
        this.ATTService = ATTService.AtractionsToTours;
    }
    public Task<AtractionsToTour> Create(BLAtractionsToTour entity)
    {
        throw new NotImplementedException();
    }

    public Task<AtractionsToTour> Delete(string id)
    {
        throw new NotImplementedException();
    }

    public List<BLAtractionsToTour> GetAll(BaseQueryParams queryParams)
    {
        Task<PagedList<AtractionsToTour>> pagedATTs = ATTService.GetAllAsync(queryParams);
        List<BLAtractionsToTour> ATTsList = new List<BLAtractionsToTour>();
        foreach(var ATT in pagedATTs.Result)
        {
            BLAtractionsToTour newATT = new BLAtractionsToTour();
            newATT.Attid = ATT.Attid;
            newATT.AttractionCode = ATT.AttractionCode;
            newATT.TourCode = ATT.TourCode;
            newATT.AttractionCodeNavigation = ATT.AttractionCodeNavigation;
            ATTsList.Add(newATT);
        }
        return ATTsList;
    }

        public Task<AtractionsToTour> Update(string id, BLAtractionsToTour entity)
    {
        throw new NotImplementedException();
    }
}
