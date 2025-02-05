﻿using DAL.EF.Tables;
using DAL.Interfaces;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Application, int, Application> getApplications()
        {
            return new ApplicationRepo();
        }
        public static IApllicationFeatures applicationStatus()
        {
            return new ApplicationRepo();
        }
        public static IApllicationFeatures applicationTrack()
        {
            return new ApplicationRepo();
        }
        public static IApllicationFeatures deadlineFeature()
        {
            return new ApplicationRepo();
        }
    }
}
