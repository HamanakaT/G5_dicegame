using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceN : Dice1
{
    public GameObject go;
    public int min = 0;
    public int max = 0;
    public int RollDice(int min,int max)
    {
        int x = 0;
        x = Random.Range(min,  max+1);
             
        
        return x;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // サイコロを振り、結果を取得
            int result = RollDice(min,max);

            // 結果をログに表示
            Debug.Log("サイコロの結果: " + result);
        }
    }
}
