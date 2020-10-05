using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    private Transform Player;
    void Start()
    {
        Player = GameObject.Find("Player").transform;
    }
    void Update()
    {
        Vector3 playerpos = Player.position;
        playerpos.z = transform.position.z;
        transform.position = playerpos;
    }
}
//Reference: https://answers.unity.com/questions/595977/moving-camera-with-player-in-2d.html