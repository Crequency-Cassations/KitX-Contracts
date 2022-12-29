package org.crequency.kitx.ruls.web;

import java.util.ArrayList;
import java.util.Date;
import java.util.HashMap;

public class PluginStruct {
    public String Name;

    public String Version;

    public HashMap<String, String> DisplayName;

    public String AuthorName;

    public String PublisherName;

    public String AuthorLink;

    public String PublisherLink;

    public HashMap<String, String> SimpleDescription;

    public HashMap<String, String> ComplexDescription;

    public HashMap<String, String> TotalDescriptionInMarkdown;

    public String IconInBase64;

    public Date PublishDate;

    public Date LastUpdateDate;

    public Boolean IsMarketVersion;

    public HashMap<String, String> Tags;

    public ArrayList<Function> Functions;

    public String RootStartupFileName;
}
