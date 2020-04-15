﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class MenuController : MonoBehaviour
{

    public Transform teleportOut;
    public Transform teleportIn; 
    public GameObject player;

    public GameObject mainMenu;
    public GameObject optionsMenu;

    public void MenuButtons(int buttonID)
    {
        //Main Menu
        if(buttonID == 1)
        {
            SteamVR_LoadLevel.Begin("TheLab");
        }

        if(buttonID == 2)
        {
            mainMenu.transform.position = teleportOut.transform.position;
            optionsMenu.transform.position = teleportIn.transform.position;
        }

        if (buttonID == 3)
        {
            Application.Quit();
        }

        //Options Menu
        if (buttonID == 4)
        {
            mainMenu.transform.position = teleportIn.transform.position;
            optionsMenu.transform.position = teleportOut.transform.position;
        }
    }
}