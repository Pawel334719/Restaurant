using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class inShoponClicks : MonoBehaviour {

    public GameObject TableObject;

	// Use this for initialization
	void Start () {
		
	}

    public void onFurnitureClick() {
        TableObject.active = true;
    }
    public void onbackToMenuClick(){
        PlayerPrefs.SetFloat("Money", Variables.Money);
        PlayerPrefs.SetInt("maxTableFor", Variables.maxTableFor);


        int x = 0;
        while (x < 6)
        {
            PlayerPrefs.SetInt("toplvlTable" + x, Variables.toplvlTable[x]);
            PlayerPrefs.SetInt("bottomlvlTable" + x, Variables.bottomlvlTable[x]);
            x++;
        }
        PlayerPrefs.SetInt("mainlvlTable1", Variables.mainlvlTable[0]);
        PlayerPrefs.SetInt("mainlvlTable2", Variables.mainlvlTable[1]);
        PlayerPrefs.SetInt("mainlvlTable3", Variables.mainlvlTable[2]);
        PlayerPrefs.SetInt("mainlvlTable4", Variables.mainlvlTable[3]);
        PlayerPrefs.SetInt("mainlvlTable5", Variables.mainlvlTable[4]);
        PlayerPrefs.SetInt("mainlvlTable6", Variables.mainlvlTable[5]);


        PlayerPrefs.SetInt("stufflvlShop0", Variables.stufflvlShop[0]);
        PlayerPrefs.SetInt("stufflvlShop1", Variables.stufflvlShop[1]);
        PlayerPrefs.SetInt("stufflvlShop2", Variables.stufflvlShop[2]);
        PlayerPrefs.SetInt("stufflvlShop3", Variables.stufflvlShop[3]);
        PlayerPrefs.SetInt("eatingTimeDurration", Variables.eatingTimeDurration);

        SceneManager.LoadScene("Menu");
    }
}
