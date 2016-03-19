using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class Volume_Control : MonoBehaviour, IPointerClickHandler
{

    
    public AudioSource source;
    public int assign;


    // Use this for initialization
    void Awake()
    {
        GameObject Temp;
        switch (assign)
        {
            case 0:
                Temp = GameObject.Find("Vocal");
                source = Temp.GetComponent<AudioSource>();
                break;
            case 1:
                Temp = GameObject.Find("Snare");
                source = Temp.GetComponent<AudioSource>();
                break;
            case 2:
                Temp = GameObject.Find("OH");
                source = Temp.GetComponent<AudioSource>();
                break;
            case 3:
                Temp = GameObject.Find("Kick");
                source = Temp.GetComponent<AudioSource>();
                break;
            case 4:
                Temp = GameObject.Find("Bass");
                source = Temp.GetComponent<AudioSource>();
                break;
            case 5:
                Temp = GameObject.Find("Xguitar");
                source = Temp.GetComponent<AudioSource>();
                break;
            case 6:
                Temp = GameObject.Find("Guitar");
                source = Temp.GetComponent<AudioSource>();
                break;
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (source.mute)
            source.mute = false;
        else
            source.mute = true;
    }


    // Update is called once per frame
    void Update()
    {



    }
}
