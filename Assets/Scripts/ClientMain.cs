using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ClientMain : MonoBehaviour {
    // Start is called before the first frame update
    ClientCtx ctx;

    void Start() {

        Application.targetFrameRate = 120;


        AssetsCtx assetsCtx = gameObject.GetComponentInChildren<AssetsCtx>();
        Canvas canvas = gameObject.GetComponentInChildren<Canvas>();

        ctx = new ClientCtx();
        ctx.Inject(canvas, assetsCtx);

        TemplateInfra.Load(ctx.tplCtx);

        UIApp.PN_Login_Open(ctx.uictx, () => {
            UIApp.PN_Login_Close(ctx.uictx);
            GamesBusiness.Enter(ctx.gameCtx);
        });
    }

    float restDT;
    const float FIXED_INTERVAL = 0.1f;
    // Update is called once per frame
    void Update() {
        float dt = Time.deltaTime;

        GamesBusiness.PreTick(ctx.gameCtx, dt);

        restDT += dt;

        if (restDT <= FIXED_INTERVAL) {
            GamesBusiness.FixedTick(ctx.gameCtx, restDT);
            restDT = 0;
        } else {
            while (restDT >= FIXED_INTERVAL) {
                GamesBusiness.FixedTick(ctx.gameCtx, FIXED_INTERVAL);
                restDT -= FIXED_INTERVAL;
            }
        }

        // LateTick

    }
}