using UnityEngine;

public class MoveEntity : MonoBehaviour {


    public int id;

    public float moveSpeed;
    public void Ctor() {
    }


    // init 使用
    public void SetPos(Vector2 pos) {
        transform.position = pos;
    }

    public void Move(float x, float y, float dt) {

        Vector2 moveInput = new Vector2(x, y);

        Vector2 pos = this.transform.position;

        pos += moveInput * moveSpeed * dt;

        this.transform.position = pos;


    }

}