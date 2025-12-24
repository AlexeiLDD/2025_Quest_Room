using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapPlayerOnEnter : MonoBehaviour
{
    public GameObject myDoor;
    
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collided with: " + other.gameObject.name);

        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Player detected!");
            myDoor.SetActive(true);
        }
    }
   
}
