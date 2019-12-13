using UnityEngine;//UnityEngine.Random

public class Zomble : MonoBehaviour
{
    [Header("血量")]
    public float Hp = 50;
    [Header("攻擊")]
    public float Atk = 0;
    [Header("玩家")]
    public Player Player;
    [Header("喇叭")]
    public AudioSource Aud;
    [Header("音效")]
    public AudioClip SoundAtk;

    private void A()  //攻擊
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            Aud.PlayOneShot(SoundAtk, 1f);
            Atk = UnityEngine.Random.Range(0f, 40f);
            if (Player.Hp >= Atk)
            {
                Hurt();
            }
            else
            {
                Dead();
            }
        }
    }

    
    public void Hurt()  //受傷
    {
        Player.Hp = Player.Hp - Atk;
        print("<color=blue>玩家受到傷害:" + Atk+"</color>");
        //print("<color=#FF0000FF>"+"玩家受到傷害:" + Atk + "</color>");
         
        print("<color=blue>玩家剩下血量:" + Player.Hp + "</color>");
    }   
      public void Dead()  //死亡
    {/*
        <color =#123456FF></color>
         
         RGBA = FF FF FF FF
         R = red 
         G = green
         B = blue 
         A = alpha
         */




        Player.Hp = Player.Hp - Atk;
        print("<color=blue>玩家受到傷害:" + Atk + "</color>");
        print("<color=blue>玩家剩下血量:" + Player.Hp + "</color>");
        print("<color=blue>玩家死亡" + "</color>");
    }


    private void FixedUpdate()
    {
        A();
    }
}
