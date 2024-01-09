using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceController : MonoBehaviour
{
    public GameObject dice;
    public int diceID =1;
    int a=0;
    public int me;
    public int you;
    // サイコロの面の数
    public int numberOfSides = 6;
    void Start()
    {
        a = 0;
    }

    // サイコロのランダムな値を取得するメソッド
    private int RollDice()
    {
        
        int x = 0;
        switch (diceID) {
            case 1:
                x = Random.Range(1, numberOfSides + 1);
                break;
            case 2:
                x = Random.Range(4, 7);
                break;
         }
        return x;
    }

    // スペースバーが押された時に呼ばれるメソッド
    void Update()
    {
        if(a==0){ 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // サイコロを振り、結果を取得
            int me = RollDice();

            // 結果をログに表示
            Debug.Log("me: " + me);
                a = 1;
        }
    }else {
            int you = Random.Range(1, numberOfSides + 1); ;

            // 結果をログに表示
            Debug.Log("you: " +you);
            a = 0;
        }
    }
    
       
}
