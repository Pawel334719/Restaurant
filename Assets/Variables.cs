using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour {

    public static float Money;

    public static float
        pDrink1 = 0.80f, pDrink2 = 0.50f,//piwo, sok
        pMeal1 = 3.50f, pMeal2 = 2.00f,//schab, pierogi
        pDessert1 = 1.50f, pDessert2 = 1.15f;//lody, ciasto
    //Ilość danego towaru do sprzedarzy
    public static int
        AmountDrink1, AmountDrink2,
        AmountMeal1, AmountMeal2,
        AmountDessert1, AmountDessert2;

    //tylko do ilości scena: beforestartgame
    public static int
        Multiplierd1, Multiplierd2,
        Multiplierm1, Multiplierm2,
        Multipliers1, Multipliers2;
    //Gameplay 
    public static int[,] Bill=new int [3,2],tableBill=new int[3,2];
    public static int[,] ClientOrder = new int[3, 2];
    public static int Queue, maxTableFor;
    public static bool customerAtCheckout;

    public static float markup = 0.50f;

    public static bool topTableEnabled, bottomTableEnabled, isTableLayoutActive=false;
    public static int[] mainlvlTable = new int[6], toplvlTable = new int[6], bottomlvlTable = new int[6];
    public static bool[] isBusyMainTable = new bool[6], isBusyTopTable = new bool[6], isBusyBottomTable = new bool[6];
    public static int tableFor;

    //shop
    public static int[] stufflvlShop = new int[4];
    public static float foodSurvive;
    public static int eatingTimeDurration;

    public static int Day;


}
