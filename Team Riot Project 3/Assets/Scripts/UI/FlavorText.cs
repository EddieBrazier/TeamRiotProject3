﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlavorText : MonoBehaviour
{
    //list of strings for flavor text
    public List<string> flavorText;

    //text box prefab
    public GameObject textPrefab;

    public GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowText()
    {
        GetComponent<AudioSource>().Play();
        //spawn text box
        GameObject itemText = Instantiate(textPrefab, canvas.transform);
        itemText.GetComponent<TextBox>().parent = this;
        itemText.GetComponent<TextBox>().textboxContents = flavorText;
        itemText.GetComponent<TextBox>().enabled = true;
        this.enabled = false;

        //set time scale to 0 and disable player movement
        Time.timeScale = 0;
        playerMovement.instance.enabled = false;
    }
}
