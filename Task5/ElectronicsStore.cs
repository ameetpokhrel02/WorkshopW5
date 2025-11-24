using System.Collections.Generic;
    // 3. Create Store Class: ElectronicsStore [cite: 98, 99]
    public class ElectronicsStore
    { 
        // Maintain a list of ElectronicDevice objects (Polymorphism) [cite: 100]
        private List<ElectronicDevice> inventory = new List<ElectronicDevice>();

        // Method: AddDevice [cite: 101, 102]
        public void AddDevice(ElectronicDevice device)
        {
            inventory.Add(device);
            Console.WriteLine($"Store: Added {device.Brand} to inventory.");
        }

        // Method: RemoveDevice [cite: 101, 103]
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

        // Method: ShowAllDeviceDetails [cite: 104]
        public void ShowAllDeviceDetails()
        {
            Console.WriteLine("\n--- Inventory Details ---");
            if (inventory.Count == 0)
            {
                Console.WriteLine("The store is empty.");
                return;
            }

            foreach (var device in inventory)
            {
                // Call ShowInfo() for each device (Run-time Polymorphism) [cite: 104]
                device.ShowInfo(); 

                // Downcast and call child specific methods too [cite: 105]
                // 'as' operator attempts the cast and returns null if it fails, which is safe.
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