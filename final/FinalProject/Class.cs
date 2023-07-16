class Class {
    public string className;
    protected string classDescription;
    protected int hitDiceMax;

    public Class() {

    }

    public virtual void DisplayClass() {
        Console.WriteLine($"Class: {className}");
        Console.WriteLine($"Description: {classDescription}");
    }

    public virtual void SetStats(Character character) {
        character.random = character.randGen.Next(1,3);
        character.scores.Sort();
    }

    public void SetHitPoints(Character character) {
        character.hitpoints += hitDiceMax + character.SetStatMod(character.constitution);
    }
}

class Barbarian: Class {
    public Barbarian() {
        hitDiceMax = 12;
        className = "Barbarian";
        classDescription = "A warrior defined by rage and fury, more than mere emotion, their anger\nand ferocity grants them strength and resilience in battle.";
    }

    public override void SetStats(Character character) {
        base.SetStats(character);
        int temp;
        character.strength += character.scores[5];
        character.constitution += character.scores[4];
        for (int i = 3; i >= 0; i--) {
            temp = character.randGen.Next(0, i+1);
            if (i == 3) {
                character.wisdom += character.scores[temp];
                character.scores.RemoveAt(temp);
            }
            else if (i == 2) {
                character.charisma += character.scores[temp];
                character.scores.RemoveAt(temp);
            }
            else if (i == 1) {
                character.intelligence += character.scores[temp];
                character.scores.RemoveAt(temp);
            }
            else if (i == 0) {
                character.dexterity += character.scores[temp];
                character.scores.RemoveAt(temp);
            }
        }
        SetHitPoints(character);
    }
}

class Bard: Class {

    public Bard() {
        hitDiceMax = 8;
        className = "Bard";
        classDescription = "A musician who weaves magic through words and music to inspire allies,\nmanipulate minds, create illusions, and heal wounds.";
    }

    public override void SetStats(Character character) {
        base.SetStats(character);
        int temp;
        character.charisma += character.scores[5];
        character.dexterity += character.scores[4];
        for (int i = 3; i >= 0; i--) {
            temp = character.randGen.Next(0, i+1);
            if (i == 3) {
                character.strength += character.scores[temp];
                character.scores.RemoveAt(temp);
            }
            else if (i == 2) {
                character.wisdom += character.scores[temp];
                character.scores.RemoveAt(temp);
            }
            else if (i == 1) {
                character.intelligence += character.scores[temp];
                character.scores.RemoveAt(temp);
            }
            else if (i == 0) {
                character.constitution += character.scores[temp];
                character.scores.RemoveAt(temp);
            }
        }
        SetHitPoints(character);
    }
}

class Cleric: Class {

    public Cleric() {
        hitDiceMax = 8;
        className = "Cleric";
        classDescription = "An intermediary between the mortal world and the distant plane of gods. Clerics strive to uphold\nthe values of their deity, and their power, varies on the god they serve.";
    }

    public override void SetStats(Character character) {
        base.SetStats(character);
        int temp;
        character.wisdom += character.scores[5];
        if (character.random == 1) {
            character.strength += character.scores[4];
            character.constitution += character.scores[3];
        }
        else {
            character.constitution += character.scores[4];
            character.strength += character.scores[3];
        }
        for (int i = 2; i >= 0; i--) {
            temp = character.randGen.Next(0, i+1);
            if (i == 2) {
                character.charisma += character.scores[temp];
                character.scores.RemoveAt(temp);
            }
            else if (i == 1) {
                character.intelligence += character.scores[temp];
                character.scores.RemoveAt(temp);
            }
            else if (i == 0) {
                character.dexterity += character.scores[temp];
                character.scores.RemoveAt(temp);
            }
        }
        SetHitPoints(character);
    }
}

class Druid: Class {
     
    public Druid() {
        hitDiceMax = 8;
        className = "Druid";
        classDescription = "An embodiment of natures resilience, a druid claims no mastery over nature,\nbut instead sees themselves as an extension of natures will.";
    }

    public override void SetStats(Character character) {
        base.SetStats(character);
        int temp;
        character.wisdom += character.scores[5];
        character.constitution += character.scores[4];
        for (int i = 3; i >= 0; i--) {
            temp = character.randGen.Next(0, i+1);
            if (i == 3) {
                character.strength += character.scores[temp];
                character.scores.RemoveAt(temp);
            }
            else if (i == 2) {
                character.charisma += character.scores[temp];
                character.scores.RemoveAt(temp);
            }
            else if (i == 1) {
                character.intelligence += character.scores[temp];
                character.scores.RemoveAt(temp);
            }
            else if (i == 0) {
                character.dexterity += character.scores[temp];
                character.scores.RemoveAt(temp);
            }
        }
        SetHitPoints(character);
    }
}

class Fighter: Class {
     
    public Fighter() {
        hitDiceMax = 10;
        className = "Fighter";
        classDescription = "A warrior with unparalleled mastery with weapons and armor, possessing thorough\nknowledge of the art of combat, Fighters stand defiant in the face of death.";
    }

    public override void SetStats(Character character) {
        base.SetStats(character);
        int temp;
        if (character.random == 1) {
            character.strength += character.scores[5];
            character.random = character.randGen.Next(1,3);
            if (character.random == 1) {
                character.constitution += character.scores[4];
                character.intelligence += character.scores[3];
                for (int i = 2; i >= 0; i--) {
                    temp = character.randGen.Next(0, i+1);
                    if (i == 2) {
                        character.wisdom += character.scores[temp];
                        character.scores.RemoveAt(temp);
                    }
                    else if (i == 1) {
                        character.charisma += character.scores[temp];
                        character.scores.RemoveAt(temp);  
                    }
                    else if (i == 0) {
                        character.dexterity += character.scores[temp];
                        character.scores.RemoveAt(temp);
                    }
                }
            }
            else {
                character.intelligence += character.scores[4];
                character.constitution += character.scores[3];
                for (int i = 2; i >= 0; i--) {
                    temp = character.randGen.Next(0, i+1);
                    if (i == 2) {
                        character.wisdom += character.scores[temp];
                        character.scores.RemoveAt(temp);
                    }
                    else if (i == 1) {
                        character.charisma += character.scores[temp];
                        character.scores.RemoveAt(temp);
                    }
                    else if (i == 0) {
                        character.dexterity += character.scores[temp];
                        character.scores.RemoveAt(temp);
                    }
                }
            }
        }
        else {
            character.dexterity += character.scores[5];
            character.random = character.randGen.Next(1,3);
            if (character.random == 1) {
                character.constitution += character.scores[4];
                character.intelligence += character.scores[3];
                for (int i = 2; i >= 0; i--) {
                    temp = character.randGen.Next(0, i+1);
                    if (i == 2) {
                        character.wisdom += character.scores[temp];
                        character.scores.RemoveAt(temp);
                    }
                    else if (i == 1) {
                        character.charisma += character.scores[temp];
                        character.scores.RemoveAt(temp);
                    }
                    else if (i == 0) {
                        character.strength += character.scores[temp];
                        character.scores.RemoveAt(temp);
                    }
                }
            }
            else {
                character.intelligence += character.scores[4];
                character.constitution += character.scores[3];
                for (int i = 2; i >= 0; i--) {
                    temp = character.randGen.Next(0, i+1);
                    if (i == 2) {
                        character.wisdom = character.scores[temp];
                        character.scores.RemoveAt(temp);
                    }
                    else if (i == 1) {
                        character.charisma += character.scores[temp];
                        character.scores.RemoveAt(temp);
                    }
                    else if (i == 0) {
                        character.strength += character.scores[temp];
                        character.scores.RemoveAt(temp);
                    }
                }
            }
        }
        SetHitPoints(character);
    }
}

class Monk: Class {
     
    public Monk() {
        hitDiceMax = 8;
        className = "Monk";
        classDescription = "With the ability to harness the magical energy that flows within their bodies,\nMonks use this energy for frightening displays of strength and defensive ability.";
    }

    public override void SetStats(Character character) {
        base.SetStats(character);
        int temp;
        character.dexterity += character.scores[5];
        character.wisdom += character.scores[4];
        for (int i = 3; i >= 0; i--) {
            temp = character.randGen.Next(0, i+1);
            if (i == 3) {
                character.constitution += character.scores[temp];
                character.scores.RemoveAt(temp);
            }
            else if (i == 2) {
                character.strength += character.scores[temp];
                character.scores.RemoveAt(temp);
            }
            else if (i == 1) {
                character.intelligence += character.scores[temp];
                character.scores.RemoveAt(temp);
            }
            else if (i == 0) {
                character.charisma += character.scores[temp];
                character.scores.RemoveAt(temp);
            }
        }
        SetHitPoints(character);
    }
}

class Paladin: Class {
     
    public Paladin() {
        hitDiceMax = 10;
        className = "Paladin";
        classDescription = "tbd";
    }

    public override void SetStats(Character character) {
        base.SetStats(character);
        int temp;
        character.strength += character.scores[5];
        character.charisma += character.scores[4];
        for (int i = 3; i >= 0; i--) {
            temp = character.randGen.Next(0, i+1);
            if (i == 3) {
                character.constitution += character.scores[temp];
                character.scores.RemoveAt(temp);
            }
            else if (i == 2) {
                character.wisdom += character.scores[temp];
                character.scores.RemoveAt(temp);
            }
            else if (i == 1) {
                character.intelligence += character.scores[temp];
                character.scores.RemoveAt(temp);
            }
            else if (i == 0) {
                character.dexterity += character.scores[temp];
                character.scores.RemoveAt(temp);
            }
        }
        SetHitPoints(character);
    }
}

class Ranger: Class {
     
    public Ranger() {
        hitDiceMax = 10;
        className = "Ranger";
        classDescription = "tbd";
    }

    public override void SetStats(Character character) {
        base.SetStats(character);
        int temp;
        character.dexterity += character.scores[5];
        character.wisdom += character.scores[4];
        for (int i = 3; i >= 0; i--) {
            temp = character.randGen.Next(0, i+1);
            if (i == 3) {
                character.strength += character.scores[temp];
                character.scores.RemoveAt(temp);
            }
            else if (i == 2) {
                character.charisma += character.scores[temp];
                character.scores.RemoveAt(temp);
            }
            else if (i == 1) {
                character.intelligence = character.scores[temp];
                character.scores.RemoveAt(temp);
            }
            else if (i == 0) {
                character.constitution += character.scores[temp];
                character.scores.RemoveAt(temp);
            }
        }
        SetHitPoints(character);
    }
}

class Rogue: Class {
     
    public Rogue() {
        hitDiceMax = 8;
        className = "Rogue";
        classDescription = "tbd";
    }

    public override void SetStats(Character character) {
        base.SetStats(character);
        int temp;
        character.dexterity += character.scores[5];
        if (character.random == 1) {
            character.intelligence += character.scores[4];
            character.charisma += character.scores[3];
        }
        else {
            character.charisma += character.scores[4];
            character.intelligence += character.scores[3];
        }
        for (int i = 2; i >= 0; i--) {
            temp = character.randGen.Next(0, i+1);
            if (i == 2) {
                character.strength += character.scores[temp];
                character.scores.RemoveAt(temp);
            }
            else if (i == 1) {
                character.wisdom += character.scores[temp];
                character.scores.RemoveAt(temp);
            }
            else if (i == 0) {
                character.constitution += character.scores[temp];
                character.scores.RemoveAt(temp);
            }
        }
        SetHitPoints(character);
    }
}

class Sorcerer: Class {
     
    public Sorcerer() {
        hitDiceMax = 6;
        className = "Sorcerer";
        classDescription = "tbd";
    }

    public override void SetStats(Character character) {
        base.SetStats(character);
        int temp;
        character.charisma += character.scores[5];
        character.constitution += character.scores[4];
        for (int i = 3; i >= 0; i--) {
            temp = character.randGen.Next(0, i+1);
            if (i == 3) {
                character.strength += character.scores[temp];
                character.scores.RemoveAt(temp);
            }
            else if (i == 2) {
                character.wisdom += character.scores[temp];
                character.scores.RemoveAt(temp);
            }
            else if (i == 1) {
                character.intelligence += character.scores[temp];
                character.scores.RemoveAt(temp);
            }
            else if (i == 0) {
                character.dexterity += character.scores[temp];
                character.scores.RemoveAt(temp);
            }
        }
        SetHitPoints(character);
    }
}

class Warlock: Class {
     
    public Warlock() {
        hitDiceMax = 8;
        className = "Warlock";
        classDescription = "tbd";
    }

    public override void SetStats(Character character) {
        base.SetStats(character);
        int temp;
        character.charisma += character.scores[5];
        character.constitution += character.scores[4];
        for (int i = 3; i >= 0; i--) {
            temp = character.randGen.Next(0, i+1);
            if (i == 3) {
                character.strength += character.scores[temp];
                character.scores.RemoveAt(temp);
            }
            else if (i == 2) {
                character.wisdom += character.scores[temp];
                character.scores.RemoveAt(temp);
            }
            else if (i == 1) {
                character.intelligence += character.scores[temp];
            }
            else if (i == 0) {
                character.dexterity += character.scores[temp];
                character.scores.RemoveAt(temp);
            }
        }
        SetHitPoints(character);
    }
}

class Wizard: Class {
     
    public Wizard() {
        hitDiceMax = 6;
        className = "Wizard";
        classDescription = "tbd";

    }

    public override void SetStats(Character character) {
        base.SetStats(character);
        int temp;
        character.intelligence += character.scores[5];
        if (character.random == 1) {
            character.constitution += character.scores[4];
            character.dexterity += character.scores[3];
        }
        else {
            character.dexterity += character.scores[4];
            character.constitution += character.scores[3];
        }
        for (int i = 2; i >= 0; i--) {
            temp = character.randGen.Next(0, i+1);
            if (i == 2) {
                character.strength += character.scores[temp];
                character.scores.RemoveAt(temp);
            }
            else if (i == 1) {
                character.wisdom += character.scores[temp];
                character.scores.RemoveAt(temp);
            }
            else if (i == 0) {
                character.charisma += character.scores[temp];
                character.scores.RemoveAt(temp);
            }
        }
        SetHitPoints(character);
    }
}