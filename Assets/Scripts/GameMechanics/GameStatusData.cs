using UnityEngine;

public class GameStatusData : MonoBehaviour
{
    public bool GameStart { get; set; }

    public bool DataLoad { get; set; } = false;

    public GameObject CurrentGameObject { get; set; }
}
