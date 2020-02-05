using System;
using System.Collections;

namespace DataValue
{
    class DataValue
    {
        string name;
        object data;
        public DataValue(string name, object data)
        {
            this.name = name;
            this.data = data;
        }
        public string Name
        {
            get
            {
                return(name);
            }
            set
            {
                name = value;
            }
        }
        public object Data
        {
            get
            {
                return (data);
            }
            set
            {
                data = value;
            }
        }
    }

    class DataRow
    {
        ArrayList row;
        public DataRow()
        {
            row = new ArrayList();
        }
        public void Load()
        {
            row.Add(new DataValue("Id", 5551212));
            row.Add(new DataValue("Name", "Fred"));
            row.Add(new DataValue("Salary", 2355.23M));
        }
        public object this[int column]
        {
            get
            {
                return (row[column]);
            }
            set
            {
                row[column] = value;
            }
        }
        private int findColumn(string name)
        {
            for(int index=0; index<row.Count; index++)
            {
                DataValue dataValue = (DataValue) row[index];
                if (dataValue.Name == name)
                    return (index);
            }
            return (-1);
        }
        public object this[string name]
        {
            get
            {
                return this[findColumn(name)];
            }
            set
            {
                this[findColumn(name)] = value;
            }
        }
    }



    class Demo
    {
        public static void Main(string[] args)
        {
            DataRow row = new DataRow();
            row.Load();
            DataValue val = (DataValue) row[0];
            Console.WriteLine("Column 0: {0}", val.Data);
            val.Data = 12; //set the ID
            DataValue valId = (DataValue)row["Id"];
            Console.WriteLine("Id: {0}", valId.Data);
            Console.WriteLine("Salary: {0}", ((DataValue) row["Salary"]).Data);
            ((DataValue)row["Name"]).Data = "Barney"; // set the name
            Console.WriteLine("Name: {0}", ((DataValue) row["Name"]).Data);
        }
    }
}
