using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SearchUIScript : MonoBehaviour
{
    public GameObject MapName;
    public GameObject BtnmapParent;
    public GameObject BtnMapPrefab;
    GameObject Btn;

   // string Shop;

    Dictionary<string, List<string>> MapsAndins = new Dictionary<string, List<string>>();
    List<KeyValuePair<string, List<string>>> FoundMaps = new List<KeyValuePair<string, List<string>>>();

    List<string> Tmp;
    
    void Start()
    {
       
        foreach (Transform Child in MapName.transform)
        {
            foreach (Transform Product in Child)
            {
              
                if (!MapsAndins.ContainsKey(Product.gameObject.name))
                {
                    Tmp = new List<string>();
                    Tmp.Add(Product.parent.gameObject.name);
                    MapsAndins.Add(Product.gameObject.name, Tmp);
                    
                }
                else
                {
                    Tmp = MapsAndins[Product.gameObject.name];
                    Tmp.Add(Product.parent.gameObject.name);
                    MapsAndins[Product.gameObject.name] = Tmp;
                   
                }
            }
        }
    }
    string Input;
    public void OnInputFieldValueChange(Text InputFieldText)
    {
      
        //clear old products in the search
        FoundMaps.Clear();
        foreach (Transform Child in BtnmapParent.transform)
            Destroy(Child.gameObject);

        //find similar products
        Input = InputFieldText.text.Trim().ToLower();
        if (Input != null && Input.Length > 1)
        {
            foreach (KeyValuePair<string, List<string>> item in MapsAndins)
            {
                if (item.Key.ToLower().Contains(Input))
                {
                    FoundMaps.Add(item);
                   
                }
            }
        }

        //add similar products puttons
        foreach (KeyValuePair<string, List<string>> Product in FoundMaps)
        {
            Btn = Instantiate(BtnMapPrefab, BtnmapParent.transform);
            Btn.GetComponentInChildren<Text>().text = Product.Key;
           
            Btn.GetComponent<Button>().onClick.AddListener(delegate {
               OnProductButtonClicked(Product);
               
            });
        }
    }
    void GoToShop(string ShopName)
    {
       
        switch (ShopName)
        { 
            case "124s":

              
                PlayerPrefs.SetString("mapname", "124s");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "164s":

                PlayerPrefs.SetString("mapname", "164s");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "155s":

                PlayerPrefs.SetString("mapname", "155s");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "156s":

                PlayerPrefs.SetString("mapname", "156s");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "157s":

                PlayerPrefs.SetString("mapname", "157s");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "152s":

                PlayerPrefs.SetString("mapname", "152s");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "151s":

                PlayerPrefs.SetString("mapname", "151s");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "149s":

                PlayerPrefs.SetString("mapname", "149s");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "148s":

                PlayerPrefs.SetString("mapname", "148s");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "146s":

                PlayerPrefs.SetString("mapname", "146s");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "147s":

                PlayerPrefs.SetString("mapname", "147s");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "144s":

                PlayerPrefs.SetString("mapname", "144s");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "143s":

                PlayerPrefs.SetString("mapname", "143s");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "122s":

                PlayerPrefs.SetString("mapname", "122s");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "167s":

                PlayerPrefs.SetString("mapname", "167s");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "137s":

                PlayerPrefs.SetString("mapname", "137s");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "138s":

                PlayerPrefs.SetString("mapname", "138s");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "139s":

                PlayerPrefs.SetString("mapname", "139s");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "140s":

                PlayerPrefs.SetString("mapname", "140s");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "141s":

                PlayerPrefs.SetString("mapname", "141s");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "142s":

                PlayerPrefs.SetString("mapname", "142s");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "158s":

                PlayerPrefs.SetString("mapname", "158s");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "159s":

                PlayerPrefs.SetString("mapname", "159s");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "112s":

                PlayerPrefs.SetString("mapname", "112s");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "113s":

                PlayerPrefs.SetString("mapname", "113s");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "114s":

                PlayerPrefs.SetString("mapname", "114s");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "109s":

                PlayerPrefs.SetString("mapname", "109s");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "108s":

                PlayerPrefs.SetString("mapname", "108s");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;

            case "121f":

                PlayerPrefs.SetString("mapname", "121f");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "119f":

                PlayerPrefs.SetString("mapname", "119f");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "120f":

                PlayerPrefs.SetString("mapname", "120f");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "122f":

                PlayerPrefs.SetString("mapname", "122f");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "123f":

                PlayerPrefs.SetString("mapname", "123f");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "124f":

                PlayerPrefs.SetString("mapname", "124f");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "125f":

                PlayerPrefs.SetString("mapname", "125f");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "126f":

                PlayerPrefs.SetString("mapname", "126f");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "127f":

                PlayerPrefs.SetString("mapname", "127f");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "128f":

                PlayerPrefs.SetString("mapname", "128f");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "135f":

                PlayerPrefs.SetString("mapname", "135f");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "134f":

                PlayerPrefs.SetString("mapname", "134f");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "136f":

                PlayerPrefs.SetString("mapname", "136f");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "102f":

                PlayerPrefs.SetString("mapname", "102f");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "103f":

                PlayerPrefs.SetString("mapname", "103f");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "105f":

                PlayerPrefs.SetString("mapname", "105f");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "104f":

                PlayerPrefs.SetString("mapname", "104f");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "124g":

                PlayerPrefs.SetString("mapname", "124g");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "122g":

                PlayerPrefs.SetString("mapname", "122g");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "123g":

                PlayerPrefs.SetString("mapname", "123g");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "127g":

                PlayerPrefs.SetString("mapname", "127g");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "128g":

                PlayerPrefs.SetString("mapname", "128g");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "130g":

                PlayerPrefs.SetString("mapname", "130g");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "131g":

                PlayerPrefs.SetString("mapname", "131g");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "129g":

                PlayerPrefs.SetString("mapname", "129g");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
          
            case "145g":

                PlayerPrefs.SetString("mapname", "145g");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "146g":

                PlayerPrefs.SetString("mapname", "146g");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "147g":

                PlayerPrefs.SetString("mapname", "147g");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "148g":

                PlayerPrefs.SetString("mapname", "148g");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "149g":

                PlayerPrefs.SetString("mapname", "149g");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "104g":

                PlayerPrefs.SetString("mapname", "104g");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "105g":

                PlayerPrefs.SetString("mapname", "105g");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "106g":

                PlayerPrefs.SetString("mapname", "106g");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;
            case "139g":

                PlayerPrefs.SetString("mapname", "139g");
                PlayerPrefs.Save();
                SceneManager.LoadScene("ReadMap");
                break;


            default:
                break;
        }
    }
    void OnProductButtonClicked(KeyValuePair<string, List<string>> item)
    {
        foreach (string Shop in item.Value)
        {
          
            Btn.GetComponentInChildren<Text>().text = Shop;
           Debug.Log(Shop);
            GoToShop(Shop);
        }

       
       


        // Update is called once per frame
       
    }
  
}
