using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkPoint : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            {
                Vector3 newPosition = transform.position;
                newPosition.y = newPosition.y + 1;
                other.GetComponent<playerMovement>().respawnPosition = newPosition;
            }




        }

    }
}
