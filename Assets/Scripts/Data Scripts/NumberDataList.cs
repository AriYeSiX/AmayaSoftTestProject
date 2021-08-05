using UnityEngine;

[CreateAssetMenu(fileName = "New NumberData", menuName = "Number Data", order = 52)]
public class NumberDataList : DataChoice
{
    [SerializeField] private Data[] _numberData;

    public Data[] Data => _numberData;

    public override void DataChoicer(Sprite image)
    {
        image = _numberData[0].Image;
    }
}
