using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene2a : MonoBehaviour
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
    public GameObject ArtBG1;
    public GameObject ArtBG2;
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
        ArtBG1.SetActive(true);
        ArtBG2.SetActive(false);
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
            ArtChar1.SetActive(true);
            dialogue.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "What the...";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 3)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "???";
            Char2speech.text = "Pretty weird huh?";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Huh? Oh yeah I've never seen faces on trees before... especially screaming ones.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 5)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "???";
            Char2speech.text = " Well that's the usual around here, and if you get lost your face will be on one of those trees.";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 6)
        {
            Char1name.text = "YOU";
            Char1speech.text = " Hahahahaha- that was a joke right?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 7)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "???";
            Char2speech.text = "Totally...";
        }
        else if (primeInt == 8)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Wow the light around you is really warm.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 9)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "SAMUEL";
            Char2speech.text = "Well that's because I'm a light mage! My name is Samuel and I work as the lantern bearer incase anyone is lost in these here woods.";
        }
        else if (primeInt == 10)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "SAMUEL";
            Char2speech.text = "It also seems that you haven't chosen a path yet seeing as your magic essence is still without color.";
        }
        else if (primeInt == 11)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Yeah. I'm still stumped on which one to choose.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 12)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "SAMUEL";
            Char2speech.text = "Well if you need help deciding let me show you the perks of a light mage!";
        }
        else if (primeInt == 13)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "SAMUEL";
            Char2speech.text = "Use this spell to shine a path down these woods.";
            // Turn off "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()
        }
        // ENCOUNTER AFTER CHOICE #1
 
        else if (primeInt == 101)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "SAMUEL";
            Char2speech.text = "For light mages the light will never leave your side. Never to be lost in the dark for as long as the magic inside you still burns. Now go on or you'll be late.";
            ArtBG1.SetActive(false);
            ArtBG2.SetActive(true);
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
            NextScene2Button.SetActive(true);
        }
        else if (primeInt == 201)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "SAMUEL";
            Char2speech.text = "That's fine. Well that's what I'm here for! Now get to it, you don't want to be late do you.";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
            NextScene2Button.SetActive(true);
        }
    }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
    public void Choice1aFunct()
    {
        primeInt = 99;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice1bFunct()
    {
        primeInt = 199;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

    public void SceneChange2a()
    {
        SceneManager.LoadScene("Scene3a");
    }
    public void SceneChange2b()
    {
        SceneManager.LoadScene("Scene3b");
    }
}