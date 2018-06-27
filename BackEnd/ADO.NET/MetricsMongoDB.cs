using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.GridFS;
using MongoDB.Driver.Linq;

namespace BackEnd.ADO.NET
{
    public class MetricsMongoDB
    {
        #region ATTRIBUTES
        private ObjectId id;
        private string denomination;
        private string deviceType;
        private string userName;
        private float metricValue;
        private string metricUnit;
        private DateTime dateBegin;
        #endregion

        #region GETTERS SETTERS
        public ObjectId Id { get => id; set => id = value; }
        public string Denomination { get => denomination; set => denomination = value; }
        public string DeviceType { get => deviceType; set => deviceType = value; }
        public string UserName { get => userName; set => userName = value; }
        public float MetricValue { get => metricValue; set => metricValue = value; }
        public string MetricUnit { get => metricUnit; set => metricUnit = value; }
        public DateTime DateBegin { get => dateBegin; set => dateBegin = value; }
        #endregion

        public MetricsMongoDB() { }
        
    }
}