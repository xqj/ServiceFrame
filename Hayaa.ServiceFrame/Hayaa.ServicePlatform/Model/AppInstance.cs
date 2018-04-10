﻿using Hayaa.BaseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.ServicePlatform.Service.Model
{
    /// <summary>
    /// App运行实例
    /// </summary>
   public class AppInstance : BaseData
    {
        public int AppInstanceId { set; get; }
        public String Title { set; get; }
    }
}
