﻿using Abp.Modules;
using System.Reflection;

namespace Cinotam.Cms.DatabaseContentProvider
{
    public class CinotamCmsDatabaseProvider : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}