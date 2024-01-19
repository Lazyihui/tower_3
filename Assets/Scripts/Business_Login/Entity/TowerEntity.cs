using UnityEngine;

public class TowerEntity : MonoBehaviour {

    public int id;
    
    public int typeID;

    public SpriteRenderer sr;

    public void Ctor(){
        sr = GetComponent<SpriteRenderer>();
    }

    public void SetColor (Color color){
        sr.color = color ;
    }

    public void SetPos(Vector2 pos){
        transform.position = pos;
    }

}