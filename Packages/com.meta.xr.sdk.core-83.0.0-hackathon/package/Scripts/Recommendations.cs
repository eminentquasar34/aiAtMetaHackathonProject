
using UnityEngine;
using TMPro;

// [RequireComponent(typeof(LlmAgent))]
public class Recommendations : MonoBehaviour
{
  [SerializeField] private TextMeshProUGUI recommendations;
  private bool lorem = true;

  public void WriteToBoard()
  {
    if (lorem)
    {
      recommendations.text = "Not the lorem ipsum now";
    }
    else
    {
      recommendations.text = "Lorem Ipsum";
    }
    lorem = !lorem;
    // var map = new Dictionary<string, int>();
    // map.Add("test1", 1);
    // map.Add("test2", 2);

    // string str = "";
    // foreach (var entry in map)
    // {
    //   str += $"Website: {entry.Key}, Cost: {entry.Value}";
    // }
  }
}

