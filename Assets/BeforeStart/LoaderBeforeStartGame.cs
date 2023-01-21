using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoaderBeforeStartGame : MonoBehaviour {
    
    public Text Money,CurrentAmountd1,CurrentAmountd2, CurrentAmountm1, CurrentAmountm2, CurrentAmounts1, CurrentAmounts2;
    float money;
    int x;
    void Start () {
        //ZAŁADOWANIE PIENIĄSZKÓW
        money= PlayerPrefs.GetFloat("Money", 1000);
        Money.text = "" + money;
        Variables.Money = money;
        //ZAŁADOWANIE ILOŚĆ PRODUKTÓW DANEGO TYPU
        x= PlayerPrefs.GetInt("AmountDrink1", 100);
        CurrentAmountd1.text = ""+x;
        Variables.AmountDrink1 = x;


        x = PlayerPrefs.GetInt("AmountDrink2", 100);
        CurrentAmountd2.text = "" + x;
        Variables.AmountDrink2 = x;


        x = PlayerPrefs.GetInt("AmountMeal1", 100);
        CurrentAmountm1.text = "" + x;
        Variables.AmountMeal1 = x;


        x = PlayerPrefs.GetInt("AmountMeal2", 100);
        CurrentAmountm2.text = "" + x;
        Variables.AmountMeal2 = x;


        x = PlayerPrefs.GetInt("AmountDessert1", 100);
        CurrentAmounts1.text = "" + x;
        Variables.AmountDessert1 = x;


        x = PlayerPrefs.GetInt("AmountDessert2", 100);
        CurrentAmounts2.text = "" + x;
        Variables.AmountDessert2 = x;


        setLanguage();
    }
    public Text infotv, drink1tv, drink2tv, meal1tv, meal2tv, sweet1tb, sweet2tv; 
    void setLanguage() {
        infotv.text=Translator.infoBeforeStartGame;
        drink1tv.text= Translator.buyString;
        drink2tv.text= Translator.buyString;
        meal1tv.text= Translator.buyString;
        meal2tv.text= Translator.buyString;
        sweet1tb.text= Translator.buyString;
        sweet2tv.text= Translator.buyString; 


}
	
}
