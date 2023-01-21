using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TablesScript : MonoBehaviour {

    public Button m1, m2, m3, m4, m5, m6,
                  b1, b2, b3, b4, b5, b6,
                  t1, t2, t3, t4, t5, t6;
    public Text drink1, drink2, meal1, meal2, sweet1, sweet2;
    public GameObject ClientLayoutObject,TableLayoutObject;
    float[] mainTableTime = new float[6], topTableTime = new float[6], bottomTableTime = new float[6];
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Variables.isTableLayoutActive) { 
        ///MAIN TABLE UPDATE
        if (Variables.isBusyMainTable[0]) { int f = Mathf.RoundToInt(mainTableTime[0] - Time.time); m1.GetComponentInChildren<Text>().text = "" + f;
            if (f <= 0) { Variables.isBusyMainTable[0] = false; m1.GetComponentInChildren<Text>().text = "";setimage(m1, 0);m1.enabled = true; }
        }
        if (Variables.isBusyMainTable[1]){ int f = Mathf.RoundToInt(mainTableTime[1] - Time.time); m2.GetComponentInChildren<Text>().text = "" + f;
            if (f <= 0) { Variables.isBusyMainTable[1] = false; m2.GetComponentInChildren<Text>().text = ""; setimage(m2, 1); m2.enabled = true; }
        }
        if (Variables.isBusyMainTable[2]){ int f = Mathf.RoundToInt(mainTableTime[2] - Time.time); m3.GetComponentInChildren<Text>().text = "" + f;
            if (f <= 0) { Variables.isBusyMainTable[2] = false; m3.GetComponentInChildren<Text>().text = ""; setimage(m3, 2); m3.enabled = true; }
        }
        if (Variables.isBusyMainTable[3]){ int f = Mathf.RoundToInt(mainTableTime[3] - Time.time); m4.GetComponentInChildren<Text>().text = "" + f;
            if (f <= 0) { Variables.isBusyMainTable[3] = false; m4.GetComponentInChildren<Text>().text = ""; setimage(m4, 3); m4.enabled = true; }
        }
        if (Variables.isBusyMainTable[4]){ int f = Mathf.RoundToInt(mainTableTime[4] - Time.time); m5.GetComponentInChildren<Text>().text = "" + f;
            if (f <= 0) { Variables.isBusyMainTable[4] = false; m5.GetComponentInChildren<Text>().text = ""; setimage(m5, 4); m5.enabled = true; }
        }
        if (Variables.isBusyMainTable[5]){ int f = Mathf.RoundToInt(mainTableTime[5] - Time.time); m6.GetComponentInChildren<Text>().text = "" + f;
            if (f <= 0) { Variables.isBusyMainTable[5] = false; m6.GetComponentInChildren<Text>().text = ""; setimage(m6, 5); m6.enabled = true; }
        }
        ///TOP TABLE UPDATE
        if (Variables.isBusyTopTable[0]){ int f = Mathf.RoundToInt(topTableTime[0] - Time.time); t1.GetComponentInChildren<Text>().text = "" + f;
            if (f <= 0) { Variables.isBusyTopTable[0] = false; t1.GetComponentInChildren<Text>().text = ""; setTopimage(m1, 0); t1.enabled = true; }
        }
        if (Variables.isBusyTopTable[1]){ int f = Mathf.RoundToInt(topTableTime[1] - Time.time); t2.GetComponentInChildren<Text>().text = "" + f;
            if (f <= 0) { Variables.isBusyTopTable[1] = false; t2.GetComponentInChildren<Text>().text = ""; setTopimage(m2, 1); t2.enabled = true; }
        }
        if (Variables.isBusyTopTable[2]){ int f = Mathf.RoundToInt(topTableTime[2] - Time.time); t3.GetComponentInChildren<Text>().text = "" + f;
            if (f <= 0) { Variables.isBusyTopTable[2] = false; t3.GetComponentInChildren<Text>().text = ""; setTopimage(m3, 2); t3.enabled = true; }
        }
        if (Variables.isBusyTopTable[3]){ int f = Mathf.RoundToInt(topTableTime[3] - Time.time); t4.GetComponentInChildren<Text>().text = "" + f;
            if (f <= 0) { Variables.isBusyTopTable[3] = false; t4.GetComponentInChildren<Text>().text = ""; setTopimage(m4, 3); t4.enabled = true; }
        }
        if (Variables.isBusyTopTable[4]){ int f = Mathf.RoundToInt(topTableTime[4] - Time.time); t5.GetComponentInChildren<Text>().text = "" + f;
            if (f <= 0) { Variables.isBusyTopTable[4] = false; t5.GetComponentInChildren<Text>().text = ""; setTopimage(m5, 4); t5.enabled = true; }
        }
        if (Variables.isBusyTopTable[5]){ int f = Mathf.RoundToInt(topTableTime[5] - Time.time); t6.GetComponentInChildren<Text>().text = "" + f;
            if (f <= 0) { Variables.isBusyTopTable[5] = false; t6.GetComponentInChildren<Text>().text = ""; setTopimage(m6, 5); t6.enabled = true; }
        }
        ///BOTTOM TABLE UPDATE
        if (Variables.isBusyBottomTable[0]){ int f = Mathf.RoundToInt(bottomTableTime[0] - Time.time); b1.GetComponentInChildren<Text>().text = "" + f;
            if (f <= 0) { Variables.isBusyBottomTable[0] = false; b1.GetComponentInChildren<Text>().text = ""; setBottomimage(b1, 0); b1.enabled = true; }
        }
        if (Variables.isBusyBottomTable[1]){ int f = Mathf.RoundToInt(bottomTableTime[1] - Time.time); b2.GetComponentInChildren<Text>().text = "" + f;
            if (f <= 0) { Variables.isBusyBottomTable[1] = false; b2.GetComponentInChildren<Text>().text = ""; setBottomimage(b2, 1); b2.enabled = true; }
        }
        if (Variables.isBusyBottomTable[2]){ int f = Mathf.RoundToInt(bottomTableTime[2] - Time.time); b3.GetComponentInChildren<Text>().text = "" + f;
            if (f <= 0) { Variables.isBusyBottomTable[2] = false; b3.GetComponentInChildren<Text>().text = ""; setBottomimage(b3, 2); b3.enabled = true; }
        }
        if (Variables.isBusyBottomTable[3]){ int f = Mathf.RoundToInt(bottomTableTime[3] - Time.time); b4.GetComponentInChildren<Text>().text = "" + f;
            if (f <= 0) { Variables.isBusyBottomTable[3] = false; b4.GetComponentInChildren<Text>().text = ""; setBottomimage(b4, 3); b4.enabled = true; }
        }
        if (Variables.isBusyBottomTable[4]){ int f = Mathf.RoundToInt(bottomTableTime[4] - Time.time); b5.GetComponentInChildren<Text>().text = "" + f;
            if (f <= 0) { Variables.isBusyBottomTable[4] = false; b5.GetComponentInChildren<Text>().text = ""; setBottomimage(b5, 4); b5.enabled = true; }
        }
        if (Variables.isBusyBottomTable[5]){ int f = Mathf.RoundToInt(bottomTableTime[5] - Time.time); b6.GetComponentInChildren<Text>().text = "" + f;
            if (f <= 0) { Variables.isBusyBottomTable[5] = false; b6.GetComponentInChildren<Text>().text = ""; setBottomimage(b6, 5); b6.enabled = true; }
        }
        }
    }
    ///////////// MAIN BUTTONS
    public void onMainTable1ButtonClick() {
        if (!Variables.isBusyMainTable[0]&&(Variables.tableFor<=Variables.mainlvlTable[0])){
            Variables.isBusyMainTable[0] = true;
            m1.enabled = false;
            mainTableTime[0] = Time.time + generateEatingTime();
            m1.image.sprite = Resources.Load<Sprite>("Tables/eating");
            backtoClient();
        }
    }
    public void onMainTable2ButtonClick(){
        if (!Variables.isBusyMainTable[1] && (Variables.tableFor <= Variables.mainlvlTable[1])){
            Variables.isBusyMainTable[1] = true;
            m2.enabled = false;
            mainTableTime[1] = Time.time + generateEatingTime();
            m2.image.sprite = Resources.Load<Sprite>("Tables/eating");
            backtoClient();
        }
    }
    public void onMainTable3ButtonClick(){
        if (!Variables.isBusyMainTable[2]&&(Variables.tableFor<=Variables.mainlvlTable[2])){
            Variables.isBusyMainTable[2] = true;
            m3.enabled = false;
            mainTableTime[2] = Time.time + generateEatingTime();
            m3.image.sprite = Resources.Load<Sprite>("Tables/eating");
            backtoClient();
        }
    }
    public void onMainTable4ButtonClick(){
        if (!Variables.isBusyMainTable[3]&&(Variables.tableFor<=Variables.mainlvlTable[3])){
            Variables.isBusyMainTable[3] = true;
            m4.enabled = false;
            mainTableTime[3] = Time.time + generateEatingTime();
            m4.image.sprite = Resources.Load<Sprite>("Tables/eating");
            backtoClient();
        }
    }
    public void onMainTable5ButtonClick(){
        if (!Variables.isBusyMainTable[4]&&(Variables.tableFor<=Variables.mainlvlTable[4])){
            Variables.isBusyMainTable[4] = true;
            m5.enabled = false;
            mainTableTime[4] = Time.time + generateEatingTime();
            m5.image.sprite = Resources.Load<Sprite>("Tables/eating");
            backtoClient();
        }
    }
    public void onMainTable6ButtonClick(){
        if (!Variables.isBusyMainTable[5]&&(Variables.tableFor<=Variables.mainlvlTable[5])){
            Variables.isBusyMainTable[5] = true;
            m6.enabled = false;
            mainTableTime[5] = Time.time + generateEatingTime();
            m6.image.sprite = Resources.Load<Sprite>("Tables/eating");
            backtoClient();
        }
    }
    ///////TOP BUTTONS
    public void onTopTable1ButtonClick(){
        if (!Variables.isBusyTopTable[0]&&(Variables.tableFor<=Variables.toplvlTable[0])){
            Variables.isBusyTopTable[0] = true;
            t1.enabled = false;
            topTableTime[0] = Time.time + generateEatingTime();
            t1.image.sprite = Resources.Load<Sprite>("Tables/eating");
            backtoClient();
        }
    }
    public void onTopTable2ButtonClick(){
        if (!Variables.isBusyTopTable[1]&& (Variables.tableFor <= Variables.toplvlTable[1])){
            Variables.isBusyTopTable[1] = true;
            t2.enabled = false;
            topTableTime[1] = Time.time + generateEatingTime();
            t2.image.sprite = Resources.Load<Sprite>("Tables/eating");
            backtoClient();
        }
    }
    public void onTopTable3ButtonClick(){
        if (!Variables.isBusyTopTable[2]&& (Variables.tableFor <= Variables.toplvlTable[2])){
            Variables.isBusyTopTable[2] = true;
            t3.enabled = false;
            topTableTime[2] = Time.time + generateEatingTime();
            t3.image.sprite = Resources.Load<Sprite>("Tables/eating");
            backtoClient();
        }
    }
    public void onTopTable4ButtonClick(){
        if (!Variables.isBusyTopTable[3]&& (Variables.tableFor <= Variables.toplvlTable[3])){
            Variables.isBusyTopTable[3] = true;
            t4.enabled = false;
            topTableTime[3] = Time.time + generateEatingTime();
            t4.image.sprite = Resources.Load<Sprite>("Tables/eating");
            backtoClient();
        }
    }
    public void onTopTable5ButtonClick(){
        if (!Variables.isBusyTopTable[4]&& (Variables.tableFor <= Variables.toplvlTable[4])){
            Variables.isBusyTopTable[4] = true;
            t5.enabled = false;
            topTableTime[4] = Time.time + generateEatingTime();
            t5.image.sprite = Resources.Load<Sprite>("Tables/eating");
            backtoClient();
        }
    }
    public void onTopTable6ButtonClick(){
        if (!Variables.isBusyTopTable[5]&& (Variables.tableFor <= Variables.toplvlTable[5])){
            Variables.isBusyTopTable[5] = true;
            t6.enabled = false;
            topTableTime[5] = Time.time + generateEatingTime();
            t6.image.sprite = Resources.Load<Sprite>("Tables/eating");
            backtoClient();
        }
    }
    ///////////BOTTOM BUTTONS
    public void onBottomTable1ButtonClick(){
        if (!Variables.isBusyBottomTable[0]&& (Variables.tableFor <= Variables.bottomlvlTable[0])){
            Variables.isBusyBottomTable[0] = true;
            b1.enabled = false;
            bottomTableTime[0] = Time.time + generateEatingTime();
            b1.image.sprite = Resources.Load<Sprite>("Tables/eating");
            backtoClient();
        }
    }
    public void onBottomTable2ButtonClick(){
        if (!Variables.isBusyBottomTable[1]&& (Variables.tableFor <= Variables.bottomlvlTable[1])){
            Variables.isBusyBottomTable[1] = true;
            b2.enabled = false;
            bottomTableTime[1] = Time.time + generateEatingTime();
            b2.image.sprite = Resources.Load<Sprite>("Tables/eating");
            backtoClient();
        }
    }
    public void onBottomTable3ButtonClick(){
        if (!Variables.isBusyBottomTable[2]&& (Variables.tableFor <= Variables.bottomlvlTable[2])){
            Variables.isBusyBottomTable[2] = true;
            b3.enabled = false;
            bottomTableTime[2] = Time.time + generateEatingTime();
            b3.image.sprite = Resources.Load<Sprite>("Tables/eating");
            backtoClient();
        }
    }
    public void onBottomTable4ButtonClick(){
        if (!Variables.isBusyBottomTable[3]&& (Variables.tableFor <= Variables.bottomlvlTable[3])){
            Variables.isBusyBottomTable[3] = true;
            b4.enabled = false;
            bottomTableTime[3] = Time.time + generateEatingTime();
            b4.image.sprite = Resources.Load<Sprite>("Tables/eating");
            backtoClient();
        }
    }
    public void onBottomTable5ButtonClick(){
        if (!Variables.isBusyBottomTable[4]&& (Variables.tableFor <= Variables.bottomlvlTable[4])){
            Variables.isBusyBottomTable[4] = true;
            b5.enabled = false;
            bottomTableTime[4] = Time.time + generateEatingTime();
            b5.image.sprite = Resources.Load<Sprite>("Tables/eating");
            backtoClient();
        }
    }
    public void onBottomTable6ButtonClick(){
        if (!Variables.isBusyBottomTable[5]&& (Variables.tableFor <= Variables.bottomlvlTable[5])){
            Variables.isBusyBottomTable[5] = true;
            b6.enabled = false;
            bottomTableTime[5] = Time.time + generateEatingTime();
            b6.image.sprite = Resources.Load<Sprite>("Tables/eating");
            backtoClient();
        }
    }

    /////// GENERATE TIME EATING!
    int generateEatingTime() {
        int time = Random.Range(0, 40) + Variables.eatingTimeDurration;
        return time;
    }
    void setimage(Button b, int i)
    {
        if (Variables.mainlvlTable[i] == 1) { b.image.sprite = Resources.Load<Sprite>("Tables/table1"); }
        if (Variables.mainlvlTable[i] == 2) { b.image.sprite = Resources.Load<Sprite>("Tables/table2"); }
        if (Variables.mainlvlTable[i] == 3) { b.image.sprite = Resources.Load<Sprite>("Tables/table3"); }
        if (Variables.mainlvlTable[i] == 4) { b.image.sprite = Resources.Load<Sprite>("Tables/table4"); }
        if (Variables.mainlvlTable[i] == 5) { b.image.sprite = Resources.Load<Sprite>("Tables/table5"); }
        if (Variables.mainlvlTable[i] == 6) { b.image.sprite = Resources.Load<Sprite>("Tables/table6"); }
    }
    void setTopimage(Button b, int i)
    {
        if (Variables.toplvlTable[i] == 1) { b.image.sprite = Resources.Load<Sprite>("Tables/table1"); }
        if (Variables.toplvlTable[i] == 2) { b.image.sprite = Resources.Load<Sprite>("Tables/table2"); }
        if (Variables.toplvlTable[i] == 3) { b.image.sprite = Resources.Load<Sprite>("Tables/table3"); }
        if (Variables.toplvlTable[i] == 4) { b.image.sprite = Resources.Load<Sprite>("Tables/table4"); }
        if (Variables.toplvlTable[i] == 5) { b.image.sprite = Resources.Load<Sprite>("Tables/table5"); }
        if (Variables.toplvlTable[i] == 6) { b.image.sprite = Resources.Load<Sprite>("Tables/table6"); }
    }
    void setBottomimage(Button b, int i)
    {
        if (Variables.bottomlvlTable[i] == 1) { b.image.sprite = Resources.Load<Sprite>("Tables/table1"); }
        if (Variables.bottomlvlTable[i] == 2) { b.image.sprite = Resources.Load<Sprite>("Tables/table2"); }
        if (Variables.bottomlvlTable[i] == 3) { b.image.sprite = Resources.Load<Sprite>("Tables/table3"); }
        if (Variables.bottomlvlTable[i] == 4) { b.image.sprite = Resources.Load<Sprite>("Tables/table4"); }
        if (Variables.bottomlvlTable[i] == 5) { b.image.sprite = Resources.Load<Sprite>("Tables/table5"); }
        if (Variables.bottomlvlTable[i] == 6) { b.image.sprite = Resources.Load<Sprite>("Tables/table6"); }
    }

    void backtoClient() {
        Variables.AmountDrink1 -= Variables.tableBill[0, 0];
        Variables.AmountDrink2 -= Variables.tableBill[0, 1];
        Variables.AmountMeal1 -= Variables.tableBill[1, 0];
        Variables.AmountMeal2 -= Variables.tableBill[1, 1];
        Variables.AmountDessert1 -= Variables.tableBill[2, 0];
        Variables.AmountDessert2 -= Variables.tableBill[2, 1];
        //dodaj pieniąszki
        Variables.Money += Variables.tableBill[0, 0] * (Variables.pDrink1 * (1 + Variables.markup));
        Variables.Money += Variables.tableBill[0, 1] * (Variables.pDrink2 * (1 + Variables.markup));
        Variables.Money += Variables.tableBill[1, 0] * (Variables.pMeal1 * (1 + Variables.markup));
        Variables.Money += Variables.tableBill[1, 1] * (Variables.pMeal2 * (1 + Variables.markup));
        Variables.Money += Variables.tableBill[2, 0] * (Variables.pDessert1 * (1 + Variables.markup));
        Variables.Money += Variables.tableBill[2, 1] * (Variables.pDessert2 * (1 + Variables.markup));

        drink1.text = Variables.AmountDrink1 + "";
        drink2.text = Variables.AmountDrink2 + "";
        meal1.text = Variables.AmountMeal1 + "";
        meal2.text = Variables.AmountMeal2 + "";
        sweet1.text = Variables.AmountDessert1 + "";
        sweet2.text = Variables.AmountDessert2 + "";

        TableLayoutObject.active = false;
        Variables.isTableLayoutActive = false;
    }

    public void onNotEnoughTableClick() {
        TableLayoutObject.active = false;
        Variables.isTableLayoutActive = false;
    }
}
