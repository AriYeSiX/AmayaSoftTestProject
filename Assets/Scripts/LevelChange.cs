using UnityEngine;

public class LevelChange : MonoBehaviour
{
    [SerializeField] private GeneratePanel _generatePanel;
    
    public void DestroyOldData()
    {
        if (GameStatus.GameStart)
        {
            for (int i = 0; i < _generatePanel.Grid.GetLength(0); i++)    
            {
                for (int j = 0; j < _generatePanel.Grid.GetLength(1); j++)
                {
                    Destroy(GameObject.Find("Circle "+i+" - " + j));
                }
            } 
        }
    }
}
