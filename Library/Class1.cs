﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    
    public static class Class1
    {
        public static bool funkcijaPalindrom(string recenica)
        {
            recenica = recenica.Trim('.', '!', '?', ' ', ',');
            string[] reci = recenica.Split(' ', ',');
            recenica = "";
            for (int i = 0; i < reci.Length; i++)
            {
                recenica += reci[i].ToUpper();
            }
            

            int duzinaStringa = recenica.Length;

            for(int i = 0, j = duzinaStringa-1; j > duzinaStringa/2 && i < duzinaStringa/2; i++, j--)
            {
                if (recenica[i] != recenica[j])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
