// See https://aka.ms/new-console-template for more information
using System.Text;

string oilWellPath = "oil-well.txt";
string gasStationPath = "gas-station.txt";

using FileStream oilWell = new FileStream(oilWellPath, FileMode.Open);
using FileStream gasStation = new FileStream(gasStationPath, FileMode.Create);
byte[] buffer = new byte[1024];
while (oilWell.Read(buffer, 0, buffer.Length) > 0)
{
    string rawOil = Encoding.UTF8.GetString(buffer);
    string processedGasoline = rawOil.Replace("Oil", "Gasoline");
    // Return the processed gasoline data
    buffer = Encoding.UTF8.GetBytes(processedGasoline);
    gasStation.Write(buffer, 0, buffer.Length);
}
