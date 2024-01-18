using System;
using UnityEngine;
using UnityEngine.UI;

public class PN_Login : MonoBehaviour {
    [SerializeField] public Button startBtn;

    public Action OnstartClickHandle;
    public void Ctor() {
        startBtn.onClick.AddListener(() => {
            OnstartClickHandle.Invoke();
        });
    }
    public void Show() {
        gameObject.SetActive(true); // 显示
    }
    public void Close() {
        gameObject.SetActive(false); // 隐藏
    }

    void OnStartClick() {
        Debug.Log("Yo1111;");
    }
}