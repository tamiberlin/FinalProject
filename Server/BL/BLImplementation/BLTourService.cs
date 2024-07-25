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

public class BLTourService : IBLTourService
{
    DALTourService tourService;
    public BLTourService(DALManager tourService)
    {
        this.tourService = tourService.Tours;
    }

    public Task<Tour> Create(BLTour entity)
    {
        throw new NotImplementedException();
    }

    public Task<Tour> Delete(string id)
    {
        throw new NotImplementedException();
    }

    public List<BLTour> GetAll(BaseQueryParams queryParams)
    {
        Task<PagedList<Tour>> pagedTours = tourService.GetAllAsync(queryParams);
        List<BLTour> tourList = new List<BLTour>();
        foreach (var tour in pagedTours.Result)
        {
            BLTour newTour = new BLTour();
            newTour.TourCode = tour.TourCode;
            newTour.TourName = tour.TourName;
            newTour.AtractionsToTours = tour.AtractionsToTours;
            newTour.Price = tour.Price;
            tourList.Add(newTour);
        }
        return tourList;
    }

    public List<BLTour> GetAllTours()
    {
        Task<List<Tour>> pagedTours = tourService.GetAllAsyncTours();
        List<BLTour> tourList = new List<BLTour>();
        foreach (var tour in pagedTours.Result)
        {
            BLTour newTour = new BLTour();
            newTour.TourCode = tour.TourCode;
            newTour.TourName = tour.TourName;
            newTour.AtractionsToTours = tour.AtractionsToTours;
            newTour.Price = tour.Price;
            tourList.Add(newTour);
        }
        return tourList;
    }

    public Task<Tour> Update(string id, BLTour entity)
    {
        throw new NotImplementedException();
    }
}
