using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI Coin;
    public TextMeshProUGUI CarbonCounter;
    public int CoinScore;
    public int CarbonScore;

    public GameObject Door;
    public AudioSource DoorS;
    // Start is called before the first frame update
    void Start()
    {
        CarbonCounter.text = CarbonScore.ToString() + "  /   1";
        Coin.text = CoinScore.ToString() + " /   1";
        if (CoinScore == 1 && CarbonScore == 1)
        {
            
            Destroy(Door);
             DoorS.Play();
        }

    }
    // Update is called once per frame
    void Update()
    {

        Start();

    }
}