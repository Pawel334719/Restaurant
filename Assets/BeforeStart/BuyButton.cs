using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyButton : MonoBehaviour {

    public Text Money, CurrentAmountd1, CurrentAmountd2, CurrentAmountm1, CurrentAmountm2, CurrentAmounts1, CurrentAmounts2;
    float money;

    void Start()
    {
        money = Variables.Money;
    }
    public void buyButtond1() {
        float x = Variables.Multiplierd1*Variables.pDrink1;
        if (x <= money)
        {
            Variables.Money -= x;
            money = Variables.Money;
            Variables.AmountDrink1 += Variables.Multiplierd1;
            CurrentAmountd1.text = "" + Variables.AmountDrink1;
            Money.text = "" + Variables.Money;
        }
        else {
            notEnoughMoney();
        }
    }
    public void buyButtond2()
    {
        float x = Variables.Multiplierd2 * Variables.pDrink2;
        if (x <= money)
        {
            Variables.Money -= x;
            money = Variables.Money;
            Variables.AmountDrink2 += Variables.Multiplierd2;
            CurrentAmountd2.text = "" + Variables.AmountDrink2;
            Money.text = "" + Variables.Money;
        }
        else
        {
            notEnoughMoney();
        }
    }
    public void buyButtonm1()
    {
        float x = Variables.Multiplierm1 * Variables.pMeal1;
        if (x <= money)
        {
            Variables.Money -= x;
            money = Variables.Money;
            Variables.AmountMeal1 += Variables.Multiplierm1;
            CurrentAmountm1.text = "" + Variables.AmountMeal1;
            Money.text = "" + Variables.Money;
        }
        else
        {
            notEnoughMoney();
        }
    }


    public void buyButtonm2()
    {
        float x = Variables.Multiplierm2 * Variables.pMeal2;
        if (x <= money)
        {
            Variables.Money -= x;
            money = Variables.Money;
            Variables.AmountMeal2 += Variables.Multiplierm2;
            CurrentAmountm2.text = "" + Variables.AmountMeal2;
            Money.text = "" + Variables.Money;
        }
        else
        {
            notEnoughMoney();
        }
    }

    public void buyButtons1()
    {
        float x = Variables.Multipliers1 * Variables.pDessert1;
        if (x <= money)
        {
            Variables.Money -= x;
            money = Variables.Money;
            Variables.AmountDessert1 += Variables.Multipliers1;
            CurrentAmounts1.text = "" + Variables.AmountDessert1;
            Money.text = "" + Variables.Money;
        }
        else
        {
            notEnoughMoney();
        }
    }

    public void buyButtons2()
    {
        float x = Variables.Multipliers2 * Variables.pDessert2;
        if (x <= money)
        {
            Variables.Money -= x;
            money = Variables.Money;
            Variables.AmountDessert2 += Variables.Multipliers2;
            CurrentAmounts2.text = "" + Variables.AmountDessert2;
            Money.text = "" + Variables.Money;
        }
        else
        {
            notEnoughMoney();
        }
    }



    void notEnoughMoney() {



    }
}
