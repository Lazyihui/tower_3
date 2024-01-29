using UnityEngine;

public class TowerEntity : MonoBehaviour {

    public int id;
    public int typeID;
    public int price;

    //形状
    public Vector2 shapeSize;


    public bool isSpawner; // 是否生成器
    public float cd; // cooldown 冷却时间
    public float cdMax;
    public float maintain; // 维持时间
    public float maintainTimer;
    public float interval;
    public float intervalTimer;

    public int mstTypeID;
    public Vector2[] path;


    [SerializeField] SpriteRenderer srp;

    // public SpriteRenderer sr;

    public void Ctor() {
        // sr = GetComponent<SpriteRenderer>();
    }
    public void TearDown() {
        Destroy(gameObject);
    }

    // public void SetColor(Color color) {
    //     sr.color = color;
    // }

    public void SetPos(Vector2 pos) {
        transform.position = pos;
    }
    public void SetSprite(Sprite sprite) {
        srp.sprite = sprite;
    }

    void OnDrawGizmos() {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, shapeSize);
    }
}