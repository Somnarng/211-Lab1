using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScene : MonoBehaviour
{

 public void ChangeScene()
    {
        Invoke("SceneChange", 1);
    }
    public void SceneChange()
    {
        SceneManager.LoadScene("EndScene");
    }
}
