using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectCoin : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<playerMovement>();
            Destroy(gameObject);
        }
    }
}
