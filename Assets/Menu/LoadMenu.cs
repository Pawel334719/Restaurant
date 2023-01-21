using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadMenu : MonoBehaviour {

    public Text money,daytv;
    float m;
	void Start () {
        loadMainMenu();
    }
    public void loadMainMenu() {
        Translator.setPolish();
        m = PlayerPrefs.GetFloat("Money", 1000);
        money.text = m + "";
        Variables.Money = m;

        // zeruje tablice kasy
        int x = 0;
        while (x < 3)
        {
            int y = 0;
            while (y < 2)
            {
                Variables.Bill[x, y] = 0;
                Variables.ClientOrder[x, y] = 0;
                y++;
            }
            x++;
        }
        Variables.Queue = 0;
        Variables.customerAtCheckout = false;
        Variables.maxTableFor = PlayerPrefs.GetInt("maxTableFor", 2);
        Variables.Day = PlayerPrefs.GetInt("Day", 1);
        daytv.text = Translator.dayMenu + Variables.Day;

        x = 0;
        while (x < 6)
        {
            Variables.toplvlTable[x] = PlayerPrefs.GetInt("toplvlTable" + x, 0);
            Variables.bottomlvlTable[x] = PlayerPrefs.GetInt("bottomlvlTable" + x, 0);
            x++;
        }

        Variables.mainlvlTable[0] = PlayerPrefs.GetInt("mainlvlTable1", 2);
        Variables.mainlvlTable[1] = PlayerPrefs.GetInt("mainlvlTable2", 1);
        Variables.mainlvlTable[2] = PlayerPrefs.GetInt("mainlvlTable3", 2);
        Variables.mainlvlTable[3] = PlayerPrefs.GetInt("mainlvlTable4", 1);
        Variables.mainlvlTable[4] = PlayerPrefs.GetInt("mainlvlTable5", 1);
        Variables.mainlvlTable[5] = PlayerPrefs.GetInt("mainlvlTable6", 0);


        if (Variables.toplvlTable[0] == 0) { Variables.topTableEnabled = false; } else Variables.topTableEnabled = true;
        if (Variables.bottomlvlTable[0] == 0) { Variables.bottomTableEnabled = false; } else Variables.bottomTableEnabled = true;

        //               ****shop****
        Variables.stufflvlShop[0] = PlayerPrefs.GetInt("stufflvlShop0", 0);
        Variables.stufflvlShop[1] = PlayerPrefs.GetInt("stufflvlShop1", 0);
        Variables.stufflvlShop[2] = PlayerPrefs.GetInt("stufflvlShop2", 0);
        Variables.stufflvlShop[3] = PlayerPrefs.GetInt("stufflvlShop3", 0);
        Variables.eatingTimeDurration = PlayerPrefs.GetInt("eatingTimeDurration", 120);

        if (Variables.stufflvlShop[2] == 0) { Variables.markup = 0.5f; }
        if (Variables.stufflvlShop[2] == 1) { Variables.markup = 1f; }
        if (Variables.stufflvlShop[2] == 2) { Variables.markup = 1.5f; }
        if (Variables.stufflvlShop[2] == 3) { Variables.markup = 2f; }
        if (Variables.stufflvlShop[2] == 4) { Variables.markup = 2.5f; }
        if (Variables.stufflvlShop[2] == 5) { Variables.markup = 3f; }

        if (Variables.stufflvlShop[1] == 0) { Variables.foodSurvive = 0f; }
        if (Variables.stufflvlShop[1] == 1) { Variables.foodSurvive = 0.25f; }
        if (Variables.stufflvlShop[1] == 2) { Variables.foodSurvive = 0.50f; }
        if (Variables.stufflvlShop[1] == 3) { Variables.foodSurvive = 0.75f; }
        if (Variables.stufflvlShop[1] == 4) { Variables.foodSurvive = 0.90f; }
        if (Variables.stufflvlShop[1] == 5) { Variables.foodSurvive = 1f; }

        if (Variables.stufflvlShop[3] == 0) { Variables.maxTableFor = 2; }
        if (Variables.stufflvlShop[3] == 1) { Variables.maxTableFor = 3; }
        if (Variables.stufflvlShop[3] == 2) { Variables.maxTableFor = 4; }
        if (Variables.stufflvlShop[3] == 3) { Variables.maxTableFor = 5; }
        if (Variables.stufflvlShop[3] == 4) { Variables.maxTableFor = 6; }
        setLanguage();

    }
    public Text playtv, shoptv, quittv, resetallgametv, infotv, yesButtontv, noButtontv;
    void setLanguage() {
        playtv.text = Translator.playMenu;
        shoptv.text = Translator.shopMenu;
        quittv.text = Translator.quitMenu;
        resetallgametv.text = Translator.resetallgameMenu;
        infotv.text = Translator.infoMenu;
        yesButtontv.text = Translator.yesButtonMenu;
        noButtontv.text = Translator.noButtonMenu;
    }

}
