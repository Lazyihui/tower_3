using UnityEngine;

public class FlagEntity : MonoBehaviour {

    public int id;

    public int typeID;
    public SpriteRenderer sr;

    //构造在创建的时候
    public void Ctor() {
        sr = GetComponent<SpriteRenderer>();
    }

    public void SetColor(Color color) {
        sr.color = color;
    }
    // init 使用
    public void SetPos(Vector2 pos) {
        transform.position = pos;
    }

}