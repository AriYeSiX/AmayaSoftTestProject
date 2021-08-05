using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Random = UnityEngine.Random;

public class GenerateData : MonoBehaviour
{
    [SerializeField] private Bounce _bounce;
    [SerializeField] private LetterDataList _letterData;
    [SerializeField] private NumberDataList _numberData;
    [SerializeField] private DataChoice[] dataBase;
    public DataChoice[] DataBase => dataBase;
    [SerializeField] private StartGameProcess _startGameProcess;
    [SerializeField] private GeneratePanel _generatePanel;
    [SerializeField] private List<int> randomList;
    [SerializeField] private UnityEvent onStart;
    [SerializeField] private SpriteRenderer[] _spriteGenerate;
    
    public SpriteRenderer[] SpriteGenerate => _spriteGenerate;
    
    [SerializeField] private string[] dataNames;
    
    public string[] DataNames => dataNames;
    
    private int spriteIndex;
    private int imageRandom;
    
    private void Start()
    {
        onStart.Invoke();
    }

    public void SpawnData()
    {
        spriteIndex = 0;
        for (int i = 0; i < _generatePanel.Grid.GetLength(0); i++)
        {
            for (int j = 0; j < _generatePanel.Grid.GetLength(1); j++)
            {
                _spriteGenerate[spriteIndex] = _generatePanel.Grid[i, j].transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>();
                spriteIndex++;
            }
        }
        
        if (_startGameProcess.CurrentBase==0)
        {
            while (randomList.Count<_letterData.Data.Length)
            {
                imageRandom = Random.Range(0, _letterData.Data.Length);
                if (!randomList.Contains(imageRandom))
                {
                    randomList.Add(imageRandom);
                }
            }
            spriteIndex = 0;
            for (int i = 0; i < _generatePanel.Grid.GetLength(0); i++)
            {
                for (int j = 0; j < _generatePanel.Grid.GetLength(1); j++)
                {
                    _spriteGenerate[spriteIndex].sprite = _letterData.Data[randomList[spriteIndex]].Image;
                    dataNames[spriteIndex] = _letterData.Data[randomList[spriteIndex]].Name;
                    _generatePanel.Grid[i, j].transform.GetChild(0).gameObject.transform.name = dataNames[spriteIndex];
                    _bounce.CircleChild = _generatePanel.Grid[i,j].transform.GetChild(0);
                    _bounce.SpriteBounce();
                    spriteIndex++;
                }
            }
            randomList.Clear();
            GameStatus.DataLoad = true;
        }
        else if (_startGameProcess.CurrentBase==1)
        {
            while (randomList.Count<_numberData.Data.Length)
            {
                imageRandom = Random.Range(0, _numberData.Data.Length);
                if (!randomList.Contains(imageRandom))
                {
                    randomList.Add(imageRandom);
                }
            }
            spriteIndex = 0;
            for (int i = 0; i < _generatePanel.Grid.GetLength(0); i++)
            {
                for (int j = 0; j < _generatePanel.Grid.GetLength(1); j++)
                {
                    _spriteGenerate[spriteIndex].sprite = _numberData.Data[randomList[spriteIndex]].Image;
                    dataNames[spriteIndex] = _numberData.Data[randomList[spriteIndex]].Name;
                    _generatePanel.Grid[i, j].transform.GetChild(0).gameObject.transform.name = dataNames[spriteIndex];
                    _bounce.CircleChild = _generatePanel.Grid[i,j].transform.GetChild(0);
                    _bounce.SpriteBounce();
                    spriteIndex++;
                }
            }
            randomList.Clear();
            GameStatus.DataLoad = true;
        }
    }
}
