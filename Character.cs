using System;

namespace Character
{
    public class Character
    {
        public Character (string nickname, int life, int damage, string power){
            this.Nickname = nickname;
            this.Life = life;
            this.Damage = damage;
            this.Power = power;
        }

        public string Nickname{get; }
        public int Life {get; private set;}
        public int Damage {get; }
        public string Power{get; }
        public void Attack(Character enemy){
            enemy.Life = enemy.Life - this.Damage;
        }
        public bool Healthy(){
            return this.Life > 0;
        }
    }
}