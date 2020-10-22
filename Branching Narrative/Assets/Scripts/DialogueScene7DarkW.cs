using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene7DarkW : MonoBehaviour
{
    public int primeInt = 1; // This integer drives game progress!
    public Text Char1name;
    public Text Char1speech;
    public Text Char2name;
    public Text Char2speech;
    public Text Char3name;
    public Text Char3speech;
    public GameObject dialogue;
    public GameObject ArtChar1;
	public GameObject ArtChar2;
	public GameObject ArtCharDARK;
    public GameObject ArtBG1;
	public GameObject ArtBG2;
    public GameObject NextSceneENDButton;
    public GameObject nextButton;
    //public GameObject gameHandler;
    //public AudioSource audioSource;
    private bool allowSpace = true;

    void Start()
    {         // initial visibility settings
        dialogue.SetActive(false);
        ArtChar1.SetActive(false);
		ArtChar2.SetActive(false);
		ArtCharDARK.SetActive(false);
        ArtBG1.SetActive(true);
		ArtBG2.SetActive(false);
        NextSceneENDButton.SetActive(false);
        nextButton.SetActive(true);
    }

    void Update()
    {         // use spacebar as Next button
        if (allowSpace == true)
        {
            if (Input.GetKeyDown("space"))
            {
                talking();
            }
        }
    }

    public void talking()
    {         // main story function. Players hit next to progress to next int
        primeInt = primeInt + 1;
        if (primeInt == 1)
        {
            // AudioSource.Play();
        }
        else if (primeInt == 2)
        {
			ArtChar2.SetActive(true);
            dialogue.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "High Witch";
            Char3speech.text = "At first I had you pegged for a light witch, but recent events have since revealed, you seem like a natural in the dark arts.";
        }
        else if (primeInt == 3)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "High Witch";
            Char2speech.text = "And with this decision, I think it’s time you see some old faces.";
			Char3name.text = "";
			Char3speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
		else if (primeInt == 4)
        {
			ArtChar2.SetActive(false);
			ArtCharDARK.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Dark Ones";
            Char2speech.text = "Hey" +PlayerData.UserName;
			Char3name.text = "";
            Char3speech.text = "";
        }
		else if (primeInt == 5)
        {
			ArtCharDARK.SetActive(false);
            Char1name.text = PlayerData.UserName;
            Char1speech.text = "Oh hey guys! Nice to see some of you again!";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "";
        }
		else if (primeInt == 6)
        {
			ArtCharDARK.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "Dark Ones";
            Char3speech.text = "We’re so glad you chose dark magic over pitiful light magic. Dark Witches know how to get stuff done!";
        }
		else if (primeInt == 7)
        {
			ArtCharDARK.SetActive(false);
            Char1name.text = PlayerData.UserName;
            Char1speech.text = "And I’m bursting with anticipation to finally get started on my life, now that I’ve decided my path, as a Dark Witch.";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "";
        }
		else if (primeInt == 8)
        {
            Char1name.text = "";
            Char1speech.text = "**You are a natural at the dark arts. Every spell ever written and researched was easily mastered by your hand, until there was nothing left to learn. And when there’s nothing left to learn it’s time to start discovering. Your never ending desire for new spells helps further the culture of witch kind.**";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "";
        }
		else if (primeInt == 9)
        {
            Char1name.text = "";
            Char1speech.text = "**You single handedly created so many new advancements for dark witches everywhere. Creating entirely new fields of study. But there’s a deep sensation that something’s missing.**";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "";
        }
		else if (primeInt == 10)
        {
			ArtChar2.SetActive(false);
			ArtCharDARK.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "**A sensation that hasn’t left you since the day you chose. You feel it was not your destiny to only be committed to the dark arts, even with all the good you’ve done and discoveries you’ve made. This feeling stays with you forever…**";
			nextButton.SetActive(false);
            allowSpace = false;
            NextSceneENDButton.SetActive(true);
        }
	}
	

    public void SceneChangeEND()
    {
        SceneManager.LoadScene("MainMenu");
    }
}