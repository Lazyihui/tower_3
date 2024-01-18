using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ClientMain : MonoBehaviour {
    // Start is called before the first frame update

    void Start() {

        GameObject ngo = new GameObject("aaa");

        AssetsCtx assetsCtx = gameObject.GetComponentInChildren<AssetsCtx>();
        Canvas canvas = gameObject.GetComponentInChildren<Canvas>();
        canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
        Scene curScene = SceneManager.GetActiveScene();
        GameObject[] arr = curScene.GetRootGameObjects();
        for (int i = 0; i < arr.Length; i += 1) {
            Debug.Log(arr[i].name);
        }
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
