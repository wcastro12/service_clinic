using ClinicalSystem.Bussines.Broker;
using SistemaClinico.Entities.Models;
using System;
using System.Collections.Generic;
using ClinicalSystem.Bussines.ServiceCalculator;

namespace ClinicalSystem.Bussines.Handler
{
   public class ReasonChangesHandler
    {
        private ReasonChangesBroker ob = new ReasonChangesBroker();

        public bool Add(ReasonChangesEntity obje)
        {

            ob.Add(obje);

            return true;
        }
        public bool Change(ReasonChangesEntity obje)
        {
            ob.Change(obje);

            return true;
        }
        public ReasonChangesEntity Find(int? Id)
        {
            return ob.Find(Id);
        }
        public ReasonChangesEntity Remove(ReasonChangesEntity obje)
        {
            return ob.Remove(obje);
        }

        public List<ReasonChangesEntity> ToList()
        {
            var calculate = new CalculatorSoapClient();
            int total = calculate.Add(4, 6);
            return ob.GetReasonChanges();
            
        }
    }
}
