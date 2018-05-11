using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTier.EF.Models;
using System.Data.Entity;

namespace DataTier.Repositories
{
    public class EFSailboatRepository : ISailboatDbRepository
    {
        public List<Sailboat> GetSailboats()
        {
            throw new NotImplementedException();
        }

        public void Save(ISailboat sailboatDto)
        {
            using (var context = new SailboatDbContext())
            {
                using (var dbContextTransaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var sailboat = new Sailboat
                        {
                            Name = sailboatDto.Name,
                            Type = sailboatDto.Type,
                            MaxHullSpeed = sailboatDto.MaxHullSpeed,
                            WaterLineLengthInFeet = sailboatDto.WaterLineLengthInFeet
                        };


                        context.Sailboats.Add(sailboat);

                        context.SaveChanges();

                        dbContextTransaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        dbContextTransaction.Rollback();
                    }
                }
            }
        }
    }
}
