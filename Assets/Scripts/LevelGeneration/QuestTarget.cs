using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestTarget : MonoBehaviour
{
    [SerializeField] private Text _missionText;
    
    [SerializeField] private GenerateData _generateData;
    
    [SerializeField] private GeneratePanel _generatePanel;
    
    [SerializeField] private GameObject _currentSprite;

    public GameObject CurrentSprite => _currentSprite;

    private string _missionMessege;
    
    private int _randomCircle;

    [SerializeField] private List<int> _previousTargets;

    public void RandomizeQuest()
    {
        _randomCircle = Random.Range(0, _generatePanel.Grid.GetLength(0) * _generatePanel.Grid.GetLength(1));      
        if (_previousTargets != null && !_previousTargets.Contains(_randomCircle))
        {
            _previousTargets.Add(_randomCircle);
        }
        else
        {
            _randomCircle = Random.Range(0, _generatePanel.Grid.GetLength(0) * _generatePanel.Grid.GetLength(1));
        }
        _missionText.text = "Find "+_generateData.DataNames[_randomCircle];
        _currentSprite = GameObject.Find(_generateData.DataNames[_randomCircle]);
    }
}
