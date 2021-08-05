using UnityEngine;

public class GeneratePanel : MonoBehaviour
{
    [SerializeField] private DifficultyList _difficultyList;
    
    [SerializeField] private int currentDifficulty;

    public int CurrentDifficulty
    {
        get => currentDifficulty;
        set => currentDifficulty = value;
    }

    private Circle[,] _grid;
    [SerializeField]private GameObject _gridParent;

    public Circle[,] Grid => _grid;
    
    public void CircleGenerate()
    {
        _grid = new Circle[_difficultyList.Difficulties[currentDifficulty].Height,_difficultyList.Difficulties[currentDifficulty].Width];
        for (int i = 0; i < _grid.GetLength(0); i++)    
        {
            for (int j = 0; j < _grid.GetLength(1); j++)
            {
                _grid[i, j] = Instantiate(Resources.Load<GameObject>("Prefabs/Circle")).GetComponent<Circle>();
                _grid[i, j].Initialisation(new Vector3(j*3f, -i*3f, 0));
                _grid[i, j].name = "Circle "+ i + " - "+ j;
                _grid[i,j].transform.SetParent(_gridParent.transform);
            }
        }
    }
}
