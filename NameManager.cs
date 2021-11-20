using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameManager : MonoBehaviour
{
    public Text nametext;

    public void DisplayName(string name)
    {
        switch (name)
        {
            case "cat":
                nametext.text = "Chat / Chatte";
                break;
            case "dog":
                nametext.text = "Chien / Chienne";
                break;
            case "lion":
                nametext.text = "Lion / Lionne";
                break;
            case "cow":
                nametext.text = "Bœuf / Vache";
                break;
            case "pig":
                nametext.text = "Porc / Truie";
                break;
            case "monkey":
                nametext.text = "Singe / Guenon";
                break;
            case "elephant":
                nametext.text = "Éléphant / Éléphante";
                break;
            case "goat":
                nametext.text = "Chèvre / Bouc";
                break;
            default:
                print("waiting for more pet");
                break;
        }

    }
}
