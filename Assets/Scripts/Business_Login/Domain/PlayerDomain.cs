using UnityEngine;

public static class PlayerDomain {

    public static void Hurt(GameCtx gameCtx, PlayerEntity player, int hurt) {
        player.hp -= hurt;
        if (player.hp <= 0) {
            player.hp = 0;
            Debug.Log("Game Over!");
        }
    }
}