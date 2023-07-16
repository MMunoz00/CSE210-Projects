class Race {
    public string race;
    public string subrace = null;

    public Race() {

    }

    public virtual void DisplayRace() {
        Console.WriteLine($"Race: {race}");
    }

    public virtual void UpdateStats(Character character) {

    }
}

class Dwarf: Race {
    
    public Dwarf() {
        race = "Dwarf";
    }

    public override void UpdateStats(Character character) {
        character.constitution += 2;
        character.speed = 25;
        character.hitpoints += 1;
    }
}

class HillDwarf: Dwarf {
    
    public HillDwarf() {
        subrace = "Hill Dwarf";
    }

    public override void DisplayRace() {
        base.DisplayRace();
        Console.WriteLine($"Subrace: {subrace}");
    }

    public override void UpdateStats(Character character) {
        base.UpdateStats(character);
        character.wisdom += 1;
    }
}

class MountainDwarf: Dwarf {
    
    public MountainDwarf() {
        subrace = "Mountain Dwarf";
    }

    public override void DisplayRace() {
        base.DisplayRace();
        Console.WriteLine($"Subrace: {subrace}");
    }

    public override void UpdateStats(Character character) {
        base.UpdateStats(character);
        character.strength += 2;
    }
}

class Dragonborn: Race {
    
    public Dragonborn() {
        race = "Dragonborn";
    }

    public override void UpdateStats(Character character) {
        character.strength += 2;
        character.charisma += 1;
        character.speed = 30;
    }
}

class Elf: Race {
    
    public Elf() {
        race = "Elf";
    }

    public override void UpdateStats(Character character) {
        character.dexterity += 2;
        character.speed = 30;
    }
}

class DarkElf: Elf {
    
    public DarkElf() {
        subrace = "Dark Elf";
    }

    public override void DisplayRace() {
        base.DisplayRace();
        Console.WriteLine($"Subrace: {subrace}");
    }

    public override void UpdateStats(Character character) {
        base.UpdateStats(character);
        character.charisma += 1;
    }
}

class HighElf: Elf {
    
    public HighElf() {
        subrace = "High Elf";
    }

    public override void DisplayRace() {
        base.DisplayRace();
        Console.WriteLine($"Subrace: {subrace}");
    }

    public override void UpdateStats(Character character) {
        base.UpdateStats(character);
        character.intelligence += 1;
    }
}

class WoodElf: Elf {
    
    public WoodElf() {
        subrace = "Wood Elf";
    }

    public override void DisplayRace() {
        base.DisplayRace();
        Console.WriteLine($"Subrace: {subrace}");
    }

    public override void UpdateStats(Character character) {
        base.UpdateStats(character);
        character.wisdom += 1;
        character.speed = 35;
    }
}

class Gnome: Race {
    
    public Gnome() {
        race = "Gnome";
    }

    public override void UpdateStats(Character character) {
        character.intelligence += 2;
        character.speed = 25;
    }
}

class ForestGnome: Gnome {
    
    public ForestGnome() {
        subrace = "Forest Gnome";
    }

    public override void DisplayRace() {
        base.DisplayRace();
        Console.WriteLine($"Subrace: {subrace}");
    }

    public override void UpdateStats(Character character) {
        base.UpdateStats(character);
        character.dexterity += 1;
    }
}

class RockGnome: Gnome {
    
    public RockGnome() {
        subrace = "Rock Gnome";
    }

    public override void DisplayRace() {
        base.DisplayRace();
        Console.WriteLine($"Subrace: {subrace}");
    }

    public override void UpdateStats(Character character) {
        base.UpdateStats(character);
        character.constitution += 1;
    }
}

class HalfElf: Race {
    
    public HalfElf() {
        race = "Half-Elf";
    }

    public int ChooseStats(Character character) {
        int choice;
        Console.WriteLine("Please select one of the following stats:");
        Console.WriteLine("\t1. Constitution");
        Console.WriteLine("\t2. Strength");
        Console.WriteLine("\t3. Dexterity");
        Console.WriteLine("\t4. Intelligence");
        Console.WriteLine("\t5. Wisdom");
        Console.WriteLine("\t0. Cancel Character Creation");
        choice = character.CheckValue(5);
        if (choice == 0) {
            character.EndProgram();
            return choice;
        }
        return choice;
    }

    public override void UpdateStats(Character character) {
        character.charisma += 2;
        character.speed = 30;
        Console.WriteLine("You are allowed to choose any two stats to increase by 1.");
        int stat = ChooseStats(character);
        for (int count = 0; count < 2; count++) {
            if (stat == 1) {
                character.constitution += 1;
                if (count < 1) {
                    stat = ChooseStats(character);
                }
                else {
                    stat = 0;
                }
                while (stat == 1) {
                    Console.WriteLine("Please choose a different stat");
                    stat = ChooseStats(character);
                }
            }
            else if (stat == 2) {
                character.strength += 1;
                if (count < 1) {
                    stat = ChooseStats(character);
                }
                else {
                    stat = 0;
                }
                while (stat == 2) {
                    Console.WriteLine("Please choose a different stat");
                    stat = ChooseStats(character);
                }
            }
            else if (stat == 3) {
                character.dexterity += 1;
                if (count < 1) {
                    stat = ChooseStats(character);
                }
                else {
                    stat = 0;
                }
                while (stat == 3) {
                    Console.WriteLine("Please choose a different stat");
                    stat = ChooseStats(character);
                }
            }
            else if (stat == 4) {
                character.intelligence += 1;
                if (count < 1) {
                    stat = ChooseStats(character);
                }
                else {
                    stat = 0;
                }
                while (stat == 4) {
                    Console.WriteLine("Please choose a different stat");
                    stat = ChooseStats(character);
                }
            }
            else if (stat == 5) {
                character.wisdom += 1;
                if (count < 1) {
                    stat = ChooseStats(character);
                }
                else {
                    stat = 0;
                }
                while (stat == 5) {
                    Console.WriteLine("Please choose a different stat");
                    stat = ChooseStats(character);
                }
            }
        }
    }
}

class Halfling: Race {
    
    public Halfling() {
        race = "Halfling";
    }

    public override void UpdateStats(Character character) {
        character.dexterity += 2;
        character.speed = 25;
    }
}

class LightfootHalfling: Halfling {
    
    public LightfootHalfling() {
        subrace = "Lightfoot Halfling";
    }

    public override void DisplayRace() {
        base.DisplayRace();
        Console.WriteLine($"Subrace: {subrace}");
    }

    public override void UpdateStats(Character character) {
        base.UpdateStats(character);
        character.charisma += 1;
    }
}

class StoutHalfling: Halfling {
    
    public StoutHalfling() {
        subrace = "Stout Halfling";
    }

    public override void DisplayRace() {
        base.DisplayRace();
        Console.WriteLine($"Subrace: {subrace}");
    }

    public override void UpdateStats(Character character) {
        base.UpdateStats(character);
        character.constitution += 1;
    }
}

class HalfOrc: Race {
    
    public HalfOrc() {
        race = "Half-Orc";
    }

    public override void UpdateStats(Character character) {
        character.strength += 2;
        character.constitution += 1;
        character.speed = 30;
    }
}

class Human: Race {
    
    public Human() {
        race = "Human";
    }

    public override void UpdateStats(Character character) {
        character.strength += 1;
        character.constitution += 1;
        character.dexterity += 1;
        character.intelligence += 1;
        character.wisdom += 1;
        character.charisma += 1;
        character.speed = 30;
    }
}

class Tiefling: Race {
    
    public Tiefling() {
        race = "Tiefling";
    }

    public override void UpdateStats(Character character) {
        character.intelligence += 1;
        character.charisma += 2;
        character.speed = 30;
    }
}