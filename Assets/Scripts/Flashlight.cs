using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{

    public Transform player;
    [SerializeField]
    private int speed = 2;
    void Update()
    {
        
            var rotation = player.rotation;
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * speed);
            transform.position = player.position;
        
    }
}
