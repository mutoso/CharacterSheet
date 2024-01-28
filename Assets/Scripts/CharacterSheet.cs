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
        Debug.Log($"{characterName}'s hit modifier is {formatHitModifier(hitModifier)}.");

        int enemyAC = Random.Range(10, 20 + 1);
        Debug.Log($"Enemy's AC is {enemyAC}.");

        int diceRoll = Random.Range(1, 20 + 1);
        Debug.Log($"{characterName} rolls 1d20. It lands on {diceRoll}.");

        Debug.Log($"{diceRoll}{formatHitModifier(hitModifier)} = {diceRoll + hitModifier} vs. {enemyAC}");
        if (diceRoll + hitModifier >= enemyAC)
        {
            // It hits!
            if (usingFinesseWeapon)
            {
                Debug.Log("You swiftly swing your sword and land a hit on your opponent!");
            }
            else
            {
                Debug.Log("You slam your club against the foe. It crumbles under its weight.");
            }
        }
        else
        {
            // It misses!
            Debug.Log("The enemy is too quick and dodges your weapon!");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    string formatHitModifier(int hitModifier)
    {
        return (hitModifier < 0 ? "" : "+") + hitModifier.ToString();
    }
}
