using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class Song_Swap : MonoBehaviour, IPointerClickHandler
{
    private GameObject[] sources;
    
    public bool swap;  
    public AudioClip otherclip;
    public AudioClip initialclip;
    // Use this for initialization
    void Start () {
        
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        sources = GameObject.FindGameObjectsWithTag("Song");


        if (swap)
        {
            swap = false;
            foreach (GameObject source in sources)
            {
                AudioSource temp = source.GetComponent<AudioSource>();
                temp.clip = otherclip; temp.Play();
            }
        }
        else {
            swap = true;
                foreach (GameObject source in sources)
                {
                    AudioSource temp = source.GetComponent<AudioSource>();
                    temp.clip = initialclip; temp.Play();
                }
            }
    }
	// Update is called once per frame
	void Update () {
	
	}
}
