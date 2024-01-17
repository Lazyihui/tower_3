using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientMain : MonoBehaviour {
    // Start is called before the first frame update

    void Start() {
        AssetsCtx assetsCtx = gameObject.GetComponentInChildren<AssetsCtx>();
        Canvas canvas = gameObject.GetComponentInChildren<Canvas>();
        ClientCtx ctx = new ClientCtx();
        // ctx.uictx.assetsCtx = assetsCtx;
        // ctx.uictx.canvas = canvas;
        ctx.uictx.Inject(canvas,assetsCtx);
        Debug.Log("hello world");
        UIApp.PN_Login_Open(ctx.uictx);
    }

    // Update is called once per frame
    void Update() {

    }
}
