using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //�N���b�N���ꂽ��Q�[�����n�߂�
    public void SwitchScene()
    {
        SceneManager.LoadScene("Main", LoadSceneMode.Single);
    }
}
