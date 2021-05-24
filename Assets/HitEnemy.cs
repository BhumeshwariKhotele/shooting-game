using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEnemy : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name=="Enemy")
        {
            print("I hit a enemy");
        }
    }
}
