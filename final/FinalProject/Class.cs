class Class: Character {
    protected string className;
    protected string classDescription;

    public Class() {

    }

    public virtual void DisplayClass() {

    }

    public virtual void SetStats() {
        random = randGen.Next(1,2);
        scores.Sort();
    }
}

class Barbarian: Class {

    public Barbarian() {

    }

    public override void SetStats() {

    }
}

class Bard: Class {
     
    public Bard() {

    }

    public override void SetStats() {

    }
}

class Cleric: Class {
     
    public Cleric() {

    }

    public override void SetStats() {
        base.SetStats();
        
    }
}

class Druid: Class {
     
    public Druid() {

    }

    public override void SetStats() {
        base.SetStats();
        int temp;
        List<int> list = new List<int>();
        wisdom = scores[5];
        constitution = scores[4];
        list.Add(scores[0]);
        list.Add(scores[1]);
        list.Add(scores[2]);
        list.Add(scores[3]);
        for (int i = 3; i >= 0; i--) {
            temp = randGen.Next(0, i);
            if (i == 3) {
                strength = scores[temp];
                list.RemoveAt(temp);
            }
            else if (i == 2) {
                charisma = scores[temp];
                list.RemoveAt(temp);
            }
            else if (i == 1) {
                intelligence = scores[temp];
                list.RemoveAt(temp);
            }
            else if (i == 0) {
                dexterity = scores[temp];
                list.RemoveAt(temp);
            }
        }
    }
}

class Fighter: Class {
     
    public Fighter() {

    }

    public override void SetStats() {
        base.SetStats();
        int temp;
        List<int> list = new List<int>();
        list.Add(scores[0]);
        list.Add(scores[1]);
        list.Add(scores[2]);
        if (random == 1) {
            strength = scores[5];
            random = randGen.Next(1,2);
            if (random == 1) {
                constitution = scores[4];
                intelligence = scores[3];
                for (int i = 2; i >= 0; i--) {
                    temp = randGen.Next(0, i);
                    if (i == 2) {
                        wisdom = scores[temp];
                        list.RemoveAt(temp);
                    }
                    else if (i == 1) {
                        charisma = scores[temp];
                        list.RemoveAt(temp);
                    }
                    else if (i == 0) {
                        dexterity = scores[temp];
                        list.RemoveAt(temp);
                    }
                }
            }
            else {
                intelligence = scores[4];
                constitution = scores[3];
                for (int i = 2; i >= 0; i--) {
                    temp = randGen.Next(0, i);
                    if (i == 2) {
                        wisdom = scores[temp];
                        list.RemoveAt(temp);
                    }
                    else if (i == 1) {
                        charisma = scores[temp];
                        list.RemoveAt(temp);
                    }
                    else if (i == 0) {
                        dexterity = scores[temp];
                        list.RemoveAt(temp);
                    }
                }
            }
        }
        else {
            dexterity = scores[5];
            random = randGen.Next(1,2);
            if (random == 1) {
                constitution = scores[4];
                intelligence = scores[3];
                for (int i = 2; i >= 0; i--) {
                    temp = randGen.Next(0, i);
                    if (i == 2) {
                        wisdom = scores[temp];
                        list.RemoveAt(temp);
                    }
                    else if (i == 1) {
                        charisma = scores[temp];
                        list.RemoveAt(temp);
                    }
                    else if (i == 0) {
                        strength = scores[temp];
                        list.RemoveAt(temp);
                    }
                }
            }
            else {
                intelligence = scores[4];
                constitution = scores[3];
                for (int i = 2; i >= 0; i--) {
                    temp = randGen.Next(0, i);
                    if (i == 2) {
                        wisdom = scores[temp];
                        list.RemoveAt(temp);
                    }
                    else if (i == 1) {
                        charisma = scores[temp];
                        list.RemoveAt(temp);
                    }
                    else if (i == 0) {
                        strength = scores[temp];
                        list.RemoveAt(temp);
                    }
                }
            }
        }
        for (int i = 3; i >= 0; i--) {
            temp = randGen.Next(0, i);
            if (i == 3) {
                constitution = scores[temp];
                list.RemoveAt(temp);
            }
            else if (i == 2) {
                wisdom = scores[temp];
                list.RemoveAt(temp);
            }
            else if (i == 1) {
                intelligence = scores[temp];
                list.RemoveAt(temp);
            }
            else if (i == 0) {
                dexterity = scores[temp];
                list.RemoveAt(temp);
            }
        }
    }
}

class Monk: Class {
     
    public Monk() {

    }

    public override void SetStats() {
        base.SetStats();
        int temp;
        List<int> list = new List<int>();
        dexterity = scores[5];
        wisdom = scores[4];
        list.Add(scores[0]);
        list.Add(scores[1]);
        list.Add(scores[2]);
        list.Add(scores[3]);
        for (int i = 3; i >= 0; i--) {
            temp = randGen.Next(0, i);
            if (i == 3) {
                constitution = scores[temp];
                list.RemoveAt(temp);
            }
            else if (i == 2) {
                strength = scores[temp];
                list.RemoveAt(temp);
            }
            else if (i == 1) {
                intelligence = scores[temp];
                list.RemoveAt(temp);
            }
            else if (i == 0) {
                charisma = scores[temp];
                list.RemoveAt(temp);
            }
        }
    }
}

class Paladin: Class {
     
    public Paladin() {

    }

    public override void SetStats() {
        base.SetStats();
        int temp;
        List<int> list = new List<int>();
        strength = scores[5];
        charisma = scores[4];
        list.Add(scores[0]);
        list.Add(scores[1]);
        list.Add(scores[2]);
        list.Add(scores[3]);
        for (int i = 3; i >= 0; i--) {
            temp = randGen.Next(0, i);
            if (i == 3) {
                constitution = scores[temp];
                list.RemoveAt(temp);
            }
            else if (i == 2) {
                wisdom = scores[temp];
                list.RemoveAt(temp);
            }
            else if (i == 1) {
                intelligence = scores[temp];
                list.RemoveAt(temp);
            }
            else if (i == 0) {
                dexterity = scores[temp];
                list.RemoveAt(temp);
            }
        }
    }
}

class Ranger: Class {
     
    public Ranger() {

    }

    public override void SetStats() {
        base.SetStats();
        int temp;
        List<int> list = new List<int>();
        dexterity = scores[5];
        wisdom = scores[4];
        list.Add(scores[0]);
        list.Add(scores[1]);
        list.Add(scores[2]);
        list.Add(scores[3]);
        for (int i = 3; i >= 0; i--) {
            temp = randGen.Next(0, i);
            if (i == 3) {
                strength = scores[temp];
                list.RemoveAt(temp);
            }
            else if (i == 2) {
                charisma = scores[temp];
                list.RemoveAt(temp);
            }
            else if (i == 1) {
                intelligence = scores[temp];
                list.RemoveAt(temp);
            }
            else if (i == 0) {
                constitution = scores[temp];
                list.RemoveAt(temp);
            }
        }
    }
}

class Rogue: Class {
     
    public Rogue() {

    }

    public override void SetStats() {
        base.SetStats();
        int temp;
        List<int> list = new List<int>();
        dexterity = scores[5];
        if (random == 1) {
            intelligence = scores[4];
            charisma = scores[3];
        }
        else {
            charisma = scores[4];
            intelligence = scores[3];
        }
        list.Add(scores[0]);
        list.Add(scores[1]);
        list.Add(scores[2]);
        for (int i = 2; i >= 0; i--) {
            temp = randGen.Next(0, i);
            if (i == 2) {
                strength = scores[temp];
                list.RemoveAt(temp);
            }
            else if (i == 1) {
                wisdom = scores[temp];
                list.RemoveAt(temp);
            }
            else if (i == 0) {
                constitution = scores[temp];
                list.RemoveAt(temp);
            }
        }
    }
}

class Sorcerer: Class {
     
    public Sorcerer() {

    }

    public override void SetStats() {
        base.SetStats();
        int temp;
        List<int> list = new List<int>();
        charisma = scores[5];
        constitution = scores[4];
        list.Add(scores[0]);
        list.Add(scores[1]);
        list.Add(scores[2]);
        list.Add(scores[3]);
        for (int i = 3; i >= 0; i--) {
            temp = randGen.Next(0, i);
            if (i == 3) {
                strength = scores[temp];
                list.RemoveAt(temp);
            }
            else if (i == 2) {
                wisdom = scores[temp];
                list.RemoveAt(temp);
            }
            else if (i == 1) {
                intelligence = scores[temp];
                list.RemoveAt(temp);
            }
            else if (i == 0) {
                dexterity = scores[temp];
                list.RemoveAt(temp);
            }
        }
    }
}

class Warlock: Class {
     
    public Warlock() {

    }

    public override void SetStats() {
        base.SetStats();
        int temp;
        List<int> list = new List<int>();
        charisma = scores[5];
        constitution = scores[4];
        list.Add(scores[0]);
        list.Add(scores[1]);
        list.Add(scores[2]);
        list.Add(scores[3]);
        for (int i = 3; i >= 0; i--) {
            temp = randGen.Next(0, i);
            if (i == 3) {
                strength = scores[temp];
                list.RemoveAt(temp);
            }
            else if (i == 2) {
                wisdom = scores[temp];
                list.RemoveAt(temp);
            }
            else if (i == 1) {
                intelligence = scores[temp];
                list.RemoveAt(temp);
            }
            else if (i == 0) {
                dexterity = scores[temp];
                list.RemoveAt(temp);
            }
        }
    }
}

class Wizard: Class {
     
    public Wizard() {

    }

    public override void SetStats() {
        base.SetStats();
        int temp;
        List<int> list = new List<int>();
        intelligence = scores[5];
        if (random == 1) {
            constitution = scores[4];
            dexterity = scores[3];
        }
        else {
            dexterity = scores[4];
            constitution = scores[3];
        }
        list.Add(scores[0]);
        list.Add(scores[1]);
        list.Add(scores[2]);
        for (int i = 2; i >= 0; i--) {
            temp = randGen.Next(0, i);
            if (i == 2) {
                strength = scores[temp];
                list.RemoveAt(temp);
            }
            else if (i == 1) {
                wisdom = scores[temp];
                list.RemoveAt(temp);
            }
            else if (i == 0) {
                charisma = scores[temp];
                list.RemoveAt(temp);
            }
        }
    }
}