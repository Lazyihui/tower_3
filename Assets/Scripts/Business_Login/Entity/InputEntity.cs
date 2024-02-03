using UnityEngine;

public class InputEntity {
    // public Vector2 moveDir>
    public Vector2 mouseScreenPos;

    public Vector2 mouseWorldPos;

    public bool isMouseLeftDown;

    public InputEntity() { }

    public void Reset() {
        mouseScreenPos = Vector2.zero;
        mouseWorldPos = Vector2.zero;
        isMouseLeftDown = false;
    }
    public Vector2 ProcessMoveInput() {

        // 输入
        Vector2 axis = Vector2.zero; // x = 0, y = 0
        
        if (Input.GetKey(KeyCode.W)) {
            axis.y = 1;
        } else if (Input.GetKey(KeyCode.S)) {
            axis.y = -1;
        }

        if (Input.GetKey(KeyCode.A)) {
            axis.x = -1;
        } else if (Input.GetKey(KeyCode.D)) {
            axis.x = 1;
        }

        axis.Normalize(); // 归一化, 保证长度为1

        return axis;

    }
}