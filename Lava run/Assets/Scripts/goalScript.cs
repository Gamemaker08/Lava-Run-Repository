using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goalScript : MonoBehaviour
{
    bool hasPlayed = false;
    private void OnTriggerEnter(Collider other)
    
    {
        if (other.gameObject.tag == "Player")
        {
           GetComponent<Animator>().SetTrigger("Goal Touched");
            
            //Audio
            if (hasPlayed == false)
                GetComponent<AudioSource>().Play();
            hasPlayed = true;
        
        }
    }




}
        