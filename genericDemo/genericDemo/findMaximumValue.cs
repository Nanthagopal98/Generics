﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class findMaximumValue
{
    public int findMaxInt(int firstValue, int secondValue, int thirdValue)
    {
        int intMaxValue;
        if (firstValue > secondValue && firstValue > thirdValue)
        {
            intMaxValue = firstValue;
        }
        else if (secondValue > firstValue && secondValue > thirdValue)
        {
            intMaxValue = secondValue;
        }
        else
        {
            intMaxValue = thirdValue;
        }
        Console.WriteLine(intMaxValue);
        return intMaxValue;
    }
    public float findMaxFloat(float firstValue, float secondValue, float thirdValue)
    {
        float floatMaxValue;
        if (firstValue > secondValue && firstValue > thirdValue)
        {
            floatMaxValue = firstValue;
        }
        else if (secondValue > firstValue && secondValue > thirdValue)
        {
            floatMaxValue = secondValue;
        }
        else
        {
            floatMaxValue = thirdValue;
        }
        Console.WriteLine(floatMaxValue);
        return floatMaxValue;
    }

}


