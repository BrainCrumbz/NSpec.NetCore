#if false

// TODO NETCORE appsettings - Probably we could remove this one
// together with appsettings.json: it seems a little bit out of scope

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
