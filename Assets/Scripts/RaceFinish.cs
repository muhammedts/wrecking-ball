﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class RaceFinish : MonoBehaviour
{
    public GameObject Mycar;
    public GameObject CompleteTrig;
    public GameObject FinishCam;
    public GameObject Cam;
<<<<<<< HEAD
<<<<<<< HEAD
    public GameObject end;
    public GameObject win;
    public GameObject lose;
=======
    public GameObject TimerMange;

>>>>>>> ffa15855b45451b698da002bf880505934776c2b
=======
    public GameObject TimerMange;

>>>>>>> ffa15855b45451b698da002bf880505934776c2b



    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("playercar"))
        {
            Debug.Log("Winner");
            Mycar.SetActive(false);
            CompleteTrig.SetActive(false);  
            CarController.m_Topspeed = 0.0f;
            Mycar.GetComponent<CarController>().enabled = false;
            Mycar.GetComponent<CarUserControl>().enabled = false;
            Mycar.SetActive(true);
           
            FinishCam.SetActive(true);
            Cam.SetActive(false);
            LapTimeManager.MintCount = 0;
            LapTimeManager.SecCount = 0;
            LapTimeManager.MilliCount = 0;
<<<<<<< HEAD
<<<<<<< HEAD
            end.SetActive(true);
            win.SetActive(true);
=======
=======
>>>>>>> ffa15855b45451b698da002bf880505934776c2b
            TimerMange.SetActive(false);
           

>>>>>>> ffa15855b45451b698da002bf880505934776c2b

        }
        else
        {
            Debug.Log("GameOver");

            Mycar.SetActive(false);
            CompleteTrig.SetActive(false);
            CarController.m_Topspeed = 0.0f;
            Mycar.GetComponent<CarController>().enabled = false;
            Mycar.GetComponent<CarUserControl>().enabled = false;
            Mycar.SetActive(true);




            FinishCam.SetActive(true);
            Cam.SetActive(false);
<<<<<<< HEAD
            end.SetActive(true);
            lose.SetActive(true);
=======
            LapTimeManager.MintCount = 0;
            LapTimeManager.SecCount = 0;
            LapTimeManager.MilliCount = 0;
            TimerMange.SetActive(false);

>>>>>>> 8ab2b5161f1cd1d18c22929589154ec38f8827ab


        }

    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
