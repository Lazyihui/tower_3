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

    }

    public void Show() {
        gameObject.SetActive(true);
    }
    public void Close() {
        gameObject.SetActive(false);
    }
}