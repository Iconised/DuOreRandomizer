﻿using Ore_Randomizer.Classes;

namespace Ore_Randomizer.Planets;

public class ThadesAsteroid33 : Planet
{
    public ThadesAsteroid33()
    {
        FileName = "orepools-433.json";
        NumberOfTiles = 271; //This is a guess
        OnPlanetOres.Add(new PlanetOreDef(Ores.AluminiumOre, 50, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.CarbonOre, 50, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.IronOre, 50, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.SiliconOre, 50, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.ManganeseOre, 0, 100, 20, 3));
    }
}