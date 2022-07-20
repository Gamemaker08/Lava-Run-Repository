using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed = 1;
    public Vector3 respawnPosition;

    void Start()
    {
        respawnPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
        Vector3 movement = new Vector3(horizontal, 0,vertical) * speed * Time.deltaTime;
        transform.Translate(movement);
    }

    public void RespawnPlayer()
    {
        transform.position = respawnPosition;
    }





} 
