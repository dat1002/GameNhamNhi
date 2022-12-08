using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private Transform player;
    private float minX = 0; 
    private float maxX = 50;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(player != null)
        {
            Vector3 vitri = transform.position;
            vitri.x = player.position.x;
            if(vitri.x < minX)
                vitri.x = 0;
            if(vitri.x > maxX)
                vitri.x = maxX;
            transform.position = vitri;
        }
    }
}
