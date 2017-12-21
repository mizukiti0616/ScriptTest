using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int mp = 53;
    private int power = 5;

    // 攻撃用の関数
    public void Magic()
    {
        Debug.Log("魔法攻撃をした。" + "残りMPは" + this.mp);

        this.mp -= power;
        if(mp < 3)
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }

    // 防御用の関数
 

}

public class Test : MonoBehaviour
{
    void Start()
    {
        Boss lastboss = new Boss();

        for (int Magic = 1; Magic <= 10; Magic++)
        {
            lastboss.Magic();
        }


        lastboss.Magic();

        int[] points = new int[5];

       
        points[0] = 30;
        points[1] = 20;
        points[2] = 50;
        points[3] = 10;
        points[4] = 80;

        for (int i = 0; i < 5; i++)
        {
            Debug.Log(points[i]);
        }




        for (int i = 5-1; i >= 0; i--)
        {

            Debug.Log(points[i]);


        }
        
    }
	// Update is called once per frame
	void Update () {
		
	}
}
