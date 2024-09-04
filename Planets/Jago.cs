﻿using Ore_Randomizer.Classes;

namespace Ore_Randomizer.Planets;

public class Jago : Planet
{
    public Jago()
    {
        FileName = "orepools-9.json";
        NumberOfTiles = 60751;
        OnPlanetOres.Add(new PlanetOreDef(Ores.AluminiumOre, 50, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.CarbonOre, 50, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.IronOre, 50, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.SiliconOre, 50, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.SilverOre, 0, 200, 50, 7));
        OnPlanetOres.Add(new PlanetOreDef(Ores.CobaltOre, 0, 200, 30, 8));
        OnPlanetOres.Add(new PlanetOreDef(Ores.TitaniumOre, 0, 200, 10, 5));
    }
}