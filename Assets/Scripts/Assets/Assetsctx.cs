using System.Collections.Generic;
using UnityEngine;

public class AssetsCtx {


    public Dictionary<string, GameObject> entities;

    public Dictionary<string, GameObject> panels;

    public AssetsCtx() {
        entities = new Dictionary<string, GameObject>();
        panels = new Dictionary<string, GameObject>();
    }

    public bool Panel_TryGetPrefab(string name, out GameObject prefab) {
        return panels.TryGetValue(name, out prefab);

    }
    public bool Entity_TryGetPrefab(string name, out GameObject prefab) {
        return entities.TryGetValue(name, out prefab);

    }

}