using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene6 : MonoBehaviour
{
    [SerializeField] PlayerData playerdata;
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
	public GameObject ArtBG2;
    public GameObject Choice1a;
    public GameObject Choice1b;
	public GameObject Choice1c;
    public GameObject NextScene1Button;
    public GameObject NextScene2Button;
	public GameObject NextScene3Button;
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
		ArtBG2.SetActive(false);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
		Choice1c.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
		NextScene3Button.SetActive(false);
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
            Char1speech.text = "Yes, We're finally here, and it looks like it hasn't started yet.";
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
            Char2speech.text = "((But everyone else is already filing, hurry up!))";
			Char3name.text = "";
			Char3speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
		else if (primeInt == 4)
        {
			ArtChar1.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "Ya'know, it's weird, once I go though that door, I'll have to make a choice, and I'll cut my magic in half,, I'll never be able to do the other again.";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "";
        }
		else if (primeInt == 5)
        {
			ArtChar1.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joan";
            Char2speech.text = "((Yeah, that's how it's always worked))";
			Char3name.text = "";
            Char3speech.text = "";
        }
		else if (primeInt == 6)
        {
			ArtChar1.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "Well, lets get in there, I don't wanna be the last one in.";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "";
        }
		else if (primeInt == 7)
        {
			ArtBG1.SetActive(false);
			ArtBG2.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "Huh, they decorated it all black and white.";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "";
        }
		else if (primeInt == 8)
        {
			ArtChar1.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joan";
            Char2speech.text = "((I know, you witches are always thinking in black and white))";
			Char3name.text = "";
            Char3speech.text = "";
        }
		else if (primeInt == 9)
        {
			ArtChar2.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "I'm kinda scared, I wish there was another way.";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "";
        }
		else if (primeInt == 10)
        {
			ArtChar1.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joan";
            Char2speech.text = "((Well, there isn't so just make your life changing choice and move on))";
			Char3name.text = "";
            Char3speech.text = "";
        }
		else if (primeInt == 11)
        {
			ArtChar1.SetActive(false);
			ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "High Witch";
            Char3speech.text = "You";
        }
		else if (primeInt == 12)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "High Witch";
            Char3speech.text = "It's your turn";
        }
		else if (primeInt == 13)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "High Witch";
            Char3speech.text = "It's time to choose....";
			// Turn off "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()
			Choice1c.SetActive(playerdata.GetTotalPlayerChoices() == 0); // function Choice1cFunct()
        }
        // ENCOUNTER AFTER CHOICE 1 LIGHT
        else if (primeInt == 100)
        {
			ArtChar2.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "High Witch";
            Char3speech.text = "You seemed like the light type";
			nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
		}

	//Encounter after choice 2 DARK
	else if (primeInt == 200)
        {
			ArtChar2.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "Hgih Witch";
            Char3speech.text = "Dark witches do have more fun.";
			nextButton.SetActive(false);
            allowSpace = false;
			NextScene2Button.SetActive(true);
        }
	//Encounter after choice 3 GREY
	else if (primeInt == 300)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "High Witch";
            Char3speech.text = "You WILL Regret this decision...";
			nextButton.SetActive(false);
            allowSpace = false;
			NextScene3Button.SetActive(true);
        }
	
	}
    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
    public void Choice1aFunct()
    {
		ArtChar2.SetActive(true);
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
		Char3name.text = "High Witch";
        Char3speech.text = "I had a feeling...";
        primeInt = 99;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
		Choice1c.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice1bFunct()
    {
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
		Char3name.text = "High Witch";
        Char3speech.text = "Interesting decision.";
        primeInt = 199;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
		Choice1c.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
	public void Choice1cFunct()
    {
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
		Char3name.text = "High Witch";
        Char3speech.text = "...";
        primeInt = 299;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
		Choice1c.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
	
    public void LightSceneChange()
    {
        if(playerdata.GetTotalPlayerChoices()==2)
            SceneManager.LoadScene("Scene7LightWin");
        else SceneManager.LoadScene("Scene7LightDeath");
    }
    public void DarkSceneChange()
    {
        if (playerdata.GetTotalPlayerChoices() == -2)
            SceneManager.LoadScene("Scene7DarkWin");
        else SceneManager.LoadScene("Scene7DarkDeath");
    }
	public void SceneChangeGreyWin()
    {
        SceneManager.LoadScene("Scene7GreyWin");
    }
}