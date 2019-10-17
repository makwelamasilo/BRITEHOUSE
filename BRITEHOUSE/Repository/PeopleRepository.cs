using BRITEHOUSE.Data;
using BRITEHOUSE.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using PagedList.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BRITEHOUSE.Repository
{
    public class PeopleRepository
    {
        private britehouseDBContext dbContext;
        private IMongoCollection<People> peopleCollection;

        public PeopleRepository()
        {
            dbContext = new britehouseDBContext();
            peopleCollection = dbContext.database.GetCollection<People>("people");
        }

        public void CreatePeople(People people)
        {
            peopleCollection.InsertOne(people);
        }

        public void DeletePeople(string id)
        {
            peopleCollection.DeleteOne(Builders<People>.Filter.Eq("_id", ObjectId.Parse(id)));
        }

        public void UpdatePeople(People people)
        {
            peopleCollection.UpdateOne(Builders<People>.Filter
                .Eq("_id", people.Id), Builders<People>
                .Update
                .Set("Person", people.Person)
                .Set("Region", people.Region));
        }

        public People GetPeople(string id)
        {
            var people_ID = new ObjectId(id);
            return peopleCollection.AsQueryable<People>().SingleOrDefault(x => x.Id == people_ID);
        }

        public IPagedList<People> GetPeopleList(int? page_Num)
        {
            return peopleCollection.AsQueryable<People>().ToPagedList(page_Num ?? 1, 10);
        }

        public IEnumerable<People> GetAllPeople()
        {
            return peopleCollection.AsQueryable<People>().ToList();
        }
    }
}
