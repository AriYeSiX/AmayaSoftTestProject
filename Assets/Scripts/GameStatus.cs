using UnityEngine;

public static class GameStatus
{
    private static bool _gameStart = false;

    public static bool GameStart
    {
        get => _gameStart;
        set => _gameStart = value;
    }
    private static bool _dataLoad = false;

    public static bool DataLoad
    {
        get => _dataLoad;
        set => _dataLoad = value;
    }

    private static GameObject _currentGameObject;

    public static GameObject CurrentGameObject
    {
        get => _currentGameObject;
        set => _currentGameObject = value;
    }
}
