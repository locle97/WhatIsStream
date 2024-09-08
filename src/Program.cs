using System.Text;

// Declare paths of well and water tank
string wellPath = "well.txt";
string waterTankPath = "water-tank.txt";

// Well of water is like a source of water stream is flowing
using FileStream well = new FileStream(wellPath, FileMode.Open);

// Water tank is like a destination where water is stored
using FileStream waterTank = new FileStream(waterTankPath, FileMode.Create);

// Buffer is like a bucket that carries water from well to water tank
byte[] buffer = new byte[2048];

// Read water from well and write to water tank
// Using buffer to carry water from well to water tank
while (well.Read(buffer, 0, buffer.Length) > 0)
{
    // Get pure water from bucket
    string pureWater = Encoding.UTF8.GetString(buffer);

    // Processed water is like a water with minerals
    string processedWater = pureWater.Replace("Water", "Water with minerals");

    // Store processed water in bucket
    buffer = Encoding.UTF8.GetBytes(processedWater);

    // Write processed water to water tank
    waterTank.Write(buffer, 0, buffer.Length);
}
