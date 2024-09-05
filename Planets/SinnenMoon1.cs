﻿using Ore_Randomizer.Classes;

namespace Ore_Randomizer.Planets;

public class SinnenMoon1 : Planet
{
    public SinnenMoon1()
    {
        FileName = "orepools-70.json";
        NumberOfTiles = 4321;
        OnPlanetOres.Add(new PlanetOreDef(Ores.AluminiumOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.CarbonOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.IronOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.SiliconOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.ChromiumOre, 10, 200, 30, 5));
        OnPlanetOres.Add(new PlanetOreDef(Ores.NiobiumOre, 10, 200, 30, 6));
    }
}