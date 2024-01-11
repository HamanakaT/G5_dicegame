using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceController : MonoBehaviour
{
    public GameObject dice;
    public int diceID = 1;
    int a = 0;
    public int me;
    public int you;
    public int meT = 0;
    public int youT = 0;
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
        Debug.Log("you: " + you);
        Debug.Log("me: " + me);
        if (a == 0) {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                // サイコロを振り、結果を取得
                me = RollDice();

                // 結果をログに表示
                meT += me;
                a = 1;
            }
        } else {
            you = Random.Range(1, numberOfSides + 1);
            youT += you;
            // 結果をログに表示
            a = 0;
        }
    }
    void backnum(int t,int n){
        t -= n;
    }
       
}
