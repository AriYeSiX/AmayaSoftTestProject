using UnityEngine;

public class CheckClick : MonoBehaviour
{
   [SerializeField] private QuestTarget _questTarget;
   
   [SerializeField] private GeneratePanel _generatePanel;
   
   [SerializeField] private DifficultyList _difficultyList;
   
   [SerializeField] private EaseIn _easeIn;
   
   [SerializeField] private Bounce _bounce;
   
   [SerializeField] private ParticleSystem _starParticles;
   
   [SerializeField] private GameStatusData _gameStatusData;
   
   public void CheckImage()
   {
      if (_gameStatusData.CurrentGameObject.name == _questTarget.CurrentSprite.name)
      {
         _starParticles.gameObject.SetActive(true);
         _starParticles.transform.position = _gameStatusData.CurrentGameObject.transform.position;
         _starParticles.Play();
         _bounce.CircleChild = _gameStatusData.CurrentGameObject.transform;
         _gameStatusData.CurrentGameObject = null;
         _generatePanel.CurrentDifficulty++;
         if (_generatePanel.CurrentDifficulty == _difficultyList.Difficulties.Length)
         {
            _gameStatusData.GameStart = false;
         }
      }
      else
      {
         _easeIn.EaseInImage = _gameStatusData.CurrentGameObject.transform;
      }
   }
}
