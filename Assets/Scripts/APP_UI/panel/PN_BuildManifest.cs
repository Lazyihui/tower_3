//页面

using System;
using UnityEngine;
using UnityEngine.UI;

public class PN_BuildManifest : MonoBehaviour {
    [SerializeField] Transform btnGroup;

    [SerializeField] PN_BuildManifestElement elePrefab;


    public void Ctor() {
    }

    public void Init(Vector3 worldPos) {
        SetWorldPos(worldPos);
        show();
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