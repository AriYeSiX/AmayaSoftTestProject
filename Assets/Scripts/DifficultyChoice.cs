using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyChoice : MonoBehaviour
{
    private DifficultyList _difficultyList;
    private Difficulty _currentDifficulty;
    
    private void Start()
    {
        _currentDifficulty = _difficultyList.Difficulties[0];
    }

    // Update is called once per frame
    private void Update()
    {
        
    }
}
