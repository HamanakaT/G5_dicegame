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
                me = RollDice();

                // ���ʂ����O�ɕ\��
                meT += me;
                a = 1;
            }
        } else {
            you = Random.Range(1, numberOfSides + 1);
            youT += you;
            // ���ʂ����O�ɕ\��
            a = 0;
        }
    }
    void backnum(int t,int n){
        t -= n;
    }
       
}
