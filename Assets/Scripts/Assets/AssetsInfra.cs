using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public static class AssetsInfra {

    public static void Load(AssetsCtx ctx) {
        {

            AssetLabelReference labelReference = new AssetLabelReference();
            labelReference.labelString = "Entities";
            IList<GameObject> all = Addressables.LoadAssetsAsync<GameObject>(labelReference, null).WaitForCompletion();
            for (int i = 0; i < all.Count; i++) {
                GameObject entity = all[i];
                ctx.entities.Add(entity.name, entity);
            }
        }
        {
            AssetLabelReference labelReference = new AssetLabelReference();
            labelReference.labelString = "Panels";
            IList<GameObject> all = Addressables.LoadAssetsAsync<GameObject>(labelReference, null).WaitForCompletion();
            for (int i = 0; i < all.Count; i++) {
                GameObject panel = all[i];
                ctx.panels.Add(panel.name, panel);
            }
        }
    }
}