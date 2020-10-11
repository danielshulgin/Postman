using UnityEditor;
using UnityEngine;


public class House : MonoBehaviour
{
    [SerializeField] private CharacterParametrVariantsSO parametrVariantsSO;
    
    [SerializeField] private string characterName;

    [SerializeField] private string surname;
    
    [SerializeField] private string sex;
    
    [SerializeField] private string age;
    
    [SerializeField] private string hair_color;
    
    [SerializeField] private string height;
    
    [SerializeField] private string body;
    
    [SerializeField] private string car;
    
    [SerializeField] private string pat;
    
    [SerializeField] private string married;


    public string Info => "name: " + name + "\n" +
                          "surname: " + surname + "\n" +
                          "sex: " + sex + "\n" +
                          "characterName: " + characterName + "\n" +
                          "age: " + age + "\n" +
                          "hair color: " + hair_color + "\n" +
                          "height: " + height + "\n" +
                          "body: " + body + "\n" +
                          "car: " + car + "\n" +
                          "pat: " + pat + "\n" +
                          "married: " + married + "\n";
    
    
    [ContextMenu("GenerateRandomValues")]
    public void GenerateRandomValues()
    {
        sex = parametrVariantsSO.sex[Random.Range(0, parametrVariantsSO.sex.Count)];
        if (sex == "Мужской")
        {
            characterName = parametrVariantsSO.names_male[Random.Range(0, parametrVariantsSO.names_male.Count)];
        }
        else
        {
            characterName = parametrVariantsSO.names_female[Random.Range(0, parametrVariantsSO.names_female.Count)];
        }
        surname = parametrVariantsSO.surnames[Random.Range(0, parametrVariantsSO.surnames.Count)];
        age = parametrVariantsSO.age[Random.Range(0, parametrVariantsSO.age.Count)];
        hair_color = parametrVariantsSO.hair_color[Random.Range(0, parametrVariantsSO.hair_color.Count)];
        height = parametrVariantsSO.height[Random.Range(0, parametrVariantsSO.height.Count)];
        body = parametrVariantsSO.body[Random.Range(0, parametrVariantsSO.body.Count)];
        car = parametrVariantsSO.car[Random.Range(0, parametrVariantsSO.car.Count)];
        pat = parametrVariantsSO.pat[Random.Range(0, parametrVariantsSO.pat.Count)];
        married = parametrVariantsSO.married[Random.Range(0, parametrVariantsSO.married.Count)];
        EditorUtility.SetDirty(this);
        AssetDatabase.SaveAssets();
    }
}
