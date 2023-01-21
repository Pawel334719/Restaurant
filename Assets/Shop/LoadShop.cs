using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadShop : MonoBehaviour {

    public Button m1, m2, m3, m4, m5, m6,
                  b1, b2, b3, b4, b5, b6,
                  t1, t2, t3, t4, t5, t6;
    public GameObject top, bottom;
    public Text moneytv;
    // Use this for initialization
    void Start () {
        Tables();
        setLanguage();
    }
    void Update() {
        moneytv.text = Variables.Money + "";
    }

    public void Tables()
    {
        setimage(m1, 0);
        setimage(m2, 1);
        setimage(m3, 2);
        setimage(m4, 3);
        setimage(m5, 4);
        setimage(m6, 5);

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
    void setimage(Button b, int i)
    {
        if (Variables.mainlvlTable[i] == 0) { b.image.sprite = Resources.Load<Sprite>("Tables/table0shop"); }
        if (Variables.mainlvlTable[i] == 1) { b.image.sprite = Resources.Load<Sprite>("Tables/table1"); }
        if (Variables.mainlvlTable[i] == 2) { b.image.sprite = Resources.Load<Sprite>("Tables/table2"); }
        if (Variables.mainlvlTable[i] == 3) { b.image.sprite = Resources.Load<Sprite>("Tables/table3"); }
        if (Variables.mainlvlTable[i] == 4) { b.image.sprite = Resources.Load<Sprite>("Tables/table4"); }
        if (Variables.mainlvlTable[i] == 5) { b.image.sprite = Resources.Load<Sprite>("Tables/table5"); }
        if (Variables.mainlvlTable[i] == 6) { b.image.sprite = Resources.Load<Sprite>("Tables/table6"); }
    }
    void setTopimage(Button b, int i)
    {
        if (Variables.toplvlTable[i] == 0) { b.image.sprite = Resources.Load<Sprite>("Tables/table0shop");}
        if (Variables.toplvlTable[i] == 1) { b.image.sprite = Resources.Load<Sprite>("Tables/table1"); }
        if (Variables.toplvlTable[i] == 2) { b.image.sprite = Resources.Load<Sprite>("Tables/table2"); }
        if (Variables.toplvlTable[i] == 3) { b.image.sprite = Resources.Load<Sprite>("Tables/table3"); }
        if (Variables.toplvlTable[i] == 4) { b.image.sprite = Resources.Load<Sprite>("Tables/table4"); }
        if (Variables.toplvlTable[i] == 5) { b.image.sprite = Resources.Load<Sprite>("Tables/table5"); }
        if (Variables.toplvlTable[i] == 6) { b.image.sprite = Resources.Load<Sprite>("Tables/table6"); }
    }
    void setBottomimage(Button b, int i)
    {
        if (Variables.bottomlvlTable[i] == 0) { b.image.sprite = Resources.Load<Sprite>("Tables/table0shop"); }
        if (Variables.bottomlvlTable[i] == 1) { b.image.sprite = Resources.Load<Sprite>("Tables/table1"); }
        if (Variables.bottomlvlTable[i] == 2) { b.image.sprite = Resources.Load<Sprite>("Tables/table2"); }
        if (Variables.bottomlvlTable[i] == 3) { b.image.sprite = Resources.Load<Sprite>("Tables/table3"); }
        if (Variables.bottomlvlTable[i] == 4) { b.image.sprite = Resources.Load<Sprite>("Tables/table4"); }
        if (Variables.bottomlvlTable[i] == 5) { b.image.sprite = Resources.Load<Sprite>("Tables/table5"); }
        if (Variables.bottomlvlTable[i] == 6) { b.image.sprite = Resources.Load<Sprite>("Tables/table6"); }
    }
    public Text yesBustertv, yesTabletv, noBustertv, noTabletv, topSpaceButtontv, bottomSpaceButtontv, backtoBusterButtontv,backtoMenuButtontv;
    void setLanguage() {
        yesBustertv.text =Translator.buyString;
        yesTabletv.text = Translator.buyString;
        noBustertv.text = Translator.backString;
        noTabletv.text = Translator.backString;
        topSpaceButtontv.text = Translator.morespaceShop;
        bottomSpaceButtontv.text = Translator.morespaceShop;
        backtoBusterButtontv.text = Translator.backString;
        backtoMenuButtontv.text= Translator.backtoMenuShop;

    }
}
