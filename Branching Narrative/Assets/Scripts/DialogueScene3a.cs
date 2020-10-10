using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene3a : MonoBehaviour
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
    public GameObject ArtBG1;
    public GameObject Choice1a;
    public GameObject Choice1b;
    public GameObject NextScene1Button;
    public GameObject NextScene2Button;
    public GameObject nextButton;
    //public GameObject gameHandler;
    //public AudioSource audioSource;
    private bool allowSpace = true;

    void Start()
    {         // initial visibility settings
        dialogue.SetActive(false);
        ArtChar1.SetActive(false);
		ArtChar2.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
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
            dialogue.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "Oh wow Joan, look at the beautiful flowers!";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 3)
        {
			ArtChar1.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joan";
            Char2speech.text = "((I see lilies, are you trying to kill me? ))";
			Char3name.text = "";
			Char3speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
		else if (primeInt == 4)
        {
			ArtChar1.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "???";
            Char3speech.text = "Oh hello there!";
        }
		else if (primeInt == 5)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Who's there?";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "";
        }
		else if (primeInt == 6)
        {
			ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "Minori";
            Char3speech.text = "Sorry! My Name’s Minori, this is my love cafe! We’re having a wedding right now, but…. Hmmmm…..";
        }
		else if (primeInt == 7)
        {
			ArtChar2.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "Is something wrong??";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "";
        }
		else if (primeInt == 8)
        {
			ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "Minori";
            Char3speech.text = "it’s nothing…";
        }
		else if (primeInt == 9)
        {
			ArtChar2.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "Well then we should really be-";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "";
        }
		else if (primeInt == 10)
        {
			ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "Minori";
            Char3speech.text = "FINE! I’ll tell you… I’m supposed to have a batch of my famous love tea but the love spell I cast on it last night isn’t taking... ";
        }
		else if (primeInt == 11)
        {
			ArtChar1.SetActive(true);
			ArtChar2.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joan";
            Char2speech.text = "((Need I remind you we’re running late??))";
			Char3name.text = "";
            Char3speech.text = "";
        }
		else if (primeInt == 12)
        {
			ArtChar2.SetActive(true);
			ArtChar1.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "Minori";
            Char3speech.text = "Wait a second… a talking cat.. A FAMILIAR! You're a witch right?!";
        }
		else if (primeInt == 13)
        {
			ArtChar2.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "Yeah, but I-";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "";
        }
		else if (primeInt == 14)
        {
			ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "Minori";
            Char3speech.text = "Perfect! Maybe you can help with the love spell! It’s really simple and the guests my cafe is currently hosting are expecting it!";
        }
		else if (primeInt == 15)
        {
			ArtChar2.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "I don’t know.. I’ve never really used this type of magic before.";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 16)
        {
			ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "Minori";
            Char3speech.text = "Please please pretty please!! It’s not that hard I’ll walk you through it just say you’ll do it!";
            // Turn off "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()
        }
        // ENCOUNTER AFTER CHOICE #1
        else if (primeInt == 17)
        {
			ArtChar2.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "I guess we should get going then huh, which way?";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "";
			nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
			NextScene2Button.SetActive(true);
        }
	}

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
    public void Choice1aFunct()
    {
        Char1name.text = "YOU";
        Char1speech.text = "Yeah this feels right!";
        Char2name.text = "";
        Char2speech.text = "";
		Char3name.text = "";
        Char3speech.text = "";
        primeInt = 99;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice1bFunct()
    {
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "Joan";
        Char2speech.text = "((It's like your casting a love enchant on me with thoose legs! The high witch should be intimated by your efervessence.))";
		Char3name.text = "";
        Char3speech.text = "";
        primeInt = 199;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
	

    public void SceneChange4a()
    {
        SceneManager.LoadScene("Scene4a");
    }
    public void SceneChange4b()
    {
        SceneManager.LoadScene("Scene4b");
    }
}