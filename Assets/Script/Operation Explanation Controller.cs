using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OperationExplanationController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //クリックされたら操作説明にいく
    public void SwitchScene()
    {
        SceneManager.LoadScene("Setumei", LoadSceneMode.Single);
    }
}
