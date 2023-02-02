using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCLookAt : MonoBehaviour
{
    public Transform player;
    [SerializeField]
    private int speed = 5;
    private bool DialogueIN = false;
    void Update()
    {
        if (DialogueIN == true)
        {
            var lookPos = player.position - transform.position;
            lookPos.y = 0;
            var rotation = Quaternion.LookRotation(lookPos);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * speed);
        }
        else{
            var defRotation = Quaternion.Euler(0, 180, 0);
            transform.rotation = Quaternion.Slerp(transform.rotation, defRotation, Time.deltaTime * speed);
        }
    }

    public void DiFlip()
    {
        DialogueIN = !DialogueIN;
    }
    }
