using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VierGewinntHost
{
    class FileManager
    {
        string path;
        StreamWriter writer;
        StreamReader reader;
        string[] lines = new string[6];
        int[,] field = new int[6, 7]
        {
            {0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0}
        };

        public FileManager()
        {
            path = @"T:\Klasse e2fs1\SAEL\VierGewinnt\info.vgw";
            writer = new StreamWriter(path);
            reader = new StreamReader(path);
            initFile();
        }

        private void initFile()
        {
            for (int r = 0; r < 6; r++)
            {
                for (int c = 0; c < 7; c++)
                {
                    lines[r] += "0";
                }
            }
            File.WriteAllLines(path, lines);
        }

        public 

        private string getField(int col, int row)
        {
            return field[col, row];
        }

        private write

        private string User(int i)
        {
            if (i == 0) return "A";
            else return "B";
        }

        public void insertIn(int line, int user)
        {
            lines = File.ReadAllLines(path).ToArray();
            lines[line] += ":" + User(user);
            File.WriteAllLines(path, lines);
        }

        public string get(int line)
        {
            return lines[line];
        }
    }
}
