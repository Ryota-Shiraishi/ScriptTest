using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    //BOSSクラスの宣言
    public class Boss
    {
        private int hp = 100; // 体力
        private int power = 25; // 攻撃力
        private int mp = 53; // MP

        // 攻撃用の関数
        public void Attack()
        {
            Debug.Log(this.power + "のダメージを与えた");
        }

        // 防御用の関数
        public void Defence(int damage)
        {
            Debug.Log(damage + "のダメージを受けた");
            // 残りhpを減らす
            this.hp -= damage;
            // 残りhpを確認する
            if (this.hp <= 0)
            {
                Debug.Log("体力がなくなった。");
            }
        }

        // 魔法攻撃用の関数
        public void Magic()
        {
            if (this.mp>5)
            {
                //残りmpを減らす
                this.mp -= 5;
                Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
            }
            else
            {
                Debug.Log("MPが足りないため魔法が使えない。");
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        //課題_配列
        int[] array = { 1, 2, 3, 4, 5 };

        Debug.Log("配列を昇順で出力");
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log("昇順：" + array[i]);
        }
        Debug.Log("配列を降順で出力");
        for (int i = array.Length-1; i > -1; i--)
        {
            Debug.Log("降順：" + array[i]);
        }

        //発展課題
        Debug.Log("BOSSクラスの練習");
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss midboss = new Boss();

        // 攻撃用の関数を呼び出す
        midboss.Attack();
        // 魔法攻撃用の関数を10回呼び出す
        for (int i = 0; i < 10; i++)
        {
            midboss.Magic();
            midboss.Defence(9);
        }
        // 魔法攻撃用の関数を呼び出す
        midboss.Magic();
        // 防御用の関数を呼び出す
        midboss.Defence(10);
    }
    // Update is called once per frame
    void Update()
    {
    }
}
