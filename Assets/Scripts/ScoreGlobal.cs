using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreGlobal : MonoBehaviour
{
    public GameObject textScore;
    public static int score;

    // Update is called once per frame
    void Update()
    {
        textScore.GetComponent<Text>().text = "Score: " + score;
    }
}