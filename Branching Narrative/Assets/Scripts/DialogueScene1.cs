using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene1 : MonoBehaviour
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
	public GameObject ArtBG3;
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
		ArtBG3.SetActive(false);
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
            Char1name.text = "PlayerData.UserName";
            Char1speech.text = "*YAWN*, Today's the big day, the day I have to choose. ";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 3)
        {
            Char1name.text = "PlayerData.UserName";
            Char1speech.text = "Will I become a dark witch, or a light witch... I'm still so conflicted, I almost don't want to decide yet, but I must.";
            Char2name.text = "";
            Char2speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {
            Char1name.text = "PlayerData.UserName";
            Char1speech.text = "If only there was a way to choose both? But I don't think the high witch would like that.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 5)
        {
            Char1name.text = "PlayerData.UserName";
            Char1speech.text = "Joan, what do you think I should choose?";
            Char2name.text = "";
            Char2speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 6)
        {
			ArtChar1.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "JOAN";
            Char2speech.text = "((Well, I'd say the whole system is flawed, Making powerful witches have to cut their abilities in half. But if you want to remain in the coven you're going to have to make a choice.))";
        }
        else if (primeInt == 7)
        {
			ArtChar1.SetActive(false);
            Char1name.text = "PlayerData.UserName";
            Char1speech.text = "You Might have a point there.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 8)
        {
            Char1name.text = "PlayerData.UserName";
            Char1speech.text = "Now now now, what to wear....";
            Char2name.text = "";
            Char2speech.text = "";
            // Turn off "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()
        }
        // ENCOUNTER AFTER CHOICE #1
        else if (primeInt == 100)
        {
			ArtChar1.SetActive(false);
            Char1name.text = "PlayerData.UserName";
            Char1speech.text = "Shut up you little flirt, you're gonna make me blush.";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 101)
        {
            Char1name.text = "PlayerData.UserName";
            Char1speech.text = "Well we should start thinking about leaving...";
            Char2name.text = "";
            Char2speech.text = "";
        }
		else if (primeInt == 102)
        {
			ArtBG1.SetActive(false);
			ArtBG2.SetActive(true);
            Char1name.text = "PlayerData.UserName";
            Char1speech.text = "Such a sunny warm day.";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 103)
        {
            Char1name.text = "PlayerData.UserName";
            Char1speech.text = "OHMIGODDESS, We're gonna be late to the ceremony!";
            Char2name.text = "";
            Char2speech.text = "";
        }
		else if (primeInt == 104)
        {
			ArtChar1.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joan";
            Char2speech.text = "((Well the path is ahead, let's hope we don't get lost in the woods today.))";
        }
		else if (primeInt == 105)
        {
			ArtChar1.SetActive(false);
			ArtBG2.SetActive(false);
			ArtBG3.SetActive(true);
            Char1name.text = "PlayerData.UserName";
            Char1speech.text = "A fork in the road, but which path should we take?";
            Char2name.text = "";
            Char2speech.text = "";
        }
		else if (primeInt == 106)
        {
			ArtChar1.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joan";
            Char2speech.text = "((We don't have time for this, just pick!))";
        }

        else if (primeInt == 107)
        {
			ArtChar1.SetActive(false);
            Char1name.text = "PlayerData.UserName";
            Char1speech.text = "Uhm.... Let's go....";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
       	    NextScene2Button.SetActive(true);
        }
    }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
    public void Choice1aFunct()
    {
		ArtChar1.SetActive(true);
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "Joan";
        Char2speech.text = "((Looking Mighty handsome today, lets hope the high witch doesn't catch feelings))";
        primeInt = 99;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice1bFunct()
    {
		ArtChar1.SetActive(true);
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "Joan";
        Char2speech.text = "((It's like your casting a love enchant on me with thoose legs! The high witch should be intimated by your efervessence.))";
        primeInt = 99;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
	

    public void SceneChange2a()
    {
        SceneManager.LoadScene("Scene2a");
    }
    public void SceneChange2b()
    {
        SceneManager.LoadScene("Scene2b");
    }
}