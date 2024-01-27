using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class PN_HeartInfo : MonoBehaviour {
    [SerializeField] Image elePrefab;
    [SerializeField] Transform heartGroup;


    List<Image> elements;

    public void Ctor() {
        elements = new List<Image>();
    }

    public void Init(int hp) {
        int lastHp = elements.Count;
        int diff = hp - lastHp;

        // 本次比上次少
        if (diff < 0) {
            // diff == -1
            for (int i = -diff - 1; i >= 0; i--) {
                Image ele = elements[elements.Count - 1];
                elements.RemoveAt(elements.Count - 1);
                GameObject.Destroy(ele.gameObject);
            }
        } else if (diff > 0) {
            // diff == 1
            for (int i = 0; i < diff; i++) {
                Image ele = GameObject.Instantiate(elePrefab, heartGroup);
                elements.Add(ele);
            }
        } else {
            // do nothing
        }
    }

    public void Show() {
        gameObject.SetActive(true);
    }
    public void Close() {
        gameObject.SetActive(false);
    }
}