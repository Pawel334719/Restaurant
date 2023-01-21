using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TableBuying : MonoBehaviour {

    public GameObject buyingLayout,tableLayout;
    public Text infotv;
    public Image buyingItemImage;
    public Button buyButton;
    int ID,TablePrice;
    // Use this for initialization
    void Start () {
		
	}
	
	

    public void onMainTable1Click() {
        buyingLayout.active=true;
        buyingmenager(0);
    }
    public void onMainTable2Click() {
        buyingLayout.active = true;
        buyingmenager(1);
    }
    public void onMainTable3Click() {
        buyingLayout.active = true;
        buyingmenager(2);
    }
    public void onMainTable4Click() {
        buyingLayout.active = true;
        buyingmenager(3);
    }
    public void onMainTable5Click() {
        buyingLayout.active = true;
        buyingmenager(4);
    }
    public void onMainTable6Click() {
        buyingLayout.active = true;
        buyingmenager(5);
    }
    /// /TOP!!!
    public void onTopTable1Click() {
        buyingLayout.active = true;
        buyingmenager(10);
    }
    public void onTopTable2Click() {
        buyingLayout.active = true;
        buyingmenager(11);
    }
    public void onTopTable3Click() {
        buyingLayout.active = true;
        buyingmenager(12);
    }
    public void onTopTable4Click() {
        buyingLayout.active = true;
        buyingmenager(13);
    }
    public void onTopTable5Click() {
        buyingLayout.active = true;
        buyingmenager(14);
    }
    public void onTopTable6Click() {
        buyingLayout.active = true;
        buyingmenager(15);
    }
    ///BOTTOM
    public void onBottomTable1Click() {
        buyingLayout.active = true;
        buyingmenager(20);
    }
    public void onBottomTable2Click() {
        buyingLayout.active = true;
        buyingmenager(21);
    }
    public void onBottomTable3Click() {
        buyingLayout.active = true;
        buyingmenager(22);
    }
    public void onBottomTable4Click() {
        buyingLayout.active = true;
        buyingmenager(23);
    }
    public void onBottomTable5Click() {
        buyingLayout.active = true;
        buyingmenager(24);
    }
    public void onBottomTable6Click() {
        buyingLayout.active = true;
        buyingmenager(25);
    }


    public void buyingTopRestaurent() {
        buyingLayout.active = true;
        buyingmenager(34);
    }
    public void buyingBottomRestaurant() {
        buyingLayout.active = true;
        buyingmenager(32);
    }

    void buyingmenager(int id) {
        int currentlvl = 0,tableprice=0;
        string info="";
        ID = id;
        if (id == 0) { currentlvl = Variables.mainlvlTable[0]; }
        if (id == 1) { currentlvl = Variables.mainlvlTable[1]; }
        if (id == 2) { currentlvl = Variables.mainlvlTable[2]; }
        if (id == 3) { currentlvl = Variables.mainlvlTable[3]; }
        if (id == 4) { currentlvl = Variables.mainlvlTable[4]; }
        if (id == 5) { currentlvl = Variables.mainlvlTable[5]; }

        if (id == 10) { currentlvl = Variables.toplvlTable[0]; }
        if (id == 11) { currentlvl = Variables.toplvlTable[1]; }
        if (id == 12) { currentlvl = Variables.toplvlTable[2]; }
        if (id == 13) { currentlvl = Variables.toplvlTable[3]; }
        if (id == 14) { currentlvl = Variables.toplvlTable[4]; }
        if (id == 15) { currentlvl = Variables.toplvlTable[5]; }

        if (id == 20) { currentlvl = Variables.bottomlvlTable[0]; }
        if (id == 21) { currentlvl = Variables.bottomlvlTable[1]; }
        if (id == 22) { currentlvl = Variables.bottomlvlTable[2]; }
        if (id == 23) { currentlvl = Variables.bottomlvlTable[3]; }
        if (id == 24) { currentlvl = Variables.bottomlvlTable[4]; }
        if (id == 25) { currentlvl = Variables.bottomlvlTable[5]; }

        if (currentlvl == 0) { tableprice = 50; buyingItemImage.sprite = Resources.Load<Sprite>("Tables/table1"); }
        if (currentlvl == 1) { tableprice = 75; buyingItemImage.sprite = Resources.Load<Sprite>("Tables/table2"); }
        if (currentlvl == 2) { tableprice = 110; buyingItemImage.sprite = Resources.Load<Sprite>("Tables/table3"); }
        if (currentlvl == 3) { tableprice = 180; buyingItemImage.sprite = Resources.Load<Sprite>("Tables/table4"); }
        if (currentlvl == 4) { tableprice = 240; buyingItemImage.sprite = Resources.Load<Sprite>("Tables/table5"); }
        if (currentlvl == 5) { tableprice = 321; buyingItemImage.sprite = Resources.Load<Sprite>("Tables/table6"); }
        if (currentlvl == 6) { tableprice = 0; buyingItemImage.sprite = Resources.Load<Sprite>("Tables/table6"); }

        
        info = Translator.tablebuying1Shop + (currentlvl + 1) + Translator.tablebuying2Shop + Translator.priceString+ tableprice;
        if (currentlvl == 6) { info = Translator.tablebuying3Shop; buyButton.enabled = false; }

        if (id == 34) { tableprice = 1000; buyingItemImage.sprite = Resources.Load<Sprite>("Tables/table0");info = Translator.morespaceShop + Translator.priceString +tableprice+""; }
        if (id == 32) { tableprice = 500; buyingItemImage.sprite = Resources.Load<Sprite>("Tables/table0"); info = Translator.morespaceShop + Translator.priceString + tableprice+""; }
        TablePrice = tableprice;
        infotv.text = info;

    }
    public void onBuyClick() {
        if (Variables.Money>=TablePrice) {
            if (ID == 0) { Variables.mainlvlTable[0]++; }
            if (ID == 1) { Variables.mainlvlTable[1]++; }
            if (ID == 2) { Variables.mainlvlTable[2]++; }
            if (ID == 3) { Variables.mainlvlTable[3]++; }
            if (ID == 4) { Variables.mainlvlTable[4]++; }
            if (ID == 5) { Variables.mainlvlTable[5]++; }

            if (ID == 10) { Variables.toplvlTable[0]++; }
            if (ID == 11) { Variables.toplvlTable[1]++; }
            if (ID == 12) { Variables.toplvlTable[2]++; }
            if (ID == 13) { Variables.toplvlTable[3]++; }
            if (ID == 14) { Variables.toplvlTable[4]++; }
            if (ID == 15) { Variables.toplvlTable[5]++; }

            if (ID == 20) { Variables.bottomlvlTable[0]++; }
            if (ID == 21) { Variables.bottomlvlTable[1]++; }
            if (ID == 22) { Variables.bottomlvlTable[2]++; }
            if (ID == 23) { Variables.bottomlvlTable[3]++; }
            if (ID == 24) { Variables.bottomlvlTable[4]++; }
            if (ID == 25) { Variables.bottomlvlTable[5]++; }

            if (ID == 34) { Variables.topTableEnabled = true;Variables.toplvlTable[0]++; }
            if (ID == 32) { Variables.bottomTableEnabled = true; Variables.bottomlvlTable[0]++; }
            Variables.Money -= TablePrice;
            buyingLayout.active = false;
        }
        infotv.text ="You need "+(TablePrice-Variables.Money)+" more money to buy it";
    }

    public void idontbuy() {
        buyButton.enabled = true;
        buyingLayout.active = false;
    }
    public void backtoshop() {
        tableLayout.active = false;
    }
}
