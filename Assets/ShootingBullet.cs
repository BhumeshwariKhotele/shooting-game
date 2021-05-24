
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingBullet: MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bulletObj;
    public float bulletspeed=1.0f;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       /* if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            BulletMovement(Vector3.forward);
        }
        else   if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            BulletMovement(Vector3.back);
        }
        else         if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            BulletMovement(Vector3.left);
        }
        else         if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            BulletMovement(Vector3.right);
        }*/
        if (Input.GetMouseButtonDown(0))
        {
            BulletMovement(Vector3.forward);
        }
       

    }

    private void BulletMovement(Vector3 direction)
    {
        GameObject bulletGeneratedRef = Instantiate(bulletObj);
        bulletGeneratedRef.transform.position = transform.position;
        Rigidbody rb = bulletGeneratedRef.GetComponent<Rigidbody>();
        Camera camera=GetComponentInChildren<Camera>();
        rb.velocity= camera.transform.rotation*Vector3.forward*bulletspeed;
    }
}
