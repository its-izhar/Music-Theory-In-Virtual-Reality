﻿using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class Swap_From_3D : MonoBehaviour
{
    private GameObject[] songs;
    private GameObject[] zones;
    public bool is3d = true;

    public GameObject player;
    public Transform Player;
    
	// Use this for initialization
	void Start () {

        Player = player.GetComponent<Transform>();
        zones = GameObject.FindGameObjectsWithTag("Zones");

    }
    public void trigger()
    {
        


        songs = GameObject.FindGameObjectsWithTag("Song");
        if (is3d)
        {
          //  foreach (GameObject song in songs) 
               // song.GetComponent<AudioSource>().spatialBlend = 0.0f;
             
            foreach(GameObject zone in zones)
                zone.SetActive(false);

            is3d = false;


        }
        else
        {
          //  foreach (GameObject song in songs)
          //      song.GetComponent<AudioSource>().spatialBlend = 1.0f;
         
            foreach (GameObject zone in zones)
                zone.SetActive(true);

            is3d = true;


        }
    }

        // Update is called once per frame
        void Update () {


    }
}
