using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DifficultyList", menuName = "DifficultyList", order = 53)]
public class DifficultyList : ScriptableObject
{
    [SerializeField] private Difficulty[] difficulties;
    public Difficulty[] Difficulties => difficulties;
}
