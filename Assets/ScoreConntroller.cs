using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreConntroller : MonoBehaviour
{
    private int SmallStarScore = 10;
    private int LargeStarScore = 20;
    private int SmallCloudScore = 30;
    private int LargeCloudScore = 50;
    private int Score = 0;
    private GameObject scoreText;

    // Start is called before the first frame update
    void Start()
    {
        this.scoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {
        string scorex = Score.ToString();
        this.scoreText.GetComponent<Text>().text = scorex;
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "SmallStarTag")
        {
            Score += SmallStarScore;
        }
        if (other.gameObject.tag == "LargeStarTag")
        {
            Score += LargeStarScore;
        }
        if (other.gameObject.tag == "SmallCloudTag")
        {
            Score += SmallCloudScore;
        }
        if (other.gameObject.tag == "LargeCloudTag")
        {
            Score += LargeCloudScore;
        }

    }
}
