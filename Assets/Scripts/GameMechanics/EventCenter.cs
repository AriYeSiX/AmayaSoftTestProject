using UnityEngine;
using UnityEngine.Events;

public class EventCenter : MonoBehaviour
{
    [SerializeField] private UnityEvent _questChoice;
    
    [SerializeField] private UnityEvent _checkClick;

    [SerializeField] private UnityEvent _wrongClick;

    [SerializeField] private UnityEvent _successClick;
    
    [SerializeField] private UnityEvent _nextLevel;

    [SerializeField] private UnityEvent _restart;
    
    [SerializeField] private GameStatusData _gameStatusData;

    [SerializeField] private EaseIn _easeIn;

    [SerializeField] private Bounce _bounce;

    [SerializeField] private GeneratePanel _generatePanel;
    
    [SerializeField] private int oldCurrentDifficulty;

    [SerializeField] private GameObject _restartMenu;
    private void Start()
    {
        oldCurrentDifficulty = _generatePanel.CurrentDifficulty;
    }

    void Update()
    {
        if (_gameStatusData.GameStart)
        {
            if (_gameStatusData.DataLoad)
            {
                _questChoice.Invoke();
                _gameStatusData.DataLoad = false;
            }

            if (_gameStatusData.CurrentGameObject != null)
            {
                _checkClick.Invoke();
            }

            if (_easeIn.EaseInImage != null)
            {
                _wrongClick.Invoke();
                _easeIn.EaseInImage=null;
            }

            if (_bounce.CircleChild != null)
            {
                _successClick.Invoke();
            }

            if (oldCurrentDifficulty != _generatePanel.CurrentDifficulty && _gameStatusData.GameStart)
            {
                oldCurrentDifficulty = _generatePanel.CurrentDifficulty;
                _nextLevel.Invoke();
                _questChoice.Invoke();
            }
        }
        
        if (!_gameStatusData.GameStart)
        {
            _restartMenu.SetActive(true);
            print("endgame");
            _restart.Invoke();
        }
    }
    
    
}
