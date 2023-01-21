using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NavigationButtons : MonoBehaviour {

    // Use this for initialization
    public void OnBackClick(){
        save();
        SceneManager.LoadScene("Menu");
    }
    public void OnNextClick() {
        save();
        SceneManager.LoadScene("Gameplay");

    }

    void save() {
        PlayerPrefs.SetFloat("Money", Variables.Money);
        PlayerPrefs.SetInt("AmountDrink1", Variables.AmountDrink1);
        PlayerPrefs.SetInt("AmountDrink2", Variables.AmountDrink2);
        PlayerPrefs.SetInt("AmountMeal1", Variables.AmountMeal1);
        PlayerPrefs.SetInt("AmountMeal2", Variables.AmountMeal2);
        PlayerPrefs.SetInt("AmountDessert1", Variables.AmountDessert1);
        PlayerPrefs.SetInt("AmountDessert2", Variables.AmountDessert2);
    }
}
