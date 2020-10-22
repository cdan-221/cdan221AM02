using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Container for player choices
/// </summary>
public class PlayerData : ScriptableObject
{
    [SerializeField] public string m_username;
    [SerializeField, Tooltip("limits the size of player choices in editor"), Range(1f, 5f)] int MaxChoices = 5;
    [SerializeField] List<PlayerPath> m_PlayerChoices = new List<PlayerPath>(5);
    /// <summary>
    /// The name entered by the user
    /// </summary>
    public static string UserName { get; private set; } = string.Empty;
    public void AddChoice(PlayerPath choice) => m_PlayerChoices.Add(choice);
    public void ClearChoices() => m_PlayerChoices.Clear();

    public void SetPlayerName(string newName)
    {
        UserName = UserName == string.Empty ? newName : throw new UnityException("cannot set name again!");
        if (Application.isEditor)
            m_username = UserName;
    }
    private void OnEnable() => m_PlayerChoices.Clear();
    private void OnValidate()
    { 
        if (m_PlayerChoices.Count > MaxChoices) // ensure that playerchoices never exceeds maxcount in editor
            m_PlayerChoices.RemoveRange(MaxChoices, m_PlayerChoices.Count - MaxChoices);
        m_username = UserName;
    }
    public int GetTotalPlayerChoices()
    {
        int totalchoices = 0;
        foreach (var choice in m_PlayerChoices)
            totalchoices += (int)choice;
        return totalchoices;
    }
}
