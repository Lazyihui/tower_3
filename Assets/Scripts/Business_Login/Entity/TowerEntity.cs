using UnityEngine;

public class TowerEntity : MonoBehaviour {

    public int id;

    public int typeID;

    public bool isSpawner; // 是否生成器
    // 每次CD结束, 生成怪物总量: maintain / interval
    public float cd; // cooldown 冷却时间
    public float cdMax;
    public float maintain; // 维持时间
    public float maintainTimer;
    public float interval;
    public float intervalTimer;
    public Vector2[] path;


    public SpriteRenderer sr;

    public void Ctor() {
        sr = GetComponent<SpriteRenderer>();
    }

    public void SetColor(Color color) {
        sr.color = color;
    }

    public void SetPos(Vector2 pos) {
        transform.position = pos;
    }

}