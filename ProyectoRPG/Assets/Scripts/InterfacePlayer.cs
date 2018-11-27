using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InterfacePlayer : MonoBehaviour
{
    Character character;
    [Header("Player Stats")]
    public Image imgPortrait;
    public Image imgHP, imgPP, imgXP;
    public Text textName, textHP, textPP, textXP, textLevel;
    // Use this for initialization

    void Start()
    {
        
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        if(character == null || character.nameChar == "")
        {
            character = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().character;
            imgPortrait.sprite = character.sprCharacter;
            textName.text = character.nameChar;
        }
        if (character == null) return;
        textHP.text = "" + character.hpCurrent + "/" + character.hpMax;
        imgHP.fillAmount = (float) character.hpCurrent / (float) character.hpMax;
        textPP.text = "" + character.ppCurrent + "/" + character.ppMax;
        imgPP.fillAmount = (float)character.ppCurrent / (float)character.ppMax;

    }
}
