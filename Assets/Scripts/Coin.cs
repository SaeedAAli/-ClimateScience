using System;
using System.Diagnostics;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameManager gamemanager;
    public Level1Counter level1;
    public Level2Counter level2;
    public AudioSource audiosource;
    public AudioSource Carbon;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            Destroy(collision.gameObject);
            audiosource.Play();
            gamemanager.CoinScore++;
            level1.CoinScore++;
            level2.CoinScore++;
            
        }

        else if (collision.gameObject.tag == "Carbon")
        {
            Destroy(collision.gameObject);
            audiosource.Play(); 
            gamemanager.CarbonScore++;
            level1.CarbonScore++;
            level2.CarbonScore++;
            Carbon.Play();
            


       }

    }
}

    









