using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LoadGameplay : MonoBehaviour {

    public Text d1, d2, m1, m2, s1, s2;
    public Button mt1, mt2, mt3, mt4, mt5, mt6;
    public Button t1, t2, t3, t4, t5, t6;
    public Button b1, b2, b3, b4, b5, b6;
    public GameObject top, bottom;
    
    // Use this for initialization
    void Start () {
        updateCurrentAmountOfFood();
        mainTables();

        int x = 0;
        while (x < 6) {
            Variables.isBusyMainTable[x] = false;
            Variables.isBusyBottomTable[x] = false;
            Variables.isBusyTopTable[x] = false;
            x++;
        }
        setLanguage();
    }
    void updateCurrentAmountOfFood(){
        d1.text = Variables.AmountDrink1 + "";
        d2.text = Variables.AmountDrink2 + "";
        m1.text = Variables.AmountMeal1 + "";
        m2.text = Variables.AmountMeal2 + "";
        s1.text = Variables.AmountDessert1 + "";
        s2.text = Variables.AmountDessert2 + "";
    }
    void mainTables() {
        setimage(mt1, 0);
        setimage(mt2, 1);
        setimage(mt3, 2);
        setimage(mt4, 3);
        setimage(mt5, 4);
        setimage(mt6, 5);

        setTopimage(t1, 0);
        setTopimage(t2, 1);
        setTopimage(t3, 2);
        setTopimage(t4, 3);
        setTopimage(t5, 4);
        setTopimage(t6, 5);

        setBottomimage(b1, 0);
        setBottomimage(b2, 1);
        setBottomimage(b3, 2);
        setBottomimage(b4, 3);
        setBottomimage(b5, 4);
        setBottomimage(b6, 5);

        if (Variables.topTableEnabled) { top.active = false; }
        if (Variables.bottomTableEnabled) { bottom.active = false; }

    }
    void setimage(Button b,int i) {
        if (Variables.mainlvlTable[i] == 0) { b.image.sprite = Resources.Load<Sprite>("Tables/table0"); b.enabled = false; }
        if (Variables.mainlvlTable[i] == 1) { b.image.sprite = Resources.Load<Sprite>("Tables/table1"); }
        if (Variables.mainlvlTable[i] == 2) { b.image.sprite = Resources.Load<Sprite>("Tables/table2"); }
        if (Variables.mainlvlTable[i] == 3) { b.image.sprite = Resources.Load<Sprite>("Tables/table3"); }
        if (Variables.mainlvlTable[i] == 4) { b.image.sprite = Resources.Load<Sprite>("Tables/table4"); }
        if (Variables.mainlvlTable[i] == 5) { b.image.sprite = Resources.Load<Sprite>("Tables/table5"); }
        if (Variables.mainlvlTable[i] == 6) { b.image.sprite = Resources.Load<Sprite>("Tables/table6"); }
    }
    void setTopimage(Button b, int i) {
        if (Variables.toplvlTable[i] == 0) { b.image.sprite = Resources.Load<Sprite>("Tables/table0"); b.enabled = false; }
        if (Variables.toplvlTable[i] == 1) { b.image.sprite = Resources.Load<Sprite>("Tables/table1"); }
        if (Variables.toplvlTable[i] == 2) { b.image.sprite = Resources.Load<Sprite>("Tables/table2"); }
        if (Variables.toplvlTable[i] == 3) { b.image.sprite = Resources.Load<Sprite>("Tables/table3"); }
        if (Variables.toplvlTable[i] == 4) { b.image.sprite = Resources.Load<Sprite>("Tables/table4"); }
        if (Variables.toplvlTable[i] == 5) { b.image.sprite = Resources.Load<Sprite>("Tables/table5"); }
        if (Variables.toplvlTable[i] == 6) { b.image.sprite = Resources.Load<Sprite>("Tables/table6"); }
    }
    void setBottomimage(Button b, int i){
        if (Variables.bottomlvlTable[i] == 0) { b.image.sprite = Resources.Load<Sprite>("Tables/table0");b.enabled = false; }
        if (Variables.bottomlvlTable[i] == 1) { b.image.sprite = Resources.Load<Sprite>("Tables/table1"); }
        if (Variables.bottomlvlTable[i] == 2) { b.image.sprite = Resources.Load<Sprite>("Tables/table2"); }
        if (Variables.bottomlvlTable[i] == 3) { b.image.sprite = Resources.Load<Sprite>("Tables/table3"); }
        if (Variables.bottomlvlTable[i] == 4) { b.image.sprite = Resources.Load<Sprite>("Tables/table4"); }
        if (Variables.bottomlvlTable[i] == 5) { b.image.sprite = Resources.Load<Sprite>("Tables/table5"); }
        if (Variables.bottomlvlTable[i] == 6) { b.image.sprite = Resources.Load<Sprite>("Tables/table6"); }
    }
    public Text resettv, donetv, tableToptv, tableBottomtv, noTableForYoutv, byebyetv;
    void setLanguage() {
        resettv.text = Translator.resetGameplay;
        donetv.text = Translator.doneGameplay;
        tableToptv.text = Translator.tableTopGameplay;
        tableBottomtv.text = Translator.tableBottomGameplay;
        noTableForYoutv.text = Translator.noTableForYouGameplay;
        byebyetv.text = Translator.byebyeGameplay;

}



}
