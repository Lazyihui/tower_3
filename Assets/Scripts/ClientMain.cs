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


        Canvas screenCanvas = gameObject.transform.Find("ScreenCanvas").GetComponentInChildren<Canvas>();
        Canvas worldCanvas = gameObject.transform.Find("WorldCanvas").GetComponentInChildren<Canvas>();
        Camera mainCamera = gameObject.GetComponentInChildren<Camera>();
        Debug.Assert(screenCanvas != null);
        Debug.Assert(worldCanvas != null);

        ctx = new ClientCtx();
        //注入
        ctx.Inject(mainCamera, screenCanvas, worldCanvas);
        // BindingEvents events
        BindingEvents(ctx);


        AssetsInfra.Load(ctx.assetsCtx);
        TemplateInfra.Load(ctx.tplCtx);

        UIApp.PN_Login_Open(ctx.uictx);


    }

    void BindingEvents(ClientCtx ctc) {

        UIEvents uIEvents = ctx.uictx.events;

        uIEvents.Login_OnStartClickHandle = () => {
            UIApp.PN_Login_Close(ctx.uictx);
            GamesBusiness.Enter(ctx.gameCtx);
        };
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
        GamesBusiness.LateTick(ctx.gameCtx, dt);

    }
}