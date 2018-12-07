using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaDifusa : MonoBehaviour {

    public static float reputation= 0;
    public AnimationCurve goodGuy;
    public AnimationCurve badGuy;

    public float goodGuyValue;
    public float badGuyValue;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AddGoodKarma()
    {
        reputation = reputation + .02f;
    }

    public void AddBadKarma()
    {
        reputation = reputation - .02f;
    }

    public void EvaluateFuzzyLogic()//evaluara la grafica con el valor que recibamos del InputField para ver en que conjunto se encuentra dentro de nuestra grafica que nos dara tres resultados
	{

	//Es para convertir a flotante

		goodGuyValue = goodGuy.Evaluate (reputation);//que guarde el valor que se va a obtener de neustra grafica, y evaluaremos el resultado o la vida que obtendremos de InputValue
		badGuyValue = badGuy.Evaluate (reputation);//que guarde el valor que se va a obtener de neustra grafica, y evaluaremos el resultado o la vida que obtendremos de InputValue
		
	}
}
