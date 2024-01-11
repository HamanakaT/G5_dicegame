using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; //TextMeshPro‚ğg‚¤ê‡‚Í“Ç‚İ‚İ‚ª•K—v


public class you : MonoBehaviour
{
    public TextMeshProUGUI numcount;
    public GameObject d;
    public static int N;
    // Start is called before the first frame update
    void Start()
    {
        N = 0;
    }

    // Update is called once per frame
    void Update()
    {
        N = d.GetComponent<DiceController>().you;
        numcount.text = "com;" + d.GetComponent<DiceController>().you;
    }
}
