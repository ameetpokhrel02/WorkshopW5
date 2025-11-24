// Create a ElectronicsStore object 
var store = new ElectronicsStore();

// Create Laptop and Smartphone objects with brand and price
var dellLaptop = new Laptop("Dell XPS 13", 1299.99);
var iphone = new Smartphone("Apple iPhone 15", 999.99);
var samsung = new Smartphone("Samsung S23", 799.99);

// Add them to the store 
store.AddDevice(dellLaptop);
store.AddDevice(iphone);
store.AddDevice(samsung);

// Call ShowAllDeviceDetails() to display info and child-specific behavior 
store.ShowAllDeviceDetails();