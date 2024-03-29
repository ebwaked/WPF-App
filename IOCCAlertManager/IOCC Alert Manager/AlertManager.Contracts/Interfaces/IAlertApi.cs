﻿using OperationsAlertManager.Models;
using System;
using System.Collections.Generic;

namespace OperationsAlertManager.Interfaces
{
    public interface IAlertApi
    {
        // GET api/alerts
        IList<Alert> GetAlerts();

        // GET api/alerts/priority/5
        IList<Alert> GetPendingAlertsByPriority(int id);

        // GET api/alerts/inProgress
        IList<Alert> GetInProgressAlerts();

        // GET api/alerts/resolved
        IList<Alert> GetResolvedAlerts(DateTime dttm);

        // GET api/alerts/5
        string GetAlert(int id);

        // POST api/alerts
        void PostAlert(Alert value);

        // PUT api/alerts/5
        void PutAlert(int id, Alert value);

        // DELETE api/alerts/5
        void DeleteAlert(int id);
    }
}
