class Race: Character {
    protected string race;
    protected string raceDescription;

    public Race() {

    }

    public virtual void DisplayRace() {
        Console.WriteLine($"Race: {race}");
        Console.WriteLine($"Description:\n{raceDescription}");
    }

    public virtual void UpdateStats() {

    }
}

class Dwarf: Race {
    
    public Dwarf() {
        race = "Dwarf";
        raceDescription = "";
    }

    public override void UpdateStats() {

    }
}

class HillDwarf: Dwarf {
    protected string subrace;
    protected string subraceDescription;
    
    public HillDwarf() {
        subrace = "Hill Dwarf";
        subraceDescription = "";
    }

    public override void DisplayRace() {
        base.DisplayRace();
        Console.WriteLine($"Subrace: {subrace}");
        Console.WriteLine($"Description:\n{subraceDescription}");
    }

    public override void UpdateStats() {

    }
}

class MountainDwarf: Dwarf {
    protected string subrace;
    protected string subraceDescription;
    
    public MountainDwarf() {
        subrace = "Mountain Dwarf";
        subraceDescription = "";
    }

    public override void DisplayRace() {
        base.DisplayRace();
        Console.WriteLine($"Subrace: {subrace}");
        Console.WriteLine($"Description:\n{subraceDescription}");
    }

    public override void UpdateStats() {

    }
}

class Dragonborn: Race {
    
    public Dragonborn() {
        race = "Dragonborn";
        raceDescription = "";
    }

    public override void UpdateStats() {

    }
}

class Elf: Race {
    
    public Elf() {
        race = "Elf";
        raceDescription = "";
    }

    public override void UpdateStats() {

    }
}

class DarkElf: Elf {
    protected string subrace;
    protected string subraceDescription;
    
    public DarkElf() {
        subrace = "Dark Elf";
        subraceDescription = "";
    }

    public override void DisplayRace() {
        base.DisplayRace();
        Console.WriteLine($"Subrace: {subrace}");
        Console.WriteLine($"Description:\n{subraceDescription}");
    }

    public override void UpdateStats() {

    }
}

class HighElf: Elf {
    protected string subrace;
    protected string subraceDescription;
    
    public HighElf() {
        subrace = "High Elf";
        subraceDescription = "";
    }

    public override void DisplayRace() {
        base.DisplayRace();
        Console.WriteLine($"Subrace: {subrace}");
        Console.WriteLine($"Description:\n{subraceDescription}");
    }

    public override void UpdateStats() {

    }
}

class WoodElf: Elf {
    protected string subrace;
    protected string subraceDescription;
    
    public WoodElf() {
        subrace = "Wood Elf";
        subraceDescription = "";
    }

    public override void DisplayRace() {
        base.DisplayRace();
        Console.WriteLine($"Subrace: {subrace}");
        Console.WriteLine($"Description:\n{subraceDescription}");
    }

    public override void UpdateStats() {

    }
}

class Gnome: Race {
    
    public Gnome() {
        race = "Gnome";
        raceDescription = "";
    }

    public override void UpdateStats() {

    }
}

class ForestGnome: Gnome {
    protected string subrace;
    protected string subraceDescription;
    
    public ForestGnome() {
        subrace = "Forest Gnome";
        subraceDescription = "";
    }

    public override void DisplayRace() {
        base.DisplayRace();
        Console.WriteLine($"Subrace: {subrace}");
        Console.WriteLine($"Description:\n{subraceDescription}");
    }

    public override void UpdateStats() {

    }
}

class RockGnome: Gnome {
    protected string subrace;
    protected string subraceDescription;
    
    public RockGnome() {
        subrace = "Rock Gnome";
        subraceDescription = "";
    }

    public override void DisplayRace() {
        base.DisplayRace();
        Console.WriteLine($"Subrace: {subrace}");
        Console.WriteLine($"Description:\n{subraceDescription}");
    }

    public override void UpdateStats() {

    }
}

class HalfElf: Race {
    
    public HalfElf() {
        race = "Half-Elf";
        raceDescription = "";
    }

    public override void UpdateStats() {

    }
}

class Halfling: Race {
    
    public Halfling() {
        race = "Halfling";
        raceDescription = "";
    }

    public override void UpdateStats() {

    }
}

class LightfootHalfling: Halfling {
    protected string subrace;
    protected string subraceDescription;
    
    public LightfootHalfling() {
        subrace = "Lightfoot Halfling";
        subraceDescription = "";
    }

    public override void DisplayRace() {
        base.DisplayRace();
        Console.WriteLine($"Subrace: {subrace}");
        Console.WriteLine($"Description:\n{subraceDescription}");
    }

    public override void UpdateStats() {

    }
}

class StoutHalfling: Halfling {
    protected string subrace;
    protected string subraceDescription;
    
    public StoutHalfling() {
        subrace = "Stout Halfling";
        subraceDescription = "";
    }

    public override void DisplayRace() {
        base.DisplayRace();
        Console.WriteLine($"Subrace: {subrace}");
        Console.WriteLine($"Description:\n{subraceDescription}");
    }

    public override void UpdateStats() {

    }
}

class HalfOrc: Race {
    
    public HalfOrc() {
        race = "Half-Orc";
        raceDescription = "";
    }

    public override void UpdateStats() {

    }
}

class Human: Race {
    
    public Human() {
        race = "Human";
        raceDescription = "";
    }

    public override void UpdateStats() {

    }
}

class Tiefling: Race {
    
    public Tiefling() {
        race = "Tiefling";
        raceDescription = "";
    }

    public override void UpdateStats() {

    }
}