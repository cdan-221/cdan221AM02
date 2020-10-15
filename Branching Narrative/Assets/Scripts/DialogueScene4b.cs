using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using TMPro;

public class DialogueScene4b : MonoBehaviour
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
    const string YOU = "You";
    const string Doc = "Doc";

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


    private void speak(int charnumber, bool displayChoice, string charname, string speech)
    {
        dialogue.SetActive(true);
        if (charnumber == 1) // player
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(false);
            Char1name.text = charname;
            Char1speech.text = speech;
            Char2name.text = string.Empty;
            Char2speech.text = string.Empty;
            Char3name.text = string.Empty;
            Char3speech.text = string.Empty;
        }
        else if (charnumber == 2)
        {
            ArtChar2.SetActive(true);
            Char1name.text = string.Empty;
            Char1speech.text = string.Empty;
            Char2name.text = charname;
            Char2speech.text = speech;
            Char3name.text = string.Empty;
            Char3speech.text = string.Empty;
        }
        else throw new UnityException("INVALID CHARACTER NUMBER INSERT 1 OR 2!");
        allowSpace = !displayChoice;
        nextButton.SetActive(!displayChoice);
        Choice1a.SetActive(displayChoice);
        Choice1b.SetActive(displayChoice);
    }
    private void DisplayNextScene()
    {
        NextScene1Button.SetActive(true);
        NextScene2Button.SetActive(true);
        allowSpace = false;
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
            speak(1, false, string.Empty, "*soft piano music plays*");
        }
        else if (primeInt == 3)
        {
            speak(1, false, YOU, "Well this is a nice change of pace! I love the piano. And this song is amazing!");
        }
        else if (primeInt == 4)
        {
            speak(2, false, Doc, "...You wrote it");
        }
        else if (primeInt == 5)
        {
            speak(1, false, YOU, "Oh no no no, im flattered but I focus so much on school I've never had time to learn the piano.");
        }
        else if (primeInt == 6)
        {
            speak(2, false, Doc, "This, is the Piano to your soul, each key represents a fragment of you");

        }
        else if (primeInt == 7)
        {
            speak(2, false, Doc, "Would you like to play your piano?");

        }
        else if (primeInt == 8)
        {
            speak(1, true, YOU, "My Piano??");
        }
        else if (primeInt == 9)
        {

        }
        else if (primeInt == 10)
        {

        }
        else if (primeInt == 11)
        {

        }
        else if (primeInt == 12)
        {

        }
        else if (primeInt == 13)
        {
        }
        else if (primeInt == 14)
        {

        }
        else if (primeInt == 15)
        {

        }
        else if (primeInt == 16)
        {
        }
        // ENCOUNTER AFTER CHOICE #1
        else if (primeInt == 100)
        {
            speak(1, false, string.Empty, "*you play the piano perfectly and are lost in a trance*");
        }
        else if (primeInt == 101)
        {
            speak(2, false, Doc, "This is what magic can be like. The perfect balence between the concious and subconcious");
        }
        else if (primeInt == 102)
        {
            speak(1, false, string.Empty, "*you stop playing*");
        }
        else if (primeInt == 103)
        {
            speak(1, false, YOU, "Wow I didnt know I had it in me");
        }
        else if (primeInt == 104)
        {
            speak(2, false, Doc, "Many people dont have the magical power to be able to do that. Consider yourself lucky");
        }
        else if (primeInt == 105)
        {
            speak(1, false, YOU, "So some people never get to expereince this?");
        }
        else if (primeInt == 106)
        {
            speak(2, false, Doc, "No, some people never get to know how their own songs end");
        }
        else if (primeInt == 107)
        {
            speak(2, false, Doc, "But you can have more.");
        }
        else if (primeInt == 108)
        {
            speak(2, false, Doc, "With powers like ours, you can change outcome of any ones life, you can become a king like me! What do you say?");
        }
        else if (primeInt == 109)
        {
            speak(2, false, Doc, "The path to the right is a path to a greater understanding of your magical powers. OR you make go left..... to the high witch");
            DisplayNextScene();
        }

        //Encounter after choice 2
        else if (primeInt == 200)
        {
            speak(2, false, Doc, "so you rather be a sheep to high wtich youre whole life?!?!?");
        }
        else if (primeInt == 201)
        {
            speak(1, false, YOU, "huh?");
        }
        else if (primeInt == 202)
        {
            speak(2, false, Doc, "Weak witches like you disugst me get out my sight");
        }
        else if (primeInt == 203)
        {
            speak(2, false, Doc, "The path to the right is a path to a greater understanding of your magical powers. OR you make go left..... to the high witch");
            DisplayNextScene();
        }
    }
    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
    public void Choice1aFunct()
    {
        primeInt = 99;
        talking();
        allowSpace = true;
    }
    public void Choice1bFunct()
    {
        primeInt = 199;
        talking();
        allowSpace = false;
    }


    public void SceneChange4a()
    {
        SceneManager.LoadScene("Scene5a");
    }
    public void SceneChange4b()
    {
        SceneManager.LoadScene("Scene5b");
    }
}