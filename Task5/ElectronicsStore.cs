using System.Collections.Generic;
    // 3. Create Store Class: ElectronicsStore 
    public class ElectronicsStore
    { 
        // Maintain a list of ElectronicDevice objects
        private List<ElectronicDevice> inventory = new List<ElectronicDevice>();

        // Method: AddDevice
        public void AddDevice(ElectronicDevice device)
        {
            inventory.Add(device);
            Console.WriteLine($"Store: Added {device.Brand} to inventory.");
        }

        // Method: RemoveDevice
        public void RemoveDevice(ElectronicDevice device)
        {
            if (inventory.Remove(device))
            {
                Console.WriteLine($"Store: Removed {device.Brand} from inventory.");
            }
            else
            {
                Console.WriteLine("Store: Device not found.");
            }
        }

        // Method: ShowAllDeviceDetails 
        public void ShowAllDeviceDetails()
        {
            Console.WriteLine("Inventory Details");
            if (inventory.Count == 0)
            {
                Console.WriteLine("The store is empty.");
                return;
            }

            foreach (var device in inventory)
            {
                // Call ShowInfo() for each device (Run-time Polymorphism) [cite: 104]
                device.ShowInfo(); 
                
                if (device is Laptop laptop) // Check if the device is a Laptop
                {
                    laptop.TurnOnBattery(); 
                }
                else if (device is Smartphone smartphone) // Check if the device is a Smartphone
                {
                    smartphone.EnableCamera();
                }
            }
        }
    }