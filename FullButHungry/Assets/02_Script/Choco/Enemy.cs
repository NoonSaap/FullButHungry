﻿using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    public UIProgressBar pb_hp = null;
    public UISprite sp_Enemy = null;
    public UISprite sp_Bomb = null;
    public int HP = 0;
    public int index = 0;

    public void SetData(int _index)
    {
        index = _index;
        HP = 3;
        sp_Enemy.spriteName = _index + "_N";
        sp_Enemy.alpha = 1;
        sp_Bomb.gameObject.SetActive(false);
    }

    public void SetAni(int level)
    {
        sp_Bomb.gameObject.SetActive(true);
        switch (level)
        {
            case 0:
                sp_Enemy.spriteName = index + "_N";
                sp_Bomb.spriteName = "Ani_S";
                sp_Bomb.width = 115;
                sp_Bomb.height = 84;
                break;
            case 1:
                sp_Enemy.spriteName = index + "_N";
                sp_Bomb.spriteName = "Ani_S";
                sp_Bomb.width = 149;
                sp_Bomb.height = 109;
                break;
            case 2:
                sp_Enemy.spriteName = index + "_N";
                sp_Bomb.spriteName = "Ani_S";
                sp_Bomb.width = 201;
                sp_Bomb.height = 145;
                break;
            case 3:
                sp_Enemy.spriteName = index + "_N";
                sp_Bomb.spriteName = "Ani_D";
                sp_Bomb.width = 201;
                sp_Bomb.height = 145;
                break;
        }
    }

    void OnCollide2D(Collider2D _col)
    {
        if (_col.tag == "Proj")
        {
            HP--;
            pb_hp.value = HP / 3;
            _col.gameObject.SetActive(false);
            if (HP <= 0)
            {

            }
        }
    }
}