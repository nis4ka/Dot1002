#region dry principle
//exercise 1
public Text goldText;
public Text crystalText;
public Text foodText;
void Update(Text source, int amount)
{
 source.text = "Amount: " + amount.ToString();
}

//exercise 2
void SoundPlayer(AudioClip soundType){
    AudioSource audio = GetComponent<AudioSource>();
    audio.clip = soundType;
    audio.Play();
}
void Jump() {
    SoundPlayer(jumpSound);
    rb.velocity = Vector2.up * jumpForce;
}
void Shoot() {
    SoundPlayer(shootSound);
    Instantiate(bullet);
}

//exercise 3
void TakeDamage(int amount) {
    health -= amount;
    if (health < 0) health = 0;
    Debug.Log("Health: " + health);
}

//exercise 4
void SpawnEnemy(GameObject enemyPrefab)
{
     Vector3 spawnPos = transform.position + new Vector3(0, 1, 0);
    Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
    PlaySpawnParticle(spawnPos);
}

void SpawnGoblin() {
    SpawnEnemy(goblinPrefab);
}
void SpawnOrc() {
    SpawnEnemy(orcPrefab);
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

//exercise 3
public class Spaceship {
    public float moveSpeed = 5f;
    public void MoveHorizontal(float input) {
        transform.Translate(Vector3.right * input * moveSpeed * Time.deltaTime);
 }
}

//exercise 4
public class PlayerStats {
    public float jumpForce = 5f;
}

//exercise 5
public interface IWeaponSystem {
    void Fire();
    void Reload();
}
public class Pistol : IWeaponSystem {
}
#endregion

#region kiss principle
//exercise 1
public bool IsPlayerDead(){
    return health <= 0;
}

//exercise 2
List<int> startingLevels = new List<int> { 1, 2, 3 };

//exercise 3
void CheckEnemy(string enemyType) {
 if (enemyType == "Goblin" || enemyType == "Orc"|| enemyType == "Troll") {
    Attack();
    }
 else {
    RunAway();
    }
}

//exercise 4
float cooldownTimer = 5f; 

void Update() {
    if (cooldownTimer > 0) {
        cooldownTimer -= Time.deltaTime;
    }
}

//exercise 5
int GetHighestScore(int score1, int score2) {
    if (score1 > score2) {
        return score1;
    }
    else if (score2 > score1){
        return score2;
    }
}

#endregion