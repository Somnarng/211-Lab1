using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndSceneCredits : MonoBehaviour
{
    public GameObject credits;
    public GameObject tbc;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            tbc.SetActive(false);
            credits.SetActive(true);
        }
    }
}
