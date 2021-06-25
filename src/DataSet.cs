using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic.FileIO;

namespace AreaSearch
{
    public class DataSet : IDataSet
    {
        public static List<DataPoint> ReadDataPoints(string filename) {
            List<DataPoint> datapoints = new List<DataPoint>();
            try
            {
                string currentDir = System.IO.Directory.GetCurrentDirectory();
                using TextFieldParser csv = new TextFieldParser(filename);
                csv.SetDelimiters(new string[] {";"});
                csv.HasFieldsEnclosedInQuotes = false;

                while (!csv.EndOfData)
                {
                    string[] points = csv.ReadFields();
                    datapoints.Add(points.Select(p => new DataPoint(float.Parse(points[0]), float.Parse(points[1]))).First());
                }
            }
            catch (System.Exception e)
            {
                throw new System.IO.IOException();
            }

            return datapoints;
        }
    }
}