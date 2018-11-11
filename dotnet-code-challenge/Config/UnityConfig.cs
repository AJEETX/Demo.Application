﻿using dotnet_code_challenge.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using Unity;

namespace dotnet_code_challenge.Config
{
    public class UnityConfig
    {
        public static IManager GetManager()
        {
            var container = new UnityContainer();

            container.RegisterType<IManager, Manager>();
            container.RegisterType<IDatasourceManager, DatasourceManager>();
            container.RegisterType<ISupervisor, Supervisor>();
            return container.Resolve<IManager>();
        }

    }
}