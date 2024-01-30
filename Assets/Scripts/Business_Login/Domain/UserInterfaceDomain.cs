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

                    UIApp.PN_BulidManifast_Close(gameCtx.uictx);
                    // 打开建造面板 ：增添可建造面板的按钮
                    bool has = gameCtx.tplCtx.towers.TryGetValue(tower.typeID, out TowerTM tm);
                    Debug.Assert(has);
                    if (tm.allowBuildTowerTypeIDs != null && tm.allowBuildTowerTypeIDs.Length > 0) {
                        Vector2 pos = tm.uiPos;

                        UIApp.PN_BuildManifest_Open(gameCtx.uictx, input.mouseWorldPos, pos);
                        for (int j = 0; j < tm.allowBuildTowerTypeIDs.Length; j++) {
                            // 可建造的ID
                            int allowBuildTowerTypeID = tm.allowBuildTowerTypeIDs[j];
                            UIApp.PN_BuildManifest_AddOption(gameCtx.uictx, tower.id, allowBuildTowerTypeID);


                        }

                    }
                    input.isMouseLeftDown = false;


                    break;
                }
            }
        }
    }  //tower
}