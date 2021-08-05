using UnityEngine;
public class StartGameProcess : MonoBehaviour
{
    [SerializeField]private GenerateData _generateData;
    
    [SerializeField]private int _currentBase;

    
    public int CurrentBase => _currentBase;

    public void DataRandom()
    {
        GameStatus.GameStart = true;   
        _currentBase = Random.Range(0, _generateData.DataBase.Length);
    }
}
