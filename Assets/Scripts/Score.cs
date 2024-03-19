using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
  public static int score = 0;
  public static int bestScore = 0;
  Text uiTexT;

    void Start()
    {
        uiTexT = GetComponent<Text>();
        score = 0;
        
    }


    void Update()
    {
        uiTexT.text= score.ToString();
    }
}
