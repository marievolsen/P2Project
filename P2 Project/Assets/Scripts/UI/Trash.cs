using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    { 

        //collision.gameObject.CompareTag("Ikon"))
        
            Destroy(collision.gameObject);

            Debug.Log("Ødelagt");
        
    }
}
