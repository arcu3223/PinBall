using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    private GameObject scoreText;

    private int score = 0;

    // Use this for initialization
    void Start()
    {
        this.scoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update() {
    }

    void OnCollisionEnter(Collision other)
    {

        if (tag == "SmallStarTag")
        {
            this.score += 10;
        }
        else if (tag == "LargeStarTag")
        {
            this.score += 50;
        }
        else if (tag == "SmallCloudTag")
        {
            this.score += 100;
        }
        else if (tag == "LargeCloudTag")
        {
            this.score += 500;
        }

        this.scoreText.GetComponent<Text>().text = "Score" + this.score;

    }
}
