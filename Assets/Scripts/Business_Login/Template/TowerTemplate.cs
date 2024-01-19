using System;
using UnityEngine;
using UnityEngine.UI;

public class TowerTemplate {
    public int typeID;
    public Color color;


    public TowerTemplate(int typeID, Color color) {
        this.typeID = typeID;
    }

    public void Create(Color color, int typeID) {

        this.color = color;
        this.typeID = typeID;

    }

}