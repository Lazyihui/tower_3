using UnityEngine;
using System;
public static class UserInterfaceDomain {

    public static void PreTick(GameCtx gameCtx, float dt) {

        InputEntity input = gameCtx.inputEntity;

        if (input.isMouseLeftDown) {
            int towerLen = gameCtx.towerRepository.TakeAll(out TowerEntity[] towers);
            for (int i = 0; i < towerLen; i++) {
                TowerEntity tower = towers[i];
                if (PFPhysics.IsPointInsideRectangle(input.mouseWorldPos, tower.transform.position, tower.shapeSize)) {
                    Debug.Log("Tower isclick" + tower.name);
                    // 打开建造面板 ：增添可建造面板的按钮
                    UIApp.PN_BuildManifest_Open(gameCtx.uictx, input.mouseWorldPos);
                    UIApp.PN_BuildManifest_AddOption(gameCtx.uictx, tower.id, tower.typeID);
                    UIApp.PN_BuildManifest_AddOption(gameCtx.uictx, tower.id, tower.typeID);





                    input.isMouseLeftDown = false;

                    break;
                }
            }
        }
    }  //tower
}