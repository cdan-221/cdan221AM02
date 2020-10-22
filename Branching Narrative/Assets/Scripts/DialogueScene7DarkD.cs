using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene7DarkD : MonoBehaviour
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
		ArtCharDARK.SetActive(false);
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
            Char3speech.text = "You choose Dark? Are you serious?";
        }
        else if (primeInt == 3)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "High Witch";
            Char2speech.text = "Ha ha ha, You are having a laugh aren’t you?";
			Char3name.text = "";
			Char3speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
		else if (primeInt == 4)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "High Witch";
            Char3speech.text = "Oh no, you are serious?";
        }
		else if (primeInt == 5)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "High Witch";
            Char3speech.text = "Even though you only explored the path of light you think you can just start doing magics you know nothing about?";
        }
		else if (primeInt == 6)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "High Witch";
            Char3speech.text = "Well let me introduce you to some unfamiliar faces.";
        }
		else if (primeInt == 7)
        {
			ArtChar2.SetActive(false);
			ArtCharDARK.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Dark Ones";
            Char2speech.text = "HAHAHAHAHAHHAHAHA";
			Char3name.text = "";
            Char3speech.text = "";
        }
		else if (primeInt == 8)
        {
			ArtChar2.SetActive(true);
			ArtCharDARK.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "High Witch";
            Char3speech.text = "What ever shall we do with them? ";
        }
		else if (primeInt == 9)
        {
			ArtChar2.SetActive(false);
			ArtCharDARK.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Dark Ones";
            Char2speech.text = "Let’s burn them alive!";
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
            Char3speech.text = "**Flames appear, flames on the side of your face. Your physical form burnt up to crispy little ashes that blow away. Your witchy soul flies off, badly damaged by the Dark ones’ powers, to live on a new plane of existence. No longer corporeal. **";
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