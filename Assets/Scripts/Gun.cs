using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform launchPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FireBullet()
    {
        GameObject bullet = Instantiate(bulletPrefab);
        bullet.transform.position = launchPosition.position;
        bullet.GetComponent<Rigidbody>().velocity = transform.parent.forward * 100;
    }

}
