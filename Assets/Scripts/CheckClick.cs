using UnityEngine;

public class CheckClick : MonoBehaviour
{
   [SerializeField] private QuestTarget _questTarget;
   [SerializeField] private GeneratePanel _generatePanel;
   [SerializeField] private DifficultyList _difficultyList;
   [SerializeField] private EaseIn _easeIn;
   [SerializeField] private Bounce _bounce;
   [SerializeField] private ParticleSystem _starParticles;
   
   public void CheckImage()
   {
      if (GameStatus.CurrentGameObject.name == _questTarget.CurrentSprite.name)
      {
         _starParticles.gameObject.SetActive(true);
         _starParticles.transform.position = GameStatus.CurrentGameObject.transform.position;
         _starParticles.Play();
         _bounce.CircleChild = GameStatus.CurrentGameObject.transform;
         GameStatus.CurrentGameObject = null;
         _generatePanel.CurrentDifficulty++;
         if (_generatePanel.CurrentDifficulty == _difficultyList.Difficulties.Length)
         {
            GameStatus.GameStart = false;
         }
      }
      else
      {
         _easeIn.EaseInImage = GameStatus.CurrentGameObject.transform;
         
      }
   }
}
