﻿using LHR.DAL.SQL;
using LHR.DAL.SQL.System;
using LHR.Types.Constants.Entities;
using LHR.Types.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LHR.Core
{
    public class GeneralSettingsManager
    {
        AppSettings settings;
        DALGeneralSettings dal;
        SQLConnectionProvider cnnProvider;
        public GeneralSettingsManager(AppSettings appSettings)
        {
            settings = appSettings;
            //TODO: replace with DI
            SQLConnectionDetailsProvider cdProvider = new SQLConnectionDetailsProvider(Newtonsoft.Json.JsonConvert.SerializeObject(settings));
            cnnProvider = new SQLConnectionProvider(cdProvider);
            dal = new DALGeneralSettings(cnnProvider);
        }
        public void AddSetting(GeneralSetting gs)
        {
            dal.AddSetting(gs);
        }
        public GeneralSetting GetCurrentSystemVersion()
        {
            var vers = dal.GetSetting(GeleralSettingsGUIDs.SystemVersion);
            if (null != vers)
                return vers;
            else
            {
                return new GeneralSetting
                {
                    Value = "0.0.0"
                };
            }
        }
    }
}