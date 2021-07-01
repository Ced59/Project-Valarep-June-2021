using Entities.Models;
using Entities.Repo;
using InterfacesContrats.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected RepoContext Context;

        public RepositoryBase(RepoContext context)
        {
            Context = context;
        }

        public void Create(T entite)
        {
            Context.Set<T>().Add(entite);
        }

        public void Delete(T entite)
        {
            Context.Set<T>().Remove(entite);
        }

        public IQueryable<T> FindAll(bool tracked)
        {
            return tracked ? Context.Set<T>() : Context.Set<T>().AsNoTracking();
        }

        public List<Carburant> FindCarburants()
        {
            List<Carburant> carburants = new List<Carburant>();

            var query = from Carburant in Context.Carburants
                        select new Carburant
                        {
                            IdCa = Carburant.IdCa,
                            Libelle = Carburant.Libelle,
                            CodeEu = Carburant.CodeEu
                        };

            return query.ToList();
        }

        public StationService FindStationServiceById(Guid id)
        {
            StationService stationService = new StationService();

            var query = from StationServices in Context.StationServices
                        join Marques in Context.Marques on StationServices.MarqueId equals Marques.IdMa
                        join CarburantsStation in Context.StationServiceCarburants on StationServices.IdSt equals CarburantsStation.StationServiceId
                        where StationServices.IdSt == id
                        select new StationService
                        {
                            IdSt = StationServices.IdSt,
                            Adresse = StationServices.Adresse,
                            Latitude = StationServices.Latitude,
                            Longitude = StationServices.Longitude,
                            Marque = new Marque
                            {
                                IdMa = Marques.IdMa,
                                Libelle = Marques.Libelle
                            },
                            Carburants = (from CarbuStation in Context.StationServiceCarburants
                                          join Carbu in Context.Carburants on CarbuStation.CarburantId equals Carbu.IdCa
                                          where CarbuStation.StationServiceId == StationServices.IdSt
                                          select new Carburant
                                          {
                                              IdCa = Carbu.IdCa,
                                              Libelle = Carbu.Libelle,
                                              CodeEu = Carbu.CodeEu
                                          }
                                          ).ToList()
                        };

            stationService = query.FirstOrDefault();

            return stationService;


        }

        public List<StationService> FindStationsServiceByCarburant(Guid id)
        {
            List<StationService> stationServices = new List<StationService>();

            var query = from StationServices in Context.StationServices
                        join Marques in Context.Marques on StationServices.MarqueId equals Marques.IdMa
                        join CarburantsStation in Context.StationServiceCarburants on StationServices.IdSt equals CarburantsStation.StationServiceId
                        join Carburants in Context.Carburants on CarburantsStation.CarburantId equals Carburants.IdCa
                        where Carburants.IdCa == id
                        select new StationService
                        {
                            IdSt = StationServices.IdSt,
                            Adresse = StationServices.Adresse,
                            Latitude = StationServices.Latitude,
                            Longitude = StationServices.Longitude,
                            Marque = new Marque
                            {
                                IdMa = Marques.IdMa,
                                Libelle = Marques.Libelle
                            },
                            Carburants = (from CarbuStation in Context.StationServiceCarburants
                                          join Carbu in Context.Carburants on CarbuStation.CarburantId equals Carbu.IdCa
                                          where CarbuStation.StationServiceId == StationServices.IdSt
                                          select new Carburant
                                          {
                                              IdCa = Carbu.IdCa,
                                              Libelle = Carbu.Libelle,
                                              CodeEu = Carbu.CodeEu
                                          }
                                          ).ToList()
                        };

            var result = query.ToList();

            return result.GroupBy(x => x.IdSt).Select(y => y.First()).ToList();
        }

        public List<StationService> FindAllStationsServices()
        {
            List<StationService> stationServices = new List<StationService>();

            var query = from StationServices in Context.StationServices
                        join Marques in Context.Marques on StationServices.MarqueId equals Marques.IdMa
                        join CarburantsStation in Context.StationServiceCarburants on StationServices.IdSt equals CarburantsStation.StationServiceId
                        select new StationService
                        {
                            IdSt = StationServices.IdSt,
                            Adresse = StationServices.Adresse,
                            Latitude = StationServices.Latitude,
                            Longitude = StationServices.Longitude,
                            Marque = new Marque
                            {
                                IdMa = Marques.IdMa,
                                Libelle = Marques.Libelle
                            },
                            Carburants = (from CarbuStation in Context.StationServiceCarburants
                                          join Carbu in Context.Carburants on CarbuStation.CarburantId equals Carbu.IdCa
                                          where CarbuStation.StationServiceId == StationServices.IdSt
                                          select new Carburant
                                          {
                                              IdCa = Carbu.IdCa,
                                              Libelle = Carbu.Libelle,
                                              CodeEu = Carbu.CodeEu
                                          }
                                          ).ToList()
                        };

            var result = query.ToList();

            return result.GroupBy(x => x.IdSt).Select(y=> y.First()).ToList();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expr, bool tracked)
        {
            return tracked ? Context.Set<T>().Where(expr) : Context.Set<T>().Where(expr).AsNoTracking();
        }

        public void Update(T entite)
        {
            Context.Set<T>().Update(entite);
        }
    }
}