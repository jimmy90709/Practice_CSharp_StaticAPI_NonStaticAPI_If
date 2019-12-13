using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("血量")]
    public float Hp = 100;
    [Header("攻擊")]
    public float Atk = 0;
    [Header("殭屍")]
    public Zomble Zb;
    [Header("喇叭")]
    public AudioSource Aud;
    [Header("音效")]
    public AudioClip SoundAtk;

    public void A()  //攻擊
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Aud.PlayOneShot(SoundAtk, 1f);
            Atk = Random.Range(0f, 40f);
            if(Zb.Hp >= Atk)
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

        Zb.Hp = Zb.Hp - Atk;
        print("<color=red>殭屍受到傷害:" + Atk + "</color>");
        print("<color=red>殭屍剩下血量:" + Zb.Hp + "</color>");
    }

    public void Dead()  //死亡
    {
        Zb.Hp = Zb.Hp - Atk;
        print("<color=red>殭屍受到傷害:" + Atk.ToString("F2") + "</color>");
        print("<color=red>殭屍剩下血量:" + Zb.Hp.ToString("F2") + "</color>");
        print("<color=red>殭屍死亡" + "</color>");
    }
    private void FixedUpdate()
    {
        A();
    }

}
