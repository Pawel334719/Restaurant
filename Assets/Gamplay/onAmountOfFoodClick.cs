using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onAmountOfFoodClick : MonoBehaviour {
    public GameObject AmountOfFood, TypeOfFood;
    public Text BillText;
    int X = 33;
    string MULTIPLER = "x";
    public void onButton1Click(){
        recognize(1);
        change();
    }
    public void onButton2Click()
    {
        recognize(2);
        change();
    }
    public void onButton3Click()
    {
        recognize(3);
        change();
    }
    public void onButton4Click()
    {
        recognize(4);
        change();
    }
    public void onButton5Click()
    {
        recognize(5);
        change();
    }
    public void onButton6Click()
    {
        recognize(6);
        change();
    }
    public void onButton7Click()
    {
        recognize(7);
        change();
    }
    public void onButton8Click()
    {
        recognize(8);
        change();
    }
    public void onButton9Click()
    {
        recognize(9);
        change();
    }

    void recognize(int Amount) {
        int x = 0;
        while(x < 3){
            int y = 0;
            while (y < 2)
            {
                if (Variables.Bill[x, y] == X)
                {
                    Variables.Bill[x, y] = Amount;
                    if ((x == 0) && (y == 0)) { BillText.text += Amount+MULTIPLER+Translator.d1BillG+"\n"; }
                    if ((x == 0) && (y == 1)) { BillText.text += Amount + MULTIPLER + Translator.d2BillG + "\n"; }
                    if ((x == 1) && (y == 0)) { BillText.text += Amount + MULTIPLER + Translator.m1BillG + "\n"; }
                    if ((x == 1) && (y == 1)) { BillText.text += Amount + MULTIPLER + Translator.m2BillG + "\n"; }
                    if ((x == 2) && (y == 0)) { BillText.text += Amount + MULTIPLER + Translator.s1BillG + "\n"; }
                    if ((x == 2) && (y == 1)) { BillText.text += Amount + MULTIPLER + Translator.s2BillG + "\n"; }

                }
                y++;
            }
            x++;
        }

    }

    void change(){
        AmountOfFood.active = false;
        TypeOfFood.active = true;
    }
}
