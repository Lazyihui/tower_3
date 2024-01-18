using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ClientMain : MonoBehaviour {
    // Start is called before the first frame update

    void Start() {


        AssetsCtx assetsCtx = gameObject.GetComponentInChildren<AssetsCtx>();

        Canvas canvas = gameObject.GetComponentInChildren<Canvas>();
        CanvasScaler scaler = canvas.gameObject.GetComponent<CanvasScaler>();

        ClientCtx ctx = new ClientCtx();
        ctx.Inject(canvas, assetsCtx);

        Debug.Log("hello world");
        UIApp.PN_Login_Open(ctx.uictx, () => {
            UIApp.PN_Login_Close(ctx.uictx);
            GamesBusiness.Enter(ctx.gameCtx);
        });
    }


    // Update is called once per frame
    void Update() {

    }
}
