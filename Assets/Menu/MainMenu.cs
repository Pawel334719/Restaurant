using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public GameObject restartLayout;
    public void PlayGame() {
        PlayerPrefs.SetFloat("Money", Variables.Money );
        SceneManager.LoadScene("BeforeStartGame");
    }

    public void GoShop() {
        PlayerPrefs.SetFloat("Money", Variables.Money);
        SceneManager.LoadScene("Shop");
    }

    public void QuitGame() {
        Application.Quit();
    }
    public void restartGame() {
        restartLayout.active = true;
    }

    public void onNoResetClick() {
        restartLayout.active = false;
    }
    public void onYesResetClick()
    {

        PlayerPrefs.SetFloat("Money", 1000);
        PlayerPrefs.SetInt("maxTableFor", 2);
        PlayerPrefs.SetInt("Day", 1);

        int x = 0;
        while (x < 6)
        {
            PlayerPrefs.SetInt("toplvlTable" + x, 0);
            PlayerPrefs.SetInt("bottomlvlTable" + x, 0);
            x++;
        }
        PlayerPrefs.SetInt("mainlvlTable1", 2);
        PlayerPrefs.SetInt("mainlvlTable2", 1);
        PlayerPrefs.SetInt("mainlvlTable3", 2);
        PlayerPrefs.SetInt("mainlvlTable4", 1);
        PlayerPrefs.SetInt("mainlvlTable5", 1);
        PlayerPrefs.SetInt("mainlvlTable6", 0);


        PlayerPrefs.SetInt("stufflvlShop0", 0);
        PlayerPrefs.SetInt("stufflvlShop1", 0);
        PlayerPrefs.SetInt("stufflvlShop2", 0);
        PlayerPrefs.SetInt("stufflvlShop3", 0);
        PlayerPrefs.SetInt("eatingTimeDurration", 120);

        PlayerPrefs.SetInt("AmountDrink1", 100);
        PlayerPrefs.SetInt("AmountDrink2", 100);
        PlayerPrefs.SetInt("AmounMeal1", 100);
        PlayerPrefs.SetInt("AmountMeal2", 100);
        PlayerPrefs.SetInt("AmountDessert1", 100);
        PlayerPrefs.SetInt("AmountDessert2", 100);
        
        restartLayout.active = false;
    }
}
