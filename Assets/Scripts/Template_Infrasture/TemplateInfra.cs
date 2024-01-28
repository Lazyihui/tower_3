
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class TemplateInfra {

    public static void Load(TemplateCtx ctx) {
        {
            AssetLabelReference labelReference = new AssetLabelReference();
            labelReference.labelString = "TM_Mst"; // label
            IList<MstTM> all = Addressables.LoadAssetsAsync<MstTM>(labelReference, null).WaitForCompletion();
            for (int i = 0; i < all.Count; i += 1) {
                MstTM tm = all[i];
                ctx.msts.Add(tm.typeID, tm);
            }
        }
        {
            AssetLabelReference labelReference = new AssetLabelReference();
            labelReference.labelString = "TM_Tower"; // label
            IList<TowerTM> all = Addressables.LoadAssetsAsync<TowerTM>(labelReference, null).WaitForCompletion();
            for (int i = 0; i < all.Count; i += 1) {
                TowerTM tm = all[i];
                ctx.towers.Add(tm.typeID, tm);
            }
        }

    }
}

