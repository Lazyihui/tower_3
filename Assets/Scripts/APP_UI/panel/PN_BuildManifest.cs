//页面

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PN_BuildManifest : MonoBehaviour {
    [SerializeField] Transform btnGroup;

    [SerializeField] PN_BuildManifestElement elePrefab;

    List<PN_BuildManifestElement> elements;


    public void Ctor() {
        elements = new List<PN_BuildManifestElement>();
    }

    public void Init(Vector3 worldPos) {
        SetWorldPos(worldPos);
        show();
    }

    public void TearDown() {
        for (int i = 0; i < elements.Count; i++) {
            GameObject.Destroy(elements[i].gameObject);
        }
    }
    public void AddOption(int clickedTowerEntityID, int clickedTowerTypeID, int price, Sprite icon) {
        PN_BuildManifestElement ele = GameObject.Instantiate(elePrefab, btnGroup);
        ele.Ctor(clickedTowerEntityID,clickedTowerTypeID,price,icon);

        elements.Add(ele);
    }

    void show() {
        gameObject.SetActive(true);
    }

    public void Hide() {
        gameObject.SetActive(false);
    }
    //添加按钮
    public void Add() { }
    //显示的位置 位置是世界坐标
    public void SetWorldPos(Vector3 worldPos) {
        transform.position = worldPos;
    }

}