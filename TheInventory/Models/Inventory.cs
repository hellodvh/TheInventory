﻿using TheInventory.Services;

namespace TheInventory.Models
{
    public class Inventory
    {
        //MATERIALS
        public List<Material> Materials = new List<Material>();

        //PARTS
        public List<Part> Parts = new List<Part>();

        //VEHICLES
        public List<Vehicle> Vehicles = new List<Vehicle>();

        public Inventory()
        {
            //MATERIALS
            Materials = Database.GetAllMaterials();

            //PARTS
            Parts = Database.GetAllParts();

            //VEHICLES
            Vehicles = Database.GetAllVehicles();
        }

        public void UpdateCount(string name, int count)
        {
            //MATERIALS
            Database.UpdateMaterialCount(name, count);

            //PARTS
            Database.UpdatePartCount(name, count);

            //VEHICLES
            Database.UpdateVehicleCount(name, count);
        }

        //Function to Get Count
        public int GetMaterialCount(string name)
        {
            //MATERIAL
            foreach(var material in Materials)
            {
                if (material.Name == name)
                {
                    return material.Count;  
                } 
            }
            return -1; 
        }

        public int GetPartCount(string name)
        {
            //PARTS
            foreach (var part in Parts)
            {
                if (part.Name == name)
                {
                    return part.Count;
                }
            }
            return -1;
        }

        public int GetVehicleCount(string name)
        {
            //VEHICLES
            foreach (var vehicle in Vehicles)
            {
                if (vehicle.Name == name)
                {
                    return vehicle.Count;
                }
            }
            return -1;
        }
    }
}
