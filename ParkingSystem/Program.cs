using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String tot = Console.ReadLine();
            String tot2 = tot.Substring(tot.Length-1);
            String[] parking = new string[int.Parse(tot2)];

            while (true)
            {
                String perintah = Console.ReadLine();
                String[] splits = perintah.Split(' ');
                if (perintah == "exit") break;
                else if (splits[0] == "leave")
                {
                    String perintah2 = perintah.Substring(perintah.Length - 1);
                    int index = int.Parse(perintah2);
                    parking[index-1] = null;
                    Console.WriteLine("Slot number "+index+" is free");
                }
                else if (perintah == "status")
                {
                    Console.WriteLine("Slot\tNo.\tType\tRegistration No\tColour");
                    for(int i = 0; i < parking.Length; i++)
                    {
                        if (parking[i] != null)
                        {
                            String[] parts = parking[i].Split(' ');
                            Console.WriteLine((i + 1) + "\t" + parts[1] + "\t" + parts[3] + "\t" + parts[2]);
                        }
                            
                    }
                }
                else if (splits[0] == "type_of_vehicles")
                {
                    String[] parts = perintah.Split(' ');
                    if (parts[1] == "Motor")
                    {
                        Console.WriteLine("2");
                    }
                    else
                    {
                        Console.WriteLine("4");
                    }
                }
                else if (splits[0] == "park")
                {
                    Boolean status = false;
                    for (int i = 0; i < parking.Length; i++)
                    {
                        if (parking[i] == null)
                        {
                            parking[i] = perintah;
                            Console.WriteLine("Allocated slot number: " + (i + 1));
                            status = true;
                            break;
                        }
                    }
                    if (status == false) Console.WriteLine("Sorry, parking lot is full");
                }
                else if (splits[0] == "slot_numbers_for_vehicles_with_colour")
                {
                    List<String> result = new List<String>();
                    for (int i = 0; i < parking.Length; i++)
                    {
                        if (parking[i] != null)
                        {
                            String datas = parking[i];
                            String color = splits.Length > 1 ? splits[1] : "";
                            Boolean hasil = datas.Contains(color);
                            if (hasil)
                            {
                                String slot = (i + 1).ToString();
                                result.Add(slot);
                            }
                        }
                    }
                    String join = String.Join(", ", result);
                    Console.WriteLine(join);
                }
                else if (splits[0] == "slot_number_for_registration_number")
                {
                    List<String> result = new List<String>();
                    for (int i = 0; i < parking.Length; i++)
                    {
                        if (parking[i] != null)
                        {
                            String datas = parking[i];
                            String color = splits.Length > 1 ? splits[1] : "";
                            Boolean hasil = datas.Contains(color);
                            if (hasil)
                            {
                                String slot = (i + 1).ToString();
                                result.Add(slot);
                            }
                        }
                    }
                    if(result.Count == 0)
                    {
                        Console.WriteLine("Not found");
                    }
                    else
                    {
                        String join = String.Join(", ", result);
                        Console.WriteLine(join);
                    }
                    
                }
                else if (splits[0] == "registration_numbers_for_vehicles_with_colour")
                {
                    List<String> result = new List<String>();
                    for (int i = 0; i < parking.Length; i++)
                    {
                        if (parking[i] != null)
                        {
                            String datas = parking[i];
                            String color = splits.Length > 1 ? splits[1] : "";
                            Boolean hasil = datas.Contains(color);
                            if (hasil)
                            {
                                String[] parts = datas.Split(' ');
                                result.Add(parts[1]);
                            }
                        }
                    }
                    String join = String.Join(", ", result);
                    Console.WriteLine(join);
                }
                else if (splits[0] == "registration_numbers_for_vehicles_with_event_plate")
                {
                    List<String> result = new List<String>();
                    int total = 0;
                    for (int i = 0; i < parking.Length; i++)
                    {
                        if (parking[i] != null)
                        {
                            String datas = parking[i];
                            String color = splits.Length > 1 ? splits[1] : "";
                            Boolean hasil = datas.Contains(color);
                            if (hasil)
                            {
                                String[] parts = datas.Split(' ');
                                result.Add(parts[1]);
                                total++;
                            }
                        }
                    }
                    Console.WriteLine(result[0]+", " + result[total-1]);
                }
                else if (splits[0] == "registration_numbers_for_vehicles_with_ood_plate")
                {
                    List<String> result = new List<String>();
                    List<String> fix = new List<string>();
                    int total = 0;
                    for (int i = 0; i < parking.Length; i++)
                    {
                        if (parking[i] != null)
                        {
                            String datas = parking[i];
                            String color = splits.Length > 1 ? splits[1] : "";
                            Boolean hasil = datas.Contains(color);
                            if (hasil)
                            {
                                String[] parts = datas.Split(' ');
                                result.Add(parts[1]);
                                total++;
                            }
                        }
                    }
                    for(int i = 0; i < total; i++)
                    {
                        if(i>0 && i< total - 1)
                        {
                            fix.Add(result[i]);
                        }
                    }
                    String join = String.Join(", ", fix);
                    Console.WriteLine(join);
                }

            }
        }
    }
}
