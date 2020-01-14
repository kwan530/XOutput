﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XOutput.Core.Configuration;
using XOutput.Core.DependencyInjection;
using XOutput.Core.External;

namespace XOutput.Core
{
    public static class CoreConfiguration
    {
        [ResolverMethod]
        public static ConfigurationManager GetConfigurationManager()
        {
            return new JsonConfigurationManager();
        }

        [ResolverMethod]
        public static CommandRunner GetCommandRunner()
        {
            return new CommandRunner();
        }
    }
}
