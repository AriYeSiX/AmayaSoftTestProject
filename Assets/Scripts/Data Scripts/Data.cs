using System;
using UnityEngine;

[Serializable]
public class Data
{
    [SerializeField] private string _name;

    [SerializeField] private Sprite _image;

    public string Name => _name;

    public Sprite Image => _image;
}
