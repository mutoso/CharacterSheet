using UnityEngine;

public class CharacterSheet : MonoBehaviour
{
    [SerializeField] string characterName = "John D'oh";
    [SerializeField] int proficiencyBonus = 2;
    [SerializeField] bool usingFinesseWeapon = true;
    [SerializeField][Range(-5, 5)] int strengthModifier = 1;
    [SerializeField][Range(-5, 5)] int dexterityModifier = 3;

    // Start is called before the first frame update
    void Start()
    {
        int hitModifier = (usingFinesseWeapon ? dexterityModifier : strengthModifier) + proficiencyBonus;
        Debug.Log(characterName + "'s hit modifier is " + hitModifier + ".");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
