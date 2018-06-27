using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataCalculationUnit
{
    public class APIEndPoint
    {
        #region ATTRIBUTES
        private float metric;
        private object command;
        private float calculatedMetric;
        #endregion

        #region GETTERS SETTERS
        public float Metric { get => metric; set => metric = value; }
        public object Command { get => command; set => command = value; }
        public float CalculatedMetric { get => calculatedMetric; set => calculatedMetric = value; }
        #endregion

        public APIEndPoint() { }

        #region METHODES
        public void Calculate(float metric)
        {
            
        }

        public void RetrieveCommand()
        {

        }

        public void ExcecuteCommand(object command)
        {

        }

        public void SendResultToSender(float calculatedMetric)
        {

        }
        #endregion
    }
}