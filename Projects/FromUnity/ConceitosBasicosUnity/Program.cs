Random random = new Random();

double[] randomDamage = new double[10];
int[] exemplo = {1,2,3,4,5};
Dictionary<string,int> monsters = new Dictionary<string, int>();

monsters.Add("A",350);
monsters.Add("B",450);
monsters.Add("C",650);

AiMonster monsterInstance = AiMonster.Attack;


for (int i = 0; i < randomDamage.Length; i++)
{
    double valor =  random.NextDouble()*100;
    if (i != 0)
    {
        if (valor <= 1.0 || valor >= 99.99)
        {
            i--;
            continue;
        }
    }
    randomDamage[i] = random.NextDouble()*100;
}

foreach (var dmg in randomDamage)
{
    Console.WriteLine(dmg);
}


enum AiMonster
{
    Attack,
    Run,
    Patrol
}
