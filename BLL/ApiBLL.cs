﻿using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ApiBLL
    {
        public object getDataForGUI()
        {
           ApiDAL apiDal = new ApiDAL();
            object data = apiDal.getData();
            return data;
        }
    }
}
