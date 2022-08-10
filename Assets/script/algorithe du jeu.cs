using System;
using System.Collections;
using System.Collections.Generic;

public class programme
{

   /// void update/
   

    public static int d = 8;
    public static int f = 10;
    public int hamdoulah = 5;
    public int tbarklh = 6;
    public int sobhanlh = 6;
    public int numham = d * 3600;
    public int numtbarklh = d * 3600;
    public int numsobhanlh = d * 3600;

    public void play_game()

    {
        bool play = true;
        double time = TimeToSeconds();
        if ((time < d * 3600) || (time > f * 3600))
            play = false;
        else
        {
            int duree = (f - d) * 3600;
            int[,] tab_hamdoulah = new int[2, hamdoulah];
            int i = 0;
            for (i = 0; i < hamdoulah; i++)
            {
                tab_hamdoulah[0, i] = numham;
                tab_hamdoulah[1, i] = 1;
                numham += (duree / (hamdoulah + 1));

            }



            int[,] tab_tbarklh = new int[2, tbarklh];
            
            for (i = 0; i < tbarklh; i++)
            {
                tab_tbarklh[0, i] = numtbarklh;
                tab_tbarklh[1, i] = 2;
                numtbarklh += (duree / (tbarklh + 1));

            }

            int[,] tab_sobhanlh = new int[2, sobhanlh];
            
            for (i = 0; i < tbarklh; i++)
            {
                tab_sobhanlh[0, i] = numsobhanlh;
                tab_sobhanlh[1, i] = 3;
                numsobhanlh += (duree / (sobhanlh + 1));

            }






            int[,] tab_wa9et = new int[2, hamdoulah + tbarklh + sobhanlh + 2];

            tab_wa9et[0, 0] = d;
            tab_wa9et[1, 0] = 0;
            
            for (i =1; i <= hamdoulah + tbarklh + sobhanlh + 1; i++)
            {
                if (i <= hamdoulah)
                {
                    tab_wa9et[0, i] = tab_hamdoulah[0, i - 1];
                    tab_wa9et[1, i] = tab_hamdoulah[1, i - 1];
                }
                else if ((i <= tbarklh + hamdoulah) && (i > hamdoulah))
                {
                    tab_wa9et[0, i] = tab_tbarklh[0, i - (1 + hamdoulah)];
                    tab_wa9et[1, i] = tab_tbarklh[1, i - (1 + hamdoulah)];
                }
                else if ((i <= tbarklh + hamdoulah + sobhanlh) && (i > hamdoulah + tbarklh))
                {
                    tab_wa9et[0, i] = tab_sobhanlh[0, i - (1 + hamdoulah + tbarklh)];
                    tab_wa9et[1, i] = tab_sobhanlh[1, i - (1 + hamdoulah + tbarklh)];
                }
                else
                {
                    tab_wa9et[0, hamdoulah + tbarklh + sobhanlh + 1] = f;
                    tab_wa9et[1, hamdoulah + tbarklh + sobhanlh + 1] = 0;
                }


            }

            Array.Sort(tab_wa9et);

            i = 0;
            int j = 1;

            while (i < tbarklh + hamdoulah + sobhanlh + 1)

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
    public Double TimeToSeconds()
    {
        string time = DateTime.Now.ToString("hh:mm:ss");
        double seconds = TimeSpan.Parse(time).TotalSeconds;
        return seconds;

    }
}
