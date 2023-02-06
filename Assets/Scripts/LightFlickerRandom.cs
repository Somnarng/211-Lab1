using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlickerRandom : MonoBehaviour
{
    public Animator anim;
    public int flick = 0;

    private void Start()
    {
        InvokeRepeating("flicker", 0, 10);
    }

    void Update()
    {
      if(flick == 1)
        {
            anim.SetTrigger("Flicker");
            flick = 0;
        }
        else
        {
            anim.ResetTrigger("Flicker");
        }
    }
    void flicker()
    {
        flick = Random.Range(0, 3);
        print(flick);
    }
}
