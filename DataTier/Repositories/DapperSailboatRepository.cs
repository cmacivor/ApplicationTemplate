using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using Dapper;
using DataTier.Dapper.Models;
using DataTier.EF.Models;

namespace DataTier.Repositories
{
    public class DapperSailboatRepository : ISailboatDbRepository
    {
        public EF.Models.Sailboat GetSailboatById(int id)
        {
            throw new NotImplementedException();
        }

        //public  List<EF.Models.Sailboat> GetSailboats()
        //{
        //    try
        //    {
        //        string sql = @"select 
        //                        SailboatId
        //                        ,Name
        //                        ,Type
        //                        ,WaterLineLengthInFeet
        //                        ,MaxHullSpeed
        //                        from
        //                        Sailboats";

        //        using (IDbConnection db = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SandboxDBContext;Integrated Security=True"))
        //        {
        //            var sailboats = db.Query<EF.Models.Sailboat>(sql).ToList();

        //            return sailboats;
        //        }
        //    }
        //    catch(Exception ex)
        //    {
        //        throw;
        //        //TODO: implement some kind of logging
        //    }
        //}

        public void Save(ISailboat sailboat)
        {
            throw new NotImplementedException();
        }

        List<EF.Models.Sailboat> ISailboatDbRepository.GetSailboats()
        {
            try
            {
                string sql = @"select 
                                SailboatId
                                ,Name
                                ,Type
                                ,WaterLineLengthInFeet
                                ,MaxHullSpeed
                                from
                                Sailboats";

                using (IDbConnection db = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SandboxDBContext;Integrated Security=True"))
                {
                    var sailboats = db.Query<EF.Models.Sailboat>(sql).ToList();

                    return sailboats;
                }
            }
            catch (Exception ex)
            {
                throw;
                //TODO: implement some kind of logging
            }
        }
    }
}
