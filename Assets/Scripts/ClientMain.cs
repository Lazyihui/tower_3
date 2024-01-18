using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientMain : MonoBehaviour {
    // Start is called before the first frame update

    void Start() {
        AssetsCtx assetsCtx = gameObject.GetComponentInChildren<AssetsCtx>();
        Canvas canvas = gameObject.GetComponentInChildren<Canvas>();
        ClientCtx ctx = new ClientCtx();

        // Vector2 self = new Vector2();
        // // f(o), fucntion object
        // // C: fuction(&self)

        // // o.f()
        // // C#: self.function()

        // 无 static
        // Vector2 pos = new Vector2(1, 3);
        // pos.Normalize();
        
        // 有 static
        // Vector2 other = new Vector2(2, 3);
        // Vector2 max = Vector2.Max(new Vector2(1, 3), new Vector2(2, 2));

        ctx.Inject(canvas, assetsCtx);
        Debug.Log("hello world");
        UIApp.PN_Login_Open(ctx.uictx);
    }


    // Update is called once per frame
    void Update() {

    }
}
