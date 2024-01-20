using System;
using UnityEngine;
using System.Collections.Generic;

public class Template {


    public Dictionary<int, FlagTemplate> flagDict;

    public Dictionary<int, TowerTemplate> towerDict;

    public Dictionary<int, MstTemplate> mstDict;

    public void FlagTemplate_Init() {

        FlagTemplate f1 = new FlagTemplate(1, Color.red);
        FlagTemplate f2 = new FlagTemplate(2, Color.yellow);

        flagDict = new Dictionary<int, FlagTemplate>();
        flagDict.Add(1, f1);
        flagDict.Add(2, f2);
    }

    public void TowerTemplate_Init() {
        TowerTemplate t1 = new TowerTemplate(1, Color.red);
        TowerTemplate t2 = new TowerTemplate(2, Color.yellow);

        towerDict = new Dictionary<int, TowerTemplate>();
        towerDict.Add(1, t1);
        towerDict.Add(2, t2);
    }

    public void MstTemplate_Init() {
        MstTemplate m1 = new MstTemplate(1, 4.5f, Color.red);
        MstTemplate m2 = new MstTemplate(2, 5.5f, Color.yellow);

        mstDict = new Dictionary<int, MstTemplate>();
        mstDict.Add(1, m1);
        mstDict.Add(2, m2);

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

    public TowerTemplate GetTower(int typeID) {
        TowerTemplate value;
        bool exist = towerDict.TryGetValue(typeID, out value);
        if (!exist) {
            Debug.LogError("not exist " + typeID.ToString());
            return null;
        }
        return value;
    }

    public MstTemplate GetMst(int typeID) {
        MstTemplate value;
        bool exist = mstDict.TryGetValue(typeID, out value);
        if (!exist) {
            Debug.LogError("not exist " + typeID.ToString());
            return null;
        }
        return value;
    }
}