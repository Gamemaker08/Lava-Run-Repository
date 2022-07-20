using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lavahurt : MonoBehaviour
{

    public Vector3 startPosition = new Vector3();


    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            other.GetComponent<playerMovement>().RespawnPlayer();
        }


    }
}