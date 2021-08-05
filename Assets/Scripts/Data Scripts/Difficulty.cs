using System;
using UnityEngine;

[Serializable]
public class Difficulty
{
    [SerializeField] private string _difficultyName;
    [SerializeField] private int _width;
    [SerializeField] private int _height;

    public string DifficultyName => _difficultyName;

    public int Width => _width;

    public int Height => _height;
}
