using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace VetClinic
{
    class Clinic
    {
        public Clinic(int capacity)
        {
            this.Capacity = capacity;
            this.Data = new List<Pet>();
        }


        public int Capacity { get; set; }
        public List<Pet> Data { get; set; }
        public int Count
        {
            get
            {
                return Data.Count;
            }
        }
        
        public void Add(Pet pet)
        {
            if (Capacity > Data.Count)
            {
                Data.Add(pet);
            }
        }

        public bool Remove(string name)
        {
            foreach (var pet in Data)
            {
                if (pet.Name == name)
                {
                    Data.Remove(pet);
                    return true;
                }
            }
            return false;
        }

        public Pet GetPet(string name, string owner)
        {
            foreach (var pet in Data)
            {
                if (pet.Name == name && pet.Owner == owner)
                {
                    return pet;
                }
            }
            return null;
        }

        public Pet GetOldestPet()
        {
            int oldestAge = int.MinValue;
            Pet oldestPet = null;

            foreach (var pet in Data)
            {
                if (pet.Age > oldestAge)
                {
                    oldestAge = pet.Age;
                    oldestPet = pet;
                }
            }
            return oldestPet;
        }

        public string GetStatistics()
        {
            if (Data.Count > 0)
            {
                Console.WriteLine("The clinic has the following patients:");
                StringBuilder sb = new StringBuilder();
                foreach (var pet in Data)
                {
                    sb.AppendLine($"Pet {pet.Name} with owner: {pet.Owner}");
                }
                return sb.ToString();
            }
            return null;
        }
    }
}
