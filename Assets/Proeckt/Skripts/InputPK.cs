using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;
public class InputPK : MonoBehaviour
{
    public GameObject joy;
    public static InputPK rid { get; set; }
    void Awake()
    {
        if (rid == null)
        {
            rid = this;
        }
        else
        {
            Destroy(this);
        }
    }
    void OnDestroy()
    {
        rid = null;
    }
    public void Kik() 
    {
        Player_Muwer.rid.Kik();
    }

    public void MuweX(float X) 
    {
        Player_Muwer.rid.muwe.x = X;
    }

    public void MuweZ(float Z)
    {
        Player_Muwer.rid.muwe.z = Z;
    }
    void Update()
    {
        if (YandexGame.EnvironmentData.isDesktop) 
        {
            joy.SetActive(false);
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                Interface.rid.Sum(0, true, 0);
            }
            if (Player_Muwer.rid)
            {
                Player_Muwer.rid.muwe.z = Input.GetAxis("Vertical");
                Player_Muwer.rid.muwe.x = Input.GetAxis("Horizontal");
            }
        }
        
    }
}