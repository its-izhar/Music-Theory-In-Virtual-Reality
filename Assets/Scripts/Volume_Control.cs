using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class Volume_Control : MonoBehaviour, IPointerClickHandler
{

    
    public AudioSource source,source2;
    public int assign;
    Color temp;
    Song_Swap song_swap;

    // Use this for initialization
    void Awake()
    {
        temp = GetComponent<SpriteRenderer>().material.color;
        GameObject Temp;
        switch (assign)
        {
            case 0:
                Temp = GameObject.Find("Vocal");
                source = Temp.GetComponent<AudioSource>();
                Temp = GameObject.Find("Vocal2");
                source2 = Temp.GetComponent<AudioSource>();
                break;
            case 1:
                Temp = GameObject.Find("Snare");
                source = Temp.GetComponent<AudioSource>();
                Temp = GameObject.Find("Snare2");
                source2 = Temp.GetComponent<AudioSource>();
                break;
            case 2:
                Temp = GameObject.Find("OH");
                source = Temp.GetComponent<AudioSource>();
                Temp = GameObject.Find("OH2");
                source2 = Temp.GetComponent<AudioSource>();
                break;
            case 3:
                Temp = GameObject.Find("Kick");
                source = Temp.GetComponent<AudioSource>();
                Temp = GameObject.Find("Kick2");
                source2 = Temp.GetComponent<AudioSource>();
                break;
            case 4:
                Temp = GameObject.Find("Bass");
                source = Temp.GetComponent<AudioSource>();
                Temp = GameObject.Find("Bass2");
                source2 = Temp.GetComponent<AudioSource>();
                break;
            case 5:
                Temp = GameObject.Find("Xguitar");
                source = Temp.GetComponent<AudioSource>();
                Temp = GameObject.Find("Xguitar2");
                source2 = Temp.GetComponent<AudioSource>();
                break;
            case 6:
                Temp = GameObject.Find("Guitar");
                source = Temp.GetComponent<AudioSource>();
                Temp = GameObject.Find("Guitar2");
                source2 = Temp.GetComponent<AudioSource>();
                break;
        }


    }

    public void OnPointerClick(PointerEventData eventData)
    {

        if (source2.mute)
        {
            source2.mute = false;
            GetComponent<SpriteRenderer>().material.color = temp;

        }
        else
        {
            source2.mute = true;
            GetComponent<SpriteRenderer>().material.color = new Color(0.5f,0.5f,0.5f, 1.0f);
        }


        if (source.mute)
        {
            source.mute = false;
            GetComponent<SpriteRenderer>().material.color = temp;
        }

        else
        {
            source.mute = true;
            GetComponent<SpriteRenderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 1.0f);
        }

        
    }


    // Update is called once per frame
    void Update()
    {



    }
}
