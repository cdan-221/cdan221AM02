using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Container for player choices
/// </summary>
public class PlayerData : ScriptableObject
{
    [SerializeField, Tooltip("limits the size of player choices in editor"), Range(1f, 5f)] int MaxChoices = 5;
    [SerializeField] List<PlayerPath> m_PlayerChoices = new List<PlayerPath>(5);
    public void AddChoice(PlayerPath choice) => m_PlayerChoices.Add(choice);
    public void ClearChoices() => m_PlayerChoices.Clear();
    private void OnEnable() => m_PlayerChoices.Clear();
    private void OnValidate()
    { 
        if (m_PlayerChoices.Count > MaxChoices) // ensure that playerchoices never exceeds maxcount in editor
            m_PlayerChoices.RemoveRange(MaxChoices, m_PlayerChoices.Count - MaxChoices);
    }
    public int GetTotalPlayerChoices()
    {
        int totalchoices = 0;
        foreach (var choice in m_PlayerChoices)
            totalchoices += (int)choice;
        return totalchoices;
    }
}
