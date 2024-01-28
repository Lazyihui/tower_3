using System;
using System.Collections.Generic;
using UnityEngine;

public class TemplateCtx {
    public Dictionary<int, MstTM> msts;
    public Dictionary<int, TowerTM> towers;

    public TemplateCtx() {
        msts = new Dictionary<int, MstTM>();
        towers = new Dictionary<int, TowerTM>();
    }

}