using UnityEngine;
using TMPro;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework.Interfaces;

public class Recommendations : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI recommendations;

    public void WriteToBoard(string str)
    {
        // var dict = JsonUtils.DeserializeToMap(str);
        var hardCoded = "---------------------\n$299.99   Meta Raybans Wayfarers\nmeta.com\n---------------------\n$399.99   Meta Oakleys\nmeta.com\n---------------------\n$409.99   Meta Raybans Headliners\nsunglasshut.com\n---------------------";
        var val = str.IndexOf("immersive_products");
        if (val == -1)
        {
            recommendations.text = hardCoded;
            return;
        }
        string aIP = str.Substring(str.IndexOf("immersive_products"));
    int start = 0;
        string text = "";

        for (int i = 0; i < 3; i++)
        {
            start = aIP.IndexOf("source", start);
            if (start == -1)
            {
                break;
            }
            int end = aIP.IndexOf(",", start);
            string source = aIP.Substring(start - 1, end - start);
            start = end;

            start = aIP.IndexOf("title", start);
            end = aIP.IndexOf(",", start);
            string title = aIP.Substring(start - 1, end - start);
            start = end;

            start = aIP.IndexOf("price", start);
            end = aIP.IndexOf(",", start);
            string price = aIP.Substring(start - 1, end - start);
            start = end;

            text += source + "\"\n" + title + "\"\n" + price + "\"\n\n---------------------";
        }
        recommendations.text = text;
    }
}
