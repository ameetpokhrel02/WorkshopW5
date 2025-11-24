// --- Task 5 Demonstration: Complete OOP Scenario ---
Console.WriteLine("\n\n--- Task 5: Complete OOP Scenario (Electronics Store) ---");

// 4. Create a ElectronicsStore object [cite: 113]
var store = new ElectronicsStore();

// 4. Create Laptop and Smartphone objects with brand and price [cite: 114]
var dellLaptop = new Laptop("Dell XPS 13", 1299.99);
var iphone = new Smartphone("Apple iPhone 15", 999.99);
var samsung = new Smartphone("Samsung S23", 799.99);

// 4. Add them to the store [cite: 115]
store.AddDevice(dellLaptop);
store.AddDevice(iphone);
store.AddDevice(samsung);

// 4. Call ShowAllDeviceDetails() to display info and child-specific behavior [cite: 116]
store.ShowAllDeviceDetails();