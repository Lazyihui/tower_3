//按钮
using System;
using UnityEngine;
using UnityEngine.UI;

public class PN_BuildManifestElement : MonoBehaviour {
    [SerializeField] Button button;

    public int clickedTowerEntityID;
    public int clickedTowerTypeID;

    //显示
    [SerializeField] Text priceTxt;
    [SerializeField] Image icon;

    public Action<int, int> OnBuildHandle;
    public void Ctor(int clickedTowerEntityID, int clickedTowerTypeID, int price, Sprite icon) {
        this.clickedTowerEntityID = clickedTowerEntityID;
        this.clickedTowerTypeID = clickedTowerTypeID;

        this.priceTxt.text = price.ToString();
        this.icon.sprite = icon;

        button.onClick.AddListener(() => {
            OnBuildHandle.Invoke(clickedTowerEntityID, clickedTowerTypeID);
        });
    }
}
