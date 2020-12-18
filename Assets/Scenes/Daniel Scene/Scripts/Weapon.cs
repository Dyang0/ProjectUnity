using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Weapon : MonoBehaviour
{
    public Transform firePoint; 
    public GameObject bulletPrefab; //*



  //  private bool allowFire;
    private float fireRate; //*

    private float cooldown; //*
    public Text reloadCooldown;   //*
    public Text ammoClip;             //*Add different weapons with specific d //*

    private int weaponDamage; //*
   // public string typeOfWeapon;

    private bool fullAuto; //*
    private float ammoCapacity; //this variable doesn't change to keep reference of clipSize //*
    private float clipSize; //this variable decreases as each bullet is fired //*

  

    private float reloadTime; //*
    private float time;      //*

    public string weaponName = "null";


    private bool isReloading = false; //checks if the reload button r was pressed 

    private void Start()
    {
        cooldown = Time.time;

        if (weaponName.Equals("null")) //change rate of fire based on name (don't need to make variables public)
        {
            weaponDamage = 0;
            ammoCapacity = 0;
           

            clipSize = ammoCapacity;
            time = reloadTime;

            reloadTime = 0;

            fullAuto = false;



        }

        if (weaponName.Equals("pistol")) //change rate of fire based on name (don't need to make variables public)
        {
            weaponDamage = 10;
            ammoCapacity = 12;
            reloadTime = 2f;
            fireRate = 0.4f;

            clipSize = ammoCapacity;
            time = reloadTime;

            fullAuto = false;

        }

        if (weaponName.Equals("auto")) //change rate of fire based on name (don't need to make variables public)
        {
            weaponDamage = 10;
            ammoCapacity = 50;
            reloadTime = 7f;
            fireRate = 0.07f;

            clipSize = ammoCapacity;
            time = reloadTime;

            fullAuto = true;

        }

        


    }





        // Update is called once per frame
        void Update()
    {
        

        if (fullAuto == false)
        {

            if (clipSize > 0)
            {
                ammoClip.text = clipSize.ToString() + "/" + ammoCapacity;

                if (Input.GetButtonDown("Fire1") && Time.time >= cooldown)
                {
                    Shoot();
                    clipSize--;
                    ammoClip.text = clipSize.ToString() + "/" + ammoCapacity;
                    cooldown = Time.time + fireRate;
                }

                if ((cooldown - Time.time) > 0)
                {
                    reloadCooldown.text = (cooldown - Time.time).ToString("f2");
                  
                }
                else
                {
                    reloadCooldown.text = "ready";
                }
            }
            else
            {
                reloadCooldown.text = "Reload (R)";
            }




            if (clipSize == 0 && Input.GetKey("r"))
            {
                isReloading = true;
            }






                if (clipSize == 0 && isReloading == true)
            {
                ammoClip.text = "..."; //maybe animate text

                if (time > 0)
                {
                    reloadCooldown.text = (time -= Time.deltaTime).ToString("f2");
                    
                }
                else
                {
                    time = reloadTime;
                    clipSize = ammoCapacity;
                    isReloading = false;
                }

             
            }
        
        }

        if(fullAuto == true)
        {

            if (clipSize > 0)
            {
                ammoClip.text = clipSize.ToString() + "/" + ammoCapacity;

                if (Input.GetButton("Fire1") && Time.time >= cooldown)
                {
                    Shoot();
                    clipSize--;
                    ammoClip.text = clipSize.ToString() + "/" + ammoCapacity;
                    cooldown = Time.time + fireRate;

                }

                if ((cooldown - Time.time) > 0)
                {
                    reloadCooldown.text = (cooldown - Time.time).ToString("f2"); //shows rate of fire cooldown (might delete later - no point if the gun is already full auto, too fast)

                }
                else
                {
                    reloadCooldown.text = "ready";
                }


            }
            else
            {
                reloadCooldown.text = "Reload (R)";
            }




            if (clipSize == 0 && Input.GetKey("r"))
            {
                isReloading = true;
            }






            if (clipSize == 0 && isReloading == true)
            {
                ammoClip.text = "..."; //maybe animate text

                if (time > 0)
                {
                    reloadCooldown.text = (time -= Time.deltaTime).ToString("f2");

                }
                else
                {
                    time = reloadTime;
                    clipSize = ammoCapacity;
                    isReloading = false;
                }


            }

        }

    }

    void Shoot()
    {
        // shooting logic
        // allowFire = false;
     //   Bullet bull = gameObject.AddComponent<Bullet>();
        

        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
       // yield return new WaitForSeconds(0.25f);
       // allowFire = true;
    }   //spawn bullets, (what you want to spawn, where you want to spawn it.with what rotation)
}
