using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendScore : MonoBehaviour
{
    int EnemeOneScorevalue=1;
    private void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject.tag); 
        collision.gameObject.SetActive(false);
   
    }

    private void GameObjectDestroy(Collision collision)
    {
    if(collision.gameObject.CompareTag("Enemy"))
        {
            print(collision.gameObject.tag);
        Scorer scorer =FindObjectOfType<Scorer>();
        scorer.ScoreCalculator(EnemeOneScorevalue);
        Destroy(collision.gameObject,2.0f);
        }
    }
}
