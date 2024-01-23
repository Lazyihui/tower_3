using System.Collections.Generic;
using UnityEngine;

public class AssetsCtx {

    public FlagEntity flagEntity;

    public TowerEntity towerEntity;

    public MstEntity mstEntity;

    public Dictionary<string, GameObject> entities;

    public Dictionary<string, GameObject> panels;

    public AssetsCtx() {
        entities = new Dictionary<string, GameObject>();
        panels = new Dictionary<string, GameObject>();
    }

    public bool Panel_TryGetPrefab(string name, out GameObject prefab) {
        Debug.Log("Get" + name);
        return panels.TryGetValue(name, out prefab);

    }

}