//页面

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PN_BuildManifest : MonoBehaviour {
    [SerializeField] Transform btnGroup;

    [SerializeField] PN_BuildManifestElement elePrefab;

    List<PN_BuildManifestElement> elements;

    public Action<int, int> OnBuildHandle;


    public void Ctor() {
        elements = new List<PN_BuildManifestElement>();

    }

    public void Init(Vector3 worldPos,Vector2 pos) {
        SetWorldPos(worldPos);
        show();
        transform.position = pos;
    }

    public void TearDown() {
        GameObject.Destroy(gameObject);
        for (int i = 0; i < elements.Count; i++) {
            GameObject.Destroy(elements[i].gameObject);
        }
    }
    public void AddOption(int clickedTowerEntityID, int clickedTowerTypeID, int price, Sprite icon) {
        PN_BuildManifestElement ele = GameObject.Instantiate(elePrefab, btnGroup);
        ele.Ctor(clickedTowerEntityID, clickedTowerTypeID, price, icon);
        //绑定
        ele.OnBuildHandle = ElementClick;
        elements.Add(ele);
    }

    void ElementClick(int clickedTowerEntityID, int clickedTowerTypeID) {
        OnBuildHandle.Invoke(clickedTowerEntityID, clickedTowerTypeID);
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