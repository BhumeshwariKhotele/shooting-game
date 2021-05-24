using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
int score=0;

public void ScoreCalculator(int value)
{
    score=score+value;
    print("The score is "+score);
}
}
