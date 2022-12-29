package org.crequency.kitx.ruls.web;

import java.util.ArrayList;
import java.util.HashMap;

public class LoaderStruct {
    public Boolean SelfLoad;

    public String LoaderName;

    public String LoaderVersion;

    public String LoaderLanguage;

    public String LoaderFramework;

    public RunType LoaderRunType;

    public ArrayList<OperatingSystems> SupportOS;

    public enum RunType
    {
        Console, Desktop, Browser
    }

    public HashMap<String, String> Tags;
}
