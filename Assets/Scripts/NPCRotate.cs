using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCRotate : MonoBehaviour
{
    public Transform player;


    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.position);
        transform.rotation = Quaternion.LookRotation(-player.forward);
    }
}
