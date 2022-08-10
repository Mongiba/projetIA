using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class menue1 : MonoBehaviour 
{

    public void gomenue2()
    {
        int SelectedCharacter =
        int.Parse(EventSystem.current.currentSelectedGameObject.name);

       //.instance.CharIndex = SelectedCharacter ;
        SceneManager.LoadScene("menue2");
    }
    public void gogame()
    { if ((d >= 0) && (d < 24) &&(f < 24) && (f >= 0) && (tbar>= 0) && (tbar <= 10) && (ham >= 0) && (ham <= 10) &&(sobh<=10)&&(sobh>=0))
        {
            SceneManager.LoadScene("game");
            Debug.Log("true");
        }
    }
        
        
          protected static int hamplus =0;
          protected static int tbarkaplus =0;
          protected static int sobhanaplus =0;
    
        public static int d;
        protected static int  f;
        protected static int ham;
        protected static int tbar;
        protected static int sobh;
        protected static int hamdoulh=ham+hamplus;
        protected static int tbarkalh= tbar+tbarkaplus;
        protected static int sobhanalh=sobh+sobhanaplus;
  

        public void Debut(string n)
        {
        d = int.Parse(n);
        Debug.Log(d);
        }
    
         public void Fin(string n)
         {
          f = int.Parse(n);
            Debug.Log(f);
         } 
        public void Hamdoulh(string n)
        {
        ham = int.Parse(n);
        Debug.Log(ham);
        } 
        public void Tbarklh(string n)
        {
        tbar = int.Parse(n);
        Debug.Log(tbar);
         } 
        public void sobhanlh(string n)
        { 
        sobh = int.Parse(n);
        Debug.Log(sobh);

        }



  
}