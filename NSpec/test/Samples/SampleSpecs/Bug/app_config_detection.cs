#if false

// NETCORE This will not be ported. Loading application settings is out of scope.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NSpec;
using System.Configuration;

namespace SampleSpecs.Bug
{
    class app_config_detection : nspec
    {
        void it_finds_app_config()
        {
            ConfigurationManager.AppSettings["SomeConfigEntry"].should_be("Worky");
        }
    }
}
#endif
