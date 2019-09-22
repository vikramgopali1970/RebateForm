using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebateForm
{
    class FileOperations
    { 

        private const String datafile = "CS6326Asg2.txt";

        public FileOperations() { }

        private void CheckOrCreateFile()
        {
            if (!File.Exists(datafile))
            {
                File.Create(datafile);
            }
        }


        public void WriteToFile(Dictionary<int, Record> Data)
        {
            String delimiter = "\t";
            using (var writer = new StreamWriter(datafile))
            {
                foreach (KeyValuePair<int, Record> item in Data)
                {
                    Record rc = item.Value;
                    var line = string.Join(delimiter, rc.ToArray());
                    writer.WriteLine(line);
                }
            }
        }

        public Dictionary<int, Record> LoadFileData()
        {
            int count = 0;
            CheckOrCreateFile();
            Dictionary<int, Record> Data = new Dictionary<int, Record>();
            String[] dataVals = File.ReadAllLines(datafile);
            foreach (String data in dataVals)
            {
                String[] vals = data.Split('\t');
                Record rc = new Record(vals[0], vals[1], vals[2], vals[3], vals[4], vals[5],
                    vals[6], vals[7], vals[8], vals[9], vals[10], vals[11],
                    Convert.ToDateTime(vals[12]), Convert.ToDateTime(vals[13]),
                    Convert.ToDateTime(vals[14]), Convert.ToInt32(vals[15]));
                Data.Add(count++, rc);
            }
            return Data;
        }

    }
}
