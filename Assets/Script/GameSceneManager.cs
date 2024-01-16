using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    //���C����scene�Ɉړ�
    public void MoveStart()
    {
        SceneManager.LoadScene("Main", LoadSceneMode.Single);
    }

    //�^�C�g����scene�Ɉړ�
    public void MoveTitle()
    {
        SceneManager.LoadScene("Title", LoadSceneMode.Single);
    }

    //Setumei��scene�Ɉړ�
    public void MoveSetumei()
    {
        SceneManager.LoadScene("Setumei", LoadSceneMode.Single);
    }

}
