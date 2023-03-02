using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    public class Codigo : MonoBehaviour
    {
        private float StartTime;
        public int suma;
        public int n = 10;

        void Start()
        {
            StartTime = Time.time;
            {
                suma = 0;
                for (int i = 1; i < n; i++)
                {
                    suma = suma + i;
                }
            }



            float Choose(float[] probabilidad)
            {

                float total = 0;

                foreach (float elementos in probabilidad)
                {
                    total += elementos;
                }

                float randomPoint = Random.value * total;

                for (int i = 0; i < probabilidad.Length; i++)
                {
                    if (randomPoint < probabilidad[i])
                    {
                        return i;
                    }
                    else
                    {
                        randomPoint -= probabilidad[i];
                    }
                }
                return probabilidad.Length - 1;
            }
            void Update()
            {
                {
                    float TimerControl = Time.time - StartTime;
                    string mins = ((int)TimerControl / 60).ToString("00");
                    string segs = (TimerControl % 60).ToString("00");
                    string milisegs = ((TimerControl * 100) % 100).ToString("00");

                    string TimerString = string.Format("{00}:{01}:{02}", mins, segs, milisegs);

                    GetComponent<Text>().text = TimerString.ToString();
                }
            }
        }
    }
}