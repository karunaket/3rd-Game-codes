using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text textscore;
    public float score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0f;
        textscore.text = "POINT : " + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        textscore.text = "POINTS : " + score.ToString();
    }
}