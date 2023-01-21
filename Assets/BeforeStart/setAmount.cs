using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setAmount : MonoBehaviour
{

    string m = "x", waluta = "zł";
    static int z = 100;
    int d1 = z, d2 = z, m1 = z, m2 = z, s1 = z, s2 = z;
    //double cena1 = Variables.cena1;
    public Text multiplierd1, priced1,
                multiplierd2, priced2,
                multiplierm1, pricem1,
                multiplierm2, pricem2,
                multipliers1, prices1,
                multipliers2, prices2;
    private void Start()
    {
        ChangeMultiplerDrink1();
        ChangeMultiplerDrink2();
        ChangeMultiplerMeal1();
        ChangeMultiplerMeal2();
        ChangeMultiplerDessert1();
        ChangeMultiplerDessert2();

    }

    public void ChangeMultiplerDrink1()
    {
        switch (d1)
        {
            case 10:
                d1 = 25; multiplierd1.text = m + d1;
                break;
            case 25:
                d1 = 50; multiplierd1.text = m + d1;
                break;
            case 50:
                d1 = 100; multiplierd1.text = m + d1;
                break;
            case 100:
                d1 = 10; multiplierd1.text = m + d1;
                break;
        }
        priced1.text = (d1 * Variables.pDrink1) + waluta;
        Variables.Multiplierd1 = d1;
    }

    public void ChangeMultiplerDrink2()
    {
        switch (d2)
        {
            case 10:
                d2 = 25; multiplierd2.text = m + d2;
                break;
            case 25:
                d2 = 50; multiplierd2.text = m + d2;
                break;
            case 50:
                d2 = 100; multiplierd2.text = m + d2;
                break;
            case 100:
                d2 = 10; multiplierd2.text = m + d2;
                break;
        }
        priced2.text = (d2 * Variables.pDrink2) + waluta;
        Variables.Multiplierd2 = d2;
    }

    public void ChangeMultiplerMeal1()
    {
        switch (m1)
        {
            case 10:
                m1 = 25; multiplierm1.text = m + m1;
                break;
            case 25:
                m1 = 50; multiplierm1.text = m + m1;
                break;
            case 50:
                m1 = 100; multiplierm1.text = m + m1;
                break;
            case 100:
                m1 = 10; multiplierm1.text = m + m1;
                break;
        }
        pricem1.text = (m1 * Variables.pMeal1) + waluta;
        Variables.Multiplierm1 = m1;
    }

    public void ChangeMultiplerMeal2()
    {
        switch (m2)
        {
            case 10:
                m2 = 25; multiplierm2.text = m + m2;
                break;
            case 25:
                m2 = 50; multiplierm2.text = m + m2;
                break;
            case 50:
                m2 = 100; multiplierm2.text = m + m2;
                break;
            case 100:
                m2 = 10; multiplierm2.text = m + m2;
                break;
        }
        pricem2.text = (m2 * Variables.pMeal2) + waluta;
        Variables.Multiplierm2 = m2;
    }

    public void ChangeMultiplerDessert1()
    {
        switch (s1)
        {
            case 10:
                s1 = 25; multipliers1.text = m + s1;
                break;
            case 25:
                s1 = 50; multipliers1.text = m + s1;
                break;
            case 50:
                s1 = 100; multipliers1.text = m + s1;
                break;
            case 100:
                s1 = 10; multipliers1.text = m + s1;
                break;
        }
        prices1.text = (s1 * Variables.pDessert1) + waluta;
        Variables.Multipliers1 = s1;
    }

    public void ChangeMultiplerDessert2()
    {
        switch (s2)
        {
            case 10:
                s2 = 25; multipliers2.text = m + s2;
                break;
            case 25:
                s2 = 50; multipliers2.text = m + s2;
                break;
            case 50:
                s2 = 100; multipliers2.text = m + s2;
                break;
            case 100:
                s2 = 10; multipliers2.text = m + s2;
                break;
        }
        prices2.text = (s2 * Variables.pDessert2) + waluta;
        Variables.Multipliers2 = s2;
    }
}