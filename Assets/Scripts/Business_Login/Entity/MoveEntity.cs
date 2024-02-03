using UnityEngine;

public class MoveEntity : MonoBehaviour {


    public int id;
    public void Ctor() {
    }


    // init 使用
    public void SetPos(Vector2 pos) {
        transform.position = pos;
    }

    public void Move() { }

}