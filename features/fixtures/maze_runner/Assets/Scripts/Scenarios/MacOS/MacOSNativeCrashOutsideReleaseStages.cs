﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MacOSNativeCrashOutsideReleaseStages : Scenario
{
    public override void PrepareConfig(string apiKey, string host)
    {
        base.PrepareConfig(apiKey, host);
        Configuration.EnabledReleaseStages = new string[] { "production" };
        Configuration.ReleaseStage = "notProduction";
    }

    public override void Run()
    {
        MacOSNativeCrash();
    }
}
