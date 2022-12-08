using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bulletPrefab;
    public bool fire = false;
    public float firerate = 5;
    public float nextFire = 0.0f;

    void Update()
  {
      if(!fire)
      {
         nextFire += Time.deltaTime;
         if(nextFire > firerate)
         {
            fire = true;
            nextFire = 0f;
         }
      }

      if(Input.GetMouseButton(0) && fire)
      {
        fire = false;
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
      }
 }

}
