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
    // �T�C�R���̖ʂ̐�
    public int numberOfSides = 6;
    void Start()
    {
        a = 0;
    }

    // �T�C�R���̃����_���Ȓl���擾���郁�\�b�h
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

    // �X�y�[�X�o�[�������ꂽ���ɌĂ΂�郁�\�b�h
    void Update()
    {
        Debug.Log("you: " + you);
        Debug.Log("me: " + me);
        if (a == 0) {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                // �T�C�R����U��A���ʂ��擾
                //me = RollDice();
                me = 1;
                // ���ʂ����O�ɕ\��
                meT += me;
                idou(a, meT, m);
                a = 1;
            }
        } else {
            you = Random.Range(1, numberOfSides + 1);
            youT += you;
            // ���ʂ����O�ɕ\��
            idou(a, youT, y);
            a = 0;
        }
    }
    void backnum(int t,int n){
        t -= n;
    }
       void idou(int a,int n,GameObject c) {
        switch (n) {
            case 1:
                c.transform.position= new Vector3(6.2f, 1.9f, 0f);
                break;
            case 2:
                c.transform.position = new Vector3(6.2f, 1.9f, 0f);
                break;
            case 3:
                c.transform.position = new Vector3(6.2f, 1.9f, 0f);
                break;
            case 4:
                c.transform.position = new Vector3(6.2f, 1.9f, 0f);
                break;
            case 5:
                c.transform.position = new Vector3(6.2f, 1.9f, 0f);
                break;
            case 6:
                c.transform.position = new Vector3(6.2f, 1.9f, 0f);
                break;
            case 7:
                c.transform.position = new Vector3(6.2f, 1.9f, 0f);
                break;
            case 8:
                c.transform.position = new Vector3(6.2f, 1.9f, 0f);
                break;
            case 9:
                c.transform.position = new Vector3(6.2f, 1.9f, 0f);
                break;
            case 10:
                c.transform.position = new Vector3(6.2f, 1.9f, 0f);
                break;
            case 11:
                c.transform.position = new Vector3(6.2f, 1.9f, 0f);
                break;
            case 12:
                c.transform.position = new Vector3(6.2f, 1.9f, 0f);
                break;
            case 13:
                c.transform.position = new Vector3(6.2f, 1.9f, 0f);
                break;
            case 14:
                c.transform.position = new Vector3(6.2f, 1.9f, 0f);
                break;
            case 15:
                c.transform.position = new Vector3(6.2f, 1.9f, 0f);
                break;
            case 16:
                c.transform.position = new Vector3(6.2f, 1.9f, 0f);
                break;
            case 17:
                c.transform.position = new Vector3(6.2f, 1.9f, 0f);
                break;
            case 18:
                c.transform.position = new Vector3(6.2f, 1.9f, 0f);
                break;
            case 19:
                c.transform.position = new Vector3(6.2f, 1.9f, 0f);
                break;
            case 20:
                c.transform.position = new Vector3(6.2f, 1.9f, 0f);
                break;
            case 21:
                c.transform.position = new Vector3(6.2f, 1.9f, 0f);
                break;
            case 22:
                c.transform.position = new Vector3(6.2f, 1.9f, 0f);
                break;
            case 23:
                c.transform.position = new Vector3(6.2f, 1.9f, 0f);
                break;
            case 24:
                c.transform.position = new Vector3(6.2f, 1.9f, 0f);
                break;
            case 25:
                c.transform.position = new Vector3(6.2f, 1.9f, 0f);
                break;
            
                
        }
    }
}
