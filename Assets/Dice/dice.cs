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
        if(a==0){ 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // �T�C�R����U��A���ʂ��擾
            int me = RollDice();

            // ���ʂ����O�ɕ\��
            Debug.Log("me: " + me);
                a = 1;
        }
    }else {
            int you = Random.Range(1, numberOfSides + 1); ;

            // ���ʂ����O�ɕ\��
            Debug.Log("you: " +you);
            a = 0;
        }
    }
    
       
}
