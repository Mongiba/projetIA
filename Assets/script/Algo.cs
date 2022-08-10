using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Algo : menue1
{
    
    public int c = 0;
    public int numham = d * 3600;
    public int numtbarklh = d * 3600;
    public int numsobhanlh = d * 3600;
    public bool Play = false;
    public int[,] tab_wa9et = new int[2, hamdoulh + tbarkalh + sobhanalh + 2];
    public double time;
    void Start()
    {
        void tritab()
        {
            int duree = (f - d) * 3600;
            int[,] tab_hamdoulah = new int[2, hamdoulh];
            int i = 0;
            for (i = 0; i < hamdoulh; i++)
            {
                tab_hamdoulah[0, i] = numham;
                tab_hamdoulah[1, i] = 1;
                numham += (duree / (hamdoulh + 1));

            }



            int[,] tab_tbarklh = new int[2, tbarkalh];

            for (i = 0; i < tbarkalh; i++)
            {
                tab_tbarklh[0, i] = numtbarklh;
                tab_tbarklh[1, i] = 2;
                numtbarklh += (duree / (tbarkalh + 1));

            }

            int[,] tab_sobhanlh = new int[2, sobhanalh];

            for (i = 0; i < tbarkalh; i++)
            {
                tab_sobhanlh[0, i] = numsobhanlh;
                tab_sobhanlh[1, i] = 3;
                numsobhanlh += (duree / (sobhanalh + 1));

            }








            tab_wa9et[0, 0] = d;
            tab_wa9et[1, 0] = 0;

            for (i = 1; i <= hamdoulh + tbarkalh + sobhanalh + 1; i++)
            {
                if (i <= hamdoulh)
                {
                    tab_wa9et[0, i] = tab_hamdoulah[0, i - 1];
                    tab_wa9et[1, i] = tab_hamdoulah[1, i - 1];
                }
                else if ((i <= tbarkalh + hamdoulh) && (i > hamdoulh))
                {
                    tab_wa9et[0, i] = tab_tbarklh[0, i - (1 + hamdoulh)];
                    tab_wa9et[1, i] = tab_tbarklh[1, i - (1 + hamdoulh)];
                }
                else if ((i <= tbarkalh + hamdoulh + sobhanalh) && (i > hamdoulh + tbarkalh))
                {
                    tab_wa9et[0, i] = tab_sobhanlh[0, i - (1 + hamdoulh + tbarkalh)];
                    tab_wa9et[1, i] = tab_sobhanlh[1, i - (1 + hamdoulh + tbarkalh)];
                }
                else
                {
                    tab_wa9et[0, hamdoulh + tbarkalh + sobhanalh + 1] = f;
                    tab_wa9et[1, hamdoulh + tbarkalh + sobhanalh + 1] = 0;
                }


            }

            Array.Sort(tab_wa9et);

            i = 0;
            int j = 1;

            while (i < tbarkalh + hamdoulh + sobhanalh + 1)

            {
                if (tab_wa9et[0, i] == tab_wa9et[0, i + j])
                {
                    while (tab_wa9et[0, i] == tab_wa9et[0, i + j])
                    {
                        j++;
                    }
                    int diff = (tab_wa9et[0, i + j] - tab_wa9et[0, i]) / j;
                    for (int k = 0; k < j; k++)
                    {
                        tab_wa9et[0, i + k] = tab_wa9et[0, i + k] + k * diff;
                    }
                }
                i++;
                j = 1;
            }

        }

    }



    void Update()
    {
 
            time = TimeToSeconds();

        double TimeToSeconds()
        {
            string tim = DateTime.Now.ToString("hh:mm:ss");
            double seconds = TimeSpan.Parse(tim).TotalSeconds;
            return seconds;

        }

       /* void play_game()

        {

          
            if ((time < d * 3600) || (time > f * 3600))
                Play = false;
            else if (time == tab_wa9et[0, c])
            {
                Play = true;
                double t = tab_wa9et[0,c];
                mouvement.Active(t, tab_wa9et[0, c+1], tab_wa9et[1, c]);
                c++;
            }


        }*/
    }
}

