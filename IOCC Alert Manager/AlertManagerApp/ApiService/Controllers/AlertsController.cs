﻿using AlertManagerApp.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace AlertManagerApp.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class AlertsController : ApiController, IAlertApi
    {
        // TODO
        //public async Task<IHttpActionResult> GetAlerts()
        //{
        //    return Ok(alertArray);
        //}

        // GET api/alerts
        public ObservableCollection<Alert> GetAlerts()
        {
            var alertDemoCollection = new ObservableCollection<Alert>();

            for (int x = 1; x <= 500; x++)
            {
                var dc = new Alert();
                dc.Id = x;
                dc.AlertDT = DateTime.Today.AddDays(x);
                dc.AlertTypeName = "Alert Type Name " + x.ToString();
                dc.Responses = x + 1;
                dc.FacilityName = x % 2 == 0 ?
                    "Super Company " + x.ToString() : "Sub-par company " + x.ToString();
                dc.ReportedBy = "Reported Name " + x.ToString();
                dc.FacilityType = "Facility Type " + x.ToString();
                dc.FirstViewed = DateTime.Today.AddDays(x + 2);
                alertDemoCollection.Add(dc);
            }

            return alertDemoCollection;
        }
        
        // GET api/alerts/5
        public string GetAlert(int id)
        {
            return "value";
        }

        // POST api/alerts
        public void PostAlert([FromBody] Alert value)
        {
            throw new System.NotImplementedException();
        }

        // PUT api/alerts/5
        public void PutAlert(int id, [FromBody] Alert value)
        {
            throw new System.NotImplementedException();
        }

        // DELETE api/alerts/5
        public void DeleteAlert(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
