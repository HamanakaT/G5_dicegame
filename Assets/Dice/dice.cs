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
    public GameObject m;
    public GameObject y;
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
                if (meT >= 25)
                {
                    meT = 25;
                }
                idou(a, meT, m);
                a = 1;
            }
        } else {
            you = Random.Range(1, numberOfSides + 1);
            youT += you;
            // 結果をログに表示
            if (youT>=25) {
                youT = 25;
            }
            idou(a, youT, y);
            a = 0;
        }
    }
    void backnum(int t,int n,GameObject d){
        if (d == m)
        {
            meT -= n;
        }
        else {
            youT -= n;
        }
        
    }
    void gonum(int t, int n, GameObject d)
    {
        if (d == m)
        {
            meT += n;
        }
        else
        {
            youT += n;
        }

    }
    void reset(int t, GameObject d)
    {
        if (d == m)
        {
            meT = 0;
        }
        else
        {
            youT = 0;
        }
    }
    void idou(int a,int n,GameObject c) {
        switch (n) {
            case 0:
                c.transform.position = new Vector3(-7.601f, -3.881f, 0f);
                break;
            case 1:
                
                c.transform.position= new Vector3(-6.95f, -3.03f, 0f);
                gonum(n, 6, c);
                if (c == m)
                {
                    idou(a, meT, m);
                }
                else
                {
                    idou(a, youT, y);
                }
                break;
            case 2:
                c.transform.position = new Vector3(-6.78f, -0.94f, 0f);
                break;
            case 3:
                c.transform.position = new Vector3(-8.57f, -2.26f, 0f);
                break;
            case 4:
                c.transform.position = new Vector3(-8.32f, -0.48f, 0f);
                break;
            case 5:
                c.transform.position = new Vector3(-6.58f, 0.08f, 0f);
                break;
            case 6:
                c.transform.position = new Vector3(-5.02f, 0.52f, 0f);
                break;
            case 7:
                c.transform.position = new Vector3(-4.371f, 2.238791f, 0f);
                backnum(n, 3,c);
                if (c == m)
                {
                    idou(a,meT,m);
                }
                else
                {
                    idou(a, youT, y);
                }
                break;
            case 8:
                c.transform.position = new Vector3(-5.741f, 2.3787f, 0f);
                break;
            case 9:
                c.transform.position = new Vector3(-3.531f, 3.0387f, 0f);
                break;
            case 10:
                c.transform.position = new Vector3(-2.711f, 2.5287f, 0f);
                break;
            case 11:
                c.transform.position = new Vector3(-2.241f, 3.4487f, 0f);
                break;
            case 12:
                c.transform.position = new Vector3(-0.791f, 3.2887f, 0f);
                break;
            case 13:
                c.transform.position = new Vector3(-0.461f, 2.1787f, 0f);
                gonum(n, 3, c);
                if (c == m)
                {
                    idou(a, meT, m);
                }
                else
                {
                    idou(a, youT, y);
                }
                break;
            case 14:
                c.transform.position = new Vector3(1.2587f, 2.2987f, 0f);
                break;
            case 15:
                
                c.transform.position = new Vector3(1.4087f, 3.1087f, 0f);
                backnum(n, 2, c);
                if (c == m)
                {
                    idou(a, meT, m);
                }
                else
                {
                    idou(a, youT, y);
                }
                break;
            case 16:
                c.transform.position = new Vector3(2.9687f, 3.1687f, 0f);
                break;
            case 17:
                c.transform.position = new Vector3(4.3887f, 3.18877f, 0f);
                break;
            case 18:
                c.transform.position = new Vector3(5.3387f, 2.8887f, 0f);
                break;
            case 19:
                c.transform.position = new Vector3(3.7687f, 2.0087f, 0f);
                break;
            case 20:
                c.transform.position = new Vector3(4.3287f, 0.9887f, 0f);
                break;
            case 21:
                c.transform.position = new Vector3(-0.06f, 1.2f, 0f);
                break;
            case 22:
                c.transform.position = new Vector3(1.1187f, 0.4487f, 0f);
                break;
            case 23:
                c.transform.position = new Vector3(-1.441f, -0.251f, 0f);
                break;
            case 24:
                c.transform.position = new Vector3(-3.141f, -0.931f, 0f);
                reset(a,c);
                if (c == m)
                {
                    idou(a, meT, m);
                }
                else
                {
                    idou(a, youT, y);
                }
                break;
            case 25:
                c.transform.position = new Vector3(-6.221f, -3.801f, 0f);
                break;
            
                
        }
    }
}
