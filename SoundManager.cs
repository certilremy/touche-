using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource catSound;
    public AudioSource dogSound;
    public AudioSource lionSound;
    public AudioSource cowSound;
    public AudioSource elephantSound;
    public AudioSource pigSound;
    public AudioSource monkeySound;
    public AudioSource goatSound;

    public GameManager gameManager;

    public void Playvoice(string name)
    {
        switch (name)
        {
            case "cat":
                catSound.Play();
                gameManager.UpdateScore();
                break;
            case "dog":
                dogSound.Play();
                gameManager.UpdateScore();
                break;
            case "lion":
                lionSound.Play();
                gameManager.UpdateScore();
                break;
            case "cow":
                cowSound.Play();
                gameManager.UpdateScore();
                break;
            case "pig":
                pigSound.Play();
                gameManager.UpdateScore();
                break;
            case "monkey":
                monkeySound.Play();
                gameManager.UpdateScore();
                break;
            case "elephant":
                elephantSound.Play();
                gameManager.UpdateScore();
                break;
            case "goat":
                goatSound.Play();
                gameManager.UpdateScore();
                break;
            default:
                print("waiting for more pet");
                break;
        }
    }
}
