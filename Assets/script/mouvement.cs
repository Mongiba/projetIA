using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.Windows.Speech;
using System;
using UnityEngine.UI;

public class mouvement : Algo
 {  
    int k = 0;
    //float currentTime = 0f;
    //float startingTime = 10f;
    //[SerializeField] Text countdownText;
    int n;


    public ConfidenceLevel Confidence = ConfidenceLevel.Low;
    private KeywordRecognizer keywordRecognizer;
    private Dictionary<string, Action> keywords = new Dictionary<string, Action>();
    void Start()
    {
        // currentTime = startingTime;
        ///////////////////////////

        keywords.Add("hamdoulah", hamdoulah);
        keywords.Add("tbarklah", tbarklh);
        keywords.Add("sobhanalah", sobhanalah);

        keywordRecognizer = new KeywordRecognizer(keywords.Keys.ToArray(), Confidence);
        keywordRecognizer.OnPhraseRecognized += Recognizeed;

    }
  

    
    /*private void hamdoulah()
    {
        transform.Translate(10, 0, 0);
        Debug.Log("hamdoulah");
    }*/
    private void hamdoulah()
    {
        Debug.Log("hamdoulah");
         k = 1;
    }
    private void tbarklh()
    {
        transform.Translate(-10, 0, 0);
        Debug.Log("tbarklh");
         k = 1;
    }
    private void sobhanalah()
    {
        Debug.Log("sobhanalah");
         k = 1;
    }
    ///////////////////////////////////////////////////////////////////////////////////
    void play_game()

    {


        if ((time < d * 3600) || (time > f * 3600))
            Play = false;
        else if (time == tab_wa9et[0, c])
        {
            Play = true;
            double t = tab_wa9et[0, c];
            Active(t, tab_wa9et[0, c + 1], tab_wa9et[1, c]);
            c++;
        }


    }
    public void Active(double t, double sec, int nn)
        {
            if ((k==0)&&(Play == true) && (time > t) && (time < (t+((sec - t) / 2))))
            {
            
            n = nn;
            keywordRecognizer.Start();
            }
            else if((k==1)&& (Play == true) && (time > t) && (time < ((sec - t) / 2)))
                {
                Play = false;
                keywordRecognizer.Stop();
                k = 0;
                }
                else if((time == ((sec - t) / 2) && (k==0) &&(Play == true)))
                {Play = false;
                keywordRecognizer.Stop();
                  if (n == 1) { hamplus ++; }
                  else if (n == 2) { tbarkaplus ++; }
                  else if (n == 3) { sobhanaplus ++; }
                      
                }
        }
            /* currentTime -= 1 * Time.deltaTime;
             countdownText.text =  currentTime.ToString("0");
             if (currentTime <= 0)
             {
                 currentTime = 0;
             }
            */


  private void Recognizeed(PhraseRecognizedEventArgs speech)
    {


        if ((n == 1) && keywords[speech.text] == hamdoulah)
        {
            keywords["hamdoulah"].Invoke();
        }
        else if ((n == 3) && keywords[speech.text] == sobhanalah)
        {
            keywords["sobhanalah"].Invoke();
        }
        else if ((n == 2) && keywords[speech.text] == tbarklh)
        {
            keywords["hamdoulah"].Invoke();
        }




        }

    }

