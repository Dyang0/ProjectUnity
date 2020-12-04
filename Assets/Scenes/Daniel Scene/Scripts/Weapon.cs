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
    public Text ammoClip;

    public bool fullAuto;
    public float ammoCapacity;
    private float clipSize;

    public float reloadTime;
    private float time;

    private void Start()
    {
        cooldown = Time.time;

        clipSize = ammoCapacity;
        time = reloadTime;
    }

    // Update is called once per frame
    void Update()
    {
        

        if (fullAuto == false)
        {

            if (clipSize > 0)
            {
                if (Input.GetButtonDown("Fire1") && Time.time >= cooldown)
                {
                    Shoot();
                    clipSize--;
                    ammoClip.text = clipSize.ToString() + " /" + ammoCapacity;
                    cooldown = Time.time + fireRate;
                }

                if ((cooldown - Time.time) > 0)
                {
                    reloadCooldown.text = (cooldown - Time.time).ToString();
                }
                else
                {
                    reloadCooldown.text = "ready";
                }
            }

            if (clipSize == 0)
            {
                ammoClip.text = "No ammo";

                if (time > 0)
                {
                    reloadCooldown.text = (time -= Time.deltaTime).ToString();
                    
                }
                else
                {
                    time = reloadTime;
                    clipSize = ammoCapacity;
                }

             
            }
        }

        if(fullAuto == true)
        {



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
