using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class clickscript : MonoBehaviour
{ 

    private Song_Swap linkin;
    private Song_Swap2 rick;
    private GameObject Temp;
    //public Camera myCam;
    public bool val = false;
    public bool val2 = false;

    public void runfunc()
    {
        linkin = GameObject.FindWithTag("Linkin").GetComponent<Song_Swap>();
        rick = GameObject.FindWithTag("Rick").GetComponent<Song_Swap2>();

        RaycastHit hit;
     //   Ray ray = myCam.ScreenPointToRay(Input.mousePosition);
     //   Debug.DrawRay(ray.origin, ray.direction * 10, Color.yellow);

        if (Physics.Raycast(Cardboard.SDK.GetComponentInChildren<CardboardHead>().Gaze, out hit))
        {
			
            if (hit.collider.name.Contains("Linkin"))
            {
                val2 = true;
                linkin.trigger(); //this make the cards flip, no problem with this              
            }
			
            else if (hit.collider.name.Contains("Rick"))
            {
                val2 = true;
                rick.trigger(); //this make the cards flip, no problem with this              
            }
                                                            //Vocals
            else if (hit.collider.name.Contains("Vocals"))
            {
                val2 = true;

                GameObject.Find("Vocals").GetComponent<Volume_Control>().trigger();
            }
            else if (hit.collider.name.Contains("Actual"))        //Guitar
            {
                val2 = true;
                GameObject.Find("Actual Guitar").GetComponent<Volume_Control>().trigger();           
            }

            else if (hit.collider.name.Contains("Electric"))        //Bass
            {
                val2 = true;
                GameObject.Find("Electric Guitar").GetComponent<Volume_Control>().trigger();
            }

            else if (hit.collider.name.Contains("Kick"))        //Kick
            {
                val2 = true;
                GameObject.Find("Kick Drum").GetComponent<Volume_Control>().trigger();
            }
            else if (hit.collider.name.Contains("Snare"))        //Bass
            {
                val2 = true;
                GameObject.Find("Snare Drum").GetComponent<Volume_Control>().trigger();
            }
            else if (hit.collider.name.Contains("Cymbals"))        //Bass
            {
                val2 = true;
                GameObject.Find("Cymbals").GetComponent<Volume_Control>().trigger();
            }
            else if (hit.collider.name.Contains("Synthesizer"))        //Bass
            {
                val2 = true;
                GameObject.Find("Synthesizer").GetComponent<Volume_Control>().trigger();
            }
            else if (hit.collider.name.Contains("Concert"))        //Bass
            {
                val2 = true;
                GameObject.Find("Concert Hall").GetComponent<Swap_From_3D>().trigger();
            }
        }
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (CrossPlatformInputManager.GetButtonDown("Fire1"))
        {
            val = true;
            runfunc();
        }
    }
}
