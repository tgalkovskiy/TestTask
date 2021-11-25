
using UnityEngine;

[CreateAssetMenu(menuName = "Data", fileName = "Cell_of")]
public class DataCell : ScriptableObject
{
    public int nowScore;
    public int maxScore;
    public int loadScene;
    public string name;
    public Sprite _mainImage;
}
