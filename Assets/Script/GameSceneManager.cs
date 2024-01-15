using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    //メインのsceneに移動
    public void MoveStart()
    {
        SceneManager.LoadScene("Main", LoadSceneMode.Single);
    }

    //タイトルのsceneに移動
    public void MoveTitle()
    {
        SceneManager.LoadScene("Title", LoadSceneMode.Single);
    }

    //Setumeiのsceneに移動
    public void MoveSetumei()
    {
        SceneManager.LoadScene("Setumei", LoadSceneMode.Single);
    }

}
