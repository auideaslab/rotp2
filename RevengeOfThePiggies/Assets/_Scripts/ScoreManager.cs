using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager
{
    public int score = 0;

    public static ScoreManager instance = new ScoreManager();

    // making the constructor private prevents others 
    // from creating an object of this class

    private ScoreManager()
    {

    }
}
