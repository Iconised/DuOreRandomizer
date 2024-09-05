﻿namespace Ore_Randomizer.Classes;


public static class OreRandomizer
{
    /// <summary>
    /// This function generates the ore file for each planet.
    /// </summary>
    /// <param name="planet"></param>
    public static void GenerateOrePool(this IIPlanet planet)
    {
        //function writes data to the file.
        void WriteData(string data)
        {
            File.AppendAllText(planet.FileName, data + "\r\n");
        }

        //function writes tile data
        void Poa(int tile, int amount)
        {
            File.AppendAllText(planet.FileName,
                tile != planet.NumberOfTiles
                    ? $"        \"{tile}\" : {amount},\r\n"
                    : $"        \"{tile}\" : {amount} \r\n");
        }

        //If the pool file exists delete it.
        if (File.Exists(planet.FileName))
            File.Delete(planet.FileName);

        //Start a new file
        File.WriteAllText(planet.FileName, "");

        //Generate a random seed
        var random = new Random();

        //Write opening brace
        WriteData("{");

        
        int oreIdx = 1;
        int maxOreIdx = planet.OnPlanetOres.Count;

        
        Console.WriteLine("Processing Planet: " + planet.GetType());
        //Foreach ore definition in the planets ore defs.
        foreach (var def in planet.OnPlanetOres)
        {
            Console.WriteLine("Processing Ore Type: " + def.OreType);
            WriteData($"    \"{def.OreType}\": {{");

            int tileId = 1;
            while (tileId <= planet.NumberOfTiles)
            {
                Console.WriteLine("Processing Tile: " + tileId);
                //If the ore chance is 100 percent than just pull a random in range and continue.
                if (def.ChanceOfHavingOre == 100)
                {
                    int oreAmount = random.Next(def.MinAmount, def.MaxAmount);
                    Poa(tileId, oreAmount);
                    tileId++;
                    continue;
                }

                //Now we handle runs.
                int rnd = random.Next(0, 100);
                //Do we have ore?
                if (rnd < def.ChanceOfHavingOre)
                {
                    if (def.MaxRun == 0) 
                        def.MaxRun = 1;

                    //how long is the run?
                    int run = random.Next(1, def.MaxRun);
                    
                    //for the next run tileid's lets give them the same ore.
                    for (int i = 0; i < run; i++)
                    {
                        
                        int oreAmount = random.Next(def.MinAmount, def.MaxAmount);
                        tileId += i;
                        if (tileId > planet.NumberOfTiles)
                            break;
                        Poa(tileId, oreAmount);
                    }

                    tileId++;
                }
                else
                {
                    Poa(tileId, 0);
                    tileId++;
                }
            }


            WriteData(oreIdx < maxOreIdx ? "    }," : "    }");
            oreIdx++;
        }

        WriteData("}");
    }
}