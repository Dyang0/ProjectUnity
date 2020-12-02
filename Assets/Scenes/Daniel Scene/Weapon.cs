using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    private bool allowFire;
    public float fireRate = 1f;
    private float cooldown;
    public Text reloadCooldown;

    private void Start()
    {
        cooldown = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.time >= cooldown)
        {
            Shoot();
            cooldown = Time.time + fireRate;
        }

        if ((cooldown - Time.time) > 0) { 
            reloadCooldown.text = (cooldown - Time.time).ToString();
         }
        else
        {
            reloadCooldown.text = "ready";
        }
        
    }

    void Shoot()
    {
        // shooting logic
       // allowFire = false;
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
       // yield return new WaitForSeconds(0.25f);
       // allowFire = true;
    }   //spawn bullets, (what you want to spawn, where you want to spawn it.with what rotation)
}
