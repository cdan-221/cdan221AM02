using UnityEngine;
class PlayerChoiceUpdater : MonoBehaviour
{
    [SerializeField] PlayerPath path;
    [SerializeField] PlayerData playerdata;
    void Start() => playerdata.AddChoice(path);
}
