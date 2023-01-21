using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class CreatingClients : MonoBehaviour
{

    int kindsOfDrink = 2, kindsOfMeal = 2, kindsOfDessert = 2;
    float startTime, GameplayTime = 5*60 , EndGameTime,enterAnimTime,exitAnimTime;
    float toNewClientTime;
    public Text ordertv, Bill, d1, d2, m1, m2, s1, s2, dayProgrestv,infoend;
    public Animator Image1A, Image2A, Image3A, Image4A, Image5A, Image6A,
                    Image1B, Image2B, Image3B, Image4B, Image5B, Image6B;
    public Image img1A, img2A, img3A, img4A, img5A, img6A,
                 img1B, img2B, img3B, img4B, img5B, img6B;
    public Button Done;
    public GameObject ByeButtonObject,TableLayoutObject,ClientLayoutObject,EndGameLayout;
    public GameObject AmountOfFood,TypeOfFood;
    bool enterBool = false, exitBool = false, shouldBeA = true,endStuffDone=false;
    int tableFor = 0;
    bool youCanEatHere = true;
    // Use this for initialization
    void Start()
    {
        startTime = Time.time;
        EndGameTime = startTime + GameplayTime;
        toNewClientTime = 2 + startTime;
        Done.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time < EndGameTime){
            if (Time.time > toNewClientTime){
                //wygeneruj klienta
                Variables.Queue++;
                if (Variables.Queue == 1) { animCoordinator(false); }

                //+czas do nowegop klienta
                toNewClientTime += Random.Range(10, 20);
            }
            
            dayProgrestv.text = Mathf.RoundToInt(100-(((EndGameTime-Time.time)/GameplayTime)*100))+"%";
        }
        else
        {
            if (!endStuffDone) {
                endStuffDone = true;
                EndGameLayout.active = true;
                infoend.text = "Koniec " + Variables.Day + " dnia";
                Variables.Day++;
                PlayerPrefs.SetInt("Day", Variables.Day);
                Variables.Money += 0.00f;
                PlayerPrefs.SetFloat("Money", Variables.Money);
                
                PlayerPrefs.SetInt("AmountDrink1", Mathf.RoundToInt(Variables.AmountDrink1*Variables.foodSurvive));
                PlayerPrefs.SetInt("AmountDrink2", Mathf.RoundToInt(Variables.AmountDrink2 * Variables.foodSurvive));
                PlayerPrefs.SetInt("AmountMeal1", Mathf.RoundToInt(Variables.AmountMeal1 * Variables.foodSurvive));
                PlayerPrefs.SetInt("AmountMeal2", Mathf.RoundToInt(Variables.AmountMeal2 * Variables.foodSurvive));
                PlayerPrefs.SetInt("AmountDessert1", Mathf.RoundToInt(Variables.AmountDessert1 * Variables.foodSurvive));
                PlayerPrefs.SetInt("AmountDessert2", Mathf.RoundToInt(Variables.AmountDessert2 * Variables.foodSurvive));
                
            }
        }
        if (enterBool){
            if (Time.time >= enterAnimTime) { Done.interactable = true; interpretTabel();  enterBool = false; }
        }
        if (exitBool){
            if (Time.time >= exitAnimTime) {
                if (!shouldBeA){
                    img1A.sprite = Resources.Load<Sprite>("ClientsImage/Client00");
                    img2A.sprite = Resources.Load<Sprite>("ClientsImage/Client00");
                    img3A.sprite = Resources.Load<Sprite>("ClientsImage/Client00");
                    img4A.sprite = Resources.Load<Sprite>("ClientsImage/Client00");
                    img5A.sprite = Resources.Load<Sprite>("ClientsImage/Client00");
                    img6A.sprite = Resources.Load<Sprite>("ClientsImage/Client00");
                }
                else {
                    img1B.sprite = Resources.Load<Sprite>("ClientsImage/Client00");
                    img2B.sprite = Resources.Load<Sprite>("ClientsImage/Client00");
                    img3B.sprite = Resources.Load<Sprite>("ClientsImage/Client00");
                    img4B.sprite = Resources.Load<Sprite>("ClientsImage/Client00");
                    img5B.sprite = Resources.Load<Sprite>("ClientsImage/Client00");
                    img6B.sprite = Resources.Load<Sprite>("ClientsImage/Client00");
                }
                exitBool = false; }
        }


    }


    public void newClient()
    {
            tableFor = Random.Range(1, Variables.maxTableFor + 1);
            int i = Random.Range(1, 3) + 1;
            if (i == 1)
            {// picie + deser
                Drink(tableFor);
                Dessert(tableFor);
            }
            else if (i == 2)
            {
                Drink(tableFor);
                Meal(tableFor);
                Dessert(tableFor);
            }
            else
            {
                Meal(tableFor);
                Dessert(tableFor);
            }
        //wyswietlić klienta
        //if (Variables.Queue == 1) { Image1.SetBool("Client1", true); }
        if (shouldBeA)
        {
            img1A.sprite = Resources.Load<Sprite>(RandomClientImage());
            if (tableFor >= 2) { img2A.sprite = Resources.Load<Sprite>(RandomClientImage()); } else { img2A.sprite = Resources.Load<Sprite>("ClientsImage/Client00"); }
            if (tableFor >= 3) { img3A.sprite = Resources.Load<Sprite>(RandomClientImage()); } else { img3A.sprite = Resources.Load<Sprite>("ClientsImage/Client00"); }
            if (tableFor >= 4) { img4A.sprite = Resources.Load<Sprite>(RandomClientImage()); } else { img4A.sprite = Resources.Load<Sprite>("ClientsImage/Client00"); }
            if (tableFor >= 5) { img5A.sprite = Resources.Load<Sprite>(RandomClientImage()); } else { img5A.sprite = Resources.Load<Sprite>("ClientsImage/Client00"); }
            if (tableFor >= 6) { img6A.sprite = Resources.Load<Sprite>(RandomClientImage()); } else { img6A.sprite = Resources.Load<Sprite>("ClientsImage/Client00"); }
        }
        else {
            img1B.sprite = Resources.Load<Sprite>(RandomClientImage());
            if (tableFor >= 2) { img2B.sprite = Resources.Load<Sprite>(RandomClientImage()); } else { img2B.sprite = Resources.Load<Sprite>("ClientsImage/Client00"); }
            if (tableFor >= 3) { img3B.sprite = Resources.Load<Sprite>(RandomClientImage()); } else { img3B.sprite = Resources.Load<Sprite>("ClientsImage/Client00"); }
            if (tableFor >= 4) { img4B.sprite = Resources.Load<Sprite>(RandomClientImage()); } else { img4B.sprite = Resources.Load<Sprite>("ClientsImage/Client00"); }
            if (tableFor >= 5) { img5B.sprite = Resources.Load<Sprite>(RandomClientImage()); } else { img5B.sprite = Resources.Load<Sprite>("ClientsImage/Client00"); }
            if (tableFor >= 6) { img6B.sprite = Resources.Load<Sprite>(RandomClientImage()); } else { img6B.sprite = Resources.Load<Sprite>("ClientsImage/Client00"); }
        }
            
    }
    string RandomClientImage() {
        int i = Random.Range(1, 5);
        string s="";
        if (i == 1) s = "ClientsImage/Client01";
        if (i == 2) s = "ClientsImage/Client02";
        if (i == 3) s = "ClientsImage/Client03";
        if (i == 4) s = "ClientsImage/Client04";
        return s;
    }
    void Drink(int tableFor)
    {
        int i, z = 1, x = 0;
        switch (tableFor)
        {
            case 1:
                i = Random.Range(0, kindsOfDrink);
                Variables.ClientOrder[x, i] = 1;
                break;
            case 2:
                while (z <= tableFor)
                {
                    i = Random.Range(0, kindsOfDrink);
                    Variables.ClientOrder[x, i]++;
                    z++;
                }
                break;
            case 3:
                while (z <= tableFor)
                {
                    i = Random.Range(0, kindsOfDrink);
                    Variables.ClientOrder[x, i]++;
                    z++;
                }
                break;
            case 4:
                while (z <= tableFor)
                {
                    i = Random.Range(0, kindsOfDrink);
                    Variables.ClientOrder[x, i]++;
                    z++;
                }
                break;

        }
    }
    void Meal(int tableFor)
    {
        int i, z = 1, x = 1;
        switch (tableFor)
        {
            case 1:
                i = Random.Range(0, kindsOfDrink);
                Variables.ClientOrder[x, i] = 1;
                break;
            case 2:
                while (z <= tableFor)
                {
                    i = Random.Range(0, kindsOfDrink);
                    Variables.ClientOrder[x, i]++;
                    z++;
                }
                break;
            case 3:
                while (z <= tableFor)
                {
                    i = Random.Range(0, kindsOfDrink);
                    Variables.ClientOrder[x, i]++;
                    z++;
                }
                break;
            case 4:
                while (z <= tableFor)
                {
                    i = Random.Range(0, kindsOfDrink);
                    Variables.ClientOrder[x, i]++;
                    z++;
                }
                break;

        }

    }
    void Dessert(int tableFor)
    {
        int i, z = 1, x = 2;
        switch (tableFor)
        {
            case 1:
                i = Random.Range(0, kindsOfDrink);
                Variables.ClientOrder[x, i] = 1;
                break;
            case 2:
                while (z <= tableFor)
                {
                    i = Random.Range(0, kindsOfDrink);
                    Variables.ClientOrder[x, i]++;
                    z++;
                }
                break;
            case 3:
                while (z <= tableFor)
                {
                    i = Random.Range(0, kindsOfDrink);
                    Variables.ClientOrder[x, i]++;
                    z++;
                }
                break;
            case 4:
                while (z <= tableFor)
                {
                    i = Random.Range(0, kindsOfDrink);
                    Variables.ClientOrder[x, i]++;
                    z++;
                }
                break;

        }
    }

    void interpretTabel()
    {
        string order = null;
        string d1Name = Translator.d1NameG, d2Name = Translator.d2NameG, m1Name = Translator.m1NameG, m2Name = Translator.m2NameG, s1Name = Translator.s1NameG, s2Name = Translator.s2NameG;
        string glass = Translator.glassG, glasses = Translator.glassesG, serving = Translator.servingG, servings = Translator.servingsG, piece = Translator.pieceG, pieces = Translator.piecesG;
        int i = Random.Range(1, 5), x, y;
        if (i == 1) { order = Translator.orderG1; }
        if (i == 2) { order = Translator.orderG2; }
        if (i == 3) { order = Translator.orderG3; }
        if (i == 4) { order = Translator.orderG4; }

        int a = howManyTypesOfFood();

        bool change = false;
        //drinks
        x = 0; y = 0; if (Variables.ClientOrder[x, y] != 0) { if (Variables.ClientOrder[x, y] == 1) order += glass + d1Name; else { order += number(Variables.ClientOrder[x, y]) + glasses + d1Name; } change = true; a--; }
        if (change) { change = false; if (a == 1) { order +=Translator.andG; } else order += ","; }
        x = 0; y = 1; if (Variables.ClientOrder[x, y] != 0) { if (Variables.ClientOrder[x, y] == 1) order += glass + d2Name; else { order += number(Variables.ClientOrder[x, y]) + glasses + d2Name; } change = true; a--; }
        if (change) { change = false; if (a == 1) { order += Translator.andG; } else order += ","; }
        //meal
        x = 1; y = 0; if (Variables.ClientOrder[x, y] != 0) { if (Variables.ClientOrder[x, y] == 1) order += serving + m1Name; else { order += number(Variables.ClientOrder[x, y]) + servings + m1Name; } change = true; a--; }
        if (change) { change = false; if (a == 1) { order += Translator.andG; } else if (a == 0) { order += "."; } else order += ","; }
        x = 1; y = 1; if (Variables.ClientOrder[x, y] != 0) { if (Variables.ClientOrder[x, y] == 1) order += serving + m2Name; else { order += number(Variables.ClientOrder[x, y]) + servings + m2Name; } change = true; a--; }
        if (change) { change = false; if (a == 1) { order += Translator.andG; } else if (a == 0) { order += "."; } else order += ","; }
        //dessert
        x = 2; y = 0; if (Variables.ClientOrder[x, y] != 0) { if (Variables.ClientOrder[x, y] == 1) order += serving + s1Name; else { order += number(Variables.ClientOrder[x, y]) + servings + s1Name; } change = true; a--; }
        if (change) { change = false; if (a == 1) { order += Translator.andG; } else if (a == 0) { order += "."; } else order += ","; }
        x = 2; y = 1; if (Variables.ClientOrder[x, y] != 0) { if (Variables.ClientOrder[x, y] == 1) order += piece + s2Name; else { order += number(Variables.ClientOrder[x, y]) + pieces + s2Name; } change = true; a--; }
        if (change) { change = false; if (a == 1) { order += Translator.andG; } else if (a == 0) { order += "."; } else order += ","; }
        order+= Translator.pleaseG;
        ordertv.text = order;

        //sprawdzić czy stoliki są dostępne
        //sprawdzić czy jest jedzenie które chce zjeść 
        youCanEatHere = true;
        if (Variables.AmountDrink1 < Variables.ClientOrder[0, 0]) youCanEatHere = false;
        if (Variables.AmountDrink2 < Variables.ClientOrder[0, 1]) youCanEatHere = false;
        if (Variables.AmountMeal1 < Variables.ClientOrder[1, 0]) youCanEatHere = false;
        if (Variables.AmountMeal2 < Variables.ClientOrder[1, 1]) youCanEatHere = false;
        if (Variables.AmountDessert1 < Variables.ClientOrder[2, 0]) youCanEatHere = false;
        if (Variables.AmountDessert2 < Variables.ClientOrder[2, 1]) youCanEatHere = false;
        if (!youCanEatHere) { Done.interactable = false; ByeButtonObject.active = true; }
    }
    string number(int i)
    {
        string s = null;
        if (i == 2) s = Translator.twoG;
        if (i == 3) s = Translator.threeG;
        if (i == 4) s = Translator.fourG;
        if (i == 5) s = Translator.fiveG;
        if (i == 6) s = Translator.sixG;
        if (i == 7) s = Translator.sevenG;
        if (i == 8) s = Translator.eightG;
        if (i == 9) s = Translator.nineG;

        return s;
    }
    int howManyTypesOfFood()
    {
        int x = 0, i = 0;
        while (x < 3)
        {
            int y = 0;
            while (y < 2)
            {
                if (Variables.ClientOrder[x, y] != 0) i++;
                y++;
            }
            x++;
        }
        return i;
    }

    public void checkOrder()
    {
        float markup = Variables.markup;
        bool corect = true;
        int x = 0;
        while (x < 3)
        {
            int y = 0;
            while (y < 2)
            {
                if (Variables.Bill[x, y] != Variables.ClientOrder[x, y]) corect = false;
                y++;
            }
            x++;
        }
        if (corect){
        x = 0;
        while (x < 3){
            int y = 0;
            while (y < 2){
               Variables.tableBill[x, y]= Variables.Bill[x, y];
                y++;
            }
            x++;
        }
            Variables.tableFor = tableFor;
            Variables.isTableLayoutActive = true;
            TableLayoutObject.active = true;
            ordertv.text = Translator.myOrder;
        }
        else{
            ordertv.text = Translator.notmyOrderG;
        }
        

        x = 0;
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
        Variables.Queue--;
        // wyzeruj rachunek
        Bill.text = null;

        
        


        Variables.customerAtCheckout = false;
        animCoordinator(true);
        Done.interactable = false;
        AmountOfFood.active = false;
        TypeOfFood.active = true;

    }

    void animCoordinator(bool isitButton)
    {
       if (isitButton) {
            if (shouldBeA)
            {
                Image1A.SetBool("enter1", false); Image1A.SetBool("exit1", true);
                Image2A.SetBool("enter2", false); Image2A.SetBool("exit2", true);
                Image3A.SetBool("enter3", false); Image3A.SetBool("exit3", true);
                Image4A.SetBool("enter4", false); Image4A.SetBool("exit4", true);
                Image5A.SetBool("enter5", false); Image5A.SetBool("exit5", true);
                Image6A.SetBool("enter6", false); Image6A.SetBool("exit6", true);
            }
            else
            {
                Image1B.SetBool("enter1", false); Image1B.SetBool("exit1", true);
                Image2B.SetBool("enter2", false); Image2B.SetBool("exit2", true);
                Image3B.SetBool("enter3", false); Image3B.SetBool("exit3", true);
                Image4B.SetBool("enter4", false); Image4B.SetBool("exit4", true);
                Image5B.SetBool("enter5", false); Image5B.SetBool("exit5", true);
                Image6B.SetBool("enter6", false); Image6B.SetBool("exit6", true);
            }
            exitAnimTime = Time.time + 2.65f;exitBool = true;
        }
        if (shouldBeA) shouldBeA = false; else shouldBeA = true;
        if ((!isitButton)||(Variables.Queue>=1)) {
            newClient();
            if (shouldBeA){
                Image1A.SetBool("exit1", false); Image1A.SetBool("enter1", true);
                Image2A.SetBool("exit2", false); Image2A.SetBool("enter2", true);
                Image3A.SetBool("exit3", false); Image3A.SetBool("enter3", true);
                Image4A.SetBool("exit4", false); Image4A.SetBool("enter4", true);
                Image5A.SetBool("exit5", false); Image5A.SetBool("enter5", true);
                Image6A.SetBool("exit6", false); Image6A.SetBool("enter6", true);
            }
            else{
                Image1B.SetBool("exit1", false); Image1B.SetBool("enter1", true);
                Image2B.SetBool("exit2", false); Image2B.SetBool("enter2", true);
                Image3B.SetBool("exit3", false); Image3B.SetBool("enter3", true);
                Image4B.SetBool("exit4", false); Image4B.SetBool("enter4", true);
                Image5B.SetBool("exit5", false); Image5B.SetBool("enter5", true);
                Image6B.SetBool("exit6", false); Image6B.SetBool("enter6", true);
            }
            enterAnimTime = Time.time + 3;enterBool = true;
        }
    }


    public void onByeButtonClickFunctiion()
    {
        Variables.Queue--;
        Done.interactable = true;
        ByeButtonObject.active = false;
        animCoordinator(true);
        ordertv.text = Translator.notenoughforOrderG;
    }

    public void onOKClick() {
        SceneManager.LoadScene("Menu");
    }
}
