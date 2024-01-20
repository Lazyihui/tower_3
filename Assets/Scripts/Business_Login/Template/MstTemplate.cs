using System;
using UnityEngine;
using UnityEngine.UI;

public class MstTemplate {
    public int typeID;

    public float moveSpeed;

    public Color color;


    public MstTemplate(int typeID, float moveSpeed, Color color) {
        this.typeID = typeID;
        this.moveSpeed = moveSpeed;
        this.color = color;
    }

}