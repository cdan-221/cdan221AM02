using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene7LightD : MonoBehaviour
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
	public GameObject ArtCharLIGHT;
    public GameObject ArtBG1;
	public GameObject ArtBG2;
    public GameObject NextSceneDEATHButton;
    public GameObject nextButton;
    //public GameObject gameHandler;
    //public AudioSource audioSource;
    private bool allowSpace = true;

    void Start()
    {         // initial visibility settings
        dialogue.SetActive(false);
        ArtChar1.SetActive(false);
		ArtChar2.SetActive(false);
		ArtCharLIGHT.SetActive(false);
        ArtBG1.SetActive(true);
		ArtBG2.SetActive(false);
        NextSceneDEATHButton.SetActive(false);
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
            Char3speech.text = "Ha, silly little witch, you really think you can be a light witch with your track record.";
        }
        else if (primeInt == 3)
        {
			ArtChar2.SetActive(false);
			ArtCharLIGHT.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "Light Ones";
			Char3speech.text = "We don’t even know them…";
            //gameHandler.AddPlayerStat(1);
        }
		else if (primeInt == 4)
        {
			ArtChar2.SetActive(true);
			ArtCharLIGHT.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "High Witch";
            Char3speech.text = "Imagine that.";
        }
		else if (primeInt == 5)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "High Witch";
            Char3speech.text = "Well for your pestilence I’ll let these fine witches decide your fate….";
        }
		else if (primeInt == 6)
        {
			ArtChar2.SetActive(false);
			ArtCharLIGHT.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "Light Ones";
            Char3speech.text = "Hmmm… Let’s think";
        }
		else if (primeInt == 7)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Light Ones";
            Char2speech.text = "DEATH";
			Char3name.text = "";
            Char3speech.text = "";
        }
		else if (primeInt == 8)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "Minori";
            Char3speech.text = "I wanna see you PAY!";
        }
		else if (primeInt == 9)
        {
			ArtChar2.SetActive(true);
			ArtCharLIGHT.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "High Witch";
            Char3speech.text = " Well they’ve decided your fate, so goodbye.";
        }
		else if (primeInt == 10)
        {
			ArtChar2.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "**The Light witches take turns casting spells on you until your fleshy form is unrecognizable and your soul floats off to a new plane of existence**";
			nextButton.SetActive(false);
            allowSpace = false;
            NextSceneDEATHButton.SetActive(true);
        }
	}
    public void SceneChangeDEATH()
    {
        SceneManager.LoadScene("DEATH");
    }
}