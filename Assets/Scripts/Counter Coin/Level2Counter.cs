using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Level2Counter : MonoBehaviour
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
        CarbonCounter.text = CarbonScore.ToString() + "  /   5";
        Coin.text = CoinScore.ToString() + " /   5";

        if (CoinScore == 5 && CarbonScore == 5)
        {
            Destroy(Door);
            Doors.Play();
        }



    }


}
