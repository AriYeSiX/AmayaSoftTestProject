using UnityEngine;

[CreateAssetMenu(fileName = "New LetterData", menuName = "Letter Data", order = 51)]
public class LetterDataList : DataChoice
{
    [SerializeField] private Data[] _letterData;

    public Data[] Data => _letterData;
    public override void DataChoicer(Sprite image)
    {
        image = _letterData[0].Image;
    }
}
