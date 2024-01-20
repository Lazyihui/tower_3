using System;
using UnityEngine;
using UnityEngine.UI;

public class TowerTemplate {
    public int typeID;
    public Color color;


    public TowerTemplate(int typeID, Color color) {
        this.typeID = typeID;
        this.color = color;
    }

    // public void Create(Color color, int typeID) {

    //     this.color = color;
    //     this.typeID = typeID;

    // }

}