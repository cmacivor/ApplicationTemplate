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
            using (var context = new SailboatDbContext())
            {
                var allSailboats = context.Sailboats.ToList();

                return allSailboats;
            }
        }

        public Sailboat GetSailboatById(int id)
        {
            using (var context = new SailboatDbContext())
            {
                var sailboat = context.Sailboats.FirstOrDefault(x => x.SailboatId == id);

                if (sailboat == null)
                {
                    return null;
                }

                return sailboat;
            }
        }

        public void Save(Common.ISailboat sailboatDto)
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
                            MaxHullSpeed = sailboatDto.MaxHullSpeed.Value,
                            WaterLineLengthInFeet = sailboatDto.WaterLineLengthInFeet.Value
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
