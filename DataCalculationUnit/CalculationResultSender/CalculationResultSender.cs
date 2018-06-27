using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataCalculationUnit
{
    public class CalculationResultSender
    {
        #region ATTRIBUTES
        private float calculatedMetric;
        #endregion

        #region GETTERS SETTERS
        public float CalculatedMetric { get => calculatedMetric; set => calculatedMetric = value; }
        #endregion

        public CalculationResultSender(float metric) {
            this.CalculatedMetric = metric;
        }

        #region METHODES
        //private void RetrieveMetric()
        //{

        //}

        public void SendResultToJEE(float calulatedMetric)
        {

        }
        #endregion
    }
}