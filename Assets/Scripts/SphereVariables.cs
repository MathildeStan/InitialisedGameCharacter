using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereVariables : MonoBehaviour
{
    public string characterName = "Ligma";

    private int startLevel = 21;

    public int addedLevel = 2;

    // Start is called before the first frame update
    private void Start()
    {
        print(PerformLevelCalculations(characterName, startLevel));             

        int currentLevel = startLevel + addedLevel;
        Debug.Log($"You have leveled up to {currentLevel}!");
    }
    /// <summary>
    /// Prints out character name and level
    /// </summary>

    int PerformLevelCalculations(string name, int level)
    {
       Debug.LogFormat("Your name: {0} - Your level: {1}", name, level);

        int results = level + addedLevel;
        return results;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
