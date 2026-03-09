#region dry principle
//exercise 1
public Text goldText;
public Text crystalText;
public Text foodText;
void Update(Text source, int amount)
{
 source.text = "Amount: " + amount.ToString();
}

//exercise 5
public class Program : MonoBehavior {
    void inBoundry(){
        if (transform.position.x < mapSize)
        {
            MoveRight();
        }
        else if (transform.position.x > mapSize)
        {
            MoveLeft();
        }
    }
    public float mapSize = 100f;
    public float speed = 5f;
    void MoveRight() {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
    void MoveLeft() {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
#endregion

#region yagni principle
//exercise 1
public class HealthPotion {
 public int healAmount = 10;
 public void Consume(Player player) {
    player.Heal(healAmount);
    }
 }

//exercise 2
public class CollectibleDot {
 public int requiredLevelToEquip = 1;
 public int pointValue = 10;
 public void Collect(Player player) {
 if (player.level >= requiredLevelToEquip) {
    player.AddScore(pointValue);
    }
}
}

//exercise
#endregion

#region kiss principle
//exercise 1
public bool IsPlayerDead(){
    return health <= 0;
}

//exercise 2

//exercise 3
void CheckEnemy(string enemyType) {
 if (enemyType == "Goblin" || enemyType == "Orc"|| enemyType == "Troll") {
    Attack();
    }
 else {
    RunAway();
    }
}
#endregion