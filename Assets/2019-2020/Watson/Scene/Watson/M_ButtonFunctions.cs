﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
public class M_ButtonFunctions : MonoBehaviour
{
    GameObject startmenu;
    GameObject optionsmenu;
    GameObject personalitymenu;
    

    W_PaintingController OKB;
    int CurrentIndex;
    void Start()
    {
        OKB = GameObject.Find("Controller").GetComponent<W_PaintingController>();
        startmenu = GameObject.Find("Start");
        optionsmenu = GameObject.Find("Options");
        optionsmenu.gameObject.SetActive(false);
        personalitymenu = GameObject.Find("Personality");
        personalitymenu.gameObject.SetActive(false);
    }
    // Start Menu
    public void StartBF()
    {
        // If no personality selected; go to creation
        // Scene Transition to Tutorial Screne
        SteamVR_LoadLevel.Begin("Outdoor_Area");
    }
    public void OptionsBF()
    {
        // Menu Transition to Options Menu
        startmenu.gameObject.SetActive(false);
        optionsmenu.gameObject.SetActive(true);
        
    }
    public void QuitBF()
    {
        // Exit Game
        Application.Quit();
    }
    // Options Menu
    public void GameplayTF()
    {
        // Tab Transition to Gameplay Personality Menu
        personalitymenu.gameObject.SetActive(true);
        OKB.GetList().transform.GetChild(CurrentIndex).GetComponent<W_PaintingPerson>().GetGraph().Show();
    }
    public void SettingsTF()
    {
        // Tab Transition to Other Settings (typical game settings)
    }
    public void BackBF()
    {
        // Menu Transition to Start Menu
        optionsmenu.gameObject.SetActive(false);
        startmenu.gameObject.SetActive(true);
        if (personalitymenu.activeInHierarchy)
            personalitymenu.SetActive(false);
    }
    // Gameplay Personality Menu
    public void NextBF()
    {
        // Cycle forward through personalities list
    }
    public void PrevBF()
    {
        // Cycle backwards through personalities list
    }
    public void SetSelfBF()
    {
        // select personality for play
        OKB.PeopleMaker = true;
    }
    public void NewPersonBF()
    {
        OKB.keyboard = true;
    }
    public void SaveBF()
    {
        // Save All personalities
    }
    public void SaveAsBF()
    {
        // Save personalities under different folder
    }
    public void LoadBF()
    {
        // Load personalities
    }
    public void DeleteBF()
    {
        // Delete personality
    }
}