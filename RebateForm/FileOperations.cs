using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebateForm
{
    public partial class RebateForm
    {
        private const String datafile = "CS6326Asg2.txt";

        private void CheckOrCreateFile()
        {
            if (!File.Exists(datafile))
            {
                File.Create(datafile);
            }
        }


        private void WriteToFile()
        {
            String delimiter = "\t";
            using (var writer = new StreamWriter(datafile))
            {
                foreach (KeyValuePair<int, Record> item in this.Data)
                {
                    Record rc = item.Value;
                    var line = string.Join(delimiter, rc.ToArray());
                    writer.WriteLine(line);
                }
            }
        }

        private void LoadFileData()
        {
            int count = 0;
            CheckOrCreateFile();
            String[] dataVals = File.ReadAllLines(datafile);
            foreach (String data in dataVals)
            {
                String[] vals = data.Split('\t');
                Record rc = new Record(vals[0], vals[1].ToCharArray()[0], vals[2], vals[3], vals[4], vals[5],
                    vals[6], vals[7], vals[8].ToCharArray()[0], vals[9], vals[10], Boolean.Parse(vals[11]),
                    Convert.ToDateTime(vals[12]), Convert.ToDateTime(vals[13]),
                    Convert.ToDateTime(vals[14]), Convert.ToInt32(vals[15]));
                this.Data.Add(count, rc);
                this.Set.Add(rc);
                this.AddItemToList(rc, count++);
            }
        }

    }
}
