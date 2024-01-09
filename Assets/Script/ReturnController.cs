using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //クリックされたらスタート画面に戻る
    public void SwitchScene()
    {
        SceneManager.LoadScene("Title", LoadSceneMode.Single);
    }
}
