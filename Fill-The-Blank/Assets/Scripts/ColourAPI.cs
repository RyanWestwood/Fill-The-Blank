using UnityEngine;
using System.Net;
using System.IO;

[System.Serializable]
public class ColourSchema
{
    public string hex;
    public string rgb;
    public string hsl;
    public string hsv;
    public string name;
    public string cmyk;
    public string xyz;
    public string image;
    public string contrast;
}

// EXAMPLE:
// https://www.thecolorapi.com/scheme?rgb=50,50,50&mode=analogic-complement&count=10
public class API_REQUEST{
    public string url = "https://www.thecolorapi.com/";
    public string type = "scheme?";
    public string rgb = "rgb=" + "50" + "," + "50" + "," + "50";
    public string mode = "&mode=analogic-complement";
    public string count = "&count=10";
}

public static class ColourAPI {

    public static ColourSchema GetColourScheme()
    {
        string test_url = "https://www.thecolorapi.com/scheme?rgb=50,50,50&mode=analogic-complement&count=10";
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(test_url);
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        StreamReader reader = new StreamReader(response.GetResponseStream());
        string json = reader.ReadToEnd();
        return JsonUtility.FromJson<ColourSchema>(json);
    }
}