using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    
    int correctAnswer = 0;
    int questionSee = 0;
  
    public int getCorrectAnswer(){
        return correctAnswer;
    }

    public void IncrementCorrectAnswer(){
        correctAnswer++;
    }

    public int getQuestionSee(){
        return questionSee;
    }

    public void IncrementQuestionSee(){
        questionSee++;
    }

    public int CalculateScore(){
        return Mathf.RoundToInt(correctAnswer / (float)questionSee * 100);
    }

}
