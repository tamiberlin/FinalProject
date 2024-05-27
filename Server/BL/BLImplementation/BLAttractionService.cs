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

public class BLAttractionService : IBLAttractionService
{

    DALAtractionService attractionService;
    public BLAttractionService(DALManager DalManager)
    {
        this.attractionService = DalManager.Atractions;
    }
    public Task<Attraction> Create(BLAttraction entity)
    {
        throw new NotImplementedException();
    }

    public Task<Attraction> Delete(string id)
    {
        throw new NotImplementedException();
    }

    public List<BLAttraction> GetAll(BaseQueryParams queryParams)
    {
        Task<PagedList<Attraction>> pagedAttractions = attractionService.GetAllAsync(queryParams);
        List<BLAttraction> attractionsList = new List<BLAttraction>();
        foreach (var attraction in pagedAttractions.Result)
        {
            BLAttraction newAttraction = new BLAttraction();
            newAttraction.AttractionId = attraction.AttractionId;
            newAttraction.AttractionName = attraction.AttractionName;
            newAttraction.AddressCode = attraction.AddressCode;
            attractionsList.Add(newAttraction);
        }
        return attractionsList;
    }

    public Task<Attraction> Update(string id, BLAttraction entity)
    {
        throw new NotImplementedException();
    }
}
