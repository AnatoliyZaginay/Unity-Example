using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    public int scoreForCoin;
    public AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            collectSound.Play();
            ScoreGlobal.score += scoreForCoin;
            gameObject.SetActive(false);
        }
    }
}
