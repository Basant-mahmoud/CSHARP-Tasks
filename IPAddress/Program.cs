using System;
using System.IO;
using System.Numerics;

namespace IPAddressClassification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            int classA = 0, classB = 0, classC = 0, classD = 0, classE = 0, invalid = 0;

            for (int i = 0; i < t; i++)
            {
                string input = Console.ReadLine();
                string[] parts = input.Split('.');

                // Validate IP has exactly 4 parts
                if (parts.Length != 4)
                {
                    invalid++;
                    continue;
                }

                int[] octets = new int[4];
                bool isValid = true;

                for (int j = 0; j < 4; j++)
                {
                    if (!int.TryParse(parts[j], out octets[j]) || octets[j] < 0 || octets[j] > 255)
                    {
                        isValid = false;
                        break;
                    }
                }

                if (!isValid || octets[0] == 0 || octets[0] == 255)
                {
                    invalid++;
                    continue;
                }

                int first = octets[0];

                if (first >= 1 && first <= 127)
                    classA++;
                else if (first >= 128 && first <= 191)
                    classB++;
                else if (first >= 192 && first <= 223)
                    classC++;
                else if (first >= 224 && first <= 239)
                    classD++;
                else if (first >= 240 && first <= 254)
                    classE++;
                else
                    invalid++; // e.g., 255
            }

            // Final output
            Console.WriteLine($"class A-{classA}");
            Console.WriteLine($"class B-{classB}");
            Console.WriteLine($"class C-{classC}");
            Console.WriteLine($"class D-{classD}");
            Console.WriteLine($"class E-{classE}");
            Console.WriteLine($"invalid-{invalid}");
        }
    }
}



#include <iostream>
#include <sstream>
#include <vector>
using namespace std;

bool isValidIP(const vector<int>& parts)
{
    if (parts.size() != 4) return false;
    for (int part : parts)
    {
        if (part < 0 || part > 255) return false;
    }
    if (parts[0] == 0 || parts[0] == 255) return false;
    return true;
}

vector<int> parseIP(const string& ip)
{
    vector<int> parts;
    stringstream ss(ip);
    string segment;

    while (getline(ss, segment, '.'))
    {
        try
        {
            parts.push_back(stoi(segment));
        }
        catch (...) {
            parts.push_back(-1); // invalid part
        }
        }

        return parts;
    }

    int main()
    {
        int t;
        cin >> t;
        cin.ignore(); // Ignore newline after number

        int classA = 0, classB = 0, classC = 0, classD = 0, classE = 0, invalid = 0;

        while (t--)
        {
            string ip;
            getline(cin, ip);

            vector<int> parts = parseIP(ip);

            if (!isValidIP(parts))
            {
                invalid++;
                continue;
            }

            int first = parts[0];

            if (first >= 1 && first <= 127)
                classA++;
            else if (first >= 128 && first <= 191)
                classB++;
            else if (first >= 192 && first <= 223)
                classC++;
            else if (first >= 224 && first <= 239)
                classD++;
            else if (first >= 240 && first <= 254)
                classE++;
            else
                invalid++;
        }

        // Print result
        cout << "class A-" << classA << endl;
        cout << "class B-" << classB << endl;
        cout << "class C-" << classC << endl;
        cout << "class D-" << classD << endl;
        cout << "class E-" << classE << endl;
        cout << "invalid-" << invalid << endl;

        return 0;
    }
