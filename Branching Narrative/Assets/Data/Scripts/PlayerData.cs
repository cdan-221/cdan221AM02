using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Container for 
/// </summary>
public class PlayerData : ScriptableObject
{
    [SerializeField, Tooltip("limits the size of player choices"), Range(1f, 5f)] int MaxChoices = 5;
    [SerializeField] List<PlayerPath> m_PlayerChoices = new List<PlayerPath>(5);
    public IReadOnlyList<PlayerPath> PlayerChoices => m_PlayerChoices;
    public void AddChoice(PlayerPath choice) => m_PlayerChoices.Add(choice);
    private void OnEnable() => m_PlayerChoices.Clear();
    private void OnValidate()
    { 
        if (m_PlayerChoices.Count > MaxChoices) // ensure that playerchoices never exceeds maxcount in editor
            m_PlayerChoices.RemoveRange(MaxChoices, m_PlayerChoices.Count - MaxChoices);
    }
}
