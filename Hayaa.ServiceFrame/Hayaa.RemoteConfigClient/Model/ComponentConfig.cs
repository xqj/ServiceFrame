﻿using Hayaa.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hayaa.RemoteConfigClient.Model
{
    /// <summary>
    /// 程序组件配置方案
    /// </summary>
    [Serializable]
   public class ComponentConfig:BaseData
    {
        /// <summary>
        /// ID
        /// </summary>		
        
        public int ID
        {
            get;
            set;
        }
        /// <summary>
        /// 组件配置ID
        /// </summary>	
       
        public int ComponentConfigID
        {
            get;
            set;
        }
        /// <summary>
        /// 组件ID
        /// </summary>		
        
        public int ComponentID
        {
            get;
            set;
        }
        /// <summary>
        /// 组件配置内容
        /// </summary>		
        
        public string Content
        {
            get;
            set;
        }
        /// <summary>
        /// 配置内容版本
        /// </summary>	
       
        public int Version
        {
            get;
            set;
        }       
        /// <summary>
        /// 配置标题
        /// </summary>
        
        public string ComponentConfigTitle { get; set; }
    }
}
