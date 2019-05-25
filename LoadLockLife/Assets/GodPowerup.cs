﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GodPowerup : MonoBehaviour
{
    GameObject player;
    GameManager gameManager; 

    private void Start() {
        player = GameObject.Find("Player");
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject == player)
        {
            player.GetComponent<PlayerController>().enableGodMode();
            player.GetComponent<Renderer>().material = gameObject.GetComponent<Renderer>().material;
            Destroy(gameObject);
        }
    }
}