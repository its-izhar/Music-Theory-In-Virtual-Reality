using UnityEngine; 
using UnityEngine.EventSystems;
using System.Collections;

public class Song_Swap : MonoBehaviour
{

    public AudioSource clip1_guitar, clip1_xguitar, clip1_bass, clip1_oh, clip1_snare, clip1_kick, clip1_vocal;
    public AudioSource clip2_guitar, clip2_xguitar, clip2_bass, clip2_oh, clip2_snare, clip2_kick, clip2_vocal;
    public GameObject Song1, Song2;
    Color temp1, temp2;

    
 
    public bool isplaying = false;

    public AudioClip otherclip_guitar, otherclip_xguitar, otherclip_bass, otherclip_oh, otherclip_snare, otherclip_kick, otherclip_vocal;
    public AudioClip initialclip_guitar, initialclip_xguitar, initialclip_bass, initialclip_oh, initialclip_snare, initialclip_kick, initialclip_vocal;
    // Use this for initialization
    void Awake()
    {

        temp1 = Song1.GetComponent<SpriteRenderer>().material.color;
        temp2 = Song2.GetComponent<SpriteRenderer>().material.color;

        clip1_bass.clip = initialclip_bass;
        clip1_guitar.clip = initialclip_guitar;
        clip1_kick.clip = initialclip_kick;
        clip1_oh.clip = initialclip_oh;
        clip1_snare.clip = initialclip_snare;
        clip1_vocal.clip = initialclip_vocal;
        clip1_xguitar.clip = initialclip_xguitar;

        clip2_bass.clip = otherclip_bass;
        clip2_guitar.clip = otherclip_guitar;
        clip2_kick.clip = otherclip_kick;
        clip2_oh.clip = otherclip_oh;
        clip2_snare.clip = otherclip_snare;
        clip2_vocal.clip = otherclip_vocal;
        clip2_xguitar.clip = otherclip_xguitar;



    }

    public void trigger()
    {

        GameObject Temp;
        
        
       
        if (GameObject.Find("Song 2 - Rick Astley").GetComponent<Song_Swap2>().isplaying == false && isplaying == false )   // Start Fucking Rick
        {
            
            Song2.GetComponent<SpriteRenderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 1.0f);
            Song1.GetComponent<SpriteRenderer>().material.color = temp1;
            isplaying = true;

            clip2_bass.Play();
            clip2_guitar.Play();
            clip2_xguitar.Play();
            clip2_snare.Play();
            clip2_vocal.Play();
            clip2_oh.Play();
            clip2_kick.Play();
        }
        // Swapping to Rick

        else if (GameObject.Find("Song 2 - Rick Astley").GetComponent<Song_Swap2>().isplaying == true )
        {
            isplaying = true;
            GameObject.Find("Song 2 - Rick Astley").GetComponent<Song_Swap2>().isplaying = false;
            
            Song2.GetComponent<SpriteRenderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 1.0f);
            Song1.GetComponent<SpriteRenderer>().material.color = temp1;
         
            clip1_bass.Stop();
            clip1_guitar.Stop();
            clip1_xguitar.Stop();
            clip1_snare.Stop();
            clip1_vocal.Stop();
            clip1_oh.Stop();
            clip1_kick.Stop();

            clip2_bass.Play();
            clip2_guitar.Play();
            clip2_xguitar.Play();
            clip2_snare.Play();
            clip2_vocal.Play();
            clip2_oh.Play();
            clip2_kick.Play();

        }


    }
    // Update is called once per frame
    void Update () {
        
    }
}
