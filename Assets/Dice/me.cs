using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; //TextMeshProを使う場合は読み込みが必要

public class me : MonoBehaviour
{
    public TextMeshProUGUI numcount;
    public GameObject d;
    public static int M;
    // Start is called before the first frame update
    void Start()
    {
        M = 0;
    }

    // Update is called once per frame
    void Update()
    {
        M = d.GetComponent<DiceController>().me;
        Debug.Log("n: " + M);
        numcount.text = "you;" + d.GetComponent<DiceController>().me;
    }
}
