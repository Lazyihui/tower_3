using UnityEngine;

public class FlagEntity : MonoBehaviour {

    public int id;

    public int typeID;
    public Color color;
    public void Ctor() {}

    public void SetPos(Vector2 pos) {
        transform.position = pos;
    }

}