package org.crequency.kitx.contracts.java;

import java.util.Date;
import java.util.HashMap;

public interface IIdentityInterface {

   String GetName();

   String GetVersion();

   HashMap<String, String> GetDisplayName();

   String GetAuthorName();

   String GetPublisherName();

   String GetAuthorLink();

   String GetPublisherLink();

   HashMap<String, String> GetSimpleDescription();

   HashMap<String, String> GetComplexDescription();

   HashMap<String, String> GetTotalDescriptionInMarkdown();

   String GetIconInBase64();

   Date GetPublishDate();

   Date GetLastUpdateDate();

   IController GetController();

   Boolean IsMarketVersion();

   IMarketPluginContract GetMarketPluginContract();

   String GetRootStartupFileName();
}
