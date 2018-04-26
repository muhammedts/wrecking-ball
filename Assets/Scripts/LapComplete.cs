﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LapComplete : MonoBehaviour {


    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;

    public GameObject MinuteDisplay;
    public GameObject SecDisplay;
    public GameObject MilliDisplay;
    public GameObject LapTimeBox;
    public GameObject LapCounter;
    public GameObject RaceFinish;
    public GameObject player;
    public GameObject ai;


    public int lapsDone = 0;
    public int lapsDoneAi = 0;

    public float RawTime;
  /*  void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Playercar")
        {
            lapsDone += 1;


            if (LapTimeManager.SecCount <= 9)
            {
                SecDisplay.GetComponent<Text>().text = "0" + LapTimeManager.SecCount + ".";
            }
            else
            {

                SecDisplay.GetComponent<Text>().text = "" + LapTimeManager.SecCount + ".";

            }
            if (LapTimeManager.MintCount <= 9)
            {
                MinuteDisplay.GetComponent<Text>().text = "0" + LapTimeManager.MintCount + ":";
            }
            else
            {

                MinuteDisplay.GetComponent<Text>().text = "" + LapTimeManager.MintCount + ":";

            }
            MilliDisplay.GetComponent<Text>().text = "" + LapTimeManager.MilliCount;
            LapCounter.GetComponent<Text>().text = "" + lapsDone;
            LapTimeManager.MintCount = 0;
            LapTimeManager.SecCount = 0;
            LapTimeManager.MilliCount = 0;
            HalfLapTrig.SetActive(true);
            LapCompleteTrig.SetActive(false);
        }
    }*/

        public Collision collision;
    private void OnTriggerEnter( Collider other)

    {
        
        
        
        Debug.Log("5555555555555555555555555");
        if (other)
           
        {
            lapsDone += 1;
            Debug.Log("Do something here");


            if (LapTimeManager.SecCount <= 9)
            {
                SecDisplay.GetComponent<Text>().text = "0" + LapTimeManager.SecCount + ".";
            }
            else
            {

                SecDisplay.GetComponent<Text>().text = "" + LapTimeManager.SecCount + ".";

            }
            if (LapTimeManager.MintCount <= 9)
            {
                MinuteDisplay.GetComponent<Text>().text = "0" + LapTimeManager.MintCount + ":";
            }
            else
            {

                MinuteDisplay.GetComponent<Text>().text = "" + LapTimeManager.MintCount + ":";

            }
            MilliDisplay.GetComponent<Text>().text = "" + LapTimeManager.MilliCount;
            LapCounter.GetComponent<Text>().text = "" + lapsDone;
            LapTimeManager.MintCount = 0;
            LapTimeManager.SecCount = 0;
            LapTimeManager.MilliCount = 0;
            HalfLapTrig.SetActive(true);
            LapCompleteTrig.SetActive(false);
        }else{
            Debug.Log("adwadaw");
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(lapsDone == 2)
        {
            RaceFinish.SetActive(true);
        }
		
	}

}
