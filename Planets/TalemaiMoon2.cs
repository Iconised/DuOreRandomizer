﻿using Ore_Randomizer.Classes;

namespace Ore_Randomizer.Planets;

public class TalemaiMoon2 : Planet
{
    public TalemaiMoon2()
    {
        VoxelGeometryRadius = 12000.0;
        TerritoryTileSize = 500.0;
        FileName = "orepools-40.json";
        NumberOfTiles = 1921;
        OnPlanetOres.Add(new PlanetOreDef(Ores.AluminiumOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.CarbonOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.IronOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.SiliconOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.ChromiumOre, 10, 200, 20, 5));
        OnPlanetOres.Add(new PlanetOreDef(Ores.NiobiumOre, 10, 200, 7, 4));
    }
}