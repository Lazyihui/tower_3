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

    public void Move(float x, float z, float dt) {

        Vector3 moveInput = new Vector3(x, 0, z);

        Vector3 pos = this.transform.position;

        pos += moveInput * moveSpeed * dt;

        this.transform.position = pos;


    }

}