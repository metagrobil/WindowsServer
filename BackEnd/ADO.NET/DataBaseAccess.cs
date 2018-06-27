using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using BackEnd.ADO.NET;
/***************************/
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.GridFS;
using MongoDB.Driver.Linq;
/***************************/

namespace BackEnd
{
    public class DataBaseAccess
    {
        #region ATTRIBUTES
        private IMongoDatabase database;
        private IMongoCollection<BsonDocument> collection;
        private List<MetricsMongoDB> allRecord;
        private MetricsMongoDB record;
        #endregion

        #region GETTERS SETTERS
        public IMongoDatabase Database { get => database; set => database = value; }
        public IMongoCollection<BsonDocument> Collection { get => collection; set => collection = value; }
        #endregion

        public DataBaseAccess() {
            Database = new MongoClient(ConfigurationManager.AppSettings["connectionString"]).GetDatabase("local");
            Collection = database.GetCollection<BsonDocument>("Data");

            //var data = collection.Find(_ => true).ToListAsync().Result;
        }

        #region METHODES
        public void SaveMetric(string metricName, string deviceType, float value, string unit, DateTime dateTime)
        {

        }

        public float FindMetric(string metricName)
        {
            return 0;
        }

        public void SendMetric(string metricName, float value, string unit, DateTime dateTime)
        {

        }

        public List<string> FindListDevices(string user)
        {
            return null;
        }
        #endregion
    }
}