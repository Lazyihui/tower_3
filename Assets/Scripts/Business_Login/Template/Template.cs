using System;
using UnityEngine;
using System.Collections.Generic;

public class Template {


    public Dictionary<int, FlagTemplate> flagDict;

    public void FlagTemplate_Init() {

        FlagTemplate f1 = new FlagTemplate(1, Color.blue);
        FlagTemplate f2 = new FlagTemplate(2, Color.red);

        flagDict = new Dictionary<int, FlagTemplate>();
        flagDict.Add(1, f1);
        flagDict.Add(2, f2);
    }

    public FlagTemplate GetFlag(int typeID) {
        FlagTemplate value; // * ref out
        bool exist = flagDict.TryGetValue(typeID, out value);
        if (!exist) {
            Debug.LogError("Not Exist " + typeID.ToString());
            return null;
        }
        return value;
    }


}