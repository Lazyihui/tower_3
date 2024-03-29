using System;
using UnityEngine;

[CreateAssetMenu(fileName = "TM_Tower", menuName = "TD/TM_Tower")]


public class TowerTM : ScriptableObject {
    [Header("Basic")]
    public int typeID;
    public string typeName;

    public int price;
    public Vector2 shapeSize;

    public Vector2 uiPos;

    [Header("Spawner")]
    public bool isSpawner;
    public float cd; // cooldown 冷却时间
    public float maintain; // 维持时间
    public float interval;
    public int mstTypeID;
    public Vector2[] path;

    // 点击该类型塔时, 可建造的其他塔
    [Header("Build Manifest")]
    public int[] allowBuildTowerTypeIDs;

    [Header("Render")]
    public Sprite sprite;
}