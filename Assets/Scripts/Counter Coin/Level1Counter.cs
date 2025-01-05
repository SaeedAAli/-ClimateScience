using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level1Counter : MonoBehaviour
{
    public TextMeshProUGUI Coin;
    public TextMeshProUGUI CarbonCounter;

    public int CoinScore;
    public int CarbonScore;

    public GameObject Door;
    public AudioSource Doors;
    // Start is called before the first frame update
    void Start()
    { 

    }

    // Update is called once per frame
    void Update()
    {
        CarbonCounter.text = CarbonScore.ToString() + "  /   2";
        Coin.text = CoinScore.ToString() + " /   5";

        if (CoinScore == 5 && CarbonScore == 2)
        {
            Destroy(Door);
            Doors.Play();
        }



    }


}



