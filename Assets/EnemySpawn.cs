using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      InvokeRepeating("EnemySpawnmethod",2.0f,2.0f);
       //Invoke("EnemySpawnmethod",2.0f);
    }

private void EnemySpawnmethod()
{
    float x=Random.Range(-5.0f,5f);
    float z=Random.Range(-4.0f,4.0f);
    Vector3 enemyPosition= new Vector3(x,1.0f,z);
    transform.position=enemyPosition;
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
