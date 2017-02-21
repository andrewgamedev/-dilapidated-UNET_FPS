﻿using UnityEngine;
using System.Collections;

public class AmmoPickup : MonoBehaviour {
    [SerializeField]
    private GunType typeOfAmmo;

    [SerializeField]
    private int numberOfbullets;

    [SerializeField]
    private HideGameObject hideGameObject;


    [SerializeField]
    private AudioSource audioSource;

    [SerializeField]
    private AudioClip pickupSound;

    void OnTriggerEnter(Collider coll)
    {
        if (coll.tag == "Player")
        {
            Player player = coll.GetComponent<Player>();


            player.PickupAmmo(numberOfbullets, typeOfAmmo);
            Destroy(gameObject, pickupSound.length + 1f);

            audioSource.PlayOneShot(pickupSound);
            hideGameObject.Hide();

        }


    }


}
